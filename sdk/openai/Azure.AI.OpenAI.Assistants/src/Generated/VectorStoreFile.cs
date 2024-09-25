// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> Description of a file attached to a vector store. </summary>
    public partial class VectorStoreFile
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

        /// <summary> Initializes a new instance of <see cref="VectorStoreFile"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="usageBytes">
        /// The total vector store usage in bytes. Note that this may be different from the original file
        /// size.
        /// </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the vector store file was created. </param>
        /// <param name="vectorStoreId"> The ID of the vector store that the file is attached to. </param>
        /// <param name="status"> The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use. </param>
        /// <param name="lastError"> The last error associated with this vector store file. Will be `null` if there are no errors. </param>
        /// <param name="chunkingStrategy">
        /// The strategy used to chunk the file.
        /// Please note <see cref="VectorStoreChunkingStrategyResponse"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VectorStoreAutoChunkingStrategyResponse"/> and <see cref="VectorStoreStaticChunkingStrategyResponse"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="vectorStoreId"/> or <paramref name="chunkingStrategy"/> is null. </exception>
        internal VectorStoreFile(string id, int usageBytes, DateTimeOffset createdAt, string vectorStoreId, VectorStoreFileStatus status, VectorStoreFileError lastError, VectorStoreChunkingStrategyResponse chunkingStrategy)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(vectorStoreId, nameof(vectorStoreId));
            Argument.AssertNotNull(chunkingStrategy, nameof(chunkingStrategy));

            Id = id;
            UsageBytes = usageBytes;
            CreatedAt = createdAt;
            VectorStoreId = vectorStoreId;
            Status = status;
            LastError = lastError;
            ChunkingStrategy = chunkingStrategy;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreFile"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="object"> The object type, which is always `vector_store.file`. </param>
        /// <param name="usageBytes">
        /// The total vector store usage in bytes. Note that this may be different from the original file
        /// size.
        /// </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the vector store file was created. </param>
        /// <param name="vectorStoreId"> The ID of the vector store that the file is attached to. </param>
        /// <param name="status"> The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use. </param>
        /// <param name="lastError"> The last error associated with this vector store file. Will be `null` if there are no errors. </param>
        /// <param name="chunkingStrategy">
        /// The strategy used to chunk the file.
        /// Please note <see cref="VectorStoreChunkingStrategyResponse"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VectorStoreAutoChunkingStrategyResponse"/> and <see cref="VectorStoreStaticChunkingStrategyResponse"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VectorStoreFile(string id, VectorStoreFileObject @object, int usageBytes, DateTimeOffset createdAt, string vectorStoreId, VectorStoreFileStatus status, VectorStoreFileError lastError, VectorStoreChunkingStrategyResponse chunkingStrategy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            UsageBytes = usageBytes;
            CreatedAt = createdAt;
            VectorStoreId = vectorStoreId;
            Status = status;
            LastError = lastError;
            ChunkingStrategy = chunkingStrategy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreFile"/> for deserialization. </summary>
        internal VectorStoreFile()
        {
        }

        /// <summary> The identifier, which can be referenced in API endpoints. </summary>
        public string Id { get; }
        /// <summary> The object type, which is always `vector_store.file`. </summary>
        public VectorStoreFileObject Object { get; } = VectorStoreFileObject.VectorStoreFile;

        /// <summary>
        /// The total vector store usage in bytes. Note that this may be different from the original file
        /// size.
        /// </summary>
        public int UsageBytes { get; }
        /// <summary> The Unix timestamp (in seconds) for when the vector store file was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The ID of the vector store that the file is attached to. </summary>
        public string VectorStoreId { get; }
        /// <summary> The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use. </summary>
        public VectorStoreFileStatus Status { get; }
        /// <summary> The last error associated with this vector store file. Will be `null` if there are no errors. </summary>
        public VectorStoreFileError LastError { get; }
        /// <summary>
        /// The strategy used to chunk the file.
        /// Please note <see cref="VectorStoreChunkingStrategyResponse"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="VectorStoreAutoChunkingStrategyResponse"/> and <see cref="VectorStoreStaticChunkingStrategyResponse"/>.
        /// </summary>
        public VectorStoreChunkingStrategyResponse ChunkingStrategy { get; }
    }
}
