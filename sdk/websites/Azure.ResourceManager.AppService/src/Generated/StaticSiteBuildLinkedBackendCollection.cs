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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="StaticSiteBuildLinkedBackendResource" /> and their operations.
    /// Each <see cref="StaticSiteBuildLinkedBackendResource" /> in the collection will belong to the same instance of <see cref="StaticSiteBuildResource" />.
    /// To get a <see cref="StaticSiteBuildLinkedBackendCollection" /> instance call the GetStaticSiteBuildLinkedBackends method from an instance of <see cref="StaticSiteBuildResource" />.
    /// </summary>
    public partial class StaticSiteBuildLinkedBackendCollection : ArmCollection, IEnumerable<StaticSiteBuildLinkedBackendResource>, IAsyncEnumerable<StaticSiteBuildLinkedBackendResource>
    {
        private readonly ClientDiagnostics _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildLinkedBackendStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildLinkedBackendCollection"/> class for mocking. </summary>
        protected StaticSiteBuildLinkedBackendCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildLinkedBackendCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteBuildLinkedBackendCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteBuildLinkedBackendResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StaticSiteBuildLinkedBackendResource.ResourceType, out string staticSiteBuildLinkedBackendStaticSitesApiVersion);
            _staticSiteBuildLinkedBackendStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteBuildLinkedBackendStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteBuildResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteBuildResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Link backend to a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends/{linkedBackendName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_LinkBackendToBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkedBackendName"> Name of the backend to link to the static site. </param>
        /// <param name="data"> A JSON representation of the linked backend request properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedBackendName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedBackendName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteBuildLinkedBackendResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string linkedBackendName, StaticSiteLinkedBackendARMResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedBackendName, nameof(linkedBackendName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildLinkedBackendCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildLinkedBackendStaticSitesRestClient.LinkBackendToBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteBuildLinkedBackendResource>(new StaticSiteBuildLinkedBackendOperationSource(Client), _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildLinkedBackendStaticSitesRestClient.CreateLinkBackendToBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Link backend to a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends/{linkedBackendName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_LinkBackendToBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkedBackendName"> Name of the backend to link to the static site. </param>
        /// <param name="data"> A JSON representation of the linked backend request properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedBackendName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedBackendName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StaticSiteBuildLinkedBackendResource> CreateOrUpdate(WaitUntil waitUntil, string linkedBackendName, StaticSiteLinkedBackendARMResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedBackendName, nameof(linkedBackendName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildLinkedBackendCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteBuildLinkedBackendStaticSitesRestClient.LinkBackendToBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, data, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteBuildLinkedBackendResource>(new StaticSiteBuildLinkedBackendOperationSource(Client), _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics, Pipeline, _staticSiteBuildLinkedBackendStaticSitesRestClient.CreateLinkBackendToBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Returns the details of a linked backend linked to a static site build by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends/{linkedBackendName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetLinkedBackendForBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedBackendName"> Name of the linked backend that should be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedBackendName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedBackendName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteBuildLinkedBackendResource>> GetAsync(string linkedBackendName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedBackendName, nameof(linkedBackendName));

            using var scope = _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildLinkedBackendCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildLinkedBackendStaticSitesRestClient.GetLinkedBackendForBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildLinkedBackendResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the details of a linked backend linked to a static site build by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends/{linkedBackendName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetLinkedBackendForBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedBackendName"> Name of the linked backend that should be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedBackendName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedBackendName"/> is null. </exception>
        public virtual Response<StaticSiteBuildLinkedBackendResource> Get(string linkedBackendName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedBackendName, nameof(linkedBackendName));

            using var scope = _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildLinkedBackendCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildLinkedBackendStaticSitesRestClient.GetLinkedBackendForBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildLinkedBackendResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns details of all backends linked to a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetLinkedBackendsForBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteBuildLinkedBackendResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteBuildLinkedBackendResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildLinkedBackendStaticSitesRestClient.CreateGetLinkedBackendsForBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildLinkedBackendStaticSitesRestClient.CreateGetLinkedBackendsForBuildNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StaticSiteBuildLinkedBackendResource(Client, StaticSiteLinkedBackendARMResourceData.DeserializeStaticSiteLinkedBackendARMResourceData(e)), _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildLinkedBackendCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns details of all backends linked to a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetLinkedBackendsForBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteBuildLinkedBackendResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteBuildLinkedBackendResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildLinkedBackendStaticSitesRestClient.CreateGetLinkedBackendsForBuildRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildLinkedBackendStaticSitesRestClient.CreateGetLinkedBackendsForBuildNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StaticSiteBuildLinkedBackendResource(Client, StaticSiteLinkedBackendARMResourceData.DeserializeStaticSiteLinkedBackendARMResourceData(e)), _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildLinkedBackendCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends/{linkedBackendName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetLinkedBackendForBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedBackendName"> Name of the linked backend that should be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedBackendName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedBackendName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkedBackendName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedBackendName, nameof(linkedBackendName));

            using var scope = _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildLinkedBackendCollection.Exists");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildLinkedBackendStaticSitesRestClient.GetLinkedBackendForBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends/{linkedBackendName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetLinkedBackendForBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedBackendName"> Name of the linked backend that should be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedBackendName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedBackendName"/> is null. </exception>
        public virtual Response<bool> Exists(string linkedBackendName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedBackendName, nameof(linkedBackendName));

            using var scope = _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildLinkedBackendCollection.Exists");
            scope.Start();
            try
            {
                var response = _staticSiteBuildLinkedBackendStaticSitesRestClient.GetLinkedBackendForBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends/{linkedBackendName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetLinkedBackendForBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedBackendName"> Name of the linked backend that should be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedBackendName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedBackendName"/> is null. </exception>
        public virtual async Task<NullableResponse<StaticSiteBuildLinkedBackendResource>> GetIfExistsAsync(string linkedBackendName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedBackendName, nameof(linkedBackendName));

            using var scope = _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildLinkedBackendCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildLinkedBackendStaticSitesRestClient.GetLinkedBackendForBuildAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StaticSiteBuildLinkedBackendResource>(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildLinkedBackendResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/linkedBackends/{linkedBackendName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetLinkedBackendForBuild</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedBackendName"> Name of the linked backend that should be retrieved. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedBackendName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedBackendName"/> is null. </exception>
        public virtual NullableResponse<StaticSiteBuildLinkedBackendResource> GetIfExists(string linkedBackendName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedBackendName, nameof(linkedBackendName));

            using var scope = _staticSiteBuildLinkedBackendStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildLinkedBackendCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSiteBuildLinkedBackendStaticSitesRestClient.GetLinkedBackendForBuild(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, linkedBackendName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StaticSiteBuildLinkedBackendResource>(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildLinkedBackendResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteBuildLinkedBackendResource> IEnumerable<StaticSiteBuildLinkedBackendResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteBuildLinkedBackendResource> IAsyncEnumerable<StaticSiteBuildLinkedBackendResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
