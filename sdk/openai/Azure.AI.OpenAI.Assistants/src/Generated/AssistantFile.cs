// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The AssistantFile. </summary>
    public partial class AssistantFile
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

        /// <summary> Initializes a new instance of <see cref="AssistantFile"/>. </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="assistantId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="assistantId"/> is null. </exception>
        internal AssistantFile(string id, DateTimeOffset createdAt, string assistantId)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(assistantId, nameof(assistantId));

            Id = id;
            CreatedAt = createdAt;
            AssistantId = assistantId;
        }

        /// <summary> Initializes a new instance of <see cref="AssistantFile"/>. </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="createdAt"></param>
        /// <param name="assistantId"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssistantFile(string id, string @object, DateTimeOffset createdAt, string assistantId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            AssistantId = assistantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AssistantFile"/> for deserialization. </summary>
        internal AssistantFile()
        {
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }

        /// <summary> Gets the created at. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> Gets the assistant id. </summary>
        public string AssistantId { get; }
    }
}
