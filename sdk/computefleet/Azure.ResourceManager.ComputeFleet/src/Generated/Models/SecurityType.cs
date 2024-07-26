// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary>
    /// Specifies the SecurityType of the virtual machine. It has to be set to any
    /// specified value to enable UefiSettings. The default behavior is: UefiSettings
    /// will not be enabled unless this property is set.
    /// </summary>
    public readonly partial struct SecurityType : IEquatable<SecurityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrustedLaunchValue = "TrustedLaunch";
        private const string ConfidentialVmValue = "ConfidentialVM";

        /// <summary> TrustedLaunch security type. </summary>
        public static SecurityType TrustedLaunch { get; } = new SecurityType(TrustedLaunchValue);
        /// <summary> ConfidentialVM security type. </summary>
        public static SecurityType ConfidentialVm { get; } = new SecurityType(ConfidentialVmValue);
        /// <summary> Determines if two <see cref="SecurityType"/> values are the same. </summary>
        public static bool operator ==(SecurityType left, SecurityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityType"/> values are not the same. </summary>
        public static bool operator !=(SecurityType left, SecurityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityType"/>. </summary>
        public static implicit operator SecurityType(string value) => new SecurityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
