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
    public partial class StreamInputProperties : IUtf8JsonSerializable, IJsonModel<StreamInputProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StreamInputProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StreamInputProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamInputProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Datasource))
            {
                writer.WritePropertyName("datasource"u8);
                writer.WriteObjectValue(Datasource, options);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(InputPropertiesType);
            if (Optional.IsDefined(Serialization))
            {
                writer.WritePropertyName("serialization"u8);
                writer.WriteObjectValue(Serialization, options);
            }
            if (options.Format != "W" && Optional.IsDefined(Diagnostics))
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteObjectValue(Diagnostics, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression"u8);
                writer.WriteObjectValue(Compression, options);
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey"u8);
                writer.WriteStringValue(PartitionKey);
            }
            if (Optional.IsDefined(WatermarkSettings))
            {
                writer.WritePropertyName("watermarkSettings"u8);
                writer.WriteObjectValue(WatermarkSettings, options);
            }
            if (Optional.IsDefined(MessagingCatalogConfiguration))
            {
                writer.WritePropertyName("messagingCatalogConfiguration"u8);
                writer.WriteStringValue(MessagingCatalogConfiguration);
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

        StreamInputProperties IJsonModel<StreamInputProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamInputProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamInputProperties(document.RootElement, options);
        }

        internal static StreamInputProperties DeserializeStreamInputProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamInputDataSource datasource = default;
            string type = default;
            StreamAnalyticsDataSerialization serialization = default;
            StreamingJobDiagnostics diagnostics = default;
            ETag? etag = default;
            StreamingCompression compression = default;
            string partitionKey = default;
            StreamingJobInputWatermarkProperties watermarkSettings = default;
            string messagingCatalogConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasource = StreamInputDataSource.DeserializeStreamInputDataSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serialization = StreamAnalyticsDataSerialization.DeserializeStreamAnalyticsDataSerialization(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnostics = StreamingJobDiagnostics.DeserializeStreamingJobDiagnostics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("compression"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compression = StreamingCompression.DeserializeStreamingCompression(property.Value, options);
                    continue;
                }
                if (property.NameEquals("partitionKey"u8))
                {
                    partitionKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("watermarkSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    watermarkSettings = StreamingJobInputWatermarkProperties.DeserializeStreamingJobInputWatermarkProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("messagingCatalogConfiguration"u8))
                {
                    messagingCatalogConfiguration = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StreamInputProperties(
                type,
                serialization,
                diagnostics,
                etag,
                compression,
                partitionKey,
                watermarkSettings,
                messagingCatalogConfiguration,
                serializedAdditionalRawData,
                datasource);
        }

        BinaryData IPersistableModel<StreamInputProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamInputProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StreamInputProperties IPersistableModel<StreamInputProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StreamInputProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStreamInputProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamInputProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamInputProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
