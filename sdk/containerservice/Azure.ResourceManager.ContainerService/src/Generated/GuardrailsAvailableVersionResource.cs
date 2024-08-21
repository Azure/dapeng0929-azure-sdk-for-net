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
    /// A Class representing a GuardrailsAvailableVersion along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GuardrailsAvailableVersionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGuardrailsAvailableVersionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetGuardrailsAvailableVersion method.
    /// </summary>
    public partial class GuardrailsAvailableVersionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GuardrailsAvailableVersionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="location"> The location. </param>
        /// <param name="version"> The version. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string version)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/guardrailsVersions/{version}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _guardrailsAvailableVersionManagedClustersClientDiagnostics;
        private readonly ManagedClustersRestOperations _guardrailsAvailableVersionManagedClustersRestClient;
        private readonly GuardrailsAvailableVersionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ContainerService/locations/guardrailsVersions";

        /// <summary> Initializes a new instance of the <see cref="GuardrailsAvailableVersionResource"/> class for mocking. </summary>
        protected GuardrailsAvailableVersionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GuardrailsAvailableVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GuardrailsAvailableVersionResource(ArmClient client, GuardrailsAvailableVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GuardrailsAvailableVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GuardrailsAvailableVersionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _guardrailsAvailableVersionManagedClustersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string guardrailsAvailableVersionManagedClustersApiVersion);
            _guardrailsAvailableVersionManagedClustersRestClient = new ManagedClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, guardrailsAvailableVersionManagedClustersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GuardrailsAvailableVersionData Data
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
        /// Contains Guardrails version along with its support info and whether it is a default version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/guardrailsVersions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetGuardrailsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuardrailsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GuardrailsAvailableVersionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _guardrailsAvailableVersionManagedClustersClientDiagnostics.CreateScope("GuardrailsAvailableVersionResource.Get");
            scope.Start();
            try
            {
                var response = await _guardrailsAvailableVersionManagedClustersRestClient.GetGuardrailsVersionsAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuardrailsAvailableVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Contains Guardrails version along with its support info and whether it is a default version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerService/locations/{location}/guardrailsVersions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedClusters_GetGuardrailsVersions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-02-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GuardrailsAvailableVersionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GuardrailsAvailableVersionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _guardrailsAvailableVersionManagedClustersClientDiagnostics.CreateScope("GuardrailsAvailableVersionResource.Get");
            scope.Start();
            try
            {
                var response = _guardrailsAvailableVersionManagedClustersRestClient.GetGuardrailsVersions(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GuardrailsAvailableVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
