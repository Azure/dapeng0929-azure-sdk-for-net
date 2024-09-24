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
    /// The specifications of the availability group replica configuration
    /// </summary>
    public partial class AvailabilityGroupConfigure
    {
        /// <summary>
        /// Initializes a new instance of the AvailabilityGroupConfigure class.
        /// </summary>
        public AvailabilityGroupConfigure()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailabilityGroupConfigure class.
        /// </summary>
        /// <param name="endpointUrl">Mirroring endpoint URL of availability
        /// group replica</param>
        /// <param name="availabilityModeDescription">The Availability
        /// Synchronization mode of the availability group replica.</param>
        /// <param name="failoverModeDescription">The failover mode of the
        /// availability group replica.</param>
        /// <param name="sessionTimeout">The time-out period of availability
        /// group session replica, in seconds.</param>
        /// <param name="primaryRoleAllowConnectionsDescription">Whether the
        /// availability allows all connections or only read-write
        /// connections.</param>
        /// <param name="secondaryRoleAllowConnectionsDescription">Whether an
        /// availability replica that is performing the secondary role (that
        /// is, a secondary replica) can accept connections from
        /// clients.</param>
        /// <param name="replicaCreateDate">Date that the replica was
        /// created.</param>
        /// <param name="replicaModifyDate">Date that the replica was
        /// modified.</param>
        /// <param name="backupPriority">Represents the user-specified priority
        /// for performing backups on this replica relative to the other
        /// replicas in the same availability group.</param>
        /// <param name="readOnlyRoutingUrl">Connectivity endpoint (URL) of the
        /// read only availability replica.</param>
        /// <param name="readWriteRoutingUrl">Connectivity endpoint (URL) of
        /// the read write availability replica.</param>
        /// <param name="seedingModeDescription">Describes seeding
        /// mode.</param>
        public AvailabilityGroupConfigure(string endpointUrl = default(string), string availabilityModeDescription = default(string), string failoverModeDescription = default(string), int? sessionTimeout = default(int?), string primaryRoleAllowConnectionsDescription = default(string), string secondaryRoleAllowConnectionsDescription = default(string), System.DateTime? replicaCreateDate = default(System.DateTime?), System.DateTime? replicaModifyDate = default(System.DateTime?), int? backupPriority = default(int?), string readOnlyRoutingUrl = default(string), string readWriteRoutingUrl = default(string), string seedingModeDescription = default(string))
        {
            EndpointUrl = endpointUrl;
            AvailabilityModeDescription = availabilityModeDescription;
            FailoverModeDescription = failoverModeDescription;
            SessionTimeout = sessionTimeout;
            PrimaryRoleAllowConnectionsDescription = primaryRoleAllowConnectionsDescription;
            SecondaryRoleAllowConnectionsDescription = secondaryRoleAllowConnectionsDescription;
            ReplicaCreateDate = replicaCreateDate;
            ReplicaModifyDate = replicaModifyDate;
            BackupPriority = backupPriority;
            ReadOnlyRoutingUrl = readOnlyRoutingUrl;
            ReadWriteRoutingUrl = readWriteRoutingUrl;
            SeedingModeDescription = seedingModeDescription;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets mirroring endpoint URL of availability group replica
        /// </summary>
        [JsonProperty(PropertyName = "endpointUrl")]
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Gets the Availability Synchronization mode of the availability
        /// group replica.
        /// </summary>
        [JsonProperty(PropertyName = "availabilityModeDescription")]
        public string AvailabilityModeDescription { get; private set; }

        /// <summary>
        /// Gets the failover mode of the availability group replica.
        /// </summary>
        [JsonProperty(PropertyName = "failoverModeDescription")]
        public string FailoverModeDescription { get; private set; }

        /// <summary>
        /// Gets or sets the time-out period of availability group session
        /// replica, in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "sessionTimeout")]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// Gets whether the availability allows all connections or only
        /// read-write connections.
        /// </summary>
        [JsonProperty(PropertyName = "primaryRoleAllowConnectionsDescription")]
        public string PrimaryRoleAllowConnectionsDescription { get; private set; }

        /// <summary>
        /// Gets whether an availability replica that is performing the
        /// secondary role (that is, a secondary replica) can accept
        /// connections from clients.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryRoleAllowConnectionsDescription")]
        public string SecondaryRoleAllowConnectionsDescription { get; private set; }

        /// <summary>
        /// Gets date that the replica was created.
        /// </summary>
        [JsonProperty(PropertyName = "replicaCreateDate")]
        public System.DateTime? ReplicaCreateDate { get; private set; }

        /// <summary>
        /// Gets date that the replica was modified.
        /// </summary>
        [JsonProperty(PropertyName = "replicaModifyDate")]
        public System.DateTime? ReplicaModifyDate { get; private set; }

        /// <summary>
        /// Gets or sets represents the user-specified priority for performing
        /// backups on this replica relative to the other replicas in the same
        /// availability group.
        /// </summary>
        [JsonProperty(PropertyName = "backupPriority")]
        public int? BackupPriority { get; set; }

        /// <summary>
        /// Gets or sets connectivity endpoint (URL) of the read only
        /// availability replica.
        /// </summary>
        [JsonProperty(PropertyName = "readOnlyRoutingUrl")]
        public string ReadOnlyRoutingUrl { get; set; }

        /// <summary>
        /// Gets or sets connectivity endpoint (URL) of the read write
        /// availability replica.
        /// </summary>
        [JsonProperty(PropertyName = "readWriteRoutingUrl")]
        public string ReadWriteRoutingUrl { get; set; }

        /// <summary>
        /// Gets describes seeding mode.
        /// </summary>
        [JsonProperty(PropertyName = "seedingModeDescription")]
        public string SeedingModeDescription { get; private set; }

    }
}
