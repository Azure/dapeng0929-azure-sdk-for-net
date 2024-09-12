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
    internal partial class X509ManualCertificate : IUtf8JsonSerializable, IJsonModel<X509ManualCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X509ManualCertificate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<X509ManualCertificate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X509ManualCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X509ManualCertificate)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("secretRef"u8);
            writer.WriteStringValue(SecretRef);
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

        X509ManualCertificate IJsonModel<X509ManualCertificate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X509ManualCertificate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X509ManualCertificate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX509ManualCertificate(document.RootElement, options);
        }

        internal static X509ManualCertificate DeserializeX509ManualCertificate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string secretRef = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretRef"u8))
                {
                    secretRef = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new X509ManualCertificate(secretRef, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<X509ManualCertificate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X509ManualCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(X509ManualCertificate)} does not support writing '{options.Format}' format.");
            }
        }

        X509ManualCertificate IPersistableModel<X509ManualCertificate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X509ManualCertificate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeX509ManualCertificate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(X509ManualCertificate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<X509ManualCertificate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
