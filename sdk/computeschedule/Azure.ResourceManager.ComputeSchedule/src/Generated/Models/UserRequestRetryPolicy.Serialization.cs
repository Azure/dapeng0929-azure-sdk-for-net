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
    public partial class UserRequestRetryPolicy : IUtf8JsonSerializable, IJsonModel<UserRequestRetryPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserRequestRetryPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UserRequestRetryPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserRequestRetryPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserRequestRetryPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RetryCount))
            {
                writer.WritePropertyName("retryCount"u8);
                writer.WriteNumberValue(RetryCount.Value);
            }
            if (Optional.IsDefined(RetryWindowInMinutes))
            {
                writer.WritePropertyName("retryWindowInMinutes"u8);
                writer.WriteNumberValue(RetryWindowInMinutes.Value);
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

        UserRequestRetryPolicy IJsonModel<UserRequestRetryPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserRequestRetryPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserRequestRetryPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserRequestRetryPolicy(document.RootElement, options);
        }

        internal static UserRequestRetryPolicy DeserializeUserRequestRetryPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? retryCount = default;
            int? retryWindowInMinutes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("retryWindowInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryWindowInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UserRequestRetryPolicy(retryCount, retryWindowInMinutes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UserRequestRetryPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserRequestRetryPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserRequestRetryPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        UserRequestRetryPolicy IPersistableModel<UserRequestRetryPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserRequestRetryPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserRequestRetryPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserRequestRetryPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserRequestRetryPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
