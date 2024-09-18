// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft.App
{
    /// <summary> The UploadFileRequest. </summary>
    internal partial class UploadFileRequest
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

        /// <summary> Initializes a new instance of <see cref="UploadFileRequest"/>. </summary>
        /// <param name="file"> The file to upload. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="file"/> is null. </exception>
        internal UploadFileRequest(Stream file)
        {
            Argument.AssertNotNull(file, nameof(file));

            File = file;
        }

        /// <summary> Initializes a new instance of <see cref="UploadFileRequest"/>. </summary>
        /// <param name="file"> The file to upload. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UploadFileRequest(Stream file, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            File = file;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UploadFileRequest"/> for deserialization. </summary>
        internal UploadFileRequest()
        {
        }

        /// <summary> The file to upload. </summary>
        public Stream File { get; }
    }
}
