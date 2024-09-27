// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Translation.Text
{
    /// <summary> The SentenceBoundaries. </summary>
    public partial class SentenceBoundaries
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

        /// <summary> Initializes a new instance of <see cref="SentenceBoundaries"/>. </summary>
        /// <param name="sourceSentencesLengths"></param>
        /// <param name="translatedSentencesLengths"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceSentencesLengths"/> or <paramref name="translatedSentencesLengths"/> is null. </exception>
        internal SentenceBoundaries(IEnumerable<int> sourceSentencesLengths, IEnumerable<int> translatedSentencesLengths)
        {
            Argument.AssertNotNull(sourceSentencesLengths, nameof(sourceSentencesLengths));
            Argument.AssertNotNull(translatedSentencesLengths, nameof(translatedSentencesLengths));

            SourceSentencesLengths = sourceSentencesLengths.ToList();
            TranslatedSentencesLengths = translatedSentencesLengths.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SentenceBoundaries"/>. </summary>
        /// <param name="sourceSentencesLengths"></param>
        /// <param name="translatedSentencesLengths"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SentenceBoundaries(IReadOnlyList<int> sourceSentencesLengths, IReadOnlyList<int> translatedSentencesLengths, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceSentencesLengths = sourceSentencesLengths;
            TranslatedSentencesLengths = translatedSentencesLengths;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SentenceBoundaries"/> for deserialization. </summary>
        internal SentenceBoundaries()
        {
        }

        /// <summary> Gets the source sentences lengths. </summary>
        public IReadOnlyList<int> SourceSentencesLengths { get; }
        /// <summary> Gets the translated sentences lengths. </summary>
        public IReadOnlyList<int> TranslatedSentencesLengths { get; }
    }
}
