// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> The DeleteType. </summary>
    public readonly partial struct DeleteType : IEquatable<DeleteType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DeleteType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DeleteType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PermanentValue = "permanent";

        /// <summary> permanent. </summary>
        public static DeleteType Permanent { get; } = new DeleteType(PermanentValue);
        /// <summary> Determines if two <see cref="DeleteType"/> values are the same. </summary>
        public static bool operator ==(DeleteType left, DeleteType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DeleteType"/> values are not the same. </summary>
        public static bool operator !=(DeleteType left, DeleteType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DeleteType"/>. </summary>
        public static implicit operator DeleteType(string value) => new DeleteType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DeleteType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DeleteType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
