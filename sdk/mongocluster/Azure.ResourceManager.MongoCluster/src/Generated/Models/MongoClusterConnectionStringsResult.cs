// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> The MongoClusterConnectionStringsResult. </summary>
    public partial class MongoClusterConnectionStringsResult
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

        /// <summary> Initializes a new instance of <see cref="MongoClusterConnectionStringsResult"/>. </summary>
        internal MongoClusterConnectionStringsResult()
        {
            ConnectionStrings = new ChangeTrackingList<MongoClusterConnectionString>();
        }

        /// <summary> Initializes a new instance of <see cref="MongoClusterConnectionStringsResult"/>. </summary>
        /// <param name="connectionStrings"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoClusterConnectionStringsResult(IReadOnlyList<MongoClusterConnectionString> connectionStrings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConnectionStrings = connectionStrings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the connection strings. </summary>
        public IReadOnlyList<MongoClusterConnectionString> ConnectionStrings { get; }
    }
}
