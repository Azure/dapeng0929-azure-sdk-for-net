// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing the ActiveSessionHostConfiguration data model.
    /// Represents a ActiveSessionHostConfiguration definition. This has all of the sessionHostConfiguration properties except provisioningState
    /// </summary>
    public partial class ActiveSessionHostConfigurationData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ActiveSessionHostConfigurationData"/>. </summary>
        /// <param name="vmNamePrefix"> The prefix that should be associated with session host names. </param>
        /// <param name="networkInfo"> Network information. </param>
        /// <param name="vmSizeId"> The id of the size of a virtual machine connected to a hostpool. Example: Standard_D2as_v6. </param>
        /// <param name="diskInfo"> Disk information. </param>
        /// <param name="imageInfo"> Image configurations of HostPool. </param>
        /// <param name="domainInfo"> Domain configurations of session hosts. </param>
        /// <param name="vmAdminCredentials"> Local Admin credentials for session hosts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmNamePrefix"/>, <paramref name="networkInfo"/>, <paramref name="vmSizeId"/>, <paramref name="diskInfo"/>, <paramref name="imageInfo"/>, <paramref name="domainInfo"/> or <paramref name="vmAdminCredentials"/> is null. </exception>
        public ActiveSessionHostConfigurationData(string vmNamePrefix, NetworkInfoProperties networkInfo, string vmSizeId, DiskInfoProperties diskInfo, ImageInfoProperties imageInfo, DomainInfoProperties domainInfo, KeyVaultCredentialsProperties vmAdminCredentials)
        {
            Argument.AssertNotNull(vmNamePrefix, nameof(vmNamePrefix));
            Argument.AssertNotNull(networkInfo, nameof(networkInfo));
            Argument.AssertNotNull(vmSizeId, nameof(vmSizeId));
            Argument.AssertNotNull(diskInfo, nameof(diskInfo));
            Argument.AssertNotNull(imageInfo, nameof(imageInfo));
            Argument.AssertNotNull(domainInfo, nameof(domainInfo));
            Argument.AssertNotNull(vmAdminCredentials, nameof(vmAdminCredentials));

            VmTags = new ChangeTrackingDictionary<string, string>();
            VmNamePrefix = vmNamePrefix;
            AvailabilityZones = new ChangeTrackingList<int>();
            NetworkInfo = networkInfo;
            VmSizeId = vmSizeId;
            DiskInfo = diskInfo;
            ImageInfo = imageInfo;
            DomainInfo = domainInfo;
            VmAdminCredentials = vmAdminCredentials;
        }

        /// <summary> Initializes a new instance of <see cref="ActiveSessionHostConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="version"> The timestamp of the last update. </param>
        /// <param name="friendlyName"> Friendly name to describe this version of the SessionHostConfiguration. </param>
        /// <param name="vmTags"> Hashtable that lists key/value pair tags to apply to the VMs. </param>
        /// <param name="vmLocation"> The Location for the session host to be created in. It will default to the location of the hostpool if not provided. </param>
        /// <param name="vmResourceGroup"> The ResourceGroup for the session hosts to be created in. It will default to the ResourceGroup of the hostpool if not provided. </param>
        /// <param name="vmNamePrefix"> The prefix that should be associated with session host names. </param>
        /// <param name="availabilityZones"> Value for availability zones to be used by the session host. Should be from [1,2,3]. </param>
        /// <param name="networkInfo"> Network information. </param>
        /// <param name="vmSizeId"> The id of the size of a virtual machine connected to a hostpool. Example: Standard_D2as_v6. </param>
        /// <param name="diskInfo"> Disk information. </param>
        /// <param name="customConfigurationScriptUri"> The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning. </param>
        /// <param name="imageInfo"> Image configurations of HostPool. </param>
        /// <param name="domainInfo"> Domain configurations of session hosts. </param>
        /// <param name="securityInfo"> Security information. </param>
        /// <param name="vmAdminCredentials"> Local Admin credentials for session hosts. </param>
        /// <param name="bootDiagnosticsInfo"> Boot Diagnostics information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ActiveSessionHostConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? version, string friendlyName, IDictionary<string, string> vmTags, string vmLocation, string vmResourceGroup, string vmNamePrefix, IList<int> availabilityZones, NetworkInfoProperties networkInfo, string vmSizeId, DiskInfoProperties diskInfo, Uri customConfigurationScriptUri, ImageInfoProperties imageInfo, DomainInfoProperties domainInfo, SecurityInfoProperties securityInfo, KeyVaultCredentialsProperties vmAdminCredentials, BootDiagnosticsInfoProperties bootDiagnosticsInfo, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Version = version;
            FriendlyName = friendlyName;
            VmTags = vmTags;
            VmLocation = vmLocation;
            VmResourceGroup = vmResourceGroup;
            VmNamePrefix = vmNamePrefix;
            AvailabilityZones = availabilityZones;
            NetworkInfo = networkInfo;
            VmSizeId = vmSizeId;
            DiskInfo = diskInfo;
            CustomConfigurationScriptUri = customConfigurationScriptUri;
            ImageInfo = imageInfo;
            DomainInfo = domainInfo;
            SecurityInfo = securityInfo;
            VmAdminCredentials = vmAdminCredentials;
            BootDiagnosticsInfo = bootDiagnosticsInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ActiveSessionHostConfigurationData"/> for deserialization. </summary>
        internal ActiveSessionHostConfigurationData()
        {
        }

        /// <summary> The timestamp of the last update. </summary>
        [WirePath("properties.version")]
        public DateTimeOffset? Version { get; }
        /// <summary> Friendly name to describe this version of the SessionHostConfiguration. </summary>
        [WirePath("properties.friendlyName")]
        public string FriendlyName { get; set; }
        /// <summary> Hashtable that lists key/value pair tags to apply to the VMs. </summary>
        [WirePath("properties.vmTags")]
        public IDictionary<string, string> VmTags { get; }
        /// <summary> The Location for the session host to be created in. It will default to the location of the hostpool if not provided. </summary>
        [WirePath("properties.vmLocation")]
        public string VmLocation { get; set; }
        /// <summary> The ResourceGroup for the session hosts to be created in. It will default to the ResourceGroup of the hostpool if not provided. </summary>
        [WirePath("properties.vmResourceGroup")]
        public string VmResourceGroup { get; set; }
        /// <summary> The prefix that should be associated with session host names. </summary>
        [WirePath("properties.vmNamePrefix")]
        public string VmNamePrefix { get; set; }
        /// <summary> Value for availability zones to be used by the session host. Should be from [1,2,3]. </summary>
        [WirePath("properties.availabilityZones")]
        public IList<int> AvailabilityZones { get; }
        /// <summary> Network information. </summary>
        [WirePath("properties.networkInfo")]
        public NetworkInfoProperties NetworkInfo { get; set; }
        /// <summary> The id of the size of a virtual machine connected to a hostpool. Example: Standard_D2as_v6. </summary>
        [WirePath("properties.vmSizeId")]
        public string VmSizeId { get; set; }
        /// <summary> Disk information. </summary>
        internal DiskInfoProperties DiskInfo { get; set; }
        /// <summary> The disk type used by virtual machine in hostpool session host. </summary>
        [WirePath("properties.diskInfo.type")]
        public VirtualMachineDiskType? VirtualMachineDiskType
        {
            get => DiskInfo is null ? default(VirtualMachineDiskType?) : DiskInfo.VirtualMachineDiskType;
            set
            {
                DiskInfo = value.HasValue ? new DiskInfoProperties(value.Value) : null;
            }
        }

        /// <summary> The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning. </summary>
        [WirePath("properties.customConfigurationScriptUrl")]
        public Uri CustomConfigurationScriptUri { get; set; }
        /// <summary> Image configurations of HostPool. </summary>
        [WirePath("properties.imageInfo")]
        public ImageInfoProperties ImageInfo { get; set; }
        /// <summary> Domain configurations of session hosts. </summary>
        [WirePath("properties.domainInfo")]
        public DomainInfoProperties DomainInfo { get; set; }
        /// <summary> Security information. </summary>
        [WirePath("properties.securityInfo")]
        public SecurityInfoProperties SecurityInfo { get; set; }
        /// <summary> Local Admin credentials for session hosts. </summary>
        [WirePath("properties.vmAdminCredentials")]
        public KeyVaultCredentialsProperties VmAdminCredentials { get; set; }
        /// <summary> Boot Diagnostics information. </summary>
        [WirePath("properties.bootDiagnosticsInfo")]
        public BootDiagnosticsInfoProperties BootDiagnosticsInfo { get; set; }
    }
}
