// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Specifications on number of machines. </summary>
    public partial class ManualScaleProfile
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

        /// <summary> Initializes a new instance of <see cref="ManualScaleProfile"/>. </summary>
        public ManualScaleProfile()
        {
            Sizes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManualScaleProfile"/>. </summary>
        /// <param name="sizes"> The list of allowed vm sizes e.g. ['Standard_E4s_v3', 'Standard_E16s_v3', 'Standard_D16s_v5']. AKS will use the first available one when scaling. If a VM size is unavailable (e.g. due to quota or regional capacity reasons), AKS will use the next size. </param>
        /// <param name="count"> Number of nodes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManualScaleProfile(IList<string> sizes, int? count, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sizes = sizes;
            Count = count;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of allowed vm sizes e.g. ['Standard_E4s_v3', 'Standard_E16s_v3', 'Standard_D16s_v5']. AKS will use the first available one when scaling. If a VM size is unavailable (e.g. due to quota or regional capacity reasons), AKS will use the next size. </summary>
        public IList<string> Sizes { get; }
        /// <summary> Number of nodes. </summary>
        public int? Count { get; set; }
    }
}
