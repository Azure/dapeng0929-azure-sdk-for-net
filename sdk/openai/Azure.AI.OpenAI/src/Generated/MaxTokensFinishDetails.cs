// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// A structured representation of a stop reason that signifies a token limit was reached before the model could naturally
    /// complete.
    /// </summary>
    public partial class MaxTokensFinishDetails : ChatFinishDetails
    {
        /// <summary> Initializes a new instance of <see cref="MaxTokensFinishDetails"/>. </summary>
        internal MaxTokensFinishDetails()
        {
            Type = "max_tokens";
        }

        /// <summary> Initializes a new instance of <see cref="MaxTokensFinishDetails"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaxTokensFinishDetails(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }
    }
}
