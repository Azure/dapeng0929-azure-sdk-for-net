// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class AzureMonitorAlertSettings : IUtf8JsonSerializable, IJsonModel<AzureMonitorAlertSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureMonitorAlertSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureMonitorAlertSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMonitorAlertSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMonitorAlertSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AlertsForAllJobFailures))
            {
                writer.WritePropertyName("alertsForAllJobFailures"u8);
                writer.WriteStringValue(AlertsForAllJobFailures.Value.ToString());
            }
            if (Optional.IsDefined(AlertsForAllReplicationIssues))
            {
                writer.WritePropertyName("alertsForAllReplicationIssues"u8);
                writer.WriteStringValue(AlertsForAllReplicationIssues.Value.ToString());
            }
            if (Optional.IsDefined(AlertsForAllFailoverIssues))
            {
                writer.WritePropertyName("alertsForAllFailoverIssues"u8);
                writer.WriteStringValue(AlertsForAllFailoverIssues.Value.ToString());
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

        AzureMonitorAlertSettings IJsonModel<AzureMonitorAlertSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMonitorAlertSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureMonitorAlertSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureMonitorAlertSettings(document.RootElement, options);
        }

        internal static AzureMonitorAlertSettings DeserializeAzureMonitorAlertSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecoveryServicesAlertsState? alertsForAllJobFailures = default;
            RecoveryServicesAlertsState? alertsForAllReplicationIssues = default;
            RecoveryServicesAlertsState? alertsForAllFailoverIssues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertsForAllJobFailures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertsForAllJobFailures = new RecoveryServicesAlertsState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertsForAllReplicationIssues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertsForAllReplicationIssues = new RecoveryServicesAlertsState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertsForAllFailoverIssues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertsForAllFailoverIssues = new RecoveryServicesAlertsState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureMonitorAlertSettings(alertsForAllJobFailures, alertsForAllReplicationIssues, alertsForAllFailoverIssues, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureMonitorAlertSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMonitorAlertSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureMonitorAlertSettings)} does not support writing '{options.Format}' format.");
            }
        }

        AzureMonitorAlertSettings IPersistableModel<AzureMonitorAlertSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureMonitorAlertSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureMonitorAlertSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureMonitorAlertSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureMonitorAlertSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
