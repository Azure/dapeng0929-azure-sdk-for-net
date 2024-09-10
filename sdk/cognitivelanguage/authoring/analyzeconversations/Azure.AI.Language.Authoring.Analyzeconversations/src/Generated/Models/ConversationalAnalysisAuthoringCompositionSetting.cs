// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    /// <summary> The ConversationalAnalysisAuthoringCompositionSetting. </summary>
    public readonly partial struct ConversationalAnalysisAuthoringCompositionSetting : IEquatable<ConversationalAnalysisAuthoringCompositionSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringCompositionSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConversationalAnalysisAuthoringCompositionSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReturnLongestOverlapValue = "returnLongestOverlap";
        private const string RequireExactOverlapValue = "requireExactOverlap";
        private const string SeparateComponentsValue = "separateComponents";
        private const string CombineComponentsValue = "combineComponents";

        /// <summary>
        /// When two or more components are found in the text and overlap, the component
        /// with the longest set of characters is returned.
        /// </summary>
        public static ConversationalAnalysisAuthoringCompositionSetting ReturnLongestOverlap { get; } = new ConversationalAnalysisAuthoringCompositionSetting(ReturnLongestOverlapValue);
        /// <summary>
        /// All components must overlap at the exact same characters in the text for the
        /// entity to return. If one of the defined components is not matched or predicted,
        /// the entity will not return.
        /// </summary>
        public static ConversationalAnalysisAuthoringCompositionSetting RequireExactOverlap { get; } = new ConversationalAnalysisAuthoringCompositionSetting(RequireExactOverlapValue);
        /// <summary>
        /// Every component's match or prediction is returned as a separate instance of the
        /// entity.
        /// </summary>
        public static ConversationalAnalysisAuthoringCompositionSetting SeparateComponents { get; } = new ConversationalAnalysisAuthoringCompositionSetting(SeparateComponentsValue);
        /// <summary>
        /// When two or more components are found in the text and overlap, the components'
        /// spans are merged together into one span combining all of them.
        /// </summary>
        public static ConversationalAnalysisAuthoringCompositionSetting CombineComponents { get; } = new ConversationalAnalysisAuthoringCompositionSetting(CombineComponentsValue);
        /// <summary> Determines if two <see cref="ConversationalAnalysisAuthoringCompositionSetting"/> values are the same. </summary>
        public static bool operator ==(ConversationalAnalysisAuthoringCompositionSetting left, ConversationalAnalysisAuthoringCompositionSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConversationalAnalysisAuthoringCompositionSetting"/> values are not the same. </summary>
        public static bool operator !=(ConversationalAnalysisAuthoringCompositionSetting left, ConversationalAnalysisAuthoringCompositionSetting right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConversationalAnalysisAuthoringCompositionSetting"/>. </summary>
        public static implicit operator ConversationalAnalysisAuthoringCompositionSetting(string value) => new ConversationalAnalysisAuthoringCompositionSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConversationalAnalysisAuthoringCompositionSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConversationalAnalysisAuthoringCompositionSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
