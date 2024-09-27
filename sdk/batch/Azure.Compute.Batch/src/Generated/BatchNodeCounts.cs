// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchNodeCounts. </summary>
    public partial class BatchNodeCounts
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

        /// <summary> Initializes a new instance of <see cref="BatchNodeCounts"/>. </summary>
        /// <param name="creating"></param>
        /// <param name="idle"></param>
        /// <param name="offline"></param>
        /// <param name="preempted"></param>
        /// <param name="rebooting"></param>
        /// <param name="reimaging"></param>
        /// <param name="running"></param>
        /// <param name="starting"></param>
        /// <param name="startTaskFailed"></param>
        /// <param name="leavingPool"></param>
        /// <param name="unknown"></param>
        /// <param name="unusable"></param>
        /// <param name="waitingForStartTask"></param>
        /// <param name="total"></param>
        /// <param name="upgradingOs"></param>
        internal BatchNodeCounts(int creating, int idle, int offline, int preempted, int rebooting, int reimaging, int running, int starting, int startTaskFailed, int leavingPool, int unknown, int unusable, int waitingForStartTask, int total, int upgradingOs)
        {
            Creating = creating;
            Idle = idle;
            Offline = offline;
            Preempted = preempted;
            Rebooting = rebooting;
            Reimaging = reimaging;
            Running = running;
            Starting = starting;
            StartTaskFailed = startTaskFailed;
            LeavingPool = leavingPool;
            Unknown = unknown;
            Unusable = unusable;
            WaitingForStartTask = waitingForStartTask;
            Total = total;
            UpgradingOs = upgradingOs;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeCounts"/>. </summary>
        /// <param name="creating"></param>
        /// <param name="idle"></param>
        /// <param name="offline"></param>
        /// <param name="preempted"></param>
        /// <param name="rebooting"></param>
        /// <param name="reimaging"></param>
        /// <param name="running"></param>
        /// <param name="starting"></param>
        /// <param name="startTaskFailed"></param>
        /// <param name="leavingPool"></param>
        /// <param name="unknown"></param>
        /// <param name="unusable"></param>
        /// <param name="waitingForStartTask"></param>
        /// <param name="total"></param>
        /// <param name="upgradingOs"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNodeCounts(int creating, int idle, int offline, int preempted, int rebooting, int reimaging, int running, int starting, int startTaskFailed, int leavingPool, int unknown, int unusable, int waitingForStartTask, int total, int upgradingOs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Creating = creating;
            Idle = idle;
            Offline = offline;
            Preempted = preempted;
            Rebooting = rebooting;
            Reimaging = reimaging;
            Running = running;
            Starting = starting;
            StartTaskFailed = startTaskFailed;
            LeavingPool = leavingPool;
            Unknown = unknown;
            Unusable = unusable;
            WaitingForStartTask = waitingForStartTask;
            Total = total;
            UpgradingOs = upgradingOs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeCounts"/> for deserialization. </summary>
        internal BatchNodeCounts()
        {
        }

        /// <summary> Gets the creating. </summary>
        public int Creating { get; }
        /// <summary> Gets the idle. </summary>
        public int Idle { get; }
        /// <summary> Gets the offline. </summary>
        public int Offline { get; }
        /// <summary> Gets the preempted. </summary>
        public int Preempted { get; }
        /// <summary> Gets the rebooting. </summary>
        public int Rebooting { get; }
        /// <summary> Gets the reimaging. </summary>
        public int Reimaging { get; }
        /// <summary> Gets the running. </summary>
        public int Running { get; }
        /// <summary> Gets the starting. </summary>
        public int Starting { get; }
        /// <summary> Gets the start task failed. </summary>
        public int StartTaskFailed { get; }
        /// <summary> Gets the leaving pool. </summary>
        public int LeavingPool { get; }
        /// <summary> Gets the unknown. </summary>
        public int Unknown { get; }
        /// <summary> Gets the unusable. </summary>
        public int Unusable { get; }
        /// <summary> Gets the waiting for start task. </summary>
        public int WaitingForStartTask { get; }
        /// <summary> Gets the total. </summary>
        public int Total { get; }
        /// <summary> Gets the upgrading os. </summary>
        public int UpgradingOs { get; }
    }
}
