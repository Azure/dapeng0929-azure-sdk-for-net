// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The result of uploading Batch service log files from a specific Compute Node. </summary>
    public partial class UploadBatchServiceLogsResult
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

        /// <summary> Initializes a new instance of <see cref="UploadBatchServiceLogsResult"/>. </summary>
        /// <param name="virtualDirectoryName"> The virtual directory within Azure Blob Storage container to which the Batch Service log file(s) will be uploaded. The virtual directory name is part of the blob name for each log file uploaded, and it is built based poolId, nodeId and a unique identifier. </param>
        /// <param name="numberOfFilesUploaded"> The number of log files which will be uploaded. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualDirectoryName"/> is null. </exception>
        internal UploadBatchServiceLogsResult(string virtualDirectoryName, int numberOfFilesUploaded)
        {
            Argument.AssertNotNull(virtualDirectoryName, nameof(virtualDirectoryName));

            VirtualDirectoryName = virtualDirectoryName;
            NumberOfFilesUploaded = numberOfFilesUploaded;
        }

        /// <summary> Initializes a new instance of <see cref="UploadBatchServiceLogsResult"/>. </summary>
        /// <param name="virtualDirectoryName"> The virtual directory within Azure Blob Storage container to which the Batch Service log file(s) will be uploaded. The virtual directory name is part of the blob name for each log file uploaded, and it is built based poolId, nodeId and a unique identifier. </param>
        /// <param name="numberOfFilesUploaded"> The number of log files which will be uploaded. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UploadBatchServiceLogsResult(string virtualDirectoryName, int numberOfFilesUploaded, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualDirectoryName = virtualDirectoryName;
            NumberOfFilesUploaded = numberOfFilesUploaded;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UploadBatchServiceLogsResult"/> for deserialization. </summary>
        internal UploadBatchServiceLogsResult()
        {
        }

        /// <summary> The virtual directory within Azure Blob Storage container to which the Batch Service log file(s) will be uploaded. The virtual directory name is part of the blob name for each log file uploaded, and it is built based poolId, nodeId and a unique identifier. </summary>
        public string VirtualDirectoryName { get; }
        /// <summary> The number of log files which will be uploaded. </summary>
        public int NumberOfFilesUploaded { get; }
    }
}
