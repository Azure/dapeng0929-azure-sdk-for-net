// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.ContentSafety
{
    /// <summary> The text jailbreak analysis response. </summary>
    public partial class JailbreakAnalysisResult
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

        /// <summary> Initializes a new instance of <see cref="JailbreakAnalysisResult"/>. </summary>
        /// <param name="detected"> Analysis result for jailbreak. </param>
        internal JailbreakAnalysisResult(bool detected)
        {
            Detected = detected;
        }

        /// <summary> Initializes a new instance of <see cref="JailbreakAnalysisResult"/>. </summary>
        /// <param name="detected"> Analysis result for jailbreak. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JailbreakAnalysisResult(bool detected, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Detected = detected;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JailbreakAnalysisResult"/> for deserialization. </summary>
        internal JailbreakAnalysisResult()
        {
        }

        /// <summary> Analysis result for jailbreak. </summary>
        public bool Detected { get; }
    }
}
