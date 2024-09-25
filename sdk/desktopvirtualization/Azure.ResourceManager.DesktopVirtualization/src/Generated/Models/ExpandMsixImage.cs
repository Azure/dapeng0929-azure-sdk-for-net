// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Represents the definition of contents retrieved after expanding the MSIX Image. </summary>
    public partial class ExpandMsixImage : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ExpandMsixImage"/>. </summary>
        public ExpandMsixImage()
        {
            PackageDependencies = new ChangeTrackingList<MsixPackageDependencies>();
            PackageApplications = new ChangeTrackingList<MsixPackageApplications>();
        }

        /// <summary> Initializes a new instance of <see cref="ExpandMsixImage"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="packageAlias"> Alias of MSIX Package. </param>
        /// <param name="imagePath"> VHD/CIM image path on Network Share. </param>
        /// <param name="packageName"> Package Name from appxmanifest.xml. </param>
        /// <param name="packageFamilyName"> Package Family Name from appxmanifest.xml. Contains Package Name and Publisher name. </param>
        /// <param name="packageFullName"> Package Full Name from appxmanifest.xml. </param>
        /// <param name="displayName"> User friendly Name to be displayed in the portal. </param>
        /// <param name="packageRelativePath"> Relative Path to the package inside the image. </param>
        /// <param name="isRegularRegistration"> Specifies how to register Package in feed. </param>
        /// <param name="isActive"> Make this version of the package the active one across the hostpool. </param>
        /// <param name="packageDependencies"> List of package dependencies. </param>
        /// <param name="version"> Package Version found in the appxmanifest.xml. </param>
        /// <param name="lastUpdatedOn"> Date Package was last updated, found in the appxmanifest.xml. </param>
        /// <param name="packageApplications"> List of package applications. </param>
        /// <param name="certificateName"> Certificate name found in the appxmanifest.xml. </param>
        /// <param name="certificateExpiry"> Date certificate expires, found in the appxmanifest.xml. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpandMsixImage(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string packageAlias, string imagePath, string packageName, string packageFamilyName, string packageFullName, string displayName, string packageRelativePath, bool? isRegularRegistration, bool? isActive, IList<MsixPackageDependencies> packageDependencies, string version, DateTimeOffset? lastUpdatedOn, IList<MsixPackageApplications> packageApplications, string certificateName, DateTimeOffset? certificateExpiry, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            PackageAlias = packageAlias;
            ImagePath = imagePath;
            PackageName = packageName;
            PackageFamilyName = packageFamilyName;
            PackageFullName = packageFullName;
            DisplayName = displayName;
            PackageRelativePath = packageRelativePath;
            IsRegularRegistration = isRegularRegistration;
            IsActive = isActive;
            PackageDependencies = packageDependencies;
            Version = version;
            LastUpdatedOn = lastUpdatedOn;
            PackageApplications = packageApplications;
            CertificateName = certificateName;
            CertificateExpiry = certificateExpiry;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Alias of MSIX Package. </summary>
        [WirePath("properties.packageAlias")]
        public string PackageAlias { get; set; }
        /// <summary> VHD/CIM image path on Network Share. </summary>
        [WirePath("properties.imagePath")]
        public string ImagePath { get; set; }
        /// <summary> Package Name from appxmanifest.xml. </summary>
        [WirePath("properties.packageName")]
        public string PackageName { get; set; }
        /// <summary> Package Family Name from appxmanifest.xml. Contains Package Name and Publisher name. </summary>
        [WirePath("properties.packageFamilyName")]
        public string PackageFamilyName { get; set; }
        /// <summary> Package Full Name from appxmanifest.xml. </summary>
        [WirePath("properties.packageFullName")]
        public string PackageFullName { get; set; }
        /// <summary> User friendly Name to be displayed in the portal. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> Relative Path to the package inside the image. </summary>
        [WirePath("properties.packageRelativePath")]
        public string PackageRelativePath { get; set; }
        /// <summary> Specifies how to register Package in feed. </summary>
        [WirePath("properties.isRegularRegistration")]
        public bool? IsRegularRegistration { get; set; }
        /// <summary> Make this version of the package the active one across the hostpool. </summary>
        [WirePath("properties.isActive")]
        public bool? IsActive { get; set; }
        /// <summary> List of package dependencies. </summary>
        [WirePath("properties.packageDependencies")]
        public IList<MsixPackageDependencies> PackageDependencies { get; set; }
        /// <summary> Package Version found in the appxmanifest.xml. </summary>
        [WirePath("properties.version")]
        public string Version { get; set; }
        /// <summary> Date Package was last updated, found in the appxmanifest.xml. </summary>
        [WirePath("properties.lastUpdated")]
        public DateTimeOffset? LastUpdatedOn { get; set; }
        /// <summary> List of package applications. </summary>
        [WirePath("properties.packageApplications")]
        public IList<MsixPackageApplications> PackageApplications { get; }
        /// <summary> Certificate name found in the appxmanifest.xml. </summary>
        [WirePath("properties.certificateName")]
        public string CertificateName { get; set; }
        /// <summary> Date certificate expires, found in the appxmanifest.xml. </summary>
        [WirePath("properties.certificateExpiry")]
        public DateTimeOffset? CertificateExpiry { get; set; }
    }
}
