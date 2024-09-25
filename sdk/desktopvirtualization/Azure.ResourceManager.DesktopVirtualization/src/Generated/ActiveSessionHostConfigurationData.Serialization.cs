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
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class ActiveSessionHostConfigurationData : IUtf8JsonSerializable, IJsonModel<ActiveSessionHostConfigurationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActiveSessionHostConfigurationData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ActiveSessionHostConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveSessionHostConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActiveSessionHostConfigurationData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value, "O");
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsCollectionDefined(VmTags))
            {
                writer.WritePropertyName("vmTags"u8);
                writer.WriteStartObject();
                foreach (var item in VmTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(VmLocation))
            {
                writer.WritePropertyName("vmLocation"u8);
                writer.WriteStringValue(VmLocation);
            }
            if (Optional.IsDefined(VmResourceGroup))
            {
                writer.WritePropertyName("vmResourceGroup"u8);
                writer.WriteStringValue(VmResourceGroup);
            }
            writer.WritePropertyName("vmNamePrefix"u8);
            writer.WriteStringValue(VmNamePrefix);
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("networkInfo"u8);
            writer.WriteObjectValue(NetworkInfo, options);
            writer.WritePropertyName("vmSizeId"u8);
            writer.WriteStringValue(VmSizeId);
            writer.WritePropertyName("diskInfo"u8);
            writer.WriteObjectValue(DiskInfo, options);
            if (Optional.IsDefined(CustomConfigurationScriptUri))
            {
                writer.WritePropertyName("customConfigurationScriptUrl"u8);
                writer.WriteStringValue(CustomConfigurationScriptUri.AbsoluteUri);
            }
            writer.WritePropertyName("imageInfo"u8);
            writer.WriteObjectValue(ImageInfo, options);
            writer.WritePropertyName("domainInfo"u8);
            writer.WriteObjectValue(DomainInfo, options);
            if (Optional.IsDefined(SecurityInfo))
            {
                writer.WritePropertyName("securityInfo"u8);
                writer.WriteObjectValue(SecurityInfo, options);
            }
            writer.WritePropertyName("vmAdminCredentials"u8);
            writer.WriteObjectValue(VmAdminCredentials, options);
            if (Optional.IsDefined(BootDiagnosticsInfo))
            {
                writer.WritePropertyName("bootDiagnosticsInfo"u8);
                writer.WriteObjectValue(BootDiagnosticsInfo, options);
            }
            writer.WriteEndObject();
        }

        ActiveSessionHostConfigurationData IJsonModel<ActiveSessionHostConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveSessionHostConfigurationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ActiveSessionHostConfigurationData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActiveSessionHostConfigurationData(document.RootElement, options);
        }

        internal static ActiveSessionHostConfigurationData DeserializeActiveSessionHostConfigurationData(JsonElement element, ModelReaderWriterOptions options = null)
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
            DateTimeOffset? version = default;
            string friendlyName = default;
            IDictionary<string, string> vmTags = default;
            string vmLocation = default;
            string vmResourceGroup = default;
            string vmNamePrefix = default;
            IList<int> availabilityZones = default;
            NetworkInfoProperties networkInfo = default;
            string vmSizeId = default;
            DiskInfoProperties diskInfo = default;
            Uri customConfigurationScriptUrl = default;
            ImageInfoProperties imageInfo = default;
            DomainInfoProperties domainInfo = default;
            SecurityInfoProperties securityInfo = default;
            KeyVaultCredentialsProperties vmAdminCredentials = default;
            BootDiagnosticsInfoProperties bootDiagnosticsInfo = default;
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
                        if (property0.NameEquals("version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            vmTags = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("vmLocation"u8))
                        {
                            vmLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmResourceGroup"u8))
                        {
                            vmResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmNamePrefix"u8))
                        {
                            vmNamePrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("availabilityZones"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<int> array = new List<int>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetInt32());
                            }
                            availabilityZones = array;
                            continue;
                        }
                        if (property0.NameEquals("networkInfo"u8))
                        {
                            networkInfo = NetworkInfoProperties.DeserializeNetworkInfoProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vmSizeId"u8))
                        {
                            vmSizeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("diskInfo"u8))
                        {
                            diskInfo = DiskInfoProperties.DeserializeDiskInfoProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("customConfigurationScriptUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customConfigurationScriptUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("imageInfo"u8))
                        {
                            imageInfo = ImageInfoProperties.DeserializeImageInfoProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("domainInfo"u8))
                        {
                            domainInfo = DomainInfoProperties.DeserializeDomainInfoProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("securityInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityInfo = SecurityInfoProperties.DeserializeSecurityInfoProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("vmAdminCredentials"u8))
                        {
                            vmAdminCredentials = KeyVaultCredentialsProperties.DeserializeKeyVaultCredentialsProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("bootDiagnosticsInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bootDiagnosticsInfo = BootDiagnosticsInfoProperties.DeserializeBootDiagnosticsInfoProperties(property0.Value, options);
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
            return new ActiveSessionHostConfigurationData(
                id,
                name,
                type,
                systemData,
                version,
                friendlyName,
                vmTags ?? new ChangeTrackingDictionary<string, string>(),
                vmLocation,
                vmResourceGroup,
                vmNamePrefix,
                availabilityZones ?? new ChangeTrackingList<int>(),
                networkInfo,
                vmSizeId,
                diskInfo,
                customConfigurationScriptUrl,
                imageInfo,
                domainInfo,
                securityInfo,
                vmAdminCredentials,
                bootDiagnosticsInfo,
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Version), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    version: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Version))
                {
                    builder.Append("    version: ");
                    var formattedDateTimeString = TypeFormatters.ToString(Version.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FriendlyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    friendlyName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FriendlyName))
                {
                    builder.Append("    friendlyName: ");
                    if (FriendlyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FriendlyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FriendlyName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VmTags), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    vmTags: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(VmTags))
                {
                    if (VmTags.Any())
                    {
                        builder.Append("    vmTags: ");
                        builder.AppendLine("{");
                        foreach (var item in VmTags)
                        {
                            builder.Append($"        '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("    }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VmLocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    vmLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VmLocation))
                {
                    builder.Append("    vmLocation: ");
                    if (VmLocation.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{VmLocation}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{VmLocation}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VmResourceGroup), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    vmResourceGroup: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VmResourceGroup))
                {
                    builder.Append("    vmResourceGroup: ");
                    if (VmResourceGroup.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{VmResourceGroup}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{VmResourceGroup}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VmNamePrefix), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    vmNamePrefix: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VmNamePrefix))
                {
                    builder.Append("    vmNamePrefix: ");
                    if (VmNamePrefix.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{VmNamePrefix}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{VmNamePrefix}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AvailabilityZones), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    availabilityZones: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AvailabilityZones))
                {
                    if (AvailabilityZones.Any())
                    {
                        builder.Append("    availabilityZones: ");
                        builder.AppendLine("[");
                        foreach (var item in AvailabilityZones)
                        {
                            builder.AppendLine($"      {item}");
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NetworkInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    networkInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NetworkInfo))
                {
                    builder.Append("    networkInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, NetworkInfo, options, 4, false, "    networkInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VmSizeId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    vmSizeId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VmSizeId))
                {
                    builder.Append("    vmSizeId: ");
                    if (VmSizeId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{VmSizeId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{VmSizeId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("VirtualMachineDiskType", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    diskInfo: ");
                builder.AppendLine("{");
                builder.AppendLine("      diskInfo: {");
                builder.Append("        type: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(DiskInfo))
                {
                    builder.Append("    diskInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DiskInfo, options, 4, false, "    diskInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomConfigurationScriptUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    customConfigurationScriptUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomConfigurationScriptUri))
                {
                    builder.Append("    customConfigurationScriptUrl: ");
                    builder.AppendLine($"'{CustomConfigurationScriptUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ImageInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    imageInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ImageInfo))
                {
                    builder.Append("    imageInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ImageInfo, options, 4, false, "    imageInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DomainInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    domainInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DomainInfo))
                {
                    builder.Append("    domainInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DomainInfo, options, 4, false, "    domainInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecurityInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    securityInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SecurityInfo))
                {
                    builder.Append("    securityInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, SecurityInfo, options, 4, false, "    securityInfo: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VmAdminCredentials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    vmAdminCredentials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VmAdminCredentials))
                {
                    builder.Append("    vmAdminCredentials: ");
                    BicepSerializationHelpers.AppendChildObject(builder, VmAdminCredentials, options, 4, false, "    vmAdminCredentials: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BootDiagnosticsInfo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    bootDiagnosticsInfo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BootDiagnosticsInfo))
                {
                    builder.Append("    bootDiagnosticsInfo: ");
                    BicepSerializationHelpers.AppendChildObject(builder, BootDiagnosticsInfo, options, 4, false, "    bootDiagnosticsInfo: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ActiveSessionHostConfigurationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveSessionHostConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ActiveSessionHostConfigurationData)} does not support writing '{options.Format}' format.");
            }
        }

        ActiveSessionHostConfigurationData IPersistableModel<ActiveSessionHostConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ActiveSessionHostConfigurationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeActiveSessionHostConfigurationData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ActiveSessionHostConfigurationData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ActiveSessionHostConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
