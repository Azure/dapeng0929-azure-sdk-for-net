// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> NIC type. </summary>
    public readonly partial struct VMwareNicType : IEquatable<VMwareNicType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VMwareNicType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VMwareNicType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Vmxnet3Value = "vmxnet3";
        private const string Vmxnet2Value = "vmxnet2";
        private const string VmxnetValue = "vmxnet";
        private const string E1000Value = "e1000";
        private const string E1000EValue = "e1000e";
        private const string Pcnet32Value = "pcnet32";

        /// <summary> vmxnet3. </summary>
        public static VMwareNicType Vmxnet3 { get; } = new VMwareNicType(Vmxnet3Value);
        /// <summary> vmxnet2. </summary>
        public static VMwareNicType Vmxnet2 { get; } = new VMwareNicType(Vmxnet2Value);
        /// <summary> vmxnet. </summary>
        public static VMwareNicType Vmxnet { get; } = new VMwareNicType(VmxnetValue);
        /// <summary> e1000. </summary>
        public static VMwareNicType E1000 { get; } = new VMwareNicType(E1000Value);
        /// <summary> e1000e. </summary>
        public static VMwareNicType E1000E { get; } = new VMwareNicType(E1000EValue);
        /// <summary> pcnet32. </summary>
        public static VMwareNicType Pcnet32 { get; } = new VMwareNicType(Pcnet32Value);
        /// <summary> Determines if two <see cref="VMwareNicType"/> values are the same. </summary>
        public static bool operator ==(VMwareNicType left, VMwareNicType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VMwareNicType"/> values are not the same. </summary>
        public static bool operator !=(VMwareNicType left, VMwareNicType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VMwareNicType"/>. </summary>
        public static implicit operator VMwareNicType(string value) => new VMwareNicType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VMwareNicType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VMwareNicType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
