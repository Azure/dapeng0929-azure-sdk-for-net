// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ContainerRegistry.ChartPushed event. </summary>
    public partial class ContainerRegistryChartPushedEventData : ContainerRegistryArtifactEventData
    {
        /// <summary> Initializes a new instance of <see cref="ContainerRegistryChartPushedEventData"/>. </summary>
        /// <param name="target"> The target of the event. </param>
        /// <param name="connectedRegistry"> The connected registry information if the event is generated by a connected registry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="target"/> or <paramref name="connectedRegistry"/> is null. </exception>
        internal ContainerRegistryChartPushedEventData(ContainerRegistryArtifactEventTarget target, ContainerRegistryEventConnectedRegistry connectedRegistry) : base(target, connectedRegistry)
        {
            Argument.AssertNotNull(target, nameof(target));
            Argument.AssertNotNull(connectedRegistry, nameof(connectedRegistry));
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryChartPushedEventData"/>. </summary>
        /// <param name="id"> The event ID. </param>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="action"> The action that encompasses the provided event. </param>
        /// <param name="location"> The location of the event. </param>
        /// <param name="target"> The target of the event. </param>
        /// <param name="connectedRegistry"> The connected registry information if the event is generated by a connected registry. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryChartPushedEventData(string id, DateTimeOffset? timestamp, string action, string location, ContainerRegistryArtifactEventTarget target, ContainerRegistryEventConnectedRegistry connectedRegistry, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, timestamp, action, location, target, connectedRegistry, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryChartPushedEventData"/> for deserialization. </summary>
        internal ContainerRegistryChartPushedEventData()
        {
        }
    }
}
