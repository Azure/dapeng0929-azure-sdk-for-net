// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The MediaJobProcessingEventData. </summary>
    public partial class MediaJobProcessingEventData : MediaJobStateChangeEventData
    {
        /// <summary> Initializes a new instance of <see cref="MediaJobProcessingEventData"/>. </summary>
        /// <param name="previousState"></param>
        /// <param name="state"></param>
        /// <param name="correlationData"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="correlationData"/> is null. </exception>
        internal MediaJobProcessingEventData(MediaJobState previousState, MediaJobState state, IReadOnlyDictionary<string, string> correlationData) : base(previousState, state, correlationData)
        {
            Argument.AssertNotNull(correlationData, nameof(correlationData));
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobProcessingEventData"/>. </summary>
        /// <param name="previousState"></param>
        /// <param name="state"></param>
        /// <param name="correlationData"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaJobProcessingEventData(MediaJobState previousState, MediaJobState state, IReadOnlyDictionary<string, string> correlationData, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(previousState, state, correlationData, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaJobProcessingEventData"/> for deserialization. </summary>
        internal MediaJobProcessingEventData()
        {
        }
    }
}
