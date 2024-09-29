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

namespace Microsoft.App.DynamicSessions
{
    public partial class SessionCodeExecutionResponse : IUtf8JsonSerializable, IJsonModel<SessionCodeExecutionResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SessionCodeExecutionResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SessionCodeExecutionResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionCodeExecutionResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionCodeExecutionResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("stdout"u8);
            writer.WriteStringValue(Stdout);
            writer.WritePropertyName("stderr"u8);
            writer.WriteStringValue(Stderr);
            writer.WritePropertyName("result"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Result);
#else
            using (JsonDocument document = JsonDocument.Parse(Result))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("executionTimeInMilliseconds"u8);
            writer.WriteNumberValue(ExecutionTimeInMilliseconds);
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

        SessionCodeExecutionResponse IJsonModel<SessionCodeExecutionResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionCodeExecutionResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionCodeExecutionResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSessionCodeExecutionResponse(document.RootElement, options);
        }

        internal static SessionCodeExecutionResponse DeserializeSessionCodeExecutionResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            CodeExecutionStatus status = default;
            string stdout = default;
            string stderr = default;
            BinaryData result = default;
            long executionTimeInMilliseconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new CodeExecutionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stdout"u8))
                {
                    stdout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stderr"u8))
                {
                    stderr = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    result = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("executionTimeInMilliseconds"u8))
                {
                    executionTimeInMilliseconds = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SessionCodeExecutionResponse(
                id,
                status,
                stdout,
                stderr,
                result,
                executionTimeInMilliseconds,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SessionCodeExecutionResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionCodeExecutionResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SessionCodeExecutionResponse)} does not support writing '{options.Format}' format.");
            }
        }

        SessionCodeExecutionResponse IPersistableModel<SessionCodeExecutionResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionCodeExecutionResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSessionCodeExecutionResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SessionCodeExecutionResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SessionCodeExecutionResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SessionCodeExecutionResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSessionCodeExecutionResponse(document.RootElement);
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
