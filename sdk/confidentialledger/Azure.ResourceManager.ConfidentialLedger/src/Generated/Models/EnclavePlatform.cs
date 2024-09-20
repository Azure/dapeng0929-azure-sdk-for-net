// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Object representing the enclave platform for the Confidential Ledger application. Defaults to IntelSgx. </summary>
    public readonly partial struct EnclavePlatform : IEquatable<EnclavePlatform>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EnclavePlatform"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EnclavePlatform(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IntelSgxValue = "IntelSgx";
        private const string AmdSevSnpValue = "AmdSevSnp";

        /// <summary> IntelSgx. </summary>
        public static EnclavePlatform IntelSgx { get; } = new EnclavePlatform(IntelSgxValue);
        /// <summary> AmdSevSnp. </summary>
        public static EnclavePlatform AmdSevSnp { get; } = new EnclavePlatform(AmdSevSnpValue);
        /// <summary> Determines if two <see cref="EnclavePlatform"/> values are the same. </summary>
        public static bool operator ==(EnclavePlatform left, EnclavePlatform right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EnclavePlatform"/> values are not the same. </summary>
        public static bool operator !=(EnclavePlatform left, EnclavePlatform right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EnclavePlatform"/>. </summary>
        public static implicit operator EnclavePlatform(string value) => new EnclavePlatform(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EnclavePlatform other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EnclavePlatform other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
