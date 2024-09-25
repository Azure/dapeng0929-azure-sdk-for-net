// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The categories of resource that is at risk when the assessment is unhealthy. </summary>
    public readonly partial struct SecurityAssessmentResourceCategory : IEquatable<SecurityAssessmentResourceCategory>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityAssessmentResourceCategory"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityAssessmentResourceCategory(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ComputeValue = "Compute";
        private const string NetworkingValue = "Networking";
        private const string DataValue = "Data";
        private const string IdentityAndAccessValue = "IdentityAndAccess";
        private const string IotValue = "IoT";

        /// <summary> Compute. </summary>
        public static SecurityAssessmentResourceCategory Compute { get; } = new SecurityAssessmentResourceCategory(ComputeValue);
        /// <summary> Networking. </summary>
        public static SecurityAssessmentResourceCategory Networking { get; } = new SecurityAssessmentResourceCategory(NetworkingValue);
        /// <summary> Data. </summary>
        public static SecurityAssessmentResourceCategory Data { get; } = new SecurityAssessmentResourceCategory(DataValue);
        /// <summary> IdentityAndAccess. </summary>
        public static SecurityAssessmentResourceCategory IdentityAndAccess { get; } = new SecurityAssessmentResourceCategory(IdentityAndAccessValue);
        /// <summary> Determines if two <see cref="SecurityAssessmentResourceCategory"/> values are the same. </summary>
        public static bool operator ==(SecurityAssessmentResourceCategory left, SecurityAssessmentResourceCategory right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityAssessmentResourceCategory"/> values are not the same. </summary>
        public static bool operator !=(SecurityAssessmentResourceCategory left, SecurityAssessmentResourceCategory right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecurityAssessmentResourceCategory"/>. </summary>
        public static implicit operator SecurityAssessmentResourceCategory(string value) => new SecurityAssessmentResourceCategory(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityAssessmentResourceCategory other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityAssessmentResourceCategory other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
