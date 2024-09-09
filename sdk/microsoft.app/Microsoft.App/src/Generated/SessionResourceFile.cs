// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Microsoft.App
{
    /// <summary> Code execution file resource. </summary>
    public partial class SessionResourceFile
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

        /// <summary> Initializes a new instance of <see cref="SessionResourceFile"/>. </summary>
        /// <param name="fileName"> The name of the file. </param>
        /// <param name="sizeInBytes"> The size of the file. </param>
        /// <param name="createdAt"> The date time in RFC3339 format when the file was uploaded. </param>
        /// <param name="lastModifiedAt"> The date time in RFC3339 format when the file was last modified. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileName"/> is null. </exception>
        internal SessionResourceFile(string fileName, long sizeInBytes, DateTimeOffset createdAt, DateTimeOffset lastModifiedAt)
        {
            Argument.AssertNotNull(fileName, nameof(fileName));

            FileName = fileName;
            SizeInBytes = sizeInBytes;
            CreatedAt = createdAt;
            LastModifiedAt = lastModifiedAt;
        }

        /// <summary> Initializes a new instance of <see cref="SessionResourceFile"/>. </summary>
        /// <param name="fileName"> The name of the file. </param>
        /// <param name="sizeInBytes"> The size of the file. </param>
        /// <param name="createdAt"> The date time in RFC3339 format when the file was uploaded. </param>
        /// <param name="lastModifiedAt"> The date time in RFC3339 format when the file was last modified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SessionResourceFile(string fileName, long sizeInBytes, DateTimeOffset createdAt, DateTimeOffset lastModifiedAt, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileName = fileName;
            SizeInBytes = sizeInBytes;
            CreatedAt = createdAt;
            LastModifiedAt = lastModifiedAt;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SessionResourceFile"/> for deserialization. </summary>
        internal SessionResourceFile()
        {
        }

        /// <summary> The name of the file. </summary>
        public string FileName { get; }
        /// <summary> The size of the file. </summary>
        public long SizeInBytes { get; }
        /// <summary> The date time in RFC3339 format when the file was uploaded. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The date time in RFC3339 format when the file was last modified. </summary>
        public DateTimeOffset LastModifiedAt { get; }
    }
}
