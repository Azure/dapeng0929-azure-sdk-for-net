// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> A list of observation types. </summary>
    public readonly partial struct ObservationType : IEquatable<ObservationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ObservationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ObservationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CveValue = "cve";
        private const string InsightValue = "insight";

        /// <summary> common vulnerabilities and exposures. </summary>
        public static ObservationType Cve { get; } = new ObservationType(CveValue);
        /// <summary> insight. </summary>
        public static ObservationType Insight { get; } = new ObservationType(InsightValue);
        /// <summary> Determines if two <see cref="ObservationType"/> values are the same. </summary>
        public static bool operator ==(ObservationType left, ObservationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ObservationType"/> values are not the same. </summary>
        public static bool operator !=(ObservationType left, ObservationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ObservationType"/>. </summary>
        public static implicit operator ObservationType(string value) => new ObservationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ObservationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ObservationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
