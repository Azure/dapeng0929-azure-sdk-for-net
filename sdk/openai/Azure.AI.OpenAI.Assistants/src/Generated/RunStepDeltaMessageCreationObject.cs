// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> Represents the data within a streaming run step message creation response object. </summary>
    public partial class RunStepDeltaMessageCreationObject
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

        /// <summary> Initializes a new instance of <see cref="RunStepDeltaMessageCreationObject"/>. </summary>
        internal RunStepDeltaMessageCreationObject()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RunStepDeltaMessageCreationObject"/>. </summary>
        /// <param name="messageId"> The ID of the newly-created message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RunStepDeltaMessageCreationObject(string messageId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MessageId = messageId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the newly-created message. </summary>
        public string MessageId { get; }
    }
}
