// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> The AddFaceFromUrlRequest3. </summary>
    internal partial class AddFaceFromUrlRequest3
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

        /// <summary> Initializes a new instance of <see cref="AddFaceFromUrlRequest3"/>. </summary>
        /// <param name="uri"> URL of input image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        internal AddFaceFromUrlRequest3(Uri uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
        }

        /// <summary> Initializes a new instance of <see cref="AddFaceFromUrlRequest3"/>. </summary>
        /// <param name="uri"> URL of input image. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AddFaceFromUrlRequest3(Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AddFaceFromUrlRequest3"/> for deserialization. </summary>
        internal AddFaceFromUrlRequest3()
        {
        }

        /// <summary> URL of input image. </summary>
        public Uri Uri { get; }
    }
}
