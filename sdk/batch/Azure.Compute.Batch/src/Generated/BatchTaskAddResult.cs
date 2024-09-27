// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchTaskAddResult. </summary>
    public partial class BatchTaskAddResult
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

        /// <summary> Initializes a new instance of <see cref="BatchTaskAddResult"/>. </summary>
        /// <param name="status"></param>
        /// <param name="taskId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskId"/> is null. </exception>
        internal BatchTaskAddResult(BatchTaskAddStatus status, string taskId)
        {
            Argument.AssertNotNull(taskId, nameof(taskId));

            Status = status;
            TaskId = taskId;
        }

        /// <summary> Initializes a new instance of <see cref="BatchTaskAddResult"/>. </summary>
        /// <param name="status"></param>
        /// <param name="taskId"></param>
        /// <param name="eTag"></param>
        /// <param name="lastModified"></param>
        /// <param name="location"></param>
        /// <param name="error"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchTaskAddResult(BatchTaskAddStatus status, string taskId, string eTag, DateTimeOffset? lastModified, string location, BatchError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            TaskId = taskId;
            ETag = eTag;
            LastModified = lastModified;
            Location = location;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchTaskAddResult"/> for deserialization. </summary>
        internal BatchTaskAddResult()
        {
        }

        /// <summary> Gets the status. </summary>
        public BatchTaskAddStatus Status { get; }
        /// <summary> Gets the task id. </summary>
        public string TaskId { get; }
        /// <summary> Gets the e tag. </summary>
        public string ETag { get; }
        /// <summary> Gets the last modified. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> Gets the location. </summary>
        public string Location { get; }
        /// <summary> Gets the error. </summary>
        public BatchError Error { get; }
    }
}
