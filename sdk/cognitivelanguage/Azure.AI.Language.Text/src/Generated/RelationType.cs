// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Text
{
    /// <summary> The relationType. </summary>
    public readonly partial struct RelationType : IEquatable<RelationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RelationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RelationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AbbreviationValue = "Abbreviation";
        private const string DirectionOfBodyStructureValue = "DirectionOfBodyStructure";
        private const string DirectionOfConditionValue = "DirectionOfCondition";
        private const string DirectionOfExaminationValue = "DirectionOfExamination";
        private const string DirectionOfTreatmentValue = "DirectionOfTreatment";
        private const string DosageOfMedicationValue = "DosageOfMedication";
        private const string FormOfMedicationValue = "FormOfMedication";
        private const string FrequencyOfMedicationValue = "FrequencyOfMedication";
        private const string FrequencyOfTreatmentValue = "FrequencyOfTreatment";
        private const string QualifierOfConditionValue = "QualifierOfCondition";
        private const string RelationOfExaminationValue = "RelationOfExamination";
        private const string RouteOfMedicationValue = "RouteOfMedication";
        private const string TimeOfConditionValue = "TimeOfCondition";
        private const string TimeOfEventValue = "TimeOfEvent";
        private const string TimeOfExaminationValue = "TimeOfExamination";
        private const string TimeOfMedicationValue = "TimeOfMedication";
        private const string TimeOfTreatmentValue = "TimeOfTreatment";
        private const string UnitOfConditionValue = "UnitOfCondition";
        private const string UnitOfExaminationValue = "UnitOfExamination";
        private const string ValueOfConditionValue = "ValueOfCondition";
        private const string ValueOfExaminationValue = "ValueOfExamination";
        private const string BodySiteOfConditionValue = "BodySiteOfCondition";
        private const string BodySiteOfTreatmentValue = "BodySiteOfTreatment";
        private const string CourseOfConditionValue = "CourseOfCondition";
        private const string CourseOfExaminationValue = "CourseOfExamination";
        private const string CourseOfMedicationValue = "CourseOfMedication";
        private const string CourseOfTreatmentValue = "CourseOfTreatment";
        private const string ExaminationFindsConditionValue = "ExaminationFindsCondition";
        private const string ExpressionOfGeneValue = "ExpressionOfGene";
        private const string ExpressionOfVariantValue = "ExpressionOfVariant";
        private const string FrequencyOfConditionValue = "FrequencyOfCondition";
        private const string MutationTypeOfGeneValue = "MutationTypeOfGene";
        private const string MutationTypeOfVariantValue = "MutationTypeOfVariant";
        private const string ScaleOfConditionValue = "ScaleOfCondition";
        private const string VariantOfGeneValue = "VariantOfGene";

        /// <summary> Abbreviation. </summary>
        public static RelationType Abbreviation { get; } = new RelationType(AbbreviationValue);
        /// <summary> DirectionOfBodyStructure. </summary>
        public static RelationType DirectionOfBodyStructure { get; } = new RelationType(DirectionOfBodyStructureValue);
        /// <summary> DirectionOfCondition. </summary>
        public static RelationType DirectionOfCondition { get; } = new RelationType(DirectionOfConditionValue);
        /// <summary> DirectionOfExamination. </summary>
        public static RelationType DirectionOfExamination { get; } = new RelationType(DirectionOfExaminationValue);
        /// <summary> DirectionOfTreatment. </summary>
        public static RelationType DirectionOfTreatment { get; } = new RelationType(DirectionOfTreatmentValue);
        /// <summary> DosageOfMedication. </summary>
        public static RelationType DosageOfMedication { get; } = new RelationType(DosageOfMedicationValue);
        /// <summary> FormOfMedication. </summary>
        public static RelationType FormOfMedication { get; } = new RelationType(FormOfMedicationValue);
        /// <summary> FrequencyOfMedication. </summary>
        public static RelationType FrequencyOfMedication { get; } = new RelationType(FrequencyOfMedicationValue);
        /// <summary> FrequencyOfTreatment. </summary>
        public static RelationType FrequencyOfTreatment { get; } = new RelationType(FrequencyOfTreatmentValue);
        /// <summary> QualifierOfCondition. </summary>
        public static RelationType QualifierOfCondition { get; } = new RelationType(QualifierOfConditionValue);
        /// <summary> RelationOfExamination. </summary>
        public static RelationType RelationOfExamination { get; } = new RelationType(RelationOfExaminationValue);
        /// <summary> RouteOfMedication. </summary>
        public static RelationType RouteOfMedication { get; } = new RelationType(RouteOfMedicationValue);
        /// <summary> TimeOfCondition. </summary>
        public static RelationType TimeOfCondition { get; } = new RelationType(TimeOfConditionValue);
        /// <summary> TimeOfEvent. </summary>
        public static RelationType TimeOfEvent { get; } = new RelationType(TimeOfEventValue);
        /// <summary> TimeOfExamination. </summary>
        public static RelationType TimeOfExamination { get; } = new RelationType(TimeOfExaminationValue);
        /// <summary> TimeOfMedication. </summary>
        public static RelationType TimeOfMedication { get; } = new RelationType(TimeOfMedicationValue);
        /// <summary> TimeOfTreatment. </summary>
        public static RelationType TimeOfTreatment { get; } = new RelationType(TimeOfTreatmentValue);
        /// <summary> UnitOfCondition. </summary>
        public static RelationType UnitOfCondition { get; } = new RelationType(UnitOfConditionValue);
        /// <summary> UnitOfExamination. </summary>
        public static RelationType UnitOfExamination { get; } = new RelationType(UnitOfExaminationValue);
        /// <summary> ValueOfCondition. </summary>
        public static RelationType ValueOfCondition { get; } = new RelationType(ValueOfConditionValue);
        /// <summary> ValueOfExamination. </summary>
        public static RelationType ValueOfExamination { get; } = new RelationType(ValueOfExaminationValue);
        /// <summary> BodySiteOfCondition. </summary>
        public static RelationType BodySiteOfCondition { get; } = new RelationType(BodySiteOfConditionValue);
        /// <summary> BodySiteOfTreatment. </summary>
        public static RelationType BodySiteOfTreatment { get; } = new RelationType(BodySiteOfTreatmentValue);
        /// <summary> CourseOfCondition. </summary>
        public static RelationType CourseOfCondition { get; } = new RelationType(CourseOfConditionValue);
        /// <summary> CourseOfExamination. </summary>
        public static RelationType CourseOfExamination { get; } = new RelationType(CourseOfExaminationValue);
        /// <summary> CourseOfMedication. </summary>
        public static RelationType CourseOfMedication { get; } = new RelationType(CourseOfMedicationValue);
        /// <summary> CourseOfTreatment. </summary>
        public static RelationType CourseOfTreatment { get; } = new RelationType(CourseOfTreatmentValue);
        /// <summary> ExaminationFindsCondition. </summary>
        public static RelationType ExaminationFindsCondition { get; } = new RelationType(ExaminationFindsConditionValue);
        /// <summary> ExpressionOfGene. </summary>
        public static RelationType ExpressionOfGene { get; } = new RelationType(ExpressionOfGeneValue);
        /// <summary> ExpressionOfVariant. </summary>
        public static RelationType ExpressionOfVariant { get; } = new RelationType(ExpressionOfVariantValue);
        /// <summary> FrequencyOfCondition. </summary>
        public static RelationType FrequencyOfCondition { get; } = new RelationType(FrequencyOfConditionValue);
        /// <summary> MutationTypeOfGene. </summary>
        public static RelationType MutationTypeOfGene { get; } = new RelationType(MutationTypeOfGeneValue);
        /// <summary> MutationTypeOfVariant. </summary>
        public static RelationType MutationTypeOfVariant { get; } = new RelationType(MutationTypeOfVariantValue);
        /// <summary> ScaleOfCondition. </summary>
        public static RelationType ScaleOfCondition { get; } = new RelationType(ScaleOfConditionValue);
        /// <summary> VariantOfGene. </summary>
        public static RelationType VariantOfGene { get; } = new RelationType(VariantOfGeneValue);
        /// <summary> Determines if two <see cref="RelationType"/> values are the same. </summary>
        public static bool operator ==(RelationType left, RelationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RelationType"/> values are not the same. </summary>
        public static bool operator !=(RelationType left, RelationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RelationType"/>. </summary>
        public static implicit operator RelationType(string value) => new RelationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RelationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RelationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
