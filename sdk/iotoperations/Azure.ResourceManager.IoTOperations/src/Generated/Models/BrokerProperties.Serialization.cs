// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IoTOperations.Models
{
    public partial class BrokerProperties : IUtf8JsonSerializable, IJsonModel<BrokerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BrokerProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BrokerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Advanced))
            {
                writer.WritePropertyName("advanced"u8);
                writer.WriteObjectValue(Advanced, options);
            }
            if (Optional.IsDefined(Cardinality))
            {
                writer.WritePropertyName("cardinality"u8);
                writer.WriteObjectValue(Cardinality, options);
            }
            if (Optional.IsDefined(Diagnostics))
            {
                writer.WritePropertyName("diagnostics"u8);
                writer.WriteObjectValue(Diagnostics, options);
            }
            if (Optional.IsDefined(DiskBackedMessageBuffer))
            {
                writer.WritePropertyName("diskBackedMessageBuffer"u8);
                writer.WriteObjectValue(DiskBackedMessageBuffer, options);
            }
            if (Optional.IsDefined(GenerateResourceLimits))
            {
                writer.WritePropertyName("generateResourceLimits"u8);
                writer.WriteObjectValue(GenerateResourceLimits, options);
            }
            if (Optional.IsDefined(MemoryProfile))
            {
                writer.WritePropertyName("memoryProfile"u8);
                writer.WriteStringValue(MemoryProfile.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        BrokerProperties IJsonModel<BrokerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBrokerProperties(document.RootElement, options);
        }

        internal static BrokerProperties DeserializeBrokerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdvancedSettings advanced = default;
            Cardinality cardinality = default;
            BrokerDiagnostics diagnostics = default;
            DiskBackedMessageBuffer diskBackedMessageBuffer = default;
            GenerateResourceLimits generateResourceLimits = default;
            BrokerMemoryProfile? memoryProfile = default;
            ProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("advanced"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    advanced = AdvancedSettings.DeserializeAdvancedSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("cardinality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cardinality = Cardinality.DeserializeCardinality(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnostics = BrokerDiagnostics.DeserializeBrokerDiagnostics(property.Value, options);
                    continue;
                }
                if (property.NameEquals("diskBackedMessageBuffer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskBackedMessageBuffer = DiskBackedMessageBuffer.DeserializeDiskBackedMessageBuffer(property.Value, options);
                    continue;
                }
                if (property.NameEquals("generateResourceLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    generateResourceLimits = GenerateResourceLimits.DeserializeGenerateResourceLimits(property.Value, options);
                    continue;
                }
                if (property.NameEquals("memoryProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryProfile = new BrokerMemoryProfile(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BrokerProperties(
                advanced,
                cardinality,
                diagnostics,
                diskBackedMessageBuffer,
                generateResourceLimits,
                memoryProfile,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BrokerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BrokerProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BrokerProperties IPersistableModel<BrokerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBrokerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BrokerProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BrokerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
