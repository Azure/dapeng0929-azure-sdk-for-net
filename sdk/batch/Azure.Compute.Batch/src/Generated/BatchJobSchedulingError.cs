// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchJobSchedulingError. </summary>
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
        /// <param name="category"></param>
        internal BatchJobSchedulingError(ErrorCategory category)
        {
            Category = category;
            Details = new ChangeTrackingList<NameValuePair>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobSchedulingError"/>. </summary>
        /// <param name="category"></param>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="details"></param>
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

        /// <summary> Gets the category. </summary>
        public ErrorCategory Category { get; }
        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the message. </summary>
        public string Message { get; }
        /// <summary> Gets the details. </summary>
        public IReadOnlyList<NameValuePair> Details { get; }
    }
}
