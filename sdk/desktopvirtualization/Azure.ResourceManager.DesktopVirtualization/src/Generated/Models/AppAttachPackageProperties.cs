// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Schema for App Attach Package properties. </summary>
    public partial class AppAttachPackageProperties
    {
        /// <summary> Initializes a new instance of AppAttachPackageProperties. </summary>
        public AppAttachPackageProperties()
        {
            HostPoolReferences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AppAttachPackageProperties. </summary>
        /// <param name="provisioningState"> The provisioning state of the App Attach Package. </param>
        /// <param name="image"> Detailed properties for App Attach Package. </param>
        /// <param name="hostPoolReferences"> List of Hostpool resource Ids. </param>
        /// <param name="keyVaultURL"> URL of keyvault location to store certificate. </param>
        /// <param name="failHealthCheckOnStagingFailure"> Parameter indicating how the health check should behave if this package fails staging. </param>
        internal AppAttachPackageProperties(ProvisioningState? provisioningState, AppAttachPackageInfoProperties image, IList<string> hostPoolReferences, string keyVaultURL, FailHealthCheckOnStagingFailure? failHealthCheckOnStagingFailure)
        {
            ProvisioningState = provisioningState;
            Image = image;
            HostPoolReferences = hostPoolReferences;
            KeyVaultURL = keyVaultURL;
            FailHealthCheckOnStagingFailure = failHealthCheckOnStagingFailure;
        }

        /// <summary> The provisioning state of the App Attach Package. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Detailed properties for App Attach Package. </summary>
        public AppAttachPackageInfoProperties Image { get; set; }
        /// <summary> List of Hostpool resource Ids. </summary>
        public IList<string> HostPoolReferences { get; }
        /// <summary> URL of keyvault location to store certificate. </summary>
        public string KeyVaultURL { get; set; }
        /// <summary> Parameter indicating how the health check should behave if this package fails staging. </summary>
        public FailHealthCheckOnStagingFailure? FailHealthCheckOnStagingFailure { get; set; }
    }
}
