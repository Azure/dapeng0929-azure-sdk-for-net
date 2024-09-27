// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text
{
    /// <summary> The ClassificationType. </summary>
    public readonly partial struct ClassificationType : IEquatable<ClassificationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClassificationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClassificationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MultiValue = "Multi";
        private const string SingleValue = "Single";

        /// <summary> Multi. </summary>
        public static ClassificationType Multi { get; } = new ClassificationType(MultiValue);
        /// <summary> Single. </summary>
        public static ClassificationType Single { get; } = new ClassificationType(SingleValue);
        /// <summary> Determines if two <see cref="ClassificationType"/> values are the same. </summary>
        public static bool operator ==(ClassificationType left, ClassificationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClassificationType"/> values are not the same. </summary>
        public static bool operator !=(ClassificationType left, ClassificationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClassificationType"/>. </summary>
        public static implicit operator ClassificationType(string value) => new ClassificationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClassificationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClassificationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
