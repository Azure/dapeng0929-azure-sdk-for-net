// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Type of the Feature Status. </summary>
    public readonly partial struct StorageSyncFeatureStatus : IEquatable<StorageSyncFeatureStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageSyncFeatureStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageSyncFeatureStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnValue = "on";
        private const string OffValue = "off";

        /// <summary> on. </summary>
        public static StorageSyncFeatureStatus On { get; } = new StorageSyncFeatureStatus(OnValue);
        /// <summary> off. </summary>
        public static StorageSyncFeatureStatus Off { get; } = new StorageSyncFeatureStatus(OffValue);
        /// <summary> Determines if two <see cref="StorageSyncFeatureStatus"/> values are the same. </summary>
        public static bool operator ==(StorageSyncFeatureStatus left, StorageSyncFeatureStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageSyncFeatureStatus"/> values are not the same. </summary>
        public static bool operator !=(StorageSyncFeatureStatus left, StorageSyncFeatureStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StorageSyncFeatureStatus"/>. </summary>
        public static implicit operator StorageSyncFeatureStatus(string value) => new StorageSyncFeatureStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageSyncFeatureStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageSyncFeatureStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
