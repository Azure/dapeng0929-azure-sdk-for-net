// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Specifies the current protection state of the resource. </summary>
    public readonly partial struct CurrentProtectionState : IEquatable<CurrentProtectionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CurrentProtectionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CurrentProtectionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string NotProtectedValue = "NotProtected";
        private const string ConfiguringProtectionValue = "ConfiguringProtection";
        private const string ProtectionConfiguredValue = "ProtectionConfigured";
        private const string BackupSchedulesSuspendedValue = "BackupSchedulesSuspended";
        private const string RetentionSchedulesSuspendedValue = "RetentionSchedulesSuspended";
        private const string ProtectionStoppedValue = "ProtectionStopped";
        private const string ProtectionErrorValue = "ProtectionError";
        private const string ConfiguringProtectionFailedValue = "ConfiguringProtectionFailed";
        private const string SoftDeletingValue = "SoftDeleting";
        private const string SoftDeletedValue = "SoftDeleted";
        private const string UpdatingProtectionValue = "UpdatingProtection";

        /// <summary> Invalid. </summary>
        public static CurrentProtectionState Invalid { get; } = new CurrentProtectionState(InvalidValue);
        /// <summary> NotProtected. </summary>
        public static CurrentProtectionState NotProtected { get; } = new CurrentProtectionState(NotProtectedValue);
        /// <summary> ConfiguringProtection. </summary>
        public static CurrentProtectionState ConfiguringProtection { get; } = new CurrentProtectionState(ConfiguringProtectionValue);
        /// <summary> ProtectionConfigured. </summary>
        public static CurrentProtectionState ProtectionConfigured { get; } = new CurrentProtectionState(ProtectionConfiguredValue);
        /// <summary> BackupSchedulesSuspended. </summary>
        public static CurrentProtectionState BackupSchedulesSuspended { get; } = new CurrentProtectionState(BackupSchedulesSuspendedValue);
        /// <summary> RetentionSchedulesSuspended. </summary>
        public static CurrentProtectionState RetentionSchedulesSuspended { get; } = new CurrentProtectionState(RetentionSchedulesSuspendedValue);
        /// <summary> ProtectionStopped. </summary>
        public static CurrentProtectionState ProtectionStopped { get; } = new CurrentProtectionState(ProtectionStoppedValue);
        /// <summary> ProtectionError. </summary>
        public static CurrentProtectionState ProtectionError { get; } = new CurrentProtectionState(ProtectionErrorValue);
        /// <summary> ConfiguringProtectionFailed. </summary>
        public static CurrentProtectionState ConfiguringProtectionFailed { get; } = new CurrentProtectionState(ConfiguringProtectionFailedValue);
        /// <summary> SoftDeleting. </summary>
        public static CurrentProtectionState SoftDeleting { get; } = new CurrentProtectionState(SoftDeletingValue);
        /// <summary> SoftDeleted. </summary>
        public static CurrentProtectionState SoftDeleted { get; } = new CurrentProtectionState(SoftDeletedValue);
        /// <summary> UpdatingProtection. </summary>
        public static CurrentProtectionState UpdatingProtection { get; } = new CurrentProtectionState(UpdatingProtectionValue);
        /// <summary> Determines if two <see cref="CurrentProtectionState"/> values are the same. </summary>
        public static bool operator ==(CurrentProtectionState left, CurrentProtectionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CurrentProtectionState"/> values are not the same. </summary>
        public static bool operator !=(CurrentProtectionState left, CurrentProtectionState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="CurrentProtectionState"/>. </summary>
        public static implicit operator CurrentProtectionState(string value) => new CurrentProtectionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CurrentProtectionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CurrentProtectionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
