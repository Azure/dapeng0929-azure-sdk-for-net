// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> HostPool properties that can be patched. </summary>
    public partial class HostPoolPatch : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="HostPoolPatch"/>. </summary>
        public HostPoolPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="HostPoolPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> tags to be updated. </param>
        /// <param name="friendlyName"> Friendly name of HostPool. </param>
        /// <param name="description"> Description of HostPool. </param>
        /// <param name="customRdpProperty"> Custom rdp property of HostPool. </param>
        /// <param name="maxSessionLimit"> The max session limit of HostPool. </param>
        /// <param name="personalDesktopAssignmentType"> PersonalDesktopAssignment type for HostPool. </param>
        /// <param name="loadBalancerType"> The type of the load balancer. </param>
        /// <param name="ring"> The ring number of HostPool. </param>
        /// <param name="isValidationEnvironment"> Is validation environment. </param>
        /// <param name="registrationInfo"> The registration info of HostPool.  This is not returned on GET. In order to get the registration token use the retrieveRegistrationToken or listRegistrationTokens POST calls. </param>
        /// <param name="vmTemplate"> VM template for sessionhosts configuration within hostpool. </param>
        /// <param name="ssoAdfsAuthority"> URL to customer ADFS server for signing WVD SSO certificates. </param>
        /// <param name="ssoClientId"> ClientId for the registered Relying Party used to issue WVD SSO certificates. </param>
        /// <param name="ssoClientSecretKeyVaultPath"> Path to Azure KeyVault storing the secret used for communication to ADFS. </param>
        /// <param name="ssoSecretType"> The type of single sign on Secret Type. </param>
        /// <param name="preferredAppGroupType"> The type of preferred application group type, default to Desktop Application Group. </param>
        /// <param name="startVmOnConnect"> The flag to turn on/off StartVMOnConnect feature. </param>
        /// <param name="publicNetworkAccess"> Enabled to allow this resource to be access from the public network. </param>
        /// <param name="agentUpdate"> The session host configuration for updating agent, monitoring agent, and stack component. </param>
        /// <param name="managedPrivateUDP"> Default: AVD-wide settings are used to determine connection availability, Enabled: UDP will attempt this connection type when making connections. This means that this connection is possible, but is not guaranteed, as there are other factors that may prevent this connection type, Disabled: UDP will not attempt this connection type when making connections. </param>
        /// <param name="directUDP"> Default: AVD-wide settings are used to determine connection availability, Enabled: UDP will attempt this connection type when making connections. This means that this connection is possible, but is not guaranteed, as there are other factors that may prevent this connection type, Disabled: UDP will not attempt this connection type when making connections. </param>
        /// <param name="publicUDP"> Default: AVD-wide settings are used to determine connection availability, Enabled: UDP will attempt this connection type when making connections. This means that this connection is possible, but is not guaranteed, as there are other factors that may prevent this connection type, Disabled: UDP will not attempt this connection type when making connections. </param>
        /// <param name="relayUDP"> Default: AVD-wide settings are used to determine connection availability, Enabled: UDP will attempt this connection type when making connections. This means that this connection is possible, but is not guaranteed, as there are other factors that may prevent this connection type, Disabled: UDP will not attempt this connection type when making connections. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HostPoolPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, string friendlyName, string description, string customRdpProperty, int? maxSessionLimit, PersonalDesktopAssignmentType? personalDesktopAssignmentType, HostPoolLoadBalancerType? loadBalancerType, int? ring, bool? isValidationEnvironment, HostPoolRegistrationInfoPatch registrationInfo, string vmTemplate, string ssoAdfsAuthority, string ssoClientId, string ssoClientSecretKeyVaultPath, HostPoolSsoSecretType? ssoSecretType, PreferredAppGroupType? preferredAppGroupType, bool? startVmOnConnect, HostPoolPublicNetworkAccess? publicNetworkAccess, SessionHostAgentUpdatePatchProperties agentUpdate, ManagedPrivateUDP? managedPrivateUDP, DirectUDP? directUDP, PublicUDP? publicUDP, RelayUDP? relayUDP, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Tags = tags;
            FriendlyName = friendlyName;
            Description = description;
            CustomRdpProperty = customRdpProperty;
            MaxSessionLimit = maxSessionLimit;
            PersonalDesktopAssignmentType = personalDesktopAssignmentType;
            LoadBalancerType = loadBalancerType;
            Ring = ring;
            IsValidationEnvironment = isValidationEnvironment;
            RegistrationInfo = registrationInfo;
            VmTemplate = vmTemplate;
            SsoAdfsAuthority = ssoAdfsAuthority;
            SsoClientId = ssoClientId;
            SsoClientSecretKeyVaultPath = ssoClientSecretKeyVaultPath;
            SsoSecretType = ssoSecretType;
            PreferredAppGroupType = preferredAppGroupType;
            StartVmOnConnect = startVmOnConnect;
            PublicNetworkAccess = publicNetworkAccess;
            AgentUpdate = agentUpdate;
            ManagedPrivateUDP = managedPrivateUDP;
            DirectUDP = directUDP;
            PublicUDP = publicUDP;
            RelayUDP = relayUDP;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> tags to be updated. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; set; }
        /// <summary> Friendly name of HostPool. </summary>
        [WirePath("properties.friendlyName")]
        public string FriendlyName { get; set; }
        /// <summary> Description of HostPool. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> Custom rdp property of HostPool. </summary>
        [WirePath("properties.customRdpProperty")]
        public string CustomRdpProperty { get; set; }
        /// <summary> The max session limit of HostPool. </summary>
        [WirePath("properties.maxSessionLimit")]
        public int? MaxSessionLimit { get; set; }
        /// <summary> PersonalDesktopAssignment type for HostPool. </summary>
        [WirePath("properties.personalDesktopAssignmentType")]
        public PersonalDesktopAssignmentType? PersonalDesktopAssignmentType { get; set; }
        /// <summary> The type of the load balancer. </summary>
        [WirePath("properties.loadBalancerType")]
        public HostPoolLoadBalancerType? LoadBalancerType { get; set; }
        /// <summary> The ring number of HostPool. </summary>
        [WirePath("properties.ring")]
        public int? Ring { get; set; }
        /// <summary> Is validation environment. </summary>
        [WirePath("properties.validationEnvironment")]
        public bool? IsValidationEnvironment { get; set; }
        /// <summary> The registration info of HostPool.  This is not returned on GET. In order to get the registration token use the retrieveRegistrationToken or listRegistrationTokens POST calls. </summary>
        [WirePath("properties.registrationInfo")]
        public HostPoolRegistrationInfoPatch RegistrationInfo { get; set; }
        /// <summary> VM template for sessionhosts configuration within hostpool. </summary>
        [WirePath("properties.vmTemplate")]
        public string VmTemplate { get; set; }
        /// <summary> URL to customer ADFS server for signing WVD SSO certificates. </summary>
        [WirePath("properties.ssoadfsAuthority")]
        public string SsoAdfsAuthority { get; set; }
        /// <summary> ClientId for the registered Relying Party used to issue WVD SSO certificates. </summary>
        [WirePath("properties.ssoClientId")]
        public string SsoClientId { get; set; }
        /// <summary> Path to Azure KeyVault storing the secret used for communication to ADFS. </summary>
        [WirePath("properties.ssoClientSecretKeyVaultPath")]
        public string SsoClientSecretKeyVaultPath { get; set; }
        /// <summary> The type of single sign on Secret Type. </summary>
        [WirePath("properties.ssoSecretType")]
        public HostPoolSsoSecretType? SsoSecretType { get; set; }
        /// <summary> The type of preferred application group type, default to Desktop Application Group. </summary>
        [WirePath("properties.preferredAppGroupType")]
        public PreferredAppGroupType? PreferredAppGroupType { get; set; }
        /// <summary> The flag to turn on/off StartVMOnConnect feature. </summary>
        [WirePath("properties.startVMOnConnect")]
        public bool? StartVmOnConnect { get; set; }
        /// <summary> Enabled to allow this resource to be access from the public network. </summary>
        [WirePath("properties.publicNetworkAccess")]
        public HostPoolPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The session host configuration for updating agent, monitoring agent, and stack component. </summary>
        [WirePath("properties.agentUpdate")]
        public SessionHostAgentUpdatePatchProperties AgentUpdate { get; set; }
        /// <summary> Default: AVD-wide settings are used to determine connection availability, Enabled: UDP will attempt this connection type when making connections. This means that this connection is possible, but is not guaranteed, as there are other factors that may prevent this connection type, Disabled: UDP will not attempt this connection type when making connections. </summary>
        [WirePath("properties.managedPrivateUDP")]
        public ManagedPrivateUDP? ManagedPrivateUDP { get; set; }
        /// <summary> Default: AVD-wide settings are used to determine connection availability, Enabled: UDP will attempt this connection type when making connections. This means that this connection is possible, but is not guaranteed, as there are other factors that may prevent this connection type, Disabled: UDP will not attempt this connection type when making connections. </summary>
        [WirePath("properties.directUDP")]
        public DirectUDP? DirectUDP { get; set; }
        /// <summary> Default: AVD-wide settings are used to determine connection availability, Enabled: UDP will attempt this connection type when making connections. This means that this connection is possible, but is not guaranteed, as there are other factors that may prevent this connection type, Disabled: UDP will not attempt this connection type when making connections. </summary>
        [WirePath("properties.publicUDP")]
        public PublicUDP? PublicUDP { get; set; }
        /// <summary> Default: AVD-wide settings are used to determine connection availability, Enabled: UDP will attempt this connection type when making connections. This means that this connection is possible, but is not guaranteed, as there are other factors that may prevent this connection type, Disabled: UDP will not attempt this connection type when making connections. </summary>
        [WirePath("properties.relayUDP")]
        public RelayUDP? RelayUDP { get; set; }
    }
}
