// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchJobSpecification. </summary>
    public partial class BatchJobSpecification
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

        /// <summary> Initializes a new instance of <see cref="BatchJobSpecification"/>. </summary>
        /// <param name="poolInfo"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="poolInfo"/> is null. </exception>
        public BatchJobSpecification(BatchPoolInfo poolInfo)
        {
            Argument.AssertNotNull(poolInfo, nameof(poolInfo));

            CommonEnvironmentSettings = new ChangeTrackingList<EnvironmentSetting>();
            PoolInfo = poolInfo;
            Metadata = new ChangeTrackingList<MetadataItem>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobSpecification"/>. </summary>
        /// <param name="priority"></param>
        /// <param name="allowTaskPreemption"></param>
        /// <param name="maxParallelTasks"></param>
        /// <param name="displayName"></param>
        /// <param name="usesTaskDependencies"></param>
        /// <param name="onAllTasksComplete"></param>
        /// <param name="onTaskFailure"></param>
        /// <param name="networkConfiguration"></param>
        /// <param name="constraints"></param>
        /// <param name="jobManagerTask"></param>
        /// <param name="jobPreparationTask"></param>
        /// <param name="jobReleaseTask"></param>
        /// <param name="commonEnvironmentSettings"></param>
        /// <param name="poolInfo"></param>
        /// <param name="metadata"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchJobSpecification(int? priority, bool? allowTaskPreemption, int? maxParallelTasks, string displayName, bool? usesTaskDependencies, OnAllBatchTasksComplete? onAllTasksComplete, OnBatchTaskFailure? onTaskFailure, BatchJobNetworkConfiguration networkConfiguration, BatchJobConstraints constraints, BatchJobManagerTask jobManagerTask, BatchJobPreparationTask jobPreparationTask, BatchJobReleaseTask jobReleaseTask, IList<EnvironmentSetting> commonEnvironmentSettings, BatchPoolInfo poolInfo, IList<MetadataItem> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Priority = priority;
            AllowTaskPreemption = allowTaskPreemption;
            MaxParallelTasks = maxParallelTasks;
            DisplayName = displayName;
            UsesTaskDependencies = usesTaskDependencies;
            OnAllTasksComplete = onAllTasksComplete;
            OnTaskFailure = onTaskFailure;
            NetworkConfiguration = networkConfiguration;
            Constraints = constraints;
            JobManagerTask = jobManagerTask;
            JobPreparationTask = jobPreparationTask;
            JobReleaseTask = jobReleaseTask;
            CommonEnvironmentSettings = commonEnvironmentSettings;
            PoolInfo = poolInfo;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobSpecification"/> for deserialization. </summary>
        internal BatchJobSpecification()
        {
        }

        /// <summary> Gets or sets the priority. </summary>
        public int? Priority { get; set; }
        /// <summary> Gets or sets the allow task preemption. </summary>
        public bool? AllowTaskPreemption { get; set; }
        /// <summary> Gets or sets the max parallel tasks. </summary>
        public int? MaxParallelTasks { get; set; }
        /// <summary> Gets or sets the display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Gets or sets the uses task dependencies. </summary>
        public bool? UsesTaskDependencies { get; set; }
        /// <summary> Gets or sets the on all tasks complete. </summary>
        public OnAllBatchTasksComplete? OnAllTasksComplete { get; set; }
        /// <summary> Gets or sets the on task failure. </summary>
        public OnBatchTaskFailure? OnTaskFailure { get; set; }
        /// <summary> Gets or sets the network configuration. </summary>
        public BatchJobNetworkConfiguration NetworkConfiguration { get; set; }
        /// <summary> Gets or sets the constraints. </summary>
        public BatchJobConstraints Constraints { get; set; }
        /// <summary> Gets or sets the job manager task. </summary>
        public BatchJobManagerTask JobManagerTask { get; set; }
        /// <summary> Gets or sets the job preparation task. </summary>
        public BatchJobPreparationTask JobPreparationTask { get; set; }
        /// <summary> Gets or sets the job release task. </summary>
        public BatchJobReleaseTask JobReleaseTask { get; set; }
        /// <summary> Gets the common environment settings. </summary>
        public IList<EnvironmentSetting> CommonEnvironmentSettings { get; }
        /// <summary> Gets or sets the pool info. </summary>
        public BatchPoolInfo PoolInfo { get; set; }
        /// <summary> Gets the metadata. </summary>
        public IList<MetadataItem> Metadata { get; }
    }
}
