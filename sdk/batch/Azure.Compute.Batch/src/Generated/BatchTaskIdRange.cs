// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchTaskIdRange. </summary>
    public partial class BatchTaskIdRange
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

        /// <summary> Initializes a new instance of <see cref="BatchTaskIdRange"/>. </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public BatchTaskIdRange(int start, int end)
        {
            Start = start;
            End = end;
        }

        /// <summary> Initializes a new instance of <see cref="BatchTaskIdRange"/>. </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchTaskIdRange(int start, int end, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Start = start;
            End = end;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchTaskIdRange"/> for deserialization. </summary>
        internal BatchTaskIdRange()
        {
        }

        /// <summary> Gets or sets the start. </summary>
        public int Start { get; set; }
        /// <summary> Gets or sets the end. </summary>
        public int End { get; set; }
    }
}
