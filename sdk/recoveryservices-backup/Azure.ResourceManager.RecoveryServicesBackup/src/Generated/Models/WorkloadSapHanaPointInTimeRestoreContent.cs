// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// AzureWorkload SAP Hana -specific restore. Specifically for PointInTime/Log restore
    /// Please note <see cref="WorkloadSapHanaPointInTimeRestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WorkloadSapHanaPointInTimeRestoreWithRehydrateContent"/>.
    /// </summary>
    public partial class WorkloadSapHanaPointInTimeRestoreContent : WorkloadSapHanaRestoreContent
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadSapHanaPointInTimeRestoreContent"/>. </summary>
        public WorkloadSapHanaPointInTimeRestoreContent()
        {
            ObjectType = "AzureWorkloadSAPHanaPointInTimeRestoreRequest";
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadSapHanaPointInTimeRestoreContent"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="resourceGuardOperationRequests"> ResourceGuardOperationRequests on which LAC check will be performed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryType"> Type of this recovery. </param>
        /// <param name="sourceResourceId"> Fully qualified ARM ID of the VM on which workload that was running is being recovered. </param>
        /// <param name="propertyBag"> Workload specific property bag. </param>
        /// <param name="targetInfo"> Details of target database. </param>
        /// <param name="recoveryMode"> Defines whether the current recovery mode is file restore or database restore. </param>
        /// <param name="targetResourceGroupName"> Defines the Resource group of the Target VM. </param>
        /// <param name="userAssignedManagedIdentityDetails">
        /// User Assigned managed identity details
        /// Currently used for snapshot.
        /// </param>
        /// <param name="snapshotRestoreParameters">
        /// Additional details for snapshot recovery
        /// Currently used for snapshot for SAP Hana.
        /// </param>
        /// <param name="targetVirtualMachineId">
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </param>
        /// <param name="pointInTime"> PointInTime value. </param>
        internal WorkloadSapHanaPointInTimeRestoreContent(string objectType, IList<string> resourceGuardOperationRequests, IDictionary<string, BinaryData> serializedAdditionalRawData, FileShareRecoveryType? recoveryType, ResourceIdentifier sourceResourceId, IDictionary<string, string> propertyBag, TargetRestoreInfo targetInfo, RecoveryMode? recoveryMode, string targetResourceGroupName, UserAssignedManagedIdentityDetails userAssignedManagedIdentityDetails, SnapshotRestoreContent snapshotRestoreParameters, ResourceIdentifier targetVirtualMachineId, DateTimeOffset? pointInTime) : base(objectType, resourceGuardOperationRequests, serializedAdditionalRawData, recoveryType, sourceResourceId, propertyBag, targetInfo, recoveryMode, targetResourceGroupName, userAssignedManagedIdentityDetails, snapshotRestoreParameters, targetVirtualMachineId)
        {
            PointInTime = pointInTime;
            ObjectType = objectType ?? "AzureWorkloadSAPHanaPointInTimeRestoreRequest";
        }

        /// <summary> PointInTime value. </summary>
        public DateTimeOffset? PointInTime { get; set; }
    }
}
