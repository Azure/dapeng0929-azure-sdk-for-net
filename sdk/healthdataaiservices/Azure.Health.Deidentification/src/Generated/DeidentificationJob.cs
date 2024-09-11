// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Deidentification
{
    /// <summary> A job containing a batch of documents to de-identify. </summary>
    public partial class DeidentificationJob
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

        /// <summary> Initializes a new instance of <see cref="DeidentificationJob"/>. </summary>
        /// <param name="sourceLocation"> Storage location to perform the operation on. </param>
        /// <param name="targetLocation"> Target location to store output of operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceLocation"/> or <paramref name="targetLocation"/> is null. </exception>
        public DeidentificationJob(SourceStorageLocation sourceLocation, TargetStorageLocation targetLocation)
        {
            Argument.AssertNotNull(sourceLocation, nameof(sourceLocation));
            Argument.AssertNotNull(targetLocation, nameof(targetLocation));

            SourceLocation = sourceLocation;
            TargetLocation = targetLocation;
        }

        /// <summary> Initializes a new instance of <see cref="DeidentificationJob"/>. </summary>
        /// <param name="name"> The name of a job. </param>
        /// <param name="sourceLocation"> Storage location to perform the operation on. </param>
        /// <param name="targetLocation"> Target location to store output of operation. </param>
        /// <param name="operation"> Operation to perform on the input documents. </param>
        /// <param name="dataType"> Data type of the input documents. </param>
        /// <param name="customizations"> Customization parameters to override default service behaviors. </param>
        /// <param name="status"> Current status of a job. </param>
        /// <param name="error"> Error when job fails in it's entirety. </param>
        /// <param name="lastUpdatedAt">
        /// Date and time when the job was completed.
        ///
        /// If the job is canceled, this is the time when the job was canceled.
        ///
        /// If the job failed, this is the time when the job failed.
        /// </param>
        /// <param name="createdAt"> Date and time when the job was created. </param>
        /// <param name="startedAt"> Date and time when the job was started. </param>
        /// <param name="summary"> Summary of a job. Exists only when the job is completed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeidentificationJob(string name, SourceStorageLocation sourceLocation, TargetStorageLocation targetLocation, OperationType? operation, DocumentDataType? dataType, CustomizationOptions customizations, JobStatus status, ResponseError error, DateTimeOffset lastUpdatedAt, DateTimeOffset createdAt, DateTimeOffset? startedAt, JobSummary summary, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            SourceLocation = sourceLocation;
            TargetLocation = targetLocation;
            Operation = operation;
            DataType = dataType;
            Customizations = customizations;
            Status = status;
            Error = error;
            LastUpdatedAt = lastUpdatedAt;
            CreatedAt = createdAt;
            StartedAt = startedAt;
            Summary = summary;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeidentificationJob"/> for deserialization. </summary>
        internal DeidentificationJob()
        {
        }

        /// <summary> The name of a job. </summary>
        public string Name { get; }
        /// <summary> Storage location to perform the operation on. </summary>
        public SourceStorageLocation SourceLocation { get; set; }
        /// <summary> Target location to store output of operation. </summary>
        public TargetStorageLocation TargetLocation { get; set; }
        /// <summary> Operation to perform on the input documents. </summary>
        public OperationType? Operation { get; set; }
        /// <summary> Data type of the input documents. </summary>
        public DocumentDataType? DataType { get; set; }
        /// <summary> Customization parameters to override default service behaviors. </summary>
        public CustomizationOptions Customizations { get; set; }
        /// <summary> Current status of a job. </summary>
        public JobStatus Status { get; }
        /// <summary> Error when job fails in it's entirety. </summary>
        public ResponseError Error { get; }
        /// <summary>
        /// Date and time when the job was completed.
        ///
        /// If the job is canceled, this is the time when the job was canceled.
        ///
        /// If the job failed, this is the time when the job failed.
        /// </summary>
        public DateTimeOffset LastUpdatedAt { get; }
        /// <summary> Date and time when the job was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> Date and time when the job was started. </summary>
        public DateTimeOffset? StartedAt { get; }
        /// <summary> Summary of a job. Exists only when the job is completed. </summary>
        public JobSummary Summary { get; }
    }
}
