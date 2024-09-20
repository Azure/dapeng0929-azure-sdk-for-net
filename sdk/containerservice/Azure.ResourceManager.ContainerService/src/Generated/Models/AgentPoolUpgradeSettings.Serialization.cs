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
    public partial class AgentPoolUpgradeSettings : IUtf8JsonSerializable, IJsonModel<AgentPoolUpgradeSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentPoolUpgradeSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AgentPoolUpgradeSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolUpgradeSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MaxSurge))
            {
                writer.WritePropertyName("maxSurge"u8);
                writer.WriteStringValue(MaxSurge);
            }
            if (Optional.IsDefined(DrainTimeoutInMinutes))
            {
                writer.WritePropertyName("drainTimeoutInMinutes"u8);
                writer.WriteNumberValue(DrainTimeoutInMinutes.Value);
            }
            if (Optional.IsDefined(NodeSoakDurationInMinutes))
            {
                writer.WritePropertyName("nodeSoakDurationInMinutes"u8);
                writer.WriteNumberValue(NodeSoakDurationInMinutes.Value);
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

        AgentPoolUpgradeSettings IJsonModel<AgentPoolUpgradeSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolUpgradeSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentPoolUpgradeSettings(document.RootElement, options);
        }

        internal static AgentPoolUpgradeSettings DeserializeAgentPoolUpgradeSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string maxSurge = default;
            int? drainTimeoutInMinutes = default;
            int? nodeSoakDurationInMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSurge"u8))
                {
                    maxSurge = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("drainTimeoutInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    drainTimeoutInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeSoakDurationInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeSoakDurationInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AgentPoolUpgradeSettings(maxSurge, drainTimeoutInMinutes, nodeSoakDurationInMinutes, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxSurge), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxSurge: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxSurge))
                {
                    builder.Append("  maxSurge: ");
                    if (MaxSurge.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MaxSurge}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MaxSurge}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DrainTimeoutInMinutes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  drainTimeoutInMinutes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DrainTimeoutInMinutes))
                {
                    builder.Append("  drainTimeoutInMinutes: ");
                    builder.AppendLine($"{DrainTimeoutInMinutes.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NodeSoakDurationInMinutes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nodeSoakDurationInMinutes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NodeSoakDurationInMinutes))
                {
                    builder.Append("  nodeSoakDurationInMinutes: ");
                    builder.AppendLine($"{NodeSoakDurationInMinutes.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AgentPoolUpgradeSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AgentPoolUpgradeSettings)} does not support writing '{options.Format}' format.");
            }
        }

        AgentPoolUpgradeSettings IPersistableModel<AgentPoolUpgradeSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentPoolUpgradeSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentPoolUpgradeSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentPoolUpgradeSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
