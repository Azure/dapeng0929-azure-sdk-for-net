// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> A request body used to retrieve a delta summary. </summary>
    public partial class DeltaSummaryRequest
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

        /// <summary> Initializes a new instance of <see cref="DeltaSummaryRequest"/>. </summary>
        public DeltaSummaryRequest()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeltaSummaryRequest"/>. </summary>
        /// <param name="priorDays"> The number of days prior to retrieve deltas for. </param>
        /// <param name="date"> expected format to be: yyyy-MM-dd. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeltaSummaryRequest(int? priorDays, string date, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PriorDays = priorDays;
            Date = date;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The number of days prior to retrieve deltas for. </summary>
        public int? PriorDays { get; set; }
        /// <summary> expected format to be: yyyy-MM-dd. </summary>
        public string Date { get; set; }
    }
}
