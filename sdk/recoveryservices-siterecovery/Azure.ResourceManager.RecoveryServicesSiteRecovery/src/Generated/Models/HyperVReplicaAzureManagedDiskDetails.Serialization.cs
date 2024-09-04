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
    public partial class HyperVReplicaAzureManagedDiskDetails : IUtf8JsonSerializable, IJsonModel<HyperVReplicaAzureManagedDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVReplicaAzureManagedDiskDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HyperVReplicaAzureManagedDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureManagedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureManagedDiskDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskId))
            {
                writer.WritePropertyName("diskId"u8);
                writer.WriteStringValue(DiskId);
            }
            if (Optional.IsDefined(SeedManagedDiskId))
            {
                writer.WritePropertyName("seedManagedDiskId"u8);
                writer.WriteStringValue(SeedManagedDiskId);
            }
            if (Optional.IsDefined(ReplicaDiskType))
            {
                writer.WritePropertyName("replicaDiskType"u8);
                writer.WriteStringValue(ReplicaDiskType);
            }
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (Optional.IsDefined(TargetDiskAccountType))
            {
                writer.WritePropertyName("targetDiskAccountType"u8);
                writer.WriteStringValue(TargetDiskAccountType.Value.ToString());
            }
            if (Optional.IsDefined(SectorSizeInBytes))
            {
                writer.WritePropertyName("sectorSizeInBytes"u8);
                writer.WriteNumberValue(SectorSizeInBytes.Value);
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

        HyperVReplicaAzureManagedDiskDetails IJsonModel<HyperVReplicaAzureManagedDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureManagedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaAzureManagedDiskDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaAzureManagedDiskDetails(document.RootElement, options);
        }

        internal static HyperVReplicaAzureManagedDiskDetails DeserializeHyperVReplicaAzureManagedDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string diskId = default;
            string seedManagedDiskId = default;
            string replicaDiskType = default;
            ResourceIdentifier diskEncryptionSetId = default;
            SiteRecoveryDiskAccountType? targetDiskAccountType = default;
            int? sectorSizeInBytes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskId"u8))
                {
                    diskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("seedManagedDiskId"u8))
                {
                    seedManagedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicaDiskType"u8))
                {
                    replicaDiskType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetDiskAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetDiskAccountType = new SiteRecoveryDiskAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sectorSizeInBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sectorSizeInBytes = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HyperVReplicaAzureManagedDiskDetails(
                diskId,
                seedManagedDiskId,
                replicaDiskType,
                diskEncryptionSetId,
                targetDiskAccountType,
                sectorSizeInBytes,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HyperVReplicaAzureManagedDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureManagedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureManagedDiskDetails)} does not support writing '{options.Format}' format.");
            }
        }

        HyperVReplicaAzureManagedDiskDetails IPersistableModel<HyperVReplicaAzureManagedDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaAzureManagedDiskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVReplicaAzureManagedDiskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaAzureManagedDiskDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVReplicaAzureManagedDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
