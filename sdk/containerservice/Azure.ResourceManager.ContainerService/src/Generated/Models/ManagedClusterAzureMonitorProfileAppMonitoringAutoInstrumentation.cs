// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook to auto-instrument Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the application. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </summary>
    internal partial class ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation"/>. </summary>
        public ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation"/>. </summary>
        /// <param name="enabled"> Indicates if Application Monitoring Auto Instrumentation is enabled or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation(bool? enabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates if Application Monitoring Auto Instrumentation is enabled or not. </summary>
        public bool? Enabled { get; set; }
    }
}
