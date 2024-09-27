// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> The ComputeFleetVmSizeProperties. </summary>
    public partial class ComputeFleetVmSizeProperties
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

        /// <summary> Initializes a new instance of <see cref="ComputeFleetVmSizeProperties"/>. </summary>
        public ComputeFleetVmSizeProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComputeFleetVmSizeProperties"/>. </summary>
        /// <param name="vcpUsAvailable"></param>
        /// <param name="vcpUsPerCore"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeFleetVmSizeProperties(int? vcpUsAvailable, int? vcpUsPerCore, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VCPUsAvailable = vcpUsAvailable;
            VCPUsPerCore = vcpUsPerCore;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the vcp us available. </summary>
        public int? VCPUsAvailable { get; set; }
        /// <summary> Gets or sets the vcp us per core. </summary>
        public int? VCPUsPerCore { get; set; }
    }
}
