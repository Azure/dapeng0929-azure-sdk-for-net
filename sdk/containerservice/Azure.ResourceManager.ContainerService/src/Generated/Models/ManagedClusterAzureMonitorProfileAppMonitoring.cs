// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics and traces through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </summary>
    public partial class ManagedClusterAzureMonitorProfileAppMonitoring
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAzureMonitorProfileAppMonitoring"/>. </summary>
        public ManagedClusterAzureMonitorProfileAppMonitoring()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAzureMonitorProfileAppMonitoring"/>. </summary>
        /// <param name="autoInstrumentation"> Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook to auto-instrument Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the application. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </param>
        /// <param name="openTelemetryMetrics"> Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Metrics. Collects OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </param>
        /// <param name="openTelemetryLogs"> Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and Traces. Collects OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterAzureMonitorProfileAppMonitoring(ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation autoInstrumentation, ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryMetrics openTelemetryMetrics, ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryLogs openTelemetryLogs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AutoInstrumentation = autoInstrumentation;
            OpenTelemetryMetrics = openTelemetryMetrics;
            OpenTelemetryLogs = openTelemetryLogs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Application Monitoring Auto Instrumentation for Kubernetes Application Container. Deploys web hook to auto-instrument Azure Monitor OpenTelemetry based SDKs to collect OpenTelemetry metrics, logs and traces of the application. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </summary>
        internal ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation AutoInstrumentation { get; set; }
        /// <summary> Indicates if Application Monitoring Auto Instrumentation is enabled or not. </summary>
        public bool? AutoInstrumentationEnabled
        {
            get => AutoInstrumentation is null ? default : AutoInstrumentation.Enabled;
            set
            {
                if (AutoInstrumentation is null)
                    AutoInstrumentation = new ManagedClusterAzureMonitorProfileAppMonitoringAutoInstrumentation();
                AutoInstrumentation.Enabled = value;
            }
        }

        /// <summary> Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Metrics. Collects OpenTelemetry metrics of the application using Azure Monitor OpenTelemetry based SDKs. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </summary>
        public ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryMetrics OpenTelemetryMetrics { get; set; }
        /// <summary> Application Monitoring Open Telemetry Metrics Profile for Kubernetes Application Container Logs and Traces. Collects OpenTelemetry logs and traces of the application using Azure Monitor OpenTelemetry based SDKs. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </summary>
        public ManagedClusterAzureMonitorProfileAppMonitoringOpenTelemetryLogs OpenTelemetryLogs { get; set; }
    }
}
