// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages.Models.Channels
{
    /// <summary> The WhatsAppMessageTemplateItem. </summary>
    public partial class WhatsAppMessageTemplateItem : MessageTemplateItem
    {
        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateItem"/>. </summary>
        /// <param name="language"></param>
        /// <param name="status"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="language"/> is null. </exception>
        internal WhatsAppMessageTemplateItem(string language, MessageTemplateStatus status) : base(language, status)
        {
            Argument.AssertNotNull(language, nameof(language));

            Kind = CommunicationMessagesChannel.WhatsApp;
        }

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateItem"/>. </summary>
        /// <param name="name"></param>
        /// <param name="language"></param>
        /// <param name="status"></param>
        /// <param name="kind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="content"></param>
        internal WhatsAppMessageTemplateItem(string name, string language, MessageTemplateStatus status, CommunicationMessagesChannel kind, IDictionary<string, BinaryData> serializedAdditionalRawData, BinaryData content) : base(name, language, status, kind, serializedAdditionalRawData)
        {
            Content = content;
        }

        /// <summary> Initializes a new instance of <see cref="WhatsAppMessageTemplateItem"/> for deserialization. </summary>
        internal WhatsAppMessageTemplateItem()
        {
        }

        /// <summary>
        /// Gets the content
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Content { get; }
    }
}
