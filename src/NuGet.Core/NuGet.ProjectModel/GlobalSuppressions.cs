// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'IAssetsLogMessage AssetsLogMessage.Create(IRestoreLogMessage logMessage)', validate parameter 'logMessage' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.AssetsLogMessage.Create(NuGet.Common.IRestoreLogMessage)~NuGet.ProjectModel.IAssetsLogMessage")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'CacheFile CacheFileFormat.Read(Stream stream, ILogger log, string path)', validate parameter 'log' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.CacheFileFormat.Read(System.IO.Stream,NuGet.Common.ILogger,System.String)~NuGet.ProjectModel.CacheFile")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'Read' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.CacheFileFormat.Read(System.IO.TextReader,NuGet.Common.ILogger,System.String)~NuGet.ProjectModel.CacheFile")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void DependencyGraphSpec.AddProject(PackageSpec projectSpec)', validate parameter 'projectSpec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.DependencyGraphSpec.AddProject(NuGet.ProjectModel.PackageSpec)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'DependencyGraphSpec.GetDGSpecFileName(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.DependencyGraphSpec.GetDGSpecFileName(System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1822:Member ToPackageSpecWithCentralVersionInformation does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.DependencyGraphSpec.ToPackageSpecWithCentralVersionInformation(NuGet.ProjectModel.PackageSpec)~NuGet.ProjectModel.PackageSpec")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'DependencyGraphSpec DependencyGraphSpec.WithReplacedSpec(PackageSpec project)', validate parameter 'project' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.DependencyGraphSpec.WithReplacedSpec(NuGet.ProjectModel.PackageSpec)~NuGet.ProjectModel.DependencyGraphSpec")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'FileFormatException FileFormatException.Create(Exception exception, JToken value, string path)', validate parameter 'exception' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.FileFormatException.Create(System.Exception,Newtonsoft.Json.Linq.JToken,System.String)~NuGet.ProjectModel.FileFormatException")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'PackageSpec JsonPackageSpecReader.GetPackageSpec(JObject rawPackageSpec, string name, string packageSpecPath, string snapshotValue)', validate parameter 'rawPackageSpec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.JsonPackageSpecReader.GetPackageSpec(Newtonsoft.Json.Linq.JObject,System.String,System.String,System.String)~NuGet.ProjectModel.PackageSpec")]
[assembly: SuppressMessage("Build", "CA1303:Method 'void JsonPackageSpecReader.ReadDownloadDependencies(JsonTextReader jsonReader, IList<DownloadDependency> downloadDependencies, string packageSpecPath)' passes a literal string as parameter 'message' of a call to 'FileFormatException FileFormatException.Create(string message, int line, int column, string path)'. Retrieve the following string(s) from a resource table instead: \"The version cannot be null or empty\".", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.JsonPackageSpecReader.ReadDownloadDependencies(Newtonsoft.Json.JsonTextReader,System.Collections.Generic.IList{NuGet.LibraryModel.DownloadDependency},System.String)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'JsonPackageSpecReader.ReadImports(PackageSpec, JsonTextReader, TargetFrameworkInformation)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.JsonPackageSpecReader.ReadImports(NuGet.ProjectModel.PackageSpec,Newtonsoft.Json.JsonTextReader,NuGet.ProjectModel.TargetFrameworkInformation)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'JsonPackageSpecReader.ReadScripts(JsonTextReader, PackageSpec)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.JsonPackageSpecReader.ReadScripts(Newtonsoft.Json.JsonTextReader,NuGet.ProjectModel.PackageSpec)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool LockFile.IsValidForPackageSpec(PackageSpec spec, int requestLockFileVersion)', validate parameter 'spec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFile.IsValidForPackageSpec(NuGet.ProjectModel.PackageSpec,System.Int32)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'int LockFileDependencyIdVersionComparer.GetHashCode(LockFileDependency obj)', validate parameter 'obj' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileDependencyIdVersionComparer.GetHashCode(NuGet.ProjectModel.LockFileDependency)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'LockFileDependencyProvider.LockFileDependencyProvider(LockFile lockFile)', validate parameter 'lockFile' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileDependencyProvider.#ctor(NuGet.ProjectModel.LockFile)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Library LockFileDependencyProvider.GetLibrary(LibraryRange libraryRange, NuGetFramework targetFramework)', validate parameter 'libraryRange' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileDependencyProvider.GetLibrary(NuGet.LibraryModel.LibraryRange,NuGet.Frameworks.NuGetFramework)~NuGet.LibraryModel.Library")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'Read' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileFormat.Read(System.IO.TextReader,NuGet.Common.ILogger,System.String)~NuGet.ProjectModel.LockFile")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'LockFile LockFileFormat.Read(TextReader reader, ILogger log, string path)', validate parameter 'log' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileFormat.Read(System.IO.TextReader,NuGet.Common.ILogger,System.String)~NuGet.ProjectModel.LockFile")]
[assembly: SuppressMessage("Build", "CA1822:Member Read does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileFormat.Read(System.IO.TextReader,NuGet.Common.ILogger,System.String)~NuGet.ProjectModel.LockFile")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'LockFileFormat.ReadSemanticVersion(JToken, string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileFormat.ReadSemanticVersion(Newtonsoft.Json.Linq.JToken,System.String)~NuGet.Versioning.SemanticVersion")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void LockFileFormat.Write(TextWriter textWriter, LockFile lockFile)', validate parameter 'lockFile' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileFormat.Write(System.IO.TextWriter,NuGet.ProjectModel.LockFile)")]
[assembly: SuppressMessage("Build", "CA1822:Member Write does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileFormat.Write(System.IO.TextWriter,NuGet.ProjectModel.LockFile)")]
[assembly: SuppressMessage("Build", "CA2225:Provide a method named 'ToLockFileItem' or 'FromString' as an alternate for operator op_Implicit.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileItem.op_Implicit(System.String)~NuGet.ProjectModel.LockFileItem")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.Equals(string, string)' could vary based on the current user's locale settings. Replace this call in 'NuGet.ProjectModel.LockFileTarget.Equals(NuGet.ProjectModel.LockFileTarget)' with a call to 'string.Equals(string, string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileTarget.Equals(NuGet.ProjectModel.LockFileTarget)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.Equals(string, string)' could vary based on the current user's locale settings. Replace this call in 'NuGet.ProjectModel.LockFileTargetLibrary.Equals(NuGet.ProjectModel.LockFileTargetLibrary)' with a call to 'string.Equals(string, string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.LockFileTargetLibrary.Equals(NuGet.ProjectModel.LockFileTargetLibrary)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'PackagesLockFile PackagesLockFileFormat.Read(TextReader reader, ILogger log, string path)', validate parameter 'log' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackagesLockFileFormat.Read(System.IO.TextReader,NuGet.Common.ILogger,System.String)~NuGet.ProjectModel.PackagesLockFile")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'Read' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackagesLockFileFormat.Read(System.IO.TextReader,NuGet.Common.ILogger,System.String)~NuGet.ProjectModel.PackagesLockFile")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void PackagesLockFileFormat.Write(TextWriter textWriter, PackagesLockFile lockFile)', validate parameter 'lockFile' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackagesLockFileFormat.Write(System.IO.TextWriter,NuGet.ProjectModel.PackagesLockFile)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string PackagesLockFileUtilities.GetNuGetLockFilePath(PackageSpec project)', validate parameter 'project' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackagesLockFileUtilities.GetNuGetLockFilePath(NuGet.ProjectModel.PackageSpec)~System.String")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool PackagesLockFileUtilities.IsLockFileStillValid(DependencyGraphSpec dgSpec, PackagesLockFile nuGetLockFile)', validate parameter 'dgSpec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackagesLockFileUtilities.IsLockFileStillValid(NuGet.ProjectModel.DependencyGraphSpec,NuGet.ProjectModel.PackagesLockFile)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool PackagesLockFileUtilities.IsNuGetLockFileEnabled(PackageSpec project)', validate parameter 'project' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackagesLockFileUtilities.IsNuGetLockFileEnabled(NuGet.ProjectModel.PackageSpec)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1822:Member CloneScripts does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpec.CloneScripts(System.Collections.Generic.IDictionary{System.String,System.Collections.Generic.IEnumerable{System.String}})~System.Collections.Generic.IDictionary{System.String,System.Collections.Generic.IEnumerable{System.String}}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'ProjectRestoreMetadataFrameworkInfo PackageSpecExtensions.GetRestoreMetadataFramework(PackageSpec project, NuGetFramework targetFramework)', validate parameter 'project' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecExtensions.GetRestoreMetadataFramework(NuGet.ProjectModel.PackageSpec,NuGet.Frameworks.NuGetFramework)~NuGet.ProjectModel.ProjectRestoreMetadataFrameworkInfo")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'TargetFrameworkInformation PackageSpecExtensions.GetTargetFramework(PackageSpec project, NuGetFramework targetFramework)', validate parameter 'project' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecExtensions.GetTargetFramework(NuGet.ProjectModel.PackageSpec,NuGet.Frameworks.NuGetFramework)~NuGet.ProjectModel.TargetFrameworkInformation")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void PackageSpecOperations.AddOrUpdateDependency(PackageSpec spec, PackageDependency dependency)', validate parameter 'spec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecOperations.AddOrUpdateDependency(NuGet.ProjectModel.PackageSpec,NuGet.Packaging.Core.PackageDependency)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void PackageSpecOperations.AddOrUpdateDependency(PackageSpec spec, PackageDependency dependency, IEnumerable<NuGetFramework> frameworksToAdd)', validate parameter 'spec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecOperations.AddOrUpdateDependency(NuGet.ProjectModel.PackageSpec,NuGet.Packaging.Core.PackageDependency,System.Collections.Generic.IEnumerable{NuGet.Frameworks.NuGetFramework})")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void PackageSpecOperations.AddOrUpdateDependency(PackageSpec spec, PackageIdentity identity)', validate parameter 'identity' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecOperations.AddOrUpdateDependency(NuGet.ProjectModel.PackageSpec,NuGet.Packaging.Core.PackageIdentity)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void PackageSpecOperations.AddOrUpdateDependency(PackageSpec spec, PackageIdentity identity, IEnumerable<NuGetFramework> frameworksToAdd)', validate parameter 'identity' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecOperations.AddOrUpdateDependency(NuGet.ProjectModel.PackageSpec,NuGet.Packaging.Core.PackageIdentity,System.Collections.Generic.IEnumerable{NuGet.Frameworks.NuGetFramework})")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void PackageSpecOperations.RemoveDependency(PackageSpec spec, string packageId)', validate parameter 'spec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecOperations.RemoveDependency(NuGet.ProjectModel.PackageSpec,System.String)")]
[assembly: SuppressMessage("Build", "CA1801:Parameter msbuildPath of method AddLibraryProperties is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecReferenceDependencyProvider.AddLibraryProperties(NuGet.LibraryModel.Library,NuGet.ProjectModel.PackageSpec,NuGet.Frameworks.NuGetFramework,System.String)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Library PackageSpecReferenceDependencyProvider.GetLibrary(LibraryRange libraryRange, NuGetFramework targetFramework)', validate parameter 'libraryRange' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecReferenceDependencyProvider.GetLibrary(NuGet.LibraryModel.LibraryRange,NuGet.Frameworks.NuGetFramework)~NuGet.LibraryModel.Library")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'NuGetVersion PackageSpecUtility.SpecifySnapshot(string version, string snapshotValue)', validate parameter 'version' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.PackageSpecUtility.SpecifySnapshot(System.String,System.String)~NuGet.Versioning.NuGetVersion")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'int LockFileDependencyComparerWithoutContentHash.GetHashCode(LockFileDependency obj)', validate parameter 'obj' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.ProjectLockFile.LockFileDependencyComparerWithoutContentHash.GetHashCode(NuGet.ProjectModel.LockFileDependency)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void ProjectRestoreMetadata.FillClone(ProjectRestoreMetadata clone)', validate parameter 'clone' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.ProjectRestoreMetadata.FillClone(NuGet.ProjectModel.ProjectRestoreMetadata)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'int ProjectRestoreMetadataFile.CompareTo(ProjectRestoreMetadataFile other)', validate parameter 'other' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.ProjectRestoreMetadataFile.CompareTo(NuGet.ProjectModel.ProjectRestoreMetadataFile)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.Equals(string, string)' could vary based on the current user's locale settings. Replace this call in 'NuGet.ProjectModel.TargetFrameworkInformation.Equals(NuGet.ProjectModel.TargetFrameworkInformation)' with a call to 'string.Equals(string, string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.TargetFrameworkInformation.Equals(NuGet.ProjectModel.TargetFrameworkInformation)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1806:GetAvailableToolVersions calls TryParse but does not explicitly check whether the conversion succeeded. Either use the return value in a conditional statement or verify that the call site expects that the out argument will be set to the default value when the conversion fails.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.ToolPathResolver.GetAvailableToolVersions(System.String)~System.Collections.Generic.IEnumerable{NuGet.Versioning.NuGetVersion}")]
[assembly: SuppressMessage("Build", "CA1308:In method 'GetAvailableToolVersions', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.ToolPathResolver.GetAvailableToolVersions(System.String)~System.Collections.Generic.IEnumerable{NuGet.Versioning.NuGetVersion}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string ToolPathResolver.GetBestToolDirectoryPath(string packageId, VersionRange versionRange, NuGetFramework framework)', validate parameter 'versionRange' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.ToolPathResolver.GetBestToolDirectoryPath(System.String,NuGet.Versioning.VersionRange,NuGet.Frameworks.NuGetFramework)~System.String")]
[assembly: SuppressMessage("Build", "CA1822:Member GetLockFilePath does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.ToolPathResolver.GetLockFilePath(System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string ToolPathResolver.GetToolDirectoryPath(string packageId, NuGetVersion version, NuGetFramework framework)', validate parameter 'framework' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.ToolPathResolver.GetToolDirectoryPath(System.String,NuGet.Versioning.NuGetVersion,NuGet.Frameworks.NuGetFramework)~System.String")]
[assembly: SuppressMessage("Build", "CA1308:In method 'GetToolDirectoryPath', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.ProjectModel.ToolPathResolver.GetToolDirectoryPath(System.String,NuGet.Versioning.NuGetVersion,NuGet.Frameworks.NuGetFramework)~System.String")]
[assembly: SuppressMessage("Build", "CA2227:Change 'ExpectedPackageFilePaths' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.CacheFile.ExpectedPackageFilePaths")]
[assembly: SuppressMessage("Build", "CA2227:Change 'LogMessages' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.CacheFile.LogMessages")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Libraries' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFile.Libraries")]
[assembly: SuppressMessage("Build", "CA2227:Change 'LogMessages' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFile.LogMessages")]
[assembly: SuppressMessage("Build", "CA2227:Change 'PackageFolders' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFile.PackageFolders")]
[assembly: SuppressMessage("Build", "CA2227:Change 'ProjectFileDependencyGroups' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFile.ProjectFileDependencyGroups")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Targets' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFile.Targets")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'bool.ToString()' could vary based on the current user's locale settings. Replace this call in 'LockFileContentFile.CopyToOutput.set' with a call to 'bool.ToString(IFormatProvider)'.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileContentFile.CopyToOutput")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Dependencies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileDependency.Dependencies")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Files' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileLibrary.Files")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Libraries' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTarget.Libraries")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Build' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.Build")]
[assembly: SuppressMessage("Build", "CA2227:Change 'BuildMultiTargeting' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.BuildMultiTargeting")]
[assembly: SuppressMessage("Build", "CA2227:Change 'CompileTimeAssemblies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.CompileTimeAssemblies")]
[assembly: SuppressMessage("Build", "CA2227:Change 'ContentFiles' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.ContentFiles")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Dependencies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.Dependencies")]
[assembly: SuppressMessage("Build", "CA2227:Change 'EmbedAssemblies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.EmbedAssemblies")]
[assembly: SuppressMessage("Build", "CA2227:Change 'FrameworkAssemblies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.FrameworkAssemblies")]
[assembly: SuppressMessage("Build", "CA2227:Change 'FrameworkReferences' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.FrameworkReferences")]
[assembly: SuppressMessage("Build", "CA2227:Change 'NativeLibraries' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.NativeLibraries")]
[assembly: SuppressMessage("Build", "CA2227:Change 'PackageType' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.PackageType")]
[assembly: SuppressMessage("Build", "CA2227:Change 'ResourceAssemblies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.ResourceAssemblies")]
[assembly: SuppressMessage("Build", "CA2227:Change 'RuntimeAssemblies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.RuntimeAssemblies")]
[assembly: SuppressMessage("Build", "CA2227:Change 'RuntimeTargets' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.RuntimeTargets")]
[assembly: SuppressMessage("Build", "CA2227:Change 'ToolsAssemblies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFileTargetLibrary.ToolsAssemblies")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Targets' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackagesLockFile.Targets")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Dependencies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackagesLockFileTarget.Dependencies")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackageSpec.Authors")]
[assembly: SuppressMessage("Build", "CA2227:Change 'ContentFiles' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackageSpec.ContentFiles")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Dependencies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackageSpec.Dependencies")]
[assembly: SuppressMessage("Build", "CA1056:Change the type of property PackageSpec.IconUrl from string to System.Uri.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackageSpec.IconUrl")]
[assembly: SuppressMessage("Build", "CA1056:Change the type of property PackageSpec.LicenseUrl from string to System.Uri.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackageSpec.LicenseUrl")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackageSpec.Owners")]
[assembly: SuppressMessage("Build", "CA1056:Change the type of property PackageSpec.ProjectUrl from string to System.Uri.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackageSpec.ProjectUrl")]
[assembly: SuppressMessage("Build", "CA1819:Properties should not return arrays", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackageSpec.Tags")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Mappings' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.PackOptions.Mappings")]
[assembly: SuppressMessage("Build", "CA2227:Change 'ConfigFilePaths' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.ProjectRestoreMetadata.ConfigFilePaths")]
[assembly: SuppressMessage("Build", "CA2227:Change 'FallbackFolders' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.ProjectRestoreMetadata.FallbackFolders")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Files' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.ProjectRestoreMetadata.Files")]
[assembly: SuppressMessage("Build", "CA2227:Change 'OriginalTargetFrameworks' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.ProjectRestoreMetadata.OriginalTargetFrameworks")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Sources' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.ProjectRestoreMetadata.Sources")]
[assembly: SuppressMessage("Build", "CA2227:Change 'TargetFrameworks' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.ProjectRestoreMetadata.TargetFrameworks")]
[assembly: SuppressMessage("Build", "CA2227:Change 'ProjectReferences' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.ProjectRestoreMetadataFrameworkInfo.ProjectReferences")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Dependencies' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.TargetFrameworkInformation.Dependencies")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Imports' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.TargetFrameworkInformation.Imports")]
[assembly: SuppressMessage("Build", "CA2237:Add [Serializable] to FileFormatException as this type implements ISerializable", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.ProjectModel.FileFormatException")]
[assembly: SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.ProjectModel.LockFile.CentralTransitiveDependencyGroups")]
