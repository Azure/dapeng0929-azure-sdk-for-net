// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Deidentification
{
    /// <summary> The DocumentDataType. </summary>
    public readonly partial struct DocumentDataType : IEquatable<DocumentDataType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentDataType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentDataType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PlaintextValue = "Plaintext";

        /// <summary> Plaintext. </summary>
        public static DocumentDataType Plaintext { get; } = new DocumentDataType(PlaintextValue);
        /// <summary> Determines if two <see cref="DocumentDataType"/> values are the same. </summary>
        public static bool operator ==(DocumentDataType left, DocumentDataType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentDataType"/> values are not the same. </summary>
        public static bool operator !=(DocumentDataType left, DocumentDataType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DocumentDataType"/>. </summary>
        public static implicit operator DocumentDataType(string value) => new DocumentDataType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentDataType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentDataType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
