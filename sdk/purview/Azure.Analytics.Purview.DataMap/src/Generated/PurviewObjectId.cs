// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The PurviewObjectId. </summary>
    public partial class PurviewObjectId
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

        /// <summary> Initializes a new instance of <see cref="PurviewObjectId"/>. </summary>
        public PurviewObjectId()
        {
            UniqueAttributes = new ChangeTrackingDictionary<string, BinaryData>();
            Properties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="PurviewObjectId"/>. </summary>
        /// <param name="guid"></param>
        /// <param name="typeName"></param>
        /// <param name="uniqueAttributes"></param>
        /// <param name="name"></param>
        /// <param name="displayText"></param>
        /// <param name="itemPath"></param>
        /// <param name="resourceId"></param>
        /// <param name="properties"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewObjectId(string guid, string typeName, IDictionary<string, BinaryData> uniqueAttributes, string name, string displayText, string itemPath, string resourceId, IDictionary<string, BinaryData> properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Guid = guid;
            TypeName = typeName;
            UniqueAttributes = uniqueAttributes;
            Name = name;
            DisplayText = displayText;
            ItemPath = itemPath;
            ResourceId = resourceId;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the guid. </summary>
        public string Guid { get; set; }
        /// <summary> Gets or sets the type name. </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// Gets the unique attributes
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
        public IDictionary<string, BinaryData> UniqueAttributes { get; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the display text. </summary>
        public string DisplayText { get; set; }
        /// <summary> Gets or sets the item path. </summary>
        public string ItemPath { get; set; }
        /// <summary> Gets or sets the resource id. </summary>
        public string ResourceId { get; set; }
        /// <summary>
        /// Gets the properties
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
        public IDictionary<string, BinaryData> Properties { get; }
    }
}
