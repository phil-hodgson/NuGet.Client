// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Reflection;
using System.Resources;
using Moq;
using Xunit;

namespace NuGet.CommandLine.Test
{
    public class LocalizedResourceManagerTests
    {
        [Fact]
        public void GetLanguageName_DefaultCulture_ReturnsEnu()
        {
            // Arrange & Act
            string name = LocalizedResourceManager.GetLanguageName();

            // Assert
            Assert.Equal("enu", name);
        }

        [Theory]
        [InlineData("A_String_With_No_Name")]
        [InlineData("An_unknown_String")]
        public void GetString_NonExistentResource_ReturnsNull(string stringResourceName)
        {
            // Arrange & Act
            string resource = LocalizedResourceManager.GetString(stringResourceName);

            // Assert
            Assert.Null(resource);
        }

        [Theory]
        [InlineData("AddFileToPackage_cht")]
        [InlineData("SpecCommandCreatedNuSpec")]
        public void GetString_ExistingResourceInNuGetResources_ReturnsStringResource(string stringResourceName)
        {
            // Arrange & Act
            string resource = LocalizedResourceManager.GetString(stringResourceName);

            // Assert
            Assert.NotEmpty(resource);
        }

        [Theory]
        [InlineData("AddFileToPackage_cht", typeof(NuGetResources) )]
        [InlineData("SpecCommandCreatedNuSpec", typeof(NuGetResources) )]
        [InlineData("UpdateCommandPrerelease", typeof(NuGetCommand))]
        public void GetString_ExistingResourcesInOtherResources_ReturnsStringResource(string resourceName, Type resourceType)
        {
            // Arrange
            PropertyInfo property = resourceType.GetProperty("ResourceManager", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
            ResourceManager resourceManager = (ResourceManager)property.GetGetMethod(nonPublic: true).Invoke(obj: null, parameters: null);

            // Act
            string resource = LocalizedResourceManager.GetString(resourceName, resourceManager);

            // Assert
            Assert.NotEmpty(resource);
        }

        [Fact]
        public void GetString_ExistingResourceInNuGetResources_ReturnsSameValueFromResourceClass()
        {
            // Arrange & Act
            string resource = LocalizedResourceManager.GetString(nameof(NuGetResources.ListCommandNoPackages));

            // Assert
            Assert.Equal(NuGetResources.ListCommandNoPackages, resource);
        }

        [Fact]
        public void GetString_NullArgument_Throws()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => LocalizedResourceManager.GetString(resourceName: null));
            Assert.Throws<ArgumentException>(() => LocalizedResourceManager.GetString(resourceName: null, resourceManager: null));
            Assert.Throws<ArgumentException>(() => LocalizedResourceManager.GetString(resourceName: "", resourceManager: It.IsAny<ResourceManager>()));
            Assert.Throws<ArgumentNullException>(() => LocalizedResourceManager.GetString(resourceName: "e", resourceManager: null));
        }
    }
}
