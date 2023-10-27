// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownSearchIndexerDataIdentity. </summary>
    internal partial class UnknownSearchIndexerDataIdentity : SearchIndexerDataIdentity
    {
        /// <summary> Initializes a new instance of UnknownSearchIndexerDataIdentity. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of identity. </param>
        internal UnknownSearchIndexerDataIdentity(string oDataType) : base(oDataType)
        {
            ODataType = oDataType ?? "Unknown";
        }
    }
}
