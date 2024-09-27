// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// The Batch Compute Node agent is a program that runs on each Compute Node in the
    /// Pool and provides Batch capability on the Compute Node.
    /// </summary>
    public partial class BatchNodeAgentInfo
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

        /// <summary> Initializes a new instance of <see cref="BatchNodeAgentInfo"/>. </summary>
        /// <param name="version"> The version of the Batch Compute Node agent running on the Compute Node. This version number can be checked against the Compute Node agent release notes located at https://github.com/Azure/Batch/blob/master/changelogs/nodeagent/CHANGELOG.md. </param>
        /// <param name="lastUpdateTime"> The time when the Compute Node agent was updated on the Compute Node. This is the most recent time that the Compute Node agent was updated to a new version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="version"/> is null. </exception>
        internal BatchNodeAgentInfo(string version, DateTimeOffset lastUpdateTime)
        {
            Argument.AssertNotNull(version, nameof(version));

            Version = version;
            LastUpdateTime = lastUpdateTime;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeAgentInfo"/>. </summary>
        /// <param name="version"> The version of the Batch Compute Node agent running on the Compute Node. This version number can be checked against the Compute Node agent release notes located at https://github.com/Azure/Batch/blob/master/changelogs/nodeagent/CHANGELOG.md. </param>
        /// <param name="lastUpdateTime"> The time when the Compute Node agent was updated on the Compute Node. This is the most recent time that the Compute Node agent was updated to a new version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNodeAgentInfo(string version, DateTimeOffset lastUpdateTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Version = version;
            LastUpdateTime = lastUpdateTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeAgentInfo"/> for deserialization. </summary>
        internal BatchNodeAgentInfo()
        {
        }

        /// <summary> The version of the Batch Compute Node agent running on the Compute Node. This version number can be checked against the Compute Node agent release notes located at https://github.com/Azure/Batch/blob/master/changelogs/nodeagent/CHANGELOG.md. </summary>
        public string Version { get; }
        /// <summary> The time when the Compute Node agent was updated on the Compute Node. This is the most recent time that the Compute Node agent was updated to a new version. </summary>
        public DateTimeOffset LastUpdateTime { get; }
    }
}
