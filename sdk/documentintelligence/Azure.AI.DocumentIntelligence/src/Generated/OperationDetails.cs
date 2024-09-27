// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary>
    /// The OperationDetails.
    /// Please note <see cref="OperationDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DocumentClassifierBuildOperationDetails"/>, <see cref="DocumentClassifierCopyToOperationDetails"/>, <see cref="DocumentModelBuildOperationDetails"/>, <see cref="DocumentModelComposeOperationDetails"/> and <see cref="DocumentModelCopyToOperationDetails"/>.
    /// </summary>
    public abstract partial class OperationDetails
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationDetails"/>. </summary>
        /// <param name="operationId"></param>
        /// <param name="status"></param>
        /// <param name="createdOn"></param>
        /// <param name="lastUpdatedOn"></param>
        /// <param name="resourceLocation"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="resourceLocation"/> is null. </exception>
        protected OperationDetails(string operationId, OperationStatus status, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, Uri resourceLocation)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
            Argument.AssertNotNull(resourceLocation, nameof(resourceLocation));

            OperationId = operationId;
            Status = status;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            ResourceLocation = resourceLocation;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationDetails"/>. </summary>
        /// <param name="operationId"></param>
        /// <param name="status"></param>
        /// <param name="percentCompleted"></param>
        /// <param name="createdOn"></param>
        /// <param name="lastUpdatedOn"></param>
        /// <param name="kind"></param>
        /// <param name="resourceLocation"></param>
        /// <param name="apiVersion"></param>
        /// <param name="tags"></param>
        /// <param name="error"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationDetails(string operationId, OperationStatus status, int? percentCompleted, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, OperationKind kind, Uri resourceLocation, string apiVersion, IReadOnlyDictionary<string, string> tags, DocumentIntelligenceError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OperationId = operationId;
            Status = status;
            PercentCompleted = percentCompleted;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            Kind = kind;
            ResourceLocation = resourceLocation;
            ApiVersion = apiVersion;
            Tags = tags;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OperationDetails"/> for deserialization. </summary>
        internal OperationDetails()
        {
        }

        /// <summary> Gets the operation id. </summary>
        public string OperationId { get; }
        /// <summary> Gets the status. </summary>
        public OperationStatus Status { get; }
        /// <summary> Gets the percent completed. </summary>
        public int? PercentCompleted { get; }
        /// <summary> Gets the created on. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Gets the last updated on. </summary>
        public DateTimeOffset LastUpdatedOn { get; }
        /// <summary> Gets or sets the kind. </summary>
        internal OperationKind Kind { get; set; }
        /// <summary> Gets the resource location. </summary>
        public Uri ResourceLocation { get; }
        /// <summary> Gets the api version. </summary>
        public string ApiVersion { get; }
        /// <summary> Gets the tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> Gets the error. </summary>
        public DocumentIntelligenceError Error { get; }
    }
}
