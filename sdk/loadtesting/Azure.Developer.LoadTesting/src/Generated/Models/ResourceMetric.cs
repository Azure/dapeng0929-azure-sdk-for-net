// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary>
    /// Associated metric definition for particular metrics of the azure resource (
    /// Refer :
    /// https://docs.microsoft.com/en-us/rest/api/monitor/metric-definitions/list#metricdefinition).
    /// </summary>
    public partial class ResourceMetric
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

        /// <summary> Initializes a new instance of <see cref="ResourceMetric"/>. </summary>
        /// <param name="resourceId"> Azure resource id. </param>
        /// <param name="metricNamespace"> Metric name space. </param>
        /// <param name="name"> The invariant value of metric name. </param>
        /// <param name="aggregation"> Metric aggregation. </param>
        /// <param name="resourceType"> Azure resource type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/>, <paramref name="metricNamespace"/>, <paramref name="name"/>, <paramref name="aggregation"/> or <paramref name="resourceType"/> is null. </exception>
        public ResourceMetric(string resourceId, string metricNamespace, string name, string aggregation, string resourceType)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNull(metricNamespace, nameof(metricNamespace));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(aggregation, nameof(aggregation));
            Argument.AssertNotNull(resourceType, nameof(resourceType));

            ResourceId = resourceId;
            MetricNamespace = metricNamespace;
            Name = name;
            Aggregation = aggregation;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceMetric"/>. </summary>
        /// <param name="id"> Unique name for metric. </param>
        /// <param name="resourceId"> Azure resource id. </param>
        /// <param name="metricNamespace"> Metric name space. </param>
        /// <param name="displayDescription"> Metric description. </param>
        /// <param name="name"> The invariant value of metric name. </param>
        /// <param name="aggregation"> Metric aggregation. </param>
        /// <param name="unit"> Metric unit. </param>
        /// <param name="resourceType"> Azure resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceMetric(string id, string resourceId, string metricNamespace, string displayDescription, string name, string aggregation, string unit, string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ResourceId = resourceId;
            MetricNamespace = metricNamespace;
            DisplayDescription = displayDescription;
            Name = name;
            Aggregation = aggregation;
            Unit = unit;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceMetric"/> for deserialization. </summary>
        internal ResourceMetric()
        {
        }

        /// <summary> Unique name for metric. </summary>
        public string Id { get; }
        /// <summary> Azure resource id. </summary>
        public string ResourceId { get; set; }
        /// <summary> Metric name space. </summary>
        public string MetricNamespace { get; set; }
        /// <summary> Metric description. </summary>
        public string DisplayDescription { get; set; }
        /// <summary> The invariant value of metric name. </summary>
        public string Name { get; set; }
        /// <summary> Metric aggregation. </summary>
        public string Aggregation { get; set; }
        /// <summary> Metric unit. </summary>
        public string Unit { get; set; }
        /// <summary> Azure resource type. </summary>
        public string ResourceType { get; set; }
    }
}
