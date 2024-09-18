// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The Batch object. </summary>
    internal partial class Batch
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

        /// <summary> Initializes a new instance of <see cref="OpenAI.Batch"/>. </summary>
        /// <param name="id"> The id assigned to the Batch. </param>
        /// <param name="inputFileId"> The ID of the input file for the batch. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="inputFileId"/> is null. </exception>
        internal Batch(string id, string inputFileId)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(inputFileId, nameof(inputFileId));

            Id = id;
            InputFileId = inputFileId;
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="OpenAI.Batch"/>. </summary>
        /// <param name="id"> The id assigned to the Batch. </param>
        /// <param name="object"> The object type, which is always `batch`. </param>
        /// <param name="endpoint"> The OpenAI API endpoint used by the batch. </param>
        /// <param name="errors"> The list of Batch errors. </param>
        /// <param name="inputFileId"> The ID of the input file for the batch. </param>
        /// <param name="completionWindow"> The time frame within which the batch should be processed. </param>
        /// <param name="status"> The current status of the batch. </param>
        /// <param name="outputFileId"> The ID of the file containing the outputs of successfully executed requests. </param>
        /// <param name="errorFileId"> The ID of the file containing the outputs of requests with errors. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the batch was created. </param>
        /// <param name="inProgressAt"> The Unix timestamp (in seconds) for when the batch started processing. </param>
        /// <param name="expiresAt"> The Unix timestamp (in seconds) for when the batch will expire. </param>
        /// <param name="finalizingAt"> The Unix timestamp (in seconds) for when the batch started finalizing. </param>
        /// <param name="completedAt"> The Unix timestamp (in seconds) for when the batch was completed. </param>
        /// <param name="failedAt"> The Unix timestamp (in seconds) for when the batch failed. </param>
        /// <param name="expiredAt"> The Unix timestamp (in seconds) for when the batch expired. </param>
        /// <param name="cancellingAt"> The Unix timestamp (in seconds) for when the batch started cancelling. </param>
        /// <param name="cancelledAt"> The Unix timestamp (in seconds) for when the batch was cancelled. </param>
        /// <param name="requestCounts"> The request counts for different statuses within the batch. </param>
        /// <param name="metadata"> A set of key-value pairs that can be attached to the batch. This can be useful for storing additional information about the batch in a structured format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Batch(string id, BatchObject @object, string endpoint, BatchErrorList errors, string inputFileId, string completionWindow, BatchStatus? status, string outputFileId, string errorFileId, DateTimeOffset? createdAt, DateTimeOffset? inProgressAt, DateTimeOffset? expiresAt, DateTimeOffset? finalizingAt, DateTimeOffset? completedAt, DateTimeOffset? failedAt, DateTimeOffset? expiredAt, DateTimeOffset? cancellingAt, DateTimeOffset? cancelledAt, BatchRequestCounts requestCounts, IReadOnlyDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            Endpoint = endpoint;
            Errors = errors;
            InputFileId = inputFileId;
            CompletionWindow = completionWindow;
            Status = status;
            OutputFileId = outputFileId;
            ErrorFileId = errorFileId;
            CreatedAt = createdAt;
            InProgressAt = inProgressAt;
            ExpiresAt = expiresAt;
            FinalizingAt = finalizingAt;
            CompletedAt = completedAt;
            FailedAt = failedAt;
            ExpiredAt = expiredAt;
            CancellingAt = cancellingAt;
            CancelledAt = cancelledAt;
            RequestCounts = requestCounts;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OpenAI.Batch"/> for deserialization. </summary>
        internal Batch()
        {
        }

        /// <summary> The id assigned to the Batch. </summary>
        public string Id { get; }
        /// <summary> The object type, which is always `batch`. </summary>
        public BatchObject Object { get; } = BatchObject.Batch;

        /// <summary> The OpenAI API endpoint used by the batch. </summary>
        public string Endpoint { get; }
        /// <summary> The list of Batch errors. </summary>
        public BatchErrorList Errors { get; }
        /// <summary> The ID of the input file for the batch. </summary>
        public string InputFileId { get; }
        /// <summary> The time frame within which the batch should be processed. </summary>
        public string CompletionWindow { get; }
        /// <summary> The current status of the batch. </summary>
        public BatchStatus? Status { get; }
        /// <summary> The ID of the file containing the outputs of successfully executed requests. </summary>
        public string OutputFileId { get; }
        /// <summary> The ID of the file containing the outputs of requests with errors. </summary>
        public string ErrorFileId { get; }
        /// <summary> The Unix timestamp (in seconds) for when the batch was created. </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the batch started processing. </summary>
        public DateTimeOffset? InProgressAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the batch will expire. </summary>
        public DateTimeOffset? ExpiresAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the batch started finalizing. </summary>
        public DateTimeOffset? FinalizingAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the batch was completed. </summary>
        public DateTimeOffset? CompletedAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the batch failed. </summary>
        public DateTimeOffset? FailedAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the batch expired. </summary>
        public DateTimeOffset? ExpiredAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the batch started cancelling. </summary>
        public DateTimeOffset? CancellingAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the batch was cancelled. </summary>
        public DateTimeOffset? CancelledAt { get; }
        /// <summary> The request counts for different statuses within the batch. </summary>
        public BatchRequestCounts RequestCounts { get; }
        /// <summary> A set of key-value pairs that can be attached to the batch. This can be useful for storing additional information about the batch in a structured format. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
