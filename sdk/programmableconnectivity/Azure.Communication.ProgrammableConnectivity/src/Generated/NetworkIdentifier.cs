// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.ProgrammableConnectivity
{
    /// <summary> Identifier for the network to be queried. </summary>
    public partial class NetworkIdentifier
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

        /// <summary> Initializes a new instance of <see cref="NetworkIdentifier"/>. </summary>
        /// <param name="identifierType"> The type of identifier for the network. one of: 'IPv4', 'IPv6', 'NetworkCode'. </param>
        /// <param name="identifier">
        /// The network identifier, based on the identifierType: an IPv4 address, and IPv6 address, or a Network Code.
        /// A Network Code may be obtained from APC documentation or from the APC /Network:retrieve endpoint.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identifierType"/> or <paramref name="identifier"/> is null. </exception>
        public NetworkIdentifier(string identifierType, string identifier)
        {
            Argument.AssertNotNull(identifierType, nameof(identifierType));
            Argument.AssertNotNull(identifier, nameof(identifier));

            IdentifierType = identifierType;
            Identifier = identifier;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkIdentifier"/>. </summary>
        /// <param name="identifierType"> The type of identifier for the network. one of: 'IPv4', 'IPv6', 'NetworkCode'. </param>
        /// <param name="identifier">
        /// The network identifier, based on the identifierType: an IPv4 address, and IPv6 address, or a Network Code.
        /// A Network Code may be obtained from APC documentation or from the APC /Network:retrieve endpoint.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkIdentifier(string identifierType, string identifier, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IdentifierType = identifierType;
            Identifier = identifier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkIdentifier"/> for deserialization. </summary>
        internal NetworkIdentifier()
        {
        }

        /// <summary> The type of identifier for the network. one of: 'IPv4', 'IPv6', 'NetworkCode'. </summary>
        public string IdentifierType { get; }
        /// <summary>
        /// The network identifier, based on the identifierType: an IPv4 address, and IPv6 address, or a Network Code.
        /// A Network Code may be obtained from APC documentation or from the APC /Network:retrieve endpoint.
        /// </summary>
        public string Identifier { get; }
    }
}
