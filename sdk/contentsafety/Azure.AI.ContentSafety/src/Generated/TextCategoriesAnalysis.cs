// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.ContentSafety
{
    /// <summary> The TextCategoriesAnalysis. </summary>
    public partial class TextCategoriesAnalysis
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

        /// <summary> Initializes a new instance of <see cref="TextCategoriesAnalysis"/>. </summary>
        /// <param name="category"></param>
        internal TextCategoriesAnalysis(TextCategory category)
        {
            Category = category;
        }

        /// <summary> Initializes a new instance of <see cref="TextCategoriesAnalysis"/>. </summary>
        /// <param name="category"></param>
        /// <param name="severity"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TextCategoriesAnalysis(TextCategory category, int? severity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            Severity = severity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TextCategoriesAnalysis"/> for deserialization. </summary>
        internal TextCategoriesAnalysis()
        {
        }

        /// <summary> Gets the category. </summary>
        public TextCategory Category { get; }
        /// <summary> Gets the severity. </summary>
        public int? Severity { get; }
    }
}
