// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ComputeSchedule.Models
{
    /// <summary> The ScheduledActionExecutionParameterDetail. </summary>
    public partial class ScheduledActionExecutionParameterDetail
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

        /// <summary> Initializes a new instance of <see cref="ScheduledActionExecutionParameterDetail"/>. </summary>
        public ScheduledActionExecutionParameterDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ScheduledActionExecutionParameterDetail"/>. </summary>
        /// <param name="optimizationPreference"></param>
        /// <param name="retryPolicy"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScheduledActionExecutionParameterDetail(ScheduledActionOptimizationPreference? optimizationPreference, UserRequestRetryPolicy retryPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OptimizationPreference = optimizationPreference;
            RetryPolicy = retryPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the optimization preference. </summary>
        public ScheduledActionOptimizationPreference? OptimizationPreference { get; set; }
        /// <summary> Gets or sets the retry policy. </summary>
        public UserRequestRetryPolicy RetryPolicy { get; set; }
    }
}
