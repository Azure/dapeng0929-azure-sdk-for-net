// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class CloudVmClusterDBNodeProperties : IUtf8JsonSerializable, IJsonModel<CloudVmClusterDBNodeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudVmClusterDBNodeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CloudVmClusterDBNodeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudVmClusterDBNodeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudVmClusterDBNodeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("ocid"u8);
            writer.WriteStringValue(Ocid);
            if (Optional.IsDefined(AdditionalDetails))
            {
                writer.WritePropertyName("additionalDetails"u8);
                writer.WriteStringValue(AdditionalDetails);
            }
            if (Optional.IsDefined(BackupIPId))
            {
                writer.WritePropertyName("backupIpId"u8);
                writer.WriteStringValue(BackupIPId);
            }
            if (Optional.IsDefined(BackupVnic2Id))
            {
                writer.WritePropertyName("backupVnic2Id"u8);
                writer.WriteStringValue(BackupVnic2Id);
            }
            if (Optional.IsDefined(BackupVnicId))
            {
                writer.WritePropertyName("backupVnicId"u8);
                writer.WriteStringValue(BackupVnicId);
            }
            if (Optional.IsDefined(CpuCoreCount))
            {
                writer.WritePropertyName("cpuCoreCount"u8);
                writer.WriteNumberValue(CpuCoreCount.Value);
            }
            if (Optional.IsDefined(DBNodeStorageSizeInGbs))
            {
                writer.WritePropertyName("dbNodeStorageSizeInGbs"u8);
                writer.WriteNumberValue(DBNodeStorageSizeInGbs.Value);
            }
            if (Optional.IsDefined(DBServerId))
            {
                writer.WritePropertyName("dbServerId"u8);
                writer.WriteStringValue(DBServerId);
            }
            writer.WritePropertyName("dbSystemId"u8);
            writer.WriteStringValue(DBSystemId);
            if (Optional.IsDefined(FaultDomain))
            {
                writer.WritePropertyName("faultDomain"u8);
                writer.WriteStringValue(FaultDomain);
            }
            if (Optional.IsDefined(HostIPId))
            {
                writer.WritePropertyName("hostIpId"u8);
                writer.WriteStringValue(HostIPId);
            }
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname"u8);
                writer.WriteStringValue(Hostname);
            }
            writer.WritePropertyName("lifecycleState"u8);
            writer.WriteStringValue(LifecycleState.ToString());
            if (Optional.IsDefined(LifecycleDetails))
            {
                writer.WritePropertyName("lifecycleDetails"u8);
                writer.WriteStringValue(LifecycleDetails);
            }
            if (Optional.IsDefined(MaintenanceType))
            {
                writer.WritePropertyName("maintenanceType"u8);
                writer.WriteStringValue(MaintenanceType.Value.ToString());
            }
            if (Optional.IsDefined(MemorySizeInGbs))
            {
                writer.WritePropertyName("memorySizeInGbs"u8);
                writer.WriteNumberValue(MemorySizeInGbs.Value);
            }
            if (Optional.IsDefined(SoftwareStorageSizeInGb))
            {
                writer.WritePropertyName("softwareStorageSizeInGb"u8);
                writer.WriteNumberValue(SoftwareStorageSizeInGb.Value);
            }
            writer.WritePropertyName("timeCreated"u8);
            writer.WriteStringValue(TimeCreated, "O");
            if (Optional.IsDefined(TimeMaintenanceWindowEnd))
            {
                writer.WritePropertyName("timeMaintenanceWindowEnd"u8);
                writer.WriteStringValue(TimeMaintenanceWindowEnd.Value, "O");
            }
            if (Optional.IsDefined(TimeMaintenanceWindowStart))
            {
                writer.WritePropertyName("timeMaintenanceWindowStart"u8);
                writer.WriteStringValue(TimeMaintenanceWindowStart.Value, "O");
            }
            if (Optional.IsDefined(Vnic2Id))
            {
                writer.WritePropertyName("vnic2Id"u8);
                writer.WriteStringValue(Vnic2Id);
            }
            writer.WritePropertyName("vnicId"u8);
            writer.WriteStringValue(VnicId);
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        CloudVmClusterDBNodeProperties IJsonModel<CloudVmClusterDBNodeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudVmClusterDBNodeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudVmClusterDBNodeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudVmClusterDBNodeProperties(document.RootElement, options);
        }

        internal static CloudVmClusterDBNodeProperties DeserializeCloudVmClusterDBNodeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier ocid = default;
            string additionalDetails = default;
            ResourceIdentifier backupIPId = default;
            ResourceIdentifier backupVnic2Id = default;
            ResourceIdentifier backupVnicId = default;
            int? cpuCoreCount = default;
            int? dbNodeStorageSizeInGbs = default;
            ResourceIdentifier dbServerId = default;
            ResourceIdentifier dbSystemId = default;
            string faultDomain = default;
            ResourceIdentifier hostIPId = default;
            string hostname = default;
            DBNodeProvisioningState lifecycleState = default;
            string lifecycleDetails = default;
            DBNodeMaintenanceType? maintenanceType = default;
            int? memorySizeInGbs = default;
            int? softwareStorageSizeInGb = default;
            DateTimeOffset timeCreated = default;
            DateTimeOffset? timeMaintenanceWindowEnd = default;
            DateTimeOffset? timeMaintenanceWindowStart = default;
            ResourceIdentifier vnic2Id = default;
            ResourceIdentifier vnicId = default;
            OracleDatabaseResourceProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ocid"u8))
                {
                    ocid = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("additionalDetails"u8))
                {
                    additionalDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupIpId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupIPId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupVnic2Id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupVnic2Id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupVnicId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupVnicId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cpuCoreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuCoreCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dbNodeStorageSizeInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbNodeStorageSizeInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dbServerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbServerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dbSystemId"u8))
                {
                    dbSystemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("faultDomain"u8))
                {
                    faultDomain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostIpId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostIPId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hostname"u8))
                {
                    hostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lifecycleState"u8))
                {
                    lifecycleState = new DBNodeProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lifecycleDetails"u8))
                {
                    lifecycleDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maintenanceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceType = new DBNodeMaintenanceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("memorySizeInGbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memorySizeInGbs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("softwareStorageSizeInGb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    softwareStorageSizeInGb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeCreated"u8))
                {
                    timeCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeMaintenanceWindowEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeMaintenanceWindowEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("timeMaintenanceWindowStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeMaintenanceWindowStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("vnic2Id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnic2Id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vnicId"u8))
                {
                    vnicId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new OracleDatabaseResourceProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CloudVmClusterDBNodeProperties(
                ocid,
                additionalDetails,
                backupIPId,
                backupVnic2Id,
                backupVnicId,
                cpuCoreCount,
                dbNodeStorageSizeInGbs,
                dbServerId,
                dbSystemId,
                faultDomain,
                hostIPId,
                hostname,
                lifecycleState,
                lifecycleDetails,
                maintenanceType,
                memorySizeInGbs,
                softwareStorageSizeInGb,
                timeCreated,
                timeMaintenanceWindowEnd,
                timeMaintenanceWindowStart,
                vnic2Id,
                vnicId,
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudVmClusterDBNodeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudVmClusterDBNodeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudVmClusterDBNodeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CloudVmClusterDBNodeProperties IPersistableModel<CloudVmClusterDBNodeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudVmClusterDBNodeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudVmClusterDBNodeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudVmClusterDBNodeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudVmClusterDBNodeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
