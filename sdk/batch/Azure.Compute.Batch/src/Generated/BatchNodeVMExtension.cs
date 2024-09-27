// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchNodeVMExtension. </summary>
    public partial class BatchNodeVMExtension
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

        /// <summary> Initializes a new instance of <see cref="BatchNodeVMExtension"/>. </summary>
        internal BatchNodeVMExtension()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeVMExtension"/>. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="vmExtension"></param>
        /// <param name="instanceView"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNodeVMExtension(string provisioningState, VMExtension vmExtension, VMExtensionInstanceView instanceView, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            VmExtension = vmExtension;
            InstanceView = instanceView;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Gets the vm extension. </summary>
        public VMExtension VmExtension { get; }
        /// <summary> Gets the instance view. </summary>
        public VMExtensionInstanceView InstanceView { get; }
    }
}
