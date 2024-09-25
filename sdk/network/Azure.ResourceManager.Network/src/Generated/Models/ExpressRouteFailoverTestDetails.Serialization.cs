// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteFailoverTestDetails : IUtf8JsonSerializable, IJsonModel<ExpressRouteFailoverTestDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteFailoverTestDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRouteFailoverTestDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteFailoverTestDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteFailoverTestDetails)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PeeringLocation))
            {
                writer.WritePropertyName("peeringLocation"u8);
                writer.WriteStringValue(PeeringLocation);
            }
            if (Optional.IsCollectionDefined(Circuits))
            {
                writer.WritePropertyName("circuits"u8);
                writer.WriteStartArray();
                foreach (var item in Circuits)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(Connections))
            {
                writer.WritePropertyName("connections"u8);
                writer.WriteStartArray();
                foreach (var item in Connections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TestGuid))
            {
                writer.WritePropertyName("testGuid"u8);
                writer.WriteStringValue(TestGuid.Value);
            }
            if (Optional.IsDefined(TestType))
            {
                writer.WritePropertyName("testType"u8);
                writer.WriteStringValue(TestType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Issues))
            {
                writer.WritePropertyName("issues"u8);
                writer.WriteStartArray();
                foreach (var item in Issues)
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

        ExpressRouteFailoverTestDetails IJsonModel<ExpressRouteFailoverTestDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteFailoverTestDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteFailoverTestDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteFailoverTestDetails(document.RootElement, options);
        }

        internal static ExpressRouteFailoverTestDetails DeserializeExpressRouteFailoverTestDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string peeringLocation = default;
            IReadOnlyList<ExpressRouteFailoverCircuitResourceDetails> circuits = default;
            FailoverTestStatus? status = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            IReadOnlyList<ExpressRouteFailoverConnectionResourceDetails> connections = default;
            Guid? testGuid = default;
            FailoverTestType? testType = default;
            IReadOnlyList<string> issues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("peeringLocation"u8))
                {
                    peeringLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("circuits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExpressRouteFailoverCircuitResourceDetails> array = new List<ExpressRouteFailoverCircuitResourceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRouteFailoverCircuitResourceDetails.DeserializeExpressRouteFailoverCircuitResourceDetails(item, options));
                    }
                    circuits = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new FailoverTestStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("connections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExpressRouteFailoverConnectionResourceDetails> array = new List<ExpressRouteFailoverConnectionResourceDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRouteFailoverConnectionResourceDetails.DeserializeExpressRouteFailoverConnectionResourceDetails(item, options));
                    }
                    connections = array;
                    continue;
                }
                if (property.NameEquals("testGuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testGuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("testType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testType = new FailoverTestType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("issues"u8))
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
                    issues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExpressRouteFailoverTestDetails(
                peeringLocation,
                circuits ?? new ChangeTrackingList<ExpressRouteFailoverCircuitResourceDetails>(),
                status,
                startTime,
                endTime,
                connections ?? new ChangeTrackingList<ExpressRouteFailoverConnectionResourceDetails>(),
                testGuid,
                testType,
                issues ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteFailoverTestDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteFailoverTestDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteFailoverTestDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRouteFailoverTestDetails IPersistableModel<ExpressRouteFailoverTestDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteFailoverTestDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpressRouteFailoverTestDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteFailoverTestDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteFailoverTestDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
