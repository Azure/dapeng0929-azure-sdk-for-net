// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the zone redundant resource setting. </summary>
    public readonly partial struct ResourceZoneRedundantSetting : IEquatable<ResourceZoneRedundantSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceZoneRedundantSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceZoneRedundantSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnableValue = "Enable";
        private const string DisableValue = "Disable";

        /// <summary> Enable. </summary>
        public static ResourceZoneRedundantSetting Enable { get; } = new ResourceZoneRedundantSetting(EnableValue);
        /// <summary> Disable. </summary>
        public static ResourceZoneRedundantSetting Disable { get; } = new ResourceZoneRedundantSetting(DisableValue);
        /// <summary> Determines if two <see cref="ResourceZoneRedundantSetting"/> values are the same. </summary>
        public static bool operator ==(ResourceZoneRedundantSetting left, ResourceZoneRedundantSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceZoneRedundantSetting"/> values are not the same. </summary>
        public static bool operator !=(ResourceZoneRedundantSetting left, ResourceZoneRedundantSetting right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ResourceZoneRedundantSetting"/>. </summary>
        public static implicit operator ResourceZoneRedundantSetting(string value) => new ResourceZoneRedundantSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceZoneRedundantSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceZoneRedundantSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
