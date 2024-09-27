// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The ConversationSummarizationActionContent. </summary>
    public partial class ConversationSummarizationActionContent
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

        /// <summary> Initializes a new instance of <see cref="ConversationSummarizationActionContent"/>. </summary>
        /// <param name="summaryAspects"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="summaryAspects"/> is null. </exception>
        public ConversationSummarizationActionContent(IEnumerable<SummaryAspect> summaryAspects)
        {
            Argument.AssertNotNull(summaryAspects, nameof(summaryAspects));

            SummaryAspects = summaryAspects.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ConversationSummarizationActionContent"/>. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="modelVersion"></param>
        /// <param name="sentenceCount"></param>
        /// <param name="stringIndexType"></param>
        /// <param name="summaryLength"></param>
        /// <param name="summaryAspects"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationSummarizationActionContent(bool? loggingOptOut, string modelVersion, int? sentenceCount, StringIndexType? stringIndexType, SummaryLengthBucket? summaryLength, IList<SummaryAspect> summaryAspects, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoggingOptOut = loggingOptOut;
            ModelVersion = modelVersion;
            SentenceCount = sentenceCount;
            StringIndexType = stringIndexType;
            SummaryLength = summaryLength;
            SummaryAspects = summaryAspects;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationSummarizationActionContent"/> for deserialization. </summary>
        internal ConversationSummarizationActionContent()
        {
        }

        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
        /// <summary> Gets or sets the model version. </summary>
        public string ModelVersion { get; set; }
        /// <summary> Gets or sets the sentence count. </summary>
        public int? SentenceCount { get; set; }
        /// <summary> Gets or sets the string index type. </summary>
        public StringIndexType? StringIndexType { get; set; }
        /// <summary> Gets or sets the summary length. </summary>
        public SummaryLengthBucket? SummaryLength { get; set; }
        /// <summary> Gets the summary aspects. </summary>
        public IList<SummaryAspect> SummaryAspects { get; }
    }
}
