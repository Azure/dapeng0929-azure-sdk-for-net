// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The current scope connection state. </summary>
    public readonly partial struct ScopeConnectionState : IEquatable<ScopeConnectionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScopeConnectionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScopeConnectionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConnectedValue = "Connected";
        private const string PendingValue = "Pending";
        private const string ConflictValue = "Conflict";
        private const string RevokedValue = "Revoked";
        private const string RejectedValue = "Rejected";

        /// <summary> Connected. </summary>
        public static ScopeConnectionState Connected { get; } = new ScopeConnectionState(ConnectedValue);
        /// <summary> Pending. </summary>
        public static ScopeConnectionState Pending { get; } = new ScopeConnectionState(PendingValue);
        /// <summary> Conflict. </summary>
        public static ScopeConnectionState Conflict { get; } = new ScopeConnectionState(ConflictValue);
        /// <summary> Revoked. </summary>
        public static ScopeConnectionState Revoked { get; } = new ScopeConnectionState(RevokedValue);
        /// <summary> Rejected. </summary>
        public static ScopeConnectionState Rejected { get; } = new ScopeConnectionState(RejectedValue);
        /// <summary> Determines if two <see cref="ScopeConnectionState"/> values are the same. </summary>
        public static bool operator ==(ScopeConnectionState left, ScopeConnectionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScopeConnectionState"/> values are not the same. </summary>
        public static bool operator !=(ScopeConnectionState left, ScopeConnectionState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ScopeConnectionState"/>. </summary>
        public static implicit operator ScopeConnectionState(string value) => new ScopeConnectionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScopeConnectionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScopeConnectionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
