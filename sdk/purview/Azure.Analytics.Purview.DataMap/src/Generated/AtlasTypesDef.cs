// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The AtlasTypesDef. </summary>
    public partial class AtlasTypesDef
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

        /// <summary> Initializes a new instance of <see cref="AtlasTypesDef"/>. </summary>
        public AtlasTypesDef()
        {
            BusinessMetadataDefs = new ChangeTrackingList<AtlasBusinessMetadataDef>();
            ClassificationDefs = new ChangeTrackingList<AtlasClassificationDef>();
            EntityDefs = new ChangeTrackingList<AtlasEntityDef>();
            EnumDefs = new ChangeTrackingList<AtlasEnumDef>();
            RelationshipDefs = new ChangeTrackingList<AtlasRelationshipDef>();
            StructDefs = new ChangeTrackingList<AtlasStructDef>();
            TermTemplateDefs = new ChangeTrackingList<TermTemplateDef>();
        }

        /// <summary> Initializes a new instance of <see cref="AtlasTypesDef"/>. </summary>
        /// <param name="businessMetadataDefs"></param>
        /// <param name="classificationDefs"></param>
        /// <param name="entityDefs"></param>
        /// <param name="enumDefs"></param>
        /// <param name="relationshipDefs"></param>
        /// <param name="structDefs"></param>
        /// <param name="termTemplateDefs"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AtlasTypesDef(IList<AtlasBusinessMetadataDef> businessMetadataDefs, IList<AtlasClassificationDef> classificationDefs, IList<AtlasEntityDef> entityDefs, IList<AtlasEnumDef> enumDefs, IList<AtlasRelationshipDef> relationshipDefs, IList<AtlasStructDef> structDefs, IList<TermTemplateDef> termTemplateDefs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BusinessMetadataDefs = businessMetadataDefs;
            ClassificationDefs = classificationDefs;
            EntityDefs = entityDefs;
            EnumDefs = enumDefs;
            RelationshipDefs = relationshipDefs;
            StructDefs = structDefs;
            TermTemplateDefs = termTemplateDefs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the business metadata defs. </summary>
        public IList<AtlasBusinessMetadataDef> BusinessMetadataDefs { get; }
        /// <summary> Gets the classification defs. </summary>
        public IList<AtlasClassificationDef> ClassificationDefs { get; }
        /// <summary> Gets the entity defs. </summary>
        public IList<AtlasEntityDef> EntityDefs { get; }
        /// <summary> Gets the enum defs. </summary>
        public IList<AtlasEnumDef> EnumDefs { get; }
        /// <summary> Gets the relationship defs. </summary>
        public IList<AtlasRelationshipDef> RelationshipDefs { get; }
        /// <summary> Gets the struct defs. </summary>
        public IList<AtlasStructDef> StructDefs { get; }
        /// <summary> Gets the term template defs. </summary>
        public IList<TermTemplateDef> TermTemplateDefs { get; }
    }
}
