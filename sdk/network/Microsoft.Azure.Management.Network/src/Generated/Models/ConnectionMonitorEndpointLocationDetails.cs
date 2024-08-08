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
    /// Connection monitor endpoint location details only being used for
    /// 'AzureArcNetwork' type endpoints, which contains the region details.
    /// </summary>
    public partial class ConnectionMonitorEndpointLocationDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionMonitorEndpointLocationDetails class.
        /// </summary>
        public ConnectionMonitorEndpointLocationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionMonitorEndpointLocationDetails class.
        /// </summary>
        /// <param name="region">Region for connection monitor
        /// endpoint.</param>
        public ConnectionMonitorEndpointLocationDetails(string region = default(string))
        {
            Region = region;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets region for connection monitor endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }

    }
}
