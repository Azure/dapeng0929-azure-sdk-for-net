// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The project's provisioning state. </summary>
    public readonly partial struct ProjectProvisioningState : IEquatable<ProjectProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProjectProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProjectProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";

        /// <summary> Deleting. </summary>
        public static ProjectProvisioningState Deleting { get; } = new ProjectProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static ProjectProvisioningState Succeeded { get; } = new ProjectProvisioningState(SucceededValue);
        /// <summary> Determines if two <see cref="ProjectProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ProjectProvisioningState left, ProjectProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProjectProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ProjectProvisioningState left, ProjectProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ProjectProvisioningState"/>. </summary>
        public static implicit operator ProjectProvisioningState(string value) => new ProjectProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProjectProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProjectProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
