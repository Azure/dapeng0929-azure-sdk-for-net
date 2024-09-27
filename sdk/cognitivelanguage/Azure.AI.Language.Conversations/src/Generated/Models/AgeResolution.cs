// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The AgeResolution. </summary>
    public partial class AgeResolution : ResolutionBase
    {
        /// <summary> Initializes a new instance of <see cref="AgeResolution"/>. </summary>
        /// <param name="value"></param>
        /// <param name="unit"></param>
        internal AgeResolution(double value, AgeUnit unit)
        {
            ResolutionKind = ResolutionKind.AgeResolution;
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="AgeResolution"/>. </summary>
        /// <param name="resolutionKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="value"></param>
        /// <param name="unit"></param>
        internal AgeResolution(ResolutionKind resolutionKind, IDictionary<string, BinaryData> serializedAdditionalRawData, double value, AgeUnit unit) : base(resolutionKind, serializedAdditionalRawData)
        {
            Value = value;
            Unit = unit;
        }

        /// <summary> Initializes a new instance of <see cref="AgeResolution"/> for deserialization. </summary>
        internal AgeResolution()
        {
        }

        /// <summary> Gets the value. </summary>
        public double Value { get; }
        /// <summary> Gets the unit. </summary>
        public AgeUnit Unit { get; }
    }
}
