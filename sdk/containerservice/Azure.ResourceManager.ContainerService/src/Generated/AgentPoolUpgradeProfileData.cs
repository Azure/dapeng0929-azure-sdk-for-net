// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing the AgentPoolUpgradeProfile data model.
    /// The list of available upgrades for an agent pool.
    /// </summary>
    public partial class AgentPoolUpgradeProfileData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AgentPoolUpgradeProfileData"/>. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version (major.minor.patch). </param>
        /// <param name="osType"> The operating system type. The default is Linux. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kubernetesVersion"/> is null. </exception>
        internal AgentPoolUpgradeProfileData(string kubernetesVersion, ContainerServiceOSType osType)
        {
            Argument.AssertNotNull(kubernetesVersion, nameof(kubernetesVersion));

            KubernetesVersion = kubernetesVersion;
            OSType = osType;
            Upgrades = new ChangeTrackingList<AgentPoolUpgradeProfilePropertiesUpgradesItem>();
            ComponentsByReleases = new ChangeTrackingList<ComponentsByRelease>();
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolUpgradeProfileData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kubernetesVersion"> The Kubernetes version (major.minor.patch). </param>
        /// <param name="osType"> The operating system type. The default is Linux. </param>
        /// <param name="upgrades"> List of orchestrator types and versions available for upgrade. </param>
        /// <param name="componentsByReleases"> List of components grouped by kubernetes major.minor version. </param>
        /// <param name="latestNodeImageVersion"> The latest AKS supported node image version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentPoolUpgradeProfileData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kubernetesVersion, ContainerServiceOSType osType, IReadOnlyList<AgentPoolUpgradeProfilePropertiesUpgradesItem> upgrades, IReadOnlyList<ComponentsByRelease> componentsByReleases, string latestNodeImageVersion, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            KubernetesVersion = kubernetesVersion;
            OSType = osType;
            Upgrades = upgrades;
            ComponentsByReleases = componentsByReleases;
            LatestNodeImageVersion = latestNodeImageVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolUpgradeProfileData"/> for deserialization. </summary>
        internal AgentPoolUpgradeProfileData()
        {
        }

        /// <summary> The Kubernetes version (major.minor.patch). </summary>
        public string KubernetesVersion { get; }
        /// <summary> The operating system type. The default is Linux. </summary>
        public ContainerServiceOSType OSType { get; }
        /// <summary> List of orchestrator types and versions available for upgrade. </summary>
        public IReadOnlyList<AgentPoolUpgradeProfilePropertiesUpgradesItem> Upgrades { get; }
        /// <summary> List of components grouped by kubernetes major.minor version. </summary>
        public IReadOnlyList<ComponentsByRelease> ComponentsByReleases { get; }
        /// <summary> The latest AKS supported node image version. </summary>
        public string LatestNodeImageVersion { get; }
    }
}
