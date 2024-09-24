// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The content of the event request message. </summary>
    public partial class ContainerRegistryEventData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEventData"/>. </summary>
        /// <param name="target"> The target of the event. </param>
        /// <param name="request"> The request that generated the event. </param>
        /// <param name="actor"> The agent that initiated the event. For most situations, this could be from the authorization context of the request. </param>
        /// <param name="source"> The registry node that generated the event. Put differently, while the actor initiates the event, the source generates it. </param>
        /// <param name="connectedRegistry"> The connected registry information if the event is generated by a connected registry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/>, <paramref name="request"/>, <paramref name="actor"/>, <paramref name="source"/> or <paramref name="connectedRegistry"/> is null. </exception>
        internal ContainerRegistryEventData(ContainerRegistryEventTarget target, ContainerRegistryEventRequest request, ContainerRegistryEventActor actor, ContainerRegistryEventSource source, ContainerRegistryEventConnectedRegistry connectedRegistry)
        {
            Argument.AssertNotNull(target, nameof(target));
            Argument.AssertNotNull(request, nameof(request));
            Argument.AssertNotNull(actor, nameof(actor));
            Argument.AssertNotNull(source, nameof(source));
            Argument.AssertNotNull(connectedRegistry, nameof(connectedRegistry));

            Target = target;
            Request = request;
            Actor = actor;
            Source = source;
            ConnectedRegistry = connectedRegistry;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEventData"/>. </summary>
        /// <param name="id"> The event ID. </param>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="action"> The action that encompasses the provided event. </param>
        /// <param name="location"> The location of the event. </param>
        /// <param name="target"> The target of the event. </param>
        /// <param name="request"> The request that generated the event. </param>
        /// <param name="actor"> The agent that initiated the event. For most situations, this could be from the authorization context of the request. </param>
        /// <param name="source"> The registry node that generated the event. Put differently, while the actor initiates the event, the source generates it. </param>
        /// <param name="connectedRegistry"> The connected registry information if the event is generated by a connected registry. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryEventData(string id, DateTimeOffset? timestamp, string action, string location, ContainerRegistryEventTarget target, ContainerRegistryEventRequest request, ContainerRegistryEventActor actor, ContainerRegistryEventSource source, ContainerRegistryEventConnectedRegistry connectedRegistry, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Timestamp = timestamp;
            Action = action;
            Location = location;
            Target = target;
            Request = request;
            Actor = actor;
            Source = source;
            ConnectedRegistry = connectedRegistry;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryEventData"/> for deserialization. </summary>
        internal ContainerRegistryEventData()
        {
        }

        /// <summary> The event ID. </summary>
        public string Id { get; }
        /// <summary> The time at which the event occurred. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The action that encompasses the provided event. </summary>
        public string Action { get; }
        /// <summary> The location of the event. </summary>
        public string Location { get; }
        /// <summary> The target of the event. </summary>
        public ContainerRegistryEventTarget Target { get; }
        /// <summary> The request that generated the event. </summary>
        public ContainerRegistryEventRequest Request { get; }
        /// <summary> The agent that initiated the event. For most situations, this could be from the authorization context of the request. </summary>
        public ContainerRegistryEventActor Actor { get; }
        /// <summary> The registry node that generated the event. Put differently, while the actor initiates the event, the source generates it. </summary>
        public ContainerRegistryEventSource Source { get; }
        /// <summary> The connected registry information if the event is generated by a connected registry. </summary>
        public ContainerRegistryEventConnectedRegistry ConnectedRegistry { get; }
    }
}
