// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> The ExtractiveSummarizationActionContent. </summary>
    public partial class ExtractiveSummarizationActionContent
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

        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationActionContent"/>. </summary>
        public ExtractiveSummarizationActionContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtractiveSummarizationActionContent"/>. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="modelVersion"></param>
        /// <param name="sentenceCount"></param>
        /// <param name="sortBy"></param>
        /// <param name="stringIndexType"></param>
        /// <param name="query"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtractiveSummarizationActionContent(bool? loggingOptOut, string modelVersion, long? sentenceCount, ExtractiveSummarizationSortingCriteria? sortBy, StringIndexType? stringIndexType, string query, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoggingOptOut = loggingOptOut;
            ModelVersion = modelVersion;
            SentenceCount = sentenceCount;
            SortBy = sortBy;
            StringIndexType = stringIndexType;
            Query = query;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
        /// <summary> Gets or sets the model version. </summary>
        public string ModelVersion { get; set; }
        /// <summary> Gets or sets the sentence count. </summary>
        public long? SentenceCount { get; set; }
        /// <summary> Gets or sets the sort by. </summary>
        public ExtractiveSummarizationSortingCriteria? SortBy { get; set; }
        /// <summary> Gets or sets the string index type. </summary>
        public StringIndexType? StringIndexType { get; set; }
        /// <summary> Gets or sets the query. </summary>
        public string Query { get; set; }
    }
}
