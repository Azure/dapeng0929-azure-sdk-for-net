// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> SaaS subscription details of a Grafana instance. </summary>
    public partial class SaasSubscriptionDetails
    {
        /// <summary> Initializes a new instance of SaasSubscriptionDetails. </summary>
        internal SaasSubscriptionDetails()
        {
        }

        /// <summary> Initializes a new instance of SaasSubscriptionDetails. </summary>
        /// <param name="planId"> The plan Id of the SaaS subscription. </param>
        /// <param name="offerId"> The offer Id of the SaaS subscription. </param>
        /// <param name="publisherId"> The publisher Id of the SaaS subscription. </param>
        /// <param name="term"> The billing term of the SaaS Subscription. </param>
        internal SaasSubscriptionDetails(string planId, string offerId, string publisherId, SubscriptionTerm term)
        {
            PlanId = planId;
            OfferId = offerId;
            PublisherId = publisherId;
            Term = term;
        }

        /// <summary> The plan Id of the SaaS subscription. </summary>
        public string PlanId { get; }
        /// <summary> The offer Id of the SaaS subscription. </summary>
        public string OfferId { get; }
        /// <summary> The publisher Id of the SaaS subscription. </summary>
        public string PublisherId { get; }
        /// <summary> The billing term of the SaaS Subscription. </summary>
        public SubscriptionTerm Term { get; }
    }
}
