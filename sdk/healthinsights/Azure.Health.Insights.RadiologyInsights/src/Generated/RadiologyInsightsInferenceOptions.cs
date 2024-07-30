// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> Options regarding follow up recommendation inferences and finding inferences. </summary>
    public partial class RadiologyInsightsInferenceOptions
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

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInferenceOptions"/>. </summary>
        public RadiologyInsightsInferenceOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInferenceOptions"/>. </summary>
        /// <param name="followupRecommendationOptions"> Follow-up recommendation options. </param>
        /// <param name="findingOptions"> Finding options. </param>
        /// <param name="guidanceOptions"> Guidance options. </param>
        /// <param name="qualityMeasureOptions"> QualityMeasureOptions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RadiologyInsightsInferenceOptions(FollowupRecommendationOptions followupRecommendationOptions, FindingOptions findingOptions, GuidanceOptions guidanceOptions, QualityMeasureOptions qualityMeasureOptions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FollowupRecommendationOptions = followupRecommendationOptions;
            FindingOptions = findingOptions;
            GuidanceOptions = guidanceOptions;
            QualityMeasureOptions = qualityMeasureOptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Follow-up recommendation options. </summary>
        public FollowupRecommendationOptions FollowupRecommendationOptions { get; set; }
        /// <summary> Finding options. </summary>
        public FindingOptions FindingOptions { get; set; }
        /// <summary> Guidance options. </summary>
        public GuidanceOptions GuidanceOptions { get; set; }
        /// <summary> QualityMeasureOptions. </summary>
        public QualityMeasureOptions QualityMeasureOptions { get; set; }
    }
}
