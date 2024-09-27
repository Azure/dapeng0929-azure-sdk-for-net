// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Pass fail criteria for a test. </summary>
    public partial class PassFailCriteria
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

        /// <summary> Initializes a new instance of <see cref="PassFailCriteria"/>. </summary>
        public PassFailCriteria()
        {
            PassFailMetrics = new ChangeTrackingDictionary<string, PassFailMetric>();
        }

        /// <summary> Initializes a new instance of <see cref="PassFailCriteria"/>. </summary>
        /// <param name="passFailMetrics"> Map of id and pass fail metrics { id  : pass fail metrics }. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PassFailCriteria(IDictionary<string, PassFailMetric> passFailMetrics, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PassFailMetrics = passFailMetrics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Map of id and pass fail metrics { id  : pass fail metrics }. </summary>
        public IDictionary<string, PassFailMetric> PassFailMetrics { get; }
    }
}
