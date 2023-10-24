// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> The name of the SKU supported by Azure AI Search. </summary>
    public partial class QuotaUsageResultName
    {
        /// <summary> Initializes a new instance of QuotaUsageResultName. </summary>
        internal QuotaUsageResultName()
        {
        }

        /// <summary> Initializes a new instance of QuotaUsageResultName. </summary>
        /// <param name="value"> The SKU name supported by Azure AI Search. </param>
        /// <param name="localizedValue"> The localized string value for the SKU name. </param>
        internal QuotaUsageResultName(string value, string localizedValue)
        {
            Value = value;
            LocalizedValue = localizedValue;
        }

        /// <summary> The SKU name supported by Azure AI Search. </summary>
        public string Value { get; }
        /// <summary> The localized string value for the SKU name. </summary>
        public string LocalizedValue { get; }
    }
}
