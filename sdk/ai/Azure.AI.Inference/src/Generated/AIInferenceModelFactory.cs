// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Inference
{
    /// <summary> Model factory for models. </summary>
    public static partial class AIInferenceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Inference.ChatRequestSystemMessage"/>. </summary>
        /// <param name="content"></param>
        /// <returns> A new <see cref="Inference.ChatRequestSystemMessage"/> instance for mocking. </returns>
        public static ChatRequestSystemMessage ChatRequestSystemMessage(string content = null)
        {
            return new ChatRequestSystemMessage(ChatRole.System, serializedAdditionalRawData: null, content);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.ChatMessageTextContentItem"/>. </summary>
        /// <param name="text"></param>
        /// <returns> A new <see cref="Inference.ChatMessageTextContentItem"/> instance for mocking. </returns>
        public static ChatMessageTextContentItem ChatMessageTextContentItem(string text = null)
        {
            return new ChatMessageTextContentItem("text", serializedAdditionalRawData: null, text);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.ChatRequestToolMessage"/>. </summary>
        /// <param name="content"></param>
        /// <param name="toolCallId"></param>
        /// <returns> A new <see cref="Inference.ChatRequestToolMessage"/> instance for mocking. </returns>
        public static ChatRequestToolMessage ChatRequestToolMessage(string content = null, string toolCallId = null)
        {
            return new ChatRequestToolMessage(ChatRole.Tool, serializedAdditionalRawData: null, content, toolCallId);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.ChatCompletionsFunctionToolDefinition"/>. </summary>
        /// <param name="function"></param>
        /// <returns> A new <see cref="Inference.ChatCompletionsFunctionToolDefinition"/> instance for mocking. </returns>
        public static ChatCompletionsFunctionToolDefinition ChatCompletionsFunctionToolDefinition(FunctionDefinition function = null)
        {
            return new ChatCompletionsFunctionToolDefinition("function", serializedAdditionalRawData: null, function);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.ChatCompletionsNamedFunctionToolSelection"/>. </summary>
        /// <param name="function"></param>
        /// <returns> A new <see cref="Inference.ChatCompletionsNamedFunctionToolSelection"/> instance for mocking. </returns>
        public static ChatCompletionsNamedFunctionToolSelection ChatCompletionsNamedFunctionToolSelection(ChatCompletionsFunctionToolSelection function = null)
        {
            return new ChatCompletionsNamedFunctionToolSelection("function", serializedAdditionalRawData: null, function);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.ChatCompletions"/>. </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="usage"></param>
        /// <param name="choices"></param>
        /// <returns> A new <see cref="Inference.ChatCompletions"/> instance for mocking. </returns>
        public static ChatCompletions ChatCompletions(string id = null, DateTimeOffset created = default, string model = null, CompletionsUsage usage = null, IEnumerable<ChatChoice> choices = null)
        {
            choices ??= new List<ChatChoice>();

            return new ChatCompletions(
                id,
                created,
                model,
                usage,
                choices?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.CompletionsUsage"/>. </summary>
        /// <param name="completionTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="totalTokens"></param>
        /// <returns> A new <see cref="Inference.CompletionsUsage"/> instance for mocking. </returns>
        public static CompletionsUsage CompletionsUsage(int completionTokens = default, int promptTokens = default, int totalTokens = default)
        {
            return new CompletionsUsage(completionTokens, promptTokens, totalTokens, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.ChatChoice"/>. </summary>
        /// <param name="index"></param>
        /// <param name="finishReason"></param>
        /// <param name="message"></param>
        /// <returns> A new <see cref="Inference.ChatChoice"/> instance for mocking. </returns>
        public static ChatChoice ChatChoice(int index = default, CompletionsFinishReason? finishReason = null, ChatResponseMessage message = null)
        {
            return new ChatChoice(index, finishReason, message, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.ChatResponseMessage"/>. </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="toolCalls">
        /// Please note <see cref="ChatCompletionsToolCall"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChatCompletionsFunctionToolCall"/>.
        /// </param>
        /// <returns> A new <see cref="Inference.ChatResponseMessage"/> instance for mocking. </returns>
        public static ChatResponseMessage ChatResponseMessage(ChatRole role = default, string content = null, IEnumerable<ChatCompletionsToolCall> toolCalls = null)
        {
            toolCalls ??= new List<ChatCompletionsToolCall>();

            return new ChatResponseMessage(role, content, toolCalls?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.ModelInfo"/>. </summary>
        /// <param name="modelName"></param>
        /// <param name="modelType"></param>
        /// <param name="modelProviderName"></param>
        /// <returns> A new <see cref="Inference.ModelInfo"/> instance for mocking. </returns>
        public static ModelInfo ModelInfo(string modelName = null, ModelType modelType = default, string modelProviderName = null)
        {
            return new ModelInfo(modelName, modelType, modelProviderName, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.StreamingChatCompletionsUpdate"/>. </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="model"></param>
        /// <param name="usage"></param>
        /// <param name="choices"></param>
        /// <returns> A new <see cref="Inference.StreamingChatCompletionsUpdate"/> instance for mocking. </returns>
        public static StreamingChatCompletionsUpdate StreamingChatCompletionsUpdate(string id = null, DateTimeOffset created = default, string model = null, CompletionsUsage usage = null, IEnumerable<StreamingChatChoiceUpdate> choices = null)
        {
            choices ??= new List<StreamingChatChoiceUpdate>();

            return new StreamingChatCompletionsUpdate(
                id,
                created,
                model,
                usage,
                choices?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Inference.StreamingChatChoiceUpdate"/>. </summary>
        /// <param name="index"></param>
        /// <param name="finishReason"></param>
        /// <param name="delta"></param>
        /// <returns> A new <see cref="Inference.StreamingChatChoiceUpdate"/> instance for mocking. </returns>
        public static StreamingChatChoiceUpdate StreamingChatChoiceUpdate(int index = default, CompletionsFinishReason? finishReason = null, ChatResponseMessage delta = null)
        {
            return new StreamingChatChoiceUpdate(index, finishReason, delta, serializedAdditionalRawData: null);
        }
    }
}
