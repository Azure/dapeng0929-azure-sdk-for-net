// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Provisioning states of a resource. </summary>
    public readonly partial struct NetworkProvisioningState : IEquatable<NetworkProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NetworkProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NetworkProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";

        /// <summary> Failed. </summary>
        public static NetworkProvisioningState Failed { get; } = new NetworkProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static NetworkProvisioningState Succeeded { get; } = new NetworkProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static NetworkProvisioningState Canceled { get; } = new NetworkProvisioningState(CanceledValue);
        /// <summary> Creating. </summary>
        public static NetworkProvisioningState Creating { get; } = new NetworkProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static NetworkProvisioningState Updating { get; } = new NetworkProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static NetworkProvisioningState Deleting { get; } = new NetworkProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="NetworkProvisioningState"/> values are the same. </summary>
        public static bool operator ==(NetworkProvisioningState left, NetworkProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NetworkProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(NetworkProvisioningState left, NetworkProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NetworkProvisioningState"/>. </summary>
        public static implicit operator NetworkProvisioningState(string value) => new NetworkProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NetworkProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NetworkProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
