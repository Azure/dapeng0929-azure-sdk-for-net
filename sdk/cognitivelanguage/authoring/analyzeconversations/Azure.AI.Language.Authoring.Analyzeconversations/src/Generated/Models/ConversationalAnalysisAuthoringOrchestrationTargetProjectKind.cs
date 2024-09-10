// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    /// <summary> The ConversationalAnalysisAuthoringOrchestrationTargetProjectKind. </summary>
    internal readonly partial struct ConversationalAnalysisAuthoringOrchestrationTargetProjectKind : IEquatable<ConversationalAnalysisAuthoringOrchestrationTargetProjectKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringOrchestrationTargetProjectKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConversationalAnalysisAuthoringOrchestrationTargetProjectKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LuisValue = "Luis";
        private const string ConversationValue = "Conversation";
        private const string QuestionAnsweringValue = "QuestionAnswering";

        /// <summary> Luis. </summary>
        public static ConversationalAnalysisAuthoringOrchestrationTargetProjectKind Luis { get; } = new ConversationalAnalysisAuthoringOrchestrationTargetProjectKind(LuisValue);
        /// <summary> Conversation. </summary>
        public static ConversationalAnalysisAuthoringOrchestrationTargetProjectKind Conversation { get; } = new ConversationalAnalysisAuthoringOrchestrationTargetProjectKind(ConversationValue);
        /// <summary> QuestionAnswering. </summary>
        public static ConversationalAnalysisAuthoringOrchestrationTargetProjectKind QuestionAnswering { get; } = new ConversationalAnalysisAuthoringOrchestrationTargetProjectKind(QuestionAnsweringValue);
        /// <summary> Determines if two <see cref="ConversationalAnalysisAuthoringOrchestrationTargetProjectKind"/> values are the same. </summary>
        public static bool operator ==(ConversationalAnalysisAuthoringOrchestrationTargetProjectKind left, ConversationalAnalysisAuthoringOrchestrationTargetProjectKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConversationalAnalysisAuthoringOrchestrationTargetProjectKind"/> values are not the same. </summary>
        public static bool operator !=(ConversationalAnalysisAuthoringOrchestrationTargetProjectKind left, ConversationalAnalysisAuthoringOrchestrationTargetProjectKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConversationalAnalysisAuthoringOrchestrationTargetProjectKind"/>. </summary>
        public static implicit operator ConversationalAnalysisAuthoringOrchestrationTargetProjectKind(string value) => new ConversationalAnalysisAuthoringOrchestrationTargetProjectKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConversationalAnalysisAuthoringOrchestrationTargetProjectKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConversationalAnalysisAuthoringOrchestrationTargetProjectKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
