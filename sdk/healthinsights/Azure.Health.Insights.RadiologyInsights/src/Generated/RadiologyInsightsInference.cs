// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// The RadiologyInsightsInference.
    /// Please note <see cref="RadiologyInsightsInference"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AgeMismatchInference"/>, <see cref="CompleteOrderDiscrepancyInference"/>, <see cref="CriticalResultInference"/>, <see cref="FindingInference"/>, <see cref="FollowupCommunicationInference"/>, <see cref="FollowupRecommendationInference"/>, <see cref="LateralityDiscrepancyInference"/>, <see cref="LimitedOrderDiscrepancyInference"/>, <see cref="RadiologyProcedureInference"/> and <see cref="SexMismatchInference"/>.
    /// </summary>
    public abstract partial class RadiologyInsightsInference
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInference"/>. </summary>
        protected RadiologyInsightsInference()
        {
            Extension = new ChangeTrackingList<FhirR4Extension>();
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsInference"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="extension"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RadiologyInsightsInference(RadiologyInsightsInferenceType kind, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Extension = extension;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the kind. </summary>
        internal RadiologyInsightsInferenceType Kind { get; set; }
        /// <summary> Gets the extension. </summary>
        public IReadOnlyList<FhirR4Extension> Extension { get; }
    }
}
