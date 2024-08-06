// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> A request chat message representing response or action from the assistant. </summary>
    public partial class ChatRequestAssistantMessage : ChatRequestMessage
    {
        /// <summary> Initializes a new instance of <see cref="ChatRequestAssistantMessage"/>. </summary>
        /// <param name="content"> The content of the message. </param>
        public ChatRequestAssistantMessage(string content)
        {
            Role = ChatRole.Assistant;
            Content = content;
            ToolCalls = new ChangeTrackingList<ChatCompletionsToolCall>();
        }

        /// <summary> Initializes a new instance of <see cref="ChatRequestAssistantMessage"/>. </summary>
        /// <param name="role"> The chat role associated with this message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="content"> The content of the message. </param>
        /// <param name="name"> An optional name for the participant. </param>
        /// <param name="toolCalls">
        /// The tool calls that must be resolved and have their outputs appended to subsequent input messages for the chat
        /// completions request to resolve as configured.
        /// Please note <see cref="ChatCompletionsToolCall"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChatCompletionsFunctionToolCall"/>.
        /// </param>
        /// <param name="functionCall">
        /// The function call that must be resolved and have its output appended to subsequent input messages for the chat
        /// completions request to resolve as configured.
        /// </param>
        internal ChatRequestAssistantMessage(ChatRole role, IDictionary<string, BinaryData> serializedAdditionalRawData, string content, string name, IList<ChatCompletionsToolCall> toolCalls, FunctionCall functionCall) : base(role, serializedAdditionalRawData)
        {
            Content = content;
            Name = name;
            ToolCalls = toolCalls;
            FunctionCall = functionCall;
        }

        /// <summary> Initializes a new instance of <see cref="ChatRequestAssistantMessage"/> for deserialization. </summary>
        internal ChatRequestAssistantMessage()
        {
        }

        /// <summary> The content of the message. </summary>
        public string Content { get; }
        /// <summary> An optional name for the participant. </summary>
        public string Name { get; set; }
        /// <summary>
        /// The tool calls that must be resolved and have their outputs appended to subsequent input messages for the chat
        /// completions request to resolve as configured.
        /// Please note <see cref="ChatCompletionsToolCall"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ChatCompletionsFunctionToolCall"/>.
        /// </summary>
        public IList<ChatCompletionsToolCall> ToolCalls { get; }
        /// <summary>
        /// The function call that must be resolved and have its output appended to subsequent input messages for the chat
        /// completions request to resolve as configured.
        /// </summary>
        public FunctionCall FunctionCall { get; set; }
    }
}
