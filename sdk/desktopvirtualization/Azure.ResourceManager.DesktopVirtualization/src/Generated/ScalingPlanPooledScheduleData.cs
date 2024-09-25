// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing the ScalingPlanPooledSchedule data model.
    /// Represents a ScalingPlanPooledSchedule definition.
    /// </summary>
    public partial class ScalingPlanPooledScheduleData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ScalingPlanPooledScheduleData"/>. </summary>
        /// <param name="daysOfWeek"> Set of days of the week on which this schedule is active. </param>
        /// <param name="rampUpStartTime"> Starting time for ramp up period. </param>
        /// <param name="rampUpCapacityThresholdPct"> Capacity threshold for ramp up period. </param>
        /// <param name="peakStartTime"> Starting time for peak period. </param>
        /// <param name="rampDownStartTime"> Starting time for ramp down period. </param>
        /// <param name="rampDownCapacityThresholdPct"> Capacity threshold for ramp down period. </param>
        /// <param name="offPeakStartTime"> Starting time for off-peak period. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="daysOfWeek"/>, <paramref name="rampUpStartTime"/>, <paramref name="peakStartTime"/>, <paramref name="rampDownStartTime"/> or <paramref name="offPeakStartTime"/> is null. </exception>
        public ScalingPlanPooledScheduleData(IEnumerable<DesktopVirtualizationDayOfWeek> daysOfWeek, ScalingActionTime rampUpStartTime, int rampUpCapacityThresholdPct, ScalingActionTime peakStartTime, ScalingActionTime rampDownStartTime, int rampDownCapacityThresholdPct, ScalingActionTime offPeakStartTime)
        {
            Argument.AssertNotNull(daysOfWeek, nameof(daysOfWeek));
            Argument.AssertNotNull(rampUpStartTime, nameof(rampUpStartTime));
            Argument.AssertNotNull(peakStartTime, nameof(peakStartTime));
            Argument.AssertNotNull(rampDownStartTime, nameof(rampDownStartTime));
            Argument.AssertNotNull(offPeakStartTime, nameof(offPeakStartTime));

            DaysOfWeek = daysOfWeek.ToList();
            RampUpStartTime = rampUpStartTime;
            RampUpCapacityThresholdPct = rampUpCapacityThresholdPct;
            PeakStartTime = peakStartTime;
            RampDownStartTime = rampDownStartTime;
            RampDownCapacityThresholdPct = rampDownCapacityThresholdPct;
            OffPeakStartTime = offPeakStartTime;
        }

        /// <summary> Initializes a new instance of <see cref="ScalingPlanPooledScheduleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="namePropertiesName"> Name of the ScalingPlanPooledSchedule. </param>
        /// <param name="daysOfWeek"> Set of days of the week on which this schedule is active. </param>
        /// <param name="rampUpStartTime"> Starting time for ramp up period. </param>
        /// <param name="rampUpLoadBalancingAlgorithm"> Load balancing algorithm for ramp up period. </param>
        /// <param name="rampUpMinimumHostsPct"> Minimum host percentage for ramp up period. </param>
        /// <param name="rampUpCapacityThresholdPct"> Capacity threshold for ramp up period. </param>
        /// <param name="peakStartTime"> Starting time for peak period. </param>
        /// <param name="peakLoadBalancingAlgorithm"> Load balancing algorithm for peak period. </param>
        /// <param name="rampDownStartTime"> Starting time for ramp down period. </param>
        /// <param name="rampDownLoadBalancingAlgorithm"> Load balancing algorithm for ramp down period. </param>
        /// <param name="rampDownMinimumHostsPct"> Minimum host percentage for ramp down period. </param>
        /// <param name="rampDownCapacityThresholdPct"> Capacity threshold for ramp down period. </param>
        /// <param name="rampDownForceLogoffUsers"> Should users be logged off forcefully from hosts. </param>
        /// <param name="rampDownStopHostsWhen"> Specifies when to stop hosts during ramp down period. </param>
        /// <param name="rampDownWaitTimeMinutes"> Number of minutes to wait to stop hosts during ramp down period. </param>
        /// <param name="rampDownNotificationMessage"> Notification message for users during ramp down period. </param>
        /// <param name="offPeakStartTime"> Starting time for off-peak period. </param>
        /// <param name="offPeakLoadBalancingAlgorithm"> Load balancing algorithm for off-peak period. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScalingPlanPooledScheduleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string namePropertiesName, IList<DesktopVirtualizationDayOfWeek> daysOfWeek, ScalingActionTime rampUpStartTime, SessionHostLoadBalancingAlgorithm? rampUpLoadBalancingAlgorithm, int? rampUpMinimumHostsPct, int rampUpCapacityThresholdPct, ScalingActionTime peakStartTime, SessionHostLoadBalancingAlgorithm? peakLoadBalancingAlgorithm, ScalingActionTime rampDownStartTime, SessionHostLoadBalancingAlgorithm? rampDownLoadBalancingAlgorithm, int? rampDownMinimumHostsPct, int rampDownCapacityThresholdPct, bool? rampDownForceLogoffUsers, DesktopVirtualizationStopHostsWhen? rampDownStopHostsWhen, int? rampDownWaitTimeMinutes, string rampDownNotificationMessage, ScalingActionTime offPeakStartTime, SessionHostLoadBalancingAlgorithm? offPeakLoadBalancingAlgorithm, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            NamePropertiesName = namePropertiesName;
            DaysOfWeek = daysOfWeek;
            RampUpStartTime = rampUpStartTime;
            RampUpLoadBalancingAlgorithm = rampUpLoadBalancingAlgorithm;
            RampUpMinimumHostsPct = rampUpMinimumHostsPct;
            RampUpCapacityThresholdPct = rampUpCapacityThresholdPct;
            PeakStartTime = peakStartTime;
            PeakLoadBalancingAlgorithm = peakLoadBalancingAlgorithm;
            RampDownStartTime = rampDownStartTime;
            RampDownLoadBalancingAlgorithm = rampDownLoadBalancingAlgorithm;
            RampDownMinimumHostsPct = rampDownMinimumHostsPct;
            RampDownCapacityThresholdPct = rampDownCapacityThresholdPct;
            RampDownForceLogoffUsers = rampDownForceLogoffUsers;
            RampDownStopHostsWhen = rampDownStopHostsWhen;
            RampDownWaitTimeMinutes = rampDownWaitTimeMinutes;
            RampDownNotificationMessage = rampDownNotificationMessage;
            OffPeakStartTime = offPeakStartTime;
            OffPeakLoadBalancingAlgorithm = offPeakLoadBalancingAlgorithm;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScalingPlanPooledScheduleData"/> for deserialization. </summary>
        internal ScalingPlanPooledScheduleData()
        {
        }

        /// <summary> Name of the ScalingPlanPooledSchedule. </summary>
        [WirePath("properties.name")]
        public string NamePropertiesName { get; }
        /// <summary> Set of days of the week on which this schedule is active. </summary>
        [WirePath("properties.daysOfWeek")]
        public IList<DesktopVirtualizationDayOfWeek> DaysOfWeek { get; }
        /// <summary> Starting time for ramp up period. </summary>
        [WirePath("properties.rampUpStartTime")]
        public ScalingActionTime RampUpStartTime { get; set; }
        /// <summary> Load balancing algorithm for ramp up period. </summary>
        [WirePath("properties.rampUpLoadBalancingAlgorithm")]
        public SessionHostLoadBalancingAlgorithm? RampUpLoadBalancingAlgorithm { get; set; }
        /// <summary> Minimum host percentage for ramp up period. </summary>
        [WirePath("properties.rampUpMinimumHostsPct")]
        public int? RampUpMinimumHostsPct { get; set; }
        /// <summary> Capacity threshold for ramp up period. </summary>
        [WirePath("properties.rampUpCapacityThresholdPct")]
        public int RampUpCapacityThresholdPct { get; set; }
        /// <summary> Starting time for peak period. </summary>
        [WirePath("properties.peakStartTime")]
        public ScalingActionTime PeakStartTime { get; set; }
        /// <summary> Load balancing algorithm for peak period. </summary>
        [WirePath("properties.peakLoadBalancingAlgorithm")]
        public SessionHostLoadBalancingAlgorithm? PeakLoadBalancingAlgorithm { get; set; }
        /// <summary> Starting time for ramp down period. </summary>
        [WirePath("properties.rampDownStartTime")]
        public ScalingActionTime RampDownStartTime { get; set; }
        /// <summary> Load balancing algorithm for ramp down period. </summary>
        [WirePath("properties.rampDownLoadBalancingAlgorithm")]
        public SessionHostLoadBalancingAlgorithm? RampDownLoadBalancingAlgorithm { get; set; }
        /// <summary> Minimum host percentage for ramp down period. </summary>
        [WirePath("properties.rampDownMinimumHostsPct")]
        public int? RampDownMinimumHostsPct { get; set; }
        /// <summary> Capacity threshold for ramp down period. </summary>
        [WirePath("properties.rampDownCapacityThresholdPct")]
        public int RampDownCapacityThresholdPct { get; set; }
        /// <summary> Should users be logged off forcefully from hosts. </summary>
        [WirePath("properties.rampDownForceLogoffUsers")]
        public bool? RampDownForceLogoffUsers { get; set; }
        /// <summary> Specifies when to stop hosts during ramp down period. </summary>
        [WirePath("properties.rampDownStopHostsWhen")]
        public DesktopVirtualizationStopHostsWhen? RampDownStopHostsWhen { get; set; }
        /// <summary> Number of minutes to wait to stop hosts during ramp down period. </summary>
        [WirePath("properties.rampDownWaitTimeMinutes")]
        public int? RampDownWaitTimeMinutes { get; set; }
        /// <summary> Notification message for users during ramp down period. </summary>
        [WirePath("properties.rampDownNotificationMessage")]
        public string RampDownNotificationMessage { get; set; }
        /// <summary> Starting time for off-peak period. </summary>
        [WirePath("properties.offPeakStartTime")]
        public ScalingActionTime OffPeakStartTime { get; set; }
        /// <summary> Load balancing algorithm for off-peak period. </summary>
        [WirePath("properties.offPeakLoadBalancingAlgorithm")]
        public SessionHostLoadBalancingAlgorithm? OffPeakLoadBalancingAlgorithm { get; set; }
    }
}
