// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Nginx.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Nginx.NginxPlus REST API operation.
    /// </summary>
    public partial class OperationResult
    {
        /// <summary>
        /// Initializes a new instance of the OperationResult class.
        /// </summary>
        public OperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationResult class.
        /// </summary>
        /// <param name="name">Operation name:
        /// {provider}/{resource}/{operation}</param>
        /// <param name="display">The object that represents the
        /// operation.</param>
        /// <param name="isDataAction">Indicates whether the operation is a
        /// data action</param>
        public OperationResult(string name = default(string), OperationDisplay display = default(OperationDisplay), bool? isDataAction = default(bool?))
        {
            Name = name;
            Display = display;
            IsDataAction = isDataAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation name: {provider}/{resource}/{operation}
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the object that represents the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the operation is a data action
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; set; }

    }
}
