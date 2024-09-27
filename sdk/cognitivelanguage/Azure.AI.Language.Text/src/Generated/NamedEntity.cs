// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> The NamedEntity. </summary>
    public partial class NamedEntity
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

        /// <summary> Initializes a new instance of <see cref="NamedEntity"/>. </summary>
        /// <param name="text"></param>
        /// <param name="category"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <param name="confidenceScore"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="category"/> is null. </exception>
        internal NamedEntity(string text, string category, int offset, int length, double confidenceScore)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(category, nameof(category));

            Text = text;
            Category = category;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Initializes a new instance of <see cref="NamedEntity"/>. </summary>
        /// <param name="text"></param>
        /// <param name="category"></param>
        /// <param name="subcategory"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <param name="confidenceScore"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NamedEntity(string text, string category, string subcategory, int offset, int length, double confidenceScore, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Category = category;
            Subcategory = subcategory;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NamedEntity"/> for deserialization. </summary>
        internal NamedEntity()
        {
        }

        /// <summary> Gets the text. </summary>
        public string Text { get; }
        /// <summary> Gets the category. </summary>
        public string Category { get; }
        /// <summary> Gets the subcategory. </summary>
        public string Subcategory { get; }
        /// <summary> Gets the offset. </summary>
        public int Offset { get; }
        /// <summary> Gets the length. </summary>
        public int Length { get; }
        /// <summary> Gets the confidence score. </summary>
        public double ConfidenceScore { get; }
    }
}
