// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> The AcceptedAge. </summary>
    public partial class AcceptedAge
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

        /// <summary> Initializes a new instance of <see cref="AcceptedAge"/>. </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public AcceptedAge(AgeUnit unit, float value)
        {
            Unit = unit;
            Value = value;
        }

        /// <summary> Initializes a new instance of <see cref="AcceptedAge"/>. </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcceptedAge(AgeUnit unit, float value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Unit = unit;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AcceptedAge"/> for deserialization. </summary>
        internal AcceptedAge()
        {
        }

        /// <summary> Gets the unit. </summary>
        public AgeUnit Unit { get; }
        /// <summary> Gets the value. </summary>
        public float Value { get; }
    }
}
