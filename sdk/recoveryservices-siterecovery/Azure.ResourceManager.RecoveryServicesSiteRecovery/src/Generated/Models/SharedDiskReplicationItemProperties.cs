// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Shared Disk Replication item custom data details. </summary>
    public partial class SharedDiskReplicationItemProperties
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

        /// <summary> Initializes a new instance of <see cref="SharedDiskReplicationItemProperties"/>. </summary>
        public SharedDiskReplicationItemProperties()
        {
            AllowedOperations = new ChangeTrackingList<string>();
            HealthErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of <see cref="SharedDiskReplicationItemProperties"/>. </summary>
        /// <param name="protectionState"> The protection state of shared disk. </param>
        /// <param name="testFailoverState"> The tfo state of shared disk. </param>
        /// <param name="activeLocation"> The Current active location of the PE. </param>
        /// <param name="allowedOperations"> The allowed operations on the Replication protected item. </param>
        /// <param name="replicationHealth"> The consolidated protection health for the VM taking any issues with SRS as well as all the replication units associated with the VM's replication group into account. This is a string representation of the ProtectionHealth enumeration. </param>
        /// <param name="healthErrors"> List of health errors. </param>
        /// <param name="currentScenario"> The current scenario. </param>
        /// <param name="sharedDiskProviderSpecificDetails">
        /// The Replication provider custom settings.
        /// Please note <see cref="SharedDiskReplicationProviderSpecificSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ASharedDiskReplicationDetails"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedDiskReplicationItemProperties(string protectionState, string testFailoverState, string activeLocation, IList<string> allowedOperations, string replicationHealth, IList<SiteRecoveryHealthError> healthErrors, CurrentScenarioDetails currentScenario, SharedDiskReplicationProviderSpecificSettings sharedDiskProviderSpecificDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProtectionState = protectionState;
            TestFailoverState = testFailoverState;
            ActiveLocation = activeLocation;
            AllowedOperations = allowedOperations;
            ReplicationHealth = replicationHealth;
            HealthErrors = healthErrors;
            CurrentScenario = currentScenario;
            SharedDiskProviderSpecificDetails = sharedDiskProviderSpecificDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The protection state of shared disk. </summary>
        public string ProtectionState { get; set; }
        /// <summary> The tfo state of shared disk. </summary>
        public string TestFailoverState { get; set; }
        /// <summary> The Current active location of the PE. </summary>
        public string ActiveLocation { get; set; }
        /// <summary> The allowed operations on the Replication protected item. </summary>
        public IList<string> AllowedOperations { get; }
        /// <summary> The consolidated protection health for the VM taking any issues with SRS as well as all the replication units associated with the VM's replication group into account. This is a string representation of the ProtectionHealth enumeration. </summary>
        public string ReplicationHealth { get; set; }
        /// <summary> List of health errors. </summary>
        public IList<SiteRecoveryHealthError> HealthErrors { get; }
        /// <summary> The current scenario. </summary>
        public CurrentScenarioDetails CurrentScenario { get; set; }
        /// <summary>
        /// The Replication provider custom settings.
        /// Please note <see cref="SharedDiskReplicationProviderSpecificSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ASharedDiskReplicationDetails"/>.
        /// </summary>
        public SharedDiskReplicationProviderSpecificSettings SharedDiskProviderSpecificDetails { get; set; }
    }
}
