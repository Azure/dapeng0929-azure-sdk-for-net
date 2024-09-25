// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SwiftVirtualNetworkResourceAllocation : IUtf8JsonSerializable, IJsonModel<SwiftVirtualNetworkResourceAllocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SwiftVirtualNetworkResourceAllocation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SwiftVirtualNetworkResourceAllocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwiftVirtualNetworkResourceAllocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwiftVirtualNetworkResourceAllocation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ConnectedServerFarmsId))
            {
                writer.WritePropertyName("connectedServerFarmsId"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectedServerFarmsId)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConnectedSitesId))
            {
                writer.WritePropertyName("connectedSitesId"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectedSitesId)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
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

        SwiftVirtualNetworkResourceAllocation IJsonModel<SwiftVirtualNetworkResourceAllocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwiftVirtualNetworkResourceAllocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwiftVirtualNetworkResourceAllocation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSwiftVirtualNetworkResourceAllocation(document.RootElement, options);
        }

        internal static SwiftVirtualNetworkResourceAllocation DeserializeSwiftVirtualNetworkResourceAllocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ResourceIdentifier> connectedServerFarmsId = default;
            IList<ResourceIdentifier> connectedSitesId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectedServerFarmsId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    connectedServerFarmsId = array;
                    continue;
                }
                if (property.NameEquals("connectedSitesId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    connectedSitesId = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SwiftVirtualNetworkResourceAllocation(connectedServerFarmsId ?? new ChangeTrackingList<ResourceIdentifier>(), connectedSitesId ?? new ChangeTrackingList<ResourceIdentifier>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectedServerFarmsId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  connectedServerFarmsId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ConnectedServerFarmsId))
                {
                    if (ConnectedServerFarmsId.Any())
                    {
                        builder.Append("  connectedServerFarmsId: ");
                        builder.AppendLine("[");
                        foreach (var item in ConnectedServerFarmsId)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectedSitesId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  connectedSitesId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ConnectedSitesId))
                {
                    if (ConnectedSitesId.Any())
                    {
                        builder.Append("  connectedSitesId: ");
                        builder.AppendLine("[");
                        foreach (var item in ConnectedSitesId)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SwiftVirtualNetworkResourceAllocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwiftVirtualNetworkResourceAllocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SwiftVirtualNetworkResourceAllocation)} does not support writing '{options.Format}' format.");
            }
        }

        SwiftVirtualNetworkResourceAllocation IPersistableModel<SwiftVirtualNetworkResourceAllocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwiftVirtualNetworkResourceAllocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSwiftVirtualNetworkResourceAllocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SwiftVirtualNetworkResourceAllocation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SwiftVirtualNetworkResourceAllocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
