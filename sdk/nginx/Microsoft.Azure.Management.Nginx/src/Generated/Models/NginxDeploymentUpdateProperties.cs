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

    public partial class NginxDeploymentUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the NginxDeploymentUpdateProperties
        /// class.
        /// </summary>
        public NginxDeploymentUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NginxDeploymentUpdateProperties
        /// class.
        /// </summary>
        public NginxDeploymentUpdateProperties(bool? enableDiagnosticsSupport = default(bool?), NginxLogging logging = default(NginxLogging), NginxDeploymentScalingProperties scalingProperties = default(NginxDeploymentScalingProperties), NginxDeploymentUserProfile userProfile = default(NginxDeploymentUserProfile))
        {
            EnableDiagnosticsSupport = enableDiagnosticsSupport;
            Logging = logging;
            ScalingProperties = scalingProperties;
            UserProfile = userProfile;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enableDiagnosticsSupport")]
        public bool? EnableDiagnosticsSupport { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logging")]
        public NginxLogging Logging { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scalingProperties")]
        public NginxDeploymentScalingProperties ScalingProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userProfile")]
        public NginxDeploymentUserProfile UserProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UserProfile != null)
            {
                UserProfile.Validate();
            }
        }
    }
}
