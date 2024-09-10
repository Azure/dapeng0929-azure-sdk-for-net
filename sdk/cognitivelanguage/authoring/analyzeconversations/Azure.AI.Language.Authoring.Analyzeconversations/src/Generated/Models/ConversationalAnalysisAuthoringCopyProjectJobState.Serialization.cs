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
    public partial class ConversationalAnalysisAuthoringCopyProjectJobState : IUtf8JsonSerializable, IJsonModel<ConversationalAnalysisAuthoringCopyProjectJobState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConversationalAnalysisAuthoringCopyProjectJobState>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConversationalAnalysisAuthoringCopyProjectJobState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringCopyProjectJobState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringCopyProjectJobState)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            writer.WritePropertyName("createdDateTime"u8);
            writer.WriteStringValue(CreatedDateTime, "O");
            writer.WritePropertyName("lastUpdatedDateTime"u8);
            writer.WriteStringValue(LastUpdatedDateTime, "O");
            if (Optional.IsDefined(ExpirationDateTime))
            {
                writer.WritePropertyName("expirationDateTime"u8);
                writer.WriteStringValue(ExpirationDateTime.Value, "O");
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            if (Optional.IsCollectionDefined(Warnings))
            {
                writer.WritePropertyName("warnings"u8);
                writer.WriteStartArray();
                foreach (var item in Warnings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
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

        ConversationalAnalysisAuthoringCopyProjectJobState IJsonModel<ConversationalAnalysisAuthoringCopyProjectJobState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringCopyProjectJobState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringCopyProjectJobState)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationalAnalysisAuthoringCopyProjectJobState(document.RootElement, options);
        }

        internal static ConversationalAnalysisAuthoringCopyProjectJobState DeserializeConversationalAnalysisAuthoringCopyProjectJobState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string jobId = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            DateTimeOffset? expirationDateTime = default;
            ConversationalAnalysisAuthoringJobStatus status = default;
            IReadOnlyList<ConversationalAnalysisAuthoringWarning> warnings = default;
            IReadOnlyList<Error> errors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new ConversationalAnalysisAuthoringJobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("warnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConversationalAnalysisAuthoringWarning> array = new List<ConversationalAnalysisAuthoringWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationalAnalysisAuthoringWarning.DeserializeConversationalAnalysisAuthoringWarning(item, options));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Error> array = new List<Error>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Error.DeserializeError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConversationalAnalysisAuthoringCopyProjectJobState(
                jobId,
                createdDateTime,
                lastUpdatedDateTime,
                expirationDateTime,
                status,
                warnings ?? new ChangeTrackingList<ConversationalAnalysisAuthoringWarning>(),
                errors ?? new ChangeTrackingList<Error>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConversationalAnalysisAuthoringCopyProjectJobState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringCopyProjectJobState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringCopyProjectJobState)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationalAnalysisAuthoringCopyProjectJobState IPersistableModel<ConversationalAnalysisAuthoringCopyProjectJobState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringCopyProjectJobState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConversationalAnalysisAuthoringCopyProjectJobState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringCopyProjectJobState)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationalAnalysisAuthoringCopyProjectJobState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ConversationalAnalysisAuthoringCopyProjectJobState FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConversationalAnalysisAuthoringCopyProjectJobState(document.RootElement);
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
