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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualWanResource"/> and their operations.
    /// Each <see cref="VirtualWanResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="VirtualWanCollection"/> instance call the GetVirtualWans method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class VirtualWanCollection : ArmCollection, IEnumerable<VirtualWanResource>, IAsyncEnumerable<VirtualWanResource>
    {
        private readonly ClientDiagnostics _virtualWanClientDiagnostics;
        private readonly VirtualWansRestOperations _virtualWanRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualWanCollection"/> class for mocking. </summary>
        protected VirtualWanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualWanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualWanCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualWanClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualWanResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualWanResource.ResourceType, out string virtualWanApiVersion);
            _virtualWanRestClient = new VirtualWansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualWanApiVersion);
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
        /// Creates a VirtualWAN resource if it doesn't exist else updates the existing VirtualWAN.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{VirtualWANName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualWanName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="data"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualWanResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualWanName, VirtualWanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualWanRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualWanResource>(new VirtualWanOperationSource(Client), _virtualWanClientDiagnostics, Pipeline, _virtualWanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a VirtualWAN resource if it doesn't exist else updates the existing VirtualWAN.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{VirtualWANName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualWanName"> The name of the VirtualWAN being created or updated. </param>
        /// <param name="data"> Parameters supplied to create or update VirtualWAN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualWanResource> CreateOrUpdate(WaitUntil waitUntil, string virtualWanName, VirtualWanData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualWanRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, data, cancellationToken);
                var operation = new NetworkArmOperation<VirtualWanResource>(new VirtualWanOperationSource(Client), _virtualWanClientDiagnostics, Pipeline, _virtualWanRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a VirtualWAN.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{VirtualWANName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual async Task<Response<VirtualWanResource>> GetAsync(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualWanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualWanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a VirtualWAN.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{VirtualWANName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual Response<VirtualWanResource> Get(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualWanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualWanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the VirtualWANs in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualWanResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualWanResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualWanRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualWanRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new VirtualWanResource(Client, VirtualWanData.DeserializeVirtualWanData(e)), _virtualWanClientDiagnostics, Pipeline, "VirtualWanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the VirtualWANs in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualWanResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualWanResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualWanRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualWanRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new VirtualWanResource(Client, VirtualWanData.DeserializeVirtualWanData(e)), _virtualWanClientDiagnostics, Pipeline, "VirtualWanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{VirtualWANName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualWanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{VirtualWANName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualWanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{VirtualWANName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualWanResource>> GetIfExistsAsync(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualWanRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualWanResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualWanResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualWans/{VirtualWANName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualWans_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VirtualWanResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualWanName"> The name of the VirtualWAN being retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualWanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualWanName"/> is null. </exception>
        public virtual NullableResponse<VirtualWanResource> GetIfExists(string virtualWanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualWanName, nameof(virtualWanName));

            using var scope = _virtualWanClientDiagnostics.CreateScope("VirtualWanCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualWanRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualWanName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualWanResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualWanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualWanResource> IEnumerable<VirtualWanResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualWanResource> IAsyncEnumerable<VirtualWanResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
