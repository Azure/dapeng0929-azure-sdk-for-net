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
    /// The properties of a Site Recovery Manager (SRM) addon
    /// </summary>
    [Newtonsoft.Json.JsonObject("SRM")]
    public partial class AddonSrmProperties : AddonProperties
    {
        /// <summary>
        /// Initializes a new instance of the AddonSrmProperties class.
        /// </summary>
        public AddonSrmProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddonSrmProperties class.
        /// </summary>
        /// <param name="provisioningState">The state of the addon
        /// provisioning. Possible values include: 'Succeeded', 'Failed',
        /// 'Canceled', 'Cancelled', 'Building', 'Deleting', 'Updating'</param>
        /// <param name="licenseKey">The Site Recovery Manager (SRM)
        /// license</param>
        public AddonSrmProperties(string provisioningState = default(string), string licenseKey = default(string))
            : base(provisioningState)
        {
            LicenseKey = licenseKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Site Recovery Manager (SRM) license
        /// </summary>
        [JsonProperty(PropertyName = "licenseKey")]
        public string LicenseKey { get; set; }

    }
}
