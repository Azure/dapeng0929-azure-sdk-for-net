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
    using Newtonsoft.Json;
    using System.Linq;

    public partial class NginxDeploymentApiKeyResponseProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NginxDeploymentApiKeyResponseProperties class.
        /// </summary>
        public NginxDeploymentApiKeyResponseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NginxDeploymentApiKeyResponseProperties class.
        /// </summary>
        /// <param name="hint">The first three characters of the secret text to
        /// help identify it in use. This property is read-only.</param>
        /// <param name="endDateTime">The time after which this Dataplane API
        /// Key is no longer valid.</param>
        public NginxDeploymentApiKeyResponseProperties(string hint = default(string), System.DateTime? endDateTime = default(System.DateTime?))
        {
            Hint = hint;
            EndDateTime = endDateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the first three characters of the secret text to help identify
        /// it in use. This property is read-only.
        /// </summary>
        [JsonProperty(PropertyName = "hint")]
        public string Hint { get; private set; }

        /// <summary>
        /// Gets or sets the time after which this Dataplane API Key is no
        /// longer valid.
        /// </summary>
        [JsonProperty(PropertyName = "endDateTime")]
        public System.DateTime? EndDateTime { get; set; }

    }
}
