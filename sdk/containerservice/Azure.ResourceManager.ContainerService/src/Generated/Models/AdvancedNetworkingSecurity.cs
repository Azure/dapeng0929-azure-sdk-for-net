// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Security profile to enable security features on cilium based cluster. </summary>
    internal partial class AdvancedNetworkingSecurity
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

        /// <summary> Initializes a new instance of <see cref="AdvancedNetworkingSecurity"/>. </summary>
        public AdvancedNetworkingSecurity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AdvancedNetworkingSecurity"/>. </summary>
        /// <param name="fqdnPolicy"> FQDNFiltering profile to enable FQDN Policy filtering on cilium based cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdvancedNetworkingSecurity(AdvancedNetworkingFqdnPolicy fqdnPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FqdnPolicy = fqdnPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> FQDNFiltering profile to enable FQDN Policy filtering on cilium based cluster. </summary>
        internal AdvancedNetworkingFqdnPolicy FqdnPolicy { get; set; }
        /// <summary> This feature allows user to configure network policy based on DNS (FQDN) names. It can be enabled only on cilium based clusters. If not specified, the default is false. </summary>
        public bool? FqdnPolicyEnabled
        {
            get => FqdnPolicy is null ? default : FqdnPolicy.Enabled;
            set
            {
                if (FqdnPolicy is null)
                    FqdnPolicy = new AdvancedNetworkingFqdnPolicy();
                FqdnPolicy.Enabled = value;
            }
        }
    }
}
