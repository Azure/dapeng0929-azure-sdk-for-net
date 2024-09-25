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
    public partial class AvsClusterFailedEventData : IUtf8JsonSerializable, IJsonModel<AvsClusterFailedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsClusterFailedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AvsClusterFailedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsClusterFailedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsClusterFailedEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FailureMessage))
            {
                writer.WritePropertyName("failureMessage"u8);
                writer.WriteStringValue(FailureMessage);
            }
            writer.WritePropertyName("operationId"u8);
            writer.WriteStringValue(OperationId);
            if (Optional.IsCollectionDefined(AddedHostNames))
            {
                writer.WritePropertyName("addedHostNames"u8);
                writer.WriteStartArray();
                foreach (var item in AddedHostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RemovedHostNames))
            {
                writer.WritePropertyName("removedHostNames"u8);
                writer.WriteStartArray();
                foreach (var item in RemovedHostNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(InMaintenanceHostNames))
            {
                writer.WritePropertyName("inMaintenanceHostNames"u8);
                writer.WriteStartArray();
                foreach (var item in InMaintenanceHostNames)
                {
                    writer.WriteStringValue(item);
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

        AvsClusterFailedEventData IJsonModel<AvsClusterFailedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsClusterFailedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsClusterFailedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsClusterFailedEventData(document.RootElement, options);
        }

        internal static AvsClusterFailedEventData DeserializeAvsClusterFailedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string failureMessage = default;
            string operationId = default;
            IReadOnlyList<string> addedHostNames = default;
            IReadOnlyList<string> removedHostNames = default;
            IReadOnlyList<string> inMaintenanceHostNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failureMessage"u8))
                {
                    failureMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addedHostNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addedHostNames = array;
                    continue;
                }
                if (property.NameEquals("removedHostNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    removedHostNames = array;
                    continue;
                }
                if (property.NameEquals("inMaintenanceHostNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    inMaintenanceHostNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AvsClusterFailedEventData(
                operationId,
                addedHostNames ?? new ChangeTrackingList<string>(),
                removedHostNames ?? new ChangeTrackingList<string>(),
                inMaintenanceHostNames ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData,
                failureMessage);
        }

        BinaryData IPersistableModel<AvsClusterFailedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsClusterFailedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvsClusterFailedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        AvsClusterFailedEventData IPersistableModel<AvsClusterFailedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsClusterFailedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvsClusterFailedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsClusterFailedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsClusterFailedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AvsClusterFailedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAvsClusterFailedEventData(document.RootElement);
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
