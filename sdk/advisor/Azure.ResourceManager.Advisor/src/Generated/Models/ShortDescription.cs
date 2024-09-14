// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> A summary of the recommendation. </summary>
    public partial class ShortDescription
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

        /// <summary> Initializes a new instance of <see cref="ShortDescription"/>. </summary>
        public ShortDescription()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ShortDescription"/>. </summary>
        /// <param name="problem"> The issue or opportunity identified by the recommendation and proposed solution. </param>
        /// <param name="solution"> The issue or opportunity identified by the recommendation and proposed solution. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ShortDescription(string problem, string solution, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Problem = problem;
            Solution = solution;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The issue or opportunity identified by the recommendation and proposed solution. </summary>
        public string Problem { get; set; }
        /// <summary> The issue or opportunity identified by the recommendation and proposed solution. </summary>
        public string Solution { get; set; }
    }
}
