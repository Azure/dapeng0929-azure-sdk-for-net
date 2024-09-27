// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MongoCluster.Models
{
    /// <summary> The MongoClusterCreateMode. </summary>
    public readonly partial struct MongoClusterCreateMode : IEquatable<MongoClusterCreateMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoClusterCreateMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoClusterCreateMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string PointInTimeRestoreValue = "PointInTimeRestore";
        private const string GeoReplicaValue = "GeoReplica";
        private const string ReplicaValue = "Replica";

        /// <summary> Default. </summary>
        public static MongoClusterCreateMode Default { get; } = new MongoClusterCreateMode(DefaultValue);
        /// <summary> PointInTimeRestore. </summary>
        public static MongoClusterCreateMode PointInTimeRestore { get; } = new MongoClusterCreateMode(PointInTimeRestoreValue);
        /// <summary> GeoReplica. </summary>
        public static MongoClusterCreateMode GeoReplica { get; } = new MongoClusterCreateMode(GeoReplicaValue);
        /// <summary> Replica. </summary>
        public static MongoClusterCreateMode Replica { get; } = new MongoClusterCreateMode(ReplicaValue);
        /// <summary> Determines if two <see cref="MongoClusterCreateMode"/> values are the same. </summary>
        public static bool operator ==(MongoClusterCreateMode left, MongoClusterCreateMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoClusterCreateMode"/> values are not the same. </summary>
        public static bool operator !=(MongoClusterCreateMode left, MongoClusterCreateMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MongoClusterCreateMode"/>. </summary>
        public static implicit operator MongoClusterCreateMode(string value) => new MongoClusterCreateMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoClusterCreateMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoClusterCreateMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
