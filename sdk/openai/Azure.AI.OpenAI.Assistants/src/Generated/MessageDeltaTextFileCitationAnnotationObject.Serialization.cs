// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    public partial class MessageDeltaTextFileCitationAnnotationObject : IUtf8JsonSerializable, IJsonModel<MessageDeltaTextFileCitationAnnotationObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MessageDeltaTextFileCitationAnnotationObject>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MessageDeltaTextFileCitationAnnotationObject>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageDeltaTextFileCitationAnnotationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageDeltaTextFileCitationAnnotationObject)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FileCitation))
            {
                writer.WritePropertyName("file_citation"u8);
                writer.WriteObjectValue(FileCitation, options);
            }
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            if (Optional.IsDefined(StartIndex))
            {
                writer.WritePropertyName("start_index"u8);
                writer.WriteNumberValue(StartIndex.Value);
            }
            if (Optional.IsDefined(EndIndex))
            {
                writer.WritePropertyName("end_index"u8);
                writer.WriteNumberValue(EndIndex.Value);
            }
            writer.WritePropertyName("index"u8);
            writer.WriteNumberValue(Index);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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

        MessageDeltaTextFileCitationAnnotationObject IJsonModel<MessageDeltaTextFileCitationAnnotationObject>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageDeltaTextFileCitationAnnotationObject>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageDeltaTextFileCitationAnnotationObject)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageDeltaTextFileCitationAnnotationObject(document.RootElement, options);
        }

        internal static MessageDeltaTextFileCitationAnnotationObject DeserializeMessageDeltaTextFileCitationAnnotationObject(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MessageDeltaTextFileCitationAnnotation fileCitation = default;
            string text = default;
            int? startIndex = default;
            int? endIndex = default;
            int index = default;
            string type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file_citation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileCitation = MessageDeltaTextFileCitationAnnotation.DeserializeMessageDeltaTextFileCitationAnnotation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start_index"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("end_index"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MessageDeltaTextFileCitationAnnotationObject(
                index,
                type,
                serializedAdditionalRawData,
                fileCitation,
                text,
                startIndex,
                endIndex);
        }

        BinaryData IPersistableModel<MessageDeltaTextFileCitationAnnotationObject>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageDeltaTextFileCitationAnnotationObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageDeltaTextFileCitationAnnotationObject)} does not support writing '{options.Format}' format.");
            }
        }

        MessageDeltaTextFileCitationAnnotationObject IPersistableModel<MessageDeltaTextFileCitationAnnotationObject>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageDeltaTextFileCitationAnnotationObject>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessageDeltaTextFileCitationAnnotationObject(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageDeltaTextFileCitationAnnotationObject)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageDeltaTextFileCitationAnnotationObject>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new MessageDeltaTextFileCitationAnnotationObject FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMessageDeltaTextFileCitationAnnotationObject(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
