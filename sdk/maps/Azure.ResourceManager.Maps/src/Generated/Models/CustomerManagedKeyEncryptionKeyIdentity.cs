// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault. </summary>
    public partial class CustomerManagedKeyEncryptionKeyIdentity
    {
        /// <summary> Initializes a new instance of CustomerManagedKeyEncryptionKeyIdentity. </summary>
        public CustomerManagedKeyEncryptionKeyIdentity()
        {
        }

        /// <summary> Initializes a new instance of CustomerManagedKeyEncryptionKeyIdentity. </summary>
        /// <param name="identityType"> Values can be systemAssignedIdentity or userAssignedIdentity. </param>
        /// <param name="userAssignedIdentityResourceId"> user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity and delegatedResourceIdentity. </param>
        /// <param name="delegatedIdentityClientId"> delegated identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity and userAssignedIdentity - internal use only. </param>
        internal CustomerManagedKeyEncryptionKeyIdentity(IdentityType? identityType, ResourceIdentifier userAssignedIdentityResourceId, Guid? delegatedIdentityClientId)
        {
            IdentityType = identityType;
            UserAssignedIdentityResourceId = userAssignedIdentityResourceId;
            DelegatedIdentityClientId = delegatedIdentityClientId;
        }

        /// <summary> Values can be systemAssignedIdentity or userAssignedIdentity. </summary>
        public IdentityType? IdentityType { get; set; }
        /// <summary> user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity and delegatedResourceIdentity. </summary>
        public ResourceIdentifier UserAssignedIdentityResourceId { get; set; }
        /// <summary> delegated identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. Mutually exclusive with identityType systemAssignedIdentity and userAssignedIdentity - internal use only. </summary>
        public Guid? DelegatedIdentityClientId { get; set; }
    }
}
