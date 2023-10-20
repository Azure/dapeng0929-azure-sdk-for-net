// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> The network associated with this object. </summary>
    public partial class ClusterByokEntity
    {
        /// <summary> Initializes a new instance of ClusterByokEntity. </summary>
        internal ClusterByokEntity()
        {
        }

        /// <summary> Initializes a new instance of ClusterByokEntity. </summary>
        /// <param name="id"> ID of the referred resource. </param>
        /// <param name="related"> API URL for accessing or modifying the referred object. </param>
        /// <param name="resourceName"> CRN reference to the referred resource. </param>
        internal ClusterByokEntity(string id, string related, string resourceName)
        {
            Id = id;
            Related = related;
            ResourceName = resourceName;
        }

        /// <summary> ID of the referred resource. </summary>
        public string Id { get; }
        /// <summary> API URL for accessing or modifying the referred object. </summary>
        public string Related { get; }
        /// <summary> CRN reference to the referred resource. </summary>
        public string ResourceName { get; }
    }
}
