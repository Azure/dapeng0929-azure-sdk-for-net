// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchPoolUpdateContent. </summary>
    public partial class BatchPoolUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="BatchPoolUpdateContent"/>. </summary>
        public BatchPoolUpdateContent()
        {
            ApplicationPackageReferences = new ChangeTrackingList<BatchApplicationPackageReference>();
            Metadata = new ChangeTrackingList<MetadataItem>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchPoolUpdateContent"/>. </summary>
        /// <param name="startTask"></param>
        /// <param name="applicationPackageReferences"></param>
        /// <param name="metadata"></param>
        /// <param name="targetNodeCommunicationMode"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchPoolUpdateContent(BatchStartTask startTask, IList<BatchApplicationPackageReference> applicationPackageReferences, IList<MetadataItem> metadata, BatchNodeCommunicationMode? targetNodeCommunicationMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartTask = startTask;
            ApplicationPackageReferences = applicationPackageReferences;
            Metadata = metadata;
            TargetNodeCommunicationMode = targetNodeCommunicationMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the start task. </summary>
        public BatchStartTask StartTask { get; set; }
        /// <summary> Gets the application package references. </summary>
        public IList<BatchApplicationPackageReference> ApplicationPackageReferences { get; }
        /// <summary> Gets the metadata. </summary>
        public IList<MetadataItem> Metadata { get; }
        /// <summary> Gets or sets the target node communication mode. </summary>
        public BatchNodeCommunicationMode? TargetNodeCommunicationMode { get; set; }
    }
}
