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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An update to database resource.
    /// </summary>
    public partial class SqlServerDatabaseUpdate
    {
        /// <summary>
        /// Initializes a new instance of the SqlServerDatabaseUpdate class.
        /// </summary>
        public SqlServerDatabaseUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlServerDatabaseUpdate class.
        /// </summary>
        /// <param name="tags">Resource tags.</param>
        /// <param name="properties">The data controller's properties</param>
        public SqlServerDatabaseUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), SqlServerDatabaseResourceProperties properties = default(SqlServerDatabaseResourceProperties))
        {
            Tags = tags;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the data controller's properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SqlServerDatabaseResourceProperties Properties { get; set; }

    }
}
