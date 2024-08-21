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

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerServiceTrustedAccessRoleBindingResource"/> and their operations.
    /// Each <see cref="ContainerServiceTrustedAccessRoleBindingResource"/> in the collection will belong to the same instance of <see cref="ContainerServiceManagedClusterResource"/>.
    /// To get a <see cref="ContainerServiceTrustedAccessRoleBindingCollection"/> instance call the GetContainerServiceTrustedAccessRoleBindings method from an instance of <see cref="ContainerServiceManagedClusterResource"/>.
    /// </summary>
    public partial class ContainerServiceTrustedAccessRoleBindingCollection : ArmCollection, IEnumerable<ContainerServiceTrustedAccessRoleBindingResource>, IAsyncEnumerable<ContainerServiceTrustedAccessRoleBindingResource>
    {
        private readonly ClientDiagnostics _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics;
        private readonly TrustedAccessRoleBindingsRestOperations _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceTrustedAccessRoleBindingCollection"/> class for mocking. </summary>
        protected ContainerServiceTrustedAccessRoleBindingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerServiceTrustedAccessRoleBindingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerServiceTrustedAccessRoleBindingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ContainerServiceTrustedAccessRoleBindingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerServiceTrustedAccessRoleBindingResource.ResourceType, out string containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsApiVersion);
            _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient = new TrustedAccessRoleBindingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerServiceManagedClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerServiceManagedClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a trusted access role binding
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="data"> A trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedAccessRoleBindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerServiceTrustedAccessRoleBindingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string trustedAccessRoleBindingName, ContainerServiceTrustedAccessRoleBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerServiceArmOperation<ContainerServiceTrustedAccessRoleBindingResource>(new ContainerServiceTrustedAccessRoleBindingOperationSource(Client), _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics, Pipeline, _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a trusted access role binding
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="data"> A trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedAccessRoleBindingName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerServiceTrustedAccessRoleBindingResource> CreateOrUpdate(WaitUntil waitUntil, string trustedAccessRoleBindingName, ContainerServiceTrustedAccessRoleBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, data, cancellationToken);
                var operation = new ContainerServiceArmOperation<ContainerServiceTrustedAccessRoleBindingResource>(new ContainerServiceTrustedAccessRoleBindingOperationSource(Client), _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics, Pipeline, _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get a trusted access role binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        public virtual async Task<Response<ContainerServiceTrustedAccessRoleBindingResource>> GetAsync(string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceTrustedAccessRoleBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a trusted access role binding.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        public virtual Response<ContainerServiceTrustedAccessRoleBindingResource> Get(string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingCollection.Get");
            scope.Start();
            try
            {
                var response = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceTrustedAccessRoleBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List trusted access role bindings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerServiceTrustedAccessRoleBindingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerServiceTrustedAccessRoleBindingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerServiceTrustedAccessRoleBindingResource(Client, ContainerServiceTrustedAccessRoleBindingData.DeserializeContainerServiceTrustedAccessRoleBindingData(e)), _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics, Pipeline, "ContainerServiceTrustedAccessRoleBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List trusted access role bindings.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerServiceTrustedAccessRoleBindingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerServiceTrustedAccessRoleBindingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerServiceTrustedAccessRoleBindingResource(Client, ContainerServiceTrustedAccessRoleBindingData.DeserializeContainerServiceTrustedAccessRoleBindingData(e)), _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics, Pipeline, "ContainerServiceTrustedAccessRoleBindingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        public virtual Response<bool> Exists(string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerServiceTrustedAccessRoleBindingResource>> GetIfExistsAsync(string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerServiceTrustedAccessRoleBindingResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceTrustedAccessRoleBindingResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/trustedAccessRoleBindings/{trustedAccessRoleBindingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TrustedAccessRoleBindings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerServiceTrustedAccessRoleBindingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="trustedAccessRoleBindingName"> The name of trusted access role binding. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="trustedAccessRoleBindingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="trustedAccessRoleBindingName"/> is null. </exception>
        public virtual NullableResponse<ContainerServiceTrustedAccessRoleBindingResource> GetIfExists(string trustedAccessRoleBindingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(trustedAccessRoleBindingName, nameof(trustedAccessRoleBindingName));

            using var scope = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsClientDiagnostics.CreateScope("ContainerServiceTrustedAccessRoleBindingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerServiceTrustedAccessRoleBindingTrustedAccessRoleBindingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, trustedAccessRoleBindingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerServiceTrustedAccessRoleBindingResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerServiceTrustedAccessRoleBindingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerServiceTrustedAccessRoleBindingResource> IEnumerable<ContainerServiceTrustedAccessRoleBindingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerServiceTrustedAccessRoleBindingResource> IAsyncEnumerable<ContainerServiceTrustedAccessRoleBindingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
