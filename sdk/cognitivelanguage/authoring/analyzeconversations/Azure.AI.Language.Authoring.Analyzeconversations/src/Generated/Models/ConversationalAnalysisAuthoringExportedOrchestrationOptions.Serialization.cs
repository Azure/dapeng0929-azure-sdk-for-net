// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    [PersistableModelProxy(typeof(UnknownConversationalAnalysisAuthoringExportedOrchestrationOptions))]
    public partial class ConversationalAnalysisAuthoringExportedOrchestrationOptions : IUtf8JsonSerializable, IJsonModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringExportedOrchestrationOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("targetProjectKind"u8);
            writer.WriteStringValue(TargetProjectKind.ToString());
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

        ConversationalAnalysisAuthoringExportedOrchestrationOptions IJsonModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringExportedOrchestrationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationalAnalysisAuthoringExportedOrchestrationOptions(document.RootElement, options);
        }

        internal static ConversationalAnalysisAuthoringExportedOrchestrationOptions DeserializeConversationalAnalysisAuthoringExportedOrchestrationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("targetProjectKind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Conversation": return ConversationalAnalysisAuthoringExportedConversationOrchestrationOptions.DeserializeConversationalAnalysisAuthoringExportedConversationOrchestrationOptions(element, options);
                    case "Luis": return ConversationalAnalysisAuthoringExportedLuisOrchestrationOptions.DeserializeConversationalAnalysisAuthoringExportedLuisOrchestrationOptions(element, options);
                    case "QuestionAnswering": return ConversationalAnalysisAuthoringExportedQuestionAnsweringOrchestrationOptions.DeserializeConversationalAnalysisAuthoringExportedQuestionAnsweringOrchestrationOptions(element, options);
                }
            }
            return UnknownConversationalAnalysisAuthoringExportedOrchestrationOptions.DeserializeUnknownConversationalAnalysisAuthoringExportedOrchestrationOptions(element, options);
        }

        BinaryData IPersistableModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringExportedOrchestrationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationalAnalysisAuthoringExportedOrchestrationOptions IPersistableModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConversationalAnalysisAuthoringExportedOrchestrationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringExportedOrchestrationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationalAnalysisAuthoringExportedOrchestrationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ConversationalAnalysisAuthoringExportedOrchestrationOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConversationalAnalysisAuthoringExportedOrchestrationOptions(document.RootElement);
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
