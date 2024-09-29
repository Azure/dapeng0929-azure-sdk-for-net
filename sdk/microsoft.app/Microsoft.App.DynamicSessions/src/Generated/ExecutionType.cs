// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.App.DynamicSessions
{
    /// <summary> Execution Type. </summary>
    public readonly partial struct ExecutionType : IEquatable<ExecutionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExecutionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExecutionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SynchronousValue = "Synchronous";
        private const string AsynchronousValue = "Asynchronous";

        /// <summary> Synchronous. </summary>
        public static ExecutionType Synchronous { get; } = new ExecutionType(SynchronousValue);
        /// <summary> Asynchronous. </summary>
        public static ExecutionType Asynchronous { get; } = new ExecutionType(AsynchronousValue);
        /// <summary> Determines if two <see cref="ExecutionType"/> values are the same. </summary>
        public static bool operator ==(ExecutionType left, ExecutionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExecutionType"/> values are not the same. </summary>
        public static bool operator !=(ExecutionType left, ExecutionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExecutionType"/>. </summary>
        public static implicit operator ExecutionType(string value) => new ExecutionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExecutionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExecutionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
