// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Base type for normalizers.
    /// Please note <see cref="LexicalNormalizer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CustomNormalizer"/>.
    /// </summary>
    public partial class LexicalNormalizer
    {
        /// <summary> Initializes a new instance of LexicalNormalizer. </summary>
        /// <param name="name"> The name of the normalizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. It cannot end in '.microsoft' nor '.lucene', nor be named 'asciifolding', 'standard', 'lowercase', 'uppercase', or 'elision'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public LexicalNormalizer(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of LexicalNormalizer. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of normalizer. </param>
        /// <param name="name"> The name of the normalizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. It cannot end in '.microsoft' nor '.lucene', nor be named 'asciifolding', 'standard', 'lowercase', 'uppercase', or 'elision'. </param>
        internal LexicalNormalizer(string oDataType, string name)
        {
            ODataType = oDataType;
            Name = name;
        }

        /// <summary> A URI fragment specifying the type of normalizer. </summary>
        internal string ODataType { get; set; }
        /// <summary> The name of the normalizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. It cannot end in '.microsoft' nor '.lucene', nor be named 'asciifolding', 'standard', 'lowercase', 'uppercase', or 'elision'. </summary>
        public string Name { get; set; }
    }
}
