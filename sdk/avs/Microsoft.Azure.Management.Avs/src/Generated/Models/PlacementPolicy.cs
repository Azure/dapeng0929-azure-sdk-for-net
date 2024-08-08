// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A vSphere Distributed Resource Scheduler (DRS) placement policy
    /// </summary>
    public partial class PlacementPolicy : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the PlacementPolicy class.
        /// </summary>
        public PlacementPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlacementPolicy class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. E.g.
        /// "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="properties">The resource-specific properties for this
        /// resource.</param>
        public PlacementPolicy(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), PlacementPolicyProperties properties = default(PlacementPolicyProperties))
            : base(id, name, type, systemData)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource-specific properties for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PlacementPolicyProperties Properties { get; set; }

    }
}
