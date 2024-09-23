// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Model lifecycle status. </summary>
    public readonly partial struct ModelLifecycleStatus : IEquatable<ModelLifecycleStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ModelLifecycleStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ModelLifecycleStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StableValue = "Stable";
        private const string PreviewValue = "Preview";
        private const string GenerallyAvailableValue = "GenerallyAvailable";
        private const string DeprecatingValue = "Deprecating";
        private const string DeprecatedValue = "Deprecated";

        /// <summary> Stable. </summary>
        public static ModelLifecycleStatus Stable { get; } = new ModelLifecycleStatus(StableValue);
        /// <summary> Preview. </summary>
        public static ModelLifecycleStatus Preview { get; } = new ModelLifecycleStatus(PreviewValue);
        /// <summary> GenerallyAvailable. </summary>
        public static ModelLifecycleStatus GenerallyAvailable { get; } = new ModelLifecycleStatus(GenerallyAvailableValue);
        /// <summary> Deprecating. </summary>
        public static ModelLifecycleStatus Deprecating { get; } = new ModelLifecycleStatus(DeprecatingValue);
        /// <summary> Deprecated. </summary>
        public static ModelLifecycleStatus Deprecated { get; } = new ModelLifecycleStatus(DeprecatedValue);
        /// <summary> Determines if two <see cref="ModelLifecycleStatus"/> values are the same. </summary>
        public static bool operator ==(ModelLifecycleStatus left, ModelLifecycleStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ModelLifecycleStatus"/> values are not the same. </summary>
        public static bool operator !=(ModelLifecycleStatus left, ModelLifecycleStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ModelLifecycleStatus"/>. </summary>
        public static implicit operator ModelLifecycleStatus(string value) => new ModelLifecycleStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ModelLifecycleStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ModelLifecycleStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
