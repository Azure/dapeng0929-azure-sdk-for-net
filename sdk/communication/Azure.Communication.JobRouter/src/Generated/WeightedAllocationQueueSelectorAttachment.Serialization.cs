// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class WeightedAllocationQueueSelectorAttachment : IUtf8JsonSerializable, IJsonModel<WeightedAllocationQueueSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WeightedAllocationQueueSelectorAttachment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WeightedAllocationQueueSelectorAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeightedAllocationQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WeightedAllocationQueueSelectorAttachment)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("allocations"u8);
            writer.WriteStartArray();
            foreach (var item in Allocations)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("queueSelectorAttachmentKind"u8);
            writer.WriteStringValue(QueueSelectorAttachmentKind.ToString());
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        WeightedAllocationQueueSelectorAttachment IJsonModel<WeightedAllocationQueueSelectorAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeightedAllocationQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WeightedAllocationQueueSelectorAttachment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWeightedAllocationQueueSelectorAttachment(document.RootElement, options);
        }

        internal static WeightedAllocationQueueSelectorAttachment DeserializeWeightedAllocationQueueSelectorAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<QueueWeightedAllocation> allocations = default;
            QueueSelectorAttachmentKind queueSelectorAttachmentKind = default;
            QueueSelectorAttachmentKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocations"u8))
                {
                    List<QueueWeightedAllocation> array = new List<QueueWeightedAllocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueueWeightedAllocation.DeserializeQueueWeightedAllocation(item, options));
                    }
                    allocations = array;
                    continue;
                }
                if (property.NameEquals("queueSelectorAttachmentKind"u8))
                {
                    queueSelectorAttachmentKind = new QueueSelectorAttachmentKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new QueueSelectorAttachmentKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WeightedAllocationQueueSelectorAttachment(queueSelectorAttachmentKind, kind, serializedAdditionalRawData, allocations);
        }

        BinaryData IPersistableModel<WeightedAllocationQueueSelectorAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeightedAllocationQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WeightedAllocationQueueSelectorAttachment)} does not support writing '{options.Format}' format.");
            }
        }

        WeightedAllocationQueueSelectorAttachment IPersistableModel<WeightedAllocationQueueSelectorAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WeightedAllocationQueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWeightedAllocationQueueSelectorAttachment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WeightedAllocationQueueSelectorAttachment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WeightedAllocationQueueSelectorAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new WeightedAllocationQueueSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWeightedAllocationQueueSelectorAttachment(document.RootElement);
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
