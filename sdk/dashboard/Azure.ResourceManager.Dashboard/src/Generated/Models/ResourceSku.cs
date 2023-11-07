// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Dashboard.Models
{
    /// <summary> The ResourceSku. </summary>
    internal partial class ResourceSku
    {
        /// <summary> Initializes a new instance of ResourceSku. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ResourceSku(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
    }
}
