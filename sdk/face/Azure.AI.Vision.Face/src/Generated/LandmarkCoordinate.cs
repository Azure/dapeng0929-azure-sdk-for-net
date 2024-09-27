// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> The LandmarkCoordinate. </summary>
    public partial class LandmarkCoordinate
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

        /// <summary> Initializes a new instance of <see cref="LandmarkCoordinate"/>. </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        internal LandmarkCoordinate(float x, float y)
        {
            X = x;
            Y = y;
        }

        /// <summary> Initializes a new instance of <see cref="LandmarkCoordinate"/>. </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LandmarkCoordinate(float x, float y, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            X = x;
            Y = y;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LandmarkCoordinate"/> for deserialization. </summary>
        internal LandmarkCoordinate()
        {
        }

        /// <summary> Gets the x. </summary>
        public float X { get; }
        /// <summary> Gets the y. </summary>
        public float Y { get; }
    }
}
