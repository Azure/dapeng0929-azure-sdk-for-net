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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Firewall Policy Insights.
    /// </summary>
    public partial class FirewallPolicyInsights
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPolicyInsights class.
        /// </summary>
        public FirewallPolicyInsights()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPolicyInsights class.
        /// </summary>
        /// <param name="isEnabled">A flag to indicate if the insights are
        /// enabled on the policy.</param>
        /// <param name="retentionDays">Number of days the insights should be
        /// enabled on the policy.</param>
        /// <param name="logAnalyticsResources">Workspaces needed to configure
        /// the Firewall Policy Insights.</param>
        public FirewallPolicyInsights(bool? isEnabled = default(bool?), int? retentionDays = default(int?), FirewallPolicyLogAnalyticsResources logAnalyticsResources = default(FirewallPolicyLogAnalyticsResources))
        {
            IsEnabled = isEnabled;
            RetentionDays = retentionDays;
            LogAnalyticsResources = logAnalyticsResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a flag to indicate if the insights are enabled on the
        /// policy.
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets number of days the insights should be enabled on the
        /// policy.
        /// </summary>
        [JsonProperty(PropertyName = "retentionDays")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Gets or sets workspaces needed to configure the Firewall Policy
        /// Insights.
        /// </summary>
        [JsonProperty(PropertyName = "logAnalyticsResources")]
        public FirewallPolicyLogAnalyticsResources LogAnalyticsResources { get; set; }

    }
}
