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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VIP swap request's frontend IP configuration object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LoadBalancerVipSwapRequestFrontendIPConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LoadBalancerVipSwapRequestFrontendIPConfiguration class.
        /// </summary>
        public LoadBalancerVipSwapRequestFrontendIPConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LoadBalancerVipSwapRequestFrontendIPConfiguration class.
        /// </summary>
        /// <param name="id">The ID of frontend IP configuration
        /// resource.</param>
        /// <param name="publicIPAddress">A reference to public IP address
        /// resource.</param>
        public LoadBalancerVipSwapRequestFrontendIPConfiguration(string id = default(string), SubResource publicIPAddress = default(SubResource))
        {
            Id = id;
            PublicIPAddress = publicIPAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of frontend IP configuration resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a reference to public IP address resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

    }
}
