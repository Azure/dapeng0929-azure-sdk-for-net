// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchPoolUsageMetrics. </summary>
    public partial class BatchPoolUsageMetrics
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

        /// <summary> Initializes a new instance of <see cref="BatchPoolUsageMetrics"/>. </summary>
        /// <param name="poolId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="vmSize"></param>
        /// <param name="totalCoreHours"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="poolId"/> or <paramref name="vmSize"/> is null. </exception>
        internal BatchPoolUsageMetrics(string poolId, DateTimeOffset startTime, DateTimeOffset endTime, string vmSize, float totalCoreHours)
        {
            Argument.AssertNotNull(poolId, nameof(poolId));
            Argument.AssertNotNull(vmSize, nameof(vmSize));

            PoolId = poolId;
            StartTime = startTime;
            EndTime = endTime;
            VmSize = vmSize;
            TotalCoreHours = totalCoreHours;
        }

        /// <summary> Initializes a new instance of <see cref="BatchPoolUsageMetrics"/>. </summary>
        /// <param name="poolId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="vmSize"></param>
        /// <param name="totalCoreHours"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchPoolUsageMetrics(string poolId, DateTimeOffset startTime, DateTimeOffset endTime, string vmSize, float totalCoreHours, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PoolId = poolId;
            StartTime = startTime;
            EndTime = endTime;
            VmSize = vmSize;
            TotalCoreHours = totalCoreHours;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchPoolUsageMetrics"/> for deserialization. </summary>
        internal BatchPoolUsageMetrics()
        {
        }

        /// <summary> Gets the pool id. </summary>
        public string PoolId { get; }
        /// <summary> Gets the start time. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> Gets the end time. </summary>
        public DateTimeOffset EndTime { get; }
        /// <summary> Gets the vm size. </summary>
        public string VmSize { get; }
        /// <summary> Gets the total core hours. </summary>
        public float TotalCoreHours { get; }
    }
}
