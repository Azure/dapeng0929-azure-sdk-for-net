// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The ResourceGroupResourceGetQueryResultsForResourceGroupLevelPolicyAssignmentComponentPolicyStatesOptions. </summary>
    public partial class ResourceGroupResourceGetQueryResultsForResourceGroupLevelPolicyAssignmentComponentPolicyStatesOptions
    {
        /// <summary> Initializes a new instance of <see cref="ResourceGroupResourceGetQueryResultsForResourceGroupLevelPolicyAssignmentComponentPolicyStatesOptions"/>. </summary>
        /// <param name="policyAssignmentName"> Policy assignment name. </param>
        /// <param name="componentPolicyStatesResource"> The virtual resource under ComponentPolicyStates resource type. In a given time range, 'latest' represents the latest component policy state(s). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyAssignmentName"/> is null. </exception>
        public ResourceGroupResourceGetQueryResultsForResourceGroupLevelPolicyAssignmentComponentPolicyStatesOptions(string policyAssignmentName, ComponentPolicyStatesResource componentPolicyStatesResource)
        {
            Argument.AssertNotNull(policyAssignmentName, nameof(policyAssignmentName));

            PolicyAssignmentName = policyAssignmentName;
            ComponentPolicyStatesResource = componentPolicyStatesResource;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceGroupResourceGetQueryResultsForResourceGroupLevelPolicyAssignmentComponentPolicyStatesOptions"/> for deserialization. </summary>
        internal ResourceGroupResourceGetQueryResultsForResourceGroupLevelPolicyAssignmentComponentPolicyStatesOptions()
        {
        }

        /// <summary> Policy assignment name. </summary>
        public string PolicyAssignmentName { get; }
        /// <summary> The virtual resource under ComponentPolicyStates resource type. In a given time range, 'latest' represents the latest component policy state(s). </summary>
        public ComponentPolicyStatesResource ComponentPolicyStatesResource { get; }
        /// <summary> Maximum number of records to return. </summary>
        public int? Top { get; set; }
        /// <summary> Ordering expression using OData notation. One or more comma-separated column names with an optional "desc" (the default) or "asc", e.g. "$orderby=PolicyAssignmentId, ResourceId asc". </summary>
        public string OrderBy { get; set; }
        /// <summary> Select expression using OData notation. Limits the columns on each record to just those requested, e.g. "$select=PolicyAssignmentId, ResourceId". </summary>
        public string Select { get; set; }
        /// <summary> ISO 8601 formatted timestamp specifying the start time of the interval to query. When not specified, the service uses ($to - 1-day). </summary>
        public DateTimeOffset? From { get; set; }
        /// <summary> ISO 8601 formatted timestamp specifying the end time of the interval to query. When not specified, the service uses request time. </summary>
        public DateTimeOffset? To { get; set; }
        /// <summary> OData filter expression. </summary>
        public string Filter { get; set; }
        /// <summary> OData apply expression for aggregations. </summary>
        public string Apply { get; set; }
    }
}
