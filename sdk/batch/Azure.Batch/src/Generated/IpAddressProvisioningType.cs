// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Compute.Batch
{
    /// <summary> IPAddressProvisioningType enums. </summary>
    public readonly partial struct IpAddressProvisioningType : IEquatable<IpAddressProvisioningType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IpAddressProvisioningType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IpAddressProvisioningType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BatchManagedValue = "batchmanaged";
        private const string UserManagedValue = "usermanaged";
        private const string NoPublicIpAddressesValue = "nopublicipaddresses";

        /// <summary> A public IP will be created and managed by Batch. There may be multiple public IPs depending on the size of the Pool. </summary>
        public static IpAddressProvisioningType BatchManaged { get; } = new IpAddressProvisioningType(BatchManagedValue);
        /// <summary> Public IPs are provided by the user and will be used to provision the Compute Nodes. </summary>
        public static IpAddressProvisioningType UserManaged { get; } = new IpAddressProvisioningType(UserManagedValue);
        /// <summary> No public IP Address will be created. </summary>
        public static IpAddressProvisioningType NoPublicIpAddresses { get; } = new IpAddressProvisioningType(NoPublicIpAddressesValue);
        /// <summary> Determines if two <see cref="IpAddressProvisioningType"/> values are the same. </summary>
        public static bool operator ==(IpAddressProvisioningType left, IpAddressProvisioningType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IpAddressProvisioningType"/> values are not the same. </summary>
        public static bool operator !=(IpAddressProvisioningType left, IpAddressProvisioningType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IpAddressProvisioningType"/>. </summary>
        public static implicit operator IpAddressProvisioningType(string value) => new IpAddressProvisioningType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IpAddressProvisioningType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IpAddressProvisioningType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
