// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The object representing continuous mode backup policy. </summary>
    public partial class ContinuousModeBackupPolicy : CosmosDBAccountBackupPolicy
    {
        /// <summary> Initializes a new instance of <see cref="ContinuousModeBackupPolicy"/>. </summary>
        public ContinuousModeBackupPolicy()
        {
            BackupPolicyType = BackupPolicyType.Continuous;
        }

        /// <summary> Initializes a new instance of <see cref="ContinuousModeBackupPolicy"/>. </summary>
        /// <param name="backupPolicyType"> Describes the mode of backups. </param>
        /// <param name="migrationState"> The object representing the state of the migration between the backup policies. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="continuousModeProperties"> Configuration values for continuous mode backup. </param>
        internal ContinuousModeBackupPolicy(BackupPolicyType backupPolicyType, BackupPolicyMigrationState migrationState, IDictionary<string, BinaryData> serializedAdditionalRawData, ContinuousModeProperties continuousModeProperties) : base(backupPolicyType, migrationState, serializedAdditionalRawData)
        {
            ContinuousModeProperties = continuousModeProperties;
            BackupPolicyType = backupPolicyType;
        }

        /// <summary> Configuration values for continuous mode backup. </summary>
        internal ContinuousModeProperties ContinuousModeProperties { get; set; }
        /// <summary> Enum to indicate type of Continuous backup mode. </summary>
        [WirePath("continuousModeProperties.tier")]
        public ContinuousTier? ContinuousModeTier
        {
            get => ContinuousModeProperties is null ? default : ContinuousModeProperties.Tier;
            set
            {
                if (ContinuousModeProperties is null)
                    ContinuousModeProperties = new ContinuousModeProperties();
                ContinuousModeProperties.Tier = value;
            }
        }
    }
}
