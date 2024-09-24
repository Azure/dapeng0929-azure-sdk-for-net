// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The properties of the machine. </summary>
    public partial class MachineProperties
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

        /// <summary> Initializes a new instance of <see cref="MachineProperties"/>. </summary>
        internal MachineProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineProperties"/>. </summary>
        /// <param name="network"> network properties of the machine. </param>
        /// <param name="resourceId"> Azure resource id of the machine. It can be used to GET underlying VM Instance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineProperties(MachineNetworkProperties network, ResourceIdentifier resourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Network = network;
            ResourceId = resourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> network properties of the machine. </summary>
        internal MachineNetworkProperties Network { get; }
        /// <summary> IPv4, IPv6 addresses of the machine. </summary>
        [WirePath("network.ipAddresses")]
        public IReadOnlyList<MachineIPAddress> NetworkIPAddresses
        {
            get => Network?.IPAddresses;
        }

        /// <summary> Azure resource id of the machine. It can be used to GET underlying VM Instance. </summary>
        [WirePath("resourceId")]
        public ResourceIdentifier ResourceId { get; }
    }
}
