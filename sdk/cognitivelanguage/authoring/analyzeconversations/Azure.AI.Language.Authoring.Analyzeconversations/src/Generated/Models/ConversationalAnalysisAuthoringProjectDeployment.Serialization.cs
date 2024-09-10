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
    public partial class ConversationalAnalysisAuthoringProjectDeployment : IUtf8JsonSerializable, IJsonModel<ConversationalAnalysisAuthoringProjectDeployment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConversationalAnalysisAuthoringProjectDeployment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConversationalAnalysisAuthoringProjectDeployment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringProjectDeployment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringProjectDeployment)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("deploymentName"u8);
                writer.WriteStringValue(DeploymentName);
            }
            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            writer.WritePropertyName("lastTrainedDateTime"u8);
            writer.WriteStringValue(LastTrainedDateTime, "O");
            writer.WritePropertyName("lastDeployedDateTime"u8);
            writer.WriteStringValue(LastDeployedDateTime, "O");
            writer.WritePropertyName("deploymentExpirationDate"u8);
            writer.WriteStringValue(DeploymentExpirationDate, "D");
            writer.WritePropertyName("modelTrainingConfigVersion"u8);
            writer.WriteStringValue(ModelTrainingConfigVersion);
            writer.WritePropertyName("assignedResources"u8);
            writer.WriteStartArray();
            foreach (var item in AssignedResources)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        ConversationalAnalysisAuthoringProjectDeployment IJsonModel<ConversationalAnalysisAuthoringProjectDeployment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringProjectDeployment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringProjectDeployment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationalAnalysisAuthoringProjectDeployment(document.RootElement, options);
        }

        internal static ConversationalAnalysisAuthoringProjectDeployment DeserializeConversationalAnalysisAuthoringProjectDeployment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string deploymentName = default;
            string modelId = default;
            DateTimeOffset lastTrainedDateTime = default;
            DateTimeOffset lastDeployedDateTime = default;
            DateTimeOffset deploymentExpirationDate = default;
            string modelTrainingConfigVersion = default;
            IReadOnlyList<ConversationalAnalysisAuthoringDeploymentResource> assignedResources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentName"u8))
                {
                    deploymentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastTrainedDateTime"u8))
                {
                    lastTrainedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastDeployedDateTime"u8))
                {
                    lastDeployedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deploymentExpirationDate"u8))
                {
                    deploymentExpirationDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("modelTrainingConfigVersion"u8))
                {
                    modelTrainingConfigVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignedResources"u8))
                {
                    List<ConversationalAnalysisAuthoringDeploymentResource> array = new List<ConversationalAnalysisAuthoringDeploymentResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationalAnalysisAuthoringDeploymentResource.DeserializeConversationalAnalysisAuthoringDeploymentResource(item, options));
                    }
                    assignedResources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConversationalAnalysisAuthoringProjectDeployment(
                deploymentName,
                modelId,
                lastTrainedDateTime,
                lastDeployedDateTime,
                deploymentExpirationDate,
                modelTrainingConfigVersion,
                assignedResources,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConversationalAnalysisAuthoringProjectDeployment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringProjectDeployment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringProjectDeployment)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationalAnalysisAuthoringProjectDeployment IPersistableModel<ConversationalAnalysisAuthoringProjectDeployment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringProjectDeployment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConversationalAnalysisAuthoringProjectDeployment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringProjectDeployment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationalAnalysisAuthoringProjectDeployment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ConversationalAnalysisAuthoringProjectDeployment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConversationalAnalysisAuthoringProjectDeployment(document.RootElement);
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
