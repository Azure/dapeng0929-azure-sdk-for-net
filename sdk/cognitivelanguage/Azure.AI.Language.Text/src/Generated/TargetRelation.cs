// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> The TargetRelation. </summary>
    public partial class TargetRelation
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

        /// <summary> Initializes a new instance of <see cref="TargetRelation"/>. </summary>
        /// <param name="ref"></param>
        /// <param name="relationType"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="ref"/> is null. </exception>
        internal TargetRelation(string @ref, TargetRelationType relationType)
        {
            Argument.AssertNotNull(@ref, nameof(@ref));

            Ref = @ref;
            RelationType = relationType;
        }

        /// <summary> Initializes a new instance of <see cref="TargetRelation"/>. </summary>
        /// <param name="ref"></param>
        /// <param name="relationType"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetRelation(string @ref, TargetRelationType relationType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Ref = @ref;
            RelationType = relationType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TargetRelation"/> for deserialization. </summary>
        internal TargetRelation()
        {
        }

        /// <summary> Gets the ref. </summary>
        public string Ref { get; }
        /// <summary> Gets the relation type. </summary>
        public TargetRelationType RelationType { get; }
    }
}
