// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The format of the export being delivered. Currently only 'Csv' is supported. </summary>
    public readonly partial struct ExportFormatType : IEquatable<ExportFormatType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExportFormatType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExportFormatType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CsvValue = "Csv";

        /// <summary> Csv. </summary>
        public static ExportFormatType Csv { get; } = new ExportFormatType(CsvValue);
        /// <summary> Determines if two <see cref="ExportFormatType"/> values are the same. </summary>
        public static bool operator ==(ExportFormatType left, ExportFormatType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExportFormatType"/> values are not the same. </summary>
        public static bool operator !=(ExportFormatType left, ExportFormatType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ExportFormatType"/>. </summary>
        public static implicit operator ExportFormatType(string value) => new ExportFormatType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExportFormatType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExportFormatType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
