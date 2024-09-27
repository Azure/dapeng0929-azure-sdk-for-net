// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace LiveMetrics
{
    /// <summary> Document type. </summary>
    internal readonly partial struct DocumentType : IEquatable<DocumentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RequestValue = "Request";
        private const string RemoteDependencyValue = "RemoteDependency";
        private const string ExceptionValue = "Exception";
        private const string EventValue = "Event";
        private const string TraceValue = "Trace";
        private const string UnknownValue = "Unknown";

        /// <summary> Represents a request telemetry type. </summary>
        public static DocumentType Request { get; } = new DocumentType(RequestValue);
        /// <summary> Represents a remote dependency telemetry type. </summary>
        public static DocumentType RemoteDependency { get; } = new DocumentType(RemoteDependencyValue);
        /// <summary> Represents an exception telemetry type. </summary>
        public static DocumentType Exception { get; } = new DocumentType(ExceptionValue);
        /// <summary> Represents an event telemetry type. </summary>
        public static DocumentType Event { get; } = new DocumentType(EventValue);
        /// <summary> Represents a trace telemetry type. </summary>
        public static DocumentType Trace { get; } = new DocumentType(TraceValue);
        /// <summary> Represents an unknown telemetry type. </summary>
        public static DocumentType Unknown { get; } = new DocumentType(UnknownValue);
        /// <summary> Determines if two <see cref="DocumentType"/> values are the same. </summary>
        public static bool operator ==(DocumentType left, DocumentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentType"/> values are not the same. </summary>
        public static bool operator !=(DocumentType left, DocumentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DocumentType"/>. </summary>
        public static implicit operator DocumentType(string value) => new DocumentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
