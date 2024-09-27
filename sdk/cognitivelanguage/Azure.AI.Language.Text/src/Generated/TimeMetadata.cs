// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> The TimeMetadata. </summary>
    public partial class TimeMetadata : BaseMetadata
    {
        /// <summary> Initializes a new instance of <see cref="TimeMetadata"/>. </summary>
        internal TimeMetadata()
        {
            MetadataKind = MetadataKind.TimeMetadata;
            Dates = new ChangeTrackingList<DateValue>();
        }

        /// <summary> Initializes a new instance of <see cref="TimeMetadata"/>. </summary>
        /// <param name="metadataKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="dates"></param>
        internal TimeMetadata(MetadataKind metadataKind, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<DateValue> dates) : base(metadataKind, serializedAdditionalRawData)
        {
            Dates = dates;
        }

        /// <summary> Gets the dates. </summary>
        public IReadOnlyList<DateValue> Dates { get; }
    }
}
