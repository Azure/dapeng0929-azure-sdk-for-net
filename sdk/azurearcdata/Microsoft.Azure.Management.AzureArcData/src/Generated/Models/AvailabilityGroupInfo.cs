// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureArcData.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The specifications of the availability group state
    /// </summary>
    public partial class AvailabilityGroupInfo
    {
        /// <summary>
        /// Initializes a new instance of the AvailabilityGroupInfo class.
        /// </summary>
        public AvailabilityGroupInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailabilityGroupInfo class.
        /// </summary>
        /// <param name="failureConditionLevel">User-defined failure condition
        /// level under which an automatic failover must be triggered.</param>
        /// <param name="healthCheckTimeout">Wait time (in milliseconds) for
        /// the sp_server_diagnostics system stored procedure to return
        /// server-health information, before the server instance is assumed to
        /// be slow or not responding.</param>
        /// <param name="automatedBackupPreferenceDescription">Preferred
        /// location for performing backups on the availability databases in
        /// this availability group.</param>
        /// <param name="version">SQL Server availability group current
        /// version.</param>
        /// <param name="basicFeatures">Specifies whether this is a basic
        /// availability group.</param>
        /// <param name="dtcSupport">Specifies whether DTC support has been
        /// enabled for this availability group.</param>
        /// <param name="dbFailover">Specifies whether the availability group
        /// supports failover for database health conditions.</param>
        /// <param name="isDistributed">Specifies whether this is a distributed
        /// availability group.</param>
        /// <param name="clusterTypeDescription">SQL Server availability group
        /// cluster type description</param>
        /// <param name="requiredSynchronizedSecondariesToCommit">The number of
        /// secondary replicas that must be in a synchronized state for a
        /// commit to complete.</param>
        /// <param name="isContained">SQL Server availability group contained
        /// system databases.</param>
        /// <param name="primaryReplica">Name of the server instance that is
        /// hosting the current primary replica.</param>
        /// <param name="primaryRecoveryHealthDescription">Indicates the
        /// recovery health of the primary replica.</param>
        /// <param name="secondaryRecoveryHealthDescription">Indicates the
        /// recovery health of a secondary replica.</param>
        /// <param name="synchronizationHealthDescription">Reflects a roll-up
        /// of the synchronization health of all availability replicas in the
        /// availability group.</param>
        /// <param name="replicationPartnerType">Possible values include:
        /// 'SQLServer', 'AzureSQLVM', 'AzureSQLManagedInstance',
        /// 'Unknown'</param>
        public AvailabilityGroupInfo(int? failureConditionLevel = default(int?), int? healthCheckTimeout = default(int?), string automatedBackupPreferenceDescription = default(string), int? version = default(int?), bool? basicFeatures = default(bool?), bool? dtcSupport = default(bool?), bool? dbFailover = default(bool?), bool? isDistributed = default(bool?), string clusterTypeDescription = default(string), int? requiredSynchronizedSecondariesToCommit = default(int?), bool? isContained = default(bool?), string primaryReplica = default(string), string primaryRecoveryHealthDescription = default(string), string secondaryRecoveryHealthDescription = default(string), string synchronizationHealthDescription = default(string), ReplicationPartnerType? replicationPartnerType = default(ReplicationPartnerType?))
        {
            FailureConditionLevel = failureConditionLevel;
            HealthCheckTimeout = healthCheckTimeout;
            AutomatedBackupPreferenceDescription = automatedBackupPreferenceDescription;
            Version = version;
            BasicFeatures = basicFeatures;
            DtcSupport = dtcSupport;
            DbFailover = dbFailover;
            IsDistributed = isDistributed;
            ClusterTypeDescription = clusterTypeDescription;
            RequiredSynchronizedSecondariesToCommit = requiredSynchronizedSecondariesToCommit;
            IsContained = isContained;
            PrimaryReplica = primaryReplica;
            PrimaryRecoveryHealthDescription = primaryRecoveryHealthDescription;
            SecondaryRecoveryHealthDescription = secondaryRecoveryHealthDescription;
            SynchronizationHealthDescription = synchronizationHealthDescription;
            ReplicationPartnerType = replicationPartnerType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets user-defined failure condition level under which an
        /// automatic failover must be triggered.
        /// </summary>
        [JsonProperty(PropertyName = "failureConditionLevel")]
        public int? FailureConditionLevel { get; set; }

        /// <summary>
        /// Gets or sets wait time (in milliseconds) for the
        /// sp_server_diagnostics system stored procedure to return
        /// server-health information, before the server instance is assumed to
        /// be slow or not responding.
        /// </summary>
        [JsonProperty(PropertyName = "healthCheckTimeout")]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// Gets preferred location for performing backups on the availability
        /// databases in this availability group.
        /// </summary>
        [JsonProperty(PropertyName = "automatedBackupPreferenceDescription")]
        public string AutomatedBackupPreferenceDescription { get; private set; }

        /// <summary>
        /// Gets SQL Server availability group current version.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; private set; }

        /// <summary>
        /// Gets or sets specifies whether this is a basic availability group.
        /// </summary>
        [JsonProperty(PropertyName = "basicFeatures")]
        public bool? BasicFeatures { get; set; }

        /// <summary>
        /// Gets or sets specifies whether DTC support has been enabled for
        /// this availability group.
        /// </summary>
        [JsonProperty(PropertyName = "dtcSupport")]
        public bool? DtcSupport { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the availability group supports
        /// failover for database health conditions.
        /// </summary>
        [JsonProperty(PropertyName = "dbFailover")]
        public bool? DbFailover { get; set; }

        /// <summary>
        /// Gets or sets specifies whether this is a distributed availability
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "isDistributed")]
        public bool? IsDistributed { get; set; }

        /// <summary>
        /// Gets SQL Server availability group cluster type description
        /// </summary>
        [JsonProperty(PropertyName = "clusterTypeDescription")]
        public string ClusterTypeDescription { get; private set; }

        /// <summary>
        /// Gets or sets the number of secondary replicas that must be in a
        /// synchronized state for a commit to complete.
        /// </summary>
        [JsonProperty(PropertyName = "requiredSynchronizedSecondariesToCommit")]
        public int? RequiredSynchronizedSecondariesToCommit { get; set; }

        /// <summary>
        /// Gets or sets SQL Server availability group contained system
        /// databases.
        /// </summary>
        [JsonProperty(PropertyName = "isContained")]
        public bool? IsContained { get; set; }

        /// <summary>
        /// Gets name of the server instance that is hosting the current
        /// primary replica.
        /// </summary>
        [JsonProperty(PropertyName = "primaryReplica")]
        public string PrimaryReplica { get; private set; }

        /// <summary>
        /// Gets indicates the recovery health of the primary replica.
        /// </summary>
        [JsonProperty(PropertyName = "primaryRecoveryHealthDescription")]
        public string PrimaryRecoveryHealthDescription { get; private set; }

        /// <summary>
        /// Gets indicates the recovery health of a secondary replica.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryRecoveryHealthDescription")]
        public string SecondaryRecoveryHealthDescription { get; private set; }

        /// <summary>
        /// Gets reflects a roll-up of the synchronization health of all
        /// availability replicas in the availability group.
        /// </summary>
        [JsonProperty(PropertyName = "synchronizationHealthDescription")]
        public string SynchronizationHealthDescription { get; private set; }

        /// <summary>
        /// Gets possible values include: 'SQLServer', 'AzureSQLVM',
        /// 'AzureSQLManagedInstance', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "replicationPartnerType")]
        public ReplicationPartnerType? ReplicationPartnerType { get; private set; }

    }
}
