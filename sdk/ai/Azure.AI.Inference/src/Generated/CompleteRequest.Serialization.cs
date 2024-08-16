// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Inference
{
    internal partial class CompleteRequest : IUtf8JsonSerializable, IJsonModel<CompleteRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CompleteRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CompleteRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CompleteRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CompleteRequest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("messages"u8);
            writer.WriteStartArray();
            foreach (var item in Messages)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(FrequencyPenalty))
            {
                writer.WritePropertyName("frequency_penalty"u8);
                writer.WriteNumberValue(FrequencyPenalty.Value);
            }
            if (Optional.IsDefined(InternalShouldStreamResponse))
            {
                writer.WritePropertyName("stream"u8);
                writer.WriteBooleanValue(InternalShouldStreamResponse.Value);
            }
            if (Optional.IsDefined(PresencePenalty))
            {
                writer.WritePropertyName("presence_penalty"u8);
                writer.WriteNumberValue(PresencePenalty.Value);
            }
            if (Optional.IsDefined(Temperature))
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            if (Optional.IsDefined(NucleusSamplingFactor))
            {
                writer.WritePropertyName("top_p"u8);
                writer.WriteNumberValue(NucleusSamplingFactor.Value);
            }
            if (Optional.IsDefined(MaxTokens))
            {
                writer.WritePropertyName("max_tokens"u8);
                writer.WriteNumberValue(MaxTokens.Value);
            }
            if (Optional.IsDefined(ResponseFormat))
            {
                writer.WritePropertyName("response_format"u8);
                writer.WriteObjectValue(ResponseFormat, options);
            }
            if (Optional.IsCollectionDefined(StopSequences))
            {
                writer.WritePropertyName("stop"u8);
                writer.WriteStartArray();
                foreach (var item in StopSequences)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tools))
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (var item in Tools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ToolChoice))
            {
                writer.WritePropertyName("tool_choice"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ToolChoice);
#else
                using (JsonDocument document = JsonDocument.Parse(ToolChoice))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Seed))
            {
                writer.WritePropertyName("seed"u8);
                writer.WriteNumberValue(Seed.Value);
            }
            if (Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        CompleteRequest IJsonModel<CompleteRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CompleteRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CompleteRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCompleteRequest(document.RootElement, options);
        }

        internal static CompleteRequest DeserializeCompleteRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ChatRequestMessage> messages = default;
            float? frequencyPenalty = default;
            bool? stream = default;
            float? presencePenalty = default;
            float? temperature = default;
            float? topP = default;
            int? maxTokens = default;
            ChatCompletionsResponseFormat responseFormat = default;
            IReadOnlyList<string> stop = default;
            IReadOnlyList<ChatCompletionsToolDefinition> tools = default;
            BinaryData toolChoice = default;
            long? seed = default;
            string model = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messages"u8))
                {
                    List<ChatRequestMessage> array = new List<ChatRequestMessage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatRequestMessage.DeserializeChatRequestMessage(item, options));
                    }
                    messages = array;
                    continue;
                }
                if (property.NameEquals("frequency_penalty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequencyPenalty = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("stream"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stream = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("presence_penalty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    presencePenalty = property.Value.GetSingle();
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
                if (property.NameEquals("top_p"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topP = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("max_tokens"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxTokens = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("response_format"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseFormat = ChatCompletionsResponseFormat.DeserializeChatCompletionsResponseFormat(property.Value, options);
                    continue;
                }
                if (property.NameEquals("stop"u8))
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
                    stop = array;
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChatCompletionsToolDefinition> array = new List<ChatCompletionsToolDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatCompletionsToolDefinition.DeserializeChatCompletionsToolDefinition(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (property.NameEquals("tool_choice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    toolChoice = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("seed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    seed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CompleteRequest(
                messages,
                frequencyPenalty,
                stream,
                presencePenalty,
                temperature,
                topP,
                maxTokens,
                responseFormat,
                stop ?? new ChangeTrackingList<string>(),
                tools ?? new ChangeTrackingList<ChatCompletionsToolDefinition>(),
                toolChoice,
                seed,
                model,
                additionalProperties);
        }

        BinaryData IPersistableModel<CompleteRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CompleteRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CompleteRequest)} does not support writing '{options.Format}' format.");
            }
        }

        CompleteRequest IPersistableModel<CompleteRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CompleteRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCompleteRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CompleteRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CompleteRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static CompleteRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCompleteRequest(document.RootElement);
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
