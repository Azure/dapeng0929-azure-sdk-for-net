// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    /// <summary> Represents a regex component of an entity. </summary>
    public partial class ConversationalAnalysisAuthoringExportedEntityRegex
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

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringExportedEntityRegex"/>. </summary>
        public ConversationalAnalysisAuthoringExportedEntityRegex()
        {
            Expressions = new ChangeTrackingList<ConversationalAnalysisAuthoringExportedEntityRegexExpression>();
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringExportedEntityRegex"/>. </summary>
        /// <param name="expressions">
        /// The regex expressions of the regex component. These expressions follow the .NET
        /// regex syntax. For reference, check here:
        /// https://learn.microsoft.com/dotnet/standard/base-types/regular-expressions
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationalAnalysisAuthoringExportedEntityRegex(IList<ConversationalAnalysisAuthoringExportedEntityRegexExpression> expressions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Expressions = expressions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The regex expressions of the regex component. These expressions follow the .NET
        /// regex syntax. For reference, check here:
        /// https://learn.microsoft.com/dotnet/standard/base-types/regular-expressions
        /// </summary>
        public IList<ConversationalAnalysisAuthoringExportedEntityRegexExpression> Expressions { get; }
    }
}
