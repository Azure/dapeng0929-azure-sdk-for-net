// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeSchedule.Models
{
    public partial class ExecuteDeallocateContent : IUtf8JsonSerializable, IJsonModel<ExecuteDeallocateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExecuteDeallocateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExecuteDeallocateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteDeallocateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecuteDeallocateContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("executionParameters"u8);
            writer.WriteObjectValue(ExecutionParameters, options);
            writer.WritePropertyName("resources"u8);
            writer.WriteObjectValue(Resources, options);
            writer.WritePropertyName("correlationid"u8);
            writer.WriteStringValue(Correlationid);
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

        ExecuteDeallocateContent IJsonModel<ExecuteDeallocateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteDeallocateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecuteDeallocateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExecuteDeallocateContent(document.RootElement, options);
        }

        internal static ExecuteDeallocateContent DeserializeExecuteDeallocateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExecutionParameters executionParameters = default;
            Resources resources = default;
            string correlationid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("executionParameters"u8))
                {
                    executionParameters = ExecutionParameters.DeserializeExecutionParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    resources = Resources.DeserializeResources(property.Value, options);
                    continue;
                }
                if (property.NameEquals("correlationid"u8))
                {
                    correlationid = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExecuteDeallocateContent(executionParameters, resources, correlationid, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExecuteDeallocateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteDeallocateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExecuteDeallocateContent)} does not support writing '{options.Format}' format.");
            }
        }

        ExecuteDeallocateContent IPersistableModel<ExecuteDeallocateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecuteDeallocateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExecuteDeallocateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExecuteDeallocateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExecuteDeallocateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
