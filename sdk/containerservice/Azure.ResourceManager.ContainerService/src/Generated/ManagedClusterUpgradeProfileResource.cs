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

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A Class representing a ManagedClusterUpgradeProfile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ManagedClusterUpgradeProfileResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetManagedClusterUpgradeProfileResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerServiceManagedClusterResource"/> using the GetManagedClusterUpgradeProfile method.
    /// </summary>
    public partial class ManagedClusterUpgradeProfileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedClusterUpgradeProfileResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/upgradeProfiles/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedClusterUpgradeProfileManagedClustersClientDiagnostics;
        private readonly ManagedClustersRestOperations _managedClusterUpgradeProfileManagedClustersRestClient;
        private readonly ManagedClusterUpgradeProfileData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerService/managedClusters/upgradeProfiles";

        /// <summary> Initializes a new instance of the <see cref="ManagedClusterUpgradeProfileResource"/> class for mocking. </summary>
        protected ManagedClusterUpgradeProfileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedClusterUpgradeProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedClusterUpgradeProfileResource(ArmClient client, ManagedClusterUpgradeProfileData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedClusterUpgradeProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedClusterUpgradeProfileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedClusterUpgradeProfileManagedClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedClusterUpgradeProfileManagedClustersApiVersion);
            _managedClusterUpgradeProfileManagedClustersRestClient = new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedClusterUpgradeProfileManagedClustersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ManagedClusterUpgradeProfileData Data
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
        /// Gets the upgrade profile of a managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/upgradeProfiles/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedClusterUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedClusterUpgradeProfileResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedClusterUpgradeProfileManagedClustersClientDiagnostics.CreateScope("ManagedClusterUpgradeProfileResource.Get");
            scope.Start();
            try
            {
                var response = await _managedClusterUpgradeProfileManagedClustersRestClient.GetUpgradeProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedClusterUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the upgrade profile of a managed cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/upgradeProfiles/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedClusterUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedClusterUpgradeProfileResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedClusterUpgradeProfileManagedClustersClientDiagnostics.CreateScope("ManagedClusterUpgradeProfileResource.Get");
            scope.Start();
            try
            {
                var response = _managedClusterUpgradeProfileManagedClustersRestClient.GetUpgradeProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedClusterUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
