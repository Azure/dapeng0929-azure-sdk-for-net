// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> A statically configured chunking strategy. </summary>
    public partial class VectorStoreStaticChunkingStrategyResponse : VectorStoreChunkingStrategyResponse
    {
        /// <summary> Initializes a new instance of <see cref="VectorStoreStaticChunkingStrategyResponse"/>. </summary>
        /// <param name="static"> The options for the static chunking strategy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="static"/> is null. </exception>
        internal VectorStoreStaticChunkingStrategyResponse(VectorStoreStaticChunkingStrategyOptions @static)
        {
            Argument.AssertNotNull(@static, nameof(@static));

            Type = VectorStoreChunkingStrategyResponseType.Static;
            Static = @static;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreStaticChunkingStrategyResponse"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="static"> The options for the static chunking strategy. </param>
        internal VectorStoreStaticChunkingStrategyResponse(VectorStoreChunkingStrategyResponseType type, IDictionary<string, BinaryData> serializedAdditionalRawData, VectorStoreStaticChunkingStrategyOptions @static) : base(type, serializedAdditionalRawData)
        {
            Static = @static;
        }

        /// <summary> Initializes a new instance of <see cref="VectorStoreStaticChunkingStrategyResponse"/> for deserialization. </summary>
        internal VectorStoreStaticChunkingStrategyResponse()
        {
        }

        /// <summary> The options for the static chunking strategy. </summary>
        public VectorStoreStaticChunkingStrategyOptions Static { get; }
    }
}
