// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The machine IP address details. </summary>
    public partial class MachineIPAddress
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

        /// <summary> Initializes a new instance of <see cref="MachineIPAddress"/>. </summary>
        internal MachineIPAddress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineIPAddress"/>. </summary>
        /// <param name="family"> To determine if address belongs IPv4 or IPv6 family. </param>
        /// <param name="ip"> IPv4 or IPv6 address of the machine. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineIPAddress(IPFamily? family, string ip, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Family = family;
            IP = ip;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> To determine if address belongs IPv4 or IPv6 family. </summary>
        [WirePath("family")]
        public IPFamily? Family { get; }
        /// <summary> IPv4 or IPv6 address of the machine. </summary>
        [WirePath("ip")]
        public string IP { get; }
    }
}
