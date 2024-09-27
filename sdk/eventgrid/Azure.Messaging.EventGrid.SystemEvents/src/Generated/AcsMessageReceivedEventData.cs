// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.AdvancedMessageReceived event. </summary>
    public partial class AcsMessageReceivedEventData : AcsMessageEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsMessageReceivedEventData"/>. </summary>
        /// <param name="error"> The channel event error. </param>
        /// <param name="channelKind"> The message channel type. </param>
        /// <param name="mediaContent"> The received message media content. </param>
        /// <param name="context"> The received message context. </param>
        /// <param name="button"> The received message button content. </param>
        /// <param name="interactiveContent"> The received message interactive content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/>, <paramref name="mediaContent"/>, <paramref name="context"/>, <paramref name="button"/> or <paramref name="interactiveContent"/> is null. </exception>
        internal AcsMessageReceivedEventData(AcsMessageChannelEventError error, AcsMessageChannelKind channelKind, AcsMessageMediaContent mediaContent, AcsMessageContext context, AcsMessageButtonContent button, AcsMessageInteractiveContent interactiveContent) : base(error)
        {
            Argument.AssertNotNull(error, nameof(error));
            Argument.AssertNotNull(mediaContent, nameof(mediaContent));
            Argument.AssertNotNull(context, nameof(context));
            Argument.AssertNotNull(button, nameof(button));
            Argument.AssertNotNull(interactiveContent, nameof(interactiveContent));

            ChannelKind = channelKind;
            MediaContent = mediaContent;
            Context = context;
            Button = button;
            InteractiveContent = interactiveContent;
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageReceivedEventData"/>. </summary>
        /// <param name="from"> The message sender. </param>
        /// <param name="to"> The message recipient. </param>
        /// <param name="receivedTimestamp"> The time message was received. </param>
        /// <param name="error"> The channel event error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="content"> The message content. </param>
        /// <param name="channelKind"> The message channel type. </param>
        /// <param name="mediaContent"> The received message media content. </param>
        /// <param name="context"> The received message context. </param>
        /// <param name="button"> The received message button content. </param>
        /// <param name="interactiveContent"> The received message interactive content. </param>
        internal AcsMessageReceivedEventData(string @from, string to, DateTimeOffset? receivedTimestamp, AcsMessageChannelEventError error, IDictionary<string, BinaryData> serializedAdditionalRawData, string content, AcsMessageChannelKind channelKind, AcsMessageMediaContent mediaContent, AcsMessageContext context, AcsMessageButtonContent button, AcsMessageInteractiveContent interactiveContent) : base(@from, to, receivedTimestamp, error, serializedAdditionalRawData)
        {
            Content = content;
            ChannelKind = channelKind;
            MediaContent = mediaContent;
            Context = context;
            Button = button;
            InteractiveContent = interactiveContent;
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageReceivedEventData"/> for deserialization. </summary>
        internal AcsMessageReceivedEventData()
        {
        }

        /// <summary> The message content. </summary>
        public string Content { get; }
        /// <summary> The message channel type. </summary>
        public AcsMessageChannelKind ChannelKind { get; }
        /// <summary> The received message media content. </summary>
        public AcsMessageMediaContent MediaContent { get; }
        /// <summary> The received message context. </summary>
        public AcsMessageContext Context { get; }
        /// <summary> The received message button content. </summary>
        public AcsMessageButtonContent Button { get; }
        /// <summary> The received message interactive content. </summary>
        public AcsMessageInteractiveContent InteractiveContent { get; }
    }
}
