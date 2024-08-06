// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> Result information for an operation that transcribed spoken audio into written text. </summary>
    public partial class AudioTranscription
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AudioTranscription"/>. </summary>
        /// <param name="text"> The transcribed text for the provided audio data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal AudioTranscription(string text)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            Segments = new ChangeTrackingList<AudioTranscriptionSegment>();
            Words = new ChangeTrackingList<AudioTranscriptionWord>();
        }

        /// <summary> Initializes a new instance of <see cref="AudioTranscription"/>. </summary>
        /// <param name="text"> The transcribed text for the provided audio data. </param>
        /// <param name="internalAudioTaskLabel"> The label that describes which operation type generated the accompanying response data. </param>
        /// <param name="language">
        /// The spoken language that was detected in the transcribed audio data.
        /// This is expressed as a two-letter ISO-639-1 language code like 'en' or 'fr'.
        /// </param>
        /// <param name="duration"> The total duration of the audio processed to produce accompanying transcription information. </param>
        /// <param name="segments"> A collection of information about the timing, probabilities, and other detail of each processed audio segment. </param>
        /// <param name="words"> A collection of information about the timing of each processed word. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AudioTranscription(string text, AudioTaskLabel? internalAudioTaskLabel, string language, TimeSpan? duration, IReadOnlyList<AudioTranscriptionSegment> segments, IReadOnlyList<AudioTranscriptionWord> words, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            InternalAudioTaskLabel = internalAudioTaskLabel;
            Language = language;
            Duration = duration;
            Segments = segments;
            Words = words;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AudioTranscription"/> for deserialization. </summary>
        internal AudioTranscription()
        {
        }

        /// <summary> The transcribed text for the provided audio data. </summary>
        public string Text { get; }
        /// <summary> The label that describes which operation type generated the accompanying response data. </summary>
        public AudioTaskLabel? InternalAudioTaskLabel { get; }
        /// <summary>
        /// The spoken language that was detected in the transcribed audio data.
        /// This is expressed as a two-letter ISO-639-1 language code like 'en' or 'fr'.
        /// </summary>
        public string Language { get; }
        /// <summary> The total duration of the audio processed to produce accompanying transcription information. </summary>
        public TimeSpan? Duration { get; }
        /// <summary> A collection of information about the timing, probabilities, and other detail of each processed audio segment. </summary>
        public IReadOnlyList<AudioTranscriptionSegment> Segments { get; }
        /// <summary> A collection of information about the timing of each processed word. </summary>
        public IReadOnlyList<AudioTranscriptionWord> Words { get; }
    }
}
