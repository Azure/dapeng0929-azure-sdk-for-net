// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes a policy that determines how resources within the search service are to be encrypted with customer=managed keys. </summary>
    public partial class SearchEncryptionWithCmk
    {
        /// <summary> Initializes a new instance of SearchEncryptionWithCmk. </summary>
        public SearchEncryptionWithCmk()
        {
        }

        /// <summary> Initializes a new instance of SearchEncryptionWithCmk. </summary>
        /// <param name="enforcement"> Describes how a search service should enforce having one or more non-customer-encrypted resources. </param>
        /// <param name="encryptionComplianceStatus"> Describes whether the search service is compliant or not with respect to having non-customer-encrypted resources. If a service has more than one non-customer-encrypted resource and 'Enforcement' is 'enabled' then the service will be marked as 'nonCompliant'. </param>
        internal SearchEncryptionWithCmk(SearchEncryptionWithCmkEnforcement? enforcement, SearchEncryptionComplianceStatus? encryptionComplianceStatus)
        {
            Enforcement = enforcement;
            EncryptionComplianceStatus = encryptionComplianceStatus;
        }

        /// <summary> Describes how a search service should enforce having one or more non-customer-encrypted resources. </summary>
        public SearchEncryptionWithCmkEnforcement? Enforcement { get; set; }
        /// <summary> Describes whether the search service is compliant or not with respect to having non-customer-encrypted resources. If a service has more than one non-customer-encrypted resource and 'Enforcement' is 'enabled' then the service will be marked as 'nonCompliant'. </summary>
        public SearchEncryptionComplianceStatus? EncryptionComplianceStatus { get; }
    }
}
