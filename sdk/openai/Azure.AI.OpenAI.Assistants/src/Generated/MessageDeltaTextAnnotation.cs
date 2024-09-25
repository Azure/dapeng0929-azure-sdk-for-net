// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary>
    /// The abstract base representation of a streamed text content part's text annotation.
    /// Please note <see cref="MessageDeltaTextAnnotation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MessageDeltaTextFileCitationAnnotationObject"/> and <see cref="MessageDeltaTextFilePathAnnotationObject"/>.
    /// </summary>
    public abstract partial class MessageDeltaTextAnnotation
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

        /// <summary> Initializes a new instance of <see cref="MessageDeltaTextAnnotation"/>. </summary>
        /// <param name="index"> The index of the annotation within a text content part. </param>
        protected MessageDeltaTextAnnotation(int index)
        {
            Index = index;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaTextAnnotation"/>. </summary>
        /// <param name="index"> The index of the annotation within a text content part. </param>
        /// <param name="type"> The type of the text content annotation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageDeltaTextAnnotation(int index, string type, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Index = index;
            Type = type;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaTextAnnotation"/> for deserialization. </summary>
        internal MessageDeltaTextAnnotation()
        {
        }

        /// <summary> The index of the annotation within a text content part. </summary>
        public int Index { get; }
        /// <summary> The type of the text content annotation. </summary>
        internal string Type { get; set; }
    }
}
