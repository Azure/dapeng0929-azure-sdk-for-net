// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    /// <summary> Represents the options for swapping two deployments together. </summary>
    public partial class ConversationalAnalysisAuthoringSwapDeploymentsOptions
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

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringSwapDeploymentsOptions"/>. </summary>
        /// <param name="firstDeploymentName"> Represents the first deployment name. </param>
        /// <param name="secondDeploymentName"> Represents the second deployment name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="firstDeploymentName"/> or <paramref name="secondDeploymentName"/> is null. </exception>
        public ConversationalAnalysisAuthoringSwapDeploymentsOptions(string firstDeploymentName, string secondDeploymentName)
        {
            Argument.AssertNotNull(firstDeploymentName, nameof(firstDeploymentName));
            Argument.AssertNotNull(secondDeploymentName, nameof(secondDeploymentName));

            FirstDeploymentName = firstDeploymentName;
            SecondDeploymentName = secondDeploymentName;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringSwapDeploymentsOptions"/>. </summary>
        /// <param name="firstDeploymentName"> Represents the first deployment name. </param>
        /// <param name="secondDeploymentName"> Represents the second deployment name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationalAnalysisAuthoringSwapDeploymentsOptions(string firstDeploymentName, string secondDeploymentName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FirstDeploymentName = firstDeploymentName;
            SecondDeploymentName = secondDeploymentName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringSwapDeploymentsOptions"/> for deserialization. </summary>
        internal ConversationalAnalysisAuthoringSwapDeploymentsOptions()
        {
        }

        /// <summary> Represents the first deployment name. </summary>
        public string FirstDeploymentName { get; }
        /// <summary> Represents the second deployment name. </summary>
        public string SecondDeploymentName { get; }
    }
}
