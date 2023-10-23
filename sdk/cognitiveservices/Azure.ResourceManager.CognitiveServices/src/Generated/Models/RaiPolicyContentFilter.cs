// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Azure OpenAI Content Filter. </summary>
    public partial class RaiPolicyContentFilter
    {
        /// <summary> Initializes a new instance of RaiPolicyContentFilter. </summary>
        public RaiPolicyContentFilter()
        {
        }

        /// <summary> Initializes a new instance of RaiPolicyContentFilter. </summary>
        /// <param name="policyName"> Name of ContentFilter. </param>
        /// <param name="enabled"> If the ContentFilter is enabled. </param>
        /// <param name="allowedContentLevel"> Level at which content is filtered. </param>
        /// <param name="blocking"> If blocking would occur. </param>
        /// <param name="source"> Content source to apply the Content Filters. </param>
        internal RaiPolicyContentFilter(string policyName, bool? enabled, AllowedContentLevel? allowedContentLevel, bool? blocking, RaiPolicyContentSource? source)
        {
            PolicyName = policyName;
            Enabled = enabled;
            AllowedContentLevel = allowedContentLevel;
            Blocking = blocking;
            Source = source;
        }

        /// <summary> Name of ContentFilter. </summary>
        public string PolicyName { get; set; }
        /// <summary> If the ContentFilter is enabled. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Level at which content is filtered. </summary>
        public AllowedContentLevel? AllowedContentLevel { get; set; }
        /// <summary> If blocking would occur. </summary>
        public bool? Blocking { get; set; }
        /// <summary> Content source to apply the Content Filters. </summary>
        public RaiPolicyContentSource? Source { get; set; }
    }
}
