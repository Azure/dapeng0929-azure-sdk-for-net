// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StandbyPool.Models
{
    /// <summary> The StandbyProvisioningState. </summary>
    public readonly partial struct StandbyProvisioningState : IEquatable<StandbyProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StandbyProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StandbyProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";

        /// <summary> Succeeded. </summary>
        public static StandbyProvisioningState Succeeded { get; } = new StandbyProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static StandbyProvisioningState Failed { get; } = new StandbyProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static StandbyProvisioningState Canceled { get; } = new StandbyProvisioningState(CanceledValue);
        /// <summary> Deleting. </summary>
        public static StandbyProvisioningState Deleting { get; } = new StandbyProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="StandbyProvisioningState"/> values are the same. </summary>
        public static bool operator ==(StandbyProvisioningState left, StandbyProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StandbyProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(StandbyProvisioningState left, StandbyProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StandbyProvisioningState"/>. </summary>
        public static implicit operator StandbyProvisioningState(string value) => new StandbyProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StandbyProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StandbyProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
