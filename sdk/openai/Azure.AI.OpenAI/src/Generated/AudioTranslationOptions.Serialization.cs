// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class AudioTranslationOptions : IUtf8JsonSerializable, IJsonModel<AudioTranslationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AudioTranslationOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AudioTranslationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("file"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(global::System.BinaryData.FromStream(AudioData));
#else
            using (JsonDocument document = JsonDocument.Parse(BinaryData.FromStream(AudioData)))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (Optional.IsDefined(Filename))
            {
                writer.WritePropertyName("filename"u8);
                writer.WriteStringValue(Filename);
            }
            if (Optional.IsDefined(ResponseFormat))
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteStringValue(ResponseFormat.Value.ToString());
            }
            if (Optional.IsDefined(Prompt))
            {
                writer.WritePropertyName("prompt"u8);
                writer.WriteStringValue(Prompt);
            }
            if (Optional.IsDefined(Temperature))
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            if (Optional.IsDefined(DeploymentName))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(DeploymentName);
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

        AudioTranslationOptions IJsonModel<AudioTranslationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioTranslationOptions(document.RootElement, options);
        }

        internal static AudioTranslationOptions DeserializeAudioTranslationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Stream file = default;
            string filename = default;
            AudioTranslationFormat? responseFormat = default;
            string prompt = default;
            float? temperature = default;
            string model = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("file"u8))
                {
                    file = BinaryData.FromString(property.Value.GetRawText()).ToStream();
                    continue;
                }
                if (property.NameEquals("filename"u8))
                {
                    filename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("response_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseFormat = new AudioTranslationFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("prompt"u8))
                {
                    prompt = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("temperature"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    temperature = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AudioTranslationOptions(
                file,
                filename,
                responseFormat,
                prompt,
                temperature,
                model,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeMultipart(ModelReaderWriterOptions options)
        {
            using MultipartFormDataRequestContent content = ToMultipartRequestContent();
            using MemoryStream stream = new MemoryStream();
            content.WriteTo(stream);
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        internal virtual MultipartFormDataRequestContent ToMultipartRequestContent()
        {
            MultipartFormDataRequestContent content = new MultipartFormDataRequestContent();
            content.Add(AudioData, "file", "file", "application/octet-stream");
            if (Optional.IsDefined(Filename))
            {
                content.Add(Filename, "filename");
            }
            if (Optional.IsDefined(ResponseFormat))
            {
                content.Add(ResponseFormat.Value.ToString(), "response_format");
            }
            if (Optional.IsDefined(Prompt))
            {
                content.Add(Prompt, "prompt");
            }
            if (Optional.IsDefined(Temperature))
            {
                content.Add(Temperature.Value, "temperature");
            }
            if (Optional.IsDefined(DeploymentName))
            {
                content.Add(DeploymentName, "model");
            }
            return content;
        }

        BinaryData IPersistableModel<AudioTranslationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "MFD":
                    return SerializeMultipart(options);
                default:
                    throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support writing '{options.Format}' format.");
            }
        }

        AudioTranslationOptions IPersistableModel<AudioTranslationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AudioTranslationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAudioTranslationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AudioTranslationOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AudioTranslationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "MFD";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AudioTranslationOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAudioTranslationOptions(document.RootElement);
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
