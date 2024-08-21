// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    public partial class AgentPoolUpgradeProfileData : IUtf8JsonSerializable, IJsonModel<AgentPoolUpgradeProfileData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AgentPoolUpgradeProfileData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AgentPoolUpgradeProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolUpgradeProfileData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("kubernetesVersion"u8);
            writer.WriteStringValue(KubernetesVersion);
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
            if (Optional.IsDefined(LatestNodeImageVersion))
            {
                writer.WritePropertyName("latestNodeImageVersion"u8);
                writer.WriteStringValue(LatestNodeImageVersion);
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

        AgentPoolUpgradeProfileData IJsonModel<AgentPoolUpgradeProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AgentPoolUpgradeProfileData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentPoolUpgradeProfileData(document.RootElement, options);
        }

        internal static AgentPoolUpgradeProfileData DeserializeAgentPoolUpgradeProfileData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string kubernetesVersion = default;
            ContainerServiceOSType osType = default;
            IReadOnlyList<AgentPoolUpgradeProfilePropertiesUpgradesItem> upgrades = default;
            IReadOnlyList<ComponentsByRelease> componentsByReleases = default;
            string latestNodeImageVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("kubernetesVersion"u8))
                        {
                            kubernetesVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            osType = new ContainerServiceOSType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("upgrades"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AgentPoolUpgradeProfilePropertiesUpgradesItem> array = new List<AgentPoolUpgradeProfilePropertiesUpgradesItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AgentPoolUpgradeProfilePropertiesUpgradesItem.DeserializeAgentPoolUpgradeProfilePropertiesUpgradesItem(item, options));
                            }
                            upgrades = array;
                            continue;
                        }
                        if (property0.NameEquals("componentsByReleases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ComponentsByRelease> array = new List<ComponentsByRelease>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ComponentsByRelease.DeserializeComponentsByRelease(item, options));
                            }
                            componentsByReleases = array;
                            continue;
                        }
                        if (property0.NameEquals("latestNodeImageVersion"u8))
                        {
                            latestNodeImageVersion = property0.Value.GetString();
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
            return new AgentPoolUpgradeProfileData(
                id,
                name,
                type,
                systemData,
                kubernetesVersion,
                osType,
                upgrades ?? new ChangeTrackingList<AgentPoolUpgradeProfilePropertiesUpgradesItem>(),
                componentsByReleases ?? new ChangeTrackingList<ComponentsByRelease>(),
                latestNodeImageVersion,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AgentPoolUpgradeProfileData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AgentPoolUpgradeProfileData)} does not support writing '{options.Format}' format.");
            }
        }

        AgentPoolUpgradeProfileData IPersistableModel<AgentPoolUpgradeProfileData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AgentPoolUpgradeProfileData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAgentPoolUpgradeProfileData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AgentPoolUpgradeProfileData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AgentPoolUpgradeProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
