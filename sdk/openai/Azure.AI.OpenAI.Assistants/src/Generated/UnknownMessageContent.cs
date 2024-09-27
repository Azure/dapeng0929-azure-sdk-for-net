// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> Unknown version of MessageContent. </summary>
    internal partial class UnknownMessageContent : MessageContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMessageContent"/>. </summary>
        /// <param name="type"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownMessageContent(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownMessageContent"/> for deserialization. </summary>
        internal UnknownMessageContent()
        {
        }
    }
}
