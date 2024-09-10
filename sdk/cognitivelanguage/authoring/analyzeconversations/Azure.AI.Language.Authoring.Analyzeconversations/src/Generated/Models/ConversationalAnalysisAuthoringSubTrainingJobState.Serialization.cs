// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    public partial class ConversationalAnalysisAuthoringSubTrainingJobState : IUtf8JsonSerializable, IJsonModel<ConversationalAnalysisAuthoringSubTrainingJobState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConversationalAnalysisAuthoringSubTrainingJobState>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConversationalAnalysisAuthoringSubTrainingJobState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringSubTrainingJobState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringSubTrainingJobState)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("percentComplete"u8);
            writer.WriteNumberValue(PercentComplete);
            if (Optional.IsDefined(StartDateTime))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartDateTime.Value, "O");
            }
            if (Optional.IsDefined(EndDateTime))
            {
                writer.WritePropertyName("endDateTime"u8);
                writer.WriteStringValue(EndDateTime.Value, "O");
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
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

        ConversationalAnalysisAuthoringSubTrainingJobState IJsonModel<ConversationalAnalysisAuthoringSubTrainingJobState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringSubTrainingJobState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringSubTrainingJobState)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationalAnalysisAuthoringSubTrainingJobState(document.RootElement, options);
        }

        internal static ConversationalAnalysisAuthoringSubTrainingJobState DeserializeConversationalAnalysisAuthoringSubTrainingJobState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int percentComplete = default;
            DateTimeOffset? startDateTime = default;
            DateTimeOffset? endDateTime = default;
            ConversationalAnalysisAuthoringJobStatus status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("percentComplete"u8))
                {
                    percentComplete = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new ConversationalAnalysisAuthoringJobStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConversationalAnalysisAuthoringSubTrainingJobState(percentComplete, startDateTime, endDateTime, status, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConversationalAnalysisAuthoringSubTrainingJobState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringSubTrainingJobState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringSubTrainingJobState)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationalAnalysisAuthoringSubTrainingJobState IPersistableModel<ConversationalAnalysisAuthoringSubTrainingJobState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringSubTrainingJobState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConversationalAnalysisAuthoringSubTrainingJobState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringSubTrainingJobState)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationalAnalysisAuthoringSubTrainingJobState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ConversationalAnalysisAuthoringSubTrainingJobState FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConversationalAnalysisAuthoringSubTrainingJobState(document.RootElement);
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
