// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    /// <summary> The ConversationalAnalysisAuthoringExportedProjectFormat. </summary>
    public readonly partial struct ConversationalAnalysisAuthoringExportedProjectFormat : IEquatable<ConversationalAnalysisAuthoringExportedProjectFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringExportedProjectFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConversationalAnalysisAuthoringExportedProjectFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConversationValue = "Conversation";
        private const string LuisValue = "Luis";

        /// <summary> Specifies the format for a conversational project. </summary>
        public static ConversationalAnalysisAuthoringExportedProjectFormat Conversation { get; } = new ConversationalAnalysisAuthoringExportedProjectFormat(ConversationValue);
        /// <summary> Specifies the format for an application that was exported from LUIS. </summary>
        public static ConversationalAnalysisAuthoringExportedProjectFormat Luis { get; } = new ConversationalAnalysisAuthoringExportedProjectFormat(LuisValue);
        /// <summary> Determines if two <see cref="ConversationalAnalysisAuthoringExportedProjectFormat"/> values are the same. </summary>
        public static bool operator ==(ConversationalAnalysisAuthoringExportedProjectFormat left, ConversationalAnalysisAuthoringExportedProjectFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConversationalAnalysisAuthoringExportedProjectFormat"/> values are not the same. </summary>
        public static bool operator !=(ConversationalAnalysisAuthoringExportedProjectFormat left, ConversationalAnalysisAuthoringExportedProjectFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConversationalAnalysisAuthoringExportedProjectFormat"/>. </summary>
        public static implicit operator ConversationalAnalysisAuthoringExportedProjectFormat(string value) => new ConversationalAnalysisAuthoringExportedProjectFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConversationalAnalysisAuthoringExportedProjectFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConversationalAnalysisAuthoringExportedProjectFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
