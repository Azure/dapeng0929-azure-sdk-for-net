// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> Specify public IP sku tier. </summary>
    public readonly partial struct ComputeFleetPublicIPAddressSkuTier : IEquatable<ComputeFleetPublicIPAddressSkuTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetPublicIPAddressSkuTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeFleetPublicIPAddressSkuTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegionalValue = "Regional";
        private const string GlobalValue = "Global";

        /// <summary> Regional sku tier. </summary>
        public static ComputeFleetPublicIPAddressSkuTier Regional { get; } = new ComputeFleetPublicIPAddressSkuTier(RegionalValue);
        /// <summary> Global sku tier. </summary>
        public static ComputeFleetPublicIPAddressSkuTier Global { get; } = new ComputeFleetPublicIPAddressSkuTier(GlobalValue);
        /// <summary> Determines if two <see cref="ComputeFleetPublicIPAddressSkuTier"/> values are the same. </summary>
        public static bool operator ==(ComputeFleetPublicIPAddressSkuTier left, ComputeFleetPublicIPAddressSkuTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeFleetPublicIPAddressSkuTier"/> values are not the same. </summary>
        public static bool operator !=(ComputeFleetPublicIPAddressSkuTier left, ComputeFleetPublicIPAddressSkuTier right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ComputeFleetPublicIPAddressSkuTier"/>. </summary>
        public static implicit operator ComputeFleetPublicIPAddressSkuTier(string value) => new ComputeFleetPublicIPAddressSkuTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeFleetPublicIPAddressSkuTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeFleetPublicIPAddressSkuTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
