// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// Options for an output file upload operation, including under what conditions
    /// to perform the upload.
    /// </summary>
    public partial class OutputFileUploadConfig
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

        /// <summary> Initializes a new instance of <see cref="OutputFileUploadConfig"/>. </summary>
        /// <param name="uploadCondition"> The conditions under which the Task output file or set of files should be uploaded. The default is taskcompletion. </param>
        public OutputFileUploadConfig(OutputFileUploadCondition uploadCondition)
        {
            UploadCondition = uploadCondition;
        }

        /// <summary> Initializes a new instance of <see cref="OutputFileUploadConfig"/>. </summary>
        /// <param name="uploadCondition"> The conditions under which the Task output file or set of files should be uploaded. The default is taskcompletion. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OutputFileUploadConfig(OutputFileUploadCondition uploadCondition, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UploadCondition = uploadCondition;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OutputFileUploadConfig"/> for deserialization. </summary>
        internal OutputFileUploadConfig()
        {
        }

        /// <summary> The conditions under which the Task output file or set of files should be uploaded. The default is taskcompletion. </summary>
        public OutputFileUploadCondition UploadCondition { get; set; }
    }
}
