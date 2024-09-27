// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class OptionalLoadTestConfig : IUtf8JsonSerializable, IJsonModel<OptionalLoadTestConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OptionalLoadTestConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OptionalLoadTestConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionalLoadTestConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OptionalLoadTestConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EndpointUrl))
            {
                writer.WritePropertyName("endpointUrl"u8);
                writer.WriteStringValue(EndpointUrl);
            }
            if (Optional.IsDefined(RequestsPerSecond))
            {
                writer.WritePropertyName("requestsPerSecond"u8);
                writer.WriteNumberValue(RequestsPerSecond.Value);
            }
            if (Optional.IsDefined(MaxResponseTimeInMs))
            {
                writer.WritePropertyName("maxResponseTimeInMs"u8);
                writer.WriteNumberValue(MaxResponseTimeInMs.Value);
            }
            if (Optional.IsDefined(VirtualUsers))
            {
                writer.WritePropertyName("virtualUsers"u8);
                writer.WriteNumberValue(VirtualUsers.Value);
            }
            if (Optional.IsDefined(RampUpTime))
            {
                writer.WritePropertyName("rampUpTime"u8);
                writer.WriteNumberValue(RampUpTime.Value);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteNumberValue(Duration.Value);
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

        OptionalLoadTestConfig IJsonModel<OptionalLoadTestConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionalLoadTestConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OptionalLoadTestConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOptionalLoadTestConfig(document.RootElement, options);
        }

        internal static OptionalLoadTestConfig DeserializeOptionalLoadTestConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string endpointUrl = default;
            int? requestsPerSecond = default;
            int? maxResponseTimeInMs = default;
            int? virtualUsers = default;
            int? rampUpTime = default;
            int? duration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointUrl"u8))
                {
                    endpointUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestsPerSecond"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestsPerSecond = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxResponseTimeInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxResponseTimeInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("virtualUsers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualUsers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampUpTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampUpTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OptionalLoadTestConfig(
                endpointUrl,
                requestsPerSecond,
                maxResponseTimeInMs,
                virtualUsers,
                rampUpTime,
                duration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OptionalLoadTestConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionalLoadTestConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OptionalLoadTestConfig)} does not support writing '{options.Format}' format.");
            }
        }

        OptionalLoadTestConfig IPersistableModel<OptionalLoadTestConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OptionalLoadTestConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOptionalLoadTestConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OptionalLoadTestConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OptionalLoadTestConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OptionalLoadTestConfig FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOptionalLoadTestConfig(document.RootElement);
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
