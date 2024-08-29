// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the SecurityAdminConfiguration data model.
    /// Defines the security admin configuration
    /// </summary>
    public partial class SecurityAdminConfigurationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="SecurityAdminConfigurationData"/>. </summary>
        public SecurityAdminConfigurationData()
        {
            ApplyOnNetworkIntentPolicyBasedServices = new ChangeTrackingList<NetworkIntentPolicyBasedService>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityAdminConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> A description of the security configuration. </param>
        /// <param name="applyOnNetworkIntentPolicyBasedServices"> Enum list of network intent policy based services. </param>
        /// <param name="networkGroupAddressSpaceAggregationOption"> Determine update behavior for changes to network groups referenced within the rules in this configuration. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="resourceGuid"> Unique identifier for this resource. </param>
        /// <param name="commonResourceType"> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityAdminConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, IList<NetworkIntentPolicyBasedService> applyOnNetworkIntentPolicyBasedServices, AddressSpaceAggregationOption? networkGroupAddressSpaceAggregationOption, NetworkProvisioningState? provisioningState, Guid? resourceGuid, string commonResourceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            ApplyOnNetworkIntentPolicyBasedServices = applyOnNetworkIntentPolicyBasedServices;
            NetworkGroupAddressSpaceAggregationOption = networkGroupAddressSpaceAggregationOption;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            CommonResourceType = commonResourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A description of the security configuration. </summary>
        public string Description { get; set; }
        /// <summary> Enum list of network intent policy based services. </summary>
        public IList<NetworkIntentPolicyBasedService> ApplyOnNetworkIntentPolicyBasedServices { get; }
        /// <summary> Determine update behavior for changes to network groups referenced within the rules in this configuration. </summary>
        public AddressSpaceAggregationOption? NetworkGroupAddressSpaceAggregationOption { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Unique identifier for this resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts". </summary>
        public string CommonResourceType { get; }
    }
}
