// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Failover direction. </summary>
    public readonly partial struct FailoverDirection : IEquatable<FailoverDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FailoverDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FailoverDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryToRecoveryValue = "PrimaryToRecovery";
        private const string RecoveryToPrimaryValue = "RecoveryToPrimary";

        /// <summary> PrimaryToRecovery. </summary>
        public static FailoverDirection PrimaryToRecovery { get; } = new FailoverDirection(PrimaryToRecoveryValue);
        /// <summary> RecoveryToPrimary. </summary>
        public static FailoverDirection RecoveryToPrimary { get; } = new FailoverDirection(RecoveryToPrimaryValue);
        /// <summary> Determines if two <see cref="FailoverDirection"/> values are the same. </summary>
        public static bool operator ==(FailoverDirection left, FailoverDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FailoverDirection"/> values are not the same. </summary>
        public static bool operator !=(FailoverDirection left, FailoverDirection right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FailoverDirection"/>. </summary>
        public static implicit operator FailoverDirection(string value) => new FailoverDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FailoverDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FailoverDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
