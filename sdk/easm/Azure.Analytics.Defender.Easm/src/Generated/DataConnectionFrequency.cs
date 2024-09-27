// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The DataConnectionFrequency. </summary>
    public readonly partial struct DataConnectionFrequency : IEquatable<DataConnectionFrequency>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataConnectionFrequency"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataConnectionFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DailyValue = "daily";
        private const string WeeklyValue = "weekly";
        private const string MonthlyValue = "monthly";

        /// <summary> daily. </summary>
        public static DataConnectionFrequency Daily { get; } = new DataConnectionFrequency(DailyValue);
        /// <summary> weekly. </summary>
        public static DataConnectionFrequency Weekly { get; } = new DataConnectionFrequency(WeeklyValue);
        /// <summary> monthly. </summary>
        public static DataConnectionFrequency Monthly { get; } = new DataConnectionFrequency(MonthlyValue);
        /// <summary> Determines if two <see cref="DataConnectionFrequency"/> values are the same. </summary>
        public static bool operator ==(DataConnectionFrequency left, DataConnectionFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataConnectionFrequency"/> values are not the same. </summary>
        public static bool operator !=(DataConnectionFrequency left, DataConnectionFrequency right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataConnectionFrequency"/>. </summary>
        public static implicit operator DataConnectionFrequency(string value) => new DataConnectionFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataConnectionFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataConnectionFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
