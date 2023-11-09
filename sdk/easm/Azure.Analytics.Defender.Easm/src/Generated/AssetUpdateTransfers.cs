// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> A list of asset types to cascade the updates to. </summary>
    public readonly partial struct AssetUpdateTransfers : IEquatable<AssetUpdateTransfers>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AssetUpdateTransfers"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AssetUpdateTransfers(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AsValue = "as";
        private const string ContactValue = "contact";
        private const string DomainValue = "domain";
        private const string HostValue = "host";
        private const string IpAddressValue = "ipAddress";
        private const string IpBlockValue = "ipBlock";
        private const string PageValue = "page";
        private const string SslCertValue = "sslCert";

        /// <summary> as. </summary>
        public static AssetUpdateTransfers As { get; } = new AssetUpdateTransfers(AsValue);
        /// <summary> contact. </summary>
        public static AssetUpdateTransfers Contact { get; } = new AssetUpdateTransfers(ContactValue);
        /// <summary> domain. </summary>
        public static AssetUpdateTransfers Domain { get; } = new AssetUpdateTransfers(DomainValue);
        /// <summary> host. </summary>
        public static AssetUpdateTransfers Host { get; } = new AssetUpdateTransfers(HostValue);
        /// <summary> ipAddress. </summary>
        public static AssetUpdateTransfers IpAddress { get; } = new AssetUpdateTransfers(IpAddressValue);
        /// <summary> ipBlock. </summary>
        public static AssetUpdateTransfers IpBlock { get; } = new AssetUpdateTransfers(IpBlockValue);
        /// <summary> page. </summary>
        public static AssetUpdateTransfers Page { get; } = new AssetUpdateTransfers(PageValue);
        /// <summary> sslCert. </summary>
        public static AssetUpdateTransfers SslCert { get; } = new AssetUpdateTransfers(SslCertValue);
        /// <summary> Determines if two <see cref="AssetUpdateTransfers"/> values are the same. </summary>
        public static bool operator ==(AssetUpdateTransfers left, AssetUpdateTransfers right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AssetUpdateTransfers"/> values are not the same. </summary>
        public static bool operator !=(AssetUpdateTransfers left, AssetUpdateTransfers right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AssetUpdateTransfers"/>. </summary>
        public static implicit operator AssetUpdateTransfers(string value) => new AssetUpdateTransfers(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AssetUpdateTransfers other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AssetUpdateTransfers other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
