// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for CreateOrUpdate operation.
    /// </summary>
    public partial class AuthorizationsCreateOrUpdateHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AuthorizationsCreateOrUpdateHeaders class.
        /// </summary>
        public AuthorizationsCreateOrUpdateHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AuthorizationsCreateOrUpdateHeaders class.
        /// </summary>
        /// <param name="retryAfter">The Retry-After header can indicate how
        /// long the client should wait before polling the operation
        /// status.</param>
        public AuthorizationsCreateOrUpdateHeaders(int? retryAfter = default(int?))
        {
            RetryAfter = retryAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Retry-After header can indicate how long the
        /// client should wait before polling the operation status.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

    }
}
