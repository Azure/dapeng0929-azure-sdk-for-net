// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The WebRestoreOperationStartedEventData. </summary>
    public partial class WebRestoreOperationStartedEventData
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

        /// <summary> Initializes a new instance of <see cref="WebRestoreOperationStartedEventData"/>. </summary>
        /// <param name="appEventTypeDetail"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="appEventTypeDetail"/> is null. </exception>
        internal WebRestoreOperationStartedEventData(AppEventTypeDetail appEventTypeDetail)
        {
            Argument.AssertNotNull(appEventTypeDetail, nameof(appEventTypeDetail));

            AppEventTypeDetail = appEventTypeDetail;
        }

        /// <summary> Initializes a new instance of <see cref="WebRestoreOperationStartedEventData"/>. </summary>
        /// <param name="appEventTypeDetail"></param>
        /// <param name="name"></param>
        /// <param name="clientRequestId"></param>
        /// <param name="correlationRequestId"></param>
        /// <param name="requestId"></param>
        /// <param name="address"></param>
        /// <param name="verb"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebRestoreOperationStartedEventData(AppEventTypeDetail appEventTypeDetail, string name, string clientRequestId, string correlationRequestId, string requestId, string address, string verb, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AppEventTypeDetail = appEventTypeDetail;
            Name = name;
            ClientRequestId = clientRequestId;
            CorrelationRequestId = correlationRequestId;
            RequestId = requestId;
            Address = address;
            Verb = verb;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebRestoreOperationStartedEventData"/> for deserialization. </summary>
        internal WebRestoreOperationStartedEventData()
        {
        }

        /// <summary> Gets the app event type detail. </summary>
        public AppEventTypeDetail AppEventTypeDetail { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the client request id. </summary>
        public string ClientRequestId { get; }
        /// <summary> Gets the correlation request id. </summary>
        public string CorrelationRequestId { get; }
        /// <summary> Gets the request id. </summary>
        public string RequestId { get; }
        /// <summary> Gets the address. </summary>
        public string Address { get; }
        /// <summary> Gets the verb. </summary>
        public string Verb { get; }
    }
}
