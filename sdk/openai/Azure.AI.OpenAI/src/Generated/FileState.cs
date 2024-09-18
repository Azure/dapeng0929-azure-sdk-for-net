// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> The state of the file. </summary>
    public readonly partial struct FileState : IEquatable<FileState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FileState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FileState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UploadedValue = "uploaded";
        private const string PendingValue = "pending";
        private const string RunningValue = "running";
        private const string ProcessedValue = "processed";
        private const string ErrorValue = "error";
        private const string DeletingValue = "deleting";
        private const string DeletedValue = "deleted";

        /// <summary>
        /// The file has been uploaded but it's not yet processed. This state is not returned by Azure OpenAI and exposed only for
        /// compatibility. It can be categorized as an inactive state.
        /// </summary>
        public static FileState Uploaded { get; } = new FileState(UploadedValue);
        /// <summary> The operation was created and is not queued to be processed in the future. It can be categorized as an inactive state. </summary>
        public static FileState Pending { get; } = new FileState(PendingValue);
        /// <summary> The operation has started to be processed. It can be categorized as an active state. </summary>
        public static FileState Running { get; } = new FileState(RunningValue);
        /// <summary> The operation has successfully processed and is ready for consumption. It can be categorized as a terminal state. </summary>
        public static FileState Processed { get; } = new FileState(ProcessedValue);
        /// <summary> The operation has completed processing with a failure and cannot be further consumed. It can be categorized as a terminal state. </summary>
        public static FileState Error { get; } = new FileState(ErrorValue);
        /// <summary>
        /// The entity is in the process to be deleted. This state is not returned by Azure OpenAI and exposed only for compatibility.
        /// It can be categorized as an active state.
        /// </summary>
        public static FileState Deleting { get; } = new FileState(DeletingValue);
        /// <summary>
        /// The entity has been deleted but may still be referenced by other entities predating the deletion. It can be categorized as a
        /// terminal state.
        /// </summary>
        public static FileState Deleted { get; } = new FileState(DeletedValue);
        /// <summary> Determines if two <see cref="FileState"/> values are the same. </summary>
        public static bool operator ==(FileState left, FileState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FileState"/> values are not the same. </summary>
        public static bool operator !=(FileState left, FileState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FileState"/>. </summary>
        public static implicit operator FileState(string value) => new FileState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FileState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FileState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
