// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace LiveMetrics
{
    public partial class DocumentFilterConjunctionGroupInfo : IUtf8JsonSerializable, IJsonModel<DocumentFilterConjunctionGroupInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentFilterConjunctionGroupInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DocumentFilterConjunctionGroupInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentFilterConjunctionGroupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentFilterConjunctionGroupInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("TelemetryType"u8);
            writer.WriteStringValue(TelemetryType.ToString());
            writer.WritePropertyName("Filters"u8);
            writer.WriteObjectValue(Filters, options);
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

        DocumentFilterConjunctionGroupInfo IJsonModel<DocumentFilterConjunctionGroupInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentFilterConjunctionGroupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentFilterConjunctionGroupInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentFilterConjunctionGroupInfo(document.RootElement, options);
        }

        internal static DocumentFilterConjunctionGroupInfo DeserializeDocumentFilterConjunctionGroupInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TelemetryType telemetryType = default;
            FilterConjunctionGroupInfo filters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("TelemetryType"u8))
                {
                    telemetryType = new TelemetryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("Filters"u8))
                {
                    filters = FilterConjunctionGroupInfo.DeserializeFilterConjunctionGroupInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DocumentFilterConjunctionGroupInfo(telemetryType, filters, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentFilterConjunctionGroupInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentFilterConjunctionGroupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentFilterConjunctionGroupInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentFilterConjunctionGroupInfo IPersistableModel<DocumentFilterConjunctionGroupInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentFilterConjunctionGroupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentFilterConjunctionGroupInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentFilterConjunctionGroupInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentFilterConjunctionGroupInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentFilterConjunctionGroupInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentFilterConjunctionGroupInfo(document.RootElement);
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
