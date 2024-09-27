// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class IpamPoolPrefixAllocation : IUtf8JsonSerializable, IJsonModel<IpamPoolPrefixAllocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IpamPoolPrefixAllocation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IpamPoolPrefixAllocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpamPoolPrefixAllocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IpamPoolPrefixAllocation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NumberOfIPAddresses))
            {
                writer.WritePropertyName("numberOfIpAddresses"u8);
                writer.WriteStringValue(NumberOfIPAddresses);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(AllocatedAddressPrefixes))
            {
                writer.WritePropertyName("allocatedAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AllocatedAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("pool"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
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

        IpamPoolPrefixAllocation IJsonModel<IpamPoolPrefixAllocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpamPoolPrefixAllocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IpamPoolPrefixAllocation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIpamPoolPrefixAllocation(document.RootElement, options);
        }

        internal static IpamPoolPrefixAllocation DeserializeIpamPoolPrefixAllocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string numberOfIPAddresses = default;
            IReadOnlyList<string> allocatedAddressPrefixes = default;
            ResourceIdentifier id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("numberOfIpAddresses"u8))
                {
                    numberOfIPAddresses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allocatedAddressPrefixes"u8))
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
                    allocatedAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("pool"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IpamPoolPrefixAllocation(numberOfIPAddresses, allocatedAddressPrefixes ?? new ChangeTrackingList<string>(), id, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IpamPoolPrefixAllocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpamPoolPrefixAllocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IpamPoolPrefixAllocation)} does not support writing '{options.Format}' format.");
            }
        }

        IpamPoolPrefixAllocation IPersistableModel<IpamPoolPrefixAllocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IpamPoolPrefixAllocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIpamPoolPrefixAllocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IpamPoolPrefixAllocation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IpamPoolPrefixAllocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
