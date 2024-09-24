// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Prometheus addon profile for the container service cluster. </summary>
    public partial class ManagedClusterAzureMonitorProfile
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

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAzureMonitorProfile"/>. </summary>
        public ManagedClusterAzureMonitorProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterAzureMonitorProfile"/>. </summary>
        /// <param name="metrics"> Metrics profile for the prometheus service addon. </param>
        /// <param name="containerInsights"> Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp; stderr logs etc. See aka.ms/AzureMonitorContainerInsights for an overview. </param>
        /// <param name="appMonitoring"> Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics and traces through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterAzureMonitorProfile(ManagedClusterMonitorProfileMetrics metrics, ManagedClusterAzureMonitorProfileContainerInsights containerInsights, ManagedClusterAzureMonitorProfileAppMonitoring appMonitoring, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Metrics = metrics;
            ContainerInsights = containerInsights;
            AppMonitoring = appMonitoring;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Metrics profile for the prometheus service addon. </summary>
        [WirePath("metrics")]
        public ManagedClusterMonitorProfileMetrics Metrics { get; set; }
        /// <summary> Azure Monitor Container Insights Profile for Kubernetes Events, Inventory and Container stdout &amp; stderr logs etc. See aka.ms/AzureMonitorContainerInsights for an overview. </summary>
        [WirePath("containerInsights")]
        public ManagedClusterAzureMonitorProfileContainerInsights ContainerInsights { get; set; }
        /// <summary> Application Monitoring Profile for Kubernetes Application Container. Collects application logs, metrics and traces through auto-instrumentation of the application using Azure Monitor OpenTelemetry based SDKs. See aka.ms/AzureMonitorApplicationMonitoring for an overview. </summary>
        [WirePath("appMonitoring")]
        public ManagedClusterAzureMonitorProfileAppMonitoring AppMonitoring { get; set; }
    }
}
