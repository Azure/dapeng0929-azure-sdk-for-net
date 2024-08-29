// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the ConnectionSharedKeyResult data model.
    /// SharedKey Resource .
    /// </summary>
    public partial class ConnectionSharedKeyResultData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ConnectionSharedKeyResultData"/>. </summary>
        public ConnectionSharedKeyResultData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionSharedKeyResultData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Properties of the shared key. </param>
        internal ConnectionSharedKeyResultData(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, SharedKeyProperties properties) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            Properties = properties;
        }

        /// <summary> Properties of the shared key. </summary>
        public SharedKeyProperties Properties { get; set; }
    }
}
