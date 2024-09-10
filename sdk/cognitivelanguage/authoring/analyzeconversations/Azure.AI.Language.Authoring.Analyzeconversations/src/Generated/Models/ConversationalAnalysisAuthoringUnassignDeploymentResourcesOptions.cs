// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    /// <summary> Represents the options to unassign Azure resources from a project. </summary>
    public partial class ConversationalAnalysisAuthoringUnassignDeploymentResourcesOptions
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

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringUnassignDeploymentResourcesOptions"/>. </summary>
        /// <param name="assignedResourceIds"> Represents the assigned resource IDs to be unassigned. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignedResourceIds"/> is null. </exception>
        public ConversationalAnalysisAuthoringUnassignDeploymentResourcesOptions(IEnumerable<string> assignedResourceIds)
        {
            Argument.AssertNotNull(assignedResourceIds, nameof(assignedResourceIds));

            AssignedResourceIds = assignedResourceIds.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringUnassignDeploymentResourcesOptions"/>. </summary>
        /// <param name="assignedResourceIds"> Represents the assigned resource IDs to be unassigned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationalAnalysisAuthoringUnassignDeploymentResourcesOptions(IList<string> assignedResourceIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssignedResourceIds = assignedResourceIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringUnassignDeploymentResourcesOptions"/> for deserialization. </summary>
        internal ConversationalAnalysisAuthoringUnassignDeploymentResourcesOptions()
        {
        }

        /// <summary> Represents the assigned resource IDs to be unassigned. </summary>
        public IList<string> AssignedResourceIds { get; }
    }
}
