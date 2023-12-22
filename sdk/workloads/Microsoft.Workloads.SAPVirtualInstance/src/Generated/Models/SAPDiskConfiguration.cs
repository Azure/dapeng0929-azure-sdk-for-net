// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Workloads.SAPVirtualInstance.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The SAP Disk Configuration contains 'recommended disk' details and list
    /// of supported disks detail for a volume type.
    /// </summary>
    public partial class SAPDiskConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the SAPDiskConfiguration class.
        /// </summary>
        public SAPDiskConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SAPDiskConfiguration class.
        /// </summary>
        /// <param name="recommendedConfiguration">The recommended disk details
        /// for a given VM Sku.</param>
        /// <param name="supportedConfigurations">The list of supported disks
        /// for a given VM Sku.</param>
        public SAPDiskConfiguration(DiskVolumeConfiguration recommendedConfiguration = default(DiskVolumeConfiguration), IList<DiskDetails> supportedConfigurations = default(IList<DiskDetails>))
        {
            RecommendedConfiguration = recommendedConfiguration;
            SupportedConfigurations = supportedConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recommended disk details for a given VM Sku.
        /// </summary>
        [JsonProperty(PropertyName = "recommendedConfiguration")]
        public DiskVolumeConfiguration RecommendedConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the list of supported disks for a given VM Sku.
        /// </summary>
        [JsonProperty(PropertyName = "supportedConfigurations")]
        public IList<DiskDetails> SupportedConfigurations { get; set; }

    }
}
