// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class SecurityProfile : IUtf8JsonSerializable, IJsonModel<SecurityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("encryptionAtHost"u8);
            writer.WriteBooleanValue(EncryptionAtHost);
            writer.WritePropertyName("securityType"u8);
            writer.WriteStringValue(SecurityType.ToString());
            writer.WritePropertyName("uefiSettings"u8);
            writer.WriteObjectValue(UefiSettings, options);
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

        SecurityProfile IJsonModel<SecurityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityProfile(document.RootElement, options);
        }

        internal static SecurityProfile DeserializeSecurityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool encryptionAtHost = default;
            SecurityTypes securityType = default;
            UefiSettings uefiSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("encryptionAtHost"u8))
                {
                    encryptionAtHost = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("securityType"u8))
                {
                    securityType = new SecurityTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uefiSettings"u8))
                {
                    uefiSettings = UefiSettings.DeserializeUefiSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityProfile(encryptionAtHost, securityType, uefiSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityProfile)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityProfile IPersistableModel<SecurityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SecurityProfile FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSecurityProfile(document.RootElement);
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
