// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> ASE region. </summary>
    public partial class AseRegion : ResourceData
    {
        /// <summary> Initializes a new instance of AseRegion. </summary>
        public AseRegion()
        {
            AvailableSku = new ChangeTrackingList<string>();
            AvailableOS = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AseRegion. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> Display name for region. </param>
        /// <param name="standard"> Is region standard. </param>
        /// <param name="dedicatedHost"> Dedicated host enabled. </param>
        /// <param name="zoneRedundant"> Zone redundant deployment enabled. </param>
        /// <param name="availableSku"> Available Skus in region. </param>
        /// <param name="availableOS"> Available OSs in region. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AseRegion(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, bool? standard, bool? dedicatedHost, bool? zoneRedundant, IList<string> availableSku, IList<string> availableOS, string kind) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Standard = standard;
            DedicatedHost = dedicatedHost;
            ZoneRedundant = zoneRedundant;
            AvailableSku = availableSku;
            AvailableOS = availableOS;
            Kind = kind;
        }

        /// <summary> Display name for region. </summary>
        public string DisplayName { get; }
        /// <summary> Is region standard. </summary>
        public bool? Standard { get; }
        /// <summary> Dedicated host enabled. </summary>
        public bool? DedicatedHost { get; }
        /// <summary> Zone redundant deployment enabled. </summary>
        public bool? ZoneRedundant { get; }
        /// <summary> Available Skus in region. </summary>
        public IList<string> AvailableSku { get; }
        /// <summary> Available OSs in region. </summary>
        public IList<string> AvailableOS { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
