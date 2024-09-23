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

namespace Microsoft.VoiceServices.Provisioning
{
    public partial class TeamsOperatorConnectAccountDetails : IUtf8JsonSerializable, IJsonModel<TeamsOperatorConnectAccountDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TeamsOperatorConnectAccountDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TeamsOperatorConnectAccountDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TeamsOperatorConnectAccountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TeamsOperatorConnectAccountDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("syncEnabled"u8);
            writer.WriteBooleanValue(SyncEnabled);
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(Enabled);
            if (options.Format != "W" && Optional.IsDefined(NumberCount))
            {
                writer.WritePropertyName("numberCount"u8);
                writer.WriteNumberValue(NumberCount.Value);
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

        TeamsOperatorConnectAccountDetails IJsonModel<TeamsOperatorConnectAccountDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TeamsOperatorConnectAccountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TeamsOperatorConnectAccountDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTeamsOperatorConnectAccountDetails(document.RootElement, options);
        }

        internal static TeamsOperatorConnectAccountDetails DeserializeTeamsOperatorConnectAccountDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool syncEnabled = default;
            bool enabled = default;
            long? numberCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("syncEnabled"u8))
                {
                    syncEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("numberCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TeamsOperatorConnectAccountDetails(syncEnabled, enabled, numberCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TeamsOperatorConnectAccountDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TeamsOperatorConnectAccountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TeamsOperatorConnectAccountDetails)} does not support writing '{options.Format}' format.");
            }
        }

        TeamsOperatorConnectAccountDetails IPersistableModel<TeamsOperatorConnectAccountDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TeamsOperatorConnectAccountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTeamsOperatorConnectAccountDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TeamsOperatorConnectAccountDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TeamsOperatorConnectAccountDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TeamsOperatorConnectAccountDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTeamsOperatorConnectAccountDetails(document.RootElement);
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
