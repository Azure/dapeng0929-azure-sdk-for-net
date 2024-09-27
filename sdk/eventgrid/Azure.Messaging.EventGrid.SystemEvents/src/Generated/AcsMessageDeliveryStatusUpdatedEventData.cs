// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.AdvancedMessageDeliveryStatusUpdated event. </summary>
    public partial class AcsMessageDeliveryStatusUpdatedEventData : AcsMessageEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsMessageDeliveryStatusUpdatedEventData"/>. </summary>
        /// <param name="error"> The channel event error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal AcsMessageDeliveryStatusUpdatedEventData(AcsMessageChannelEventError error) : base(error)
        {
            Argument.AssertNotNull(error, nameof(error));
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageDeliveryStatusUpdatedEventData"/>. </summary>
        /// <param name="from"> The message sender. </param>
        /// <param name="to"> The message recipient. </param>
        /// <param name="receivedTimestamp"> The time message was received. </param>
        /// <param name="error"> The channel event error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="messageId"> The message id. </param>
        /// <param name="status"> The updated message status. </param>
        /// <param name="channelKind"> The updated message channel type. </param>
        internal AcsMessageDeliveryStatusUpdatedEventData(string @from, string to, DateTimeOffset? receivedTimestamp, AcsMessageChannelEventError error, IDictionary<string, BinaryData> serializedAdditionalRawData, string messageId, AcsMessageDeliveryStatus? status, AcsMessageChannelKind? channelKind) : base(@from, to, receivedTimestamp, error, serializedAdditionalRawData)
        {
            MessageId = messageId;
            Status = status;
            ChannelKind = channelKind;
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageDeliveryStatusUpdatedEventData"/> for deserialization. </summary>
        internal AcsMessageDeliveryStatusUpdatedEventData()
        {
        }

        /// <summary> The message id. </summary>
        public string MessageId { get; }
        /// <summary> The updated message status. </summary>
        public AcsMessageDeliveryStatus? Status { get; }
        /// <summary> The updated message channel type. </summary>
        public AcsMessageChannelKind? ChannelKind { get; }
    }
}
