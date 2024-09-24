// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig : IUtf8JsonSerializable, IJsonModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Scheduler))
            {
                writer.WritePropertyName("scheduler"u8);
                writer.WriteStringValue(Scheduler.Value.ToString());
            }
            if (Optional.IsDefined(TcpTimeoutSeconds))
            {
                writer.WritePropertyName("tcpTimeoutSeconds"u8);
                writer.WriteNumberValue(TcpTimeoutSeconds.Value);
            }
            if (Optional.IsDefined(TcpFinTimeoutSeconds))
            {
                writer.WritePropertyName("tcpFinTimeoutSeconds"u8);
                writer.WriteNumberValue(TcpFinTimeoutSeconds.Value);
            }
            if (Optional.IsDefined(UdpTimeoutSeconds))
            {
                writer.WritePropertyName("udpTimeoutSeconds"u8);
                writer.WriteNumberValue(UdpTimeoutSeconds.Value);
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

        ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig IJsonModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceNetworkProfileKubeProxyConfigIPVSConfig(document.RootElement, options);
        }

        internal static ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig DeserializeContainerServiceNetworkProfileKubeProxyConfigIPVSConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPVSScheduler? scheduler = default;
            int? tcpTimeoutSeconds = default;
            int? tcpFinTimeoutSeconds = default;
            int? udpTimeoutSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduler"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduler = new IPVSScheduler(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tcpTimeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcpTimeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tcpFinTimeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcpFinTimeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("udpTimeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    udpTimeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig(scheduler, tcpTimeoutSeconds, tcpFinTimeoutSeconds, udpTimeoutSeconds, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Scheduler), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scheduler: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Scheduler))
                {
                    builder.Append("  scheduler: ");
                    builder.AppendLine($"'{Scheduler.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TcpTimeoutSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tcpTimeoutSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TcpTimeoutSeconds))
                {
                    builder.Append("  tcpTimeoutSeconds: ");
                    builder.AppendLine($"{TcpTimeoutSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TcpFinTimeoutSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tcpFinTimeoutSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TcpFinTimeoutSeconds))
                {
                    builder.Append("  tcpFinTimeoutSeconds: ");
                    builder.AppendLine($"{TcpFinTimeoutSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UdpTimeoutSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  udpTimeoutSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UdpTimeoutSeconds))
                {
                    builder.Append("  udpTimeoutSeconds: ");
                    builder.AppendLine($"{UdpTimeoutSeconds.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig IPersistableModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceNetworkProfileKubeProxyConfigIPVSConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceNetworkProfileKubeProxyConfigIPVSConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
