// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NuGet.Configuration;
using NuGet.Frameworks;
using NuGet.ProjectModel;
using NuGet.Test.Utility;
using Xunit;

namespace NuGet.Commands.Test
{
    public class PackagesWithRelatedFilesTests
    {
        [Theory]
        [InlineData(".exe", "X", new[] { ".config.json", ".pdb", ".xml" })]
        [InlineData(".dll", "Test.X", new string[] { })]
        [InlineData(".winmd", "NuGet.Test.X", new[] { ".pdb", ".some.random.extension", ".xml" })]
        public async Task RelatedProperty_TopLevelPackageWithDifferentExtensions_RelatedPropertyAddedSuccessfully(string assemblyExtension, string assemblyName, string[] relatedExtensionList)
        {
            // Arrange
            using (var pathContext = new SimpleTestPathContext())
            {
                var framework = "net5.0";
                // A -> packaegX
                var projectA = SimpleTestProjectContext.CreateNETCoreWithSDK(
                    "A",
                    pathContext.SolutionRoot,
                    framework);

                var packageX = new SimpleTestPackageContext("packageX", "1.0.0");
                packageX.Files.Clear();

                packageX.AddFile($"lib/net5.0/{assemblyName}{assemblyExtension}");
                foreach (string relatedExtension in relatedExtensionList)
                {
                    packageX.AddFile($"lib/net5.0/{assemblyName}{relatedExtension}");
                }

                await SimpleTestPackageUtility.CreatePackagesAsync(pathContext.PackageSource, packageX);
                projectA.AddPackageToAllFrameworks(packageX);

                var sources = new List<PackageSource>();
                sources.Add(new PackageSource(pathContext.PackageSource));
                projectA.Sources = sources;
                projectA.FallbackFolders = new List<string>();
                projectA.FallbackFolders.Add(pathContext.FallbackFolder);
                projectA.GlobalPackagesFolder = pathContext.UserPackagesFolder;

                var logger = new TestLogger();
                var request = new TestRestoreRequest(projectA.PackageSpec, projectA.Sources, pathContext.UserPackagesFolder, logger)
                {
                    LockFilePath = projectA.AssetsFileOutputPath
                };

                // Act
                var command = new RestoreCommand(request);
                var result = await command.ExecuteAsync();
                await result.CommitAsync(logger, CancellationToken.None);

                // Asert
                Assert.True(result.Success);
                var assetsFile = projectA.AssetsFile;
                Assert.NotNull(assetsFile);

                var targets = assetsFile.GetTarget(NuGetFramework.Parse(framework), null);
                var lib = targets.Libraries.Single();
                var compileAssemblies = lib.CompileTimeAssemblies;
                var runtimeAssemblies = lib.RuntimeAssemblies;

                string expectedRelatedProperty = null;
                if (relatedExtensionList.Any())
                {
                    expectedRelatedProperty = string.Join(";", relatedExtensionList);
                }

                // Compile, "related" property is applied.
                AssertRelatedProperty(compileAssemblies, $"lib/net5.0/{assemblyName}{assemblyExtension}", expectedRelatedProperty);

                // Runtime, "related" property is applied.
                AssertRelatedProperty(runtimeAssemblies, $"lib/net5.0/{assemblyName}{assemblyExtension}", expectedRelatedProperty);
            }
        }

        [Fact]
        public async Task RelatedProperty_TopLevelPackageWithMultipleAssets_RelatedPropertyAppliedOnCompileRuntimeEmbedOnly()
        {
            // Arrange
            using (var pathContext = new SimpleTestPathContext())
            {
                var framework = "net5.0";
                // A -> packaegX
                var projectA = SimpleTestProjectContext.CreateNETCoreWithSDK(
                    "A",
                    pathContext.SolutionRoot,
                    framework);

                var packageX = new SimpleTestPackageContext("packageX", "1.0.0");
                packageX.Files.Clear();
                // Compile
                packageX.AddFile("ref/net5.0/X.dll");
                packageX.AddFile("ref/net5.0/X.xml");
                // Runtime
                packageX.AddFile("lib/net5.0/X.dll");
                packageX.AddFile("lib/net5.0/X.xml");
                // Embed
                packageX.AddFile("embed/net5.0/X.dll");
                packageX.AddFile("embed/net5.0/X.xml");
                // Resources
                packageX.AddFile("lib/net5.0/en-US/X.resources.dll");
                packageX.AddFile("lib/net5.0/en-US/X.resources.xml");

                await SimpleTestPackageUtility.CreatePackagesAsync(pathContext.PackageSource, packageX);
                projectA.AddPackageToAllFrameworks(packageX);

                var sources = new List<PackageSource>();
                sources.Add(new PackageSource(pathContext.PackageSource));
                projectA.Sources = sources;
                projectA.FallbackFolders = new List<string>();
                projectA.FallbackFolders.Add(pathContext.FallbackFolder);
                projectA.GlobalPackagesFolder = pathContext.UserPackagesFolder;

                var logger = new TestLogger();
                var request = new TestRestoreRequest(projectA.PackageSpec, projectA.Sources, pathContext.UserPackagesFolder, logger)
                {
                    LockFilePath = projectA.AssetsFileOutputPath
                };

                // Act
                var command = new RestoreCommand(request);
                var result = await command.ExecuteAsync();
                await result.CommitAsync(logger, CancellationToken.None);

                // Asert
                Assert.True(result.Success);
                var assetsFile = projectA.AssetsFile;
                Assert.NotNull(assetsFile);

                var targets = assetsFile.GetTarget(NuGetFramework.Parse(framework), null);
                var lib = targets.Libraries.Single();

                // Compile, "related" property is applied.
                var compileAssemblies = lib.CompileTimeAssemblies;
                AssertRelatedProperty(compileAssemblies, "ref/net5.0/X.dll", ".xml");

                // Runtime, "related" property is applied.
                var runtimeAssemblies = lib.RuntimeAssemblies;
                AssertRelatedProperty(runtimeAssemblies, "lib/net5.0/X.dll", ".xml");

                // Embed, "related" property is applied.
                var embedAssemblies = lib.EmbedAssemblies;
                AssertRelatedProperty(embedAssemblies, "embed/net5.0/X.dll", ".xml");

                // Resources, "related" property is NOT applied.
                var resourceAssemblies = lib.ResourceAssemblies;
                AssertRelatedProperty(resourceAssemblies, "lib/net5.0/en-US/X.resources.dll", null);
            }
        }

        [Fact]
        public async Task RelatedProperty_TransitivePackageReferenceWithMultipleAssets_RelatedPropertyAppliedOnCompileRuntimeEmbedOnly()
        {
            // Arrange
            using (var pathContext = new SimpleTestPathContext())
            {
                var framework = "net5.0";
                // A -> packageX -> packageY
                var projectA = SimpleTestProjectContext.CreateNETCoreWithSDK(
                    "A",
                    pathContext.SolutionRoot,
                    framework);

                var packageX = new SimpleTestPackageContext("packageX", "1.0.0");
                packageX.Files.Clear();
                packageX.AddFile($"lib/net5.0/X.dll");

                var packageY = new SimpleTestPackageContext("packageY", "1.0.0");
                packageY.Files.Clear();
                // Compile
                packageY.AddFile("ref/net5.0/Y.dll");
                packageY.AddFile("ref/net5.0/Y.xml");
                // Runtime
                packageY.AddFile("lib/net5.0/Y.dll");
                packageY.AddFile("lib/net5.0/Y.xml");
                // Embed
                packageY.AddFile("embed/net5.0/Y.dll");
                packageY.AddFile("embed/net5.0/Y.xml");
                // Resources
                packageY.AddFile("lib/net5.0/en-US/Y.resources.dll");
                packageY.AddFile("lib/net5.0/en-US/Y.resources.xml");

                packageX.Dependencies.Add(packageY);

                await SimpleTestPackageUtility.CreatePackagesAsync(pathContext.PackageSource, packageX, packageY);
                projectA.AddPackageToAllFrameworks(packageX);

                var sources = new List<PackageSource>();
                sources.Add(new PackageSource(pathContext.PackageSource));
                projectA.Sources = sources;
                projectA.FallbackFolders = new List<string>();
                projectA.FallbackFolders.Add(pathContext.FallbackFolder);
                projectA.GlobalPackagesFolder = pathContext.UserPackagesFolder;

                var logger = new TestLogger();
                var request = new TestRestoreRequest(projectA.PackageSpec, projectA.Sources, pathContext.UserPackagesFolder, logger)
                {
                    LockFilePath = projectA.AssetsFileOutputPath
                };

                // Act
                var command = new RestoreCommand(request);
                var result = await command.ExecuteAsync();
                await result.CommitAsync(logger, CancellationToken.None);

                // Asert
                Assert.True(result.Success);
                var assetsFile = projectA.AssetsFile;
                Assert.NotNull(assetsFile);

                var targets = assetsFile.GetTarget(NuGetFramework.Parse(framework), null);

                var libX = targets.Libraries.Single(i => i.Name.Equals("packageX"));
                var runtimeAssembliesX = libX.RuntimeAssemblies;
                AssertRelatedProperty(runtimeAssembliesX, $"lib/net5.0/X.dll", null);

                var libY = targets.Libraries.Single(i => i.Name.Equals("packageY"));

                // Compile, "related" property is applied.
                var compileAssembliesY = libY.CompileTimeAssemblies;
                AssertRelatedProperty(compileAssembliesY, $"ref/net5.0/Y.dll", ".xml");

                // Runtime, "related" property is applied.
                var runtimeAssembliesY = libY.RuntimeAssemblies;
                AssertRelatedProperty(runtimeAssembliesY, $"lib/net5.0/Y.dll", ".xml");

                // Embed, "related" property is applied.
                var embedAssembliesY = libY.EmbedAssemblies;
                AssertRelatedProperty(embedAssembliesY, $"embed/net5.0/Y.dll", ".xml");

                // Resources, "related" property is NOT applied.
                var resourceAssembliesY = libY.ResourceAssemblies;
                AssertRelatedProperty(resourceAssembliesY, "lib/net5.0/en-US/Y.resources.dll", null);
            }
        }

        [Fact]
        public async Task RelatedProperty_ProjectReferenceWithCompileAssets_RelatedPropertyNOTAppliedOnCompile()
        {
            // Arrange
            using (var pathContext = new SimpleTestPathContext())
            {
                var framework = "net5.0";
                // A -> B
                // Set up solution, project
                var solution = new SimpleTestSolutionContext(pathContext.SolutionRoot);

                var projectA = SimpleTestProjectContext.CreateNETCore(
                    "A",
                    pathContext.SolutionRoot,
                    framework);

                var projectB = SimpleTestProjectContext.CreateNETCore(
                    "B",
                    pathContext.SolutionRoot,
                    framework);
                // Make sure projectB has a .pdb file
                projectB.Properties.Add("Configuration", "Debug");

                projectA.AddProjectToAllFrameworks(projectB);
                solution.Projects.Add(projectA);
                solution.Projects.Add(projectB);
                solution.Create(pathContext.SolutionRoot);

                var sources = new List<PackageSource>();
                sources.Add(new PackageSource(pathContext.PackageSource));
                projectA.Sources = sources;
                projectA.FallbackFolders = new List<string>();
                projectA.FallbackFolders.Add(pathContext.FallbackFolder);
                projectA.GlobalPackagesFolder = pathContext.UserPackagesFolder;

                var logger = new TestLogger();
                var request = new TestRestoreRequest(projectA.PackageSpec, projectA.Sources, pathContext.UserPackagesFolder, logger)
                {
                    LockFilePath = projectA.AssetsFileOutputPath
                };

                // Act
                var command = new RestoreCommand(request);
                var result = await command.ExecuteAsync();
                await result.CommitAsync(logger, CancellationToken.None);

                // Asert
                Assert.True(result.Success);
                var assetsFile = projectA.AssetsFile;
                Assert.NotNull(assetsFile);

                var targets = assetsFile.GetTarget(NuGetFramework.Parse(framework), null);
                var lib = targets.Libraries.Single();

                // Compile, "related" property is applied.
                var compileAssemblies = lib.CompileTimeAssemblies;
                AssertRelatedProperty(compileAssemblies, $"ref/net5.0/X.dll", ".xml");

                // Runtime, "related" property is applied.
                var runtimeAssemblies = lib.RuntimeAssemblies;
                AssertRelatedProperty(runtimeAssemblies, $"lib/net5.0/X.dll", ".xml");

                // Embed, "related" property is applied.
                var embedAssemblies = lib.EmbedAssemblies;
                AssertRelatedProperty(embedAssemblies, $"embed/net5.0/X.dll", ".xml");

                // Resources, "related" property is NOT applied.
                var resourceAssemblies = lib.ResourceAssemblies;
                AssertRelatedProperty(resourceAssemblies, "lib/net5.0/en-US/X.resources.dll", null);
            }
        }

        [Fact]
        public async Task RelatedProperty_NativePakcage_RelatedPropertyNOTAppliedOnCompile()
        {
            //// Arrange
            //using (var pathContext = new SimpleTestPathContext())
            //{
            //    // Set-up packages
            //    var packageX = new SimpleTestPackageContext("x", "1.0.0");
            //    packageX.AddFile("build/native/x.targets");
            //    packageX.AddFile("lib/native/x.dll");
            //    packageX.AddFile("lib/native/x.h");
            //    await SimpleTestPackageUtility.CreateFolderFeedV3Async(
            //        pathContext.PackageSource,
            //        packageX);
            //    // Set up project
            //    var solution = new SimpleTestSolutionContext(pathContext.SolutionRoot);
            //    var framework = NuGetFramework.Parse("net5.0-windows7.0");
            //    var projectA = SimpleTestProjectContext.CreateNETCore("projectName", pathContext.SolutionRoot, framework);
            //    projectA.Properties.Add("CLRSupport", "NetCore");
            //    //update path to vcxproj
            //    projectA.ProjectPath = Path.Combine(Path.GetDirectoryName(projectA.ProjectPath), projectA.ProjectName + ".vcxproj");
            //    projectA.AddPackageToAllFrameworks(packageX);
            //    solution.Projects.Add(projectA);
            //    solution.Create(pathContext.SolutionRoot);
            //    // Act
            //    var result = _msbuildFixture.RunMsBuild(pathContext.WorkingDirectory, $"/t:restore {pathContext.SolutionRoot}");

            //    // Assert
            //    result.Success.Should().BeTrue(because: result.AllOutput);
            //    File.Exists(projectA.AssetsFileOutputPath).Should().BeTrue(because: result.AllOutput);
            //    File.Exists(projectA.TargetsOutput).Should().BeTrue(because: result.AllOutput);
            //    File.Exists(projectA.PropsOutput).Should().BeTrue(because: result.AllOutput);

            //    var targetsSection = projectA.AssetsFile.Targets.First(e => string.IsNullOrEmpty(e.RuntimeIdentifier));
            //    targetsSection.Libraries.Should().Contain(e => e.Name.Equals("x"), because: string.Join(",", targetsSection.Libraries));
            //    var lockFileTargetLibrary = targetsSection.Libraries.First(e => e.Name.Equals("x"));
            //    lockFileTargetLibrary.CompileTimeAssemblies.Should().Contain("lib/native/x.dll");
            //    lockFileTargetLibrary.Build.Should().Contain("build/native/x.targets");
            //}
        }

        //[Fact]
        //public async Task RelatedProperty_DotnetToolPakcage_RelatedPropertyNOTAppliedOnCompile()
        //{

        //}

        private void AssertRelatedProperty(IList<LockFileItem> items, string path, string related)
        {
            var item = items.Single(i => i.Path.Equals(path));
            if (related == null)
            {
                Assert.False(item.Properties.ContainsKey("related"));
            }
            else
            {
                Assert.Equal(related, item.Properties["related"]);
            }
        }
    }
}