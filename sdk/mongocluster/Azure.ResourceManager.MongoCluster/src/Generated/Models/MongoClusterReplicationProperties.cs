// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> The MongoClusterReplicationProperties. </summary>
    public partial class MongoClusterReplicationProperties
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

        /// <summary> Initializes a new instance of <see cref="MongoClusterReplicationProperties"/>. </summary>
        internal MongoClusterReplicationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MongoClusterReplicationProperties"/>. </summary>
        /// <param name="sourceResourceId"></param>
        /// <param name="role"></param>
        /// <param name="replicationState"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoClusterReplicationProperties(ResourceIdentifier sourceResourceId, MongoClusterReplicationRole? role, MongoClusterReplicationState? replicationState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceResourceId = sourceResourceId;
            Role = role;
            ReplicationState = replicationState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the source resource id. </summary>
        public ResourceIdentifier SourceResourceId { get; }
        /// <summary> Gets the role. </summary>
        public MongoClusterReplicationRole? Role { get; }
        /// <summary> Gets the replication state. </summary>
        public MongoClusterReplicationState? ReplicationState { get; }
    }
}
