// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents an index alias, which describes a mapping from the alias name to an index. The alias name can be used in place of the index name for supported operations. </summary>
    public partial class SearchAlias
    {
        /// <summary> Initializes a new instance of <see cref="SearchAlias"/>. </summary>
        /// <param name="name"> The name of the alias. </param>
        /// <param name="indexes"> The name of the index this alias maps to. Only one index name may be specified. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="indexes"/> is null. </exception>
        public SearchAlias(string name, IEnumerable<string> indexes)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(indexes, nameof(indexes));

            Name = name;
            Indexes = indexes.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="SearchAlias"/>. </summary>
        /// <param name="name"> The name of the alias. </param>
        /// <param name="indexes"> The name of the index this alias maps to. Only one index name may be specified. </param>
        /// <param name="eTag"> The ETag of the alias. </param>
        internal SearchAlias(string name, IList<string> indexes, string eTag)
        {
            Name = name;
            Indexes = indexes;
            ETag = eTag;
        }

        /// <summary> The name of the alias. </summary>
        public string Name { get; set; }
        /// <summary> The name of the index this alias maps to. Only one index name may be specified. </summary>
        public IList<string> Indexes { get; }
        /// <summary> The ETag of the alias. </summary>
        public string ETag { get; set; }
    }
}
