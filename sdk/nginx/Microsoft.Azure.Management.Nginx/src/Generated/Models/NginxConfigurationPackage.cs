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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class NginxConfigurationPackage
    {
        /// <summary>
        /// Initializes a new instance of the NginxConfigurationPackage class.
        /// </summary>
        public NginxConfigurationPackage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NginxConfigurationPackage class.
        /// </summary>
        public NginxConfigurationPackage(string data = default(string), IList<string> protectedFiles = default(IList<string>))
        {
            Data = data;
            ProtectedFiles = protectedFiles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protectedFiles")]
        public IList<string> ProtectedFiles { get; set; }

    }
}
