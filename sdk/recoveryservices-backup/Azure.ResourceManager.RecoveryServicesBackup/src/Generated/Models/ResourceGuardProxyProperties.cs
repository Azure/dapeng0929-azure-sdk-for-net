// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The ResourceGuardProxyProperties. </summary>
    public partial class ResourceGuardProxyProperties
    {
        /// <summary> Initializes a new instance of ResourceGuardProxyProperties. </summary>
        /// <param name="resourceGuardResourceId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGuardResourceId"/> is null. </exception>
        public ResourceGuardProxyProperties(ResourceIdentifier resourceGuardResourceId)
        {
            Argument.AssertNotNull(resourceGuardResourceId, nameof(resourceGuardResourceId));

            ResourceGuardResourceId = resourceGuardResourceId;
            ResourceGuardOperationDetails = new ChangeTrackingList<ResourceGuardOperationDetail>();
        }

        /// <summary> Initializes a new instance of ResourceGuardProxyProperties. </summary>
        /// <param name="resourceGuardResourceId"></param>
        /// <param name="resourceGuardOperationDetails"></param>
        /// <param name="lastUpdatedOn"></param>
        /// <param name="description"></param>
        internal ResourceGuardProxyProperties(ResourceIdentifier resourceGuardResourceId, IList<ResourceGuardOperationDetail> resourceGuardOperationDetails, DateTimeOffset? lastUpdatedOn, string description)
        {
            ResourceGuardResourceId = resourceGuardResourceId;
            ResourceGuardOperationDetails = resourceGuardOperationDetails;
            LastUpdatedOn = lastUpdatedOn;
            Description = description;
        }

        /// <summary> Gets or sets the resource guard resource id. </summary>
        public ResourceIdentifier ResourceGuardResourceId { get; set; }
        /// <summary> Gets the resource guard operation details. </summary>
        public IList<ResourceGuardOperationDetail> ResourceGuardOperationDetails { get; }
        /// <summary> Gets or sets the last updated on. </summary>
        public DateTimeOffset? LastUpdatedOn { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
