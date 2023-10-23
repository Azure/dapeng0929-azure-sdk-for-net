// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Properties of Cognitive Services account deployment model. (Deprecated, please use Deployment.sku instead.). </summary>
    public partial class CognitiveServicesAccountDeploymentScaleSettings
    {
        /// <summary> Initializes a new instance of CognitiveServicesAccountDeploymentScaleSettings. </summary>
        public CognitiveServicesAccountDeploymentScaleSettings()
        {
        }

        /// <summary> Initializes a new instance of CognitiveServicesAccountDeploymentScaleSettings. </summary>
        /// <param name="scaleType"> Deployment scale type. </param>
        /// <param name="capacity"> Deployment capacity. </param>
        /// <param name="activeCapacity"> Deployment active capacity. This value might be different from `capacity` if customer recently updated `capacity`. </param>
        internal CognitiveServicesAccountDeploymentScaleSettings(CognitiveServicesAccountDeploymentScaleType? scaleType, int? capacity, int? activeCapacity)
        {
            ScaleType = scaleType;
            Capacity = capacity;
            ActiveCapacity = activeCapacity;
        }

        /// <summary> Deployment scale type. </summary>
        public CognitiveServicesAccountDeploymentScaleType? ScaleType { get; set; }
        /// <summary> Deployment capacity. </summary>
        public int? Capacity { get; set; }
        /// <summary> Deployment active capacity. This value might be different from `capacity` if customer recently updated `capacity`. </summary>
        public int? ActiveCapacity { get; }
    }
}
