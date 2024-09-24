// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureArcData.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Failover Cluster Instance properties.
    /// </summary>
    public partial class FailoverCluster
    {
        /// <summary>
        /// Initializes a new instance of the FailoverCluster class.
        /// </summary>
        public FailoverCluster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FailoverCluster class.
        /// </summary>
        /// <param name="id">The GUID of the SQL Server's underlying Failover
        /// Cluster.</param>
        /// <param name="networkName">The network name to connect to the SQL
        /// FCI.</param>
        /// <param name="sqlInstanceIds">The ARM IDs of the Arc SQL Server
        /// resources, belonging to the current server's Failover
        /// cluster.</param>
        /// <param name="hostNames">The host names which are part of the SQL
        /// FCI resource group.</param>
        public FailoverCluster(string id = default(string), string networkName = default(string), IList<string> sqlInstanceIds = default(IList<string>), IList<string> hostNames = default(IList<string>))
        {
            Id = id;
            NetworkName = networkName;
            SqlInstanceIds = sqlInstanceIds;
            HostNames = hostNames;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the GUID of the SQL Server's underlying Failover Cluster.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the network name to connect to the SQL FCI.
        /// </summary>
        [JsonProperty(PropertyName = "networkName")]
        public string NetworkName { get; private set; }

        /// <summary>
        /// Gets the ARM IDs of the Arc SQL Server resources, belonging to the
        /// current server's Failover cluster.
        /// </summary>
        [JsonProperty(PropertyName = "sqlInstanceIds")]
        public IList<string> SqlInstanceIds { get; private set; }

        /// <summary>
        /// Gets the host names which are part of the SQL FCI resource group.
        /// </summary>
        [JsonProperty(PropertyName = "hostNames")]
        public IList<string> HostNames { get; private set; }

    }
}
