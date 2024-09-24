// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The security settings of an agent pool. </summary>
    public partial class AgentPoolSecurityProfile
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

        /// <summary> Initializes a new instance of <see cref="AgentPoolSecurityProfile"/>. </summary>
        public AgentPoolSecurityProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolSecurityProfile"/>. </summary>
        /// <param name="sshAccess"> SSH access method of an agent pool. </param>
        /// <param name="enableVtpm"> vTPM is a Trusted Launch feature for configuring a dedicated secure vault for keys and measurements held locally on the node. For more details, see aka.ms/aks/trustedlaunch. If not specified, the default is false. </param>
        /// <param name="enableSecureBoot"> Secure Boot is a feature of Trusted Launch which ensures that only signed operating systems and drivers can boot. For more details, see aka.ms/aks/trustedlaunch.  If not specified, the default is false. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentPoolSecurityProfile(AgentPoolSSHAccess? sshAccess, bool? enableVtpm, bool? enableSecureBoot, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SshAccess = sshAccess;
            EnableVtpm = enableVtpm;
            EnableSecureBoot = enableSecureBoot;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> SSH access method of an agent pool. </summary>
        [WirePath("sshAccess")]
        public AgentPoolSSHAccess? SshAccess { get; set; }
        /// <summary> vTPM is a Trusted Launch feature for configuring a dedicated secure vault for keys and measurements held locally on the node. For more details, see aka.ms/aks/trustedlaunch. If not specified, the default is false. </summary>
        [WirePath("enableVTPM")]
        public bool? EnableVtpm { get; set; }
        /// <summary> Secure Boot is a feature of Trusted Launch which ensures that only signed operating systems and drivers can boot. For more details, see aka.ms/aks/trustedlaunch.  If not specified, the default is false. </summary>
        [WirePath("enableSecureBoot")]
        public bool? EnableSecureBoot { get; set; }
    }
}
