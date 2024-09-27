// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The CustomSummaryResult. </summary>
    public partial class CustomSummaryResult
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

        /// <summary> Initializes a new instance of <see cref="CustomSummaryResult"/>. </summary>
        /// <param name="conversations"></param>
        /// <param name="errors"></param>
        /// <param name="projectName"></param>
        /// <param name="deploymentName"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversations"/>, <paramref name="errors"/>, <paramref name="projectName"/> or <paramref name="deploymentName"/> is null. </exception>
        internal CustomSummaryResult(IEnumerable<ConversationsSummaryResult> conversations, IEnumerable<DocumentError> errors, string projectName, string deploymentName)
        {
            Argument.AssertNotNull(conversations, nameof(conversations));
            Argument.AssertNotNull(errors, nameof(errors));
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));

            Conversations = conversations.ToList();
            Errors = errors.ToList();
            ProjectName = projectName;
            DeploymentName = deploymentName;
        }

        /// <summary> Initializes a new instance of <see cref="CustomSummaryResult"/>. </summary>
        /// <param name="conversations"></param>
        /// <param name="errors"></param>
        /// <param name="statistics"></param>
        /// <param name="projectName"></param>
        /// <param name="deploymentName"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomSummaryResult(IReadOnlyList<ConversationsSummaryResult> conversations, IReadOnlyList<DocumentError> errors, RequestStatistics statistics, string projectName, string deploymentName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Conversations = conversations;
            Errors = errors;
            Statistics = statistics;
            ProjectName = projectName;
            DeploymentName = deploymentName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomSummaryResult"/> for deserialization. </summary>
        internal CustomSummaryResult()
        {
        }

        /// <summary> Gets the conversations. </summary>
        public IReadOnlyList<ConversationsSummaryResult> Conversations { get; }
        /// <summary> Gets the errors. </summary>
        public IReadOnlyList<DocumentError> Errors { get; }
        /// <summary> Gets the statistics. </summary>
        public RequestStatistics Statistics { get; }
        /// <summary> Gets the project name. </summary>
        public string ProjectName { get; }
        /// <summary> Gets the deployment name. </summary>
        public string DeploymentName { get; }
    }
}
