// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> The ComputeFleetLinuxVMGuestPatchAutomaticByPlatformRebootSetting. </summary>
    public readonly partial struct ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting : IEquatable<ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string IfRequiredValue = "IfRequired";
        private const string NeverValue = "Never";
        private const string AlwaysValue = "Always";

        /// <summary> Unknown. </summary>
        public static ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting Unknown { get; } = new ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting(UnknownValue);
        /// <summary> IfRequired. </summary>
        public static ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting IfRequired { get; } = new ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting(IfRequiredValue);
        /// <summary> Never. </summary>
        public static ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting Never { get; } = new ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting(NeverValue);
        /// <summary> Always. </summary>
        public static ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting Always { get; } = new ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting(AlwaysValue);
        /// <summary> Determines if two <see cref="ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting"/> values are the same. </summary>
        public static bool operator ==(ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting left, ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting"/> values are not the same. </summary>
        public static bool operator !=(ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting left, ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting"/>. </summary>
        public static implicit operator ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting(string value) => new ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeFleetLinuxVmGuestPatchAutomaticByPlatformRebootSetting other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
