// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The ThreadMessage. </summary>
    public partial class ThreadMessage
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

        /// <summary> Initializes a new instance of <see cref="ThreadMessage"/>. </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="threadId"></param>
        /// <param name="role"></param>
        /// <param name="contentItems">
        /// Please note <see cref="MessageContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageImageFileContent"/> and <see cref="MessageTextContent"/>.
        /// </param>
        /// <param name="fileIds"></param>
        /// <param name="metadata"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="threadId"/>, <paramref name="contentItems"/> or <paramref name="fileIds"/> is null. </exception>
        internal ThreadMessage(string id, DateTimeOffset createdAt, string threadId, MessageRole role, IEnumerable<MessageContent> contentItems, IEnumerable<string> fileIds, IReadOnlyDictionary<string, string> metadata)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(threadId, nameof(threadId));
            Argument.AssertNotNull(contentItems, nameof(contentItems));
            Argument.AssertNotNull(fileIds, nameof(fileIds));

            Id = id;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Role = role;
            ContentItems = contentItems.ToList();
            FileIds = fileIds.ToList();
            Metadata = metadata;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadMessage"/>. </summary>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="createdAt"></param>
        /// <param name="threadId"></param>
        /// <param name="role"></param>
        /// <param name="contentItems">
        /// Please note <see cref="MessageContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageImageFileContent"/> and <see cref="MessageTextContent"/>.
        /// </param>
        /// <param name="assistantId"></param>
        /// <param name="runId"></param>
        /// <param name="fileIds"></param>
        /// <param name="metadata"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreadMessage(string id, string @object, DateTimeOffset createdAt, string threadId, MessageRole role, IReadOnlyList<MessageContent> contentItems, string assistantId, string runId, IReadOnlyList<string> fileIds, IReadOnlyDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            ThreadId = threadId;
            Role = role;
            ContentItems = contentItems;
            AssistantId = assistantId;
            RunId = runId;
            FileIds = fileIds;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ThreadMessage"/> for deserialization. </summary>
        internal ThreadMessage()
        {
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }

        /// <summary> Gets the created at. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> Gets the thread id. </summary>
        public string ThreadId { get; }
        /// <summary> Gets the role. </summary>
        public MessageRole Role { get; }
        /// <summary>
        /// Gets the content items
        /// Please note <see cref="MessageContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageImageFileContent"/> and <see cref="MessageTextContent"/>.
        /// </summary>
        public IReadOnlyList<MessageContent> ContentItems { get; }
        /// <summary> Gets the assistant id. </summary>
        public string AssistantId { get; }
        /// <summary> Gets the run id. </summary>
        public string RunId { get; }
        /// <summary> Gets the file ids. </summary>
        public IReadOnlyList<string> FileIds { get; }
        /// <summary> Gets the metadata. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
