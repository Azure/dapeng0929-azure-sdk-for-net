// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Describes the properties of a supported private link resource for the search service. For a given API version, this represents the 'supported' groupIds when creating a shared private link resource. </summary>
    public partial class SearchPrivateLinkResourceProperties
    {
        /// <summary> Initializes a new instance of SearchPrivateLinkResourceProperties. </summary>
        internal SearchPrivateLinkResourceProperties()
        {
            RequiredMembers = new ChangeTrackingList<string>();
            RequiredZoneNames = new ChangeTrackingList<string>();
            ShareablePrivateLinkResourceTypes = new ChangeTrackingList<ShareableSearchServicePrivateLinkResourceType>();
        }

        /// <summary> Initializes a new instance of SearchPrivateLinkResourceProperties. </summary>
        /// <param name="groupId"> The group ID of the private link resource. </param>
        /// <param name="requiredMembers"> The list of required members of the private link resource. </param>
        /// <param name="requiredZoneNames"> The list of required DNS zone names of the private link resource. </param>
        /// <param name="shareablePrivateLinkResourceTypes"> The list of resources that are onboarded to private link service and that are supported by search. </param>
        internal SearchPrivateLinkResourceProperties(string groupId, IReadOnlyList<string> requiredMembers, IReadOnlyList<string> requiredZoneNames, IReadOnlyList<ShareableSearchServicePrivateLinkResourceType> shareablePrivateLinkResourceTypes)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            RequiredZoneNames = requiredZoneNames;
            ShareablePrivateLinkResourceTypes = shareablePrivateLinkResourceTypes;
        }

        /// <summary> The group ID of the private link resource. </summary>
        public string GroupId { get; }
        /// <summary> The list of required members of the private link resource. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
        /// <summary> The list of required DNS zone names of the private link resource. </summary>
        public IReadOnlyList<string> RequiredZoneNames { get; }
        /// <summary> The list of resources that are onboarded to private link service and that are supported by search. </summary>
        public IReadOnlyList<ShareableSearchServicePrivateLinkResourceType> ShareablePrivateLinkResourceTypes { get; }
    }
}
