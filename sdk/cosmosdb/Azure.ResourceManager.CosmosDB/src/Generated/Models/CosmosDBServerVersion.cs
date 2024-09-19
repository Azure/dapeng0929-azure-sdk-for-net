// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Describes the version of the MongoDB account. </summary>
    public readonly partial struct CosmosDBServerVersion : IEquatable<CosmosDBServerVersion>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBServerVersion"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBServerVersion(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string V3_2Value = "3.2";
        private const string V3_6Value = "3.6";
        private const string V4_0Value = "4.0";
        private const string V4_2Value = "4.2";
        private const string Five0Value = "5.0";
        private const string Six0Value = "6.0";
        private const string Seven0Value = "7.0";
        /// <summary> 5.0. </summary>
        public static CosmosDBServerVersion Five0 { get; } = new CosmosDBServerVersion(Five0Value);
        /// <summary> 6.0. </summary>
        public static CosmosDBServerVersion Six0 { get; } = new CosmosDBServerVersion(Six0Value);
        /// <summary> 7.0. </summary>
        public static CosmosDBServerVersion Seven0 { get; } = new CosmosDBServerVersion(Seven0Value);
        /// <summary> Determines if two <see cref="CosmosDBServerVersion"/> values are the same. </summary>
        public static bool operator ==(CosmosDBServerVersion left, CosmosDBServerVersion right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBServerVersion"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBServerVersion left, CosmosDBServerVersion right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBServerVersion"/>. </summary>
        public static implicit operator CosmosDBServerVersion(string value) => new CosmosDBServerVersion(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBServerVersion other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBServerVersion other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
