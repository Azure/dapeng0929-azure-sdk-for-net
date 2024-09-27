// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Deidentification
{
    /// <summary> The StringIndex. </summary>
    public partial class StringIndex
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

        /// <summary> Initializes a new instance of <see cref="StringIndex"/>. </summary>
        /// <param name="utf8"></param>
        /// <param name="utf16"></param>
        /// <param name="codePoint"></param>
        internal StringIndex(int utf8, int utf16, int codePoint)
        {
            Utf8 = utf8;
            Utf16 = utf16;
            CodePoint = codePoint;
        }

        /// <summary> Initializes a new instance of <see cref="StringIndex"/>. </summary>
        /// <param name="utf8"></param>
        /// <param name="utf16"></param>
        /// <param name="codePoint"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StringIndex(int utf8, int utf16, int codePoint, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Utf8 = utf8;
            Utf16 = utf16;
            CodePoint = codePoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StringIndex"/> for deserialization. </summary>
        internal StringIndex()
        {
        }

        /// <summary> Gets the utf 8. </summary>
        public int Utf8 { get; }
        /// <summary> Gets the utf 16. </summary>
        public int Utf16 { get; }
        /// <summary> Gets the code point. </summary>
        public int CodePoint { get; }
    }
}
