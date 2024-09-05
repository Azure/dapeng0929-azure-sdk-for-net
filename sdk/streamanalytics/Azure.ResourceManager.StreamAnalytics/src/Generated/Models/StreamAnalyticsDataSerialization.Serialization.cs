// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    [PersistableModelProxy(typeof(UnknownSerialization))]
    public partial class StreamAnalyticsDataSerialization : IUtf8JsonSerializable, IJsonModel<StreamAnalyticsDataSerialization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamAnalyticsDataSerialization>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamAnalyticsDataSerialization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsDataSerialization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsDataSerialization)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(EventSerializationType.ToString());
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

        StreamAnalyticsDataSerialization IJsonModel<StreamAnalyticsDataSerialization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsDataSerialization>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamAnalyticsDataSerialization)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsDataSerialization(document.RootElement, options);
        }

        internal static StreamAnalyticsDataSerialization DeserializeStreamAnalyticsDataSerialization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Avro": return AvroFormatSerialization.DeserializeAvroFormatSerialization(element, options);
                    case "Csv": return CsvFormatSerialization.DeserializeCsvFormatSerialization(element, options);
                    case "CustomClr": return CustomClrFormatSerialization.DeserializeCustomClrFormatSerialization(element, options);
                    case "Delta": return DeltaSerialization.DeserializeDeltaSerialization(element, options);
                    case "Json": return JsonFormatSerialization.DeserializeJsonFormatSerialization(element, options);
                    case "Parquet": return ParquetFormatSerialization.DeserializeParquetFormatSerialization(element, options);
                }
            }
            return UnknownSerialization.DeserializeUnknownSerialization(element, options);
        }

        BinaryData IPersistableModel<StreamAnalyticsDataSerialization>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsDataSerialization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsDataSerialization)} does not support writing '{options.Format}' format.");
            }
        }

        StreamAnalyticsDataSerialization IPersistableModel<StreamAnalyticsDataSerialization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamAnalyticsDataSerialization>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamAnalyticsDataSerialization(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamAnalyticsDataSerialization)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamAnalyticsDataSerialization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
