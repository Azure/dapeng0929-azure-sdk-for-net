// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Types of secrets supported. </summary>
    public readonly partial struct SecretType : IEquatable<SecretType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecretType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecretType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AKVSECRETURIValue = "AKV_SECRET_URI";
        private const string SECRETVALUEValue = "SECRET_VALUE";

        /// <summary> If the secret is stored in an Azure Key Vault. </summary>
        public static SecretType AKVSECRETURI { get; } = new SecretType(AKVSECRETURIValue);
        /// <summary> If the secret value provided as plain text. </summary>
        public static SecretType SECRETVALUE { get; } = new SecretType(SECRETVALUEValue);
        /// <summary> Determines if two <see cref="SecretType"/> values are the same. </summary>
        public static bool operator ==(SecretType left, SecretType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecretType"/> values are not the same. </summary>
        public static bool operator !=(SecretType left, SecretType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecretType"/>. </summary>
        public static implicit operator SecretType(string value) => new SecretType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecretType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecretType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
