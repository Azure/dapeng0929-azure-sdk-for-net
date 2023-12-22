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
    /// The resource name object where the specified values will be full
    /// resource names of the corresponding resources in a three tier SAP
    /// system.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FullResourceName")]
    public partial class ThreeTierFullResourceNames : ThreeTierCustomResourceNames
    {
        /// <summary>
        /// Initializes a new instance of the ThreeTierFullResourceNames class.
        /// </summary>
        public ThreeTierFullResourceNames()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThreeTierFullResourceNames class.
        /// </summary>
        public ThreeTierFullResourceNames(CentralServerFullResourceNames centralServer = default(CentralServerFullResourceNames), ApplicationServerFullResourceNames applicationServer = default(ApplicationServerFullResourceNames), DatabaseServerFullResourceNames databaseServer = default(DatabaseServerFullResourceNames), SharedStorageResourceNames sharedStorage = default(SharedStorageResourceNames))
        {
            CentralServer = centralServer;
            ApplicationServer = applicationServer;
            DatabaseServer = databaseServer;
            SharedStorage = sharedStorage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "centralServer")]
        public CentralServerFullResourceNames CentralServer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicationServer")]
        public ApplicationServerFullResourceNames ApplicationServer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "databaseServer")]
        public DatabaseServerFullResourceNames DatabaseServer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharedStorage")]
        public SharedStorageResourceNames SharedStorage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CentralServer != null)
            {
                CentralServer.Validate();
            }
            if (DatabaseServer != null)
            {
                DatabaseServer.Validate();
            }
        }
    }
}
