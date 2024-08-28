// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> Result for each of the delta detail response. </summary>
    public partial class DeltaResult
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

        /// <summary> Initializes a new instance of <see cref="DeltaResult"/>. </summary>
        /// <param name="kind"> Shows the asset kind. </param>
        /// <param name="name"> Shows the asset name. </param>
        /// <param name="createdAt"> Shows the date when the asset was originally created. </param>
        /// <param name="updatedAt"> Shows the date when the asset was last updated, usually the date the we trying to pull up the results for. </param>
        /// <param name="state"> Shows the inventory state. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal DeltaResult(GlobalAssetType kind, string name, DateTimeOffset createdAt, DateTimeOffset updatedAt, GlobalInventoryState state)
        {
            Argument.AssertNotNull(name, nameof(name));

            Kind = kind;
            Name = name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            State = state;
        }

        /// <summary> Initializes a new instance of <see cref="DeltaResult"/>. </summary>
        /// <param name="kind"> Shows the asset kind. </param>
        /// <param name="name"> Shows the asset name. </param>
        /// <param name="createdAt"> Shows the date when the asset was originally created. </param>
        /// <param name="updatedAt"> Shows the date when the asset was last updated, usually the date the we trying to pull up the results for. </param>
        /// <param name="state"> Shows the inventory state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeltaResult(GlobalAssetType kind, string name, DateTimeOffset createdAt, DateTimeOffset updatedAt, GlobalInventoryState state, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Name = name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            State = state;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeltaResult"/> for deserialization. </summary>
        internal DeltaResult()
        {
        }

        /// <summary> Shows the asset kind. </summary>
        public GlobalAssetType Kind { get; }
        /// <summary> Shows the asset name. </summary>
        public string Name { get; }
        /// <summary> Shows the date when the asset was originally created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> Shows the date when the asset was last updated, usually the date the we trying to pull up the results for. </summary>
        public DateTimeOffset UpdatedAt { get; }
        /// <summary> Shows the inventory state. </summary>
        public GlobalInventoryState State { get; }
    }
}
