// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The Status of the copy. </summary>
    public readonly partial struct DataBoxCopyStatus : IEquatable<DataBoxCopyStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxCopyStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxCopyStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string InProgressValue = "InProgress";
        private const string CompletedValue = "Completed";
        private const string CompletedWithErrorsValue = "CompletedWithErrors";
        private const string FailedValue = "Failed";
        private const string NotReturnedValue = "NotReturned";
        private const string HardwareErrorValue = "HardwareError";
        private const string DeviceFormattedValue = "DeviceFormatted";
        private const string DeviceMetadataModifiedValue = "DeviceMetadataModified";
        private const string StorageAccountNotAccessibleValue = "StorageAccountNotAccessible";
        private const string UnsupportedDataValue = "UnsupportedData";
        private const string DriveNotReceivedValue = "DriveNotReceived";
        private const string UnsupportedDriveValue = "UnsupportedDrive";
        private const string OtherServiceErrorValue = "OtherServiceError";
        private const string OtherUserErrorValue = "OtherUserError";
        private const string DriveNotDetectedValue = "DriveNotDetected";
        private const string DriveCorruptedValue = "DriveCorrupted";
        private const string MetadataFilesModifiedOrRemovedValue = "MetadataFilesModifiedOrRemoved";

        /// <summary> Data copy hasn't started yet. </summary>
        public static DataBoxCopyStatus NotStarted { get; } = new DataBoxCopyStatus(NotStartedValue);
        /// <summary> Data copy is in progress. </summary>
        public static DataBoxCopyStatus InProgress { get; } = new DataBoxCopyStatus(InProgressValue);
        /// <summary> Data copy completed. </summary>
        public static DataBoxCopyStatus Completed { get; } = new DataBoxCopyStatus(CompletedValue);
        /// <summary> Data copy completed with errors. </summary>
        public static DataBoxCopyStatus CompletedWithErrors { get; } = new DataBoxCopyStatus(CompletedWithErrorsValue);
        /// <summary> Data copy failed. No data was copied. </summary>
        public static DataBoxCopyStatus Failed { get; } = new DataBoxCopyStatus(FailedValue);
        /// <summary> No copy triggered as device was not returned. </summary>
        public static DataBoxCopyStatus NotReturned { get; } = new DataBoxCopyStatus(NotReturnedValue);
        /// <summary> The Device has hit hardware issues. </summary>
        public static DataBoxCopyStatus HardwareError { get; } = new DataBoxCopyStatus(HardwareErrorValue);
        /// <summary> Data copy failed. The Device was formatted by user. </summary>
        public static DataBoxCopyStatus DeviceFormatted { get; } = new DataBoxCopyStatus(DeviceFormattedValue);
        /// <summary> Data copy failed. Device metadata was modified by user. </summary>
        public static DataBoxCopyStatus DeviceMetadataModified { get; } = new DataBoxCopyStatus(DeviceMetadataModifiedValue);
        /// <summary> Data copy failed. Storage Account was not accessible during copy. </summary>
        public static DataBoxCopyStatus StorageAccountNotAccessible { get; } = new DataBoxCopyStatus(StorageAccountNotAccessibleValue);
        /// <summary> Data copy failed. The Device data content is not supported. </summary>
        public static DataBoxCopyStatus UnsupportedData { get; } = new DataBoxCopyStatus(UnsupportedDataValue);
        /// <summary> No copy triggered as device was not received. </summary>
        public static DataBoxCopyStatus DriveNotReceived { get; } = new DataBoxCopyStatus(DriveNotReceivedValue);
        /// <summary> No copy triggered as device type is not supported. </summary>
        public static DataBoxCopyStatus UnsupportedDrive { get; } = new DataBoxCopyStatus(UnsupportedDriveValue);
        /// <summary> Copy failed due to service error. </summary>
        public static DataBoxCopyStatus OtherServiceError { get; } = new DataBoxCopyStatus(OtherServiceErrorValue);
        /// <summary> Copy failed due to user error. </summary>
        public static DataBoxCopyStatus OtherUserError { get; } = new DataBoxCopyStatus(OtherUserErrorValue);
        /// <summary> Copy failed due to disk detection error. </summary>
        public static DataBoxCopyStatus DriveNotDetected { get; } = new DataBoxCopyStatus(DriveNotDetectedValue);
        /// <summary> Copy failed due to corrupted drive. </summary>
        public static DataBoxCopyStatus DriveCorrupted { get; } = new DataBoxCopyStatus(DriveCorruptedValue);
        /// <summary> Copy failed due to modified or removed metadata files. </summary>
        public static DataBoxCopyStatus MetadataFilesModifiedOrRemoved { get; } = new DataBoxCopyStatus(MetadataFilesModifiedOrRemovedValue);
        /// <summary> Determines if two <see cref="DataBoxCopyStatus"/> values are the same. </summary>
        public static bool operator ==(DataBoxCopyStatus left, DataBoxCopyStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxCopyStatus"/> values are not the same. </summary>
        public static bool operator !=(DataBoxCopyStatus left, DataBoxCopyStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataBoxCopyStatus"/>. </summary>
        public static implicit operator DataBoxCopyStatus(string value) => new DataBoxCopyStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxCopyStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxCopyStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
