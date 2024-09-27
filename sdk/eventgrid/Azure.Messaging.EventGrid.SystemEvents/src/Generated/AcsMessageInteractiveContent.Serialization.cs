// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsMessageInteractiveContent : IUtf8JsonSerializable, IJsonModel<AcsMessageInteractiveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsMessageInteractiveContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AcsMessageInteractiveContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsMessageInteractiveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsMessageInteractiveContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReplyKind))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ReplyKind.Value.ToString());
            }
            writer.WritePropertyName("buttonReply"u8);
            writer.WriteObjectValue(ButtonReply, options);
            writer.WritePropertyName("listReply"u8);
            writer.WriteObjectValue(ListReply, options);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AcsMessageInteractiveContent IJsonModel<AcsMessageInteractiveContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsMessageInteractiveContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsMessageInteractiveContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsMessageInteractiveContent(document.RootElement, options);
        }

        internal static AcsMessageInteractiveContent DeserializeAcsMessageInteractiveContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AcsInteractiveReplyKind? type = default;
            AcsMessageInteractiveButtonReplyContent buttonReply = default;
            AcsMessageInteractiveListReplyContent listReply = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new AcsInteractiveReplyKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("buttonReply"u8))
                {
                    buttonReply = AcsMessageInteractiveButtonReplyContent.DeserializeAcsMessageInteractiveButtonReplyContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("listReply"u8))
                {
                    listReply = AcsMessageInteractiveListReplyContent.DeserializeAcsMessageInteractiveListReplyContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AcsMessageInteractiveContent(type, buttonReply, listReply, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AcsMessageInteractiveContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsMessageInteractiveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AcsMessageInteractiveContent)} does not support writing '{options.Format}' format.");
            }
        }

        AcsMessageInteractiveContent IPersistableModel<AcsMessageInteractiveContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsMessageInteractiveContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAcsMessageInteractiveContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AcsMessageInteractiveContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsMessageInteractiveContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AcsMessageInteractiveContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAcsMessageInteractiveContent(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
