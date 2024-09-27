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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.StandbyPool
{
    /// <summary>
    /// A class representing a collection of <see cref="StandbyContainerGroupPoolResource"/> and their operations.
    /// Each <see cref="StandbyContainerGroupPoolResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="StandbyContainerGroupPoolCollection"/> instance call the GetStandbyContainerGroupPools method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class StandbyContainerGroupPoolCollection : ArmCollection, IEnumerable<StandbyContainerGroupPoolResource>, IAsyncEnumerable<StandbyContainerGroupPoolResource>
    {
        private readonly ClientDiagnostics _standbyContainerGroupPoolClientDiagnostics;
        private readonly StandbyContainerGroupPoolsRestOperations _standbyContainerGroupPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="StandbyContainerGroupPoolCollection"/> class for mocking. </summary>
        protected StandbyContainerGroupPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StandbyContainerGroupPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StandbyContainerGroupPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _standbyContainerGroupPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StandbyPool", StandbyContainerGroupPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StandbyContainerGroupPoolResource.ResourceType, out string standbyContainerGroupPoolApiVersion);
            _standbyContainerGroupPoolRestClient = new StandbyContainerGroupPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, standbyContainerGroupPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="standbyContainerGroupPoolName"> The <see cref="string"/> to use. </param>
        /// <param name="data"> The <see cref="StandbyContainerGroupPoolData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StandbyContainerGroupPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string standbyContainerGroupPoolName, StandbyContainerGroupPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _standbyContainerGroupPoolClientDiagnostics.CreateScope("StandbyContainerGroupPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _standbyContainerGroupPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new StandbyPoolArmOperation<StandbyContainerGroupPoolResource>(new StandbyContainerGroupPoolOperationSource(Client), _standbyContainerGroupPoolClientDiagnostics, Pipeline, _standbyContainerGroupPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="standbyContainerGroupPoolName"> The <see cref="string"/> to use. </param>
        /// <param name="data"> The <see cref="StandbyContainerGroupPoolData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StandbyContainerGroupPoolResource> CreateOrUpdate(WaitUntil waitUntil, string standbyContainerGroupPoolName, StandbyContainerGroupPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _standbyContainerGroupPoolClientDiagnostics.CreateScope("StandbyContainerGroupPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _standbyContainerGroupPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, data, cancellationToken);
                var operation = new StandbyPoolArmOperation<StandbyContainerGroupPoolResource>(new StandbyContainerGroupPoolOperationSource(Client), _standbyContainerGroupPoolClientDiagnostics, Pipeline, _standbyContainerGroupPoolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyContainerGroupPoolName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        public virtual async Task<Response<StandbyContainerGroupPoolResource>> GetAsync(string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var scope = _standbyContainerGroupPoolClientDiagnostics.CreateScope("StandbyContainerGroupPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _standbyContainerGroupPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyContainerGroupPoolName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        public virtual Response<StandbyContainerGroupPoolResource> Get(string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var scope = _standbyContainerGroupPoolClientDiagnostics.CreateScope("StandbyContainerGroupPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _standbyContainerGroupPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List StandbyContainerGroupPoolResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StandbyContainerGroupPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StandbyContainerGroupPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _standbyContainerGroupPoolRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _standbyContainerGroupPoolRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StandbyContainerGroupPoolResource(Client, StandbyContainerGroupPoolData.DeserializeStandbyContainerGroupPoolData(e)), _standbyContainerGroupPoolClientDiagnostics, Pipeline, "StandbyContainerGroupPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List StandbyContainerGroupPoolResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolResource_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StandbyContainerGroupPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StandbyContainerGroupPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _standbyContainerGroupPoolRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _standbyContainerGroupPoolRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StandbyContainerGroupPoolResource(Client, StandbyContainerGroupPoolData.DeserializeStandbyContainerGroupPoolData(e)), _standbyContainerGroupPoolClientDiagnostics, Pipeline, "StandbyContainerGroupPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyContainerGroupPoolName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var scope = _standbyContainerGroupPoolClientDiagnostics.CreateScope("StandbyContainerGroupPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _standbyContainerGroupPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyContainerGroupPoolName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var scope = _standbyContainerGroupPoolClientDiagnostics.CreateScope("StandbyContainerGroupPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _standbyContainerGroupPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyContainerGroupPoolName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        public virtual async Task<NullableResponse<StandbyContainerGroupPoolResource>> GetIfExistsAsync(string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var scope = _standbyContainerGroupPoolClientDiagnostics.CreateScope("StandbyContainerGroupPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _standbyContainerGroupPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StandbyContainerGroupPoolResource>(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="standbyContainerGroupPoolName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        public virtual NullableResponse<StandbyContainerGroupPoolResource> GetIfExists(string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(standbyContainerGroupPoolName, nameof(standbyContainerGroupPoolName));

            using var scope = _standbyContainerGroupPoolClientDiagnostics.CreateScope("StandbyContainerGroupPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _standbyContainerGroupPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, standbyContainerGroupPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StandbyContainerGroupPoolResource>(response.GetRawResponse());
                return Response.FromValue(new StandbyContainerGroupPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StandbyContainerGroupPoolResource> IEnumerable<StandbyContainerGroupPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StandbyContainerGroupPoolResource> IAsyncEnumerable<StandbyContainerGroupPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
