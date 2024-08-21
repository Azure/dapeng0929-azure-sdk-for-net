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
    public partial class ManagedClusterPoolUpgradeProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterPoolUpgradeProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterPoolUpgradeProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterPoolUpgradeProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPoolUpgradeProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPoolUpgradeProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kubernetesVersion"u8);
            writer.WriteStringValue(KubernetesVersion);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
            if (Optional.IsCollectionDefined(Upgrades))
            {
                writer.WritePropertyName("upgrades"u8);
                writer.WriteStartArray();
                foreach (var item in Upgrades)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ComponentsByReleases))
            {
                writer.WritePropertyName("componentsByReleases"u8);
                writer.WriteStartArray();
                foreach (var item in ComponentsByReleases)
                {
                    writer.WriteObjectValue(item, options);
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

        ManagedClusterPoolUpgradeProfile IJsonModel<ManagedClusterPoolUpgradeProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPoolUpgradeProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPoolUpgradeProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterPoolUpgradeProfile(document.RootElement, options);
        }

        internal static ManagedClusterPoolUpgradeProfile DeserializeManagedClusterPoolUpgradeProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kubernetesVersion = default;
            string name = default;
            ContainerServiceOSType osType = default;
            IReadOnlyList<ManagedClusterPoolUpgradeProfileUpgradesItem> upgrades = default;
            IReadOnlyList<ComponentsByRelease> componentsByReleases = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = new ContainerServiceOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("upgrades"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedClusterPoolUpgradeProfileUpgradesItem> array = new List<ManagedClusterPoolUpgradeProfileUpgradesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedClusterPoolUpgradeProfileUpgradesItem.DeserializeManagedClusterPoolUpgradeProfileUpgradesItem(item, options));
                    }
                    upgrades = array;
                    continue;
                }
                if (property.NameEquals("componentsByReleases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComponentsByRelease> array = new List<ComponentsByRelease>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComponentsByRelease.DeserializeComponentsByRelease(item, options));
                    }
                    componentsByReleases = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterPoolUpgradeProfile(
                kubernetesVersion,
                name,
                osType,
                upgrades ?? new ChangeTrackingList<ManagedClusterPoolUpgradeProfileUpgradesItem>(),
                componentsByReleases ?? new ChangeTrackingList<ComponentsByRelease>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterPoolUpgradeProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPoolUpgradeProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPoolUpgradeProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterPoolUpgradeProfile IPersistableModel<ManagedClusterPoolUpgradeProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPoolUpgradeProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterPoolUpgradeProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPoolUpgradeProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterPoolUpgradeProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
