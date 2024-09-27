// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The AtlasRelationshipAttributeDef. </summary>
    public partial class AtlasRelationshipAttributeDef
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

        /// <summary> Initializes a new instance of <see cref="AtlasRelationshipAttributeDef"/>. </summary>
        public AtlasRelationshipAttributeDef()
        {
            Constraints = new ChangeTrackingList<AtlasConstraintDef>();
            Options = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AtlasRelationshipAttributeDef"/>. </summary>
        /// <param name="cardinality"></param>
        /// <param name="constraints"></param>
        /// <param name="defaultValue"></param>
        /// <param name="description"></param>
        /// <param name="includeInNotification"></param>
        /// <param name="isIndexable"></param>
        /// <param name="isOptional"></param>
        /// <param name="isUnique"></param>
        /// <param name="name"></param>
        /// <param name="options"></param>
        /// <param name="typeName"></param>
        /// <param name="valuesMaxCount"></param>
        /// <param name="valuesMinCount"></param>
        /// <param name="isLegacyAttribute"></param>
        /// <param name="relationshipTypeName"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AtlasRelationshipAttributeDef(CardinalityValue? cardinality, IList<AtlasConstraintDef> constraints, string defaultValue, string description, bool? includeInNotification, bool? isIndexable, bool? isOptional, bool? isUnique, string name, IDictionary<string, string> options, string typeName, int? valuesMaxCount, int? valuesMinCount, bool? isLegacyAttribute, string relationshipTypeName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Cardinality = cardinality;
            Constraints = constraints;
            DefaultValue = defaultValue;
            Description = description;
            IncludeInNotification = includeInNotification;
            IsIndexable = isIndexable;
            IsOptional = isOptional;
            IsUnique = isUnique;
            Name = name;
            Options = options;
            TypeName = typeName;
            ValuesMaxCount = valuesMaxCount;
            ValuesMinCount = valuesMinCount;
            IsLegacyAttribute = isLegacyAttribute;
            RelationshipTypeName = relationshipTypeName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the cardinality. </summary>
        public CardinalityValue? Cardinality { get; set; }
        /// <summary> Gets the constraints. </summary>
        public IList<AtlasConstraintDef> Constraints { get; }
        /// <summary> Gets or sets the default value. </summary>
        public string DefaultValue { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the include in notification. </summary>
        public bool? IncludeInNotification { get; set; }
        /// <summary> Gets or sets the is indexable. </summary>
        public bool? IsIndexable { get; set; }
        /// <summary> Gets or sets the is optional. </summary>
        public bool? IsOptional { get; set; }
        /// <summary> Gets or sets the is unique. </summary>
        public bool? IsUnique { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets the options. </summary>
        public IDictionary<string, string> Options { get; }
        /// <summary> Gets or sets the type name. </summary>
        public string TypeName { get; set; }
        /// <summary> Gets or sets the values max count. </summary>
        public int? ValuesMaxCount { get; set; }
        /// <summary> Gets or sets the values min count. </summary>
        public int? ValuesMinCount { get; set; }
        /// <summary> Gets or sets the is legacy attribute. </summary>
        public bool? IsLegacyAttribute { get; set; }
        /// <summary> Gets or sets the relationship type name. </summary>
        public string RelationshipTypeName { get; set; }
    }
}
