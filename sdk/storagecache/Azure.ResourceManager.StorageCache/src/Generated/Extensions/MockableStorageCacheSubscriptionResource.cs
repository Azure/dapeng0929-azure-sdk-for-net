// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableStorageCacheSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _amlFileSystemamlFilesystemsClientDiagnostics;
        private AmlFilesystemsRestOperations _amlFileSystemamlFilesystemsRestClient;
        private ClientDiagnostics _defaultClientDiagnostics;
        private StorageCacheManagementRestOperations _defaultRestClient;
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;
        private ClientDiagnostics _usageModelsClientDiagnostics;
        private UsageModelsRestOperations _usageModelsRestClient;
        private ClientDiagnostics _ascUsagesClientDiagnostics;
        private AscUsagesRestOperations _ascUsagesRestClient;
        private ClientDiagnostics _storageCacheCachesClientDiagnostics;
        private CachesRestOperations _storageCacheCachesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableStorageCacheSubscriptionResource"/> class for mocking. </summary>
        protected MockableStorageCacheSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableStorageCacheSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableStorageCacheSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AmlFileSystemamlFilesystemsClientDiagnostics => _amlFileSystemamlFilesystemsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StorageCache", AmlFileSystemResource.ResourceType.Namespace, Diagnostics);
        private AmlFilesystemsRestOperations AmlFileSystemamlFilesystemsRestClient => _amlFileSystemamlFilesystemsRestClient ??= new AmlFilesystemsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AmlFileSystemResource.ResourceType));
        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StorageCache", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private StorageCacheManagementRestOperations DefaultRestClient => _defaultRestClient ??= new StorageCacheManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StorageCache", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics UsageModelsClientDiagnostics => _usageModelsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StorageCache", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private UsageModelsRestOperations UsageModelsRestClient => _usageModelsRestClient ??= new UsageModelsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics AscUsagesClientDiagnostics => _ascUsagesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StorageCache", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AscUsagesRestOperations AscUsagesRestClient => _ascUsagesRestClient ??= new AscUsagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics StorageCacheCachesClientDiagnostics => _storageCacheCachesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.StorageCache", StorageCacheResource.ResourceType.Namespace, Diagnostics);
        private CachesRestOperations StorageCacheCachesRestClient => _storageCacheCachesRestClient ??= new CachesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(StorageCacheResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Returns all AML file systems the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/amlFilesystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AmlFileSystemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AmlFileSystemResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AmlFileSystemResource> GetAmlFileSystemsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AmlFileSystemamlFilesystemsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AmlFileSystemamlFilesystemsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AmlFileSystemResource(Client, AmlFileSystemData.DeserializeAmlFileSystemData(e)), AmlFileSystemamlFilesystemsClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetAmlFileSystems", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all AML file systems the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/amlFilesystems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>amlFilesystems_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AmlFileSystemResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AmlFileSystemResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AmlFileSystemResource> GetAmlFileSystems(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AmlFileSystemamlFilesystemsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AmlFileSystemamlFilesystemsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AmlFileSystemResource(Client, AmlFileSystemData.DeserializeAmlFileSystemData(e)), AmlFileSystemamlFilesystemsClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetAmlFileSystems", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check that subnets will be valid for AML file system create calls.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/checkAmlFSSubnets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckAmlFSSubnets</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information about the subnets to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckAmlFSSubnetsAsync(AmlFileSystemSubnetContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("MockableStorageCacheSubscriptionResource.CheckAmlFSSubnets");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckAmlFSSubnetsAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check that subnets will be valid for AML file system create calls.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/checkAmlFSSubnets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckAmlFSSubnets</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information about the subnets to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckAmlFSSubnets(AmlFileSystemSubnetContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("MockableStorageCacheSubscriptionResource.CheckAmlFSSubnets");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckAmlFSSubnets(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the number of available IP addresses needed for the AML file system information provided.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/getRequiredAmlFSSubnetsSize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetRequiredAmlFSSubnetsSize</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information to determine the number of available IPs a subnet will need to host the AML file system. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RequiredAmlFileSystemSubnetsSize>> GetRequiredAmlFSSubnetsSizeAsync(RequiredAmlFileSystemSubnetsSizeContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("MockableStorageCacheSubscriptionResource.GetRequiredAmlFSSubnetsSize");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.GetRequiredAmlFSSubnetsSizeAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the number of available IP addresses needed for the AML file system information provided.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/getRequiredAmlFSSubnetsSize</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetRequiredAmlFSSubnetsSize</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Information to determine the number of available IPs a subnet will need to host the AML file system. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RequiredAmlFileSystemSubnetsSize> GetRequiredAmlFSSubnetsSize(RequiredAmlFileSystemSubnetsSizeContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("MockableStorageCacheSubscriptionResource.GetRequiredAmlFSSubnetsSize");
            scope.Start();
            try
            {
                var response = DefaultRestClient.GetRequiredAmlFSSubnetsSize(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the list of StorageCache.Cache SKUs available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageCacheSku> GetStorageCacheSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => StorageCacheSku.DeserializeStorageCacheSku(e), SkusClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetStorageCacheSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the list of StorageCache.Cache SKUs available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheSku"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageCacheSku> GetStorageCacheSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SkusRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => StorageCacheSku.DeserializeStorageCacheSku(e), SkusClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetStorageCacheSkus", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the list of cache usage models available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/usageModels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageModels_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheUsageModel"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageCacheUsageModel> GetUsageModelsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsageModelsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsageModelsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => StorageCacheUsageModel.DeserializeStorageCacheUsageModel(e), UsageModelsClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetUsageModels", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the list of cache usage models available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/usageModels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageModels_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheUsageModel"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageCacheUsageModel> GetUsageModels(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => UsageModelsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => UsageModelsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => StorageCacheUsageModel.DeserializeStorageCacheUsageModel(e), UsageModelsClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetUsageModels", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the quantity used and quota limit for resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AscUsages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the region to query for usage information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageCacheUsage> GetStorageCacheUsagesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AscUsagesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AscUsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => StorageCacheUsage.DeserializeStorageCacheUsage(e), AscUsagesClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetStorageCacheUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the quantity used and quota limit for resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AscUsages_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the region to query for usage information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheUsage"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageCacheUsage> GetStorageCacheUsages(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AscUsagesRestClient.CreateListRequest(Id.SubscriptionId, location);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AscUsagesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => StorageCacheUsage.DeserializeStorageCacheUsage(e), AscUsagesClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetStorageCacheUsages", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all caches the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageCacheResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageCacheResource> GetStorageCachesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageCacheCachesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageCacheCachesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageCacheResource(Client, StorageCacheData.DeserializeStorageCacheData(e)), StorageCacheCachesClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetStorageCaches", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all caches the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-07-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageCacheResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageCacheResource> GetStorageCaches(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => StorageCacheCachesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => StorageCacheCachesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageCacheResource(Client, StorageCacheData.DeserializeStorageCacheData(e)), StorageCacheCachesClientDiagnostics, Pipeline, "MockableStorageCacheSubscriptionResource.GetStorageCaches", "value", "nextLink", cancellationToken);
        }
    }
}
