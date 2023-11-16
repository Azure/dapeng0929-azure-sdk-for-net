// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the Namespace Topic destination for an event subscription. </summary>
    public partial class NamespaceTopicEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary> Initializes a new instance of NamespaceTopicEventSubscriptionDestination. </summary>
        public NamespaceTopicEventSubscriptionDestination()
        {
            EndpointType = EndpointType.NamespaceTopic;
        }

        /// <summary> Initializes a new instance of NamespaceTopicEventSubscriptionDestination. </summary>
        /// <param name="endpointType"> Type of the endpoint for the event subscription destination. </param>
        /// <param name="resourceId">
        /// The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of an event subscription.
        /// This field is required and the Namespace Topic resource listed must already exist.
        /// The resource ARM Id should follow this pattern: /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
        /// </param>
        internal NamespaceTopicEventSubscriptionDestination(EndpointType endpointType, ResourceIdentifier resourceId) : base(endpointType)
        {
            ResourceId = resourceId;
            EndpointType = endpointType;
        }

        /// <summary>
        /// The Azure resource Id that represents the endpoint of the Event Grid Namespace Topic destination of an event subscription.
        /// This field is required and the Namespace Topic resource listed must already exist.
        /// The resource ARM Id should follow this pattern: /subscriptions/{AzureSubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.EventGrid/namespaces/{NamespaceName}/topics/{TopicName}.
        /// </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
