// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A skill that extracts content and layout information (as markdown), via Azure AI Services, from files within the enrichment pipeline. </summary>
    public partial class DocumentIntelligenceLayoutSkill : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of <see cref="DocumentIntelligenceLayoutSkill"/>. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        public DocumentIntelligenceLayoutSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            Argument.AssertNotNull(inputs, nameof(inputs));
            Argument.AssertNotNull(outputs, nameof(outputs));

            ODataType = "#Microsoft.Skills.Util.DocumentIntelligenceLayoutSkill";
        }

        /// <summary> Initializes a new instance of <see cref="DocumentIntelligenceLayoutSkill"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character '#'. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="outputMode"> Controls the cardinality of the output produced by the skill. </param>
        /// <param name="markdownHeaderDepth"> The depth of headers in the markdown output. Default is h6. </param>
        internal DocumentIntelligenceLayoutSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, DocumentIntelligenceLayoutSkillOutputMode? outputMode, DocumentIntelligenceLayoutSkillMarkdownHeaderDepth? markdownHeaderDepth) : base(oDataType, name, description, context, inputs, outputs)
        {
            OutputMode = outputMode;
            MarkdownHeaderDepth = markdownHeaderDepth;
            ODataType = oDataType ?? "#Microsoft.Skills.Util.DocumentIntelligenceLayoutSkill";
        }

        /// <summary> Controls the cardinality of the output produced by the skill. </summary>
        public DocumentIntelligenceLayoutSkillOutputMode? OutputMode { get; set; }
        /// <summary> The depth of headers in the markdown output. Default is h6. </summary>
        public DocumentIntelligenceLayoutSkillMarkdownHeaderDepth? MarkdownHeaderDepth { get; set; }
    }
}
