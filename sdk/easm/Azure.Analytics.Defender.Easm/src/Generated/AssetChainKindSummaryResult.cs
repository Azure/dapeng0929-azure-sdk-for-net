// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> A list of asset chain summaries per asset kind. </summary>
    public partial class AssetChainKindSummaryResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AssetChainKindSummaryResult"/>. </summary>
        /// <param name="kind"> The kind of asset. </param>
        /// <param name="affectedCount"> The amount of assets affected for a given asset kind. </param>
        internal AssetChainKindSummaryResult(AssetKind kind, long affectedCount)
        {
            Kind = kind;
            AffectedCount = affectedCount;
        }

        /// <summary> Initializes a new instance of <see cref="AssetChainKindSummaryResult"/>. </summary>
        /// <param name="kind"> The kind of asset. </param>
        /// <param name="affectedCount"> The amount of assets affected for a given asset kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssetChainKindSummaryResult(AssetKind kind, long affectedCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            AffectedCount = affectedCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AssetChainKindSummaryResult"/> for deserialization. </summary>
        internal AssetChainKindSummaryResult()
        {
        }

        /// <summary> The kind of asset. </summary>
        public AssetKind Kind { get; }
        /// <summary> The amount of assets affected for a given asset kind. </summary>
        public long AffectedCount { get; }
    }
}
