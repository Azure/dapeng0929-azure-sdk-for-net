// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VpnClientConfiguration for P2S client.
    /// </summary>
    public partial class VpnClientConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the VpnClientConfiguration class.
        /// </summary>
        public VpnClientConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VpnClientConfiguration class.
        /// </summary>
        /// <param name="vpnClientAddressPool">The reference to the address
        /// space resource which represents Address space for P2S
        /// VpnClient.</param>
        /// <param name="vpnClientRootCertificates">VpnClientRootCertificate
        /// for virtual network gateway.</param>
        /// <param
        /// name="vpnClientRevokedCertificates">VpnClientRevokedCertificate for
        /// Virtual network gateway.</param>
        /// <param name="vpnClientProtocols">VpnClientProtocols for Virtual
        /// network gateway.</param>
        /// <param name="vpnAuthenticationTypes">VPN authentication types for
        /// the virtual network gateway..</param>
        /// <param name="vpnClientIpsecPolicies">VpnClientIpsecPolicies for
        /// virtual network gateway P2S client.</param>
        /// <param name="radiusServerAddress">The radius server address
        /// property of the VirtualNetworkGateway resource for vpn client
        /// connection.</param>
        /// <param name="radiusServerSecret">The radius secret property of the
        /// VirtualNetworkGateway resource for vpn client connection.</param>
        /// <param name="radiusServers">The radiusServers property for multiple
        /// radius server configuration.</param>
        /// <param name="aadTenant">The AADTenant property of the
        /// VirtualNetworkGateway resource for vpn client connection used for
        /// AAD authentication.</param>
        /// <param name="aadAudience">The AADAudience property of the
        /// VirtualNetworkGateway resource for vpn client connection used for
        /// AAD authentication.</param>
        /// <param name="aadIssuer">The AADIssuer property of the
        /// VirtualNetworkGateway resource for vpn client connection used for
        /// AAD authentication.</param>
        /// <param name="vngClientConnectionConfigurations">per ip address pool
        /// connection policy for virtual network gateway P2S client.</param>
        public VpnClientConfiguration(AddressSpace vpnClientAddressPool = default(AddressSpace), IList<VpnClientRootCertificate> vpnClientRootCertificates = default(IList<VpnClientRootCertificate>), IList<VpnClientRevokedCertificate> vpnClientRevokedCertificates = default(IList<VpnClientRevokedCertificate>), IList<string> vpnClientProtocols = default(IList<string>), IList<string> vpnAuthenticationTypes = default(IList<string>), IList<IpsecPolicy> vpnClientIpsecPolicies = default(IList<IpsecPolicy>), string radiusServerAddress = default(string), string radiusServerSecret = default(string), IList<RadiusServer> radiusServers = default(IList<RadiusServer>), string aadTenant = default(string), string aadAudience = default(string), string aadIssuer = default(string), IList<VngClientConnectionConfiguration> vngClientConnectionConfigurations = default(IList<VngClientConnectionConfiguration>))
        {
            VpnClientAddressPool = vpnClientAddressPool;
            VpnClientRootCertificates = vpnClientRootCertificates;
            VpnClientRevokedCertificates = vpnClientRevokedCertificates;
            VpnClientProtocols = vpnClientProtocols;
            VpnAuthenticationTypes = vpnAuthenticationTypes;
            VpnClientIpsecPolicies = vpnClientIpsecPolicies;
            RadiusServerAddress = radiusServerAddress;
            RadiusServerSecret = radiusServerSecret;
            RadiusServers = radiusServers;
            AadTenant = aadTenant;
            AadAudience = aadAudience;
            AadIssuer = aadIssuer;
            VngClientConnectionConfigurations = vngClientConnectionConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the reference to the address space resource which
        /// represents Address space for P2S VpnClient.
        /// </summary>
        [JsonProperty(PropertyName = "vpnClientAddressPool")]
        public AddressSpace VpnClientAddressPool { get; set; }

        /// <summary>
        /// Gets or sets vpnClientRootCertificate for virtual network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "vpnClientRootCertificates")]
        public IList<VpnClientRootCertificate> VpnClientRootCertificates { get; set; }

        /// <summary>
        /// Gets or sets vpnClientRevokedCertificate for Virtual network
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "vpnClientRevokedCertificates")]
        public IList<VpnClientRevokedCertificate> VpnClientRevokedCertificates { get; set; }

        /// <summary>
        /// Gets or sets vpnClientProtocols for Virtual network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "vpnClientProtocols")]
        public IList<string> VpnClientProtocols { get; set; }

        /// <summary>
        /// Gets or sets VPN authentication types for the virtual network
        /// gateway..
        /// </summary>
        [JsonProperty(PropertyName = "vpnAuthenticationTypes")]
        public IList<string> VpnAuthenticationTypes { get; set; }

        /// <summary>
        /// Gets or sets vpnClientIpsecPolicies for virtual network gateway P2S
        /// client.
        /// </summary>
        [JsonProperty(PropertyName = "vpnClientIpsecPolicies")]
        public IList<IpsecPolicy> VpnClientIpsecPolicies { get; set; }

        /// <summary>
        /// Gets or sets the radius server address property of the
        /// VirtualNetworkGateway resource for vpn client connection.
        /// </summary>
        [JsonProperty(PropertyName = "radiusServerAddress")]
        public string RadiusServerAddress { get; set; }

        /// <summary>
        /// Gets or sets the radius secret property of the
        /// VirtualNetworkGateway resource for vpn client connection.
        /// </summary>
        [JsonProperty(PropertyName = "radiusServerSecret")]
        public string RadiusServerSecret { get; set; }

        /// <summary>
        /// Gets or sets the radiusServers property for multiple radius server
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "radiusServers")]
        public IList<RadiusServer> RadiusServers { get; set; }

        /// <summary>
        /// Gets or sets the AADTenant property of the VirtualNetworkGateway
        /// resource for vpn client connection used for AAD authentication.
        /// </summary>
        [JsonProperty(PropertyName = "aadTenant")]
        public string AadTenant { get; set; }

        /// <summary>
        /// Gets or sets the AADAudience property of the VirtualNetworkGateway
        /// resource for vpn client connection used for AAD authentication.
        /// </summary>
        [JsonProperty(PropertyName = "aadAudience")]
        public string AadAudience { get; set; }

        /// <summary>
        /// Gets or sets the AADIssuer property of the VirtualNetworkGateway
        /// resource for vpn client connection used for AAD authentication.
        /// </summary>
        [JsonProperty(PropertyName = "aadIssuer")]
        public string AadIssuer { get; set; }

        /// <summary>
        /// Gets or sets per ip address pool connection policy for virtual
        /// network gateway P2S client.
        /// </summary>
        [JsonProperty(PropertyName = "vngClientConnectionConfigurations")]
        public IList<VngClientConnectionConfiguration> VngClientConnectionConfigurations { get; set; }

    }
}
