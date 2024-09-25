// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </summary>
    public readonly partial struct ManagedServiceIdentityType : IEquatable<ManagedServiceIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagedServiceIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagedServiceIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SystemAssignedValue = "SystemAssigned";
        private const string UserAssignedValue = "UserAssigned";
        private const string SystemAssignedUserAssignedValue = "SystemAssigned, UserAssigned";

        /// <summary> None. </summary>
        public static ManagedServiceIdentityType None { get; } = new ManagedServiceIdentityType(NoneValue);
        /// <summary> SystemAssigned. </summary>
        public static ManagedServiceIdentityType SystemAssigned { get; } = new ManagedServiceIdentityType(SystemAssignedValue);
        /// <summary> UserAssigned. </summary>
        public static ManagedServiceIdentityType UserAssigned { get; } = new ManagedServiceIdentityType(UserAssignedValue);
        /// <summary> SystemAssigned, UserAssigned. </summary>
        public static ManagedServiceIdentityType SystemAssignedUserAssigned { get; } = new ManagedServiceIdentityType(SystemAssignedUserAssignedValue);
        /// <summary> Determines if two <see cref="ManagedServiceIdentityType"/> values are the same. </summary>
        public static bool operator ==(ManagedServiceIdentityType left, ManagedServiceIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagedServiceIdentityType"/> values are not the same. </summary>
        public static bool operator !=(ManagedServiceIdentityType left, ManagedServiceIdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagedServiceIdentityType"/>. </summary>
        public static implicit operator ManagedServiceIdentityType(string value) => new ManagedServiceIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagedServiceIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagedServiceIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
