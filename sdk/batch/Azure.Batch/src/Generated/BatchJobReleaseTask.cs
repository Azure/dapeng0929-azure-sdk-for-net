// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary>
    /// A Job Release Task to run on Job completion on any Compute Node where the Job has run.
    /// The Job Release Task runs when the Job ends, because of one of the following:
    /// The user calls the Terminate Job API, or the Delete Job API while the Job is
    /// still active, the Job's maximum wall clock time constraint is reached, and the
    /// Job is still active, or the Job's Job Manager Task completed, and the Job is
    /// configured to terminate when the Job Manager completes. The Job Release Task
    /// runs on each Node where Tasks of the Job have run and the Job Preparation Task
    /// ran and completed. If you reimage a Node after it has run the Job Preparation
    /// Task, and the Job ends without any further Tasks of the Job running on that
    /// Node (and hence the Job Preparation Task does not re-run), then the Job Release
    /// Task does not run on that Compute Node. If a Node reboots while the Job Release
    /// Task is still running, the Job Release Task runs again when the Compute Node
    /// starts up. The Job is not marked as complete until all Job Release Tasks have
    /// completed. The Job Release Task runs in the background. It does not occupy a
    /// scheduling slot; that is, it does not count towards the taskSlotsPerNode limit
    /// specified on the Pool.
    /// </summary>
    public partial class BatchJobReleaseTask
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

        /// <summary> Initializes a new instance of <see cref="BatchJobReleaseTask"/>. </summary>
        /// <param name="commandLine"> The command line of the Job Release Task. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="commandLine"/> is null. </exception>
        public BatchJobReleaseTask(string commandLine)
        {
            Argument.AssertNotNull(commandLine, nameof(commandLine));

            CommandLine = commandLine;
            ResourceFiles = new ChangeTrackingList<ResourceFile>();
            EnvironmentSettings = new ChangeTrackingList<EnvironmentSetting>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobReleaseTask"/>. </summary>
        /// <param name="id"> A string that uniquely identifies the Job Release Task within the Job. The ID can contain any combination of alphanumeric characters including hyphens and underscores and cannot contain more than 64 characters. If you do not specify this property, the Batch service assigns a default value of 'jobrelease'. No other Task in the Job can have the same ID as the Job Release Task. If you try to submit a Task with the same id, the Batch service rejects the request with error code TaskIdSameAsJobReleaseTask; if you are calling the REST API directly, the HTTP status code is 409 (Conflict). </param>
        /// <param name="commandLine"> The command line of the Job Release Task. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </param>
        /// <param name="containerSettings"> The settings for the container under which the Job Release Task runs. When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the node) are mapped into the container, all Task environment variables are mapped into the container, and the Task command line is executed in the container. Files produced in the container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file APIs will not be able to access those files. </param>
        /// <param name="resourceFiles"> A list of files that the Batch service will download to the Compute Node before running the command line.  There is a maximum size for the list of resource files.  When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. Files listed under this element are located in the Task's working directory. </param>
        /// <param name="environmentSettings"> A list of environment variable settings for the Job Release Task. </param>
        /// <param name="maxWallClockTime"> The maximum elapsed time that the Job Release Task may run on a given Compute Node, measured from the time the Task starts. If the Task does not complete within the time limit, the Batch service terminates it. The default value is 15 minutes. You may not specify a timeout longer than 15 minutes. If you do, the Batch service rejects it with an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="retentionTime"> The minimum time to retain the Task directory for the Job Release Task on the Compute Node. After this time, the Batch service may delete the Task directory and all its contents. The default is 7 days, i.e. the Task directory will be retained for 7 days unless the Compute Node is removed or the Job is deleted. </param>
        /// <param name="userIdentity"> The user identity under which the Job Release Task runs. If omitted, the Task runs as a non-administrative user unique to the Task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchJobReleaseTask(string id, string commandLine, BatchTaskContainerSettings containerSettings, IList<ResourceFile> resourceFiles, IList<EnvironmentSetting> environmentSettings, TimeSpan? maxWallClockTime, TimeSpan? retentionTime, UserIdentity userIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CommandLine = commandLine;
            ContainerSettings = containerSettings;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            MaxWallClockTime = maxWallClockTime;
            RetentionTime = retentionTime;
            UserIdentity = userIdentity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobReleaseTask"/> for deserialization. </summary>
        internal BatchJobReleaseTask()
        {
        }

        /// <summary> A string that uniquely identifies the Job Release Task within the Job. The ID can contain any combination of alphanumeric characters including hyphens and underscores and cannot contain more than 64 characters. If you do not specify this property, the Batch service assigns a default value of 'jobrelease'. No other Task in the Job can have the same ID as the Job Release Task. If you try to submit a Task with the same id, the Batch service rejects the request with error code TaskIdSameAsJobReleaseTask; if you are calling the REST API directly, the HTTP status code is 409 (Conflict). </summary>
        public string Id { get; set; }
        /// <summary> The command line of the Job Release Task. The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment variable expansion. If you want to take advantage of such features, you should invoke the shell in the command line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux. If the command line refers to file paths, it should use a relative path (relative to the Task working directory), or use the Batch provided environment variable (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables). </summary>
        public string CommandLine { get; set; }
        /// <summary> The settings for the container under which the Job Release Task runs. When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR (the root of Azure Batch directories on the node) are mapped into the container, all Task environment variables are mapped into the container, and the Task command line is executed in the container. Files produced in the container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file APIs will not be able to access those files. </summary>
        public BatchTaskContainerSettings ContainerSettings { get; set; }
        /// <summary> A list of files that the Batch service will download to the Compute Node before running the command line.  There is a maximum size for the list of resource files.  When the max size is exceeded, the request will fail and the response error code will be RequestEntityTooLarge. If this occurs, the collection of ResourceFiles must be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers. Files listed under this element are located in the Task's working directory. </summary>
        public IList<ResourceFile> ResourceFiles { get; }
        /// <summary> A list of environment variable settings for the Job Release Task. </summary>
        public IList<EnvironmentSetting> EnvironmentSettings { get; }
        /// <summary> The maximum elapsed time that the Job Release Task may run on a given Compute Node, measured from the time the Task starts. If the Task does not complete within the time limit, the Batch service terminates it. The default value is 15 minutes. You may not specify a timeout longer than 15 minutes. If you do, the Batch service rejects it with an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public TimeSpan? MaxWallClockTime { get; set; }
        /// <summary> The minimum time to retain the Task directory for the Job Release Task on the Compute Node. After this time, the Batch service may delete the Task directory and all its contents. The default is 7 days, i.e. the Task directory will be retained for 7 days unless the Compute Node is removed or the Job is deleted. </summary>
        public TimeSpan? RetentionTime { get; set; }
        /// <summary> The user identity under which the Job Release Task runs. If omitted, the Task runs as a non-administrative user unique to the Task. </summary>
        public UserIdentity UserIdentity { get; set; }
    }
}
