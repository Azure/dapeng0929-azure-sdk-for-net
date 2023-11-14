// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AseV3NetworkingConfiguration data model.
    /// Full view of networking configuration for an ASE.
    /// </summary>
    public partial class AseV3NetworkingConfigurationData : ResourceData
    {
        /// <summary> Initializes a new instance of AseV3NetworkingConfigurationData. </summary>
        public AseV3NetworkingConfigurationData()
        {
            WindowsOutboundIPAddresses = new ChangeTrackingList<IPAddress>();
            LinuxOutboundIPAddresses = new ChangeTrackingList<IPAddress>();
            ExternalInboundIPAddresses = new ChangeTrackingList<IPAddress>();
            InternalInboundIPAddresses = new ChangeTrackingList<IPAddress>();
        }

        /// <summary> Initializes a new instance of AseV3NetworkingConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="windowsOutboundIPAddresses"></param>
        /// <param name="linuxOutboundIPAddresses"></param>
        /// <param name="externalInboundIPAddresses"></param>
        /// <param name="internalInboundIPAddresses"></param>
        /// <param name="allowNewPrivateEndpointConnections"> Property to enable and disable new private endpoint connection creation on ASE. </param>
        /// <param name="ftpEnabled"> Property to enable and disable FTP on ASEV3. </param>
        /// <param name="remoteDebugEnabled"> Property to enable and disable Remote Debug on ASEV3. </param>
        /// <param name="inboundIPAddressOverride"> Customer provided Inbound IP Address. Only able to be set on Ase create. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AseV3NetworkingConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<IPAddress> windowsOutboundIPAddresses, IReadOnlyList<IPAddress> linuxOutboundIPAddresses, IReadOnlyList<IPAddress> externalInboundIPAddresses, IReadOnlyList<IPAddress> internalInboundIPAddresses, bool? allowNewPrivateEndpointConnections, bool? ftpEnabled, bool? remoteDebugEnabled, string inboundIPAddressOverride, string kind) : base(id, name, resourceType, systemData)
        {
            WindowsOutboundIPAddresses = windowsOutboundIPAddresses;
            LinuxOutboundIPAddresses = linuxOutboundIPAddresses;
            ExternalInboundIPAddresses = externalInboundIPAddresses;
            InternalInboundIPAddresses = internalInboundIPAddresses;
            AllowNewPrivateEndpointConnections = allowNewPrivateEndpointConnections;
            FtpEnabled = ftpEnabled;
            RemoteDebugEnabled = remoteDebugEnabled;
            InboundIPAddressOverride = inboundIPAddressOverride;
            Kind = kind;
        }

        /// <summary> Gets the windows outbound ip addresses. </summary>
        public IReadOnlyList<IPAddress> WindowsOutboundIPAddresses { get; }
        /// <summary> Gets the linux outbound ip addresses. </summary>
        public IReadOnlyList<IPAddress> LinuxOutboundIPAddresses { get; }
        /// <summary> Gets the external inbound ip addresses. </summary>
        public IReadOnlyList<IPAddress> ExternalInboundIPAddresses { get; }
        /// <summary> Gets the internal inbound ip addresses. </summary>
        public IReadOnlyList<IPAddress> InternalInboundIPAddresses { get; }
        /// <summary> Property to enable and disable new private endpoint connection creation on ASE. </summary>
        public bool? AllowNewPrivateEndpointConnections { get; set; }
        /// <summary> Property to enable and disable FTP on ASEV3. </summary>
        public bool? FtpEnabled { get; set; }
        /// <summary> Property to enable and disable Remote Debug on ASEV3. </summary>
        public bool? RemoteDebugEnabled { get; set; }
        /// <summary> Customer provided Inbound IP Address. Only able to be set on Ase create. </summary>
        public string InboundIPAddressOverride { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
