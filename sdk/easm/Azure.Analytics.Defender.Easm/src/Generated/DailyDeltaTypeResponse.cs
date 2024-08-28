// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> Delta response for each day. </summary>
    public partial class DailyDeltaTypeResponse : DeltaTypeResponse
    {
        /// <summary> Initializes a new instance of <see cref="DailyDeltaTypeResponse"/>. </summary>
        /// <param name="kind"> The kind of asset. </param>
        /// <param name="removed"> The amount of assets removed for one asset kind. </param>
        /// <param name="added"> The amount of assets added for one asset kind. </param>
        /// <param name="difference"> The amount of assets changed for one asset kind. </param>
        /// <param name="count"> The current number of assets for one asset kind. </param>
        internal DailyDeltaTypeResponse(GlobalAssetType kind, long removed, long added, long difference, long count) : base(kind, removed, added, difference)
        {
            Count = count;
        }

        /// <summary> Initializes a new instance of <see cref="DailyDeltaTypeResponse"/>. </summary>
        /// <param name="kind"> The kind of asset. </param>
        /// <param name="removed"> The amount of assets removed for one asset kind. </param>
        /// <param name="added"> The amount of assets added for one asset kind. </param>
        /// <param name="difference"> The amount of assets changed for one asset kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="count"> The current number of assets for one asset kind. </param>
        internal DailyDeltaTypeResponse(GlobalAssetType kind, long removed, long added, long difference, IDictionary<string, BinaryData> serializedAdditionalRawData, long count) : base(kind, removed, added, difference, serializedAdditionalRawData)
        {
            Count = count;
        }

        /// <summary> Initializes a new instance of <see cref="DailyDeltaTypeResponse"/> for deserialization. </summary>
        internal DailyDeltaTypeResponse()
        {
        }

        /// <summary> The current number of assets for one asset kind. </summary>
        public long Count { get; }
    }
}
