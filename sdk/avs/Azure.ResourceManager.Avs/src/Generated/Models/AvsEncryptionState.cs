// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Whether encryption is enabled or disabled. </summary>
    public readonly partial struct AvsEncryptionState : IEquatable<AvsEncryptionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvsEncryptionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvsEncryptionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> is enabled. </summary>
        public static AvsEncryptionState Enabled { get; } = new AvsEncryptionState(EnabledValue);
        /// <summary> is disabled. </summary>
        public static AvsEncryptionState Disabled { get; } = new AvsEncryptionState(DisabledValue);
        /// <summary> Determines if two <see cref="AvsEncryptionState"/> values are the same. </summary>
        public static bool operator ==(AvsEncryptionState left, AvsEncryptionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvsEncryptionState"/> values are not the same. </summary>
        public static bool operator !=(AvsEncryptionState left, AvsEncryptionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvsEncryptionState"/>. </summary>
        public static implicit operator AvsEncryptionState(string value) => new AvsEncryptionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvsEncryptionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvsEncryptionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
