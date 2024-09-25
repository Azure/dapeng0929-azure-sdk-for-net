// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Provisioning state of the Session Host Configuration. </summary>
    public readonly partial struct ProvisioningStateSHC : IEquatable<ProvisioningStateSHC>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProvisioningStateSHC"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProvisioningStateSHC(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ProvisioningValue = "Provisioning";

        /// <summary> Succeeded. </summary>
        public static ProvisioningStateSHC Succeeded { get; } = new ProvisioningStateSHC(SucceededValue);
        /// <summary> Failed. </summary>
        public static ProvisioningStateSHC Failed { get; } = new ProvisioningStateSHC(FailedValue);
        /// <summary> Canceled. </summary>
        public static ProvisioningStateSHC Canceled { get; } = new ProvisioningStateSHC(CanceledValue);
        /// <summary> Provisioning. </summary>
        public static ProvisioningStateSHC Provisioning { get; } = new ProvisioningStateSHC(ProvisioningValue);
        /// <summary> Determines if two <see cref="ProvisioningStateSHC"/> values are the same. </summary>
        public static bool operator ==(ProvisioningStateSHC left, ProvisioningStateSHC right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProvisioningStateSHC"/> values are not the same. </summary>
        public static bool operator !=(ProvisioningStateSHC left, ProvisioningStateSHC right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProvisioningStateSHC"/>. </summary>
        public static implicit operator ProvisioningStateSHC(string value) => new ProvisioningStateSHC(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProvisioningStateSHC other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProvisioningStateSHC other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
