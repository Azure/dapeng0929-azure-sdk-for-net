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
    using System.Linq;

    /// <summary>
    /// Internet Ingress Public Ip Properties
    /// </summary>
    /// <remarks>
    /// Resource Uri of Public Ip for Standard Load Balancer Frontend End.
    /// </remarks>
    public partial class InternetIngressPublicIpsProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InternetIngressPublicIpsProperties class.
        /// </summary>
        public InternetIngressPublicIpsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InternetIngressPublicIpsProperties class.
        /// </summary>
        /// <param name="id">Resource Uri of Public Ip</param>
        public InternetIngressPublicIpsProperties(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource Uri of Public Ip
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
