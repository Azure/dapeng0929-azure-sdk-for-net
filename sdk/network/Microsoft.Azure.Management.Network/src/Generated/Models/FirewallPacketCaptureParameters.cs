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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure Firewall Packet Capture Parameters resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FirewallPacketCaptureParameters : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPacketCaptureParameters
        /// class.
        /// </summary>
        public FirewallPacketCaptureParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPacketCaptureParameters
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="durationInSeconds">Duration of packet capture in
        /// seconds.</param>
        /// <param name="numberOfPacketsToCapture">Number of packets to be
        /// captured.</param>
        /// <param name="sasUrl">Upload capture location</param>
        /// <param name="fileName">Name of file to be uploaded to
        /// sasURL</param>
        /// <param name="protocol">The protocol of packets to capture. Possible
        /// values include: 'TCP', 'UDP', 'Any', 'ICMP'</param>
        /// <param name="flags">The tcp-flag type to be captured. Used with
        /// protocol TCP</param>
        /// <param name="filters">Rules to filter packet captures.</param>
        public FirewallPacketCaptureParameters(string id = default(string), int? durationInSeconds = default(int?), int? numberOfPacketsToCapture = default(int?), string sasUrl = default(string), string fileName = default(string), string protocol = default(string), IList<AzureFirewallPacketCaptureFlags> flags = default(IList<AzureFirewallPacketCaptureFlags>), IList<AzureFirewallPacketCaptureRule> filters = default(IList<AzureFirewallPacketCaptureRule>))
            : base(id)
        {
            DurationInSeconds = durationInSeconds;
            NumberOfPacketsToCapture = numberOfPacketsToCapture;
            SasUrl = sasUrl;
            FileName = fileName;
            Protocol = protocol;
            Flags = flags;
            Filters = filters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets duration of packet capture in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "properties.durationInSeconds")]
        public int? DurationInSeconds { get; set; }

        /// <summary>
        /// Gets or sets number of packets to be captured.
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfPacketsToCapture")]
        public int? NumberOfPacketsToCapture { get; set; }

        /// <summary>
        /// Gets or sets upload capture location
        /// </summary>
        [JsonProperty(PropertyName = "properties.sasUrl")]
        public string SasUrl { get; set; }

        /// <summary>
        /// Gets or sets name of file to be uploaded to sasURL
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the protocol of packets to capture. Possible values
        /// include: 'TCP', 'UDP', 'Any', 'ICMP'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the tcp-flag type to be captured. Used with protocol
        /// TCP
        /// </summary>
        [JsonProperty(PropertyName = "properties.flags")]
        public IList<AzureFirewallPacketCaptureFlags> Flags { get; set; }

        /// <summary>
        /// Gets or sets rules to filter packet captures.
        /// </summary>
        [JsonProperty(PropertyName = "properties.filters")]
        public IList<AzureFirewallPacketCaptureRule> Filters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DurationInSeconds > 1800)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "DurationInSeconds", 1800);
            }
            if (DurationInSeconds < 30)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "DurationInSeconds", 30);
            }
            if (NumberOfPacketsToCapture > 90000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "NumberOfPacketsToCapture", 90000);
            }
            if (NumberOfPacketsToCapture < 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "NumberOfPacketsToCapture", 100);
            }
        }
    }
}
