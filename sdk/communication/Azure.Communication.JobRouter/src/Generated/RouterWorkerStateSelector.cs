// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.JobRouter
{
    /// <summary> The RouterWorkerStateSelector. </summary>
    public readonly partial struct RouterWorkerStateSelector : IEquatable<RouterWorkerStateSelector>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RouterWorkerStateSelector"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RouterWorkerStateSelector(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "active";
        private const string DrainingValue = "draining";
        private const string InactiveValue = "inactive";
        private const string AllValue = "all";

        /// <summary> active. </summary>
        public static RouterWorkerStateSelector Active { get; } = new RouterWorkerStateSelector(ActiveValue);
        /// <summary> draining. </summary>
        public static RouterWorkerStateSelector Draining { get; } = new RouterWorkerStateSelector(DrainingValue);
        /// <summary> inactive. </summary>
        public static RouterWorkerStateSelector Inactive { get; } = new RouterWorkerStateSelector(InactiveValue);
        /// <summary> all. </summary>
        public static RouterWorkerStateSelector All { get; } = new RouterWorkerStateSelector(AllValue);
        /// <summary> Determines if two <see cref="RouterWorkerStateSelector"/> values are the same. </summary>
        public static bool operator ==(RouterWorkerStateSelector left, RouterWorkerStateSelector right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RouterWorkerStateSelector"/> values are not the same. </summary>
        public static bool operator !=(RouterWorkerStateSelector left, RouterWorkerStateSelector right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RouterWorkerStateSelector"/>. </summary>
        public static implicit operator RouterWorkerStateSelector(string value) => new RouterWorkerStateSelector(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RouterWorkerStateSelector other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RouterWorkerStateSelector other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
