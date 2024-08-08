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

    public partial class BastionHostPropertiesFormatNetworkAcls
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BastionHostPropertiesFormatNetworkAcls class.
        /// </summary>
        public BastionHostPropertiesFormatNetworkAcls()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BastionHostPropertiesFormatNetworkAcls class.
        /// </summary>
        /// <param name="ipRules">Sets the IP ACL rules for Developer Bastion
        /// Host.</param>
        public BastionHostPropertiesFormatNetworkAcls(IList<IPRule> ipRules = default(IList<IPRule>))
        {
            IpRules = ipRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sets the IP ACL rules for Developer Bastion Host.
        /// </summary>
        [JsonProperty(PropertyName = "ipRules")]
        public IList<IPRule> IpRules { get; set; }

    }
}
