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
    public partial class ExecutionParameters : IUtf8JsonSerializable, IJsonModel<ExecutionParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExecutionParameters>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExecutionParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecutionParameters)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OptimizationPreference))
            {
                writer.WritePropertyName("optimizationPreference"u8);
                writer.WriteStringValue(OptimizationPreference.Value.ToString());
            }
            if (Optional.IsDefined(RetryPolicy))
            {
                writer.WritePropertyName("retryPolicy"u8);
                writer.WriteObjectValue(RetryPolicy, options);
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

        ExecutionParameters IJsonModel<ExecutionParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExecutionParameters)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExecutionParameters(document.RootElement, options);
        }

        internal static ExecutionParameters DeserializeExecutionParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptimizationPreference? optimizationPreference = default;
            RetryPolicy retryPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("optimizationPreference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optimizationPreference = new OptimizationPreference(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("retryPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryPolicy = RetryPolicy.DeserializeRetryPolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExecutionParameters(optimizationPreference, retryPolicy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExecutionParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExecutionParameters)} does not support writing '{options.Format}' format.");
            }
        }

        ExecutionParameters IPersistableModel<ExecutionParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExecutionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExecutionParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExecutionParameters)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExecutionParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
