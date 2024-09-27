// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Defines the minimal alert severity which will be sent as email notifications. </summary>
    public readonly partial struct SecurityAlertMinimalSeverity : IEquatable<SecurityAlertMinimalSeverity>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityAlertMinimalSeverity"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityAlertMinimalSeverity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HighValue = "High";
        private const string MediumValue = "Medium";
        private const string LowValue = "Low";

        /// <summary> Get notifications on new alerts with High severity. </summary>
        public static SecurityAlertMinimalSeverity High { get; } = new SecurityAlertMinimalSeverity(HighValue);
        /// <summary> Get notifications on new alerts with medium or high severity. </summary>
        public static SecurityAlertMinimalSeverity Medium { get; } = new SecurityAlertMinimalSeverity(MediumValue);
        /// <summary> Don't get notifications on new alerts with low, medium or high severity. </summary>
        public static SecurityAlertMinimalSeverity Low { get; } = new SecurityAlertMinimalSeverity(LowValue);
        /// <summary> Determines if two <see cref="SecurityAlertMinimalSeverity"/> values are the same. </summary>
        public static bool operator ==(SecurityAlertMinimalSeverity left, SecurityAlertMinimalSeverity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityAlertMinimalSeverity"/> values are not the same. </summary>
        public static bool operator !=(SecurityAlertMinimalSeverity left, SecurityAlertMinimalSeverity right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecurityAlertMinimalSeverity"/>. </summary>
        public static implicit operator SecurityAlertMinimalSeverity(string value) => new SecurityAlertMinimalSeverity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityAlertMinimalSeverity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityAlertMinimalSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
