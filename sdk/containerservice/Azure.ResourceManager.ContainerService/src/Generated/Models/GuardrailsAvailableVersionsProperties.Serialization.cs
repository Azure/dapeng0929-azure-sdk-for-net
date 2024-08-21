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
    public partial class GuardrailsAvailableVersionsProperties : IUtf8JsonSerializable, IJsonModel<GuardrailsAvailableVersionsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuardrailsAvailableVersionsProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GuardrailsAvailableVersionsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuardrailsAvailableVersionsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuardrailsAvailableVersionsProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IsDefaultVersion))
            {
                writer.WritePropertyName("isDefaultVersion"u8);
                writer.WriteBooleanValue(IsDefaultVersion.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Support))
            {
                writer.WritePropertyName("support"u8);
                writer.WriteStringValue(Support.Value.ToString());
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

        GuardrailsAvailableVersionsProperties IJsonModel<GuardrailsAvailableVersionsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuardrailsAvailableVersionsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuardrailsAvailableVersionsProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuardrailsAvailableVersionsProperties(document.RootElement, options);
        }

        internal static GuardrailsAvailableVersionsProperties DeserializeGuardrailsAvailableVersionsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isDefaultVersion = default;
            GuardrailsSupport? support = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isDefaultVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefaultVersion = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("support"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    support = new GuardrailsSupport(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GuardrailsAvailableVersionsProperties(isDefaultVersion, support, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GuardrailsAvailableVersionsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuardrailsAvailableVersionsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GuardrailsAvailableVersionsProperties)} does not support writing '{options.Format}' format.");
            }
        }

        GuardrailsAvailableVersionsProperties IPersistableModel<GuardrailsAvailableVersionsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuardrailsAvailableVersionsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGuardrailsAvailableVersionsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuardrailsAvailableVersionsProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuardrailsAvailableVersionsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
