// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The OSDisk. </summary>
    public partial class OSDisk
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

        /// <summary> Initializes a new instance of <see cref="OSDisk"/>. </summary>
        public OSDisk()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OSDisk"/>. </summary>
        /// <param name="ephemeralOSDiskSettings"></param>
        /// <param name="caching"></param>
        /// <param name="diskSizeGB"></param>
        /// <param name="managedDisk"></param>
        /// <param name="writeAcceleratorEnabled"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OSDisk(DiffDiskSettings ephemeralOSDiskSettings, CachingType? caching, int? diskSizeGB, ManagedDisk managedDisk, bool? writeAcceleratorEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EphemeralOSDiskSettings = ephemeralOSDiskSettings;
            Caching = caching;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the ephemeral os disk settings. </summary>
        public DiffDiskSettings EphemeralOSDiskSettings { get; set; }
        /// <summary> Gets or sets the caching. </summary>
        public CachingType? Caching { get; set; }
        /// <summary> Gets or sets the disk size gb. </summary>
        public int? DiskSizeGB { get; set; }
        /// <summary> Gets or sets the managed disk. </summary>
        public ManagedDisk ManagedDisk { get; set; }
        /// <summary> Gets or sets the write accelerator enabled. </summary>
        public bool? WriteAcceleratorEnabled { get; set; }
    }
}
