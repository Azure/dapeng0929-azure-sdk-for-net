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
    /// A Class representing an AgentPoolUpgradeProfile along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AgentPoolUpgradeProfileResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAgentPoolUpgradeProfileResource method.
    /// Otherwise you can get one from its parent resource <see cref="ContainerServiceAgentPoolResource"/> using the GetAgentPoolUpgradeProfile method.
    /// </summary>
    public partial class AgentPoolUpgradeProfileResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AgentPoolUpgradeProfileResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="agentPoolName"> The agentPoolName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string agentPoolName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}/upgradeProfiles/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _agentPoolUpgradeProfileAgentPoolsClientDiagnostics;
        private readonly AgentPoolsRestOperations _agentPoolUpgradeProfileAgentPoolsRestClient;
        private readonly AgentPoolUpgradeProfileData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerService/managedClusters/agentPools/upgradeProfiles";

        /// <summary> Initializes a new instance of the <see cref="AgentPoolUpgradeProfileResource"/> class for mocking. </summary>
        protected AgentPoolUpgradeProfileResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AgentPoolUpgradeProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AgentPoolUpgradeProfileResource(ArmClient client, AgentPoolUpgradeProfileData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AgentPoolUpgradeProfileResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AgentPoolUpgradeProfileResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _agentPoolUpgradeProfileAgentPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string agentPoolUpgradeProfileAgentPoolsApiVersion);
            _agentPoolUpgradeProfileAgentPoolsRestClient = new AgentPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, agentPoolUpgradeProfileAgentPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AgentPoolUpgradeProfileData Data
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
        /// Gets the upgrade profile for an agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}/upgradeProfiles/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_GetUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgentPoolUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AgentPoolUpgradeProfileResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _agentPoolUpgradeProfileAgentPoolsClientDiagnostics.CreateScope("AgentPoolUpgradeProfileResource.Get");
            scope.Start();
            try
            {
                var response = await _agentPoolUpgradeProfileAgentPoolsRestClient.GetUpgradeProfileAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AgentPoolUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the upgrade profile for an agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/agentPools/{agentPoolName}/upgradeProfiles/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AgentPools_GetUpgradeProfile</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AgentPoolUpgradeProfileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AgentPoolUpgradeProfileResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _agentPoolUpgradeProfileAgentPoolsClientDiagnostics.CreateScope("AgentPoolUpgradeProfileResource.Get");
            scope.Start();
            try
            {
                var response = _agentPoolUpgradeProfileAgentPoolsRestClient.GetUpgradeProfile(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AgentPoolUpgradeProfileResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
