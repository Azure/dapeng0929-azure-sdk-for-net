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
    /// The model for updating storageClass properties
    /// </summary>
    public partial class StorageClassPropertiesUpdate
    {
        /// <summary>
        /// Initializes a new instance of the StorageClassPropertiesUpdate
        /// class.
        /// </summary>
        public StorageClassPropertiesUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageClassPropertiesUpdate
        /// class.
        /// </summary>
        /// <param name="allowVolumeExpansion">Volume can be expanded or not.
        /// Possible values include: 'Allow', 'Disallow'</param>
        /// <param name="mountOptions">Additional mount options</param>
        /// <param name="accessModes">The access mode: [ReadWriteOnce,
        /// ReadWriteMany] or [ReadWriteOnce]</param>
        /// <param name="dataResilience">Allow single data node failure.
        /// Possible values include: 'NotDataResilient',
        /// 'DataResilient'</param>
        /// <param name="failoverSpeed">Failover speed: NA, Slow, Fast.
        /// Possible values include: 'NotAvailable', 'Slow', 'Fast',
        /// 'Super'</param>
        /// <param name="limitations">Limitations of the storage class</param>
        /// <param name="performance">Performance tier. Possible values
        /// include: 'Undefined', 'Basic', 'Standard', 'Premium',
        /// 'Ultra'</param>
        /// <param name="priority">Selection priority when multiple storage
        /// classes meet the criteria. 0: Highest, -1: Never use</param>
        /// <param name="typeProperties">New storage class type of
        /// storageClass</param>
        public StorageClassPropertiesUpdate(string allowVolumeExpansion = default(string), IList<string> mountOptions = default(IList<string>), IList<string> accessModes = default(IList<string>), string dataResilience = default(string), string failoverSpeed = default(string), IList<string> limitations = default(IList<string>), string performance = default(string), long? priority = default(long?), StorageClassTypePropertiesUpdate typeProperties = default(StorageClassTypePropertiesUpdate))
        {
            AllowVolumeExpansion = allowVolumeExpansion;
            MountOptions = mountOptions;
            AccessModes = accessModes;
            DataResilience = dataResilience;
            FailoverSpeed = failoverSpeed;
            Limitations = limitations;
            Performance = performance;
            Priority = priority;
            TypeProperties = typeProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets volume can be expanded or not. Possible values
        /// include: 'Allow', 'Disallow'
        /// </summary>
        [JsonProperty(PropertyName = "allowVolumeExpansion")]
        public string AllowVolumeExpansion { get; set; }

        /// <summary>
        /// Gets or sets additional mount options
        /// </summary>
        [JsonProperty(PropertyName = "mountOptions")]
        public IList<string> MountOptions { get; set; }

        /// <summary>
        /// Gets or sets the access mode: [ReadWriteOnce, ReadWriteMany] or
        /// [ReadWriteOnce]
        /// </summary>
        [JsonProperty(PropertyName = "accessModes")]
        public IList<string> AccessModes { get; set; }

        /// <summary>
        /// Gets or sets allow single data node failure. Possible values
        /// include: 'NotDataResilient', 'DataResilient'
        /// </summary>
        [JsonProperty(PropertyName = "dataResilience")]
        public string DataResilience { get; set; }

        /// <summary>
        /// Gets or sets failover speed: NA, Slow, Fast. Possible values
        /// include: 'NotAvailable', 'Slow', 'Fast', 'Super'
        /// </summary>
        [JsonProperty(PropertyName = "failoverSpeed")]
        public string FailoverSpeed { get; set; }

        /// <summary>
        /// Gets or sets limitations of the storage class
        /// </summary>
        [JsonProperty(PropertyName = "limitations")]
        public IList<string> Limitations { get; set; }

        /// <summary>
        /// Gets or sets performance tier. Possible values include:
        /// 'Undefined', 'Basic', 'Standard', 'Premium', 'Ultra'
        /// </summary>
        [JsonProperty(PropertyName = "performance")]
        public string Performance { get; set; }

        /// <summary>
        /// Gets or sets selection priority when multiple storage classes meet
        /// the criteria. 0: Highest, -1: Never use
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public long? Priority { get; set; }

        /// <summary>
        /// Gets or sets new storage class type of storageClass
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties")]
        public StorageClassTypePropertiesUpdate TypeProperties { get; set; }

    }
}
