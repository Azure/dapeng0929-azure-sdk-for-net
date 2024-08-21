// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAzureMonitorProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterAzureMonitorProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterAzureMonitorProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterAzureMonitorProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAzureMonitorProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAzureMonitorProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteObjectValue(Metrics, options);
            }
            if (Optional.IsDefined(ContainerInsights))
            {
                writer.WritePropertyName("containerInsights"u8);
                writer.WriteObjectValue(ContainerInsights, options);
            }
            if (Optional.IsDefined(AppMonitoring))
            {
                writer.WritePropertyName("appMonitoring"u8);
                writer.WriteObjectValue(AppMonitoring, options);
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

        ManagedClusterAzureMonitorProfile IJsonModel<ManagedClusterAzureMonitorProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAzureMonitorProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterAzureMonitorProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterAzureMonitorProfile(document.RootElement, options);
        }

        internal static ManagedClusterAzureMonitorProfile DeserializeManagedClusterAzureMonitorProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedClusterMonitorProfileMetrics metrics = default;
            ManagedClusterAzureMonitorProfileContainerInsights containerInsights = default;
            ManagedClusterAzureMonitorProfileAppMonitoring appMonitoring = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metrics = ManagedClusterMonitorProfileMetrics.DeserializeManagedClusterMonitorProfileMetrics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("containerInsights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerInsights = ManagedClusterAzureMonitorProfileContainerInsights.DeserializeManagedClusterAzureMonitorProfileContainerInsights(property.Value, options);
                    continue;
                }
                if (property.NameEquals("appMonitoring"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appMonitoring = ManagedClusterAzureMonitorProfileAppMonitoring.DeserializeManagedClusterAzureMonitorProfileAppMonitoring(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterAzureMonitorProfile(metrics, containerInsights, appMonitoring, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterAzureMonitorProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAzureMonitorProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAzureMonitorProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterAzureMonitorProfile IPersistableModel<ManagedClusterAzureMonitorProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterAzureMonitorProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterAzureMonitorProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterAzureMonitorProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterAzureMonitorProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
