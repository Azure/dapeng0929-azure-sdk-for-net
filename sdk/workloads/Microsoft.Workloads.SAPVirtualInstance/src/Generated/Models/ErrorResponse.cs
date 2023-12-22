// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Workloads.SAPVirtualInstance.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error response
    /// </summary>
    /// <remarks>
    /// Common error response for all Azure Resource Manager APIs to return
    /// error details for failed operations. (This also follows the OData error
    /// response format.).
    /// </remarks>
    public partial class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        /// <param name="error">The error object.</param>
        public ErrorResponse(ErrorDetail error = default(ErrorDetail))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the error object.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorDetail Error { get; set; }

    }
}
