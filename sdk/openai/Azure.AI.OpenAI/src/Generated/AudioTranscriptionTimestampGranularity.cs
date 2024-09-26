// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> Defines the timestamp granularities that can be requested on a verbose transcription response. </summary>
    public readonly partial struct AudioTranscriptionTimestampGranularity : IEquatable<AudioTranscriptionTimestampGranularity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AudioTranscriptionTimestampGranularity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AudioTranscriptionTimestampGranularity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WordValue = "word";
        private const string SegmentValue = "segment";

        /// <summary>
        /// Indicates that responses should include timing information about each transcribed word. Note that generating word
        /// timestamp information will incur additional response latency.
        /// </summary>
        public static AudioTranscriptionTimestampGranularity Word { get; } = new AudioTranscriptionTimestampGranularity(WordValue);
        /// <summary>
        /// Indicates that responses should include timing and other information about each transcribed audio segment. Audio
        /// segment timestamp information does not incur any additional latency.
        /// </summary>
        public static AudioTranscriptionTimestampGranularity Segment { get; } = new AudioTranscriptionTimestampGranularity(SegmentValue);
        /// <summary> Determines if two <see cref="AudioTranscriptionTimestampGranularity"/> values are the same. </summary>
        public static bool operator ==(AudioTranscriptionTimestampGranularity left, AudioTranscriptionTimestampGranularity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AudioTranscriptionTimestampGranularity"/> values are not the same. </summary>
        public static bool operator !=(AudioTranscriptionTimestampGranularity left, AudioTranscriptionTimestampGranularity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AudioTranscriptionTimestampGranularity"/>. </summary>
        public static implicit operator AudioTranscriptionTimestampGranularity(string value) => new AudioTranscriptionTimestampGranularity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AudioTranscriptionTimestampGranularity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AudioTranscriptionTimestampGranularity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
