// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The list of cognitive services accounts operation response. </summary>
    internal partial class DeploymentSkuListResult
    {
        /// <summary> Initializes a new instance of DeploymentSkuListResult. </summary>
        internal DeploymentSkuListResult()
        {
            Value = new ChangeTrackingList<SkuResource>();
        }

        /// <summary> Initializes a new instance of DeploymentSkuListResult. </summary>
        /// <param name="nextLink"> The link used to get the next page of deployment skus. </param>
        /// <param name="value"> Gets the list of Cognitive Services accounts deployment skus. </param>
        internal DeploymentSkuListResult(string nextLink, IReadOnlyList<SkuResource> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of deployment skus. </summary>
        public string NextLink { get; }
        /// <summary> Gets the list of Cognitive Services accounts deployment skus. </summary>
        public IReadOnlyList<SkuResource> Value { get; }
    }
}
