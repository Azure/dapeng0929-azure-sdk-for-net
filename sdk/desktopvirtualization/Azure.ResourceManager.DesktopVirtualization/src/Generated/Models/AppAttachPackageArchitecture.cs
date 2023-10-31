// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> Possible device architectures that an app attach package can be configured for. </summary>
    public readonly partial struct AppAttachPackageArchitecture : IEquatable<AppAttachPackageArchitecture>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppAttachPackageArchitecture"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppAttachPackageArchitecture(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ARMValue = "ARM";
        private const string ARM64Value = "ARM64";
        private const string X86Value = "x86";
        private const string X64Value = "x64";
        private const string NeutralValue = "Neutral";
        private const string X86A64Value = "x86a64";
        private const string ALLValue = "ALL";

        /// <summary> ARM. </summary>
        public static AppAttachPackageArchitecture ARM { get; } = new AppAttachPackageArchitecture(ARMValue);
        /// <summary> ARM64. </summary>
        public static AppAttachPackageArchitecture ARM64 { get; } = new AppAttachPackageArchitecture(ARM64Value);
        /// <summary> x86. </summary>
        public static AppAttachPackageArchitecture X86 { get; } = new AppAttachPackageArchitecture(X86Value);
        /// <summary> x64. </summary>
        public static AppAttachPackageArchitecture X64 { get; } = new AppAttachPackageArchitecture(X64Value);
        /// <summary> Neutral. </summary>
        public static AppAttachPackageArchitecture Neutral { get; } = new AppAttachPackageArchitecture(NeutralValue);
        /// <summary> x86a64. </summary>
        public static AppAttachPackageArchitecture X86A64 { get; } = new AppAttachPackageArchitecture(X86A64Value);
        /// <summary> ALL. </summary>
        public static AppAttachPackageArchitecture ALL { get; } = new AppAttachPackageArchitecture(ALLValue);
        /// <summary> Determines if two <see cref="AppAttachPackageArchitecture"/> values are the same. </summary>
        public static bool operator ==(AppAttachPackageArchitecture left, AppAttachPackageArchitecture right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppAttachPackageArchitecture"/> values are not the same. </summary>
        public static bool operator !=(AppAttachPackageArchitecture left, AppAttachPackageArchitecture right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AppAttachPackageArchitecture"/>. </summary>
        public static implicit operator AppAttachPackageArchitecture(string value) => new AppAttachPackageArchitecture(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppAttachPackageArchitecture other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppAttachPackageArchitecture other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
