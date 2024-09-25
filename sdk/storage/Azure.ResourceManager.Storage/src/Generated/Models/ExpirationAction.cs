// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The SAS Expiration Action defines the action to be performed when sasPolicy.sasExpirationPeriod is violated. The 'Log' action can be used for audit purposes and the 'Block' action can be used to block and deny the usage of SAS tokens that do not adhere to the sas policy expiration period. </summary>
    public readonly partial struct ExpirationAction : IEquatable<ExpirationAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExpirationAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpirationAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LogValue = "Log";
        private const string BlockValue = "Block";

        /// <summary> Log. </summary>
        public static ExpirationAction Log { get; } = new ExpirationAction(LogValue);
        /// <summary> Block. </summary>
        public static ExpirationAction Block { get; } = new ExpirationAction(BlockValue);
        /// <summary> Determines if two <see cref="ExpirationAction"/> values are the same. </summary>
        public static bool operator ==(ExpirationAction left, ExpirationAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpirationAction"/> values are not the same. </summary>
        public static bool operator !=(ExpirationAction left, ExpirationAction right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExpirationAction"/>. </summary>
        public static implicit operator ExpirationAction(string value) => new ExpirationAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpirationAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpirationAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
