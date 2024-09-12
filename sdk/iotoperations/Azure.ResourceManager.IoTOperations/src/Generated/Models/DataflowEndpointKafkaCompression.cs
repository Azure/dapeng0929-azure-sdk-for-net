// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> Kafka endpoint Compression properties. </summary>
    public readonly partial struct DataflowEndpointKafkaCompression : IEquatable<DataflowEndpointKafkaCompression>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataflowEndpointKafkaCompression"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataflowEndpointKafkaCompression(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string GzipValue = "Gzip";
        private const string SnappyValue = "Snappy";
        private const string Lz4Value = "Lz4";

        /// <summary> NONE Option. </summary>
        public static DataflowEndpointKafkaCompression None { get; } = new DataflowEndpointKafkaCompression(NoneValue);
        /// <summary> Gzip Option. </summary>
        public static DataflowEndpointKafkaCompression Gzip { get; } = new DataflowEndpointKafkaCompression(GzipValue);
        /// <summary> SNAPPY Option. </summary>
        public static DataflowEndpointKafkaCompression Snappy { get; } = new DataflowEndpointKafkaCompression(SnappyValue);
        /// <summary> LZ4 Option. </summary>
        public static DataflowEndpointKafkaCompression Lz4 { get; } = new DataflowEndpointKafkaCompression(Lz4Value);
        /// <summary> Determines if two <see cref="DataflowEndpointKafkaCompression"/> values are the same. </summary>
        public static bool operator ==(DataflowEndpointKafkaCompression left, DataflowEndpointKafkaCompression right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataflowEndpointKafkaCompression"/> values are not the same. </summary>
        public static bool operator !=(DataflowEndpointKafkaCompression left, DataflowEndpointKafkaCompression right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataflowEndpointKafkaCompression"/>. </summary>
        public static implicit operator DataflowEndpointKafkaCompression(string value) => new DataflowEndpointKafkaCompression(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataflowEndpointKafkaCompression other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataflowEndpointKafkaCompression other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
