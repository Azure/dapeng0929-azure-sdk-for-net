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
    /// A class representing a collection of <see cref="MeshRevisionProfileResource"/> and their operations.
    /// Each <see cref="MeshRevisionProfileResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="MeshRevisionProfileCollection"/> instance call the GetMeshRevisionProfiles method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class MeshRevisionProfileCollection : ArmCollection, IEnumerable<MeshRevisionProfileResource>, IAsyncEnumerable<MeshRevisionProfileResource>
    {
        private readonly ClientDiagnostics _meshRevisionProfileManagedClustersClientDiagnostics;
        private readonly ManagedClustersRestOperations _meshRevisionProfileManagedClustersRestClient;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="MeshRevisionProfileCollection"/> class for mocking. </summary>
        protected MeshRevisionProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MeshRevisionProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="location"> The name of the Azure region. </param>
        internal MeshRevisionProfileCollection(ArmClient client, ResourceIdentifier id, AzureLocation location) : base(client, id)
        {
            _location = location;
            _meshRevisionProfileManagedClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", MeshRevisionProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MeshRevisionProfileResource.ResourceType, out string meshRevisionProfileManagedClustersApiVersion);
            _meshRevisionProfileManagedClustersRestClient = new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, meshRevisionProfileManagedClustersApiVersion);
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
        /// Contains extra metadata on the revision, including supported revisions, cluster compatibility and available upgrades
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/meshRevisionProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshRevisionProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshRevisionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual async Task<Response<MeshRevisionProfileResource>> GetAsync(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshRevisionProfileManagedClustersClientDiagnostics.CreateScope("MeshRevisionProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _meshRevisionProfileManagedClustersRestClient.GetMeshRevisionProfileAsync(Id.SubscriptionId, new AzureLocation(_location), mode, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MeshRevisionProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Contains extra metadata on the revision, including supported revisions, cluster compatibility and available upgrades
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/meshRevisionProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshRevisionProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshRevisionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual Response<MeshRevisionProfileResource> Get(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshRevisionProfileManagedClustersClientDiagnostics.CreateScope("MeshRevisionProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _meshRevisionProfileManagedClustersRestClient.GetMeshRevisionProfile(Id.SubscriptionId, new AzureLocation(_location), mode, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MeshRevisionProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Contains extra metadata on each revision, including supported revisions, cluster compatibility and available upgrades
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/meshRevisionProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_ListMeshRevisionProfiles</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshRevisionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MeshRevisionProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MeshRevisionProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _meshRevisionProfileManagedClustersRestClient.CreateListMeshRevisionProfilesRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _meshRevisionProfileManagedClustersRestClient.CreateListMeshRevisionProfilesNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MeshRevisionProfileResource(Client, MeshRevisionProfileData.DeserializeMeshRevisionProfileData(e)), _meshRevisionProfileManagedClustersClientDiagnostics, Pipeline, "MeshRevisionProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Contains extra metadata on each revision, including supported revisions, cluster compatibility and available upgrades
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/meshRevisionProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_ListMeshRevisionProfiles</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshRevisionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MeshRevisionProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MeshRevisionProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _meshRevisionProfileManagedClustersRestClient.CreateListMeshRevisionProfilesRequest(Id.SubscriptionId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _meshRevisionProfileManagedClustersRestClient.CreateListMeshRevisionProfilesNextPageRequest(nextLink, Id.SubscriptionId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MeshRevisionProfileResource(Client, MeshRevisionProfileData.DeserializeMeshRevisionProfileData(e)), _meshRevisionProfileManagedClustersClientDiagnostics, Pipeline, "MeshRevisionProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/meshRevisionProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshRevisionProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshRevisionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshRevisionProfileManagedClustersClientDiagnostics.CreateScope("MeshRevisionProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _meshRevisionProfileManagedClustersRestClient.GetMeshRevisionProfileAsync(Id.SubscriptionId, new AzureLocation(_location), mode, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/meshRevisionProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshRevisionProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshRevisionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual Response<bool> Exists(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshRevisionProfileManagedClustersClientDiagnostics.CreateScope("MeshRevisionProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _meshRevisionProfileManagedClustersRestClient.GetMeshRevisionProfile(Id.SubscriptionId, new AzureLocation(_location), mode, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/meshRevisionProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshRevisionProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshRevisionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual async Task<NullableResponse<MeshRevisionProfileResource>> GetIfExistsAsync(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshRevisionProfileManagedClustersClientDiagnostics.CreateScope("MeshRevisionProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _meshRevisionProfileManagedClustersRestClient.GetMeshRevisionProfileAsync(Id.SubscriptionId, new AzureLocation(_location), mode, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MeshRevisionProfileResource>(response.GetRawResponse());
                return Response.FromValue(new MeshRevisionProfileResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/meshRevisionProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshRevisionProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshRevisionProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual NullableResponse<MeshRevisionProfileResource> GetIfExists(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshRevisionProfileManagedClustersClientDiagnostics.CreateScope("MeshRevisionProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _meshRevisionProfileManagedClustersRestClient.GetMeshRevisionProfile(Id.SubscriptionId, new AzureLocation(_location), mode, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MeshRevisionProfileResource>(response.GetRawResponse());
                return Response.FromValue(new MeshRevisionProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MeshRevisionProfileResource> IEnumerable<MeshRevisionProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MeshRevisionProfileResource> IAsyncEnumerable<MeshRevisionProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
