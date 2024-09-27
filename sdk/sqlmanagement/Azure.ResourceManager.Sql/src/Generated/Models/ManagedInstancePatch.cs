// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An update request for an Azure SQL Database managed instance. </summary>
    public partial class ManagedInstancePatch
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

        /// <summary> Initializes a new instance of <see cref="ManagedInstancePatch"/>. </summary>
        public ManagedInstancePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            PrivateEndpointConnections = new ChangeTrackingList<ManagedInstancePecProperty>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstancePatch"/>. </summary>
        /// <param name="sku"> Managed instance sku. </param>
        /// <param name="identity"> Managed instance identity. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="provisioningState"> Provisioning state of managed instance. </param>
        /// <param name="managedInstanceCreateMode">
        /// Specifies the mode of database creation.
        ///
        /// Default: Regular instance creation.
        ///
        /// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
        /// </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of the managed instance. </param>
        /// <param name="isGeneralPurposeV2"> Whether or not this is a GPv2 variant of General Purpose edition. </param>
        /// <param name="administratorLogin"> Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation). </param>
        /// <param name="administratorLoginPassword"> The administrator login password (required for managed instance creation). </param>
        /// <param name="subnetId"> Subnet resource ID for the managed instance. </param>
        /// <param name="state"> The state of the managed instance. </param>
        /// <param name="licenseType"> The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses). </param>
        /// <param name="hybridSecondaryUsage"> Hybrid secondary usage. Possible values are 'Active' (default value) and 'Passive' (customer uses the secondary as Passive DR). </param>
        /// <param name="hybridSecondaryUsageDetected"> Hybrid secondary usage detected. Possible values are 'Active' (customer does not meet the requirements to use the secondary as Passive DR) and 'Passive' (customer meets the requirements to use the secondary as Passive DR). </param>
        /// <param name="vCores"> The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80. </param>
        /// <param name="storageSizeInGB"> Storage size in GB. Minimum value: 32. Maximum value: 16384. Increments of 32 GB allowed only. Maximum value depends on the selected hardware family and number of vCores. </param>
        /// <param name="storageIOps"> Storage IOps. Minimum value: 300. Maximum value: 80000. Increments of 1 IOps allowed only. Maximum value depends on the selected hardware family and number of vCores. </param>
        /// <param name="storageThroughputMBps"> Storage throughput MBps parameter is not supported in the instance create/update operation. </param>
        /// <param name="collation"> Collation of the managed instance. </param>
        /// <param name="dnsZone"> The Dns Zone that the managed instance is in. </param>
        /// <param name="managedDnsZonePartner"> The resource id of another managed instance whose DNS zone this managed instance will share after creation. </param>
        /// <param name="isPublicDataEndpointEnabled"> Whether or not the public data endpoint is enabled. </param>
        /// <param name="sourceManagedInstanceId"> The resource identifier of the source managed instance associated with create operation of this instance. </param>
        /// <param name="restorePointInTime"> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </param>
        /// <param name="proxyOverride"> Connection type used for connecting to the instance. </param>
        /// <param name="timezoneId">
        /// Id of the timezone. Allowed values are timezones supported by Windows.
        /// Windows keeps details on supported timezones, including the id, in registry under
        /// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
        /// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
        /// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
        /// </param>
        /// <param name="instancePoolId"> The Id of the instance pool this managed server belongs to. </param>
        /// <param name="maintenanceConfigurationId"> Specifies maintenance configuration id to apply to this managed instance. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections on a managed instance. </param>
        /// <param name="minimalTlsVersion"> Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'. </param>
        /// <param name="currentBackupStorageRedundancy"> The storage account type used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </param>
        /// <param name="requestedBackupStorageRedundancy"> The storage account type to be used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </param>
        /// <param name="isZoneRedundant"> Whether or not the multi-az is enabled. </param>
        /// <param name="primaryUserAssignedIdentityId"> The resource id of a user assigned identity to be used by default. </param>
        /// <param name="keyId"> A CMK URI of the key to use for encryption. </param>
        /// <param name="administrators"> The Azure Active Directory administrator of the instance. This can only be used at instance create time. If used for instance update, it will be ignored or it will result in an error. For updates individual APIs will need to be used. </param>
        /// <param name="servicePrincipal"> The managed instance's service principal. </param>
        /// <param name="virtualClusterId"> Virtual cluster resource id for the Managed Instance. </param>
        /// <param name="externalGovernanceStatus"> Status of external governance. </param>
        /// <param name="pricingModel"> Weather or not Managed Instance is freemium. </param>
        /// <param name="createOn"> Specifies the point in time (ISO8601 format) of the Managed Instance creation. </param>
        /// <param name="authenticationMetadata"> The managed instance's authentication metadata lookup mode. </param>
        /// <param name="databaseFormat"> Specifies the internal format of instance databases specific to the SQL engine version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstancePatch(SqlSku sku, ManagedServiceIdentity identity, IDictionary<string, string> tags, JobExecutionProvisioningState? provisioningState, ManagedServerCreateMode? managedInstanceCreateMode, string fullyQualifiedDomainName, bool? isGeneralPurposeV2, string administratorLogin, string administratorLoginPassword, ResourceIdentifier subnetId, string state, ManagedInstanceLicenseType? licenseType, HybridSecondaryUsage? hybridSecondaryUsage, HybridSecondaryUsageDetected? hybridSecondaryUsageDetected, int? vCores, int? storageSizeInGB, int? storageIOps, int? storageThroughputMBps, string collation, string dnsZone, ResourceIdentifier managedDnsZonePartner, bool? isPublicDataEndpointEnabled, ResourceIdentifier sourceManagedInstanceId, DateTimeOffset? restorePointInTime, ManagedInstanceProxyOverride? proxyOverride, string timezoneId, ResourceIdentifier instancePoolId, ResourceIdentifier maintenanceConfigurationId, IReadOnlyList<ManagedInstancePecProperty> privateEndpointConnections, string minimalTlsVersion, SqlBackupStorageRedundancy? currentBackupStorageRedundancy, SqlBackupStorageRedundancy? requestedBackupStorageRedundancy, bool? isZoneRedundant, ResourceIdentifier primaryUserAssignedIdentityId, Uri keyId, ManagedInstanceExternalAdministrator administrators, SqlServicePrincipal servicePrincipal, string virtualClusterId, ExternalGovernanceStatus? externalGovernanceStatus, FreemiumType? pricingModel, DateTimeOffset? createOn, AuthMetadataLookupMode? authenticationMetadata, ManagedInstanceDatabaseFormat? databaseFormat, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sku = sku;
            Identity = identity;
            Tags = tags;
            ProvisioningState = provisioningState;
            ManagedInstanceCreateMode = managedInstanceCreateMode;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            IsGeneralPurposeV2 = isGeneralPurposeV2;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            SubnetId = subnetId;
            State = state;
            LicenseType = licenseType;
            HybridSecondaryUsage = hybridSecondaryUsage;
            HybridSecondaryUsageDetected = hybridSecondaryUsageDetected;
            VCores = vCores;
            StorageSizeInGB = storageSizeInGB;
            StorageIOps = storageIOps;
            StorageThroughputMBps = storageThroughputMBps;
            Collation = collation;
            DnsZone = dnsZone;
            ManagedDnsZonePartner = managedDnsZonePartner;
            IsPublicDataEndpointEnabled = isPublicDataEndpointEnabled;
            SourceManagedInstanceId = sourceManagedInstanceId;
            RestorePointInTime = restorePointInTime;
            ProxyOverride = proxyOverride;
            TimezoneId = timezoneId;
            InstancePoolId = instancePoolId;
            MaintenanceConfigurationId = maintenanceConfigurationId;
            PrivateEndpointConnections = privateEndpointConnections;
            MinimalTlsVersion = minimalTlsVersion;
            CurrentBackupStorageRedundancy = currentBackupStorageRedundancy;
            RequestedBackupStorageRedundancy = requestedBackupStorageRedundancy;
            IsZoneRedundant = isZoneRedundant;
            PrimaryUserAssignedIdentityId = primaryUserAssignedIdentityId;
            KeyId = keyId;
            Administrators = administrators;
            ServicePrincipal = servicePrincipal;
            VirtualClusterId = virtualClusterId;
            ExternalGovernanceStatus = externalGovernanceStatus;
            PricingModel = pricingModel;
            CreateOn = createOn;
            AuthenticationMetadata = authenticationMetadata;
            DatabaseFormat = databaseFormat;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Managed instance sku. </summary>
        [WirePath("sku")]
        public SqlSku Sku { get; set; }
        /// <summary> Managed instance identity. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Resource tags. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
        /// <summary> Provisioning state of managed instance. </summary>
        [WirePath("properties.provisioningState")]
        public JobExecutionProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// Specifies the mode of database creation.
        ///
        /// Default: Regular instance creation.
        ///
        /// Restore: Creates an instance by restoring a set of backups to specific point in time. RestorePointInTime and SourceManagedInstanceId must be specified.
        /// </summary>
        [WirePath("properties.managedInstanceCreateMode")]
        public ManagedServerCreateMode? ManagedInstanceCreateMode { get; set; }
        /// <summary> The fully qualified domain name of the managed instance. </summary>
        [WirePath("properties.fullyQualifiedDomainName")]
        public string FullyQualifiedDomainName { get; }
        /// <summary> Whether or not this is a GPv2 variant of General Purpose edition. </summary>
        [WirePath("properties.isGeneralPurposeV2")]
        public bool? IsGeneralPurposeV2 { get; set; }
        /// <summary> Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation). </summary>
        [WirePath("properties.administratorLogin")]
        public string AdministratorLogin { get; set; }
        /// <summary> The administrator login password (required for managed instance creation). </summary>
        [WirePath("properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }
        /// <summary> Subnet resource ID for the managed instance. </summary>
        [WirePath("properties.subnetId")]
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> The state of the managed instance. </summary>
        [WirePath("properties.state")]
        public string State { get; }
        /// <summary> The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses). </summary>
        [WirePath("properties.licenseType")]
        public ManagedInstanceLicenseType? LicenseType { get; set; }
        /// <summary> Hybrid secondary usage. Possible values are 'Active' (default value) and 'Passive' (customer uses the secondary as Passive DR). </summary>
        [WirePath("properties.hybridSecondaryUsage")]
        public HybridSecondaryUsage? HybridSecondaryUsage { get; set; }
        /// <summary> Hybrid secondary usage detected. Possible values are 'Active' (customer does not meet the requirements to use the secondary as Passive DR) and 'Passive' (customer meets the requirements to use the secondary as Passive DR). </summary>
        [WirePath("properties.hybridSecondaryUsageDetected")]
        public HybridSecondaryUsageDetected? HybridSecondaryUsageDetected { get; }
        /// <summary> The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80. </summary>
        [WirePath("properties.vCores")]
        public int? VCores { get; set; }
        /// <summary> Storage size in GB. Minimum value: 32. Maximum value: 16384. Increments of 32 GB allowed only. Maximum value depends on the selected hardware family and number of vCores. </summary>
        [WirePath("properties.storageSizeInGB")]
        public int? StorageSizeInGB { get; set; }
        /// <summary> Storage IOps. Minimum value: 300. Maximum value: 80000. Increments of 1 IOps allowed only. Maximum value depends on the selected hardware family and number of vCores. </summary>
        [WirePath("properties.storageIOps")]
        public int? StorageIOps { get; set; }
        /// <summary> Storage throughput MBps parameter is not supported in the instance create/update operation. </summary>
        [WirePath("properties.storageThroughputMBps")]
        public int? StorageThroughputMBps { get; set; }
        /// <summary> Collation of the managed instance. </summary>
        [WirePath("properties.collation")]
        public string Collation { get; set; }
        /// <summary> The Dns Zone that the managed instance is in. </summary>
        [WirePath("properties.dnsZone")]
        public string DnsZone { get; }
        /// <summary> The resource id of another managed instance whose DNS zone this managed instance will share after creation. </summary>
        [WirePath("properties.dnsZonePartner")]
        public ResourceIdentifier ManagedDnsZonePartner { get; set; }
        /// <summary> Whether or not the public data endpoint is enabled. </summary>
        [WirePath("properties.publicDataEndpointEnabled")]
        public bool? IsPublicDataEndpointEnabled { get; set; }
        /// <summary> The resource identifier of the source managed instance associated with create operation of this instance. </summary>
        [WirePath("properties.sourceManagedInstanceId")]
        public ResourceIdentifier SourceManagedInstanceId { get; set; }
        /// <summary> Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </summary>
        [WirePath("properties.restorePointInTime")]
        public DateTimeOffset? RestorePointInTime { get; set; }
        /// <summary> Connection type used for connecting to the instance. </summary>
        [WirePath("properties.proxyOverride")]
        public ManagedInstanceProxyOverride? ProxyOverride { get; set; }
        /// <summary>
        /// Id of the timezone. Allowed values are timezones supported by Windows.
        /// Windows keeps details on supported timezones, including the id, in registry under
        /// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones.
        /// You can get those registry values via SQL Server by querying SELECT name AS timezone_id FROM sys.time_zone_info.
        /// List of Ids can also be obtained by executing [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time" or "W. Europe Standard Time".
        /// </summary>
        [WirePath("properties.timezoneId")]
        public string TimezoneId { get; set; }
        /// <summary> The Id of the instance pool this managed server belongs to. </summary>
        [WirePath("properties.instancePoolId")]
        public ResourceIdentifier InstancePoolId { get; set; }
        /// <summary> Specifies maintenance configuration id to apply to this managed instance. </summary>
        [WirePath("properties.maintenanceConfigurationId")]
        public ResourceIdentifier MaintenanceConfigurationId { get; set; }
        /// <summary> List of private endpoint connections on a managed instance. </summary>
        [WirePath("properties.privateEndpointConnections")]
        public IReadOnlyList<ManagedInstancePecProperty> PrivateEndpointConnections { get; }
        /// <summary> Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'. </summary>
        [WirePath("properties.minimalTlsVersion")]
        public string MinimalTlsVersion { get; set; }
        /// <summary> The storage account type used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </summary>
        [WirePath("properties.currentBackupStorageRedundancy")]
        public SqlBackupStorageRedundancy? CurrentBackupStorageRedundancy { get; }
        /// <summary> The storage account type to be used to store backups for this instance. The options are Local (LocallyRedundantStorage), Zone (ZoneRedundantStorage), Geo (GeoRedundantStorage) and GeoZone(GeoZoneRedundantStorage). </summary>
        [WirePath("properties.requestedBackupStorageRedundancy")]
        public SqlBackupStorageRedundancy? RequestedBackupStorageRedundancy { get; set; }
        /// <summary> Whether or not the multi-az is enabled. </summary>
        [WirePath("properties.zoneRedundant")]
        public bool? IsZoneRedundant { get; set; }
        /// <summary> The resource id of a user assigned identity to be used by default. </summary>
        [WirePath("properties.primaryUserAssignedIdentityId")]
        public ResourceIdentifier PrimaryUserAssignedIdentityId { get; set; }
        /// <summary> A CMK URI of the key to use for encryption. </summary>
        [WirePath("properties.keyId")]
        public Uri KeyId { get; set; }
        /// <summary> The Azure Active Directory administrator of the instance. This can only be used at instance create time. If used for instance update, it will be ignored or it will result in an error. For updates individual APIs will need to be used. </summary>
        [WirePath("properties.administrators")]
        public ManagedInstanceExternalAdministrator Administrators { get; set; }
        /// <summary> The managed instance's service principal. </summary>
        [WirePath("properties.servicePrincipal")]
        public SqlServicePrincipal ServicePrincipal { get; set; }
        /// <summary> Virtual cluster resource id for the Managed Instance. </summary>
        [WirePath("properties.virtualClusterId")]
        public string VirtualClusterId { get; }
        /// <summary> Status of external governance. </summary>
        [WirePath("properties.externalGovernanceStatus")]
        public ExternalGovernanceStatus? ExternalGovernanceStatus { get; }
        /// <summary> Weather or not Managed Instance is freemium. </summary>
        [WirePath("properties.pricingModel")]
        public FreemiumType? PricingModel { get; set; }
        /// <summary> Specifies the point in time (ISO8601 format) of the Managed Instance creation. </summary>
        [WirePath("properties.createTime")]
        public DateTimeOffset? CreateOn { get; }
        /// <summary> The managed instance's authentication metadata lookup mode. </summary>
        [WirePath("properties.authenticationMetadata")]
        public AuthMetadataLookupMode? AuthenticationMetadata { get; set; }
        /// <summary> Specifies the internal format of instance databases specific to the SQL engine version. </summary>
        [WirePath("properties.databaseFormat")]
        public ManagedInstanceDatabaseFormat? DatabaseFormat { get; set; }
    }
}
