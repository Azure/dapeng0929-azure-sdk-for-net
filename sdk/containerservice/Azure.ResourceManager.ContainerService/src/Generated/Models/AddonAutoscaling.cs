// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Whether VPA add-on is enabled and configured to scale AKS-managed add-ons. </summary>
    public readonly partial struct AddonAutoscaling : IEquatable<AddonAutoscaling>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AddonAutoscaling"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AddonAutoscaling(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Feature to autoscale AKS-managed add-ons is enabled. The default VPA update mode is Initial mode. </summary>
        public static AddonAutoscaling Enabled { get; } = new AddonAutoscaling(EnabledValue);
        /// <summary> Feature to autoscale AKS-managed add-ons is disabled. </summary>
        public static AddonAutoscaling Disabled { get; } = new AddonAutoscaling(DisabledValue);
        /// <summary> Determines if two <see cref="AddonAutoscaling"/> values are the same. </summary>
        public static bool operator ==(AddonAutoscaling left, AddonAutoscaling right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AddonAutoscaling"/> values are not the same. </summary>
        public static bool operator !=(AddonAutoscaling left, AddonAutoscaling right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AddonAutoscaling"/>. </summary>
        public static implicit operator AddonAutoscaling(string value) => new AddonAutoscaling(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AddonAutoscaling other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AddonAutoscaling other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
