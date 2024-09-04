// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AReplicationProtectionClusterDetails : IUtf8JsonSerializable, IJsonModel<A2AReplicationProtectionClusterDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AReplicationProtectionClusterDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<A2AReplicationProtectionClusterDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReplicationProtectionClusterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AReplicationProtectionClusterDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MultiVmGroupId))
            {
                writer.WritePropertyName("multiVmGroupId"u8);
                writer.WriteStringValue(MultiVmGroupId);
            }
            if (Optional.IsDefined(MultiVmGroupName))
            {
                writer.WritePropertyName("multiVmGroupName"u8);
                writer.WriteStringValue(MultiVmGroupName);
            }
            if (Optional.IsDefined(MultiVmGroupCreateOption))
            {
                writer.WritePropertyName("multiVmGroupCreateOption"u8);
                writer.WriteStringValue(MultiVmGroupCreateOption.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryFabricLocation))
            {
                writer.WritePropertyName("primaryFabricLocation"u8);
                writer.WriteStringValue(PrimaryFabricLocation.Value);
            }
            if (Optional.IsDefined(RecoveryFabricLocation))
            {
                writer.WritePropertyName("recoveryFabricLocation"u8);
                writer.WriteStringValue(RecoveryFabricLocation.Value);
            }
            if (Optional.IsDefined(FailoverRecoveryPointId))
            {
                writer.WritePropertyName("failoverRecoveryPointId"u8);
                writer.WriteStringValue(FailoverRecoveryPointId);
            }
            if (Optional.IsDefined(ClusterManagementId))
            {
                writer.WritePropertyName("clusterManagementId"u8);
                writer.WriteStringValue(ClusterManagementId);
            }
            if (Optional.IsDefined(RpoInSeconds))
            {
                writer.WritePropertyName("rpoInSeconds"u8);
                writer.WriteNumberValue(RpoInSeconds.Value);
            }
            if (Optional.IsDefined(LastRpoCalculatedOn))
            {
                writer.WritePropertyName("lastRpoCalculatedTime"u8);
                writer.WriteStringValue(LastRpoCalculatedOn.Value, "O");
            }
            if (Optional.IsDefined(InitialPrimaryZone))
            {
                writer.WritePropertyName("initialPrimaryZone"u8);
                writer.WriteStringValue(InitialPrimaryZone);
            }
            if (Optional.IsDefined(InitialPrimaryFabricLocation))
            {
                writer.WritePropertyName("initialPrimaryFabricLocation"u8);
                writer.WriteStringValue(InitialPrimaryFabricLocation.Value);
            }
            if (Optional.IsDefined(InitialRecoveryZone))
            {
                writer.WritePropertyName("initialRecoveryZone"u8);
                writer.WriteStringValue(InitialRecoveryZone);
            }
            if (Optional.IsDefined(InitialRecoveryFabricLocation))
            {
                writer.WritePropertyName("initialRecoveryFabricLocation"u8);
                writer.WriteStringValue(InitialRecoveryFabricLocation.Value);
            }
            if (Optional.IsDefined(InitialPrimaryExtendedLocation))
            {
                writer.WritePropertyName("initialPrimaryExtendedLocation"u8);
                writer.WriteObjectValue(InitialPrimaryExtendedLocation, options);
            }
            if (Optional.IsDefined(InitialRecoveryExtendedLocation))
            {
                writer.WritePropertyName("initialRecoveryExtendedLocation"u8);
                writer.WriteObjectValue(InitialRecoveryExtendedLocation, options);
            }
            if (Optional.IsDefined(PrimaryAvailabilityZone))
            {
                writer.WritePropertyName("primaryAvailabilityZone"u8);
                writer.WriteStringValue(PrimaryAvailabilityZone);
            }
            if (Optional.IsDefined(RecoveryAvailabilityZone))
            {
                writer.WritePropertyName("recoveryAvailabilityZone"u8);
                writer.WriteStringValue(RecoveryAvailabilityZone);
            }
            if (Optional.IsDefined(PrimaryExtendedLocation))
            {
                writer.WritePropertyName("primaryExtendedLocation"u8);
                writer.WriteObjectValue(PrimaryExtendedLocation, options);
            }
            if (Optional.IsDefined(RecoveryExtendedLocation))
            {
                writer.WritePropertyName("recoveryExtendedLocation"u8);
                writer.WriteObjectValue(RecoveryExtendedLocation, options);
            }
            if (Optional.IsDefined(LifecycleId))
            {
                writer.WritePropertyName("lifecycleId"u8);
                writer.WriteStringValue(LifecycleId);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        A2AReplicationProtectionClusterDetails IJsonModel<A2AReplicationProtectionClusterDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReplicationProtectionClusterDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AReplicationProtectionClusterDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AReplicationProtectionClusterDetails(document.RootElement, options);
        }

        internal static A2AReplicationProtectionClusterDetails DeserializeA2AReplicationProtectionClusterDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string multiVmGroupId = default;
            string multiVmGroupName = default;
            MultiVmGroupCreateOption? multiVmGroupCreateOption = default;
            AzureLocation? primaryFabricLocation = default;
            AzureLocation? recoveryFabricLocation = default;
            ResourceIdentifier failoverRecoveryPointId = default;
            string clusterManagementId = default;
            long? rpoInSeconds = default;
            DateTimeOffset? lastRpoCalculatedTime = default;
            string initialPrimaryZone = default;
            AzureLocation? initialPrimaryFabricLocation = default;
            string initialRecoveryZone = default;
            AzureLocation? initialRecoveryFabricLocation = default;
            SiteRecoveryExtendedLocation initialPrimaryExtendedLocation = default;
            SiteRecoveryExtendedLocation initialRecoveryExtendedLocation = default;
            string primaryAvailabilityZone = default;
            string recoveryAvailabilityZone = default;
            SiteRecoveryExtendedLocation primaryExtendedLocation = default;
            SiteRecoveryExtendedLocation recoveryExtendedLocation = default;
            string lifecycleId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("multiVmGroupId"u8))
                {
                    multiVmGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupCreateOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multiVmGroupCreateOption = new MultiVmGroupCreateOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failoverRecoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failoverRecoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clusterManagementId"u8))
                {
                    clusterManagementId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rpoInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rpoInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastRpoCalculatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRpoCalculatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("initialPrimaryZone"u8))
                {
                    initialPrimaryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialPrimaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialPrimaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initialRecoveryZone"u8))
                {
                    initialRecoveryZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialRecoveryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialRecoveryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initialPrimaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialPrimaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("initialRecoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialRecoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("primaryAvailabilityZone"u8))
                {
                    primaryAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilityZone"u8))
                {
                    recoveryAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recoveryExtendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryExtendedLocation = SiteRecoveryExtendedLocation.DeserializeSiteRecoveryExtendedLocation(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lifecycleId"u8))
                {
                    lifecycleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new A2AReplicationProtectionClusterDetails(
                instanceType,
                serializedAdditionalRawData,
                multiVmGroupId,
                multiVmGroupName,
                multiVmGroupCreateOption,
                primaryFabricLocation,
                recoveryFabricLocation,
                failoverRecoveryPointId,
                clusterManagementId,
                rpoInSeconds,
                lastRpoCalculatedTime,
                initialPrimaryZone,
                initialPrimaryFabricLocation,
                initialRecoveryZone,
                initialRecoveryFabricLocation,
                initialPrimaryExtendedLocation,
                initialRecoveryExtendedLocation,
                primaryAvailabilityZone,
                recoveryAvailabilityZone,
                primaryExtendedLocation,
                recoveryExtendedLocation,
                lifecycleId);
        }

        BinaryData IPersistableModel<A2AReplicationProtectionClusterDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReplicationProtectionClusterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(A2AReplicationProtectionClusterDetails)} does not support writing '{options.Format}' format.");
            }
        }

        A2AReplicationProtectionClusterDetails IPersistableModel<A2AReplicationProtectionClusterDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AReplicationProtectionClusterDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AReplicationProtectionClusterDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(A2AReplicationProtectionClusterDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AReplicationProtectionClusterDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
