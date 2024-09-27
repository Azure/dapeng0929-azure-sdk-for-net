// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> Specifies how a Job should be assigned to a Pool. </summary>
    public partial class BatchPoolInfo
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

        /// <summary> Initializes a new instance of <see cref="BatchPoolInfo"/>. </summary>
        public BatchPoolInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchPoolInfo"/>. </summary>
        /// <param name="poolId"> The ID of an existing Pool. All the Tasks of the Job will run on the specified Pool. You must ensure that the Pool referenced by this property exists. If the Pool does not exist at the time the Batch service tries to schedule a Job, no Tasks for the Job will run until you create a Pool with that id. Note that the Batch service will not reject the Job request; it will simply not run Tasks until the Pool exists. You must specify either the Pool ID or the auto Pool specification, but not both. </param>
        /// <param name="autoPoolSpecification"> Characteristics for a temporary 'auto pool'. The Batch service will create this auto Pool when the Job is submitted. If auto Pool creation fails, the Batch service moves the Job to a completed state, and the Pool creation error is set in the Job's scheduling error property. The Batch service manages the lifetime (both creation and, unless keepAlive is specified, deletion) of the auto Pool. Any user actions that affect the lifetime of the auto Pool while the Job is active will result in unexpected behavior. You must specify either the Pool ID or the auto Pool specification, but not both. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchPoolInfo(string poolId, BatchAutoPoolSpecification autoPoolSpecification, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PoolId = poolId;
            AutoPoolSpecification = autoPoolSpecification;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of an existing Pool. All the Tasks of the Job will run on the specified Pool. You must ensure that the Pool referenced by this property exists. If the Pool does not exist at the time the Batch service tries to schedule a Job, no Tasks for the Job will run until you create a Pool with that id. Note that the Batch service will not reject the Job request; it will simply not run Tasks until the Pool exists. You must specify either the Pool ID or the auto Pool specification, but not both. </summary>
        public string PoolId { get; set; }
        /// <summary> Characteristics for a temporary 'auto pool'. The Batch service will create this auto Pool when the Job is submitted. If auto Pool creation fails, the Batch service moves the Job to a completed state, and the Pool creation error is set in the Job's scheduling error property. The Batch service manages the lifetime (both creation and, unless keepAlive is specified, deletion) of the auto Pool. Any user actions that affect the lifetime of the auto Pool while the Job is active will result in unexpected behavior. You must specify either the Pool ID or the auto Pool specification, but not both. </summary>
        public BatchAutoPoolSpecification AutoPoolSpecification { get; set; }
    }
}
