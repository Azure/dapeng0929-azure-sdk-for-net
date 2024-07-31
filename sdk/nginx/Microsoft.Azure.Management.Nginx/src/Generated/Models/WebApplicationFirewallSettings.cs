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

    /// <summary>
    /// Settings for the NGINX App Protect Web Application Firewall (WAF)
    /// </summary>
    public partial class WebApplicationFirewallSettings
    {
        /// <summary>
        /// Initializes a new instance of the WebApplicationFirewallSettings
        /// class.
        /// </summary>
        public WebApplicationFirewallSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebApplicationFirewallSettings
        /// class.
        /// </summary>
        /// <param name="activationState">The activation state of the WAF. Use
        /// 'Enabled' to enable the WAF and 'Disabled' to disable it. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        public WebApplicationFirewallSettings(string activationState = default(string))
        {
            ActivationState = activationState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the activation state of the WAF. Use 'Enabled' to
        /// enable the WAF and 'Disabled' to disable it. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "activationState")]
        public string ActivationState { get; set; }

    }
}
