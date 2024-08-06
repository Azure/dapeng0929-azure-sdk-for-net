// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class ChatChoice : IUtf8JsonSerializable, IJsonModel<ChatChoice>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChatChoice>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChatChoice>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatChoice)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteObjectValue(Message, options);
            }
            if (LogProbabilityInfo != null)
            {
                writer.WritePropertyName("logprobs"u8);
                writer.WriteObjectValue(LogProbabilityInfo, options);
            }
            else
            {
                writer.WriteNull("logprobs");
            }
            writer.WritePropertyName("index"u8);
            writer.WriteNumberValue(Index);
            if (FinishReason != null)
            {
                writer.WritePropertyName("finish_reason"u8);
                writer.WriteStringValue(FinishReason.Value.ToString());
            }
            else
            {
                writer.WriteNull("finish_reason");
            }
            if (Optional.IsDefined(FinishDetails))
            {
                writer.WritePropertyName("finish_details"u8);
                writer.WriteObjectValue(FinishDetails, options);
            }
            if (Optional.IsDefined(InternalStreamingDeltaMessage))
            {
                writer.WritePropertyName("delta"u8);
                writer.WriteObjectValue(InternalStreamingDeltaMessage, options);
            }
            if (Optional.IsDefined(ContentFilterResults))
            {
                writer.WritePropertyName("content_filter_results"u8);
                writer.WriteObjectValue(ContentFilterResults, options);
            }
            if (Optional.IsDefined(Enhancements))
            {
                writer.WritePropertyName("enhancements"u8);
                writer.WriteObjectValue(Enhancements, options);
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

        ChatChoice IJsonModel<ChatChoice>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatChoice)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatChoice(document.RootElement, options);
        }

        internal static ChatChoice DeserializeChatChoice(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ChatResponseMessage message = default;
            ChatChoiceLogProbabilityInfo logprobs = default;
            int index = default;
            CompletionsFinishReason? finishReason = default;
            ChatFinishDetails finishDetails = default;
            ChatResponseMessage delta = default;
            ContentFilterResultsForChoice contentFilterResults = default;
            AzureChatEnhancements enhancements = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = ChatResponseMessage.DeserializeChatResponseMessage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("logprobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        logprobs = null;
                        continue;
                    }
                    logprobs = ChatChoiceLogProbabilityInfo.DeserializeChatChoiceLogProbabilityInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("finish_reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        finishReason = null;
                        continue;
                    }
                    finishReason = new CompletionsFinishReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("finish_details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    finishDetails = ChatFinishDetails.DeserializeChatFinishDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("delta"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delta = ChatResponseMessage.DeserializeChatResponseMessage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("content_filter_results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentFilterResults = ContentFilterResultsForChoice.DeserializeContentFilterResultsForChoice(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enhancements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enhancements = AzureChatEnhancements.DeserializeAzureChatEnhancements(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChatChoice(
                message,
                logprobs,
                index,
                finishReason,
                finishDetails,
                delta,
                contentFilterResults,
                enhancements,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatChoice>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatChoice)} does not support writing '{options.Format}' format.");
            }
        }

        ChatChoice IPersistableModel<ChatChoice>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatChoice(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatChoice)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatChoice>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatChoice FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatChoice(document.RootElement);
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
