// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The QueryFilters. </summary>
    public partial class QueryFilters
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

        /// <summary> Initializes a new instance of <see cref="QueryFilters"/>. </summary>
        public QueryFilters()
        {
            SourceFilter = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryFilters"/>. </summary>
        /// <param name="metadataFilter"></param>
        /// <param name="sourceFilter"></param>
        /// <param name="logicalOperation"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryFilters(MetadataFilter metadataFilter, IList<string> sourceFilter, LogicalOperationKind? logicalOperation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MetadataFilter = metadataFilter;
            SourceFilter = sourceFilter;
            LogicalOperation = logicalOperation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the metadata filter. </summary>
        public MetadataFilter MetadataFilter { get; set; }
        /// <summary> Gets the source filter. </summary>
        public IList<string> SourceFilter { get; }
        /// <summary> Gets or sets the logical operation. </summary>
        public LogicalOperationKind? LogicalOperation { get; set; }
    }
}
