// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> Face resource for large face list. </summary>
    public partial class LargeFaceListFace
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

        /// <summary> Initializes a new instance of <see cref="LargeFaceListFace"/>. </summary>
        internal LargeFaceListFace()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LargeFaceListFace"/>. </summary>
        /// <param name="persistedFaceId"> Face ID of the face. </param>
        /// <param name="userData"> User-provided data attached to the face. The length limit is 1K. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LargeFaceListFace(Guid persistedFaceId, string userData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PersistedFaceId = persistedFaceId;
            UserData = userData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Face ID of the face. </summary>
        public Guid PersistedFaceId { get; }
        /// <summary> User-provided data attached to the face. The length limit is 1K. </summary>
        public string UserData { get; }
    }
}
