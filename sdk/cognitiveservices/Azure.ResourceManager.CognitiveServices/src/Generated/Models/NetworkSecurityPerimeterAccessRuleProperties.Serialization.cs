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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class NetworkSecurityPerimeterAccessRuleProperties : IUtf8JsonSerializable, IJsonModel<NetworkSecurityPerimeterAccessRuleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSecurityPerimeterAccessRuleProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkSecurityPerimeterAccessRuleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterAccessRuleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterAccessRuleProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Direction))
            {
                writer.WritePropertyName("direction"u8);
                writer.WriteStringValue(Direction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AddressPrefixes))
            {
                writer.WritePropertyName("addressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NetworkSecurityPerimeters))
            {
                writer.WritePropertyName("networkSecurityPerimeters"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkSecurityPerimeters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(FullyQualifiedDomainNames))
            {
                writer.WritePropertyName("fullyQualifiedDomainNames"u8);
                writer.WriteStartArray();
                foreach (var item in FullyQualifiedDomainNames)
                {
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

        NetworkSecurityPerimeterAccessRuleProperties IJsonModel<NetworkSecurityPerimeterAccessRuleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterAccessRuleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityPerimeterAccessRuleProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityPerimeterAccessRuleProperties(document.RootElement, options);
        }

        internal static NetworkSecurityPerimeterAccessRuleProperties DeserializeNetworkSecurityPerimeterAccessRuleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NspAccessRuleDirection? direction = default;
            IList<string> addressPrefixes = default;
            IList<WritableSubResource> subscriptions = default;
            IList<NetworkSecurityPerimeter> networkSecurityPerimeters = default;
            IList<string> fullyQualifiedDomainNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("direction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    direction = new NspAccessRuleDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WritableSubResource> array = new List<WritableSubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                    }
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("networkSecurityPerimeters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkSecurityPerimeter> array = new List<NetworkSecurityPerimeter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkSecurityPerimeter.DeserializeNetworkSecurityPerimeter(item, options));
                    }
                    networkSecurityPerimeters = array;
                    continue;
                }
                if (property.NameEquals("fullyQualifiedDomainNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fullyQualifiedDomainNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkSecurityPerimeterAccessRuleProperties(
                direction,
                addressPrefixes ?? new ChangeTrackingList<string>(),
                subscriptions ?? new ChangeTrackingList<WritableSubResource>(),
                networkSecurityPerimeters ?? new ChangeTrackingList<NetworkSecurityPerimeter>(),
                fullyQualifiedDomainNames ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Direction), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  direction: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Direction))
                {
                    builder.Append("  direction: ");
                    builder.AppendLine($"'{Direction.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AddressPrefixes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  addressPrefixes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AddressPrefixes))
                {
                    if (AddressPrefixes.Any())
                    {
                        builder.Append("  addressPrefixes: ");
                        builder.AppendLine("[");
                        foreach (var item in AddressPrefixes)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Subscriptions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subscriptions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Subscriptions))
                {
                    if (Subscriptions.Any())
                    {
                        builder.Append("  subscriptions: ");
                        builder.AppendLine("[");
                        foreach (var item in Subscriptions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  subscriptions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkSecurityPerimeters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  networkSecurityPerimeters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NetworkSecurityPerimeters))
                {
                    if (NetworkSecurityPerimeters.Any())
                    {
                        builder.Append("  networkSecurityPerimeters: ");
                        builder.AppendLine("[");
                        foreach (var item in NetworkSecurityPerimeters)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  networkSecurityPerimeters: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FullyQualifiedDomainNames), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  fullyQualifiedDomainNames: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(FullyQualifiedDomainNames))
                {
                    if (FullyQualifiedDomainNames.Any())
                    {
                        builder.Append("  fullyQualifiedDomainNames: ");
                        builder.AppendLine("[");
                        foreach (var item in FullyQualifiedDomainNames)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NetworkSecurityPerimeterAccessRuleProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterAccessRuleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterAccessRuleProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkSecurityPerimeterAccessRuleProperties IPersistableModel<NetworkSecurityPerimeterAccessRuleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityPerimeterAccessRuleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkSecurityPerimeterAccessRuleProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityPerimeterAccessRuleProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSecurityPerimeterAccessRuleProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
