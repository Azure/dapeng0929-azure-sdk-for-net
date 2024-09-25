// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Direction of Access Rule. </summary>
    public readonly partial struct NspAccessRuleDirection : IEquatable<NspAccessRuleDirection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NspAccessRuleDirection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NspAccessRuleDirection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary> Inbound. </summary>
        public static NspAccessRuleDirection Inbound { get; } = new NspAccessRuleDirection(InboundValue);
        /// <summary> Outbound. </summary>
        public static NspAccessRuleDirection Outbound { get; } = new NspAccessRuleDirection(OutboundValue);
        /// <summary> Determines if two <see cref="NspAccessRuleDirection"/> values are the same. </summary>
        public static bool operator ==(NspAccessRuleDirection left, NspAccessRuleDirection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NspAccessRuleDirection"/> values are not the same. </summary>
        public static bool operator !=(NspAccessRuleDirection left, NspAccessRuleDirection right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="NspAccessRuleDirection"/>. </summary>
        public static implicit operator NspAccessRuleDirection(string value) => new NspAccessRuleDirection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NspAccessRuleDirection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NspAccessRuleDirection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
