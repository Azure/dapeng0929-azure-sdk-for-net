// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> The UnivariateLastDetectionResult. </summary>
    public partial class UnivariateLastDetectionResult
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

        /// <summary> Initializes a new instance of <see cref="UnivariateLastDetectionResult"/>. </summary>
        /// <param name="period"></param>
        /// <param name="suggestedWindow"></param>
        /// <param name="expectedValue"></param>
        /// <param name="upperMargin"></param>
        /// <param name="lowerMargin"></param>
        /// <param name="isAnomaly"></param>
        /// <param name="isNegativeAnomaly"></param>
        /// <param name="isPositiveAnomaly"></param>
        internal UnivariateLastDetectionResult(int period, int suggestedWindow, float expectedValue, float upperMargin, float lowerMargin, bool isAnomaly, bool isNegativeAnomaly, bool isPositiveAnomaly)
        {
            Period = period;
            SuggestedWindow = suggestedWindow;
            ExpectedValue = expectedValue;
            UpperMargin = upperMargin;
            LowerMargin = lowerMargin;
            IsAnomaly = isAnomaly;
            IsNegativeAnomaly = isNegativeAnomaly;
            IsPositiveAnomaly = isPositiveAnomaly;
        }

        /// <summary> Initializes a new instance of <see cref="UnivariateLastDetectionResult"/>. </summary>
        /// <param name="period"></param>
        /// <param name="suggestedWindow"></param>
        /// <param name="expectedValue"></param>
        /// <param name="upperMargin"></param>
        /// <param name="lowerMargin"></param>
        /// <param name="isAnomaly"></param>
        /// <param name="isNegativeAnomaly"></param>
        /// <param name="isPositiveAnomaly"></param>
        /// <param name="severity"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnivariateLastDetectionResult(int period, int suggestedWindow, float expectedValue, float upperMargin, float lowerMargin, bool isAnomaly, bool isNegativeAnomaly, bool isPositiveAnomaly, float? severity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Period = period;
            SuggestedWindow = suggestedWindow;
            ExpectedValue = expectedValue;
            UpperMargin = upperMargin;
            LowerMargin = lowerMargin;
            IsAnomaly = isAnomaly;
            IsNegativeAnomaly = isNegativeAnomaly;
            IsPositiveAnomaly = isPositiveAnomaly;
            Severity = severity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UnivariateLastDetectionResult"/> for deserialization. </summary>
        internal UnivariateLastDetectionResult()
        {
        }

        /// <summary> Gets the period. </summary>
        public int Period { get; }
        /// <summary> Gets the suggested window. </summary>
        public int SuggestedWindow { get; }
        /// <summary> Gets the expected value. </summary>
        public float ExpectedValue { get; }
        /// <summary> Gets the upper margin. </summary>
        public float UpperMargin { get; }
        /// <summary> Gets the lower margin. </summary>
        public float LowerMargin { get; }
        /// <summary> Gets the is anomaly. </summary>
        public bool IsAnomaly { get; }
        /// <summary> Gets the is negative anomaly. </summary>
        public bool IsNegativeAnomaly { get; }
        /// <summary> Gets the is positive anomaly. </summary>
        public bool IsPositiveAnomaly { get; }
        /// <summary> Gets the severity. </summary>
        public float? Severity { get; }
    }
}
