// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The health probing behavior for External Traffic Policy Cluster services. </summary>
    public readonly partial struct ClusterServiceLoadBalancerHealthProbeMode : IEquatable<ClusterServiceLoadBalancerHealthProbeMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterServiceLoadBalancerHealthProbeMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterServiceLoadBalancerHealthProbeMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceNodePortValue = "ServiceNodePort";
        private const string SharedValue = "Shared";

        /// <summary> Each External Traffic Policy Cluster service will have its own health probe targeting service nodePort. </summary>
        public static ClusterServiceLoadBalancerHealthProbeMode ServiceNodePort { get; } = new ClusterServiceLoadBalancerHealthProbeMode(ServiceNodePortValue);
        /// <summary> All External Traffic Policy Cluster services in a Standard Load Balancer will have a dedicated health probe targeting the backend nodes' kube-proxy health check port 10256. </summary>
        public static ClusterServiceLoadBalancerHealthProbeMode Shared { get; } = new ClusterServiceLoadBalancerHealthProbeMode(SharedValue);
        /// <summary> Determines if two <see cref="ClusterServiceLoadBalancerHealthProbeMode"/> values are the same. </summary>
        public static bool operator ==(ClusterServiceLoadBalancerHealthProbeMode left, ClusterServiceLoadBalancerHealthProbeMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterServiceLoadBalancerHealthProbeMode"/> values are not the same. </summary>
        public static bool operator !=(ClusterServiceLoadBalancerHealthProbeMode left, ClusterServiceLoadBalancerHealthProbeMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClusterServiceLoadBalancerHealthProbeMode"/>. </summary>
        public static implicit operator ClusterServiceLoadBalancerHealthProbeMode(string value) => new ClusterServiceLoadBalancerHealthProbeMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterServiceLoadBalancerHealthProbeMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterServiceLoadBalancerHealthProbeMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
