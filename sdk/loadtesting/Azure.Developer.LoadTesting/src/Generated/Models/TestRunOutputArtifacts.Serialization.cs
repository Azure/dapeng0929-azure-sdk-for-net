// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class TestRunOutputArtifacts : IUtf8JsonSerializable, IJsonModel<TestRunOutputArtifacts>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TestRunOutputArtifacts>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TestRunOutputArtifacts>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestRunOutputArtifacts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestRunOutputArtifacts)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResultFileInfo))
            {
                writer.WritePropertyName("resultFileInfo"u8);
                writer.WriteObjectValue(ResultFileInfo, options);
            }
            if (Optional.IsDefined(LogsFileInfo))
            {
                writer.WritePropertyName("logsFileInfo"u8);
                writer.WriteObjectValue(LogsFileInfo, options);
            }
            if (Optional.IsDefined(ArtifactsContainerInfo))
            {
                writer.WritePropertyName("artifactsContainerInfo"u8);
                writer.WriteObjectValue(ArtifactsContainerInfo, options);
            }
            if (Optional.IsDefined(ReportFileInfo))
            {
                writer.WritePropertyName("reportFileInfo"u8);
                writer.WriteObjectValue(ReportFileInfo, options);
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

        TestRunOutputArtifacts IJsonModel<TestRunOutputArtifacts>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestRunOutputArtifacts>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestRunOutputArtifacts)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTestRunOutputArtifacts(document.RootElement, options);
        }

        internal static TestRunOutputArtifacts DeserializeTestRunOutputArtifacts(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TestRunFileInfo resultFileInfo = default;
            TestRunFileInfo logsFileInfo = default;
            ArtifactsContainerInfo artifactsContainerInfo = default;
            TestRunFileInfo reportFileInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resultFileInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultFileInfo = TestRunFileInfo.DeserializeTestRunFileInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logsFileInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logsFileInfo = TestRunFileInfo.DeserializeTestRunFileInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("artifactsContainerInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactsContainerInfo = ArtifactsContainerInfo.DeserializeArtifactsContainerInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reportFileInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportFileInfo = TestRunFileInfo.DeserializeTestRunFileInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TestRunOutputArtifacts(resultFileInfo, logsFileInfo, artifactsContainerInfo, reportFileInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TestRunOutputArtifacts>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestRunOutputArtifacts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TestRunOutputArtifacts)} does not support writing '{options.Format}' format.");
            }
        }

        TestRunOutputArtifacts IPersistableModel<TestRunOutputArtifacts>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestRunOutputArtifacts>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTestRunOutputArtifacts(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TestRunOutputArtifacts)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TestRunOutputArtifacts>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TestRunOutputArtifacts FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTestRunOutputArtifacts(document.RootElement);
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
