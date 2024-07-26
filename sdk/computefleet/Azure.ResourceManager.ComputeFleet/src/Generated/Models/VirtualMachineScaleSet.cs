// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> An AzureFleet's virtualMachineScaleSet. </summary>
    public partial class VirtualMachineScaleSet
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSet"/>. </summary>
        /// <param name="id">
        /// The compute RP resource id of the virtualMachineScaleSet
        /// "subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}"
        /// </param>
        /// <param name="operationStatus"> This represents the operationStatus of the VMSS in response to the last operation that was performed on it by Azure Fleet resource. </param>
        internal VirtualMachineScaleSet(string id, ProvisioningState operationStatus)
        {
            Id = id;
            OperationStatus = operationStatus;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSet"/>. </summary>
        /// <param name="id">
        /// The compute RP resource id of the virtualMachineScaleSet
        /// "subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}"
        /// </param>
        /// <param name="type"> Type of the virtualMachineScaleSet. </param>
        /// <param name="operationStatus"> This represents the operationStatus of the VMSS in response to the last operation that was performed on it by Azure Fleet resource. </param>
        /// <param name="error"> Error Information when `operationStatus` is `Failed`. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSet(string id, string type, ProvisioningState operationStatus, ApiError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Type = type;
            OperationStatus = operationStatus;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSet"/> for deserialization. </summary>
        internal VirtualMachineScaleSet()
        {
        }

        /// <summary>
        /// The compute RP resource id of the virtualMachineScaleSet
        /// "subscriptions/{subId}/resourceGroups/{rgName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmssName}"
        /// </summary>
        public string Id { get; }
        /// <summary> Type of the virtualMachineScaleSet. </summary>
        public string Type { get; }
        /// <summary> This represents the operationStatus of the VMSS in response to the last operation that was performed on it by Azure Fleet resource. </summary>
        public ProvisioningState OperationStatus { get; }
        /// <summary> Error Information when `operationStatus` is `Failed`. </summary>
        public ApiError Error { get; }
    }
}
