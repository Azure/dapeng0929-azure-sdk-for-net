// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> Unknown version of DistributionMode. </summary>
    internal partial class UnknownDistributionMode : DistributionMode
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDistributionMode"/>. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors"> If set to true, then router will match workers to jobs even if they don't match label selectors. Warning: You may get workers that are not qualified for a job they are matched with if you set this variable to true. This flag is intended more for temporary usage. By default, set to false. </param>
        /// <param name="distributionModeKind"> The type discriminator describing a sub-type of DistributionMode. </param>
        /// <param name="kind"> The type discriminator describing a kind of DistributionMode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDistributionMode(int minConcurrentOffers, int maxConcurrentOffers, bool? bypassSelectors, DistributionModeKind distributionModeKind, DistributionModeKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(minConcurrentOffers, maxConcurrentOffers, bypassSelectors, distributionModeKind, kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDistributionMode"/> for deserialization. </summary>
        internal UnknownDistributionMode()
        {
        }
    }
}
