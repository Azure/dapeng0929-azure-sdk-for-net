// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The ImageReference. </summary>
    public partial class ImageReference
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

        /// <summary> Initializes a new instance of <see cref="ImageReference"/>. </summary>
        public ImageReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageReference"/>. </summary>
        /// <param name="publisher"></param>
        /// <param name="offer"></param>
        /// <param name="sku"></param>
        /// <param name="version"></param>
        /// <param name="virtualMachineImageId"></param>
        /// <param name="exactVersion"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageReference(string publisher, string offer, string sku, string version, string virtualMachineImageId, string exactVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            Version = version;
            VirtualMachineImageId = virtualMachineImageId;
            ExactVersion = exactVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> Gets or sets the offer. </summary>
        public string Offer { get; set; }
        /// <summary> Gets or sets the sku. </summary>
        public string Sku { get; set; }
        /// <summary> Gets or sets the version. </summary>
        public string Version { get; set; }
        /// <summary> Gets or sets the virtual machine image id. </summary>
        public string VirtualMachineImageId { get; set; }
        /// <summary> Gets the exact version. </summary>
        public string ExactVersion { get; }
    }
}
