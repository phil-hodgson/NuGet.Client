// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft;
using Microsoft.ServiceHub.Framework;
using NuGet.Packaging.Core;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;
using NuGet.VisualStudio.Internal.Contracts;

namespace NuGet.PackageManagement.VisualStudio
{
    /// <summary>
    /// A package feed providing services of package enumeration of installed packages having updated versions in upstream source(s).
    /// </summary>
    public sealed class UpdatePackageFeed : PlainPackageFeedBase
    {
        private readonly IEnumerable<PackageCollectionItem> _installedPackages;
        private readonly IPackageMetadataProvider _metadataProvider;
        private readonly IProjectContextInfo[] _projects;
        private readonly IServiceBroker _serviceBroker;

        public UpdatePackageFeed(
            IServiceBroker serviceBroker,
            IEnumerable<PackageCollectionItem> installedPackages,
            IPackageMetadataProvider metadataProvider,
            IProjectContextInfo[] projects)
        {
            Assumes.NotNull(serviceBroker);
            Assumes.NotNull(installedPackages);
            Assumes.NotNull(metadataProvider);
            Assumes.NotNull(projects);

            _serviceBroker = serviceBroker;
            _installedPackages = installedPackages;
            _metadataProvider = metadataProvider;
            _projects = projects;
        }

        public override async Task<SearchResult<IPackageSearchMetadata>> ContinueSearchAsync(ContinuationToken continuationToken, CancellationToken cancellationToken)
        {
            var searchToken = continuationToken as FeedSearchContinuationToken;
            if (searchToken == null)
            {
                throw new InvalidOperationException("Invalid token");
            }

            IEnumerable<IPackageSearchMetadata> packagesWithUpdates = await GetPackagesWithUpdatesAsync(searchToken.SearchString, searchToken.SearchFilter, cancellationToken, includeInstalledWithoutUpdates: searchToken.IsUIFiltering);

            IPackageSearchMetadata[] items = packagesWithUpdates
                .Skip(searchToken.StartIndex)
                .ToArray();

            SearchResult<IPackageSearchMetadata> result = SearchResult.FromItems(items);

            LoadingStatus loadingStatus = items.Length == 0
                ? LoadingStatus.NoItemsFound
                : LoadingStatus.NoMoreItems;
            result.SourceSearchStatus = new Dictionary<string, LoadingStatus>
            {
                ["Update"] = loadingStatus
            };

            return result;
        }

        public async Task<IEnumerable<IPackageSearchMetadata>> GetPackagesWithUpdatesAsync(string searchText, SearchFilter searchFilter,
            CancellationToken cancellationToken, bool includeInstalledWithoutUpdates = false)
        {
            IEnumerable<PackageIdentity> packages = _installedPackages
                .Where(p => !p.IsAutoReferenced())
                .GetEarliest()
                .Where(p => p.Id.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) != -1);

            // Prefetch metadata for all installed packages
            IEnumerable<IEnumerable<IPackageSearchMetadata>> prefetch = await TaskCombinators.ThrottledAsync(
                packages,
                (p, t) => _metadataProvider.GetPackageMetadataListAsync(p.Id, searchFilter.IncludePrerelease, includeUnlisted: false, cancellationToken: t),
                cancellationToken);

            // Flatten the result list
            IPackageSearchMetadata[] prefetchedPackages = prefetch
                .Where(p => p != null)
                .SelectMany(p => p)
                .ToArray();

            // Traverse all projects and determine packages with updates
            var packagesWithUpdates = new List<IPackageSearchMetadata>();
            foreach (IProjectContextInfo project in _projects)
            {
                IReadOnlyCollection<IPackageReferenceContextInfo> installed = await project.GetInstalledPackagesAsync(_serviceBroker, cancellationToken);
                foreach (IPackageReferenceContextInfo installedPackage in installed)
                {
                    NuGetVersion installedVersion = installedPackage.Identity.Version;
                    VersionRange allowedVersions = installedPackage.AllowedVersions ?? VersionRange.All;

                    // filter packages based on current package identity
                    IPackageSearchMetadata[] allPackages = prefetchedPackages
                        .Where(p => StringComparer.OrdinalIgnoreCase.Equals(
                            p.Identity.Id,
                            installedPackage.Identity.Id))
                        .ToArray();

                    // and allowed versions
                    IEnumerable<IPackageSearchMetadata> allowedPackages = allPackages
                        .Where(p => allowedVersions.Satisfies(p.Identity.Version));

                    
                    // peek the highest available
                    IPackageSearchMetadata highest = allowedPackages
                        .OrderByDescending(e => e.Identity.Version, VersionComparer.VersionRelease)
                        .FirstOrDefault();

                    if (highest != null &&
                        VersionComparer.VersionRelease.Compare(installedVersion, highest.Identity.Version) < 0)
                    {
                        packagesWithUpdates.Add(highest.WithVersions(ToVersionInfo(allPackages)));
                    }
                    else if (includeInstalledWithoutUpdates) // Add package even if no update is available when UI filtering, as they'll be filtered later.
                    {
                        // Include the installed metadata.
                        IPackageSearchMetadata installedWithMetadata = allPackages.Single(metadata => metadata.Identity.Equals(installedPackage.Identity))
                            ?.WithVersions(ToVersionInfo(allPackages));

                        packagesWithUpdates.Add(installedWithMetadata);
                    }
                }
            }

            // select the earliest package update candidates
            var uniquePackageIds = packagesWithUpdates
                .Select(p => p.Identity)
                .GetEarliest();

            // get unique list of package metadata as similar updates may come from different projects
            var uniquePackages = uniquePackageIds
                .GroupJoin(
                    packagesWithUpdates,
                    id => id,
                    p => p.Identity,
                    (id, pl) => pl.First());

            return uniquePackages
                .OrderBy(p => p.Identity.Id)
                .ToArray();
        }

        private static IEnumerable<VersionInfo> ToVersionInfo(IEnumerable<IPackageSearchMetadata> packages)
        {
            return packages?
                .OrderByDescending(m => m.Identity.Version, VersionComparer.VersionRelease)
                .Select(m => new VersionInfo(m.Identity.Version, m.DownloadCount)
                {
                    PackageSearchMetadata = m
                });
        }
    }
}
