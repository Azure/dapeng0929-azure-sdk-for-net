// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    /// <summary> The ConversationalAnalysisAuthoringStringIndexType. </summary>
    public readonly partial struct ConversationalAnalysisAuthoringStringIndexType : IEquatable<ConversationalAnalysisAuthoringStringIndexType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringStringIndexType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConversationalAnalysisAuthoringStringIndexType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Utf16CodeUnitValue = "Utf16CodeUnit";

        /// <summary>
        /// The offset and length values will correspond to UTF-16 code units. Use this
        /// option if your application is written in a language that support Unicode, for
        /// example Java, JavaScript.
        /// </summary>
        public static ConversationalAnalysisAuthoringStringIndexType Utf16CodeUnit { get; } = new ConversationalAnalysisAuthoringStringIndexType(Utf16CodeUnitValue);
        /// <summary> Determines if two <see cref="ConversationalAnalysisAuthoringStringIndexType"/> values are the same. </summary>
        public static bool operator ==(ConversationalAnalysisAuthoringStringIndexType left, ConversationalAnalysisAuthoringStringIndexType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConversationalAnalysisAuthoringStringIndexType"/> values are not the same. </summary>
        public static bool operator !=(ConversationalAnalysisAuthoringStringIndexType left, ConversationalAnalysisAuthoringStringIndexType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConversationalAnalysisAuthoringStringIndexType"/>. </summary>
        public static implicit operator ConversationalAnalysisAuthoringStringIndexType(string value) => new ConversationalAnalysisAuthoringStringIndexType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConversationalAnalysisAuthoringStringIndexType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConversationalAnalysisAuthoringStringIndexType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
