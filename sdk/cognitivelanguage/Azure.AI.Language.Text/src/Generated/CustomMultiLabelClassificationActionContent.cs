// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> The CustomMultiLabelClassificationActionContent. </summary>
    public partial class CustomMultiLabelClassificationActionContent
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

        /// <summary> Initializes a new instance of <see cref="CustomMultiLabelClassificationActionContent"/>. </summary>
        /// <param name="projectName"></param>
        /// <param name="deploymentName"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="deploymentName"/> is null. </exception>
        public CustomMultiLabelClassificationActionContent(string projectName, string deploymentName)
        {
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));

            ProjectName = projectName;
            DeploymentName = deploymentName;
        }

        /// <summary> Initializes a new instance of <see cref="CustomMultiLabelClassificationActionContent"/>. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="projectName"></param>
        /// <param name="deploymentName"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomMultiLabelClassificationActionContent(bool? loggingOptOut, string projectName, string deploymentName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LoggingOptOut = loggingOptOut;
            ProjectName = projectName;
            DeploymentName = deploymentName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomMultiLabelClassificationActionContent"/> for deserialization. </summary>
        internal CustomMultiLabelClassificationActionContent()
        {
        }

        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
        /// <summary> Gets the project name. </summary>
        public string ProjectName { get; }
        /// <summary> Gets the deployment name. </summary>
        public string DeploymentName { get; }
    }
}
