// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Configurations for a Function App using Flex Consumption Plan. </summary>
    public partial class FunctionFlexConsumptionTargetResourceConfigurations : TargetResourceConfigurations
    {
        /// <summary> Initializes a new instance of <see cref="FunctionFlexConsumptionTargetResourceConfigurations"/>. </summary>
        public FunctionFlexConsumptionTargetResourceConfigurations()
        {
            Kind = ResourceKind.FunctionsFlexConsumption;
            Configurations = new ChangeTrackingDictionary<string, FunctionFlexConsumptionResourceConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="FunctionFlexConsumptionTargetResourceConfigurations"/>. </summary>
        /// <param name="kind"> Kind of the resource for which the configurations apply. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="configurations"> A map of configurations for a Function app using Flex Consumption Plan. </param>
        internal FunctionFlexConsumptionTargetResourceConfigurations(ResourceKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, IDictionary<string, FunctionFlexConsumptionResourceConfiguration> configurations) : base(kind, serializedAdditionalRawData)
        {
            Configurations = configurations;
        }

        /// <summary> A map of configurations for a Function app using Flex Consumption Plan. </summary>
        public IDictionary<string, FunctionFlexConsumptionResourceConfiguration> Configurations { get; }
    }
}
