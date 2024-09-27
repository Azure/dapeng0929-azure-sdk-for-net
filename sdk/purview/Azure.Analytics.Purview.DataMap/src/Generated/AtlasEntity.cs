// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The AtlasEntity. </summary>
    public partial class AtlasEntity
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

        /// <summary> Initializes a new instance of <see cref="AtlasEntity"/>. </summary>
        public AtlasEntity()
        {
            Attributes = new ChangeTrackingDictionary<string, BinaryData>();
            BusinessAttributes = new ChangeTrackingDictionary<string, BinaryData>();
            Classifications = new ChangeTrackingList<AtlasClassification>();
            CustomAttributes = new ChangeTrackingDictionary<string, string>();
            Labels = new ChangeTrackingList<string>();
            Meanings = new ChangeTrackingList<AtlasTermAssignmentHeader>();
            RelationshipAttributes = new ChangeTrackingDictionary<string, BinaryData>();
            Contacts = new ChangeTrackingDictionary<string, IList<ContactInfo>>();
        }

        /// <summary> Initializes a new instance of <see cref="AtlasEntity"/>. </summary>
        /// <param name="attributes"></param>
        /// <param name="typeName"></param>
        /// <param name="lastModifiedTS"></param>
        /// <param name="businessAttributes"></param>
        /// <param name="classifications"></param>
        /// <param name="createTime"></param>
        /// <param name="createdBy"></param>
        /// <param name="customAttributes"></param>
        /// <param name="guid"></param>
        /// <param name="homeId"></param>
        /// <param name="collectionId"></param>
        /// <param name="isIncomplete"></param>
        /// <param name="labels"></param>
        /// <param name="meanings"></param>
        /// <param name="provenanceType"></param>
        /// <param name="proxy"></param>
        /// <param name="relationshipAttributes"></param>
        /// <param name="status"></param>
        /// <param name="updateTime"></param>
        /// <param name="updatedBy"></param>
        /// <param name="version"></param>
        /// <param name="contacts"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AtlasEntity(IDictionary<string, BinaryData> attributes, string typeName, string lastModifiedTS, IDictionary<string, BinaryData> businessAttributes, IList<AtlasClassification> classifications, long? createTime, string createdBy, IDictionary<string, string> customAttributes, string guid, string homeId, string collectionId, bool? isIncomplete, IList<string> labels, IList<AtlasTermAssignmentHeader> meanings, int? provenanceType, bool? proxy, IDictionary<string, BinaryData> relationshipAttributes, EntityStatus? status, long? updateTime, string updatedBy, long? version, IDictionary<string, IList<ContactInfo>> contacts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Attributes = attributes;
            TypeName = typeName;
            LastModifiedTS = lastModifiedTS;
            BusinessAttributes = businessAttributes;
            Classifications = classifications;
            CreateTime = createTime;
            CreatedBy = createdBy;
            CustomAttributes = customAttributes;
            Guid = guid;
            HomeId = homeId;
            CollectionId = collectionId;
            IsIncomplete = isIncomplete;
            Labels = labels;
            Meanings = meanings;
            ProvenanceType = provenanceType;
            Proxy = proxy;
            RelationshipAttributes = relationshipAttributes;
            Status = status;
            UpdateTime = updateTime;
            UpdatedBy = updatedBy;
            Version = version;
            Contacts = contacts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Gets the attributes
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
        public IDictionary<string, BinaryData> Attributes { get; }
        /// <summary> Gets or sets the type name. </summary>
        public string TypeName { get; set; }
        /// <summary> Gets or sets the last modified ts. </summary>
        public string LastModifiedTS { get; set; }
        /// <summary>
        /// Gets the business attributes
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
        public IDictionary<string, BinaryData> BusinessAttributes { get; }
        /// <summary> Gets the classifications. </summary>
        public IList<AtlasClassification> Classifications { get; }
        /// <summary> Gets or sets the create time. </summary>
        public long? CreateTime { get; set; }
        /// <summary> Gets or sets the created by. </summary>
        public string CreatedBy { get; set; }
        /// <summary> Gets the custom attributes. </summary>
        public IDictionary<string, string> CustomAttributes { get; }
        /// <summary> Gets or sets the guid. </summary>
        public string Guid { get; set; }
        /// <summary> Gets or sets the home id. </summary>
        public string HomeId { get; set; }
        /// <summary> Gets the collection id. </summary>
        public string CollectionId { get; }
        /// <summary> Gets or sets the is incomplete. </summary>
        public bool? IsIncomplete { get; set; }
        /// <summary> Gets the labels. </summary>
        public IList<string> Labels { get; }
        /// <summary> Gets the meanings. </summary>
        public IList<AtlasTermAssignmentHeader> Meanings { get; }
        /// <summary> Gets or sets the provenance type. </summary>
        public int? ProvenanceType { get; set; }
        /// <summary> Gets or sets the proxy. </summary>
        public bool? Proxy { get; set; }
        /// <summary>
        /// Gets the relationship attributes
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
        public IDictionary<string, BinaryData> RelationshipAttributes { get; }
        /// <summary> Gets or sets the status. </summary>
        public EntityStatus? Status { get; set; }
        /// <summary> Gets or sets the update time. </summary>
        public long? UpdateTime { get; set; }
        /// <summary> Gets or sets the updated by. </summary>
        public string UpdatedBy { get; set; }
        /// <summary> Gets or sets the version. </summary>
        public long? Version { get; set; }
        /// <summary> Gets the contacts. </summary>
        public IDictionary<string, IList<ContactInfo>> Contacts { get; }
    }
}
