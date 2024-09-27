// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchPoolEvaluateAutoScaleContent. </summary>
    public partial class BatchPoolEvaluateAutoScaleContent
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

        /// <summary> Initializes a new instance of <see cref="BatchPoolEvaluateAutoScaleContent"/>. </summary>
        /// <param name="autoScaleFormula"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="autoScaleFormula"/> is null. </exception>
        public BatchPoolEvaluateAutoScaleContent(string autoScaleFormula)
        {
            Argument.AssertNotNull(autoScaleFormula, nameof(autoScaleFormula));

            AutoScaleFormula = autoScaleFormula;
        }

        /// <summary> Initializes a new instance of <see cref="BatchPoolEvaluateAutoScaleContent"/>. </summary>
        /// <param name="autoScaleFormula"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchPoolEvaluateAutoScaleContent(string autoScaleFormula, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AutoScaleFormula = autoScaleFormula;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchPoolEvaluateAutoScaleContent"/> for deserialization. </summary>
        internal BatchPoolEvaluateAutoScaleContent()
        {
        }

        /// <summary> Gets the auto scale formula. </summary>
        public string AutoScaleFormula { get; }
    }
}
