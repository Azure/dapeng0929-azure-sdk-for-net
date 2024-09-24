// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Documents.Models
{
    /// <summary> The SkillNames. </summary>
    public partial class SkillNames
    {
        /// <summary> Initializes a new instance of <see cref="SkillNames"/>. </summary>
        public SkillNames()
        {
            SkillNamesProperty = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SkillNames"/>. </summary>
        /// <param name="skillNamesProperty"> the names of skills to be reset. </param>
        internal SkillNames(IList<string> skillNamesProperty)
        {
            SkillNamesProperty = skillNamesProperty;
        }

        /// <summary> the names of skills to be reset. </summary>
        public IList<string> SkillNamesProperty { get; }
    }
}
