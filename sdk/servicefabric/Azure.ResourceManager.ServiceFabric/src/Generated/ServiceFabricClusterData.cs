// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    /// <summary>
    /// A class representing the ServiceFabricCluster data model.
    /// The cluster resource
    ///
    /// </summary>
    public partial class ServiceFabricClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ServiceFabricClusterData. </summary>
        /// <param name="location"> The location. </param>
        public ServiceFabricClusterData(AzureLocation location) : base(location)
        {
            AddOnFeatures = new ChangeTrackingList<ClusterAddOnFeature>();
            AvailableClusterVersions = new ChangeTrackingList<ClusterVersionDetails>();
            ClientCertificateCommonNames = new ChangeTrackingList<ClusterClientCertificateCommonName>();
            ClientCertificateThumbprints = new ChangeTrackingList<ClusterClientCertificateThumbprint>();
            FabricSettings = new ChangeTrackingList<SettingsSectionDescription>();
            NodeTypes = new ChangeTrackingList<ClusterNodeTypeDescription>();
            Notifications = new ChangeTrackingList<ClusterNotification>();
        }

        /// <summary> Initializes a new instance of ServiceFabricClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="addOnFeatures"> The list of add-on features to enable in the cluster. </param>
        /// <param name="availableClusterVersions"> The Service Fabric runtime versions available for this cluster. </param>
        /// <param name="azureActiveDirectory"> The AAD authentication settings of the cluster. </param>
        /// <param name="certificate"> The certificate to use for securing the cluster. The certificate provided will be used for node to node security within the cluster, SSL certificate for cluster management endpoint and default admin client. </param>
        /// <param name="certificateCommonNames"> Describes a list of server certificates referenced by common name that are used to secure the cluster. </param>
        /// <param name="clientCertificateCommonNames"> The list of client certificates referenced by common name that are allowed to manage the cluster. </param>
        /// <param name="clientCertificateThumbprints"> The list of client certificates referenced by thumbprint that are allowed to manage the cluster. </param>
        /// <param name="clusterCodeVersion"> The Service Fabric runtime version of the cluster. This property can only by set the user when **upgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](https://learn.microsoft.com/rest/api/servicefabric/cluster-versions/list). To get the list of available version for existing clusters use **availableClusterVersions**. </param>
        /// <param name="clusterEndpoint"> The Azure Resource Provider endpoint. A system service in the cluster connects to this  endpoint. </param>
        /// <param name="clusterId"> A service generated unique identifier for the cluster resource. </param>
        /// <param name="clusterState">
        /// The current state of the cluster.
        ///
        ///   - WaitingForNodes - Indicates that the cluster resource is created and the resource provider is waiting for Service Fabric VM extension to boot up and report to it.
        ///   - Deploying - Indicates that the Service Fabric runtime is being installed on the VMs. Cluster resource will be in this state until the cluster boots up and system services are up.
        ///   - BaselineUpgrade - Indicates that the cluster is upgrading to establishes the cluster version. This upgrade is automatically initiated when the cluster boots up for the first time.
        ///   - UpdatingUserConfiguration - Indicates that the cluster is being upgraded with the user provided configuration.
        ///   - UpdatingUserCertificate - Indicates that the cluster is being upgraded with the user provided certificate.
        ///   - UpdatingInfrastructure - Indicates that the cluster is being upgraded with the latest Service Fabric runtime version. This happens only when the **upgradeMode** is set to 'Automatic'.
        ///   - EnforcingClusterVersion - Indicates that cluster is on a different version than expected and the cluster is being upgraded to the expected version.
        ///   - UpgradeServiceUnreachable - Indicates that the system service in the cluster is no longer polling the Resource Provider. Clusters in this state cannot be managed by the Resource Provider.
        ///   - AutoScale - Indicates that the ReliabilityLevel of the cluster is being adjusted.
        ///   - Ready - Indicates that the cluster is in a stable state.
        ///
        /// </param>
        /// <param name="diagnosticsStorageAccountConfig"> The storage account information for storing Service Fabric diagnostic logs. </param>
        /// <param name="isEventStoreServiceEnabled"> Indicates if the event store service is enabled. </param>
        /// <param name="fabricSettings"> The list of custom fabric settings to configure the cluster. </param>
        /// <param name="managementEndpoint"> The http management endpoint of the cluster. </param>
        /// <param name="nodeTypes"> The list of node types in the cluster. </param>
        /// <param name="provisioningState"> The provisioning state of the cluster resource. </param>
        /// <param name="reliabilityLevel">
        /// The reliability level sets the replica set size of system services. Learn about [ReliabilityLevel](https://docs.microsoft.com/azure/service-fabric/service-fabric-cluster-capacity).
        ///
        ///   - None - Run the System services with a target replica set count of 1. This should only be used for test clusters.
        ///   - Bronze - Run the System services with a target replica set count of 3. This should only be used for test clusters.
        ///   - Silver - Run the System services with a target replica set count of 5.
        ///   - Gold - Run the System services with a target replica set count of 7.
        ///   - Platinum - Run the System services with a target replica set count of 9.
        ///
        /// </param>
        /// <param name="reverseProxyCertificate"> The server certificate used by reverse proxy. </param>
        /// <param name="reverseProxyCertificateCommonNames"> Describes a list of server certificates referenced by common name that are used to secure the cluster. </param>
        /// <param name="upgradeDescription"> The policy to use when upgrading the cluster. </param>
        /// <param name="upgradeMode"> The upgrade mode of the cluster when new Service Fabric runtime version is available. </param>
        /// <param name="applicationTypeVersionsCleanupPolicy"> The policy used to clean up unused versions. </param>
        /// <param name="vmImage"> The VM image VMSS has been configured with. Generic names such as Windows or Linux can be used. </param>
        /// <param name="serviceFabricZonalUpgradeMode"> This property controls the logical grouping of VMs in upgrade domains (UDs). This property can't be modified if a node type with multiple Availability Zones is already present in the cluster. </param>
        /// <param name="vmssZonalUpgradeMode"> This property defines the upgrade mode for the virtual machine scale set, it is mandatory if a node type with multiple Availability Zones is added. </param>
        /// <param name="isInfrastructureServiceManagerEnabled"> Indicates if infrastructure service manager is enabled. </param>
        /// <param name="upgradeWave"> Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **upgradeMode** is set to 'Automatic'. </param>
        /// <param name="upgradePauseStartOn"> Indicates the start date and time to pause automatic runtime version upgrades on the cluster for an specific period of time on the cluster (UTC). </param>
        /// <param name="upgradePauseEndOn"> Indicates the end date and time to pause automatic runtime version upgrades on the cluster for an specific period of time on the cluster (UTC). </param>
        /// <param name="isWaveUpgradePaused"> Boolean to pause automatic runtime version upgrades to the cluster. </param>
        /// <param name="notifications"> Indicates a list of notification channels for cluster events. </param>
        /// <param name="etag"> Azure resource etag. </param>
        internal ServiceFabricClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<ClusterAddOnFeature> addOnFeatures, IReadOnlyList<ClusterVersionDetails> availableClusterVersions, ClusterAadSetting azureActiveDirectory, ClusterCertificateDescription certificate, ClusterServerCertificateCommonNames certificateCommonNames, IList<ClusterClientCertificateCommonName> clientCertificateCommonNames, IList<ClusterClientCertificateThumbprint> clientCertificateThumbprints, string clusterCodeVersion, Uri clusterEndpoint, Guid? clusterId, ServiceFabricClusterState? clusterState, DiagnosticsStorageAccountConfig diagnosticsStorageAccountConfig, bool? isEventStoreServiceEnabled, IList<SettingsSectionDescription> fabricSettings, Uri managementEndpoint, IList<ClusterNodeTypeDescription> nodeTypes, ServiceFabricProvisioningState? provisioningState, ClusterReliabilityLevel? reliabilityLevel, ClusterCertificateDescription reverseProxyCertificate, ClusterServerCertificateCommonNames reverseProxyCertificateCommonNames, ClusterUpgradePolicy upgradeDescription, ClusterUpgradeMode? upgradeMode, ApplicationTypeVersionsCleanupPolicy applicationTypeVersionsCleanupPolicy, string vmImage, SfZonalUpgradeMode? serviceFabricZonalUpgradeMode, VmssZonalUpgradeMode? vmssZonalUpgradeMode, bool? isInfrastructureServiceManagerEnabled, ClusterUpgradeCadence? upgradeWave, DateTimeOffset? upgradePauseStartOn, DateTimeOffset? upgradePauseEndOn, bool? isWaveUpgradePaused, IList<ClusterNotification> notifications, ETag? etag) : base(id, name, resourceType, systemData, tags, location)
        {
            AddOnFeatures = addOnFeatures;
            AvailableClusterVersions = availableClusterVersions;
            AzureActiveDirectory = azureActiveDirectory;
            Certificate = certificate;
            CertificateCommonNames = certificateCommonNames;
            ClientCertificateCommonNames = clientCertificateCommonNames;
            ClientCertificateThumbprints = clientCertificateThumbprints;
            ClusterCodeVersion = clusterCodeVersion;
            ClusterEndpoint = clusterEndpoint;
            ClusterId = clusterId;
            ClusterState = clusterState;
            DiagnosticsStorageAccountConfig = diagnosticsStorageAccountConfig;
            IsEventStoreServiceEnabled = isEventStoreServiceEnabled;
            FabricSettings = fabricSettings;
            ManagementEndpoint = managementEndpoint;
            NodeTypes = nodeTypes;
            ProvisioningState = provisioningState;
            ReliabilityLevel = reliabilityLevel;
            ReverseProxyCertificate = reverseProxyCertificate;
            ReverseProxyCertificateCommonNames = reverseProxyCertificateCommonNames;
            UpgradeDescription = upgradeDescription;
            UpgradeMode = upgradeMode;
            ApplicationTypeVersionsCleanupPolicy = applicationTypeVersionsCleanupPolicy;
            VmImage = vmImage;
            ServiceFabricZonalUpgradeMode = serviceFabricZonalUpgradeMode;
            VmssZonalUpgradeMode = vmssZonalUpgradeMode;
            IsInfrastructureServiceManagerEnabled = isInfrastructureServiceManagerEnabled;
            UpgradeWave = upgradeWave;
            UpgradePauseStartOn = upgradePauseStartOn;
            UpgradePauseEndOn = upgradePauseEndOn;
            IsWaveUpgradePaused = isWaveUpgradePaused;
            Notifications = notifications;
            ETag = etag;
        }

        /// <summary> The list of add-on features to enable in the cluster. </summary>
        public IList<ClusterAddOnFeature> AddOnFeatures { get; }
        /// <summary> The Service Fabric runtime versions available for this cluster. </summary>
        public IReadOnlyList<ClusterVersionDetails> AvailableClusterVersions { get; }
        /// <summary> The AAD authentication settings of the cluster. </summary>
        public ClusterAadSetting AzureActiveDirectory { get; set; }
        /// <summary> The certificate to use for securing the cluster. The certificate provided will be used for node to node security within the cluster, SSL certificate for cluster management endpoint and default admin client. </summary>
        public ClusterCertificateDescription Certificate { get; set; }
        /// <summary> Describes a list of server certificates referenced by common name that are used to secure the cluster. </summary>
        public ClusterServerCertificateCommonNames CertificateCommonNames { get; set; }
        /// <summary> The list of client certificates referenced by common name that are allowed to manage the cluster. </summary>
        public IList<ClusterClientCertificateCommonName> ClientCertificateCommonNames { get; }
        /// <summary> The list of client certificates referenced by thumbprint that are allowed to manage the cluster. </summary>
        public IList<ClusterClientCertificateThumbprint> ClientCertificateThumbprints { get; }
        /// <summary> The Service Fabric runtime version of the cluster. This property can only by set the user when **upgradeMode** is set to 'Manual'. To get list of available Service Fabric versions for new clusters use [ClusterVersion API](https://learn.microsoft.com/rest/api/servicefabric/cluster-versions/list). To get the list of available version for existing clusters use **availableClusterVersions**. </summary>
        public string ClusterCodeVersion { get; set; }
        /// <summary> The Azure Resource Provider endpoint. A system service in the cluster connects to this  endpoint. </summary>
        public Uri ClusterEndpoint { get; }
        /// <summary> A service generated unique identifier for the cluster resource. </summary>
        public Guid? ClusterId { get; }
        /// <summary>
        /// The current state of the cluster.
        ///
        ///   - WaitingForNodes - Indicates that the cluster resource is created and the resource provider is waiting for Service Fabric VM extension to boot up and report to it.
        ///   - Deploying - Indicates that the Service Fabric runtime is being installed on the VMs. Cluster resource will be in this state until the cluster boots up and system services are up.
        ///   - BaselineUpgrade - Indicates that the cluster is upgrading to establishes the cluster version. This upgrade is automatically initiated when the cluster boots up for the first time.
        ///   - UpdatingUserConfiguration - Indicates that the cluster is being upgraded with the user provided configuration.
        ///   - UpdatingUserCertificate - Indicates that the cluster is being upgraded with the user provided certificate.
        ///   - UpdatingInfrastructure - Indicates that the cluster is being upgraded with the latest Service Fabric runtime version. This happens only when the **upgradeMode** is set to 'Automatic'.
        ///   - EnforcingClusterVersion - Indicates that cluster is on a different version than expected and the cluster is being upgraded to the expected version.
        ///   - UpgradeServiceUnreachable - Indicates that the system service in the cluster is no longer polling the Resource Provider. Clusters in this state cannot be managed by the Resource Provider.
        ///   - AutoScale - Indicates that the ReliabilityLevel of the cluster is being adjusted.
        ///   - Ready - Indicates that the cluster is in a stable state.
        ///
        /// </summary>
        public ServiceFabricClusterState? ClusterState { get; }
        /// <summary> The storage account information for storing Service Fabric diagnostic logs. </summary>
        public DiagnosticsStorageAccountConfig DiagnosticsStorageAccountConfig { get; set; }
        /// <summary> Indicates if the event store service is enabled. </summary>
        public bool? IsEventStoreServiceEnabled { get; set; }
        /// <summary> The list of custom fabric settings to configure the cluster. </summary>
        public IList<SettingsSectionDescription> FabricSettings { get; }
        /// <summary> The http management endpoint of the cluster. </summary>
        public Uri ManagementEndpoint { get; set; }
        /// <summary> The list of node types in the cluster. </summary>
        public IList<ClusterNodeTypeDescription> NodeTypes { get; }
        /// <summary> The provisioning state of the cluster resource. </summary>
        public ServiceFabricProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// The reliability level sets the replica set size of system services. Learn about [ReliabilityLevel](https://docs.microsoft.com/azure/service-fabric/service-fabric-cluster-capacity).
        ///
        ///   - None - Run the System services with a target replica set count of 1. This should only be used for test clusters.
        ///   - Bronze - Run the System services with a target replica set count of 3. This should only be used for test clusters.
        ///   - Silver - Run the System services with a target replica set count of 5.
        ///   - Gold - Run the System services with a target replica set count of 7.
        ///   - Platinum - Run the System services with a target replica set count of 9.
        ///
        /// </summary>
        public ClusterReliabilityLevel? ReliabilityLevel { get; set; }
        /// <summary> The server certificate used by reverse proxy. </summary>
        public ClusterCertificateDescription ReverseProxyCertificate { get; set; }
        /// <summary> Describes a list of server certificates referenced by common name that are used to secure the cluster. </summary>
        public ClusterServerCertificateCommonNames ReverseProxyCertificateCommonNames { get; set; }
        /// <summary> The policy to use when upgrading the cluster. </summary>
        public ClusterUpgradePolicy UpgradeDescription { get; set; }
        /// <summary> The upgrade mode of the cluster when new Service Fabric runtime version is available. </summary>
        public ClusterUpgradeMode? UpgradeMode { get; set; }
        /// <summary> The policy used to clean up unused versions. </summary>
        internal ApplicationTypeVersionsCleanupPolicy ApplicationTypeVersionsCleanupPolicy { get; set; }
        /// <summary> Number of unused versions per application type to keep. </summary>
        public long? MaxUnusedVersionsToKeep
        {
            get => ApplicationTypeVersionsCleanupPolicy is null ? default(long?) : ApplicationTypeVersionsCleanupPolicy.MaxUnusedVersionsToKeep;
            set
            {
                ApplicationTypeVersionsCleanupPolicy = value.HasValue ? new ApplicationTypeVersionsCleanupPolicy(value.Value) : null;
            }
        }

        /// <summary> The VM image VMSS has been configured with. Generic names such as Windows or Linux can be used. </summary>
        public string VmImage { get; set; }
        /// <summary> This property controls the logical grouping of VMs in upgrade domains (UDs). This property can't be modified if a node type with multiple Availability Zones is already present in the cluster. </summary>
        public SfZonalUpgradeMode? ServiceFabricZonalUpgradeMode { get; set; }
        /// <summary> This property defines the upgrade mode for the virtual machine scale set, it is mandatory if a node type with multiple Availability Zones is added. </summary>
        public VmssZonalUpgradeMode? VmssZonalUpgradeMode { get; set; }
        /// <summary> Indicates if infrastructure service manager is enabled. </summary>
        public bool? IsInfrastructureServiceManagerEnabled { get; set; }
        /// <summary> Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. Only applies when **upgradeMode** is set to 'Automatic'. </summary>
        public ClusterUpgradeCadence? UpgradeWave { get; set; }
        /// <summary> Indicates the start date and time to pause automatic runtime version upgrades on the cluster for an specific period of time on the cluster (UTC). </summary>
        public DateTimeOffset? UpgradePauseStartOn { get; set; }
        /// <summary> Indicates the end date and time to pause automatic runtime version upgrades on the cluster for an specific period of time on the cluster (UTC). </summary>
        public DateTimeOffset? UpgradePauseEndOn { get; set; }
        /// <summary> Boolean to pause automatic runtime version upgrades to the cluster. </summary>
        public bool? IsWaveUpgradePaused { get; set; }
        /// <summary> Indicates a list of notification channels for cluster events. </summary>
        public IList<ClusterNotification> Notifications { get; }
        /// <summary> Azure resource etag. </summary>
        public ETag? ETag { get; }
    }
}
