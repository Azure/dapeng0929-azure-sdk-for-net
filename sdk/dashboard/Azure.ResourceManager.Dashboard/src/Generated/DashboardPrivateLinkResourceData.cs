// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Dashboard.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Dashboard
{
    /// <summary>
    /// A class representing the DashboardPrivateLinkResource data model.
    /// A private link resource
    /// </summary>
    public partial class DashboardPrivateLinkResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of DashboardPrivateLinkResourceData. </summary>
        public DashboardPrivateLinkResourceData()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DashboardPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone name. </param>
        internal DashboardPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ProvisioningState? provisioningState, string groupId, IReadOnlyList<string> requiredMembers, IList<string> requiredZoneNames) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> Provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The private link resource Private link DNS zone name. </summary>
        public IList<string> RequiredZoneNames { get; }
    }
}
