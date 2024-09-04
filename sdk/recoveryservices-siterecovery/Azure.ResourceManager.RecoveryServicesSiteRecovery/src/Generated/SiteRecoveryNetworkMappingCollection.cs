// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="SiteRecoveryNetworkMappingResource"/> and their operations.
    /// Each <see cref="SiteRecoveryNetworkMappingResource"/> in the collection will belong to the same instance of <see cref="SiteRecoveryNetworkResource"/>.
    /// To get a <see cref="SiteRecoveryNetworkMappingCollection"/> instance call the GetSiteRecoveryNetworkMappings method from an instance of <see cref="SiteRecoveryNetworkResource"/>.
    /// </summary>
    public partial class SiteRecoveryNetworkMappingCollection : ArmCollection, IEnumerable<SiteRecoveryNetworkMappingResource>, IAsyncEnumerable<SiteRecoveryNetworkMappingResource>
    {
        private readonly ClientDiagnostics _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics;
        private readonly ReplicationNetworkMappingsRestOperations _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkMappingCollection"/> class for mocking. </summary>
        protected SiteRecoveryNetworkMappingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryNetworkMappingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteRecoveryNetworkMappingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryNetworkMappingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryNetworkMappingResource.ResourceType, out string siteRecoveryNetworkMappingReplicationNetworkMappingsApiVersion);
            _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient = new ReplicationNetworkMappingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryNetworkMappingReplicationNetworkMappingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteRecoveryNetworkResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteRecoveryNetworkResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="content"> Create network mapping input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteRecoveryNetworkMappingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkMappingName, SiteRecoveryNetworkMappingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkMappingName, nameof(networkMappingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryNetworkMappingResource>(new SiteRecoveryNetworkMappingOperationSource(Client), _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics, Pipeline, _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="content"> Create network mapping input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SiteRecoveryNetworkMappingResource> CreateOrUpdate(WaitUntil waitUntil, string networkMappingName, SiteRecoveryNetworkMappingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkMappingName, nameof(networkMappingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryNetworkMappingResource>(new SiteRecoveryNetworkMappingOperationSource(Client), _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics, Pipeline, _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryNetworkMappingResource>> GetAsync(string networkMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkMappingName, nameof(networkMappingName));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of an ASR network mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> is null. </exception>
        public virtual Response<SiteRecoveryNetworkMappingResource> Get(string networkMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkMappingName, nameof(networkMappingName));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all ASR network mappings for the specified network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_ListByReplicationNetworks</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryNetworkMappingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryNetworkMappingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateListByReplicationNetworksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateListByReplicationNetworksNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryNetworkMappingResource(Client, SiteRecoveryNetworkMappingData.DeserializeSiteRecoveryNetworkMappingData(e)), _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics, Pipeline, "SiteRecoveryNetworkMappingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all ASR network mappings for the specified network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_ListByReplicationNetworks</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryNetworkMappingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryNetworkMappingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateListByReplicationNetworksRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.CreateListByReplicationNetworksNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryNetworkMappingResource(Client, SiteRecoveryNetworkMappingData.DeserializeSiteRecoveryNetworkMappingData(e)), _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics, Pipeline, "SiteRecoveryNetworkMappingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkMappingName, nameof(networkMappingName));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkMappingName, nameof(networkMappingName));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteRecoveryNetworkMappingResource>> GetIfExistsAsync(string networkMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkMappingName, nameof(networkMappingName));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryNetworkMappingResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationNetworks/{networkName}/replicationNetworkMappings/{networkMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationNetworkMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryNetworkMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkMappingName"> Network mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkMappingName"/> is null. </exception>
        public virtual NullableResponse<SiteRecoveryNetworkMappingResource> GetIfExists(string networkMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkMappingName, nameof(networkMappingName));

            using var scope = _siteRecoveryNetworkMappingReplicationNetworkMappingsClientDiagnostics.CreateScope("SiteRecoveryNetworkMappingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteRecoveryNetworkMappingReplicationNetworkMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, networkMappingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryNetworkMappingResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryNetworkMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryNetworkMappingResource> IEnumerable<SiteRecoveryNetworkMappingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryNetworkMappingResource> IAsyncEnumerable<SiteRecoveryNetworkMappingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
