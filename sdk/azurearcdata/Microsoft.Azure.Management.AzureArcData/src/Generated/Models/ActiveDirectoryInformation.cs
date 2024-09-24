// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureArcData.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Active Directory information that related to the resource.
    /// </summary>
    public partial class ActiveDirectoryInformation
    {
        /// <summary>
        /// Initializes a new instance of the ActiveDirectoryInformation class.
        /// </summary>
        public ActiveDirectoryInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveDirectoryInformation class.
        /// </summary>
        /// <param name="keytabInformation">Keytab information that is used for
        /// the Sql Managed Instance when Active Directory authentication is
        /// used.</param>
        public ActiveDirectoryInformation(KeytabInformation keytabInformation = default(KeytabInformation))
        {
            KeytabInformation = keytabInformation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets keytab information that is used for the Sql Managed
        /// Instance when Active Directory authentication is used.
        /// </summary>
        [JsonProperty(PropertyName = "keytabInformation")]
        public KeytabInformation KeytabInformation { get; set; }

    }
}
