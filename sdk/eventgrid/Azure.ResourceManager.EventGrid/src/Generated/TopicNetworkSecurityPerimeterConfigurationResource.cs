// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A Class representing a TopicNetworkSecurityPerimeterConfiguration along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="TopicNetworkSecurityPerimeterConfigurationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetTopicNetworkSecurityPerimeterConfigurationResource method.
    /// Otherwise you can get one from its parent resource <see cref="EventGridTopicResource" /> using the GetTopicNetworkSecurityPerimeterConfiguration method.
    /// </summary>
    public partial class TopicNetworkSecurityPerimeterConfigurationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TopicNetworkSecurityPerimeterConfigurationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="resourceName"> The resourceName. </param>
        /// <param name="perimeterGuid"> The perimeterGuid. </param>
        /// <param name="associationName"> The associationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string perimeterGuid, string associationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}/./{associationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics;
        private readonly NetworkSecurityPerimeterConfigurationsRestOperations _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient;
        private readonly NetworkSecurityPerimeterConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="TopicNetworkSecurityPerimeterConfigurationResource"/> class for mocking. </summary>
        protected TopicNetworkSecurityPerimeterConfigurationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TopicNetworkSecurityPerimeterConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TopicNetworkSecurityPerimeterConfigurationResource(ArmClient client, NetworkSecurityPerimeterConfigurationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TopicNetworkSecurityPerimeterConfigurationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TopicNetworkSecurityPerimeterConfigurationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsApiVersion);
            _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient = new NetworkSecurityPerimeterConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EventGrid/topics/networkSecurityPerimeterConfigurations/.";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkSecurityPerimeterConfigurationData Data
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
        /// Get a specific network security perimeter configuration with a topic or domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TopicNetworkSecurityPerimeterConfigurationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = await _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific network security perimeter configuration with a topic or domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TopicNetworkSecurityPerimeterConfigurationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationResource.Get");
            scope.Start();
            try
            {
                var response = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TopicNetworkSecurityPerimeterConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Reconcile a specific network security perimeter configuration for a given network security perimeter association with a topic or domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}/reconcile</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Reconcile</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<TopicNetworkSecurityPerimeterConfigurationResource>> ReconcileAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationResource.Reconcile");
            scope.Start();
            try
            {
                var response = await _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.ReconcileAsync(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<TopicNetworkSecurityPerimeterConfigurationResource>(new TopicNetworkSecurityPerimeterConfigurationOperationSource(Client), _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics, Pipeline, _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.CreateReconcileRequest(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Reconcile a specific network security perimeter configuration for a given network security perimeter association with a topic or domain.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/{resourceType}/{resourceName}/networkSecurityPerimeterConfigurations/{perimeterGuid}.{associationName}/reconcile</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkSecurityPerimeterConfigurations_Reconcile</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<TopicNetworkSecurityPerimeterConfigurationResource> Reconcile(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics.CreateScope("TopicNetworkSecurityPerimeterConfigurationResource.Reconcile");
            scope.Start();
            try
            {
                var response = _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.Reconcile(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new EventGridArmOperation<TopicNetworkSecurityPerimeterConfigurationResource>(new TopicNetworkSecurityPerimeterConfigurationOperationSource(Client), _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsClientDiagnostics, Pipeline, _topicNetworkSecurityPerimeterConfigurationNetworkSecurityPerimeterConfigurationsRestClient.CreateReconcileRequest(Id.SubscriptionId, Id.ResourceGroupName, "topics", Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
    }
}
