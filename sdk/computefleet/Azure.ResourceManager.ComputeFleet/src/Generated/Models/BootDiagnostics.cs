// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary>
    /// Boot Diagnostics is a debugging feature which allows you to view Console Output
    /// and Screenshot to diagnose VM status. You can easily view the output of your
    /// console log. Azure also enables you to see a screenshot of the VM from the
    /// hypervisor.
    /// </summary>
    public partial class BootDiagnostics
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

        /// <summary> Initializes a new instance of <see cref="BootDiagnostics"/>. </summary>
        public BootDiagnostics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BootDiagnostics"/>. </summary>
        /// <param name="enabled"> Whether boot diagnostics should be enabled on the Virtual Machine. </param>
        /// <param name="storageUri">
        /// Uri of the storage account to use for placing the console output and
        /// screenshot. If storageUri is not specified while enabling boot diagnostics,
        /// managed storage will be used.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BootDiagnostics(bool? enabled, string storageUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            StorageUri = storageUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Whether boot diagnostics should be enabled on the Virtual Machine. </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// Uri of the storage account to use for placing the console output and
        /// screenshot. If storageUri is not specified while enabling boot diagnostics,
        /// managed storage will be used.
        /// </summary>
        public string StorageUri { get; set; }
    }
}
