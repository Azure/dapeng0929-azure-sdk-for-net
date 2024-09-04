// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppServiceCertificateOrder data model.
    /// SSL certificate purchase order.
    /// </summary>
    public partial class AppServiceCertificateOrderData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="AppServiceCertificateOrderData"/>. </summary>
        /// <param name="location"> The location. </param>
        public AppServiceCertificateOrderData(AzureLocation location) : base(location)
        {
            Certificates = new ChangeTrackingDictionary<string, AppServiceCertificateProperties>();
            AppServiceCertificateNotRenewableReasons = new ChangeTrackingList<AppServiceCertificateNotRenewableReason>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceCertificateOrderData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="certificates"> State of the Key Vault secret. </param>
        /// <param name="distinguishedName"> Certificate distinguished name. </param>
        /// <param name="domainVerificationToken"> Domain verification token. </param>
        /// <param name="validityInYears"> Duration in years (must be 1). </param>
        /// <param name="keySize"> Certificate key size. </param>
        /// <param name="productType"> Certificate product type. </param>
        /// <param name="isAutoRenew"> &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="provisioningState"> Status of certificate order. </param>
        /// <param name="status"> Current order status. </param>
        /// <param name="signedCertificate"> Signed certificate. </param>
        /// <param name="csr"> Last CSR that was created for this order. </param>
        /// <param name="intermediate"> Intermediate certificate. </param>
        /// <param name="root"> Root certificate. </param>
        /// <param name="serialNumber"> Current serial number of the certificate. </param>
        /// <param name="lastCertificateIssuedOn"> Certificate last issuance time. </param>
        /// <param name="expireOn"> Certificate expiration time. </param>
        /// <param name="isPrivateKeyExternal"> &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="appServiceCertificateNotRenewableReasons"> Reasons why App Service Certificate is not renewable at the current moment. </param>
        /// <param name="nextAutoRenewTimeStamp"> Time stamp when the certificate would be auto renewed next. </param>
        /// <param name="contact"> Contact info. </param>
        /// <param name="kind"> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceCertificateOrderData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IDictionary<string, AppServiceCertificateProperties> certificates, string distinguishedName, string domainVerificationToken, int? validityInYears, int? keySize, CertificateProductType? productType, bool? isAutoRenew, ProvisioningState? provisioningState, CertificateOrderStatus? status, AppServiceCertificateDetails signedCertificate, string csr, AppServiceCertificateDetails intermediate, AppServiceCertificateDetails root, string serialNumber, DateTimeOffset? lastCertificateIssuedOn, DateTimeOffset? expireOn, bool? isPrivateKeyExternal, IReadOnlyList<AppServiceCertificateNotRenewableReason> appServiceCertificateNotRenewableReasons, DateTimeOffset? nextAutoRenewTimeStamp, CertificateOrderContact contact, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Certificates = certificates;
            DistinguishedName = distinguishedName;
            DomainVerificationToken = domainVerificationToken;
            ValidityInYears = validityInYears;
            KeySize = keySize;
            ProductType = productType;
            IsAutoRenew = isAutoRenew;
            ProvisioningState = provisioningState;
            Status = status;
            SignedCertificate = signedCertificate;
            Csr = csr;
            Intermediate = intermediate;
            Root = root;
            SerialNumber = serialNumber;
            LastCertificateIssuedOn = lastCertificateIssuedOn;
            ExpireOn = expireOn;
            IsPrivateKeyExternal = isPrivateKeyExternal;
            AppServiceCertificateNotRenewableReasons = appServiceCertificateNotRenewableReasons;
            NextAutoRenewTimeStamp = nextAutoRenewTimeStamp;
            Contact = contact;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceCertificateOrderData"/> for deserialization. </summary>
        internal AppServiceCertificateOrderData()
        {
        }

        /// <summary> State of the Key Vault secret. </summary>
        [WirePath("properties.certificates")]
        public IDictionary<string, AppServiceCertificateProperties> Certificates { get; }
        /// <summary> Certificate distinguished name. </summary>
        [WirePath("properties.distinguishedName")]
        public string DistinguishedName { get; set; }
        /// <summary> Domain verification token. </summary>
        [WirePath("properties.domainVerificationToken")]
        public string DomainVerificationToken { get; }
        /// <summary> Duration in years (must be 1). </summary>
        [WirePath("properties.validityInYears")]
        public int? ValidityInYears { get; set; }
        /// <summary> Certificate key size. </summary>
        [WirePath("properties.keySize")]
        public int? KeySize { get; set; }
        /// <summary> Certificate product type. </summary>
        [WirePath("properties.productType")]
        public CertificateProductType? ProductType { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if the certificate should be automatically renewed when it expires; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("properties.autoRenew")]
        public bool? IsAutoRenew { get; set; }
        /// <summary> Status of certificate order. </summary>
        [WirePath("properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Current order status. </summary>
        [WirePath("properties.status")]
        public CertificateOrderStatus? Status { get; }
        /// <summary> Signed certificate. </summary>
        [WirePath("properties.signedCertificate")]
        public AppServiceCertificateDetails SignedCertificate { get; }
        /// <summary> Last CSR that was created for this order. </summary>
        [WirePath("properties.csr")]
        public string Csr { get; set; }
        /// <summary> Intermediate certificate. </summary>
        [WirePath("properties.intermediate")]
        public AppServiceCertificateDetails Intermediate { get; }
        /// <summary> Root certificate. </summary>
        [WirePath("properties.root")]
        public AppServiceCertificateDetails Root { get; }
        /// <summary> Current serial number of the certificate. </summary>
        [WirePath("properties.serialNumber")]
        public string SerialNumber { get; }
        /// <summary> Certificate last issuance time. </summary>
        [WirePath("properties.lastCertificateIssuanceTime")]
        public DateTimeOffset? LastCertificateIssuedOn { get; }
        /// <summary> Certificate expiration time. </summary>
        [WirePath("properties.expirationTime")]
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if private key is external; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        [WirePath("properties.isPrivateKeyExternal")]
        public bool? IsPrivateKeyExternal { get; }
        /// <summary> Reasons why App Service Certificate is not renewable at the current moment. </summary>
        [WirePath("properties.appServiceCertificateNotRenewableReasons")]
        public IReadOnlyList<AppServiceCertificateNotRenewableReason> AppServiceCertificateNotRenewableReasons { get; }
        /// <summary> Time stamp when the certificate would be auto renewed next. </summary>
        [WirePath("properties.nextAutoRenewalTimeStamp")]
        public DateTimeOffset? NextAutoRenewTimeStamp { get; }
        /// <summary> Contact info. </summary>
        [WirePath("properties.contact")]
        public CertificateOrderContact Contact { get; }
        /// <summary> Kind of resource. If the resource is an app, you can refer to https://github.com/Azure/app-service-linux-docs/blob/master/Things_You_Should_Know/kind_property.md#app-service-resource-kind-reference for details supported values for kind. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
