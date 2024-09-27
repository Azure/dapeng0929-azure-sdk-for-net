// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The AtlasBusinessMetadataDef. </summary>
    public partial class AtlasBusinessMetadataDef
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

        /// <summary> Initializes a new instance of <see cref="AtlasBusinessMetadataDef"/>. </summary>
        public AtlasBusinessMetadataDef()
        {
            Options = new ChangeTrackingDictionary<string, string>();
            AttributeDefs = new ChangeTrackingList<AtlasAttributeDef>();
        }

        /// <summary> Initializes a new instance of <see cref="AtlasBusinessMetadataDef"/>. </summary>
        /// <param name="category"></param>
        /// <param name="createTime"></param>
        /// <param name="createdBy"></param>
        /// <param name="dateFormatter"></param>
        /// <param name="description"></param>
        /// <param name="guid"></param>
        /// <param name="name"></param>
        /// <param name="options"></param>
        /// <param name="serviceType"></param>
        /// <param name="typeVersion"></param>
        /// <param name="updateTime"></param>
        /// <param name="updatedBy"></param>
        /// <param name="version"></param>
        /// <param name="lastModifiedTS"></param>
        /// <param name="attributeDefs"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AtlasBusinessMetadataDef(TypeCategory? category, long? createTime, string createdBy, AtlasDateFormat dateFormatter, string description, string guid, string name, IDictionary<string, string> options, string serviceType, string typeVersion, long? updateTime, string updatedBy, long? version, string lastModifiedTS, IList<AtlasAttributeDef> attributeDefs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            CreateTime = createTime;
            CreatedBy = createdBy;
            DateFormatter = dateFormatter;
            Description = description;
            Guid = guid;
            Name = name;
            Options = options;
            ServiceType = serviceType;
            TypeVersion = typeVersion;
            UpdateTime = updateTime;
            UpdatedBy = updatedBy;
            Version = version;
            LastModifiedTS = lastModifiedTS;
            AttributeDefs = attributeDefs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the category. </summary>
        public TypeCategory? Category { get; set; }
        /// <summary> Gets or sets the create time. </summary>
        public long? CreateTime { get; set; }
        /// <summary> Gets or sets the created by. </summary>
        public string CreatedBy { get; set; }
        /// <summary> Gets or sets the date formatter. </summary>
        public AtlasDateFormat DateFormatter { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the guid. </summary>
        public string Guid { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets the options. </summary>
        public IDictionary<string, string> Options { get; }
        /// <summary> Gets or sets the service type. </summary>
        public string ServiceType { get; set; }
        /// <summary> Gets or sets the type version. </summary>
        public string TypeVersion { get; set; }
        /// <summary> Gets or sets the update time. </summary>
        public long? UpdateTime { get; set; }
        /// <summary> Gets or sets the updated by. </summary>
        public string UpdatedBy { get; set; }
        /// <summary> Gets or sets the version. </summary>
        public long? Version { get; set; }
        /// <summary> Gets or sets the last modified ts. </summary>
        public string LastModifiedTS { get; set; }
        /// <summary> Gets the attribute defs. </summary>
        public IList<AtlasAttributeDef> AttributeDefs { get; }
    }
}
