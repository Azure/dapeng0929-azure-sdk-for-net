// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class StorageBlobInventoryPolicyCompletedEventData : IUtf8JsonSerializable, IJsonModel<StorageBlobInventoryPolicyCompletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageBlobInventoryPolicyCompletedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageBlobInventoryPolicyCompletedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBlobInventoryPolicyCompletedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageBlobInventoryPolicyCompletedEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleDateTime))
            {
                writer.WritePropertyName("scheduleDateTime"u8);
                writer.WriteStringValue(ScheduleDateTime.Value, "O");
            }
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(RuleName))
            {
                writer.WritePropertyName("ruleName"u8);
                writer.WriteStringValue(RuleName);
            }
            if (Optional.IsDefined(PolicyRunStatus))
            {
                writer.WritePropertyName("policyRunStatus"u8);
                writer.WriteStringValue(PolicyRunStatus);
            }
            if (Optional.IsDefined(PolicyRunStatusMessage))
            {
                writer.WritePropertyName("policyRunStatusMessage"u8);
                writer.WriteStringValue(PolicyRunStatusMessage);
            }
            if (Optional.IsDefined(PolicyRunId))
            {
                writer.WritePropertyName("policyRunId"u8);
                writer.WriteStringValue(PolicyRunId);
            }
            if (Optional.IsDefined(ManifestBlobUrl))
            {
                writer.WritePropertyName("manifestBlobUrl"u8);
                writer.WriteStringValue(ManifestBlobUrl);
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

        StorageBlobInventoryPolicyCompletedEventData IJsonModel<StorageBlobInventoryPolicyCompletedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBlobInventoryPolicyCompletedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageBlobInventoryPolicyCompletedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageBlobInventoryPolicyCompletedEventData(document.RootElement, options);
        }

        internal static StorageBlobInventoryPolicyCompletedEventData DeserializeStorageBlobInventoryPolicyCompletedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? scheduleDateTime = default;
            string accountName = default;
            string ruleName = default;
            string policyRunStatus = default;
            string policyRunStatusMessage = default;
            string policyRunId = default;
            string manifestBlobUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleName"u8))
                {
                    ruleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyRunStatus"u8))
                {
                    policyRunStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyRunStatusMessage"u8))
                {
                    policyRunStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyRunId"u8))
                {
                    policyRunId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manifestBlobUrl"u8))
                {
                    manifestBlobUrl = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageBlobInventoryPolicyCompletedEventData(
                scheduleDateTime,
                accountName,
                ruleName,
                policyRunStatus,
                policyRunStatusMessage,
                policyRunId,
                manifestBlobUrl,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageBlobInventoryPolicyCompletedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBlobInventoryPolicyCompletedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageBlobInventoryPolicyCompletedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        StorageBlobInventoryPolicyCompletedEventData IPersistableModel<StorageBlobInventoryPolicyCompletedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageBlobInventoryPolicyCompletedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageBlobInventoryPolicyCompletedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageBlobInventoryPolicyCompletedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageBlobInventoryPolicyCompletedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static StorageBlobInventoryPolicyCompletedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeStorageBlobInventoryPolicyCompletedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
