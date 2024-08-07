// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> A request chat message representing user input to the assistant. </summary>
    public partial class ChatRequestUserMessage : ChatRequestMessage
    {
        /// <summary> Initializes a new instance of <see cref="ChatRequestUserMessage"/>. </summary>
        /// <param name="content"> The contents of the user message, with available input types varying by selected model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public ChatRequestUserMessage(BinaryData content)
        {
            Argument.AssertNotNull(content, nameof(content));

            Role = ChatRole.User;
            Content = content;
        }

        /// <summary> Initializes a new instance of <see cref="ChatRequestUserMessage"/>. </summary>
        /// <param name="role"> The chat role associated with this message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="content"> The contents of the user message, with available input types varying by selected model. </param>
        /// <param name="name"> An optional name for the participant. </param>
        internal ChatRequestUserMessage(ChatRole role, IDictionary<string, BinaryData> serializedAdditionalRawData, BinaryData content, string name) : base(role, serializedAdditionalRawData)
        {
            Content = content;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ChatRequestUserMessage"/> for deserialization. </summary>
        internal ChatRequestUserMessage()
        {
        }

        /// <summary>
        /// The contents of the user message, with available input types varying by selected model.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// <remarks>
        /// Supported types:
        /// <list type="bullet">
        /// <item>
        /// <description><see cref="string"/></description>
        /// </item>
        /// <item>
        /// <description><see cref="IList{T}"/> where <c>T</c> is of type <see cref="ChatMessageContentItem"/></description>
        /// </item>
        /// </list>
        /// </remarks>
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
        public BinaryData Content { get; }
        /// <summary> An optional name for the participant. </summary>
        public string Name { get; set; }
    }
}
