// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.VoiceServices.Provisioning
{
    /// <summary> Possible values for DNS provisioning state of Teams Direct Routing domains. </summary>
    public readonly partial struct TeamsDirectRoutingSubdomainProvisioningStatus : IEquatable<TeamsDirectRoutingSubdomainProvisioningStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TeamsDirectRoutingSubdomainProvisioningStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TeamsDirectRoutingSubdomainProvisioningStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ProvisionedValue = "provisioned";
        private const string NotProvisionedValue = "notProvisioned";
        private const string InconsistentValue = "inconsistent";

        /// <summary> The DNS provisioning state Provisioned. </summary>
        public static TeamsDirectRoutingSubdomainProvisioningStatus Provisioned { get; } = new TeamsDirectRoutingSubdomainProvisioningStatus(ProvisionedValue);
        /// <summary> The DNS provisioning state Not Provisioned. </summary>
        public static TeamsDirectRoutingSubdomainProvisioningStatus NotProvisioned { get; } = new TeamsDirectRoutingSubdomainProvisioningStatus(NotProvisionedValue);
        /// <summary> The DNS provisioning state Inconsistent. </summary>
        public static TeamsDirectRoutingSubdomainProvisioningStatus Inconsistent { get; } = new TeamsDirectRoutingSubdomainProvisioningStatus(InconsistentValue);
        /// <summary> Determines if two <see cref="TeamsDirectRoutingSubdomainProvisioningStatus"/> values are the same. </summary>
        public static bool operator ==(TeamsDirectRoutingSubdomainProvisioningStatus left, TeamsDirectRoutingSubdomainProvisioningStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TeamsDirectRoutingSubdomainProvisioningStatus"/> values are not the same. </summary>
        public static bool operator !=(TeamsDirectRoutingSubdomainProvisioningStatus left, TeamsDirectRoutingSubdomainProvisioningStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TeamsDirectRoutingSubdomainProvisioningStatus"/>. </summary>
        public static implicit operator TeamsDirectRoutingSubdomainProvisioningStatus(string value) => new TeamsDirectRoutingSubdomainProvisioningStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TeamsDirectRoutingSubdomainProvisioningStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TeamsDirectRoutingSubdomainProvisioningStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
