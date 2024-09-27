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
    public partial class AvsScriptExecutionFailedEventData : IUtf8JsonSerializable, IJsonModel<AvsScriptExecutionFailedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsScriptExecutionFailedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvsScriptExecutionFailedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsScriptExecutionFailedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsScriptExecutionFailedEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FailureMessage))
            {
                writer.WritePropertyName("failureMessage"u8);
                writer.WriteStringValue(FailureMessage);
            }
            writer.WritePropertyName("operationId"u8);
            writer.WriteStringValue(OperationId);
            writer.WritePropertyName("cmdletId"u8);
            writer.WriteStringValue(CmdletId);
            if (Optional.IsCollectionDefined(Output))
            {
                writer.WritePropertyName("output"u8);
                writer.WriteStartArray();
                foreach (var item in Output)
                {
                    writer.WriteStringValue(item);
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

        AvsScriptExecutionFailedEventData IJsonModel<AvsScriptExecutionFailedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsScriptExecutionFailedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsScriptExecutionFailedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsScriptExecutionFailedEventData(document.RootElement, options);
        }

        internal static AvsScriptExecutionFailedEventData DeserializeAvsScriptExecutionFailedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string failureMessage = default;
            string operationId = default;
            string cmdletId = default;
            IReadOnlyList<string> output = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failureMessage"u8))
                {
                    failureMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cmdletId"u8))
                {
                    cmdletId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    output = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvsScriptExecutionFailedEventData(operationId, cmdletId, output ?? new ChangeTrackingList<string>(), serializedAdditionalRawData, failureMessage);
        }

        BinaryData IPersistableModel<AvsScriptExecutionFailedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsScriptExecutionFailedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvsScriptExecutionFailedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        AvsScriptExecutionFailedEventData IPersistableModel<AvsScriptExecutionFailedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsScriptExecutionFailedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvsScriptExecutionFailedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsScriptExecutionFailedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsScriptExecutionFailedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AvsScriptExecutionFailedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAvsScriptExecutionFailedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
