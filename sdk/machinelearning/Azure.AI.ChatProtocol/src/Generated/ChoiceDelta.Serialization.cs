// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.ChatProtocol
{
    internal partial class ChoiceDelta : IUtf8JsonSerializable, IJsonModel<ChoiceDelta>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChoiceDelta>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChoiceDelta>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChoiceDelta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChoiceDelta)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("index"u8);
            writer.WriteNumberValue(Index);
            writer.WritePropertyName("delta"u8);
            writer.WriteObjectValue(Delta, options);
            if (Optional.IsDefined(SessionState))
            {
                writer.WritePropertyName("sessionState"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SessionState);
#else
                using (JsonDocument document = JsonDocument.Parse(SessionState))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStartObject();
                foreach (var item in Context)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(FinishReason))
            {
                writer.WritePropertyName("finishReason"u8);
                writer.WriteStringValue(FinishReason.Value.ToString());
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

        ChoiceDelta IJsonModel<ChoiceDelta>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChoiceDelta>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChoiceDelta)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChoiceDelta(document.RootElement, options);
        }

        internal static ChoiceDelta DeserializeChoiceDelta(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long index = default;
            ChatMessageDelta delta = default;
            BinaryData sessionState = default;
            IReadOnlyDictionary<string, BinaryData> context = default;
            FinishReason? finishReason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("delta"u8))
                {
                    delta = ChatMessageDelta.DeserializeChatMessageDelta(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sessionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionState = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    context = dictionary;
                    continue;
                }
                if (property.NameEquals("finishReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    finishReason = new FinishReason(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChoiceDelta(
                index,
                delta,
                sessionState,
                context ?? new ChangeTrackingDictionary<string, BinaryData>(),
                finishReason,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChoiceDelta>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChoiceDelta>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChoiceDelta)} does not support writing '{options.Format}' format.");
            }
        }

        ChoiceDelta IPersistableModel<ChoiceDelta>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChoiceDelta>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChoiceDelta(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChoiceDelta)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChoiceDelta>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChoiceDelta FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChoiceDelta(document.RootElement);
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
