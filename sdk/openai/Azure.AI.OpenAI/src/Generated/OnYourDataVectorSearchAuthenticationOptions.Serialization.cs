// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    [PersistableModelProxy(typeof(UnknownOnYourDataVectorSearchAuthenticationOptions))]
    public partial class OnYourDataVectorSearchAuthenticationOptions : IUtf8JsonSerializable, IJsonModel<OnYourDataVectorSearchAuthenticationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OnYourDataVectorSearchAuthenticationOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OnYourDataVectorSearchAuthenticationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataVectorSearchAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnYourDataVectorSearchAuthenticationOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
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

        OnYourDataVectorSearchAuthenticationOptions IJsonModel<OnYourDataVectorSearchAuthenticationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataVectorSearchAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnYourDataVectorSearchAuthenticationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOnYourDataVectorSearchAuthenticationOptions(document.RootElement, options);
        }

        internal static OnYourDataVectorSearchAuthenticationOptions DeserializeOnYourDataVectorSearchAuthenticationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "access_token": return OnYourDataVectorSearchAccessTokenAuthenticationOptions.DeserializeOnYourDataVectorSearchAccessTokenAuthenticationOptions(element, options);
                    case "api_key": return OnYourDataVectorSearchApiKeyAuthenticationOptions.DeserializeOnYourDataVectorSearchApiKeyAuthenticationOptions(element, options);
                }
            }
            return UnknownOnYourDataVectorSearchAuthenticationOptions.DeserializeUnknownOnYourDataVectorSearchAuthenticationOptions(element, options);
        }

        BinaryData IPersistableModel<OnYourDataVectorSearchAuthenticationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataVectorSearchAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OnYourDataVectorSearchAuthenticationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        OnYourDataVectorSearchAuthenticationOptions IPersistableModel<OnYourDataVectorSearchAuthenticationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataVectorSearchAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOnYourDataVectorSearchAuthenticationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OnYourDataVectorSearchAuthenticationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OnYourDataVectorSearchAuthenticationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OnYourDataVectorSearchAuthenticationOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOnYourDataVectorSearchAuthenticationOptions(document.RootElement);
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
