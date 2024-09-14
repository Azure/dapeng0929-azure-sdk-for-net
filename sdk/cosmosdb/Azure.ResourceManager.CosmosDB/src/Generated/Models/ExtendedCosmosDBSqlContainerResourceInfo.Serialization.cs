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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ExtendedCosmosDBSqlContainerResourceInfo : IUtf8JsonSerializable, IJsonModel<ExtendedCosmosDBSqlContainerResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExtendedCosmosDBSqlContainerResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedCosmosDBSqlContainerResourceInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Rid))
            {
                writer.WritePropertyName("_rid"u8);
                writer.WriteStringValue(Rid);
            }
            if (options.Format != "W" && Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("_ts"u8);
                writer.WriteNumberValue(Timestamp.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("_etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(ContainerName);
            if (Optional.IsDefined(IndexingPolicy))
            {
                writer.WritePropertyName("indexingPolicy"u8);
                writer.WriteObjectValue(IndexingPolicy, options);
            }
            if (Optional.IsDefined(PartitionKey))
            {
                writer.WritePropertyName("partitionKey"u8);
                writer.WriteObjectValue(PartitionKey, options);
            }
            if (Optional.IsDefined(DefaultTtl))
            {
                writer.WritePropertyName("defaultTtl"u8);
                writer.WriteNumberValue(DefaultTtl.Value);
            }
            if (Optional.IsDefined(UniqueKeyPolicy))
            {
                writer.WritePropertyName("uniqueKeyPolicy"u8);
                writer.WriteObjectValue(UniqueKeyPolicy, options);
            }
            if (Optional.IsDefined(ConflictResolutionPolicy))
            {
                writer.WritePropertyName("conflictResolutionPolicy"u8);
                writer.WriteObjectValue(ConflictResolutionPolicy, options);
            }
            if (Optional.IsDefined(ClientEncryptionPolicy))
            {
                writer.WritePropertyName("clientEncryptionPolicy"u8);
                writer.WriteObjectValue(ClientEncryptionPolicy, options);
            }
            if (Optional.IsDefined(AnalyticalStorageTtl))
            {
                writer.WritePropertyName("analyticalStorageTtl"u8);
                writer.WriteNumberValue(AnalyticalStorageTtl.Value);
            }
            if (Optional.IsDefined(RestoreParameters))
            {
                writer.WritePropertyName("restoreParameters"u8);
                writer.WriteObjectValue(RestoreParameters, options);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ComputedProperties))
            {
                writer.WritePropertyName("computedProperties"u8);
                writer.WriteStartArray();
                foreach (var item in ComputedProperties)
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

        ExtendedCosmosDBSqlContainerResourceInfo IJsonModel<ExtendedCosmosDBSqlContainerResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExtendedCosmosDBSqlContainerResourceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExtendedCosmosDBSqlContainerResourceInfo(document.RootElement, options);
        }

        internal static ExtendedCosmosDBSqlContainerResourceInfo DeserializeExtendedCosmosDBSqlContainerResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string rid = default;
            float? ts = default;
            ETag? etag = default;
            string id = default;
            CosmosDBIndexingPolicy indexingPolicy = default;
            CosmosDBContainerPartitionKey partitionKey = default;
            int? defaultTtl = default;
            CosmosDBUniqueKeyPolicy uniqueKeyPolicy = default;
            ConflictResolutionPolicy conflictResolutionPolicy = default;
            CosmosDBClientEncryptionPolicy clientEncryptionPolicy = default;
            long? analyticalStorageTtl = default;
            ResourceRestoreParameters restoreParameters = default;
            CosmosDBAccountCreateMode? createMode = default;
            IList<ComputedProperty> computedProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("_rid"u8))
                {
                    rid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("_ts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ts = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("_etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexingPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    indexingPolicy = CosmosDBIndexingPolicy.DeserializeCosmosDBIndexingPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("partitionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionKey = CosmosDBContainerPartitionKey.DeserializeCosmosDBContainerPartitionKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("defaultTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultTtl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uniqueKeyPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uniqueKeyPolicy = CosmosDBUniqueKeyPolicy.DeserializeCosmosDBUniqueKeyPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("conflictResolutionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conflictResolutionPolicy = ConflictResolutionPolicy.DeserializeConflictResolutionPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("clientEncryptionPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientEncryptionPolicy = CosmosDBClientEncryptionPolicy.DeserializeCosmosDBClientEncryptionPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticalStorageTtl = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new CosmosDBAccountCreateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computedProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputedProperty> array = new List<ComputedProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputedProperty.DeserializeComputedProperty(item, options));
                    }
                    computedProperties = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExtendedCosmosDBSqlContainerResourceInfo(
                id,
                indexingPolicy,
                partitionKey,
                defaultTtl,
                uniqueKeyPolicy,
                conflictResolutionPolicy,
                clientEncryptionPolicy,
                analyticalStorageTtl,
                restoreParameters,
                createMode,
                computedProperties ?? new ChangeTrackingList<ComputedProperty>(),
                serializedAdditionalRawData,
                rid,
                ts,
                etag);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Rid), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  _rid: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Rid))
                {
                    builder.Append("  _rid: ");
                    if (Rid.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Rid}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Rid}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Timestamp), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  _ts: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Timestamp))
                {
                    builder.Append("  _ts: ");
                    builder.AppendLine($"'{Timestamp.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ETag), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  _etag: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ETag))
                {
                    builder.Append("  _etag: ");
                    builder.AppendLine($"'{ETag.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContainerName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContainerName))
                {
                    builder.Append("  id: ");
                    if (ContainerName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContainerName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContainerName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IndexingPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  indexingPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IndexingPolicy))
                {
                    builder.Append("  indexingPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, IndexingPolicy, options, 2, false, "  indexingPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PartitionKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  partitionKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PartitionKey))
                {
                    builder.Append("  partitionKey: ");
                    BicepSerializationHelpers.AppendChildObject(builder, PartitionKey, options, 2, false, "  partitionKey: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultTtl), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  defaultTtl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefaultTtl))
                {
                    builder.Append("  defaultTtl: ");
                    builder.AppendLine($"{DefaultTtl.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("UniqueKeys", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  uniqueKeyPolicy: ");
                builder.AppendLine("{");
                builder.Append("    uniqueKeys: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(UniqueKeyPolicy))
                {
                    builder.Append("  uniqueKeyPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, UniqueKeyPolicy, options, 2, false, "  uniqueKeyPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConflictResolutionPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  conflictResolutionPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConflictResolutionPolicy))
                {
                    builder.Append("  conflictResolutionPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ConflictResolutionPolicy, options, 2, false, "  conflictResolutionPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientEncryptionPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientEncryptionPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientEncryptionPolicy))
                {
                    builder.Append("  clientEncryptionPolicy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ClientEncryptionPolicy, options, 2, false, "  clientEncryptionPolicy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AnalyticalStorageTtl), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  analyticalStorageTtl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AnalyticalStorageTtl))
                {
                    builder.Append("  analyticalStorageTtl: ");
                    builder.AppendLine($"'{AnalyticalStorageTtl.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RestoreParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  restoreParameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RestoreParameters))
                {
                    builder.Append("  restoreParameters: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RestoreParameters, options, 2, false, "  restoreParameters: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreateMode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  createMode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreateMode))
                {
                    builder.Append("  createMode: ");
                    builder.AppendLine($"'{CreateMode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComputedProperties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  computedProperties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ComputedProperties))
                {
                    if (ComputedProperties.Any())
                    {
                        builder.Append("  computedProperties: ");
                        builder.AppendLine("[");
                        foreach (var item in ComputedProperties)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  computedProperties: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ExtendedCosmosDBSqlContainerResourceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        ExtendedCosmosDBSqlContainerResourceInfo IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExtendedCosmosDBSqlContainerResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExtendedCosmosDBSqlContainerResourceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExtendedCosmosDBSqlContainerResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
