// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> Request for creating liveness with verify session. </summary>
    internal partial class CreateLivenessWithVerifySessionJsonContent
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

        /// <summary> Initializes a new instance of <see cref="CreateLivenessWithVerifySessionJsonContent"/>. </summary>
        /// <param name="livenessOperationMode"> Type of liveness mode the client should follow. </param>
        public CreateLivenessWithVerifySessionJsonContent(LivenessOperationMode livenessOperationMode)
        {
            LivenessOperationMode = livenessOperationMode;
        }

        /// <summary> Initializes a new instance of <see cref="CreateLivenessWithVerifySessionJsonContent"/>. </summary>
        /// <param name="livenessOperationMode"> Type of liveness mode the client should follow. </param>
        /// <param name="sendResultsToClient"> Whether or not to allow a '200 - Success' response body to be sent to the client, which may be undesirable for security reasons. Default is false, clients will receive a '204 - NoContent' empty body response. Regardless of selection, calling Session GetResult will always contain a response body enabling business logic to be implemented. </param>
        /// <param name="deviceCorrelationIdSetInClient"> Whether or not to allow client to set their own 'deviceCorrelationId' via the Vision SDK. Default is false, and 'deviceCorrelationId' must be set in this request body. </param>
        /// <param name="enableSessionImage"> Whether or not store the session image. </param>
        /// <param name="livenessSingleModalModel"> The model version used for liveness classification. This is an optional parameter, and if this is not specified, then the latest supported model version will be chosen. </param>
        /// <param name="deviceCorrelationId"> Unique Guid per each end-user device. This is to provide rate limiting and anti-hammering. If 'deviceCorrelationIdSetInClient' is true in this request, this 'deviceCorrelationId' must be null. </param>
        /// <param name="authTokenTimeToLiveInSeconds"> Seconds the session should last for. Range is 60 to 86400 seconds. Default value is 600. </param>
        /// <param name="returnVerifyImageHash"> Whether or not return the verify image hash. </param>
        /// <param name="verifyConfidenceThreshold"> Threshold for confidence of the face verification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateLivenessWithVerifySessionJsonContent(LivenessOperationMode livenessOperationMode, bool? sendResultsToClient, bool? deviceCorrelationIdSetInClient, bool? enableSessionImage, LivenessModel? livenessSingleModalModel, string deviceCorrelationId, int? authTokenTimeToLiveInSeconds, bool? returnVerifyImageHash, float? verifyConfidenceThreshold, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LivenessOperationMode = livenessOperationMode;
            SendResultsToClient = sendResultsToClient;
            DeviceCorrelationIdSetInClient = deviceCorrelationIdSetInClient;
            EnableSessionImage = enableSessionImage;
            LivenessSingleModalModel = livenessSingleModalModel;
            DeviceCorrelationId = deviceCorrelationId;
            AuthTokenTimeToLiveInSeconds = authTokenTimeToLiveInSeconds;
            ReturnVerifyImageHash = returnVerifyImageHash;
            VerifyConfidenceThreshold = verifyConfidenceThreshold;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateLivenessWithVerifySessionJsonContent"/> for deserialization. </summary>
        internal CreateLivenessWithVerifySessionJsonContent()
        {
        }

        /// <summary> Type of liveness mode the client should follow. </summary>
        public LivenessOperationMode LivenessOperationMode { get; }
        /// <summary> Whether or not to allow a '200 - Success' response body to be sent to the client, which may be undesirable for security reasons. Default is false, clients will receive a '204 - NoContent' empty body response. Regardless of selection, calling Session GetResult will always contain a response body enabling business logic to be implemented. </summary>
        public bool? SendResultsToClient { get; set; }
        /// <summary> Whether or not to allow client to set their own 'deviceCorrelationId' via the Vision SDK. Default is false, and 'deviceCorrelationId' must be set in this request body. </summary>
        public bool? DeviceCorrelationIdSetInClient { get; set; }
        /// <summary> Whether or not store the session image. </summary>
        public bool? EnableSessionImage { get; set; }
        /// <summary> The model version used for liveness classification. This is an optional parameter, and if this is not specified, then the latest supported model version will be chosen. </summary>
        public LivenessModel? LivenessSingleModalModel { get; set; }
        /// <summary> Unique Guid per each end-user device. This is to provide rate limiting and anti-hammering. If 'deviceCorrelationIdSetInClient' is true in this request, this 'deviceCorrelationId' must be null. </summary>
        public string DeviceCorrelationId { get; set; }
        /// <summary> Seconds the session should last for. Range is 60 to 86400 seconds. Default value is 600. </summary>
        public int? AuthTokenTimeToLiveInSeconds { get; set; }
        /// <summary> Whether or not return the verify image hash. </summary>
        public bool? ReturnVerifyImageHash { get; set; }
        /// <summary> Threshold for confidence of the face verification. </summary>
        public float? VerifyConfidenceThreshold { get; set; }
    }
}
