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

namespace Microsoft.App
{
    public partial class CodeExecutionRequestProperties : IUtf8JsonSerializable, IJsonModel<CodeExecutionRequestProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CodeExecutionRequestProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CodeExecutionRequestProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodeExecutionRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodeExecutionRequestProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("codeInputType"u8);
            writer.WriteStringValue(CodeInputType.ToString());
            writer.WritePropertyName("executionType"u8);
            writer.WriteStringValue(ExecutionType.ToString());
            writer.WritePropertyName("code"u8);
            writer.WriteStringValue(Code);
            writer.WritePropertyName("timeoutInSeconds"u8);
            writer.WriteNumberValue(TimeoutInSeconds);
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

        CodeExecutionRequestProperties IJsonModel<CodeExecutionRequestProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodeExecutionRequestProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CodeExecutionRequestProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCodeExecutionRequestProperties(document.RootElement, options);
        }

        internal static CodeExecutionRequestProperties DeserializeCodeExecutionRequestProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CodeInputType codeInputType = default;
            ExecutionType executionType = default;
            string code = default;
            long timeoutInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeInputType"u8))
                {
                    codeInputType = new CodeInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("executionType"u8))
                {
                    executionType = new ExecutionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CodeExecutionRequestProperties(codeInputType, executionType, code, timeoutInSeconds, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CodeExecutionRequestProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodeExecutionRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CodeExecutionRequestProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CodeExecutionRequestProperties IPersistableModel<CodeExecutionRequestProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CodeExecutionRequestProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCodeExecutionRequestProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CodeExecutionRequestProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CodeExecutionRequestProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CodeExecutionRequestProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCodeExecutionRequestProperties(document.RootElement);
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
