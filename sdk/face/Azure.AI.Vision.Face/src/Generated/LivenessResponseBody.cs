// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> The LivenessResponseBody. </summary>
    public partial class LivenessResponseBody
    {
        /// <summary> Initializes a new instance of <see cref="LivenessResponseBody"/>. </summary>
        internal LivenessResponseBody()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="LivenessResponseBody"/>. </summary>
        /// <param name="livenessDecision"></param>
        /// <param name="target"></param>
        /// <param name="modelVersionUsed"></param>
        /// <param name="verifyResult"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal LivenessResponseBody(FaceLivenessDecision? livenessDecision, LivenessOutputsTarget target, LivenessModel? modelVersionUsed, LivenessWithVerifyOutputs verifyResult, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            LivenessDecision = livenessDecision;
            Target = target;
            ModelVersionUsed = modelVersionUsed;
            VerifyResult = verifyResult;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Gets the liveness decision. </summary>
        public FaceLivenessDecision? LivenessDecision { get; }
        /// <summary> Gets the target. </summary>
        public LivenessOutputsTarget Target { get; }
        /// <summary> Gets the model version used. </summary>
        public LivenessModel? ModelVersionUsed { get; }
        /// <summary> Gets the verify result. </summary>
        public LivenessWithVerifyOutputs VerifyResult { get; }
        /// <summary>
        /// Additional Properties
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
