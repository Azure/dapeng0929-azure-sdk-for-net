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
    /// A class representing a collection of <see cref="MeshUpgradeProfileResource"/> and their operations.
    /// Each <see cref="MeshUpgradeProfileResource"/> in the collection will belong to the same instance of <see cref="ContainerServiceManagedClusterResource"/>.
    /// To get a <see cref="MeshUpgradeProfileCollection"/> instance call the GetMeshUpgradeProfiles method from an instance of <see cref="ContainerServiceManagedClusterResource"/>.
    /// </summary>
    public partial class MeshUpgradeProfileCollection : ArmCollection, IEnumerable<MeshUpgradeProfileResource>, IAsyncEnumerable<MeshUpgradeProfileResource>
    {
        private readonly ClientDiagnostics _meshUpgradeProfileManagedClustersClientDiagnostics;
        private readonly ManagedClustersRestOperations _meshUpgradeProfileManagedClustersRestClient;

        /// <summary> Initializes a new instance of the <see cref="MeshUpgradeProfileCollection"/> class for mocking. </summary>
        protected MeshUpgradeProfileCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MeshUpgradeProfileCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MeshUpgradeProfileCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _meshUpgradeProfileManagedClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", MeshUpgradeProfileResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MeshUpgradeProfileResource.ResourceType, out string meshUpgradeProfileManagedClustersApiVersion);
            _meshUpgradeProfileManagedClustersRestClient = new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, meshUpgradeProfileManagedClustersApiVersion);
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
        /// Gets available upgrades for a service mesh in a cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/meshUpgradeProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual async Task<Response<MeshUpgradeProfileResource>> GetAsync(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshUpgradeProfileManagedClustersClientDiagnostics.CreateScope("MeshUpgradeProfileCollection.Get");
            scope.Start();
            try
            {
                var response = await _meshUpgradeProfileManagedClustersRestClient.GetMeshUpgradeProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mode, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MeshUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets available upgrades for a service mesh in a cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/meshUpgradeProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual Response<MeshUpgradeProfileResource> Get(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshUpgradeProfileManagedClustersClientDiagnostics.CreateScope("MeshUpgradeProfileCollection.Get");
            scope.Start();
            try
            {
                var response = _meshUpgradeProfileManagedClustersRestClient.GetMeshUpgradeProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mode, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MeshUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists available upgrades for all service meshes in a specific cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/meshUpgradeProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_ListMeshUpgradeProfiles</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MeshUpgradeProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MeshUpgradeProfileResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _meshUpgradeProfileManagedClustersRestClient.CreateListMeshUpgradeProfilesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _meshUpgradeProfileManagedClustersRestClient.CreateListMeshUpgradeProfilesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MeshUpgradeProfileResource(Client, MeshUpgradeProfileData.DeserializeMeshUpgradeProfileData(e)), _meshUpgradeProfileManagedClustersClientDiagnostics, Pipeline, "MeshUpgradeProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists available upgrades for all service meshes in a specific cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/meshUpgradeProfiles</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_ListMeshUpgradeProfiles</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MeshUpgradeProfileResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MeshUpgradeProfileResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _meshUpgradeProfileManagedClustersRestClient.CreateListMeshUpgradeProfilesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _meshUpgradeProfileManagedClustersRestClient.CreateListMeshUpgradeProfilesNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MeshUpgradeProfileResource(Client, MeshUpgradeProfileData.DeserializeMeshUpgradeProfileData(e)), _meshUpgradeProfileManagedClustersClientDiagnostics, Pipeline, "MeshUpgradeProfileCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/meshUpgradeProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshUpgradeProfileResource"/></description>
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

            using var scope = _meshUpgradeProfileManagedClustersClientDiagnostics.CreateScope("MeshUpgradeProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = await _meshUpgradeProfileManagedClustersRestClient.GetMeshUpgradeProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mode, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/meshUpgradeProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshUpgradeProfileResource"/></description>
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

            using var scope = _meshUpgradeProfileManagedClustersClientDiagnostics.CreateScope("MeshUpgradeProfileCollection.Exists");
            scope.Start();
            try
            {
                var response = _meshUpgradeProfileManagedClustersRestClient.GetMeshUpgradeProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mode, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/meshUpgradeProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual async Task<NullableResponse<MeshUpgradeProfileResource>> GetIfExistsAsync(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshUpgradeProfileManagedClustersClientDiagnostics.CreateScope("MeshUpgradeProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _meshUpgradeProfileManagedClustersRestClient.GetMeshUpgradeProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mode, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MeshUpgradeProfileResource>(response.GetRawResponse());
                return Response.FromValue(new MeshUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/meshUpgradeProfiles/{mode}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetMeshUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="MeshUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="mode"> The mode of the mesh. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mode"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mode"/> is null. </exception>
        public virtual NullableResponse<MeshUpgradeProfileResource> GetIfExists(string mode, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(mode, nameof(mode));

            using var scope = _meshUpgradeProfileManagedClustersClientDiagnostics.CreateScope("MeshUpgradeProfileCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _meshUpgradeProfileManagedClustersRestClient.GetMeshUpgradeProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, mode, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MeshUpgradeProfileResource>(response.GetRawResponse());
                return Response.FromValue(new MeshUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MeshUpgradeProfileResource> IEnumerable<MeshUpgradeProfileResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MeshUpgradeProfileResource> IAsyncEnumerable<MeshUpgradeProfileResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
