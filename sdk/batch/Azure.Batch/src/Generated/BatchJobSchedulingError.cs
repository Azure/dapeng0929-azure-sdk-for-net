// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> An error encountered by the Batch service when scheduling a Job. </summary>
    public partial class BatchJobSchedulingError
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

        /// <summary> Initializes a new instance of <see cref="BatchJobSchedulingError"/>. </summary>
        /// <param name="category"> The category of the Job scheduling error. </param>
        internal BatchJobSchedulingError(ErrorCategory category)
        {
            Category = category;
            Details = new ChangeTrackingList<NameValuePair>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobSchedulingError"/>. </summary>
        /// <param name="category"> The category of the Job scheduling error. </param>
        /// <param name="code"> An identifier for the Job scheduling error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the Job scheduling error, intended to be suitable for display in a user interface. </param>
        /// <param name="details"> A list of additional error details related to the scheduling error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchJobSchedulingError(ErrorCategory category, string code, string message, IReadOnlyList<NameValuePair> details, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            Code = code;
            Message = message;
            Details = details;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobSchedulingError"/> for deserialization. </summary>
        internal BatchJobSchedulingError()
        {
        }

        /// <summary> The category of the Job scheduling error. </summary>
        public ErrorCategory Category { get; }
        /// <summary> An identifier for the Job scheduling error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; }
        /// <summary> A message describing the Job scheduling error, intended to be suitable for display in a user interface. </summary>
        public string Message { get; }
        /// <summary> A list of additional error details related to the scheduling error. </summary>
        public IReadOnlyList<NameValuePair> Details { get; }
    }
}
