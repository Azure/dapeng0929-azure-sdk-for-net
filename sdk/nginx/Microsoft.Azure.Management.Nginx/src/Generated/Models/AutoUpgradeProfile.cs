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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Autoupgrade settings of a deployment.
    /// </summary>
    public partial class AutoUpgradeProfile
    {
        /// <summary>
        /// Initializes a new instance of the AutoUpgradeProfile class.
        /// </summary>
        public AutoUpgradeProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoUpgradeProfile class.
        /// </summary>
        /// <param name="upgradeChannel">Channel used for autoupgrade.</param>
        public AutoUpgradeProfile(string upgradeChannel)
        {
            UpgradeChannel = upgradeChannel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets channel used for autoupgrade.
        /// </summary>
        [JsonProperty(PropertyName = "upgradeChannel")]
        public string UpgradeChannel { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UpgradeChannel == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UpgradeChannel");
            }
        }
    }
}
