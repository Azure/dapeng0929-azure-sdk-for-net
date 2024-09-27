// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> The DetectedLanguage. </summary>
    public partial class DetectedLanguage
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

        /// <summary> Initializes a new instance of <see cref="DetectedLanguage"/>. </summary>
        /// <param name="name"></param>
        /// <param name="iso6391Name"></param>
        /// <param name="confidenceScore"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="iso6391Name"/> is null. </exception>
        internal DetectedLanguage(string name, string iso6391Name, double confidenceScore)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(iso6391Name, nameof(iso6391Name));

            Name = name;
            Iso6391Name = iso6391Name;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Initializes a new instance of <see cref="DetectedLanguage"/>. </summary>
        /// <param name="name"></param>
        /// <param name="iso6391Name"></param>
        /// <param name="confidenceScore"></param>
        /// <param name="script"></param>
        /// <param name="scriptCode"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectedLanguage(string name, string iso6391Name, double confidenceScore, ScriptKind? script, ScriptCode? scriptCode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Iso6391Name = iso6391Name;
            ConfidenceScore = confidenceScore;
            Script = script;
            ScriptCode = scriptCode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DetectedLanguage"/> for deserialization. </summary>
        internal DetectedLanguage()
        {
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the iso 6391 name. </summary>
        public string Iso6391Name { get; }
        /// <summary> Gets the confidence score. </summary>
        public double ConfidenceScore { get; }
        /// <summary> Gets the script. </summary>
        public ScriptKind? Script { get; }
        /// <summary> Gets the script code. </summary>
        public ScriptCode? ScriptCode { get; }
    }
}
