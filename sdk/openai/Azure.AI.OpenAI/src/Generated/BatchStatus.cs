// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> The status of a batch. </summary>
    internal readonly partial struct BatchStatus : IEquatable<BatchStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BatchStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BatchStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ValidatingValue = "validating";
        private const string FailedValue = "failed";
        private const string InProgressValue = "in_progress";
        private const string FinalizingValue = "finalizing";
        private const string CompletedValue = "completed";
        private const string ExpiredValue = "expired";
        private const string CancellingValue = "cancelling";
        private const string CancelledValue = "cancelled";

        /// <summary> The input file is being validated before the batch can begin. </summary>
        public static BatchStatus Validating { get; } = new BatchStatus(ValidatingValue);
        /// <summary> The input file has failed the validation process. </summary>
        public static BatchStatus Failed { get; } = new BatchStatus(FailedValue);
        /// <summary> The input file was successfully validated and the batch is currently being executed. </summary>
        public static BatchStatus InProgress { get; } = new BatchStatus(InProgressValue);
        /// <summary> The batch has completed and the results are being prepared. </summary>
        public static BatchStatus Finalizing { get; } = new BatchStatus(FinalizingValue);
        /// <summary> The batch has been completed and the results are ready. </summary>
        public static BatchStatus Completed { get; } = new BatchStatus(CompletedValue);
        /// <summary> The batch was not able to complete within the 24-hour time window. </summary>
        public static BatchStatus Expired { get; } = new BatchStatus(ExpiredValue);
        /// <summary> Cancellation of the batch has been initiated. </summary>
        public static BatchStatus Cancelling { get; } = new BatchStatus(CancellingValue);
        /// <summary> The batch was cancelled. </summary>
        public static BatchStatus Cancelled { get; } = new BatchStatus(CancelledValue);
        /// <summary> Determines if two <see cref="BatchStatus"/> values are the same. </summary>
        public static bool operator ==(BatchStatus left, BatchStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BatchStatus"/> values are not the same. </summary>
        public static bool operator !=(BatchStatus left, BatchStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BatchStatus"/>. </summary>
        public static implicit operator BatchStatus(string value) => new BatchStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BatchStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BatchStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
