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
    public partial class MachineLearningServicesDatasetDriftDetectedEventData : IUtf8JsonSerializable, IJsonModel<MachineLearningServicesDatasetDriftDetectedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningServicesDatasetDriftDetectedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicesDatasetDriftDetectedEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DataDriftId))
            {
                writer.WritePropertyName("dataDriftId"u8);
                writer.WriteStringValue(DataDriftId);
            }
            if (Optional.IsDefined(DataDriftName))
            {
                writer.WritePropertyName("dataDriftName"u8);
                writer.WriteStringValue(DataDriftName);
            }
            if (Optional.IsDefined(RunId))
            {
                writer.WritePropertyName("runId"u8);
                writer.WriteStringValue(RunId);
            }
            if (Optional.IsDefined(BaseDatasetId))
            {
                writer.WritePropertyName("baseDatasetId"u8);
                writer.WriteStringValue(BaseDatasetId);
            }
            if (Optional.IsDefined(TargetDatasetId))
            {
                writer.WritePropertyName("targetDatasetId"u8);
                writer.WriteStringValue(TargetDatasetId);
            }
            if (Optional.IsDefined(DriftCoefficient))
            {
                writer.WritePropertyName("driftCoefficient"u8);
                writer.WriteNumberValue(DriftCoefficient.Value);
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartTime.Value, "O");
            }
            if (Optional.IsDefined(EndTime))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndTime.Value, "O");
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

        MachineLearningServicesDatasetDriftDetectedEventData IJsonModel<MachineLearningServicesDatasetDriftDetectedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicesDatasetDriftDetectedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServicesDatasetDriftDetectedEventData(document.RootElement, options);
        }

        internal static MachineLearningServicesDatasetDriftDetectedEventData DeserializeMachineLearningServicesDatasetDriftDetectedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dataDriftId = default;
            string dataDriftName = default;
            string runId = default;
            string baseDatasetId = default;
            string targetDatasetId = default;
            double? driftCoefficient = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataDriftId"u8))
                {
                    dataDriftId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataDriftName"u8))
                {
                    dataDriftName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseDatasetId"u8))
                {
                    baseDatasetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatasetId"u8))
                {
                    targetDatasetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driftCoefficient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    driftCoefficient = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningServicesDatasetDriftDetectedEventData(
                dataDriftId,
                dataDriftName,
                runId,
                baseDatasetId,
                targetDatasetId,
                driftCoefficient,
                startTime,
                endTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicesDatasetDriftDetectedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningServicesDatasetDriftDetectedEventData IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningServicesDatasetDriftDetectedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicesDatasetDriftDetectedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MachineLearningServicesDatasetDriftDetectedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMachineLearningServicesDatasetDriftDetectedEventData(document.RootElement);
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
