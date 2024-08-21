// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> IPVS scheduler, for more information please see http://www.linuxvirtualserver.org/docs/scheduling.html. </summary>
    public readonly partial struct IPVSScheduler : IEquatable<IPVSScheduler>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IPVSScheduler"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IPVSScheduler(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RoundRobinValue = "RoundRobin";
        private const string LeastConnectionValue = "LeastConnection";

        /// <summary> Round Robin. </summary>
        public static IPVSScheduler RoundRobin { get; } = new IPVSScheduler(RoundRobinValue);
        /// <summary> Least Connection. </summary>
        public static IPVSScheduler LeastConnection { get; } = new IPVSScheduler(LeastConnectionValue);
        /// <summary> Determines if two <see cref="IPVSScheduler"/> values are the same. </summary>
        public static bool operator ==(IPVSScheduler left, IPVSScheduler right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IPVSScheduler"/> values are not the same. </summary>
        public static bool operator !=(IPVSScheduler left, IPVSScheduler right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IPVSScheduler"/>. </summary>
        public static implicit operator IPVSScheduler(string value) => new IPVSScheduler(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IPVSScheduler other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IPVSScheduler other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
