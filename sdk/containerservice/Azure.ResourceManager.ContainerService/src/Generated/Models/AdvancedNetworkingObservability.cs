// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Observability profile to enable advanced network metrics and flow logs with historical contexts. </summary>
    public partial class AdvancedNetworkingObservability
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

        /// <summary> Initializes a new instance of <see cref="AdvancedNetworkingObservability"/>. </summary>
        public AdvancedNetworkingObservability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AdvancedNetworkingObservability"/>. </summary>
        /// <param name="enabled"> Indicates the enablement of Advanced Networking observability functionalities on clusters. </param>
        /// <param name="tlsManagement"> Management of TLS certificates for querying network flow logs via the flow log endpoint for Advanced Networking observability clusters. If not specified, the default is Managed. For more information see aka.ms/acnstls. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdvancedNetworkingObservability(bool? enabled, TLSManagement? tlsManagement, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            TlsManagement = tlsManagement;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates the enablement of Advanced Networking observability functionalities on clusters. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Management of TLS certificates for querying network flow logs via the flow log endpoint for Advanced Networking observability clusters. If not specified, the default is Managed. For more information see aka.ms/acnstls. </summary>
        public TLSManagement? TlsManagement { get; set; }
    }
}
