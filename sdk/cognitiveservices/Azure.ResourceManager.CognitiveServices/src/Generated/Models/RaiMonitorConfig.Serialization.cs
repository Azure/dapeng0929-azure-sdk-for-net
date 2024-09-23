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

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class RaiMonitorConfig : IUtf8JsonSerializable, IJsonModel<RaiMonitorConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RaiMonitorConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RaiMonitorConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiMonitorConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RaiMonitorConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AdxStorageResourceId))
            {
                writer.WritePropertyName("adxStorageResourceId"u8);
                writer.WriteStringValue(AdxStorageResourceId);
            }
            if (Optional.IsDefined(IdentityClientId))
            {
                writer.WritePropertyName("identityClientId"u8);
                writer.WriteStringValue(IdentityClientId.Value);
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

        RaiMonitorConfig IJsonModel<RaiMonitorConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiMonitorConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RaiMonitorConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRaiMonitorConfig(document.RootElement, options);
        }

        internal static RaiMonitorConfig DeserializeRaiMonitorConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string adxStorageResourceId = default;
            Guid? identityClientId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adxStorageResourceId"u8))
                {
                    adxStorageResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityClientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityClientId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RaiMonitorConfig(adxStorageResourceId, identityClientId, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AdxStorageResourceId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  adxStorageResourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AdxStorageResourceId))
                {
                    builder.Append("  adxStorageResourceId: ");
                    if (AdxStorageResourceId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AdxStorageResourceId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AdxStorageResourceId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IdentityClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  identityClientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IdentityClientId))
                {
                    builder.Append("  identityClientId: ");
                    builder.AppendLine($"'{IdentityClientId.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RaiMonitorConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiMonitorConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RaiMonitorConfig)} does not support writing '{options.Format}' format.");
            }
        }

        RaiMonitorConfig IPersistableModel<RaiMonitorConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RaiMonitorConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRaiMonitorConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RaiMonitorConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RaiMonitorConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
