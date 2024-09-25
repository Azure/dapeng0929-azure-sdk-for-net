// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Big data pool reference type. </summary>
    public readonly partial struct BigDataPoolReferenceType : IEquatable<BigDataPoolReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BigDataPoolReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BigDataPoolReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BigDataPoolReferenceValue = "BigDataPoolReference";

        /// <summary> BigDataPoolReference. </summary>
        public static BigDataPoolReferenceType BigDataPoolReference { get; } = new BigDataPoolReferenceType(BigDataPoolReferenceValue);
        /// <summary> Determines if two <see cref="BigDataPoolReferenceType"/> values are the same. </summary>
        public static bool operator ==(BigDataPoolReferenceType left, BigDataPoolReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BigDataPoolReferenceType"/> values are not the same. </summary>
        public static bool operator !=(BigDataPoolReferenceType left, BigDataPoolReferenceType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BigDataPoolReferenceType"/>. </summary>
        public static implicit operator BigDataPoolReferenceType(string value) => new BigDataPoolReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BigDataPoolReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BigDataPoolReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
