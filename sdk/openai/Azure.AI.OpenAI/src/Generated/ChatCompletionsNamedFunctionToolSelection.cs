// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> A tool selection of a specific, named function tool that will limit chat completions to using the named function. </summary>
    public partial class ChatCompletionsNamedFunctionToolSelection : ChatCompletionsNamedToolSelection
    {
        /// <summary> Initializes a new instance of <see cref="ChatCompletionsNamedFunctionToolSelection"/>. </summary>
        /// <param name="function"> The function that should be called. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="function"/> is null. </exception>
        public ChatCompletionsNamedFunctionToolSelection(ChatCompletionsFunctionToolSelection function)
        {
            Argument.AssertNotNull(function, nameof(function));

            Type = "function";
            Function = function;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsNamedFunctionToolSelection"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="function"> The function that should be called. </param>
        internal ChatCompletionsNamedFunctionToolSelection(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, ChatCompletionsFunctionToolSelection function) : base(type, serializedAdditionalRawData)
        {
            Function = function;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsNamedFunctionToolSelection"/> for deserialization. </summary>
        internal ChatCompletionsNamedFunctionToolSelection()
        {
        }

        /// <summary> The function that should be called. </summary>
        public ChatCompletionsFunctionToolSelection Function { get; }
    }
}
