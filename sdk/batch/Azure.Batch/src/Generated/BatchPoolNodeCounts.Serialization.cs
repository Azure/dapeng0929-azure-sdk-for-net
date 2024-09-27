// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchPoolNodeCounts : IUtf8JsonSerializable, IJsonModel<BatchPoolNodeCounts>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchPoolNodeCounts>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchPoolNodeCounts>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolNodeCounts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPoolNodeCounts)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("poolId"u8);
            writer.WriteStringValue(PoolId);
            if (Optional.IsDefined(Dedicated))
            {
                writer.WritePropertyName("dedicated"u8);
                writer.WriteObjectValue(Dedicated, options);
            }
            if (Optional.IsDefined(LowPriority))
            {
                writer.WritePropertyName("lowPriority"u8);
                writer.WriteObjectValue(LowPriority, options);
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

        BatchPoolNodeCounts IJsonModel<BatchPoolNodeCounts>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolNodeCounts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPoolNodeCounts)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchPoolNodeCounts(document.RootElement, options);
        }

        internal static BatchPoolNodeCounts DeserializeBatchPoolNodeCounts(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string poolId = default;
            BatchNodeCounts dedicated = default;
            BatchNodeCounts lowPriority = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("poolId"u8))
                {
                    poolId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dedicated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dedicated = BatchNodeCounts.DeserializeBatchNodeCounts(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lowPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lowPriority = BatchNodeCounts.DeserializeBatchNodeCounts(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchPoolNodeCounts(poolId, dedicated, lowPriority, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchPoolNodeCounts>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolNodeCounts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchPoolNodeCounts)} does not support writing '{options.Format}' format.");
            }
        }

        BatchPoolNodeCounts IPersistableModel<BatchPoolNodeCounts>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolNodeCounts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchPoolNodeCounts(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchPoolNodeCounts)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchPoolNodeCounts>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchPoolNodeCounts FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBatchPoolNodeCounts(document.RootElement);
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
