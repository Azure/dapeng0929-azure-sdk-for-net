// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.ProgrammableConnectivity
{
    /// <summary> The network that the device is on. </summary>
    public partial class NetworkRetrievalResult
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

        /// <summary> Initializes a new instance of <see cref="NetworkRetrievalResult"/>. </summary>
        /// <param name="networkCode"> The identifier for the network. This can be used as the networkIdentifier for the service APIs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkCode"/> is null. </exception>
        internal NetworkRetrievalResult(string networkCode)
        {
            Argument.AssertNotNull(networkCode, nameof(networkCode));

            NetworkCode = networkCode;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkRetrievalResult"/>. </summary>
        /// <param name="networkCode"> The identifier for the network. This can be used as the networkIdentifier for the service APIs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkRetrievalResult(string networkCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkCode = networkCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkRetrievalResult"/> for deserialization. </summary>
        internal NetworkRetrievalResult()
        {
        }

        /// <summary> The identifier for the network. This can be used as the networkIdentifier for the service APIs. </summary>
        public string NetworkCode { get; }
    }
}
