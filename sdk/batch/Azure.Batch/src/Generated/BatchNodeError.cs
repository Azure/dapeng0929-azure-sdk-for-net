// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> An error encountered by a Compute Node. </summary>
    public partial class BatchNodeError
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

        /// <summary> Initializes a new instance of <see cref="BatchNodeError"/>. </summary>
        internal BatchNodeError()
        {
            ErrorDetails = new ChangeTrackingList<NameValuePair>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeError"/>. </summary>
        /// <param name="code"> An identifier for the Compute Node error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the Compute Node error, intended to be suitable for display in a user interface. </param>
        /// <param name="errorDetails"> The list of additional error details related to the Compute Node error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNodeError(string code, string message, IReadOnlyList<NameValuePair> errorDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            ErrorDetails = errorDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An identifier for the Compute Node error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; }
        /// <summary> A message describing the Compute Node error, intended to be suitable for display in a user interface. </summary>
        public string Message { get; }
        /// <summary> The list of additional error details related to the Compute Node error. </summary>
        public IReadOnlyList<NameValuePair> ErrorDetails { get; }
    }
}
