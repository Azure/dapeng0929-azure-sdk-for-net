// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The AcsSmsDeliveryAttemptProperties. </summary>
    public partial class AcsSmsDeliveryAttemptProperties
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AcsSmsDeliveryAttemptProperties"/>. </summary>
        /// <param name="timestamp"></param>
        internal AcsSmsDeliveryAttemptProperties(DateTimeOffset timestamp)
        {
            Timestamp = timestamp;
        }

        /// <summary> Initializes a new instance of <see cref="AcsSmsDeliveryAttemptProperties"/>. </summary>
        /// <param name="timestamp"></param>
        /// <param name="segmentsSucceeded"></param>
        /// <param name="segmentsFailed"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsSmsDeliveryAttemptProperties(DateTimeOffset timestamp, int? segmentsSucceeded, int? segmentsFailed, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Timestamp = timestamp;
            SegmentsSucceeded = segmentsSucceeded;
            SegmentsFailed = segmentsFailed;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AcsSmsDeliveryAttemptProperties"/> for deserialization. </summary>
        internal AcsSmsDeliveryAttemptProperties()
        {
        }

        /// <summary> Gets the timestamp. </summary>
        public DateTimeOffset Timestamp { get; }
        /// <summary> Gets the segments succeeded. </summary>
        public int? SegmentsSucceeded { get; }
        /// <summary> Gets the segments failed. </summary>
        public int? SegmentsFailed { get; }
    }
}
