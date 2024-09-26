// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> The supported audio output formats for text-to-speech. </summary>
    public readonly partial struct SpeechGenerationResponseFormat : IEquatable<SpeechGenerationResponseFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SpeechGenerationResponseFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SpeechGenerationResponseFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Mp3Value = "mp3";
        private const string OpusValue = "opus";
        private const string AacValue = "aac";
        private const string FlacValue = "flac";
        private const string WavValue = "wav";
        private const string PcmValue = "pcm";

        /// <summary> Use MP3 as the audio output format. MP3 is the default, general-purpose format. </summary>
        public static SpeechGenerationResponseFormat Mp3 { get; } = new SpeechGenerationResponseFormat(Mp3Value);
        /// <summary> Use Opus as the audio output format. Opus is optimized for internet streaming and low latency. </summary>
        public static SpeechGenerationResponseFormat Opus { get; } = new SpeechGenerationResponseFormat(OpusValue);
        /// <summary> Use AAC as the audio output format. AAC is optimized for digital audio compression and is preferred by YouTube, Android, and iOS. </summary>
        public static SpeechGenerationResponseFormat Aac { get; } = new SpeechGenerationResponseFormat(AacValue);
        /// <summary> Use FLAC as the audio output format. FLAC is a fully lossless format optimized for maximum quality at the expense of size. </summary>
        public static SpeechGenerationResponseFormat Flac { get; } = new SpeechGenerationResponseFormat(FlacValue);
        /// <summary> Use uncompressed WAV as the audio output format, suitable for low-latency applications to avoid decoding overhead. </summary>
        public static SpeechGenerationResponseFormat Wav { get; } = new SpeechGenerationResponseFormat(WavValue);
        /// <summary> Use uncompressed PCM as the audio output format, which is similar to WAV but contains raw samples in 24kHz (16-bit signed, low-endian), without the header. </summary>
        public static SpeechGenerationResponseFormat Pcm { get; } = new SpeechGenerationResponseFormat(PcmValue);
        /// <summary> Determines if two <see cref="SpeechGenerationResponseFormat"/> values are the same. </summary>
        public static bool operator ==(SpeechGenerationResponseFormat left, SpeechGenerationResponseFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SpeechGenerationResponseFormat"/> values are not the same. </summary>
        public static bool operator !=(SpeechGenerationResponseFormat left, SpeechGenerationResponseFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SpeechGenerationResponseFormat"/>. </summary>
        public static implicit operator SpeechGenerationResponseFormat(string value) => new SpeechGenerationResponseFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SpeechGenerationResponseFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SpeechGenerationResponseFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
