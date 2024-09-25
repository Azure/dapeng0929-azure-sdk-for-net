// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> Information providing additional detail about a message entering an incomplete status. </summary>
    public partial class MessageIncompleteDetails
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

        /// <summary> Initializes a new instance of <see cref="MessageIncompleteDetails"/>. </summary>
        /// <param name="reason"> The provided reason describing why the message was marked as incomplete. </param>
        public MessageIncompleteDetails(MessageIncompleteDetailsReason reason)
        {
            Reason = reason;
        }

        /// <summary> Initializes a new instance of <see cref="MessageIncompleteDetails"/>. </summary>
        /// <param name="reason"> The provided reason describing why the message was marked as incomplete. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageIncompleteDetails(MessageIncompleteDetailsReason reason, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Reason = reason;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MessageIncompleteDetails"/> for deserialization. </summary>
        internal MessageIncompleteDetails()
        {
        }

        /// <summary> The provided reason describing why the message was marked as incomplete. </summary>
        public MessageIncompleteDetailsReason Reason { get; set; }
    }
}
