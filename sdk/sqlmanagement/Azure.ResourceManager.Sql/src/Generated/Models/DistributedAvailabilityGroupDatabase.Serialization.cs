// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class DistributedAvailabilityGroupDatabase : IUtf8JsonSerializable, IJsonModel<DistributedAvailabilityGroupDatabase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DistributedAvailabilityGroupDatabase>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DistributedAvailabilityGroupDatabase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributedAvailabilityGroupDatabase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DistributedAvailabilityGroupDatabase)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceReplicaId))
            {
                writer.WritePropertyName("instanceReplicaId"u8);
                writer.WriteStringValue(InstanceReplicaId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PartnerReplicaId))
            {
                writer.WritePropertyName("partnerReplicaId"u8);
                writer.WriteStringValue(PartnerReplicaId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicaState))
            {
                writer.WritePropertyName("replicaState"u8);
                writer.WriteStringValue(ReplicaState);
            }
            if (options.Format != "W" && Optional.IsDefined(SeedingProgress))
            {
                writer.WritePropertyName("seedingProgress"u8);
                writer.WriteStringValue(SeedingProgress);
            }
            if (options.Format != "W" && Optional.IsDefined(SynchronizationHealth))
            {
                writer.WritePropertyName("synchronizationHealth"u8);
                writer.WriteStringValue(SynchronizationHealth.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectedState))
            {
                writer.WritePropertyName("connectedState"u8);
                writer.WriteStringValue(ConnectedState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastReceivedLsn))
            {
                writer.WritePropertyName("lastReceivedLsn"u8);
                writer.WriteStringValue(LastReceivedLsn);
            }
            if (options.Format != "W" && Optional.IsDefined(LastReceivedOn))
            {
                writer.WritePropertyName("lastReceivedTime"u8);
                writer.WriteStringValue(LastReceivedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastSentLsn))
            {
                writer.WritePropertyName("lastSentLsn"u8);
                writer.WriteStringValue(LastSentLsn);
            }
            if (options.Format != "W" && Optional.IsDefined(LastSentOn))
            {
                writer.WritePropertyName("lastSentTime"u8);
                writer.WriteStringValue(LastSentOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastCommitLsn))
            {
                writer.WritePropertyName("lastCommitLsn"u8);
                writer.WriteStringValue(LastCommitLsn);
            }
            if (options.Format != "W" && Optional.IsDefined(LastCommitOn))
            {
                writer.WritePropertyName("lastCommitTime"u8);
                writer.WriteStringValue(LastCommitOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastHardenedLsn))
            {
                writer.WritePropertyName("lastHardenedLsn"u8);
                writer.WriteStringValue(LastHardenedLsn);
            }
            if (options.Format != "W" && Optional.IsDefined(LastHardenedOn))
            {
                writer.WritePropertyName("lastHardenedTime"u8);
                writer.WriteStringValue(LastHardenedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(LastBackupLsn))
            {
                writer.WritePropertyName("lastBackupLsn"u8);
                writer.WriteStringValue(LastBackupLsn);
            }
            if (options.Format != "W" && Optional.IsDefined(LastBackupOn))
            {
                writer.WritePropertyName("lastBackupTime"u8);
                writer.WriteStringValue(LastBackupOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(MostRecentLinkError))
            {
                writer.WritePropertyName("mostRecentLinkError"u8);
                writer.WriteStringValue(MostRecentLinkError);
            }
            if (options.Format != "W" && Optional.IsDefined(PartnerAuthCertValidity))
            {
                writer.WritePropertyName("partnerAuthCertValidity"u8);
                writer.WriteObjectValue(PartnerAuthCertValidity, options);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceSendReplicationLagSeconds))
            {
                writer.WritePropertyName("instanceSendReplicationLagSeconds"u8);
                writer.WriteNumberValue(InstanceSendReplicationLagSeconds.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InstanceRedoReplicationLagSeconds))
            {
                writer.WritePropertyName("instanceRedoReplicationLagSeconds"u8);
                writer.WriteNumberValue(InstanceRedoReplicationLagSeconds.Value);
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

        DistributedAvailabilityGroupDatabase IJsonModel<DistributedAvailabilityGroupDatabase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributedAvailabilityGroupDatabase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DistributedAvailabilityGroupDatabase)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDistributedAvailabilityGroupDatabase(document.RootElement, options);
        }

        internal static DistributedAvailabilityGroupDatabase DeserializeDistributedAvailabilityGroupDatabase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string databaseName = default;
            Guid? instanceReplicaId = default;
            Guid? partnerReplicaId = default;
            string replicaState = default;
            string seedingProgress = default;
            ReplicaSynchronizationHealth? synchronizationHealth = default;
            ReplicaConnectedState? connectedState = default;
            string lastReceivedLsn = default;
            DateTimeOffset? lastReceivedTime = default;
            string lastSentLsn = default;
            DateTimeOffset? lastSentTime = default;
            string lastCommitLsn = default;
            DateTimeOffset? lastCommitTime = default;
            string lastHardenedLsn = default;
            DateTimeOffset? lastHardenedTime = default;
            string lastBackupLsn = default;
            DateTimeOffset? lastBackupTime = default;
            string mostRecentLinkError = default;
            CertificateInfo partnerAuthCertValidity = default;
            int? instanceSendReplicationLagSeconds = default;
            int? instanceRedoReplicationLagSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceReplicaId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceReplicaId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("partnerReplicaId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partnerReplicaId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("replicaState"u8))
                {
                    replicaState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedingProgress"u8))
                {
                    seedingProgress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("synchronizationHealth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    synchronizationHealth = new ReplicaSynchronizationHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectedState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedState = new ReplicaConnectedState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastReceivedLsn"u8))
                {
                    lastReceivedLsn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastReceivedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastReceivedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSentLsn"u8))
                {
                    lastSentLsn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastSentTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSentTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastCommitLsn"u8))
                {
                    lastCommitLsn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCommitTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastCommitTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastHardenedLsn"u8))
                {
                    lastHardenedLsn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastHardenedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHardenedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastBackupLsn"u8))
                {
                    lastBackupLsn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastBackupTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastBackupTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("mostRecentLinkError"u8))
                {
                    mostRecentLinkError = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("partnerAuthCertValidity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partnerAuthCertValidity = CertificateInfo.DeserializeCertificateInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instanceSendReplicationLagSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceSendReplicationLagSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("instanceRedoReplicationLagSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceRedoReplicationLagSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DistributedAvailabilityGroupDatabase(
                databaseName,
                instanceReplicaId,
                partnerReplicaId,
                replicaState,
                seedingProgress,
                synchronizationHealth,
                connectedState,
                lastReceivedLsn,
                lastReceivedTime,
                lastSentLsn,
                lastSentTime,
                lastCommitLsn,
                lastCommitTime,
                lastHardenedLsn,
                lastHardenedTime,
                lastBackupLsn,
                lastBackupTime,
                mostRecentLinkError,
                partnerAuthCertValidity,
                instanceSendReplicationLagSeconds,
                instanceRedoReplicationLagSeconds,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DatabaseName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  databaseName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DatabaseName))
                {
                    builder.Append("  databaseName: ");
                    if (DatabaseName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DatabaseName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DatabaseName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InstanceReplicaId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  instanceReplicaId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InstanceReplicaId))
                {
                    builder.Append("  instanceReplicaId: ");
                    builder.AppendLine($"'{InstanceReplicaId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartnerReplicaId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  partnerReplicaId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PartnerReplicaId))
                {
                    builder.Append("  partnerReplicaId: ");
                    builder.AppendLine($"'{PartnerReplicaId.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReplicaState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  replicaState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReplicaState))
                {
                    builder.Append("  replicaState: ");
                    if (ReplicaState.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ReplicaState}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ReplicaState}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SeedingProgress), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  seedingProgress: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SeedingProgress))
                {
                    builder.Append("  seedingProgress: ");
                    if (SeedingProgress.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SeedingProgress}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SeedingProgress}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SynchronizationHealth), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  synchronizationHealth: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SynchronizationHealth))
                {
                    builder.Append("  synchronizationHealth: ");
                    builder.AppendLine($"'{SynchronizationHealth.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConnectedState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  connectedState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConnectedState))
                {
                    builder.Append("  connectedState: ");
                    builder.AppendLine($"'{ConnectedState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastReceivedLsn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastReceivedLsn: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastReceivedLsn))
                {
                    builder.Append("  lastReceivedLsn: ");
                    if (LastReceivedLsn.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastReceivedLsn}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastReceivedLsn}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastReceivedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastReceivedTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastReceivedOn))
                {
                    builder.Append("  lastReceivedTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastReceivedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastSentLsn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastSentLsn: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastSentLsn))
                {
                    builder.Append("  lastSentLsn: ");
                    if (LastSentLsn.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastSentLsn}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastSentLsn}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastSentOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastSentTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastSentOn))
                {
                    builder.Append("  lastSentTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastSentOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastCommitLsn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastCommitLsn: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastCommitLsn))
                {
                    builder.Append("  lastCommitLsn: ");
                    if (LastCommitLsn.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastCommitLsn}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastCommitLsn}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastCommitOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastCommitTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastCommitOn))
                {
                    builder.Append("  lastCommitTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastCommitOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastHardenedLsn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastHardenedLsn: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastHardenedLsn))
                {
                    builder.Append("  lastHardenedLsn: ");
                    if (LastHardenedLsn.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastHardenedLsn}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastHardenedLsn}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastHardenedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastHardenedTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastHardenedOn))
                {
                    builder.Append("  lastHardenedTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastHardenedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastBackupLsn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastBackupLsn: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastBackupLsn))
                {
                    builder.Append("  lastBackupLsn: ");
                    if (LastBackupLsn.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastBackupLsn}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastBackupLsn}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastBackupOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastBackupTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastBackupOn))
                {
                    builder.Append("  lastBackupTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(LastBackupOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MostRecentLinkError), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  mostRecentLinkError: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MostRecentLinkError))
                {
                    builder.Append("  mostRecentLinkError: ");
                    if (MostRecentLinkError.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{MostRecentLinkError}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{MostRecentLinkError}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartnerAuthCertValidity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  partnerAuthCertValidity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PartnerAuthCertValidity))
                {
                    builder.Append("  partnerAuthCertValidity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PartnerAuthCertValidity, options, 2, false, "  partnerAuthCertValidity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InstanceSendReplicationLagSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  instanceSendReplicationLagSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InstanceSendReplicationLagSeconds))
                {
                    builder.Append("  instanceSendReplicationLagSeconds: ");
                    builder.AppendLine($"{InstanceSendReplicationLagSeconds.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InstanceRedoReplicationLagSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  instanceRedoReplicationLagSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InstanceRedoReplicationLagSeconds))
                {
                    builder.Append("  instanceRedoReplicationLagSeconds: ");
                    builder.AppendLine($"{InstanceRedoReplicationLagSeconds.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DistributedAvailabilityGroupDatabase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributedAvailabilityGroupDatabase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DistributedAvailabilityGroupDatabase)} does not support writing '{options.Format}' format.");
            }
        }

        DistributedAvailabilityGroupDatabase IPersistableModel<DistributedAvailabilityGroupDatabase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DistributedAvailabilityGroupDatabase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDistributedAvailabilityGroupDatabase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DistributedAvailabilityGroupDatabase)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DistributedAvailabilityGroupDatabase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
