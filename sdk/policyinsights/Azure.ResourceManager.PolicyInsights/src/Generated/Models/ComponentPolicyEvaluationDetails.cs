// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Policy evaluation details. </summary>
    public partial class ComponentPolicyEvaluationDetails
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

        /// <summary> Initializes a new instance of <see cref="ComponentPolicyEvaluationDetails"/>. </summary>
        internal ComponentPolicyEvaluationDetails()
        {
            EvaluatedExpressions = new ChangeTrackingList<ComponentExpressionEvaluationDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="ComponentPolicyEvaluationDetails"/>. </summary>
        /// <param name="evaluatedExpressions"> Details of the evaluated expressions. </param>
        /// <param name="reason"> Additional textual reason for the evaluation outcome. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentPolicyEvaluationDetails(IReadOnlyList<ComponentExpressionEvaluationDetails> evaluatedExpressions, string reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EvaluatedExpressions = evaluatedExpressions;
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Details of the evaluated expressions. </summary>
        public IReadOnlyList<ComponentExpressionEvaluationDetails> EvaluatedExpressions { get; }
        /// <summary> Additional textual reason for the evaluation outcome. </summary>
        public string Reason { get; }
    }
}
