// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The SavedFilter. </summary>
    public partial class SavedFilter
    {
        /// <summary> Initializes a new instance of SavedFilter. </summary>
        internal SavedFilter()
        {
        }

        /// <summary> Initializes a new instance of SavedFilter. </summary>
        /// <param name="id"> The system generated unique id for the resource. </param>
        /// <param name="name"> The caller provided unique name for the resource. </param>
        /// <param name="displayName"> The name that can be used for display purposes. </param>
        /// <param name="filter"></param>
        /// <param name="description"></param>
        internal SavedFilter(string id, string name, string displayName, string filter, string description)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
            Filter = filter;
            Description = description;
        }

        /// <summary> The system generated unique id for the resource. </summary>
        public string Id { get; }
        /// <summary> The caller provided unique name for the resource. </summary>
        public string Name { get; }
        /// <summary> The name that can be used for display purposes. </summary>
        public string DisplayName { get; }
        /// <summary> Gets the filter. </summary>
        public string Filter { get; }
        /// <summary> Gets the description. </summary>
        public string Description { get; }
    }
}
