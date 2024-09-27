// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The TermStatus. </summary>
    public readonly partial struct TermStatus : IEquatable<TermStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TermStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TermStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DraftValue = "Draft";
        private const string ApprovedValue = "Approved";
        private const string AlertValue = "Alert";
        private const string ExpiredValue = "Expired";

        /// <summary> Draft. </summary>
        public static TermStatus Draft { get; } = new TermStatus(DraftValue);
        /// <summary> Approved. </summary>
        public static TermStatus Approved { get; } = new TermStatus(ApprovedValue);
        /// <summary> Alert. </summary>
        public static TermStatus Alert { get; } = new TermStatus(AlertValue);
        /// <summary> Expired. </summary>
        public static TermStatus Expired { get; } = new TermStatus(ExpiredValue);
        /// <summary> Determines if two <see cref="TermStatus"/> values are the same. </summary>
        public static bool operator ==(TermStatus left, TermStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TermStatus"/> values are not the same. </summary>
        public static bool operator !=(TermStatus left, TermStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TermStatus"/>. </summary>
        public static implicit operator TermStatus(string value) => new TermStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TermStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TermStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
