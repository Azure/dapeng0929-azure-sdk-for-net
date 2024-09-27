// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The SummaryResult. </summary>
    public partial class SummaryResult
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

        /// <summary> Initializes a new instance of <see cref="SummaryResult"/>. </summary>
        /// <param name="conversations"></param>
        /// <param name="errors"></param>
        /// <param name="modelVersion"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversations"/>, <paramref name="errors"/> or <paramref name="modelVersion"/> is null. </exception>
        internal SummaryResult(IEnumerable<ConversationsSummaryResult> conversations, IEnumerable<DocumentError> errors, string modelVersion)
        {
            Argument.AssertNotNull(conversations, nameof(conversations));
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(modelVersion, nameof(modelVersion));

            Conversations = conversations.ToList();
            Errors = errors.ToList();
            ModelVersion = modelVersion;
        }

        /// <summary> Initializes a new instance of <see cref="SummaryResult"/>. </summary>
        /// <param name="conversations"></param>
        /// <param name="errors"></param>
        /// <param name="statistics"></param>
        /// <param name="modelVersion"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SummaryResult(IReadOnlyList<ConversationsSummaryResult> conversations, IReadOnlyList<DocumentError> errors, RequestStatistics statistics, string modelVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Conversations = conversations;
            Errors = errors;
            Statistics = statistics;
            ModelVersion = modelVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SummaryResult"/> for deserialization. </summary>
        internal SummaryResult()
        {
        }

        /// <summary> Gets the conversations. </summary>
        public IReadOnlyList<ConversationsSummaryResult> Conversations { get; }
        /// <summary> Gets the errors. </summary>
        public IReadOnlyList<DocumentError> Errors { get; }
        /// <summary> Gets the statistics. </summary>
        public RequestStatistics Statistics { get; }
        /// <summary> Gets the model version. </summary>
        public string ModelVersion { get; }
    }
}
