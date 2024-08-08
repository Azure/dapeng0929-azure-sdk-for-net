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
    /// The network group resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NetworkGroup : ChildResource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkGroup class.
        /// </summary>
        public NetworkGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkGroup class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="description">A description of the network
        /// group.</param>
        /// <param name="provisioningState">The provisioning state of the scope
        /// assignment resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="resourceGuid">Unique identifier for this
        /// resource.</param>
        /// <param name="systemData">The system metadata related to this
        /// resource.</param>
        public NetworkGroup(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), string description = default(string), string provisioningState = default(string), string resourceGuid = default(string), SystemData systemData = default(SystemData))
            : base(id, name, type, etag)
        {
            Description = description;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a description of the network group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the provisioning state of the scope assignment resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets unique identifier for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the system metadata related to this resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

    }
}
