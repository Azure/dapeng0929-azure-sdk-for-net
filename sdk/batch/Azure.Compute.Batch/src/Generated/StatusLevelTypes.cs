// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> The StatusLevelTypes. </summary>
    public readonly partial struct StatusLevelTypes : IEquatable<StatusLevelTypes>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StatusLevelTypes"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StatusLevelTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string InfoValue = "Info";
        private const string WarningValue = "Warning";

        /// <summary> Error. </summary>
        public static StatusLevelTypes Error { get; } = new StatusLevelTypes(ErrorValue);
        /// <summary> Info. </summary>
        public static StatusLevelTypes Info { get; } = new StatusLevelTypes(InfoValue);
        /// <summary> Warning. </summary>
        public static StatusLevelTypes Warning { get; } = new StatusLevelTypes(WarningValue);
        /// <summary> Determines if two <see cref="StatusLevelTypes"/> values are the same. </summary>
        public static bool operator ==(StatusLevelTypes left, StatusLevelTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StatusLevelTypes"/> values are not the same. </summary>
        public static bool operator !=(StatusLevelTypes left, StatusLevelTypes right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="StatusLevelTypes"/>. </summary>
        public static implicit operator StatusLevelTypes(string value) => new StatusLevelTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StatusLevelTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StatusLevelTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
