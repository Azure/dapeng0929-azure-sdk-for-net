// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The AtlasGlossaryExtInfo. </summary>
    public partial class AtlasGlossaryExtInfo
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

        /// <summary> Initializes a new instance of <see cref="AtlasGlossaryExtInfo"/>. </summary>
        internal AtlasGlossaryExtInfo()
        {
            Classifications = new ChangeTrackingList<AtlasClassification>();
            Categories = new ChangeTrackingList<AtlasRelatedCategoryHeader>();
            Terms = new ChangeTrackingList<AtlasRelatedTermHeader>();
            CategoryInfo = new ChangeTrackingDictionary<string, AtlasGlossaryCategory>();
            TermInfo = new ChangeTrackingDictionary<string, AtlasGlossaryTerm>();
        }

        /// <summary> Initializes a new instance of <see cref="AtlasGlossaryExtInfo"/>. </summary>
        /// <param name="guid"></param>
        /// <param name="classifications"></param>
        /// <param name="longDescription"></param>
        /// <param name="name"></param>
        /// <param name="qualifiedName"></param>
        /// <param name="shortDescription"></param>
        /// <param name="lastModifiedTS"></param>
        /// <param name="createTime"></param>
        /// <param name="createdBy"></param>
        /// <param name="updateTime"></param>
        /// <param name="updatedBy"></param>
        /// <param name="categories"></param>
        /// <param name="language"></param>
        /// <param name="terms"></param>
        /// <param name="usage"></param>
        /// <param name="categoryInfo"></param>
        /// <param name="termInfo"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AtlasGlossaryExtInfo(string guid, IReadOnlyList<AtlasClassification> classifications, string longDescription, string name, string qualifiedName, string shortDescription, string lastModifiedTS, long? createTime, string createdBy, long? updateTime, string updatedBy, IReadOnlyList<AtlasRelatedCategoryHeader> categories, string language, IReadOnlyList<AtlasRelatedTermHeader> terms, string usage, IReadOnlyDictionary<string, AtlasGlossaryCategory> categoryInfo, IReadOnlyDictionary<string, AtlasGlossaryTerm> termInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Guid = guid;
            Classifications = classifications;
            LongDescription = longDescription;
            Name = name;
            QualifiedName = qualifiedName;
            ShortDescription = shortDescription;
            LastModifiedTS = lastModifiedTS;
            CreateTime = createTime;
            CreatedBy = createdBy;
            UpdateTime = updateTime;
            UpdatedBy = updatedBy;
            Categories = categories;
            Language = language;
            Terms = terms;
            Usage = usage;
            CategoryInfo = categoryInfo;
            TermInfo = termInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the guid. </summary>
        public string Guid { get; }
        /// <summary> Gets the classifications. </summary>
        public IReadOnlyList<AtlasClassification> Classifications { get; }
        /// <summary> Gets the long description. </summary>
        public string LongDescription { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the qualified name. </summary>
        public string QualifiedName { get; }
        /// <summary> Gets the short description. </summary>
        public string ShortDescription { get; }
        /// <summary> Gets the last modified ts. </summary>
        public string LastModifiedTS { get; }
        /// <summary> Gets the create time. </summary>
        public long? CreateTime { get; }
        /// <summary> Gets the created by. </summary>
        public string CreatedBy { get; }
        /// <summary> Gets the update time. </summary>
        public long? UpdateTime { get; }
        /// <summary> Gets the updated by. </summary>
        public string UpdatedBy { get; }
        /// <summary> Gets the categories. </summary>
        public IReadOnlyList<AtlasRelatedCategoryHeader> Categories { get; }
        /// <summary> Gets the language. </summary>
        public string Language { get; }
        /// <summary> Gets the terms. </summary>
        public IReadOnlyList<AtlasRelatedTermHeader> Terms { get; }
        /// <summary> Gets the usage. </summary>
        public string Usage { get; }
        /// <summary> Gets the category info. </summary>
        public IReadOnlyDictionary<string, AtlasGlossaryCategory> CategoryInfo { get; }
        /// <summary> Gets the term info. </summary>
        public IReadOnlyDictionary<string, AtlasGlossaryTerm> TermInfo { get; }
    }
}
