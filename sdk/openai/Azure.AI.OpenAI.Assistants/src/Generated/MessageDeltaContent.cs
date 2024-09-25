// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary>
    /// The abstract base representation of a partial streamed message content payload.
    /// Please note <see cref="MessageDeltaContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MessageDeltaImageFileContent"/> and <see cref="MessageDeltaTextContentObject"/>.
    /// </summary>
    public abstract partial class MessageDeltaContent
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

        /// <summary> Initializes a new instance of <see cref="MessageDeltaContent"/>. </summary>
        /// <param name="index"> The index of the content part of the message. </param>
        protected MessageDeltaContent(int index)
        {
            Index = index;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaContent"/>. </summary>
        /// <param name="index"> The index of the content part of the message. </param>
        /// <param name="type"> The type of content for this content part. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageDeltaContent(int index, string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Index = index;
            Type = type;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaContent"/> for deserialization. </summary>
        internal MessageDeltaContent()
        {
        }

        /// <summary> The index of the content part of the message. </summary>
        public int Index { get; }
        /// <summary> The type of content for this content part. </summary>
        internal string Type { get; set; }
    }
}
