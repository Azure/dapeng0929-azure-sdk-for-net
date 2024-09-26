// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class ChatCompletionsJsonSchemaResponseFormatJsonSchema : IUtf8JsonSerializable, IJsonModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionsJsonSchemaResponseFormatJsonSchema)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Schema);
#else
                using (JsonDocument document = JsonDocument.Parse(Schema))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Strict))
            {
                if (Strict != null)
                {
                    writer.WritePropertyName("strict"u8);
                    writer.WriteBooleanValue(Strict.Value);
                }
                else
                {
                    writer.WriteNull("strict");
                }
            }
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

        ChatCompletionsJsonSchemaResponseFormatJsonSchema IJsonModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionsJsonSchemaResponseFormatJsonSchema)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletionsJsonSchemaResponseFormatJsonSchema(document.RootElement, options);
        }

        internal static ChatCompletionsJsonSchemaResponseFormatJsonSchema DeserializeChatCompletionsJsonSchemaResponseFormatJsonSchema(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            string name = default;
            BinaryData schema = default;
            bool? strict = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schema"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schema = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("strict"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        strict = null;
                        continue;
                    }
                    strict = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChatCompletionsJsonSchemaResponseFormatJsonSchema(description, name, schema, strict, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionsJsonSchemaResponseFormatJsonSchema)} does not support writing '{options.Format}' format.");
            }
        }

        ChatCompletionsJsonSchemaResponseFormatJsonSchema IPersistableModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatCompletionsJsonSchemaResponseFormatJsonSchema(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionsJsonSchemaResponseFormatJsonSchema)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletionsJsonSchemaResponseFormatJsonSchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatCompletionsJsonSchemaResponseFormatJsonSchema FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletionsJsonSchemaResponseFormatJsonSchema(document.RootElement);
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
