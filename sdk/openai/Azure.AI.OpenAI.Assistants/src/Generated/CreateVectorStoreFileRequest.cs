// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The CreateVectorStoreFileRequest. </summary>
    internal partial class CreateVectorStoreFileRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateVectorStoreFileRequest"/>. </summary>
        /// <param name="fileId"> A File ID that the vector store should use. Useful for tools like `file_search` that can access files. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileId"/> is null. </exception>
        internal CreateVectorStoreFileRequest(string fileId)
        {
            Argument.AssertNotNull(fileId, nameof(fileId));

            FileId = fileId;
        }

        /// <summary> Initializes a new instance of <see cref="CreateVectorStoreFileRequest"/>. </summary>
        /// <param name="fileId"> A File ID that the vector store should use. Useful for tools like `file_search` that can access files. </param>
        /// <param name="chunkingStrategy">
        /// The chunking strategy used to chunk the file(s). If not set, will use the auto strategy.
        /// Please note <see cref="VectorStoreChunkingStrategyRequest"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VectorStoreAutoChunkingStrategyRequest"/> and <see cref="VectorStoreStaticChunkingStrategyRequest"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateVectorStoreFileRequest(string fileId, VectorStoreChunkingStrategyRequest chunkingStrategy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            ChunkingStrategy = chunkingStrategy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateVectorStoreFileRequest"/> for deserialization. </summary>
        internal CreateVectorStoreFileRequest()
        {
        }

        /// <summary> A File ID that the vector store should use. Useful for tools like `file_search` that can access files. </summary>
        public string FileId { get; }
        /// <summary>
        /// The chunking strategy used to chunk the file(s). If not set, will use the auto strategy.
        /// Please note <see cref="VectorStoreChunkingStrategyRequest"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VectorStoreAutoChunkingStrategyRequest"/> and <see cref="VectorStoreStaticChunkingStrategyRequest"/>.
        /// </summary>
        public VectorStoreChunkingStrategyRequest ChunkingStrategy { get; }
    }
}
