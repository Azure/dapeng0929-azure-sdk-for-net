// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> BatchNodePlacementPolicyType enums. </summary>
    public readonly partial struct BatchNodePlacementPolicyType : IEquatable<BatchNodePlacementPolicyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchNodePlacementPolicyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchNodePlacementPolicyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RegionalValue = "regional";
        private const string ZonalValue = "zonal";

        /// <summary> All nodes in the pool will be allocated in the same region. </summary>
        public static BatchNodePlacementPolicyType Regional { get; } = new BatchNodePlacementPolicyType(RegionalValue);
        /// <summary> Nodes in the pool will be spread across different availability zones with best effort balancing. </summary>
        public static BatchNodePlacementPolicyType Zonal { get; } = new BatchNodePlacementPolicyType(ZonalValue);
        /// <summary> Determines if two <see cref="BatchNodePlacementPolicyType"/> values are the same. </summary>
        public static bool operator ==(BatchNodePlacementPolicyType left, BatchNodePlacementPolicyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchNodePlacementPolicyType"/> values are not the same. </summary>
        public static bool operator !=(BatchNodePlacementPolicyType left, BatchNodePlacementPolicyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BatchNodePlacementPolicyType"/>. </summary>
        public static implicit operator BatchNodePlacementPolicyType(string value) => new BatchNodePlacementPolicyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchNodePlacementPolicyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchNodePlacementPolicyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
