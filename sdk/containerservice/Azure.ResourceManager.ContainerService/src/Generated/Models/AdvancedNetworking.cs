// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Advanced Networking profile for enabling observability and security feature suite on a cluster. For more information see aka.ms/aksadvancednetworking. </summary>
    public partial class AdvancedNetworking
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

        /// <summary> Initializes a new instance of <see cref="AdvancedNetworking"/>. </summary>
        public AdvancedNetworking()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AdvancedNetworking"/>. </summary>
        /// <param name="enabled"> Indicates the enablement of Advanced Networking functionalities of observability and security on AKS clusters. When this is set to true, all observability and security features will be set to enabled unless explicitly disabled. If not specified, the default is false. </param>
        /// <param name="observability"> Observability profile to enable advanced network metrics and flow logs with historical contexts. </param>
        /// <param name="security"> Security profile to enable security features on cilium based cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdvancedNetworking(bool? enabled, AdvancedNetworkingObservability observability, AdvancedNetworkingSecurity security, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            Observability = observability;
            Security = security;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates the enablement of Advanced Networking functionalities of observability and security on AKS clusters. When this is set to true, all observability and security features will be set to enabled unless explicitly disabled. If not specified, the default is false. </summary>
        [WirePath("enabled")]
        public bool? Enabled { get; set; }
        /// <summary> Observability profile to enable advanced network metrics and flow logs with historical contexts. </summary>
        internal AdvancedNetworkingObservability Observability { get; set; }
        /// <summary> Indicates the enablement of Advanced Networking observability functionalities on clusters. </summary>
        [WirePath("observability.enabled")]
        public bool? ObservabilityEnabled
        {
            get => Observability is null ? default : Observability.Enabled;
            set
            {
                if (Observability is null)
                    Observability = new AdvancedNetworkingObservability();
                Observability.Enabled = value;
            }
        }

        /// <summary> Security profile to enable security features on cilium based cluster. </summary>
        internal AdvancedNetworkingSecurity Security { get; set; }
        /// <summary> This feature allows user to configure network policy based on DNS (FQDN) names. It can be enabled only on cilium based clusters. If not specified, the default is false. </summary>
        [WirePath("security.enabled")]
        public bool? SecurityEnabled
        {
            get => Security is null ? default : Security.Enabled;
            set
            {
                if (Security is null)
                    Security = new AdvancedNetworkingSecurity();
                Security.Enabled = value;
            }
        }
    }
}
