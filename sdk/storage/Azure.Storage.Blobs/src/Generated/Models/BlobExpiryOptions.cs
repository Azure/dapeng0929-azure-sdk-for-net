// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The BlobExpiryOptions. </summary>
    internal readonly partial struct BlobExpiryOptions : IEquatable<BlobExpiryOptions>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BlobExpiryOptions"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BlobExpiryOptions(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NeverExpireValue = "NeverExpire";
        private const string RelativeToCreationValue = "RelativeToCreation";
        private const string RelativeToNowValue = "RelativeToNow";
        private const string AbsoluteValue = "Absolute";

        /// <summary> NeverExpire. </summary>
        public static BlobExpiryOptions NeverExpire { get; } = new BlobExpiryOptions(NeverExpireValue);
        /// <summary> RelativeToCreation. </summary>
        public static BlobExpiryOptions RelativeToCreation { get; } = new BlobExpiryOptions(RelativeToCreationValue);
        /// <summary> RelativeToNow. </summary>
        public static BlobExpiryOptions RelativeToNow { get; } = new BlobExpiryOptions(RelativeToNowValue);
        /// <summary> Absolute. </summary>
        public static BlobExpiryOptions Absolute { get; } = new BlobExpiryOptions(AbsoluteValue);
        /// <summary> Determines if two <see cref="BlobExpiryOptions"/> values are the same. </summary>
        public static bool operator ==(BlobExpiryOptions left, BlobExpiryOptions right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BlobExpiryOptions"/> values are not the same. </summary>
        public static bool operator !=(BlobExpiryOptions left, BlobExpiryOptions right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BlobExpiryOptions"/>. </summary>
        public static implicit operator BlobExpiryOptions(string value) => new BlobExpiryOptions(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BlobExpiryOptions other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BlobExpiryOptions other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
