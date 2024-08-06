// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> The available voices for text-to-speech. </summary>
    public readonly partial struct SpeechVoice : IEquatable<SpeechVoice>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SpeechVoice"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SpeechVoice(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AlloyValue = "alloy";
        private const string EchoValue = "echo";
        private const string FableValue = "fable";
        private const string OnyxValue = "onyx";
        private const string NovaValue = "nova";
        private const string ShimmerValue = "shimmer";

        /// <summary> The Alloy voice. </summary>
        public static SpeechVoice Alloy { get; } = new SpeechVoice(AlloyValue);
        /// <summary> The Echo voice. </summary>
        public static SpeechVoice Echo { get; } = new SpeechVoice(EchoValue);
        /// <summary> The Fable voice. </summary>
        public static SpeechVoice Fable { get; } = new SpeechVoice(FableValue);
        /// <summary> The Onyx voice. </summary>
        public static SpeechVoice Onyx { get; } = new SpeechVoice(OnyxValue);
        /// <summary> The Nova voice. </summary>
        public static SpeechVoice Nova { get; } = new SpeechVoice(NovaValue);
        /// <summary> The Shimmer voice. </summary>
        public static SpeechVoice Shimmer { get; } = new SpeechVoice(ShimmerValue);
        /// <summary> Determines if two <see cref="SpeechVoice"/> values are the same. </summary>
        public static bool operator ==(SpeechVoice left, SpeechVoice right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SpeechVoice"/> values are not the same. </summary>
        public static bool operator !=(SpeechVoice left, SpeechVoice right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SpeechVoice"/>. </summary>
        public static implicit operator SpeechVoice(string value) => new SpeechVoice(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SpeechVoice other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SpeechVoice other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
