﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.PackageManagement.VisualStudio {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.PackageManagement.VisualStudio.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All.
        /// </summary>
        public static string AggregateSourceName {
            get {
                return ResourceManager.GetString("AggregateSourceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument cannot be null or empty.
        /// </summary>
        public static string Argument_Cannot_Be_Null_Or_Empty {
            get {
                return ResourceManager.GetString("Argument_Cannot_Be_Null_Or_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be greater than or equal to {0}..
        /// </summary>
        public static string Argument_Must_Be_GreaterThanOrEqualTo {
            get {
                return ResourceManager.GetString("Argument_Must_Be_GreaterThanOrEqualTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet operation failed.
        /// </summary>
        public static string ConfigErrorDialogBoxTitle {
            get {
                return ResourceManager.GetString("ConfigErrorDialogBoxTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default credentials credential provider failed to load..
        /// </summary>
        public static string CredentialProviderFailed_DefaultCredentialsCredentialProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_DefaultCredentialsCredentialProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load credential provider from assembly {0}..
        /// </summary>
        public static string CredentialProviderFailed_ImportedProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_ImportedProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin credential providers could not be loaded..
        /// </summary>
        public static string CredentialProviderFailed_PluginCredentialProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_PluginCredentialProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Visual Studio or VSTS account provider failed to load..
        /// </summary>
        public static string CredentialProviderFailed_VisualStudioAccountProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_VisualStudioAccountProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Visual Studio credential provider failed to load..
        /// </summary>
        public static string CredentialProviderFailed_VisualStudioCredentialProvider {
            get {
                return ResourceManager.GetString("CredentialProviderFailed_VisualStudioCredentialProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Added file &apos;{0}&apos; to project &apos;{1}&apos;..
        /// </summary>
        public static string Debug_AddedFileToProject {
            get {
                return ResourceManager.GetString("Debug_AddedFileToProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Added reference &apos;{0}&apos; to project:&apos;{1}&apos;. The Reference was Resolved To Package (resolvedToPackage):&apos;{2}&apos;, where Reference Path from DTE(dteOriginalPath):&apos;{3}&apos; and Reference Path from package reference(assemblyFullPath):&apos;{4}&apos;..
        /// </summary>
        public static string Debug_AddedReferenceToProject {
            get {
                return ResourceManager.GetString("Debug_AddedReferenceToProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Added reference &apos;{0}&apos; in the Global Assembly Cache to project &apos;{1}&apos;.
        /// </summary>
        public static string Debug_AddGacReference {
            get {
                return ResourceManager.GetString("Debug_AddGacReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removed file &apos;{0}&apos;.
        /// </summary>
        public static string Debug_RemovedFile {
            get {
                return ResourceManager.GetString("Debug_RemovedFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removed file &apos;{0}&apos; from folder &apos;{1}&apos;.
        /// </summary>
        public static string Debug_RemovedFileFromFolder {
            get {
                return ResourceManager.GetString("Debug_RemovedFileFromFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removed folder &apos;{0}&apos;..
        /// </summary>
        public static string Debug_RemovedFolder {
            get {
                return ResourceManager.GetString("Debug_RemovedFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removed reference &apos;{0}&apos; from project &apos;{1}&apos;.
        /// </summary>
        public static string Debug_RemoveReference {
            get {
                return ResourceManager.GetString("Debug_RemoveReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project &apos;{0}&apos; is unsupported.
        /// </summary>
        public static string DTE_ProjectUnsupported {
            get {
                return ResourceManager.GetString("DTE_ProjectUnsupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create parent folder for file &apos;{0}&apos; in project {1}..
        /// </summary>
        public static string Error_FailedToCreateParentFolder {
            get {
                return ResourceManager.GetString("Error_FailedToCreateParentFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File &apos;{0}&apos; does not exist on disk. .
        /// </summary>
        public static string Error_FileNotExists {
            get {
                return ResourceManager.GetString("Error_FileNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is an invalid json file..
        /// </summary>
        public static string Error_InvalidJson {
            get {
                return ResourceManager.GetString("Error_InvalidJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to migrate project &apos;{0}&apos;. The project may only contain one target framework..
        /// </summary>
        public static string Error_MultipleFrameworks {
            get {
                return ResourceManager.GetString("Error_MultipleFrameworks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load &apos;{0}&apos;, while updating binding redirects. {1}.
        /// </summary>
        public static string Error_WhileLoadingConfigForBindingRedirects {
            get {
                return ResourceManager.GetString("Error_WhileLoadingConfigForBindingRedirects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid token.
        /// </summary>
        public static string Exception_InvalidContinuationToken {
            get {
                return ResourceManager.GetString("Exception_InvalidContinuationToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to add reference to &apos;{0}&apos;. The package &apos;{1}&apos; tried to add a framework reference to &apos;{0}&apos;. This reference is not required to be explicitly added by a package..
        /// </summary>
        public static string FailedToAddFacadeReference {
            get {
                return ResourceManager.GetString("FailedToAddFacadeReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to add reference. The package &apos;{0}&apos; tried to add a framework reference to &apos;{1}&apos; which was not found in the GAC. This is possibly a bug in the package. Please contact the package owners for assistance..
        /// </summary>
        public static string FailedToAddGacReference {
            get {
                return ResourceManager.GetString("FailedToAddGacReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to add reference to &apos;{0}&apos;..
        /// </summary>
        public static string FailedToAddReference {
            get {
                return ResourceManager.GetString("FailedToAddReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Case insensitive search for reference &apos;{0}&apos;, to be removed, returned more than 1 match. Request could not be performed..
        /// </summary>
        public static string FailedToRemoveReference {
            get {
                return ResourceManager.GetString("FailedToRemoveReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to update binding redirects for {0} : {1}.
        /// </summary>
        public static string FailedToUpdateBindingRedirects {
            get {
                return ResourceManager.GetString("FailedToUpdateBindingRedirects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Installing NuGet package {0}..
        /// </summary>
        public static string InstallingPackage {
            get {
                return ResourceManager.GetString("InstallingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All PackageReference elements contained in a PackageCollectionItem object from a transitive package must implement ITransitivePackageReferenceContextInfo interface and TransitiveOrigins collection must not be empty.
        /// </summary>
        public static string InvalidCollectionElementType {
            get {
                return ResourceManager.GetString("InvalidCollectionElementType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} MSBuild property could not be found for project &apos;{1}&apos;..
        /// </summary>
        public static string MSBuildPropertyNotFound {
            get {
                return ResourceManager.GetString("MSBuildPropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path &apos;{0}&apos; to existing file is not found on disk. Cannot add to project &apos;{1}&apos;.
        /// </summary>
        public static string PathToExistingFileNotPresent {
            get {
                return ResourceManager.GetString("PathToExistingFileNotPresent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation failed as details for project {0} could not be loaded..
        /// </summary>
        public static string ProjectNotLoaded_RestoreFailed {
            get {
                return ResourceManager.GetString("ProjectNotLoaded_RestoreFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some NuGet packages were installed using a target framework different from the current target framework and may need to be reinstalled. Visit https://docs.nuget.org/docs/workflows/reinstalling-packages for more information.  Packages affected: {0}.
        /// </summary>
        public static string ProjectUpgradeAndRetargetErrorMessage {
            get {
                return ResourceManager.GetString("ProjectUpgradeAndRetargetErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A project with ID &apos;{0}&apos; was not found..
        /// </summary>
        public static string ProjectWithIdNotFound {
            get {
                return ResourceManager.GetString("ProjectWithIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be null..
        /// </summary>
        public static string PropertyCannotBeNull {
            get {
                return ResourceManager.GetString("PropertyCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Solution is not saved. Please save your solution before managing NuGet packages..
        /// </summary>
        public static string SolutionIsNotSaved {
            get {
                return ResourceManager.GetString("SolutionIsNotSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to migration document.
        /// </summary>
        public static string Text_DeprecatedFramework_DocumentLink {
            get {
                return ResourceManager.GetString("Text_DeprecatedFramework_DocumentLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ..
        /// </summary>
        public static string Text_DeprecatedFramework_DocumentLink_After {
            get {
                return ResourceManager.GetString("Text_DeprecatedFramework_DocumentLink_After", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The NuGet operation failed due to one or more packages being incompatible with your project. The &apos;{0}&apos; (&apos;{1}&apos;) project framework is deprecated. For more information about how to migrate your projects to a supported framework, please refer to the.
        /// </summary>
        public static string Text_DeprecatedFramework_DocumentLink_Before {
            get {
                return ResourceManager.GetString("Text_DeprecatedFramework_DocumentLink_Before", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following project(s) target the deprecated framework:.
        /// </summary>
        public static string Text_DeprecatedFramework_ProjectList {
            get {
                return ResourceManager.GetString("Text_DeprecatedFramework_ProjectList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to get the project&apos;s package installation service for project &apos;{0}&apos;..
        /// </summary>
        public static string UnableToGetCPSPackageInstallationService {
            get {
                return ResourceManager.GetString("UnableToGetCPSPackageInstallationService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to resolve all items referenced by &apos;{0}&apos;. This message can typically be ignored. The issue may be resolved by fully restoring and building the solution. If the unresolved item is a project reference this can lead to an incomplete NuGet restore result and missing package references. To ensure that restore is able to find all projects verify that all projects are referenced correctly and exist on disk..
        /// </summary>
        public static string UnresolvedItemDuringProjectClosureWalk {
            get {
                return ResourceManager.GetString("UnresolvedItemDuringProjectClosureWalk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The feed type &apos;{0}&apos; is unsupported..
        /// </summary>
        public static string UnsupportedFeedType {
            get {
                return ResourceManager.GetString("UnsupportedFeedType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory &apos;{0}&apos; is not empty. Skipping....
        /// </summary>
        public static string Warning_DirectoryNotEmpty {
            get {
                return ResourceManager.GetString("Warning_DirectoryNotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to remove package directories that were marked for deletion on Visual Studio restart: {0}.
        /// </summary>
        public static string Warning_FailedToDeleteMarkedPackageDirectories {
            get {
                return ResourceManager.GetString("Warning_FailedToDeleteMarkedPackageDirectories", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to remove package directory &apos;{0}&apos; that was marked for deletion on Visual Studio restart..
        /// </summary>
        public static string Warning_FailedToDeleteMarkedPackageDirectory {
            get {
                return ResourceManager.GetString("Warning_FailedToDeleteMarkedPackageDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find match for removing reference &apos;{0}&apos;..
        /// </summary>
        public static string Warning_FailedToFindMatchForRemoveReference {
            get {
                return ResourceManager.GetString("Warning_FailedToFindMatchForRemoveReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to mark package directory &apos;{0}&apos; for deletion on Visual Studio restart: {1}.
        /// </summary>
        public static string Warning_FailedToMarkPackageDirectoryForDeletion {
            get {
                return ResourceManager.GetString("Warning_FailedToMarkPackageDirectoryForDeletion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; already exists. Skipping....
        /// </summary>
        public static string Warning_FileAlreadyExists {
            get {
                return ResourceManager.GetString("Warning_FileAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No exact match found for removing reference &apos;{0}&apos;. Trying No No exact match found for removing reference &apos;{0}&apos;. Trying case-insensitive search...-.
        /// </summary>
        public static string Warning_NoExactMatchForReference {
            get {
                return ResourceManager.GetString("Warning_NoExactMatchForReference", resourceCulture);
            }
        }
    }
}
