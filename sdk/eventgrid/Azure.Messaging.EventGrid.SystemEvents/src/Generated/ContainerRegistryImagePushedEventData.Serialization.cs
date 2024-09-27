// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ContainerRegistryImagePushedEventData : IUtf8JsonSerializable, IJsonModel<ContainerRegistryImagePushedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryImagePushedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerRegistryImagePushedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryImagePushedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryImagePushedEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
            }
            writer.WritePropertyName("target"u8);
            writer.WriteObjectValue(Target, options);
            writer.WritePropertyName("request"u8);
            writer.WriteObjectValue(Request, options);
            writer.WritePropertyName("actor"u8);
            writer.WriteObjectValue(Actor, options);
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source, options);
            writer.WritePropertyName("connectedRegistry"u8);
            writer.WriteObjectValue(ConnectedRegistry, options);
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

        ContainerRegistryImagePushedEventData IJsonModel<ContainerRegistryImagePushedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryImagePushedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryImagePushedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryImagePushedEventData(document.RootElement, options);
        }

        internal static ContainerRegistryImagePushedEventData DeserializeContainerRegistryImagePushedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            DateTimeOffset? timestamp = default;
            string action = default;
            string location = default;
            ContainerRegistryEventTarget target = default;
            ContainerRegistryEventRequest request = default;
            ContainerRegistryEventActor actor = default;
            ContainerRegistryEventSource source = default;
            ContainerRegistryEventConnectedRegistry connectedRegistry = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = ContainerRegistryEventTarget.DeserializeContainerRegistryEventTarget(property.Value, options);
                    continue;
                }
                if (property.NameEquals("request"u8))
                {
                    request = ContainerRegistryEventRequest.DeserializeContainerRegistryEventRequest(property.Value, options);
                    continue;
                }
                if (property.NameEquals("actor"u8))
                {
                    actor = ContainerRegistryEventActor.DeserializeContainerRegistryEventActor(property.Value, options);
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = ContainerRegistryEventSource.DeserializeContainerRegistryEventSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("connectedRegistry"u8))
                {
                    connectedRegistry = ContainerRegistryEventConnectedRegistry.DeserializeContainerRegistryEventConnectedRegistry(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerRegistryImagePushedEventData(
                id,
                timestamp,
                action,
                location,
                target,
                request,
                actor,
                source,
                connectedRegistry,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryImagePushedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryImagePushedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryImagePushedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerRegistryImagePushedEventData IPersistableModel<ContainerRegistryImagePushedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryImagePushedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryImagePushedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryImagePushedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryImagePushedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ContainerRegistryImagePushedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeContainerRegistryImagePushedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
