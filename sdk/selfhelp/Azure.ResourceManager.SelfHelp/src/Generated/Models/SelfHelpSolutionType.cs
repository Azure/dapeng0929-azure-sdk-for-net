// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Solution Type. </summary>
    public readonly partial struct SelfHelpSolutionType : IEquatable<SelfHelpSolutionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SelfHelpSolutionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SelfHelpSolutionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DiagnosticsValue = "Diagnostics";
        private const string SolutionsValue = "Solutions";
        private const string TroubleshootersValue = "Troubleshooters";
        private const string SelfHelpValue = "SelfHelp";

        /// <summary> Diagnostics resource type. </summary>
        public static SelfHelpSolutionType Diagnostics { get; } = new SelfHelpSolutionType(DiagnosticsValue);
        /// <summary> Solutions resource type. </summary>
        public static SelfHelpSolutionType Solutions { get; } = new SelfHelpSolutionType(SolutionsValue);
        /// <summary> Troubleshooters resource type. </summary>
        public static SelfHelpSolutionType Troubleshooters { get; } = new SelfHelpSolutionType(TroubleshootersValue);
        /// <summary> SelfHelp resource type. </summary>
        public static SelfHelpSolutionType SelfHelp { get; } = new SelfHelpSolutionType(SelfHelpValue);
        /// <summary> Determines if two <see cref="SelfHelpSolutionType"/> values are the same. </summary>
        public static bool operator ==(SelfHelpSolutionType left, SelfHelpSolutionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SelfHelpSolutionType"/> values are not the same. </summary>
        public static bool operator !=(SelfHelpSolutionType left, SelfHelpSolutionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SelfHelpSolutionType"/>. </summary>
        public static implicit operator SelfHelpSolutionType(string value) => new SelfHelpSolutionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SelfHelpSolutionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SelfHelpSolutionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
