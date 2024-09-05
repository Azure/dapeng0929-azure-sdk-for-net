// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class SkuCapacity : IUtf8JsonSerializable, IJsonModel<SkuCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SkuCapacity>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SkuCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SkuCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SkuCapacity)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Minimum))
            {
                writer.WritePropertyName("minimum"u8);
                writer.WriteNumberValue(Minimum.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Maximum))
            {
                writer.WritePropertyName("maximum"u8);
                writer.WriteNumberValue(Maximum.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Default))
            {
                writer.WritePropertyName("default"u8);
                writer.WriteNumberValue(Default.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ScaleType))
            {
                writer.WritePropertyName("scaleType"u8);
                writer.WriteStringValue(ScaleType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AllowedValues))
            {
                writer.WritePropertyName("allowedValues"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedValues)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
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

        SkuCapacity IJsonModel<SkuCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SkuCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SkuCapacity)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSkuCapacity(document.RootElement, options);
        }

        internal static SkuCapacity DeserializeSkuCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? minimum = default;
            int? maximum = default;
            int? @default = default;
            SkuCapacityScaleType? scaleType = default;
            IReadOnlyList<int> allowedValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleType = new SkuCapacityScaleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("allowedValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    allowedValues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SkuCapacity(
                minimum,
                maximum,
                @default,
                scaleType,
                allowedValues ?? new ChangeTrackingList<int>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SkuCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SkuCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SkuCapacity)} does not support writing '{options.Format}' format.");
            }
        }

        SkuCapacity IPersistableModel<SkuCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SkuCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSkuCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SkuCapacity)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SkuCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
