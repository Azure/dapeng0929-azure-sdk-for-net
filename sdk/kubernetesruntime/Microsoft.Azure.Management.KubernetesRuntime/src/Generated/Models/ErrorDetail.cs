// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KubernetesRuntime.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The error detail.
    /// </summary>
    public partial class ErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        public ErrorDetail()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetail class.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="message">The error message.</param>
        /// <param name="target">The error target.</param>
        /// <param name="details">The error details.</param>
        /// <param name="additionalInfo">The error additional info.</param>
        public ErrorDetail(string code = default(string), string message = default(string), string target = default(string), IList<ErrorDetail> details = default(IList<ErrorDetail>), IList<ErrorAdditionalInfo> additionalInfo = default(IList<ErrorAdditionalInfo>))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            AdditionalInfo = additionalInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the error target.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; private set; }

        /// <summary>
        /// Gets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorDetail> Details { get; private set; }

        /// <summary>
        /// Gets the error additional info.
        /// </summary>
        [JsonProperty(PropertyName = "additionalInfo")]
        public IList<ErrorAdditionalInfo> AdditionalInfo { get; private set; }

    }
}
