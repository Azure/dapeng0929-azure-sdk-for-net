// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> Represents an assistant that can call the model and use tools. </summary>
    public partial class OpenAIFile
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

        /// <summary> Initializes a new instance of <see cref="OpenAIFile"/>. </summary>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="bytes"> The size of the file, in bytes. </param>
        /// <param name="filename"> The name of the file. </param>
        /// <param name="createdAt"> The Unix timestamp, in seconds, representing when this object was created. </param>
        /// <param name="purpose"> The intended purpose of a file. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="filename"/> is null. </exception>
        internal OpenAIFile(string id, int bytes, string filename, DateTimeOffset createdAt, FilePurpose purpose)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(filename, nameof(filename));

            Id = id;
            Bytes = bytes;
            Filename = filename;
            CreatedAt = createdAt;
            Purpose = purpose;
        }

        /// <summary> Initializes a new instance of <see cref="OpenAIFile"/>. </summary>
        /// <param name="object"> The object type, which is always 'file'. </param>
        /// <param name="id"> The identifier, which can be referenced in API endpoints. </param>
        /// <param name="bytes"> The size of the file, in bytes. </param>
        /// <param name="filename"> The name of the file. </param>
        /// <param name="createdAt"> The Unix timestamp, in seconds, representing when this object was created. </param>
        /// <param name="purpose"> The intended purpose of a file. </param>
        /// <param name="status"> The state of the file. This field is available in Azure OpenAI only. </param>
        /// <param name="statusDetails"> The error message with details in case processing of this file failed. This field is available in Azure OpenAI only. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OpenAIFile(OpenAIFileObject @object, string id, int bytes, string filename, DateTimeOffset createdAt, FilePurpose purpose, FileState? status, string statusDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Object = @object;
            Id = id;
            Bytes = bytes;
            Filename = filename;
            CreatedAt = createdAt;
            Purpose = purpose;
            Status = status;
            StatusDetails = statusDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OpenAIFile"/> for deserialization. </summary>
        internal OpenAIFile()
        {
        }

        /// <summary> The object type, which is always 'file'. </summary>
        public OpenAIFileObject Object { get; } = OpenAIFileObject.File;

        /// <summary> The identifier, which can be referenced in API endpoints. </summary>
        public string Id { get; }
        /// <summary> The size of the file, in bytes. </summary>
        public int Bytes { get; }
        /// <summary> The name of the file. </summary>
        public string Filename { get; }
        /// <summary> The Unix timestamp, in seconds, representing when this object was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The intended purpose of a file. </summary>
        public FilePurpose Purpose { get; }
        /// <summary> The state of the file. This field is available in Azure OpenAI only. </summary>
        public FileState? Status { get; }
        /// <summary> The error message with details in case processing of this file failed. This field is available in Azure OpenAI only. </summary>
        public string StatusDetails { get; }
    }
}
