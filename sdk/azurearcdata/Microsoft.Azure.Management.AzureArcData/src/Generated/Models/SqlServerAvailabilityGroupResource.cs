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
    /// Arc Sql Server Availability Group
    /// </summary>
    public partial class SqlServerAvailabilityGroupResource : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SqlServerAvailabilityGroupResource class.
        /// </summary>
        public SqlServerAvailabilityGroupResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SqlServerAvailabilityGroupResource class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="properties">Properties of Arc Sql Server availability
        /// group</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="tags">Resource tags.</param>
        public SqlServerAvailabilityGroupResource(string location, SqlServerAvailabilityGroupResourceProperties properties, string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(location, id, name, type, systemData, tags)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of Arc Sql Server availability group
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SqlServerAvailabilityGroupResourceProperties Properties { get; set; }

    }
}
