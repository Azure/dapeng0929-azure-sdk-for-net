// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt specific update migration item input. </summary>
    public partial class VMwareCbtUpdateMigrationItemContent : UpdateMigrationItemProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="VMwareCbtUpdateMigrationItemContent"/>. </summary>
        public VMwareCbtUpdateMigrationItemContent()
        {
            VmNics = new ChangeTrackingList<VMwareCbtNicContent>();
            VmDisks = new ChangeTrackingList<VMwareCbtUpdateDiskContent>();
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            TargetDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            InstanceType = "VMwareCbt";
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtUpdateMigrationItemContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="targetVmName"> The target VM name. </param>
        /// <param name="targetVmSize"> The target VM size. </param>
        /// <param name="targetResourceGroupId"> The target resource group ARM Id. </param>
        /// <param name="targetAvailabilitySetId"> The target availability set ARM Id. </param>
        /// <param name="targetAvailabilityZone"> The target availability zone. </param>
        /// <param name="targetProximityPlacementGroupId"> The target proximity placement group ARM Id. </param>
        /// <param name="targetBootDiagnosticsStorageAccountId"> The target boot diagnostics storage account ARM Id. </param>
        /// <param name="targetNetworkId"> The target network ARM Id. </param>
        /// <param name="testNetworkId"> The test network ARM Id. </param>
        /// <param name="vmNics"> The list of NIC details. </param>
        /// <param name="vmDisks"> The list of disk update properties. </param>
        /// <param name="licenseType"> The license type. </param>
        /// <param name="sqlServerLicenseType"> The SQL Server license type. </param>
        /// <param name="linuxLicenseType"> The license type for Linux VM's. </param>
        /// <param name="userSelectedOSName"> The OS name selected by user. </param>
        /// <param name="performAutoResync"> A value indicating whether auto resync is to be done. </param>
        /// <param name="targetVmTags"> The target VM tags. </param>
        /// <param name="targetDiskTags"> The tags for the target disks. </param>
        /// <param name="targetNicTags"> The tags for the target NICs. </param>
        internal VMwareCbtUpdateMigrationItemContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string targetVmName, string targetVmSize, ResourceIdentifier targetResourceGroupId, ResourceIdentifier targetAvailabilitySetId, string targetAvailabilityZone, ResourceIdentifier targetProximityPlacementGroupId, ResourceIdentifier targetBootDiagnosticsStorageAccountId, ResourceIdentifier targetNetworkId, ResourceIdentifier testNetworkId, IList<VMwareCbtNicContent> vmNics, IList<VMwareCbtUpdateDiskContent> vmDisks, SiteRecoveryLicenseType? licenseType, SiteRecoverySqlServerLicenseType? sqlServerLicenseType, LinuxLicenseType? linuxLicenseType, string userSelectedOSName, string performAutoResync, IDictionary<string, string> targetVmTags, IDictionary<string, string> targetDiskTags, IDictionary<string, string> targetNicTags) : base(instanceType, serializedAdditionalRawData)
        {
            TargetVmName = targetVmName;
            TargetVmSize = targetVmSize;
            TargetResourceGroupId = targetResourceGroupId;
            TargetAvailabilitySetId = targetAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            TargetBootDiagnosticsStorageAccountId = targetBootDiagnosticsStorageAccountId;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            VmNics = vmNics;
            VmDisks = vmDisks;
            LicenseType = licenseType;
            SqlServerLicenseType = sqlServerLicenseType;
            LinuxLicenseType = linuxLicenseType;
            UserSelectedOSName = userSelectedOSName;
            PerformAutoResync = performAutoResync;
            TargetVmTags = targetVmTags;
            TargetDiskTags = targetDiskTags;
            TargetNicTags = targetNicTags;
            InstanceType = instanceType ?? "VMwareCbt";
        }

        /// <summary> The target VM name. </summary>
        public string TargetVmName { get; set; }
        /// <summary> The target VM size. </summary>
        public string TargetVmSize { get; set; }
        /// <summary> The target resource group ARM Id. </summary>
        public ResourceIdentifier TargetResourceGroupId { get; set; }
        /// <summary> The target availability set ARM Id. </summary>
        public ResourceIdentifier TargetAvailabilitySetId { get; set; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; set; }
        /// <summary> The target proximity placement group ARM Id. </summary>
        public ResourceIdentifier TargetProximityPlacementGroupId { get; set; }
        /// <summary> The target boot diagnostics storage account ARM Id. </summary>
        public ResourceIdentifier TargetBootDiagnosticsStorageAccountId { get; set; }
        /// <summary> The target network ARM Id. </summary>
        public ResourceIdentifier TargetNetworkId { get; set; }
        /// <summary> The test network ARM Id. </summary>
        public ResourceIdentifier TestNetworkId { get; set; }
        /// <summary> The list of NIC details. </summary>
        public IList<VMwareCbtNicContent> VmNics { get; }
        /// <summary> The list of disk update properties. </summary>
        public IList<VMwareCbtUpdateDiskContent> VmDisks { get; }
        /// <summary> The license type. </summary>
        public SiteRecoveryLicenseType? LicenseType { get; set; }
        /// <summary> The SQL Server license type. </summary>
        public SiteRecoverySqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary> The license type for Linux VM's. </summary>
        public LinuxLicenseType? LinuxLicenseType { get; set; }
        /// <summary> The OS name selected by user. </summary>
        public string UserSelectedOSName { get; set; }
        /// <summary> A value indicating whether auto resync is to be done. </summary>
        public string PerformAutoResync { get; set; }
        /// <summary> The target VM tags. </summary>
        public IDictionary<string, string> TargetVmTags { get; }
        /// <summary> The tags for the target disks. </summary>
        public IDictionary<string, string> TargetDiskTags { get; }
        /// <summary> The tags for the target NICs. </summary>
        public IDictionary<string, string> TargetNicTags { get; }
    }
}
