// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> The AnomalyInterpretation. </summary>
    public partial class AnomalyInterpretation
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

        /// <summary> Initializes a new instance of <see cref="AnomalyInterpretation"/>. </summary>
        internal AnomalyInterpretation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyInterpretation"/>. </summary>
        /// <param name="variable"></param>
        /// <param name="contributionScore"></param>
        /// <param name="correlationChanges"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnomalyInterpretation(string variable, float? contributionScore, CorrelationChanges correlationChanges, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Variable = variable;
            ContributionScore = contributionScore;
            CorrelationChanges = correlationChanges;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the variable. </summary>
        public string Variable { get; }
        /// <summary> Gets the contribution score. </summary>
        public float? ContributionScore { get; }
        /// <summary> Gets the correlation changes. </summary>
        public CorrelationChanges CorrelationChanges { get; }
    }
}
