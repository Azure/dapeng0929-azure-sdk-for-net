// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Storage.StorageTaskAssignmentQueued event. </summary>
    public partial class StorageTaskAssignmentQueuedEventData
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

        /// <summary> Initializes a new instance of <see cref="StorageTaskAssignmentQueuedEventData"/>. </summary>
        internal StorageTaskAssignmentQueuedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageTaskAssignmentQueuedEventData"/>. </summary>
        /// <param name="queuedOn"> The time at which a storage task was queued. </param>
        /// <param name="taskExecutionId"> The execution id for a storage task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageTaskAssignmentQueuedEventData(DateTimeOffset? queuedOn, string taskExecutionId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QueuedOn = queuedOn;
            TaskExecutionId = taskExecutionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The time at which a storage task was queued. </summary>
        public DateTimeOffset? QueuedOn { get; }
        /// <summary> The execution id for a storage task. </summary>
        public string TaskExecutionId { get; }
    }
}
