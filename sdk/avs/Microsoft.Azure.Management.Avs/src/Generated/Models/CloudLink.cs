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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A cloud link resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CloudLink : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the CloudLink class.
        /// </summary>
        public CloudLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudLink class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. E.g.
        /// "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="systemData">Azure Resource Manager metadata containing
        /// createdBy and modifiedBy information.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Failed',
        /// 'Canceled'</param>
        /// <param name="status">The state of the cloud link. Possible values
        /// include: 'Active', 'Building', 'Deleting', 'Failed',
        /// 'Disconnected'</param>
        /// <param name="linkedCloud">Identifier of the other private cloud
        /// participating in the link.</param>
        public CloudLink(string id = default(string), string name = default(string), string type = default(string), SystemData systemData = default(SystemData), string provisioningState = default(string), string status = default(string), string linkedCloud = default(string))
            : base(id, name, type, systemData)
        {
            ProvisioningState = provisioningState;
            Status = status;
            LinkedCloud = linkedCloud;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values
        /// include: 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the state of the cloud link. Possible values include:
        /// 'Active', 'Building', 'Deleting', 'Failed', 'Disconnected'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or sets identifier of the other private cloud participating in
        /// the link.
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkedCloud")]
        public string LinkedCloud { get; set; }

    }
}
