// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI
{
    /// <summary> The MongoDBChatExtensionParametersFieldsMapping. </summary>
    public partial class MongoDBChatExtensionParametersFieldsMapping
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

        /// <summary> Initializes a new instance of <see cref="MongoDBChatExtensionParametersFieldsMapping"/>. </summary>
        /// <param name="contentFields"></param>
        /// <param name="vectorFields"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="contentFields"/> or <paramref name="vectorFields"/> is null. </exception>
        public MongoDBChatExtensionParametersFieldsMapping(IEnumerable<string> contentFields, IEnumerable<string> vectorFields)
        {
            Argument.AssertNotNull(contentFields, nameof(contentFields));
            Argument.AssertNotNull(vectorFields, nameof(vectorFields));

            ContentFields = contentFields.ToList();
            VectorFields = vectorFields.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBChatExtensionParametersFieldsMapping"/>. </summary>
        /// <param name="contentFields"></param>
        /// <param name="vectorFields"></param>
        /// <param name="titleField"></param>
        /// <param name="urlField"></param>
        /// <param name="filepathField"></param>
        /// <param name="contentFieldsSeparator"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBChatExtensionParametersFieldsMapping(IList<string> contentFields, IList<string> vectorFields, string titleField, string urlField, string filepathField, string contentFieldsSeparator, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContentFields = contentFields;
            VectorFields = vectorFields;
            TitleField = titleField;
            UrlField = urlField;
            FilepathField = filepathField;
            ContentFieldsSeparator = contentFieldsSeparator;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBChatExtensionParametersFieldsMapping"/> for deserialization. </summary>
        internal MongoDBChatExtensionParametersFieldsMapping()
        {
        }

        /// <summary> Gets the content fields. </summary>
        public IList<string> ContentFields { get; }
        /// <summary> Gets the vector fields. </summary>
        public IList<string> VectorFields { get; }
        /// <summary> Gets or sets the title field. </summary>
        public string TitleField { get; set; }
        /// <summary> Gets or sets the url field. </summary>
        public string UrlField { get; set; }
        /// <summary> Gets or sets the filepath field. </summary>
        public string FilepathField { get; set; }
        /// <summary> Gets or sets the content fields separator. </summary>
        public string ContentFieldsSeparator { get; set; }
    }
}
