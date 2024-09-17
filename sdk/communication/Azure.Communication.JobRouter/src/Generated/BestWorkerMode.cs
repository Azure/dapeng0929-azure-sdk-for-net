// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> Jobs are distributed to the worker with the strongest abilities available. </summary>
    public partial class BestWorkerMode : DistributionMode
    {
        /// <summary> Initializes a new instance of <see cref="BestWorkerMode"/>. </summary>
        /// <param name="distributionModeKind"> The type discriminator describing a sub-type of DistributionMode. </param>
        internal BestWorkerMode(DistributionModeKind distributionModeKind) : base(distributionModeKind)
        {
            Kind = DistributionModeKind.BestWorker;
        }

        /// <summary> Initializes a new instance of <see cref="BestWorkerMode"/>. </summary>
        /// <param name="minConcurrentOffers"> Governs the minimum desired number of active concurrent offers a job can have. </param>
        /// <param name="maxConcurrentOffers"> Governs the maximum number of active concurrent offers a job can have. </param>
        /// <param name="bypassSelectors"> If set to true, then router will match workers to jobs even if they don't match label selectors. Warning: You may get workers that are not qualified for a job they are matched with if you set this variable to true. This flag is intended more for temporary usage. By default, set to false. </param>
        /// <param name="distributionModeKind"> The type discriminator describing a sub-type of DistributionMode. </param>
        /// <param name="kind"> The type discriminator describing a kind of DistributionMode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="scoringRule">
        /// Define a scoring rule to use, when calculating a score to determine the best worker. If not set, will use a default scoring formula that uses the number of job labels that the worker labels match, as well as the number of label selectors the worker labels match and/or exceed using a logistic function (https://en.wikipedia.org/wiki/Logistic_function).
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="WebhookRouterRule"/>.
        /// </param>
        /// <param name="scoringRuleOptions"> Options to configure 'scoringRule'. If not set, default values are used. </param>
        internal BestWorkerMode(int minConcurrentOffers, int maxConcurrentOffers, bool? bypassSelectors, DistributionModeKind distributionModeKind, DistributionModeKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, RouterRule scoringRule, ScoringRuleOptions scoringRuleOptions) : base(minConcurrentOffers, maxConcurrentOffers, bypassSelectors, distributionModeKind, kind, serializedAdditionalRawData)
        {
            ScoringRule = scoringRule;
            ScoringRuleOptions = scoringRuleOptions;
        }
    }
}
