// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The AzureDataExplorerDataConnection. </summary>
    public partial class AzureDataExplorerDataConnection : DataConnection
    {
        /// <summary> Initializes a new instance of AzureDataExplorerDataConnection. </summary>
        /// <param name="properties"> properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal AzureDataExplorerDataConnection(AzureDataExplorerDataConnectionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Kind = "azureDataExplorer";
            Properties = properties;
        }

        /// <summary> Initializes a new instance of AzureDataExplorerDataConnection. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="id"> The system generated unique id for the resource. </param>
        /// <param name="name"> The caller provided unique name for the resource. </param>
        /// <param name="displayName"> The name that can be used for display purposes. </param>
        /// <param name="content"> The type of data the data connection will transfer. </param>
        /// <param name="createdDate"> The date the data connection was created. </param>
        /// <param name="frequency"> The rate at which the data connection will receive updates. </param>
        /// <param name="frequencyOffset"> The day to update the data connection on. </param>
        /// <param name="updatedDate"> The date the data connection was last updated. </param>
        /// <param name="userUpdatedAt"> The date the data connection was last updated by user. </param>
        /// <param name="active"> An indicator of whether the data connection is active. </param>
        /// <param name="inactiveMessage"> A message that specifies details about data connection if inactive. </param>
        /// <param name="properties"> properties. </param>
        internal AzureDataExplorerDataConnection(string kind, string id, string name, string displayName, DataConnectionContent? content, DateTimeOffset? createdDate, DataConnectionFrequency? frequency, int? frequencyOffset, DateTimeOffset? updatedDate, DateTimeOffset? userUpdatedAt, bool? active, string inactiveMessage, AzureDataExplorerDataConnectionProperties properties) : base(kind, id, name, displayName, content, createdDate, frequency, frequencyOffset, updatedDate, userUpdatedAt, active, inactiveMessage)
        {
            Properties = properties;
        }

        /// <summary> properties. </summary>
        public AzureDataExplorerDataConnectionProperties Properties { get; }
    }
}
