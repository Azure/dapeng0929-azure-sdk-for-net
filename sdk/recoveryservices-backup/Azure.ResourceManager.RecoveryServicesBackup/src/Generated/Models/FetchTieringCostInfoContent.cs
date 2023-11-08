// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Base class for tiering cost request.
    /// Specific cost request types are derived from this class.
    /// Please note <see cref="FetchTieringCostInfoContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FetchTieringCostInfoForRehydrationRequest"/>, <see cref="FetchTieringCostSavingsInfoForPolicyRequest"/>, <see cref="FetchTieringCostSavingsInfoForProtectedItemRequest"/> and <see cref="FetchTieringCostSavingsInfoForVaultRequest"/>.
    /// </summary>
    public abstract partial class FetchTieringCostInfoContent
    {
        /// <summary> Initializes a new instance of FetchTieringCostInfoContent. </summary>
        /// <param name="sourceTierType"> Source tier for the request. </param>
        /// <param name="targetTierType"> target tier for the request. </param>
        protected FetchTieringCostInfoContent(RecoveryPointTierType sourceTierType, RecoveryPointTierType targetTierType)
        {
            SourceTierType = sourceTierType;
            TargetTierType = targetTierType;
        }

        /// <summary> Source tier for the request. </summary>
        public RecoveryPointTierType SourceTierType { get; }
        /// <summary> target tier for the request. </summary>
        public RecoveryPointTierType TargetTierType { get; }
        /// <summary> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </summary>
        internal string ObjectType { get; set; }
    }
}
