// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> StorageAccountType enums. </summary>
    public readonly partial struct StorageAccountType : IEquatable<StorageAccountType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageAccountType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageAccountType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardLRSValue = "standard_lrs";
        private const string PremiumLRSValue = "premium_lrs";
        private const string StandardSSDLRSValue = "standardssd_lrs";

        /// <summary> The data disk should use standard locally redundant storage. </summary>
        public static StorageAccountType StandardLRS { get; } = new StorageAccountType(StandardLRSValue);
        /// <summary> The data disk should use premium locally redundant storage. </summary>
        public static StorageAccountType PremiumLRS { get; } = new StorageAccountType(PremiumLRSValue);
        /// <summary> The data disk / OS disk should use standard SSD locally redundant storage. </summary>
        public static StorageAccountType StandardSSDLRS { get; } = new StorageAccountType(StandardSSDLRSValue);
        /// <summary> Determines if two <see cref="StorageAccountType"/> values are the same. </summary>
        public static bool operator ==(StorageAccountType left, StorageAccountType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageAccountType"/> values are not the same. </summary>
        public static bool operator !=(StorageAccountType left, StorageAccountType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageAccountType"/>. </summary>
        public static implicit operator StorageAccountType(string value) => new StorageAccountType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageAccountType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageAccountType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
