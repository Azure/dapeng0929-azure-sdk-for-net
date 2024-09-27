// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The KnowledgeBaseAnswerPrompt. </summary>
    public partial class KnowledgeBaseAnswerPrompt
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

        /// <summary> Initializes a new instance of <see cref="KnowledgeBaseAnswerPrompt"/>. </summary>
        internal KnowledgeBaseAnswerPrompt()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KnowledgeBaseAnswerPrompt"/>. </summary>
        /// <param name="displayOrder"></param>
        /// <param name="qnaId"></param>
        /// <param name="displayText"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KnowledgeBaseAnswerPrompt(int? displayOrder, int? qnaId, string displayText, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayOrder = displayOrder;
            QnaId = qnaId;
            DisplayText = displayText;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the display order. </summary>
        public int? DisplayOrder { get; }
        /// <summary> Gets the qna id. </summary>
        public int? QnaId { get; }
        /// <summary> Gets the display text. </summary>
        public string DisplayText { get; }
    }
}
