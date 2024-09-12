// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> How to map events to the cloud. </summary>
    public readonly partial struct CloudEventAttributeType : IEquatable<CloudEventAttributeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CloudEventAttributeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudEventAttributeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PropagateValue = "Propagate";
        private const string CreateOrRemapValue = "CreateOrRemap";

        /// <summary> Propagate type. </summary>
        public static CloudEventAttributeType Propagate { get; } = new CloudEventAttributeType(PropagateValue);
        /// <summary> CreateOrRemap type. </summary>
        public static CloudEventAttributeType CreateOrRemap { get; } = new CloudEventAttributeType(CreateOrRemapValue);
        /// <summary> Determines if two <see cref="CloudEventAttributeType"/> values are the same. </summary>
        public static bool operator ==(CloudEventAttributeType left, CloudEventAttributeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudEventAttributeType"/> values are not the same. </summary>
        public static bool operator !=(CloudEventAttributeType left, CloudEventAttributeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CloudEventAttributeType"/>. </summary>
        public static implicit operator CloudEventAttributeType(string value) => new CloudEventAttributeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudEventAttributeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudEventAttributeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
