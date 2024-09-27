// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The AcsMessageInteractiveButtonReplyContent. </summary>
    public partial class AcsMessageInteractiveButtonReplyContent
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

        /// <summary> Initializes a new instance of <see cref="AcsMessageInteractiveButtonReplyContent"/>. </summary>
        internal AcsMessageInteractiveButtonReplyContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageInteractiveButtonReplyContent"/>. </summary>
        /// <param name="buttonId"></param>
        /// <param name="title"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsMessageInteractiveButtonReplyContent(string buttonId, string title, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ButtonId = buttonId;
            Title = title;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the button id. </summary>
        public string ButtonId { get; }
        /// <summary> Gets the title. </summary>
        public string Title { get; }
    }
}
