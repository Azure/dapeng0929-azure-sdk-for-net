// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An update to an Instance pool. </summary>
    public partial class InstancePoolPatch
    {
        /// <summary> Initializes a new instance of InstancePoolPatch. </summary>
        public InstancePoolPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The name and tier of the SKU. </summary>
        public SqlSku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Resource ID of the subnet to place this instance pool in. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Count of vCores belonging to this instance pool. </summary>
        public int? VCores { get; set; }
        /// <summary> The license type. Possible values are 'LicenseIncluded' (price for SQL license is included) and 'BasePrice' (without SQL license price). </summary>
        public InstancePoolLicenseType? LicenseType { get; set; }
        /// <summary> The Dns Zone that the managed instance pool is in. </summary>
        public string DnsZone { get; }
        /// <summary> Specifies maintenance configuration id to apply to this managed instance. </summary>
        public ResourceIdentifier MaintenanceConfigurationId { get; set; }
    }
}
