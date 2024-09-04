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
    /// A class representing a collection of <see cref="SiteRecoveryProtectionContainerResource"/> and their operations.
    /// Each <see cref="SiteRecoveryProtectionContainerResource"/> in the collection will belong to the same instance of <see cref="SiteRecoveryFabricResource"/>.
    /// To get a <see cref="SiteRecoveryProtectionContainerCollection"/> instance call the GetSiteRecoveryProtectionContainers method from an instance of <see cref="SiteRecoveryFabricResource"/>.
    /// </summary>
    public partial class SiteRecoveryProtectionContainerCollection : ArmCollection, IEnumerable<SiteRecoveryProtectionContainerResource>, IAsyncEnumerable<SiteRecoveryProtectionContainerResource>
    {
        private readonly ClientDiagnostics _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics;
        private readonly ReplicationProtectionContainersRestOperations _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryProtectionContainerCollection"/> class for mocking. </summary>
        protected SiteRecoveryProtectionContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteRecoveryProtectionContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SiteRecoveryProtectionContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", SiteRecoveryProtectionContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SiteRecoveryProtectionContainerResource.ResourceType, out string siteRecoveryProtectionContainerReplicationProtectionContainersApiVersion);
            _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient = new ReplicationProtectionContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteRecoveryProtectionContainerReplicationProtectionContainersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteRecoveryFabricResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteRecoveryFabricResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Operation to create a protection container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="protectionContainerName"> Unique protection container ARM name. </param>
        /// <param name="content"> Creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectionContainerName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteRecoveryProtectionContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string protectionContainerName, SiteRecoveryProtectionContainerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics.CreateScope("SiteRecoveryProtectionContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryProtectionContainerResource>(new SiteRecoveryProtectionContainerOperationSource(Client), _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics, Pipeline, _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Operation to create a protection container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="protectionContainerName"> Unique protection container ARM name. </param>
        /// <param name="content"> Creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectionContainerName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SiteRecoveryProtectionContainerResource> CreateOrUpdate(WaitUntil waitUntil, string protectionContainerName, SiteRecoveryProtectionContainerCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics.CreateScope("SiteRecoveryProtectionContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<SiteRecoveryProtectionContainerResource>(new SiteRecoveryProtectionContainerOperationSource(Client), _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics, Pipeline, _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of a protection container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectionContainerName"/> is null. </exception>
        public virtual async Task<Response<SiteRecoveryProtectionContainerResource>> GetAsync(string protectionContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));

            using var scope = _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics.CreateScope("SiteRecoveryProtectionContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryProtectionContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of a protection container.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectionContainerName"/> is null. </exception>
        public virtual Response<SiteRecoveryProtectionContainerResource> Get(string protectionContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));

            using var scope = _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics.CreateScope("SiteRecoveryProtectionContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryProtectionContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the protection containers in the specified fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_ListByReplicationFabrics</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteRecoveryProtectionContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteRecoveryProtectionContainerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.CreateListByReplicationFabricsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.CreateListByReplicationFabricsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryProtectionContainerResource(Client, SiteRecoveryProtectionContainerData.DeserializeSiteRecoveryProtectionContainerData(e)), _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics, Pipeline, "SiteRecoveryProtectionContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the protection containers in the specified fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_ListByReplicationFabrics</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteRecoveryProtectionContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteRecoveryProtectionContainerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.CreateListByReplicationFabricsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.CreateListByReplicationFabricsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SiteRecoveryProtectionContainerResource(Client, SiteRecoveryProtectionContainerData.DeserializeSiteRecoveryProtectionContainerData(e)), _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics, Pipeline, "SiteRecoveryProtectionContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectionContainerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string protectionContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));

            using var scope = _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics.CreateScope("SiteRecoveryProtectionContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectionContainerName"/> is null. </exception>
        public virtual Response<bool> Exists(string protectionContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));

            using var scope = _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics.CreateScope("SiteRecoveryProtectionContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectionContainerName"/> is null. </exception>
        public virtual async Task<NullableResponse<SiteRecoveryProtectionContainerResource>> GetIfExistsAsync(string protectionContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));

            using var scope = _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics.CreateScope("SiteRecoveryProtectionContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryProtectionContainerResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryProtectionContainerResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationProtectionContainers/{protectionContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationProtectionContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SiteRecoveryProtectionContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="protectionContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="protectionContainerName"/> is null. </exception>
        public virtual NullableResponse<SiteRecoveryProtectionContainerResource> GetIfExists(string protectionContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));

            using var scope = _siteRecoveryProtectionContainerReplicationProtectionContainersClientDiagnostics.CreateScope("SiteRecoveryProtectionContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _siteRecoveryProtectionContainerReplicationProtectionContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, protectionContainerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SiteRecoveryProtectionContainerResource>(response.GetRawResponse());
                return Response.FromValue(new SiteRecoveryProtectionContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SiteRecoveryProtectionContainerResource> IEnumerable<SiteRecoveryProtectionContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteRecoveryProtectionContainerResource> IAsyncEnumerable<SiteRecoveryProtectionContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
