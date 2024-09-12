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
    public partial class AuthorizationRule : IUtf8JsonSerializable, IJsonModel<AuthorizationRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AuthorizationRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AuthorizationRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthorizationRule)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("brokerResources"u8);
            writer.WriteStartArray();
            foreach (var item in BrokerResources)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("principals"u8);
            writer.WriteObjectValue(Principals, options);
            if (Optional.IsCollectionDefined(StateStoreResources))
            {
                writer.WritePropertyName("stateStoreResources"u8);
                writer.WriteStartArray();
                foreach (var item in StateStoreResources)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        AuthorizationRule IJsonModel<AuthorizationRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AuthorizationRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAuthorizationRule(document.RootElement, options);
        }

        internal static AuthorizationRule DeserializeAuthorizationRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<BrokerResourceRule> brokerResources = default;
            PrincipalDefinition principals = default;
            IList<StateStoreResourceRule> stateStoreResources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("brokerResources"u8))
                {
                    List<BrokerResourceRule> array = new List<BrokerResourceRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BrokerResourceRule.DeserializeBrokerResourceRule(item, options));
                    }
                    brokerResources = array;
                    continue;
                }
                if (property.NameEquals("principals"u8))
                {
                    principals = PrincipalDefinition.DeserializePrincipalDefinition(property.Value, options);
                    continue;
                }
                if (property.NameEquals("stateStoreResources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StateStoreResourceRule> array = new List<StateStoreResourceRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StateStoreResourceRule.DeserializeStateStoreResourceRule(item, options));
                    }
                    stateStoreResources = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AuthorizationRule(brokerResources, principals, stateStoreResources ?? new ChangeTrackingList<StateStoreResourceRule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AuthorizationRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AuthorizationRule)} does not support writing '{options.Format}' format.");
            }
        }

        AuthorizationRule IPersistableModel<AuthorizationRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthorizationRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAuthorizationRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AuthorizationRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AuthorizationRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
