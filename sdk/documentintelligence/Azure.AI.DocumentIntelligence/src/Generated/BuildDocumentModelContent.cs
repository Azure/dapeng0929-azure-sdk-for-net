// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> The BuildDocumentModelContent. </summary>
    public partial class BuildDocumentModelContent
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

        /// <summary> Initializes a new instance of <see cref="BuildDocumentModelContent"/>. </summary>
        /// <param name="modelId"></param>
        /// <param name="buildMode"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        public BuildDocumentModelContent(string modelId, DocumentBuildMode buildMode)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            ModelId = modelId;
            BuildMode = buildMode;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="BuildDocumentModelContent"/>. </summary>
        /// <param name="modelId"></param>
        /// <param name="description"></param>
        /// <param name="buildMode"></param>
        /// <param name="azureBlobSource"></param>
        /// <param name="azureBlobFileListSource"></param>
        /// <param name="tags"></param>
        /// <param name="maxTrainingHours"></param>
        /// <param name="allowOverwrite"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildDocumentModelContent(string modelId, string description, DocumentBuildMode buildMode, AzureBlobContentSource azureBlobSource, AzureBlobFileListContentSource azureBlobFileListSource, IDictionary<string, string> tags, float? maxTrainingHours, bool? allowOverwrite, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelId = modelId;
            Description = description;
            BuildMode = buildMode;
            AzureBlobSource = azureBlobSource;
            AzureBlobFileListSource = azureBlobFileListSource;
            Tags = tags;
            MaxTrainingHours = maxTrainingHours;
            AllowOverwrite = allowOverwrite;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BuildDocumentModelContent"/> for deserialization. </summary>
        internal BuildDocumentModelContent()
        {
        }

        /// <summary> Gets the model id. </summary>
        public string ModelId { get; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> Gets the build mode. </summary>
        public DocumentBuildMode BuildMode { get; }
        /// <summary> Gets or sets the azure blob source. </summary>
        public AzureBlobContentSource AzureBlobSource { get; set; }
        /// <summary> Gets or sets the azure blob file list source. </summary>
        public AzureBlobFileListContentSource AzureBlobFileListSource { get; set; }
        /// <summary> Gets the tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the max training hours. </summary>
        public float? MaxTrainingHours { get; set; }
        /// <summary> Gets or sets the allow overwrite. </summary>
        public bool? AllowOverwrite { get; set; }
    }
}
