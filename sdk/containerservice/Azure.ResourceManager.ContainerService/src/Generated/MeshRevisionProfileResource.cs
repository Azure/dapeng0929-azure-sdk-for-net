// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A Class representing a MeshRevisionProfile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="MeshRevisionProfileResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetMeshRevisionProfileResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetMeshRevisionProfile method.
    /// </summary>
    public partial class MeshRevisionProfileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MeshRevisionProfileResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        /// <param name="mode"> The mode. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string mode)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/meshRevisionProfiles/{mode}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _meshRevisionProfileManagedClustersClientDiagnostics;
        private readonly ManagedClustersRestOperations _meshRevisionProfileManagedClustersRestClient;
        private readonly MeshRevisionProfileData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerService/locations/meshRevisionProfiles";

        /// <summary> Initializes a new instance of the <see cref="MeshRevisionProfileResource"/> class for mocking. </summary>
        protected MeshRevisionProfileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MeshRevisionProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MeshRevisionProfileResource(ArmClient client, MeshRevisionProfileData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MeshRevisionProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MeshRevisionProfileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _meshRevisionProfileManagedClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string meshRevisionProfileManagedClustersApiVersion);
            _meshRevisionProfileManagedClustersRestClient = new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, meshRevisionProfileManagedClustersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MeshRevisionProfileData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MeshRevisionProfileResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _meshRevisionProfileManagedClustersClientDiagnostics.CreateScope("MeshRevisionProfileResource.Get");
            scope.Start();
            try
            {
                var response = await _meshRevisionProfileManagedClustersRestClient.GetMeshRevisionProfileAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MeshRevisionProfileResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _meshRevisionProfileManagedClustersClientDiagnostics.CreateScope("MeshRevisionProfileResource.Get");
            scope.Start();
            try
            {
                var response = _meshRevisionProfileManagedClustersRestClient.GetMeshRevisionProfile(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
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
    }
}
