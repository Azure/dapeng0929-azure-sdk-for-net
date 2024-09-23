// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Unknown version of SharedDiskReplicationProviderSpecificSettings. </summary>
    internal partial class UnknownSharedDiskReplicationProviderSpecificSettings : SharedDiskReplicationProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSharedDiskReplicationProviderSpecificSettings"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSharedDiskReplicationProviderSpecificSettings(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSharedDiskReplicationProviderSpecificSettings"/> for deserialization. </summary>
        internal UnknownSharedDiskReplicationProviderSpecificSettings()
        {
        }
    }
}
