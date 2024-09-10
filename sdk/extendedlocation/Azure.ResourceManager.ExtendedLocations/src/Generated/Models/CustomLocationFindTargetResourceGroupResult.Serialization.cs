// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    public partial class CustomLocationFindTargetResourceGroupResult : IUtf8JsonSerializable, IJsonModel<CustomLocationFindTargetResourceGroupResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomLocationFindTargetResourceGroupResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CustomLocationFindTargetResourceGroupResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationFindTargetResourceGroupResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomLocationFindTargetResourceGroupResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MatchedResourceSyncRule))
            {
                writer.WritePropertyName("matchedResourceSyncRule"u8);
                writer.WriteStringValue(MatchedResourceSyncRule);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetResourceGroup))
            {
                writer.WritePropertyName("targetResourceGroup"u8);
                writer.WriteStringValue(TargetResourceGroup);
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

        CustomLocationFindTargetResourceGroupResult IJsonModel<CustomLocationFindTargetResourceGroupResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationFindTargetResourceGroupResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomLocationFindTargetResourceGroupResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomLocationFindTargetResourceGroupResult(document.RootElement, options);
        }

        internal static CustomLocationFindTargetResourceGroupResult DeserializeCustomLocationFindTargetResourceGroupResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string matchedResourceSyncRule = default;
            string targetResourceGroup = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("matchedResourceSyncRule"u8))
                {
                    matchedResourceSyncRule = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"u8))
                {
                    targetResourceGroup = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CustomLocationFindTargetResourceGroupResult(matchedResourceSyncRule, targetResourceGroup, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomLocationFindTargetResourceGroupResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationFindTargetResourceGroupResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomLocationFindTargetResourceGroupResult)} does not support writing '{options.Format}' format.");
            }
        }

        CustomLocationFindTargetResourceGroupResult IPersistableModel<CustomLocationFindTargetResourceGroupResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationFindTargetResourceGroupResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomLocationFindTargetResourceGroupResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomLocationFindTargetResourceGroupResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomLocationFindTargetResourceGroupResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
