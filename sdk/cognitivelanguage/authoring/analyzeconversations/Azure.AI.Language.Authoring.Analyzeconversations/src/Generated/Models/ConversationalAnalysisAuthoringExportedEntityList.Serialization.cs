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
    public partial class ConversationalAnalysisAuthoringExportedEntityList : IUtf8JsonSerializable, IJsonModel<ConversationalAnalysisAuthoringExportedEntityList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConversationalAnalysisAuthoringExportedEntityList>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConversationalAnalysisAuthoringExportedEntityList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringExportedEntityList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringExportedEntityList)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Sublists))
            {
                writer.WritePropertyName("sublists"u8);
                writer.WriteStartArray();
                foreach (var item in Sublists)
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

        ConversationalAnalysisAuthoringExportedEntityList IJsonModel<ConversationalAnalysisAuthoringExportedEntityList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringExportedEntityList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringExportedEntityList)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationalAnalysisAuthoringExportedEntityList(document.RootElement, options);
        }

        internal static ConversationalAnalysisAuthoringExportedEntityList DeserializeConversationalAnalysisAuthoringExportedEntityList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ConversationalAnalysisAuthoringExportedEntitySublist> sublists = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sublists"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConversationalAnalysisAuthoringExportedEntitySublist> array = new List<ConversationalAnalysisAuthoringExportedEntitySublist>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationalAnalysisAuthoringExportedEntitySublist.DeserializeConversationalAnalysisAuthoringExportedEntitySublist(item, options));
                    }
                    sublists = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConversationalAnalysisAuthoringExportedEntityList(sublists ?? new ChangeTrackingList<ConversationalAnalysisAuthoringExportedEntitySublist>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConversationalAnalysisAuthoringExportedEntityList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringExportedEntityList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringExportedEntityList)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationalAnalysisAuthoringExportedEntityList IPersistableModel<ConversationalAnalysisAuthoringExportedEntityList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationalAnalysisAuthoringExportedEntityList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConversationalAnalysisAuthoringExportedEntityList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationalAnalysisAuthoringExportedEntityList)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationalAnalysisAuthoringExportedEntityList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ConversationalAnalysisAuthoringExportedEntityList FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConversationalAnalysisAuthoringExportedEntityList(document.RootElement);
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
