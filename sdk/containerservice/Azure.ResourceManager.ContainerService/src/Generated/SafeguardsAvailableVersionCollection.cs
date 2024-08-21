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

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing a collection of <see cref="SafeguardsAvailableVersionResource"/> and their operations.
    /// Each <see cref="SafeguardsAvailableVersionResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="SafeguardsAvailableVersionCollection"/> instance call the GetSafeguardsAvailableVersions method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class SafeguardsAvailableVersionCollection : ArmCollection, IEnumerable<SafeguardsAvailableVersionResource>, IAsyncEnumerable<SafeguardsAvailableVersionResource>
    {
        private readonly ClientDiagnostics _safeguardsAvailableVersionManagedClustersClientDiagnostics;
        private readonly ManagedClustersRestOperations _safeguardsAvailableVersionManagedClustersRestClient;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="SafeguardsAvailableVersionCollection"/> class for mocking. </summary>
        protected SafeguardsAvailableVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SafeguardsAvailableVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> The name of the Azure region. </param>
        internal SafeguardsAvailableVersionCollection(ArmClient client, ResourceIdentifier id, AzureLocation location) : base(client, id)
        {
            _location = location;
            _safeguardsAvailableVersionManagedClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", SafeguardsAvailableVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SafeguardsAvailableVersionResource.ResourceType, out string safeguardsAvailableVersionManagedClustersApiVersion);
            _safeguardsAvailableVersionManagedClustersRestClient = new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, safeguardsAvailableVersionManagedClustersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Contains Safeguards version along with its support info and whether it is a default version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/safeguardsVersions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetSafeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SafeguardsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Safeguards version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<SafeguardsAvailableVersionResource>> GetAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _safeguardsAvailableVersionManagedClustersClientDiagnostics.CreateScope("SafeguardsAvailableVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _safeguardsAvailableVersionManagedClustersRestClient.GetSafeguardsVersionsAsync(Id.SubscriptionId, new AzureLocation(_location), version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SafeguardsAvailableVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Contains Safeguards version along with its support info and whether it is a default version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/safeguardsVersions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetSafeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SafeguardsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Safeguards version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<SafeguardsAvailableVersionResource> Get(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _safeguardsAvailableVersionManagedClustersClientDiagnostics.CreateScope("SafeguardsAvailableVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _safeguardsAvailableVersionManagedClustersRestClient.GetSafeguardsVersions(Id.SubscriptionId, new AzureLocation(_location), version, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SafeguardsAvailableVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Contains list of Safeguards version along with its support info and whether it is a default version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/safeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_ListSafeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SafeguardsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SafeguardsAvailableVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SafeguardsAvailableVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _safeguardsAvailableVersionManagedClustersRestClient.CreateListSafeguardsVersionsRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _safeguardsAvailableVersionManagedClustersRestClient.CreateListSafeguardsVersionsNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SafeguardsAvailableVersionResource(Client, SafeguardsAvailableVersionData.DeserializeSafeguardsAvailableVersionData(e)), _safeguardsAvailableVersionManagedClustersClientDiagnostics, Pipeline, "SafeguardsAvailableVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Contains list of Safeguards version along with its support info and whether it is a default version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/safeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_ListSafeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SafeguardsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SafeguardsAvailableVersionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SafeguardsAvailableVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _safeguardsAvailableVersionManagedClustersRestClient.CreateListSafeguardsVersionsRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _safeguardsAvailableVersionManagedClustersRestClient.CreateListSafeguardsVersionsNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SafeguardsAvailableVersionResource(Client, SafeguardsAvailableVersionData.DeserializeSafeguardsAvailableVersionData(e)), _safeguardsAvailableVersionManagedClustersClientDiagnostics, Pipeline, "SafeguardsAvailableVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/safeguardsVersions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetSafeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SafeguardsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Safeguards version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _safeguardsAvailableVersionManagedClustersClientDiagnostics.CreateScope("SafeguardsAvailableVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _safeguardsAvailableVersionManagedClustersRestClient.GetSafeguardsVersionsAsync(Id.SubscriptionId, new AzureLocation(_location), version, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/safeguardsVersions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetSafeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SafeguardsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Safeguards version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual Response<bool> Exists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _safeguardsAvailableVersionManagedClustersClientDiagnostics.CreateScope("SafeguardsAvailableVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _safeguardsAvailableVersionManagedClustersRestClient.GetSafeguardsVersions(Id.SubscriptionId, new AzureLocation(_location), version, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/safeguardsVersions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetSafeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SafeguardsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Safeguards version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual async Task<NullableResponse<SafeguardsAvailableVersionResource>> GetIfExistsAsync(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _safeguardsAvailableVersionManagedClustersClientDiagnostics.CreateScope("SafeguardsAvailableVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _safeguardsAvailableVersionManagedClustersRestClient.GetSafeguardsVersionsAsync(Id.SubscriptionId, new AzureLocation(_location), version, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SafeguardsAvailableVersionResource>(response.GetRawResponse());
                return Response.FromValue(new SafeguardsAvailableVersionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/safeguardsVersions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetSafeguardsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SafeguardsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="version"> Safeguards version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="version"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        public virtual NullableResponse<SafeguardsAvailableVersionResource> GetIfExists(string version, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(version, nameof(version));

            using var scope = _safeguardsAvailableVersionManagedClustersClientDiagnostics.CreateScope("SafeguardsAvailableVersionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _safeguardsAvailableVersionManagedClustersRestClient.GetSafeguardsVersions(Id.SubscriptionId, new AzureLocation(_location), version, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SafeguardsAvailableVersionResource>(response.GetRawResponse());
                return Response.FromValue(new SafeguardsAvailableVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SafeguardsAvailableVersionResource> IEnumerable<SafeguardsAvailableVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SafeguardsAvailableVersionResource> IAsyncEnumerable<SafeguardsAvailableVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
