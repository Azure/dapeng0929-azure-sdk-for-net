// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The EntityMutationResult. </summary>
    public partial class EntityMutationResult
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

        /// <summary> Initializes a new instance of <see cref="EntityMutationResult"/>. </summary>
        internal EntityMutationResult()
        {
            GuidAssignments = new ChangeTrackingDictionary<string, string>();
            MutatedEntities = new ChangeTrackingDictionary<string, IList<AtlasEntityHeader>>();
            PartialUpdatedEntities = new ChangeTrackingList<AtlasEntityHeader>();
        }

        /// <summary> Initializes a new instance of <see cref="EntityMutationResult"/>. </summary>
        /// <param name="guidAssignments"></param>
        /// <param name="mutatedEntities"></param>
        /// <param name="partialUpdatedEntities"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityMutationResult(IReadOnlyDictionary<string, string> guidAssignments, IReadOnlyDictionary<string, IList<AtlasEntityHeader>> mutatedEntities, IReadOnlyList<AtlasEntityHeader> partialUpdatedEntities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GuidAssignments = guidAssignments;
            MutatedEntities = mutatedEntities;
            PartialUpdatedEntities = partialUpdatedEntities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the guid assignments. </summary>
        public IReadOnlyDictionary<string, string> GuidAssignments { get; }
        /// <summary> Gets the mutated entities. </summary>
        public IReadOnlyDictionary<string, IList<AtlasEntityHeader>> MutatedEntities { get; }
        /// <summary> Gets the partial updated entities. </summary>
        public IReadOnlyList<AtlasEntityHeader> PartialUpdatedEntities { get; }
    }
}
