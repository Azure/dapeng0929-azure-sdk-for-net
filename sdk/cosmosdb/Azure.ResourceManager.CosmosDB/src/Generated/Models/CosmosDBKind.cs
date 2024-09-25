// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Kind of the connection string key. </summary>
    public readonly partial struct CosmosDBKind : IEquatable<CosmosDBKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PrimaryValue = "Primary";
        private const string SecondaryValue = "Secondary";
        private const string PrimaryReadonlyValue = "PrimaryReadonly";
        private const string SecondaryReadonlyValue = "SecondaryReadonly";

        /// <summary> Primary. </summary>
        public static CosmosDBKind Primary { get; } = new CosmosDBKind(PrimaryValue);
        /// <summary> Secondary. </summary>
        public static CosmosDBKind Secondary { get; } = new CosmosDBKind(SecondaryValue);
        /// <summary> PrimaryReadonly. </summary>
        public static CosmosDBKind PrimaryReadonly { get; } = new CosmosDBKind(PrimaryReadonlyValue);
        /// <summary> SecondaryReadonly. </summary>
        public static CosmosDBKind SecondaryReadonly { get; } = new CosmosDBKind(SecondaryReadonlyValue);
        /// <summary> Determines if two <see cref="CosmosDBKind"/> values are the same. </summary>
        public static bool operator ==(CosmosDBKind left, CosmosDBKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBKind"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBKind left, CosmosDBKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CosmosDBKind"/>. </summary>
        public static implicit operator CosmosDBKind(string value) => new CosmosDBKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
