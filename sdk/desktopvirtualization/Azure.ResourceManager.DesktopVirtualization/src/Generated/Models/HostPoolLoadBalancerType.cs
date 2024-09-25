// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The type of the load balancer. </summary>
    public readonly partial struct HostPoolLoadBalancerType : IEquatable<HostPoolLoadBalancerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HostPoolLoadBalancerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HostPoolLoadBalancerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BreadthFirstValue = "BreadthFirst";
        private const string DepthFirstValue = "DepthFirst";
        private const string PersistentValue = "Persistent";
        private const string MultiplePersistentValue = "MultiplePersistent";

        /// <summary> BreadthFirst. </summary>
        public static HostPoolLoadBalancerType BreadthFirst { get; } = new HostPoolLoadBalancerType(BreadthFirstValue);
        /// <summary> DepthFirst. </summary>
        public static HostPoolLoadBalancerType DepthFirst { get; } = new HostPoolLoadBalancerType(DepthFirstValue);
        /// <summary> Persistent. </summary>
        public static HostPoolLoadBalancerType Persistent { get; } = new HostPoolLoadBalancerType(PersistentValue);
        /// <summary> MultiplePersistent. </summary>
        public static HostPoolLoadBalancerType MultiplePersistent { get; } = new HostPoolLoadBalancerType(MultiplePersistentValue);
        /// <summary> Determines if two <see cref="HostPoolLoadBalancerType"/> values are the same. </summary>
        public static bool operator ==(HostPoolLoadBalancerType left, HostPoolLoadBalancerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HostPoolLoadBalancerType"/> values are not the same. </summary>
        public static bool operator !=(HostPoolLoadBalancerType left, HostPoolLoadBalancerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HostPoolLoadBalancerType"/>. </summary>
        public static implicit operator HostPoolLoadBalancerType(string value) => new HostPoolLoadBalancerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HostPoolLoadBalancerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HostPoolLoadBalancerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
