// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The AzureDataExplorerDataConnectionProperties. </summary>
    public partial class AzureDataExplorerDataConnectionProperties : DataConnectionProperties
    {
        /// <summary> Initializes a new instance of AzureDataExplorerDataConnectionProperties. </summary>
        public AzureDataExplorerDataConnectionProperties()
        {
        }

        /// <summary> Initializes a new instance of AzureDataExplorerDataConnectionProperties. </summary>
        /// <param name="clusterName"> The azure data explorer cluster name. </param>
        /// <param name="region"> The azure data explorer region. </param>
        /// <param name="databaseName"> The azure data explorer database name. </param>
        internal AzureDataExplorerDataConnectionProperties(string clusterName, string region, string databaseName)
        {
            ClusterName = clusterName;
            Region = region;
            DatabaseName = databaseName;
        }

        /// <summary> The azure data explorer cluster name. </summary>
        public string ClusterName { get; set; }
        /// <summary> The azure data explorer region. </summary>
        public string Region { get; set; }
        /// <summary> The azure data explorer database name. </summary>
        public string DatabaseName { get; set; }
    }
}
