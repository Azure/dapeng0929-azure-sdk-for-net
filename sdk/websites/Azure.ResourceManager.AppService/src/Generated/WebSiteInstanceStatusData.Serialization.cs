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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class WebSiteInstanceStatusData : IUtf8JsonSerializable, IJsonModel<WebSiteInstanceStatusData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebSiteInstanceStatusData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<WebSiteInstanceStatusData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteInstanceStatusData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebSiteInstanceStatusData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsDefined(StatusUri))
            {
                writer.WritePropertyName("statusUrl"u8);
                writer.WriteStringValue(StatusUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DetectorUri))
            {
                writer.WritePropertyName("detectorUrl"u8);
                writer.WriteStringValue(DetectorUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ConsoleUri))
            {
                writer.WritePropertyName("consoleUrl"u8);
                writer.WriteStringValue(ConsoleUri.AbsoluteUri);
            }
            if (Optional.IsDefined(HealthCheckUrlString))
            {
                writer.WritePropertyName("healthCheckUrl"u8);
                writer.WriteStringValue(HealthCheckUrlString);
            }
            if (Optional.IsCollectionDefined(Containers))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartObject();
                foreach (var item in Containers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(PhysicalZone))
            {
                writer.WritePropertyName("physicalZone"u8);
                writer.WriteStringValue(PhysicalZone);
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

        WebSiteInstanceStatusData IJsonModel<WebSiteInstanceStatusData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteInstanceStatusData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebSiteInstanceStatusData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebSiteInstanceStatusData(document.RootElement, options);
        }

        internal static WebSiteInstanceStatusData DeserializeWebSiteInstanceStatusData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            SiteRuntimeState? state = default;
            Uri statusUrl = default;
            Uri detectorUrl = default;
            Uri consoleUrl = default;
            string healthCheckUrl = default;
            IDictionary<string, ContainerInfo> containers = default;
            string physicalZone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToSiteRuntimeState();
                            continue;
                        }
                        if (property0.NameEquals("statusUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            statusUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("detectorUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            detectorUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("consoleUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null || property0.Value.ValueKind == JsonValueKind.String && property0.Value.GetString().Length == 0)
                            {
                                continue;
                            }
                            consoleUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthCheckUrl"u8))
                        {
                            healthCheckUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ContainerInfo> dictionary = new Dictionary<string, ContainerInfo>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ContainerInfo.DeserializeContainerInfo(property1.Value, options));
                            }
                            containers = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("physicalZone"u8))
                        {
                            physicalZone = property0.Value.GetString();
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
            return new WebSiteInstanceStatusData(
                id,
                name,
                type,
                systemData,
                state,
                statusUrl,
                detectorUrl,
                consoleUrl,
                healthCheckUrl,
                containers ?? new ChangeTrackingDictionary<string, ContainerInfo>(),
                physicalZone,
                kind,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(State), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    state: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(State))
                {
                    builder.Append("    state: ");
                    builder.AppendLine($"'{State.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(StatusUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    statusUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(StatusUri))
                {
                    builder.Append("    statusUrl: ");
                    builder.AppendLine($"'{StatusUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DetectorUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    detectorUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DetectorUri))
                {
                    builder.Append("    detectorUrl: ");
                    builder.AppendLine($"'{DetectorUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConsoleUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    consoleUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConsoleUri))
                {
                    builder.Append("    consoleUrl: ");
                    builder.AppendLine($"'{ConsoleUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HealthCheckUrlString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    healthCheckUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HealthCheckUrlString))
                {
                    builder.Append("    healthCheckUrl: ");
                    if (HealthCheckUrlString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{HealthCheckUrlString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{HealthCheckUrlString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Containers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    containers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Containers))
                {
                    if (Containers.Any())
                    {
                        builder.Append("    containers: ");
                        builder.AppendLine("{");
                        foreach (var item in Containers)
                        {
                            builder.Append($"        '{item.Key}': ");
                            BicepSerializationHelpers.AppendChildObject(builder, item.Value, options, 6, false, "    containers: ");
                        }
                        builder.AppendLine("    }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PhysicalZone), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    physicalZone: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PhysicalZone))
                {
                    builder.Append("    physicalZone: ");
                    if (PhysicalZone.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PhysicalZone}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PhysicalZone}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<WebSiteInstanceStatusData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteInstanceStatusData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebSiteInstanceStatusData)} does not support writing '{options.Format}' format.");
            }
        }

        WebSiteInstanceStatusData IPersistableModel<WebSiteInstanceStatusData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebSiteInstanceStatusData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebSiteInstanceStatusData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebSiteInstanceStatusData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebSiteInstanceStatusData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
