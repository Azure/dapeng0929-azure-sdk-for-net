// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> The ClinicalTrialPurpose. </summary>
    public readonly partial struct ClinicalTrialPurpose : IEquatable<ClinicalTrialPurpose>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialPurpose"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClinicalTrialPurpose(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotApplicableValue = "notApplicable";
        private const string ScreeningValue = "screening";
        private const string DiagnosticValue = "diagnostic";
        private const string PreventionValue = "prevention";
        private const string HealthServicesResearchValue = "healthServicesResearch";
        private const string TreatmentValue = "treatment";
        private const string DeviceFeasibilityValue = "deviceFeasibility";
        private const string SupportiveCareValue = "supportiveCare";
        private const string BasicScienceValue = "basicScience";
        private const string OtherValue = "other";

        /// <summary> notApplicable. </summary>
        public static ClinicalTrialPurpose NotApplicable { get; } = new ClinicalTrialPurpose(NotApplicableValue);
        /// <summary> screening. </summary>
        public static ClinicalTrialPurpose Screening { get; } = new ClinicalTrialPurpose(ScreeningValue);
        /// <summary> diagnostic. </summary>
        public static ClinicalTrialPurpose Diagnostic { get; } = new ClinicalTrialPurpose(DiagnosticValue);
        /// <summary> prevention. </summary>
        public static ClinicalTrialPurpose Prevention { get; } = new ClinicalTrialPurpose(PreventionValue);
        /// <summary> healthServicesResearch. </summary>
        public static ClinicalTrialPurpose HealthServicesResearch { get; } = new ClinicalTrialPurpose(HealthServicesResearchValue);
        /// <summary> treatment. </summary>
        public static ClinicalTrialPurpose Treatment { get; } = new ClinicalTrialPurpose(TreatmentValue);
        /// <summary> deviceFeasibility. </summary>
        public static ClinicalTrialPurpose DeviceFeasibility { get; } = new ClinicalTrialPurpose(DeviceFeasibilityValue);
        /// <summary> supportiveCare. </summary>
        public static ClinicalTrialPurpose SupportiveCare { get; } = new ClinicalTrialPurpose(SupportiveCareValue);
        /// <summary> basicScience. </summary>
        public static ClinicalTrialPurpose BasicScience { get; } = new ClinicalTrialPurpose(BasicScienceValue);
        /// <summary> other. </summary>
        public static ClinicalTrialPurpose Other { get; } = new ClinicalTrialPurpose(OtherValue);
        /// <summary> Determines if two <see cref="ClinicalTrialPurpose"/> values are the same. </summary>
        public static bool operator ==(ClinicalTrialPurpose left, ClinicalTrialPurpose right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClinicalTrialPurpose"/> values are not the same. </summary>
        public static bool operator !=(ClinicalTrialPurpose left, ClinicalTrialPurpose right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ClinicalTrialPurpose"/>. </summary>
        public static implicit operator ClinicalTrialPurpose(string value) => new ClinicalTrialPurpose(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClinicalTrialPurpose other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClinicalTrialPurpose other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
