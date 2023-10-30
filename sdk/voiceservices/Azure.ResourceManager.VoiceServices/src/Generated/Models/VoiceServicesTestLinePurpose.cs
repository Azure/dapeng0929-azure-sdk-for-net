// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.VoiceServices.Models
{
    /// <summary> The purpose of the TestLine resource. </summary>
    public readonly partial struct VoiceServicesTestLinePurpose : IEquatable<VoiceServicesTestLinePurpose>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VoiceServicesTestLinePurpose"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VoiceServicesTestLinePurpose(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ManualValue = "Manual";
        private const string AutomatedValue = "Automated";

        /// <summary> The test line is used for manual testing. </summary>
        public static VoiceServicesTestLinePurpose Manual { get; } = new VoiceServicesTestLinePurpose(ManualValue);
        /// <summary> The test line is used for automated testing. </summary>
        public static VoiceServicesTestLinePurpose Automated { get; } = new VoiceServicesTestLinePurpose(AutomatedValue);
        /// <summary> Determines if two <see cref="VoiceServicesTestLinePurpose"/> values are the same. </summary>
        public static bool operator ==(VoiceServicesTestLinePurpose left, VoiceServicesTestLinePurpose right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VoiceServicesTestLinePurpose"/> values are not the same. </summary>
        public static bool operator !=(VoiceServicesTestLinePurpose left, VoiceServicesTestLinePurpose right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VoiceServicesTestLinePurpose"/>. </summary>
        public static implicit operator VoiceServicesTestLinePurpose(string value) => new VoiceServicesTestLinePurpose(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VoiceServicesTestLinePurpose other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VoiceServicesTestLinePurpose other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
