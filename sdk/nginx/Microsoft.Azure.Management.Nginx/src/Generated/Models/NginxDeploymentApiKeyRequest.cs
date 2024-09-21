// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Nginx.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NginxDeploymentApiKeyRequest : IResource
    {
        /// <summary>
        /// Initializes a new instance of the NginxDeploymentApiKeyRequest
        /// class.
        /// </summary>
        public NginxDeploymentApiKeyRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NginxDeploymentApiKeyRequest
        /// class.
        /// </summary>
        public NginxDeploymentApiKeyRequest(string id = default(string), string name = default(string), string type = default(string), NginxDeploymentApiKeyRequestProperties properties = default(NginxDeploymentApiKeyRequestProperties))
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public NginxDeploymentApiKeyRequestProperties Properties { get; set; }

    }
}
