// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> The ClinicalDocumentContentType. </summary>
    public readonly partial struct ClinicalDocumentContentType : IEquatable<ClinicalDocumentContentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClinicalDocumentContentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClinicalDocumentContentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoteValue = "note";
        private const string FhirBundleValue = "fhirBundle";
        private const string DicomValue = "dicom";
        private const string GenomicSequencingValue = "genomicSequencing";

        /// <summary> note. </summary>
        public static ClinicalDocumentContentType Note { get; } = new ClinicalDocumentContentType(NoteValue);
        /// <summary> fhirBundle. </summary>
        public static ClinicalDocumentContentType FhirBundle { get; } = new ClinicalDocumentContentType(FhirBundleValue);
        /// <summary> dicom. </summary>
        public static ClinicalDocumentContentType Dicom { get; } = new ClinicalDocumentContentType(DicomValue);
        /// <summary> genomicSequencing. </summary>
        public static ClinicalDocumentContentType GenomicSequencing { get; } = new ClinicalDocumentContentType(GenomicSequencingValue);
        /// <summary> Determines if two <see cref="ClinicalDocumentContentType"/> values are the same. </summary>
        public static bool operator ==(ClinicalDocumentContentType left, ClinicalDocumentContentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClinicalDocumentContentType"/> values are not the same. </summary>
        public static bool operator !=(ClinicalDocumentContentType left, ClinicalDocumentContentType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClinicalDocumentContentType"/>. </summary>
        public static implicit operator ClinicalDocumentContentType(string value) => new ClinicalDocumentContentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClinicalDocumentContentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClinicalDocumentContentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
