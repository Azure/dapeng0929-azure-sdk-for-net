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
    using System.Linq;

    /// <summary>
    /// Defines headers for StopInstance operation.
    /// </summary>
    public partial class SAPApplicationServerInstancesStopInstanceHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SAPApplicationServerInstancesStopInstanceHeaders class.
        /// </summary>
        public SAPApplicationServerInstancesStopInstanceHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SAPApplicationServerInstancesStopInstanceHeaders class.
        /// </summary>
        /// <param name="location">The URI to fetch the updated Virtual
        /// Instance for SAP resource.</param>
        public SAPApplicationServerInstancesStopInstanceHeaders(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URI to fetch the updated Virtual Instance for SAP
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
