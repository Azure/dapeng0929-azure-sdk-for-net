// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MigrationDiscoverySap.Models
{
    /// <summary> Defines the SAP Instance properties. </summary>
    public partial class ServerInstanceProperties
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

        /// <summary> Initializes a new instance of <see cref="ServerInstanceProperties"/>. </summary>
        public ServerInstanceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServerInstanceProperties"/>. </summary>
        /// <param name="serverName"> This is the Virtual Machine Name of the SAP system. Add all the virtual machines attached to an SAP system which you wish to migrate to Azure. Keeping this not equal to ID as for single tier all InstanceTypes would be on same server, leading to multiple resources with same servername. </param>
        /// <param name="sapInstanceType"> Defines the type SAP instance on this server instance. </param>
        /// <param name="instanceSid"> This is the Instance SID for ASCS/AP/DB instance.  An SAP system with HANA database for example could have a different SID for database Instance than that of ASCS instance. </param>
        /// <param name="sapProduct"> This is the SAP Application Component; e.g. SAP S/4HANA 2022, SAP ERP ENHANCE PACKAGE. </param>
        /// <param name="sapProductVersion"> Provide the product version of the SAP product. </param>
        /// <param name="operatingSystem"> This is Operating System on which the host server is running. </param>
        /// <param name="configurationData"> Configuration data for this server instance. </param>
        /// <param name="performanceData">
        /// Configuration data for this server instance.
        /// Please note <see cref="PerformanceDetail"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExcelPerformanceDetail"/> and <see cref="NativePerformanceDetail"/>.
        /// </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errors"> Defines the errors related to SAP Instance resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServerInstanceProperties(string serverName, SapInstanceType? sapInstanceType, string instanceSid, string sapProduct, string sapProductVersion, SapDiscoveryOperatingSystem? operatingSystem, ConfigurationDetail configurationData, PerformanceDetail performanceData, SapDiscoveryProvisioningState? provisioningState, SapMigrateError errors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServerName = serverName;
            SapInstanceType = sapInstanceType;
            InstanceSid = instanceSid;
            SapProduct = sapProduct;
            SapProductVersion = sapProductVersion;
            OperatingSystem = operatingSystem;
            ConfigurationData = configurationData;
            PerformanceData = performanceData;
            ProvisioningState = provisioningState;
            Errors = errors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This is the Virtual Machine Name of the SAP system. Add all the virtual machines attached to an SAP system which you wish to migrate to Azure. Keeping this not equal to ID as for single tier all InstanceTypes would be on same server, leading to multiple resources with same servername. </summary>
        public string ServerName { get; }
        /// <summary> Defines the type SAP instance on this server instance. </summary>
        public SapInstanceType? SapInstanceType { get; }
        /// <summary> This is the Instance SID for ASCS/AP/DB instance.  An SAP system with HANA database for example could have a different SID for database Instance than that of ASCS instance. </summary>
        public string InstanceSid { get; }
        /// <summary> This is the SAP Application Component; e.g. SAP S/4HANA 2022, SAP ERP ENHANCE PACKAGE. </summary>
        public string SapProduct { get; }
        /// <summary> Provide the product version of the SAP product. </summary>
        public string SapProductVersion { get; }
        /// <summary> This is Operating System on which the host server is running. </summary>
        public SapDiscoveryOperatingSystem? OperatingSystem { get; }
        /// <summary> Configuration data for this server instance. </summary>
        public ConfigurationDetail ConfigurationData { get; }
        /// <summary>
        /// Configuration data for this server instance.
        /// Please note <see cref="PerformanceDetail"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ExcelPerformanceDetail"/> and <see cref="NativePerformanceDetail"/>.
        /// </summary>
        public PerformanceDetail PerformanceData { get; }
        /// <summary> Defines the provisioning states. </summary>
        public SapDiscoveryProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the errors related to SAP Instance resource. </summary>
        internal SapMigrateError Errors { get; }
        /// <summary> The SAP Discovery site resource error body. </summary>
        public SapDiscoveryErrorDetail ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
