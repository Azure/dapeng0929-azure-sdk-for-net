// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Configuration of how auto upgrade will be run. </summary>
    public readonly partial struct UpgradeChannel : IEquatable<UpgradeChannel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UpgradeChannel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UpgradeChannel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StableValue = "Stable";
        private const string RapidValue = "Rapid";
        private const string NodeImageValue = "NodeImage";

        /// <summary>
        ///  Upgrades the clusters kubernetes version to the latest supported patch release on minor version N-1, where N is the latest supported minor version.
        ///  For example, if a cluster runs version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, the cluster upgrades to 1.18.6.
        /// </summary>
        public static UpgradeChannel Stable { get; } = new UpgradeChannel(StableValue);
        /// <summary> Upgrades the clusters kubernetes version to the latest supported patch release on the latest supported minor version. </summary>
        public static UpgradeChannel Rapid { get; } = new UpgradeChannel(RapidValue);
        /// <summary> Upgrade node image version of the clusters. </summary>
        public static UpgradeChannel NodeImage { get; } = new UpgradeChannel(NodeImageValue);
        /// <summary> Determines if two <see cref="UpgradeChannel"/> values are the same. </summary>
        public static bool operator ==(UpgradeChannel left, UpgradeChannel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UpgradeChannel"/> values are not the same. </summary>
        public static bool operator !=(UpgradeChannel left, UpgradeChannel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UpgradeChannel"/>. </summary>
        public static implicit operator UpgradeChannel(string value) => new UpgradeChannel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UpgradeChannel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UpgradeChannel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
