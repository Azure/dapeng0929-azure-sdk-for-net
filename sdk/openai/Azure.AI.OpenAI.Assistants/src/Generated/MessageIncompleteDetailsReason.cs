// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> A set of reasons describing why a message is marked as incomplete. </summary>
    public readonly partial struct MessageIncompleteDetailsReason : IEquatable<MessageIncompleteDetailsReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageIncompleteDetailsReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageIncompleteDetailsReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ContentFilterValue = "content_filter";
        private const string MaxTokensValue = "max_tokens";
        private const string RunCancelledValue = "run_cancelled";
        private const string RunFailedValue = "run_failed";
        private const string RunExpiredValue = "run_expired";

        /// <summary> The run generating the message was terminated due to content filter flagging. </summary>
        public static MessageIncompleteDetailsReason ContentFilter { get; } = new MessageIncompleteDetailsReason(ContentFilterValue);
        /// <summary> The run generating the message exhausted available tokens before completion. </summary>
        public static MessageIncompleteDetailsReason MaxTokens { get; } = new MessageIncompleteDetailsReason(MaxTokensValue);
        /// <summary> The run generating the message was cancelled before completion. </summary>
        public static MessageIncompleteDetailsReason RunCancelled { get; } = new MessageIncompleteDetailsReason(RunCancelledValue);
        /// <summary> The run generating the message failed. </summary>
        public static MessageIncompleteDetailsReason RunFailed { get; } = new MessageIncompleteDetailsReason(RunFailedValue);
        /// <summary> The run generating the message expired. </summary>
        public static MessageIncompleteDetailsReason RunExpired { get; } = new MessageIncompleteDetailsReason(RunExpiredValue);
        /// <summary> Determines if two <see cref="MessageIncompleteDetailsReason"/> values are the same. </summary>
        public static bool operator ==(MessageIncompleteDetailsReason left, MessageIncompleteDetailsReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageIncompleteDetailsReason"/> values are not the same. </summary>
        public static bool operator !=(MessageIncompleteDetailsReason left, MessageIncompleteDetailsReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageIncompleteDetailsReason"/>. </summary>
        public static implicit operator MessageIncompleteDetailsReason(string value) => new MessageIncompleteDetailsReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageIncompleteDetailsReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageIncompleteDetailsReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
