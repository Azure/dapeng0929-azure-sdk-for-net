// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The ConversationActionState. </summary>
    public readonly partial struct ConversationActionState : IEquatable<ConversationActionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConversationActionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConversationActionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "notStarted";
        private const string RunningValue = "running";
        private const string SucceededValue = "succeeded";
        private const string PartiallyCompletedValue = "partiallyCompleted";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";
        private const string CancellingValue = "cancelling";

        /// <summary> notStarted. </summary>
        public static ConversationActionState NotStarted { get; } = new ConversationActionState(NotStartedValue);
        /// <summary> running. </summary>
        public static ConversationActionState Running { get; } = new ConversationActionState(RunningValue);
        /// <summary> succeeded. </summary>
        public static ConversationActionState Succeeded { get; } = new ConversationActionState(SucceededValue);
        /// <summary> partiallyCompleted. </summary>
        public static ConversationActionState PartiallyCompleted { get; } = new ConversationActionState(PartiallyCompletedValue);
        /// <summary> failed. </summary>
        public static ConversationActionState Failed { get; } = new ConversationActionState(FailedValue);
        /// <summary> cancelled. </summary>
        public static ConversationActionState Cancelled { get; } = new ConversationActionState(CancelledValue);
        /// <summary> cancelling. </summary>
        public static ConversationActionState Cancelling { get; } = new ConversationActionState(CancellingValue);
        /// <summary> Determines if two <see cref="ConversationActionState"/> values are the same. </summary>
        public static bool operator ==(ConversationActionState left, ConversationActionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConversationActionState"/> values are not the same. </summary>
        public static bool operator !=(ConversationActionState left, ConversationActionState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConversationActionState"/>. </summary>
        public static implicit operator ConversationActionState(string value) => new ConversationActionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConversationActionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConversationActionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
