// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> The result of the operation if the operation succeeded. </summary>
    public partial class ImageGenerations
    {
        /// <summary> Initializes a new instance of ImageGenerations. </summary>
        /// <param name="created"> A timestamp when this job or item was created (in unix epochs). </param>
        /// <param name="data"> The images generated by the operator. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public ImageGenerations(DateTimeOffset created, IEnumerable<ImageLocation> data)
        {
            Argument.AssertNotNull(data, nameof(data));

            Created = created;
            Data = data.ToList();
        }

        /// <summary> Initializes a new instance of ImageGenerations. </summary>
        /// <param name="created"> A timestamp when this job or item was created (in unix epochs). </param>
        /// <param name="data"> The images generated by the operator. </param>
        internal ImageGenerations(DateTimeOffset created, IReadOnlyList<ImageLocation> data)
        {
            Created = created;
            Data = data;
        }

        /// <summary> A timestamp when this job or item was created (in unix epochs). </summary>
        public DateTimeOffset Created { get; set; }
    }
}
