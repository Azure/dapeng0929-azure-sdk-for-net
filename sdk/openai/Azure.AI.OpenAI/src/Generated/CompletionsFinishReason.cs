// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> Representation of the manner in which a completions response concluded. </summary>
    public readonly partial struct CompletionsFinishReason : IEquatable<CompletionsFinishReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CompletionsFinishReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CompletionsFinishReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StoppedValue = "stop";
        private const string TokenLimitReachedValue = "length";
        private const string ContentFilteredValue = "content_filter";
        private const string FunctionCallValue = "function_call";
        private const string ToolCallsValue = "tool_calls";

        /// <summary> Completions ended normally and reached its end of token generation. </summary>
        public static CompletionsFinishReason Stopped { get; } = new CompletionsFinishReason(StoppedValue);
        /// <summary> Completions exhausted available token limits before generation could complete. </summary>
        public static CompletionsFinishReason TokenLimitReached { get; } = new CompletionsFinishReason(TokenLimitReachedValue);
        /// <summary>
        /// Completions generated a response that was identified as potentially sensitive per content
        /// moderation policies.
        /// </summary>
        public static CompletionsFinishReason ContentFiltered { get; } = new CompletionsFinishReason(ContentFilteredValue);
        /// <summary> Completion ended normally, with the model requesting a function to be called. </summary>
        public static CompletionsFinishReason FunctionCall { get; } = new CompletionsFinishReason(FunctionCallValue);
        /// <summary> Completion ended with the model calling a provided tool for output. </summary>
        public static CompletionsFinishReason ToolCalls { get; } = new CompletionsFinishReason(ToolCallsValue);
        /// <summary> Determines if two <see cref="CompletionsFinishReason"/> values are the same. </summary>
        public static bool operator ==(CompletionsFinishReason left, CompletionsFinishReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CompletionsFinishReason"/> values are not the same. </summary>
        public static bool operator !=(CompletionsFinishReason left, CompletionsFinishReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CompletionsFinishReason"/>. </summary>
        public static implicit operator CompletionsFinishReason(string value) => new CompletionsFinishReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CompletionsFinishReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CompletionsFinishReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
