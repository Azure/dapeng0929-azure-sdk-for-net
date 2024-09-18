// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> The FileDeletionStatus_object. </summary>
    public readonly partial struct FileDeletionStatusObject : IEquatable<FileDeletionStatusObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FileDeletionStatusObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FileDeletionStatusObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FileValue = "file";

        /// <summary> file. </summary>
        public static FileDeletionStatusObject File { get; } = new FileDeletionStatusObject(FileValue);
        /// <summary> Determines if two <see cref="FileDeletionStatusObject"/> values are the same. </summary>
        public static bool operator ==(FileDeletionStatusObject left, FileDeletionStatusObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FileDeletionStatusObject"/> values are not the same. </summary>
        public static bool operator !=(FileDeletionStatusObject left, FileDeletionStatusObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FileDeletionStatusObject"/>. </summary>
        public static implicit operator FileDeletionStatusObject(string value) => new FileDeletionStatusObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileDeletionStatusObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FileDeletionStatusObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
