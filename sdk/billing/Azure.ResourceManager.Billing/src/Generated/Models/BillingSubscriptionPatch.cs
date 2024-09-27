// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The billing properties of a subscription. </summary>
    public partial class BillingSubscriptionPatch : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionPatch"/>. </summary>
        public BillingSubscriptionPatch()
        {
            BillingPolicies = new ChangeTrackingDictionary<string, string>();
            SuspensionReasons = new ChangeTrackingList<string>();
            SuspensionReasonDetails = new ChangeTrackingList<BillingSubscriptionStatusDetails>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="BillingSubscriptionPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="autoRenew"> Indicates whether auto renewal is turned on or off for a product. </param>
        /// <param name="beneficiaryTenantId"> The provisioning tenant of the subscription. </param>
        /// <param name="beneficiary"> The beneficiary of the billing subscription. </param>
        /// <param name="billingFrequency"> The billing frequency in ISO8601 format of product in the subscription. Example: P1M, P3M, P1Y. </param>
        /// <param name="billingProfileId"> The fully qualified ID that uniquely identifies a billing profile. </param>
        /// <param name="billingPolicies"> Dictionary of billing policies associated with the subscription. </param>
        /// <param name="billingProfileDisplayName"> The name of the billing profile. </param>
        /// <param name="billingProfileName"> The ID that uniquely identifies a billing profile. </param>
        /// <param name="consumptionCostCenter"> The cost center applied to the subscription. This field is only available for consumption subscriptions of Microsoft Customer Agreement or Enterprise Agreement Type billing accounts. </param>
        /// <param name="customerId"> The fully qualified ID that uniquely identifies a customer. </param>
        /// <param name="customerDisplayName"> The name of the customer. </param>
        /// <param name="customerName"> The ID that uniquely identifies a customer. </param>
        /// <param name="displayName"> The name of the billing subscription. </param>
        /// <param name="enrollmentAccountId"> The enrollment Account ID associated with the subscription. This field is available only for the Enterprise Agreement Type billing accounts. </param>
        /// <param name="enrollmentAccountDisplayName"> The enrollment Account name associated with the subscription. This field is available only for the Enterprise Agreement Type billing accounts. </param>
        /// <param name="invoiceSectionId"> The fully qualified ID that uniquely identifies an invoice section. </param>
        /// <param name="invoiceSectionDisplayName"> The name of the invoice section. </param>
        /// <param name="invoiceSectionName"> The ID that uniquely identifies an invoice section. </param>
        /// <param name="lastMonthCharges"> The last month's charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="monthToDateCharges"> The current month to date charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </param>
        /// <param name="nextBillingCycleDetails"> Next billing cycle details of the subscription. </param>
        /// <param name="offerId"> The offer ID for the subscription. This field is only available for the Microsoft Online Services Program billing accounts or billing accounts with agreement type Enterprise Agreement. </param>
        /// <param name="productCategory"> The category of the product for which the subscription is purchased. Possible values include: AzureSupport, Hardware, ReservationOrder, SaaS, SavingsPlanOrder, Software, UsageBased, Other. </param>
        /// <param name="productType"> Type of the product for which the subscription is purchased. </param>
        /// <param name="productTypeId"> Id of the product for which the subscription is purchased. </param>
        /// <param name="purchaseOn"> Purchase date of the product in UTC time. </param>
        /// <param name="quantity"> The quantity of licenses or fulfillment units for the subscription. </param>
        /// <param name="reseller"> Reseller for this subscription. The fields is not available for Microsoft Partner Agreement billing accounts. </param>
        /// <param name="renewalTermDetails"> Details for the next renewal term of a subscription. </param>
        /// <param name="skuId"> The SKU ID of the product for which the subscription is purchased. This field is is only available  for Microsoft Customer Agreement billing accounts. </param>
        /// <param name="skuDescription"> The SKU description of the product for which the subscription is purchased. This field is is only available for billing accounts with agreement type Microsoft Customer Agreement and Microsoft Partner Agreement. </param>
        /// <param name="systemOverrides"> System imposed policies that regulate behavior of the subscription. </param>
        /// <param name="resourceUri"> Unique identifier of the linked resource. </param>
        /// <param name="termDuration"> The duration in ISO8601 format for which you can use the subscription. Example: P1M, P3M, P1Y. </param>
        /// <param name="termStartOn"> Start date of the term in UTC time. </param>
        /// <param name="termEndOn"> End date of the term in UTC time. </param>
        /// <param name="provisioningTenantId"> The tenant in which the subscription is provisioned. </param>
        /// <param name="status"> The status of the subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="operationStatus"> The status of an operation on the subscription. When None, there is no ongoing operation. When LockedForUpdate, write operations will be blocked on the Billing Subscription. Other is the default value and you may need to refer to the latest API version for more details. </param>
        /// <param name="provisioningState"> The provisioning state of the resource during a long-running operation. </param>
        /// <param name="subscriptionId"> The ID of the subscription. </param>
        /// <param name="suspensionReasons"> The suspension reason for a subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="suspensionReasonDetails"> The suspension details for a subscription. This field is not available for Enterprise Agreement billing accounts. </param>
        /// <param name="enrollmentAccountStartOn"> The enrollment Account and the subscription association start date. This field is available only for the Enterprise Agreement Type. </param>
        /// <param name="subscriptionEnrollmentAccountStatus"> The current enrollment account status of the subscription. This field is available only for the Enterprise Agreement Type. </param>
        /// <param name="tags"> Dictionary of metadata associated with the resource. It may not be populated for all resource types. Maximum key/value length supported of 256 characters. Keys/value should not empty value nor null. Keys can not contain &lt; &gt; % &amp; \ ? /. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BillingSubscriptionPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BillingSubscriptionAutoRenewState? autoRenew, Guid? beneficiaryTenantId, BillingBeneficiary beneficiary, string billingFrequency, ResourceIdentifier billingProfileId, IReadOnlyDictionary<string, string> billingPolicies, string billingProfileDisplayName, string billingProfileName, string consumptionCostCenter, string customerId, string customerDisplayName, string customerName, string displayName, string enrollmentAccountId, string enrollmentAccountDisplayName, ResourceIdentifier invoiceSectionId, string invoiceSectionDisplayName, string invoiceSectionName, BillingAmount lastMonthCharges, BillingAmount monthToDateCharges, NextBillingCycleDetails nextBillingCycleDetails, string offerId, string productCategory, string productType, string productTypeId, DateTimeOffset? purchaseOn, long? quantity, CreatedSubscriptionReseller reseller, SubscriptionRenewalTermDetails renewalTermDetails, string skuId, string skuDescription, BillingSystemOverrides systemOverrides, Uri resourceUri, TimeSpan? termDuration, DateTimeOffset? termStartOn, DateTimeOffset? termEndOn, Guid? provisioningTenantId, BillingSubscriptionStatus? status, BillingSubscriptionOperationStatus? operationStatus, BillingProvisioningState? provisioningState, string subscriptionId, IReadOnlyList<string> suspensionReasons, IReadOnlyList<BillingSubscriptionStatusDetails> suspensionReasonDetails, DateTimeOffset? enrollmentAccountStartOn, SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            AutoRenew = autoRenew;
            BeneficiaryTenantId = beneficiaryTenantId;
            Beneficiary = beneficiary;
            BillingFrequency = billingFrequency;
            BillingProfileId = billingProfileId;
            BillingPolicies = billingPolicies;
            BillingProfileDisplayName = billingProfileDisplayName;
            BillingProfileName = billingProfileName;
            ConsumptionCostCenter = consumptionCostCenter;
            CustomerId = customerId;
            CustomerDisplayName = customerDisplayName;
            CustomerName = customerName;
            DisplayName = displayName;
            EnrollmentAccountId = enrollmentAccountId;
            EnrollmentAccountDisplayName = enrollmentAccountDisplayName;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionDisplayName = invoiceSectionDisplayName;
            InvoiceSectionName = invoiceSectionName;
            LastMonthCharges = lastMonthCharges;
            MonthToDateCharges = monthToDateCharges;
            NextBillingCycleDetails = nextBillingCycleDetails;
            OfferId = offerId;
            ProductCategory = productCategory;
            ProductType = productType;
            ProductTypeId = productTypeId;
            PurchaseOn = purchaseOn;
            Quantity = quantity;
            Reseller = reseller;
            RenewalTermDetails = renewalTermDetails;
            SkuId = skuId;
            SkuDescription = skuDescription;
            SystemOverrides = systemOverrides;
            ResourceUri = resourceUri;
            TermDuration = termDuration;
            TermStartOn = termStartOn;
            TermEndOn = termEndOn;
            ProvisioningTenantId = provisioningTenantId;
            Status = status;
            OperationStatus = operationStatus;
            ProvisioningState = provisioningState;
            SubscriptionId = subscriptionId;
            SuspensionReasons = suspensionReasons;
            SuspensionReasonDetails = suspensionReasonDetails;
            EnrollmentAccountStartOn = enrollmentAccountStartOn;
            SubscriptionEnrollmentAccountStatus = subscriptionEnrollmentAccountStatus;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether auto renewal is turned on or off for a product. </summary>
        [WirePath("properties.autoRenew")]
        public BillingSubscriptionAutoRenewState? AutoRenew { get; set; }
        /// <summary> The provisioning tenant of the subscription. </summary>
        [WirePath("properties.beneficiaryTenantId")]
        public Guid? BeneficiaryTenantId { get; set; }
        /// <summary> The beneficiary of the billing subscription. </summary>
        [WirePath("properties.beneficiary")]
        public BillingBeneficiary Beneficiary { get; set; }
        /// <summary> The billing frequency in ISO8601 format of product in the subscription. Example: P1M, P3M, P1Y. </summary>
        [WirePath("properties.billingFrequency")]
        public string BillingFrequency { get; set; }
        /// <summary> The fully qualified ID that uniquely identifies a billing profile. </summary>
        [WirePath("properties.billingProfileId")]
        public ResourceIdentifier BillingProfileId { get; set; }
        /// <summary> Dictionary of billing policies associated with the subscription. </summary>
        [WirePath("properties.billingPolicies")]
        public IReadOnlyDictionary<string, string> BillingPolicies { get; }
        /// <summary> The name of the billing profile. </summary>
        [WirePath("properties.billingProfileDisplayName")]
        public string BillingProfileDisplayName { get; }
        /// <summary> The ID that uniquely identifies a billing profile. </summary>
        [WirePath("properties.billingProfileName")]
        public string BillingProfileName { get; }
        /// <summary> The cost center applied to the subscription. This field is only available for consumption subscriptions of Microsoft Customer Agreement or Enterprise Agreement Type billing accounts. </summary>
        [WirePath("properties.consumptionCostCenter")]
        public string ConsumptionCostCenter { get; set; }
        /// <summary> The fully qualified ID that uniquely identifies a customer. </summary>
        [WirePath("properties.customerId")]
        public string CustomerId { get; set; }
        /// <summary> The name of the customer. </summary>
        [WirePath("properties.customerDisplayName")]
        public string CustomerDisplayName { get; }
        /// <summary> The ID that uniquely identifies a customer. </summary>
        [WirePath("properties.customerName")]
        public string CustomerName { get; }
        /// <summary> The name of the billing subscription. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> The enrollment Account ID associated with the subscription. This field is available only for the Enterprise Agreement Type billing accounts. </summary>
        [WirePath("properties.enrollmentAccountId")]
        public string EnrollmentAccountId { get; }
        /// <summary> The enrollment Account name associated with the subscription. This field is available only for the Enterprise Agreement Type billing accounts. </summary>
        [WirePath("properties.enrollmentAccountDisplayName")]
        public string EnrollmentAccountDisplayName { get; }
        /// <summary> The fully qualified ID that uniquely identifies an invoice section. </summary>
        [WirePath("properties.invoiceSectionId")]
        public ResourceIdentifier InvoiceSectionId { get; set; }
        /// <summary> The name of the invoice section. </summary>
        [WirePath("properties.invoiceSectionDisplayName")]
        public string InvoiceSectionDisplayName { get; }
        /// <summary> The ID that uniquely identifies an invoice section. </summary>
        [WirePath("properties.invoiceSectionName")]
        public string InvoiceSectionName { get; }
        /// <summary> The last month's charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </summary>
        [WirePath("properties.lastMonthCharges")]
        public BillingAmount LastMonthCharges { get; }
        /// <summary> The current month to date charges. This field is only available for usage based subscriptions of Microsoft Customer Agreement billing accounts. </summary>
        [WirePath("properties.monthToDateCharges")]
        public BillingAmount MonthToDateCharges { get; }
        /// <summary> Next billing cycle details of the subscription. </summary>
        internal NextBillingCycleDetails NextBillingCycleDetails { get; }
        /// <summary> Billing frequency of the product under the subscription. </summary>
        [WirePath("properties.nextBillingCycleDetails.billingFrequency")]
        public string NextBillingCycleBillingFrequency
        {
            get => NextBillingCycleDetails?.NextBillingCycleBillingFrequency;
        }

        /// <summary> The offer ID for the subscription. This field is only available for the Microsoft Online Services Program billing accounts or billing accounts with agreement type Enterprise Agreement. </summary>
        [WirePath("properties.offerId")]
        public string OfferId { get; }
        /// <summary> The category of the product for which the subscription is purchased. Possible values include: AzureSupport, Hardware, ReservationOrder, SaaS, SavingsPlanOrder, Software, UsageBased, Other. </summary>
        [WirePath("properties.productCategory")]
        public string ProductCategory { get; }
        /// <summary> Type of the product for which the subscription is purchased. </summary>
        [WirePath("properties.productType")]
        public string ProductType { get; }
        /// <summary> Id of the product for which the subscription is purchased. </summary>
        [WirePath("properties.productTypeId")]
        public string ProductTypeId { get; set; }
        /// <summary> Purchase date of the product in UTC time. </summary>
        [WirePath("properties.purchaseDate")]
        public DateTimeOffset? PurchaseOn { get; }
        /// <summary> The quantity of licenses or fulfillment units for the subscription. </summary>
        [WirePath("properties.quantity")]
        public long? Quantity { get; set; }
        /// <summary> Reseller for this subscription. The fields is not available for Microsoft Partner Agreement billing accounts. </summary>
        [WirePath("properties.reseller")]
        public CreatedSubscriptionReseller Reseller { get; }
        /// <summary> Details for the next renewal term of a subscription. </summary>
        [WirePath("properties.renewalTermDetails")]
        public SubscriptionRenewalTermDetails RenewalTermDetails { get; }
        /// <summary> The SKU ID of the product for which the subscription is purchased. This field is is only available  for Microsoft Customer Agreement billing accounts. </summary>
        [WirePath("properties.skuId")]
        public string SkuId { get; set; }
        /// <summary> The SKU description of the product for which the subscription is purchased. This field is is only available for billing accounts with agreement type Microsoft Customer Agreement and Microsoft Partner Agreement. </summary>
        [WirePath("properties.skuDescription")]
        public string SkuDescription { get; }
        /// <summary> System imposed policies that regulate behavior of the subscription. </summary>
        [WirePath("properties.systemOverrides")]
        public BillingSystemOverrides SystemOverrides { get; set; }
        /// <summary> Unique identifier of the linked resource. </summary>
        [WirePath("properties.resourceUri")]
        public Uri ResourceUri { get; }
        /// <summary> The duration in ISO8601 format for which you can use the subscription. Example: P1M, P3M, P1Y. </summary>
        [WirePath("properties.termDuration")]
        public TimeSpan? TermDuration { get; set; }
        /// <summary> Start date of the term in UTC time. </summary>
        [WirePath("properties.termStartDate")]
        public DateTimeOffset? TermStartOn { get; }
        /// <summary> End date of the term in UTC time. </summary>
        [WirePath("properties.termEndDate")]
        public DateTimeOffset? TermEndOn { get; }
        /// <summary> The tenant in which the subscription is provisioned. </summary>
        [WirePath("properties.provisioningTenantId")]
        public Guid? ProvisioningTenantId { get; set; }
        /// <summary> The status of the subscription. This field is not available for Enterprise Agreement billing accounts. </summary>
        [WirePath("properties.status")]
        public BillingSubscriptionStatus? Status { get; }
        /// <summary> The status of an operation on the subscription. When None, there is no ongoing operation. When LockedForUpdate, write operations will be blocked on the Billing Subscription. Other is the default value and you may need to refer to the latest API version for more details. </summary>
        [WirePath("properties.operationStatus")]
        public BillingSubscriptionOperationStatus? OperationStatus { get; }
        /// <summary> The provisioning state of the resource during a long-running operation. </summary>
        [WirePath("properties.provisioningState")]
        public BillingProvisioningState? ProvisioningState { get; }
        /// <summary> The ID of the subscription. </summary>
        [WirePath("properties.subscriptionId")]
        public string SubscriptionId { get; }
        /// <summary> The suspension reason for a subscription. This field is not available for Enterprise Agreement billing accounts. </summary>
        [WirePath("properties.suspensionReasons")]
        public IReadOnlyList<string> SuspensionReasons { get; }
        /// <summary> The suspension details for a subscription. This field is not available for Enterprise Agreement billing accounts. </summary>
        [WirePath("properties.suspensionReasonDetails")]
        public IReadOnlyList<BillingSubscriptionStatusDetails> SuspensionReasonDetails { get; }
        /// <summary> The enrollment Account and the subscription association start date. This field is available only for the Enterprise Agreement Type. </summary>
        [WirePath("properties.enrollmentAccountStartDate")]
        public DateTimeOffset? EnrollmentAccountStartOn { get; }
        /// <summary> The current enrollment account status of the subscription. This field is available only for the Enterprise Agreement Type. </summary>
        [WirePath("properties.subscriptionEnrollmentAccountStatus")]
        public SubscriptionEnrollmentAccountStatus? SubscriptionEnrollmentAccountStatus { get; }
        /// <summary> Dictionary of metadata associated with the resource. It may not be populated for all resource types. Maximum key/value length supported of 256 characters. Keys/value should not empty value nor null. Keys can not contain &lt; &gt; % &amp; \ ? /. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
    }
}
