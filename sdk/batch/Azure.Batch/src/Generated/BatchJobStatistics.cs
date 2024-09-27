// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> Resource usage statistics for a Job. </summary>
    public partial class BatchJobStatistics
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

        /// <summary> Initializes a new instance of <see cref="BatchJobStatistics"/>. </summary>
        /// <param name="url"> The URL of the statistics. </param>
        /// <param name="startTime"> The start time of the time range covered by the statistics. </param>
        /// <param name="lastUpdateTime"> The time at which the statistics were last updated. All statistics are limited to the range between startTime and lastUpdateTime. </param>
        /// <param name="userCpuTime"> The total user mode CPU time (summed across all cores and all Compute Nodes) consumed by all Tasks in the Job. </param>
        /// <param name="kernelCpuTime"> The total kernel mode CPU time (summed across all cores and all Compute Nodes) consumed by all Tasks in the Job. </param>
        /// <param name="wallClockTime"> The total wall clock time of all Tasks in the Job.  The wall clock time is the elapsed time from when the Task started running on a Compute Node to when it finished (or to the last time the statistics were updated, if the Task had not finished by then). If a Task was retried, this includes the wall clock time of all the Task retries. </param>
        /// <param name="readIOps"> The total number of disk read operations made by all Tasks in the Job. </param>
        /// <param name="writeIOps"> The total number of disk write operations made by all Tasks in the Job. </param>
        /// <param name="readIOGiB"> The total amount of data in GiB read from disk by all Tasks in the Job. </param>
        /// <param name="writeIOGiB"> The total amount of data in GiB written to disk by all Tasks in the Job. </param>
        /// <param name="numSucceededTasks"> The total number of Tasks successfully completed in the Job during the given time range. A Task completes successfully if it returns exit code 0. </param>
        /// <param name="numFailedTasks"> The total number of Tasks in the Job that failed during the given time range. A Task fails if it exhausts its maximum retry count without returning exit code 0. </param>
        /// <param name="numTaskRetries"> The total number of retries on all the Tasks in the Job during the given time range. </param>
        /// <param name="waitTime"> The total wait time of all Tasks in the Job. The wait time for a Task is defined as the elapsed time between the creation of the Task and the start of Task execution. (If the Task is retried due to failures, the wait time is the time to the most recent Task execution.) This value is only reported in the Account lifetime statistics; it is not included in the Job statistics. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        internal BatchJobStatistics(string url, DateTimeOffset startTime, DateTimeOffset lastUpdateTime, TimeSpan userCpuTime, TimeSpan kernelCpuTime, TimeSpan wallClockTime, long readIOps, long writeIOps, float readIOGiB, float writeIOGiB, long numSucceededTasks, long numFailedTasks, long numTaskRetries, TimeSpan waitTime)
        {
            Argument.AssertNotNull(url, nameof(url));

            Url = url;
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
            UserCpuTime = userCpuTime;
            KernelCpuTime = kernelCpuTime;
            WallClockTime = wallClockTime;
            ReadIOps = readIOps;
            WriteIOps = writeIOps;
            ReadIOGiB = readIOGiB;
            WriteIOGiB = writeIOGiB;
            NumSucceededTasks = numSucceededTasks;
            NumFailedTasks = numFailedTasks;
            NumTaskRetries = numTaskRetries;
            WaitTime = waitTime;
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobStatistics"/>. </summary>
        /// <param name="url"> The URL of the statistics. </param>
        /// <param name="startTime"> The start time of the time range covered by the statistics. </param>
        /// <param name="lastUpdateTime"> The time at which the statistics were last updated. All statistics are limited to the range between startTime and lastUpdateTime. </param>
        /// <param name="userCpuTime"> The total user mode CPU time (summed across all cores and all Compute Nodes) consumed by all Tasks in the Job. </param>
        /// <param name="kernelCpuTime"> The total kernel mode CPU time (summed across all cores and all Compute Nodes) consumed by all Tasks in the Job. </param>
        /// <param name="wallClockTime"> The total wall clock time of all Tasks in the Job.  The wall clock time is the elapsed time from when the Task started running on a Compute Node to when it finished (or to the last time the statistics were updated, if the Task had not finished by then). If a Task was retried, this includes the wall clock time of all the Task retries. </param>
        /// <param name="readIOps"> The total number of disk read operations made by all Tasks in the Job. </param>
        /// <param name="writeIOps"> The total number of disk write operations made by all Tasks in the Job. </param>
        /// <param name="readIOGiB"> The total amount of data in GiB read from disk by all Tasks in the Job. </param>
        /// <param name="writeIOGiB"> The total amount of data in GiB written to disk by all Tasks in the Job. </param>
        /// <param name="numSucceededTasks"> The total number of Tasks successfully completed in the Job during the given time range. A Task completes successfully if it returns exit code 0. </param>
        /// <param name="numFailedTasks"> The total number of Tasks in the Job that failed during the given time range. A Task fails if it exhausts its maximum retry count without returning exit code 0. </param>
        /// <param name="numTaskRetries"> The total number of retries on all the Tasks in the Job during the given time range. </param>
        /// <param name="waitTime"> The total wait time of all Tasks in the Job. The wait time for a Task is defined as the elapsed time between the creation of the Task and the start of Task execution. (If the Task is retried due to failures, the wait time is the time to the most recent Task execution.) This value is only reported in the Account lifetime statistics; it is not included in the Job statistics. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchJobStatistics(string url, DateTimeOffset startTime, DateTimeOffset lastUpdateTime, TimeSpan userCpuTime, TimeSpan kernelCpuTime, TimeSpan wallClockTime, long readIOps, long writeIOps, float readIOGiB, float writeIOGiB, long numSucceededTasks, long numFailedTasks, long numTaskRetries, TimeSpan waitTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Url = url;
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
            UserCpuTime = userCpuTime;
            KernelCpuTime = kernelCpuTime;
            WallClockTime = wallClockTime;
            ReadIOps = readIOps;
            WriteIOps = writeIOps;
            ReadIOGiB = readIOGiB;
            WriteIOGiB = writeIOGiB;
            NumSucceededTasks = numSucceededTasks;
            NumFailedTasks = numFailedTasks;
            NumTaskRetries = numTaskRetries;
            WaitTime = waitTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobStatistics"/> for deserialization. </summary>
        internal BatchJobStatistics()
        {
        }

        /// <summary> The URL of the statistics. </summary>
        public string Url { get; }
        /// <summary> The start time of the time range covered by the statistics. </summary>
        public DateTimeOffset StartTime { get; }
        /// <summary> The time at which the statistics were last updated. All statistics are limited to the range between startTime and lastUpdateTime. </summary>
        public DateTimeOffset LastUpdateTime { get; }
        /// <summary> The total user mode CPU time (summed across all cores and all Compute Nodes) consumed by all Tasks in the Job. </summary>
        public TimeSpan UserCpuTime { get; }
        /// <summary> The total kernel mode CPU time (summed across all cores and all Compute Nodes) consumed by all Tasks in the Job. </summary>
        public TimeSpan KernelCpuTime { get; }
        /// <summary> The total wall clock time of all Tasks in the Job.  The wall clock time is the elapsed time from when the Task started running on a Compute Node to when it finished (or to the last time the statistics were updated, if the Task had not finished by then). If a Task was retried, this includes the wall clock time of all the Task retries. </summary>
        public TimeSpan WallClockTime { get; }
        /// <summary> The total number of disk read operations made by all Tasks in the Job. </summary>
        public long ReadIOps { get; }
        /// <summary> The total number of disk write operations made by all Tasks in the Job. </summary>
        public long WriteIOps { get; }
        /// <summary> The total amount of data in GiB read from disk by all Tasks in the Job. </summary>
        public float ReadIOGiB { get; }
        /// <summary> The total amount of data in GiB written to disk by all Tasks in the Job. </summary>
        public float WriteIOGiB { get; }
        /// <summary> The total number of Tasks successfully completed in the Job during the given time range. A Task completes successfully if it returns exit code 0. </summary>
        public long NumSucceededTasks { get; }
        /// <summary> The total number of Tasks in the Job that failed during the given time range. A Task fails if it exhausts its maximum retry count without returning exit code 0. </summary>
        public long NumFailedTasks { get; }
        /// <summary> The total number of retries on all the Tasks in the Job during the given time range. </summary>
        public long NumTaskRetries { get; }
        /// <summary> The total wait time of all Tasks in the Job. The wait time for a Task is defined as the elapsed time between the creation of the Task and the start of Task execution. (If the Task is retried due to failures, the wait time is the time to the most recent Task execution.) This value is only reported in the Account lifetime statistics; it is not included in the Job statistics. </summary>
        public TimeSpan WaitTime { get; }
    }
}
