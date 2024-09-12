// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IoTOperations.Models
{
    public partial class BrokerAuthenticatorMethodCustom : IUtf8JsonSerializable, IJsonModel<BrokerAuthenticatorMethodCustom>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BrokerAuthenticatorMethodCustom>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BrokerAuthenticatorMethodCustom>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthenticatorMethodCustom>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerAuthenticatorMethodCustom)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Auth))
            {
                writer.WritePropertyName("auth"u8);
                writer.WriteObjectValue(Auth, options);
            }
            if (Optional.IsDefined(CaCertConfigMap))
            {
                writer.WritePropertyName("caCertConfigMap"u8);
                writer.WriteStringValue(CaCertConfigMap);
            }
            writer.WritePropertyName("endpoint"u8);
            writer.WriteStringValue(Endpoint.AbsoluteUri);
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartObject();
                foreach (var item in Headers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        BrokerAuthenticatorMethodCustom IJsonModel<BrokerAuthenticatorMethodCustom>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthenticatorMethodCustom>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BrokerAuthenticatorMethodCustom)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBrokerAuthenticatorMethodCustom(document.RootElement, options);
        }

        internal static BrokerAuthenticatorMethodCustom DeserializeBrokerAuthenticatorMethodCustom(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BrokerAuthenticatorCustomAuth auth = default;
            string caCertConfigMap = default;
            Uri endpoint = default;
            IDictionary<string, string> headers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("auth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    auth = BrokerAuthenticatorCustomAuth.DeserializeBrokerAuthenticatorCustomAuth(property.Value, options);
                    continue;
                }
                if (property.NameEquals("caCertConfigMap"u8))
                {
                    caCertConfigMap = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    headers = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BrokerAuthenticatorMethodCustom(auth, caCertConfigMap, endpoint, headers ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BrokerAuthenticatorMethodCustom>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthenticatorMethodCustom>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BrokerAuthenticatorMethodCustom)} does not support writing '{options.Format}' format.");
            }
        }

        BrokerAuthenticatorMethodCustom IPersistableModel<BrokerAuthenticatorMethodCustom>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BrokerAuthenticatorMethodCustom>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBrokerAuthenticatorMethodCustom(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BrokerAuthenticatorMethodCustom)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BrokerAuthenticatorMethodCustom>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
