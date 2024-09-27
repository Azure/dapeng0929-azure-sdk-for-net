// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Vision.Face
{
    /// <summary> The CreateRequest1. </summary>
    internal partial class CreateRequest1
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

        /// <summary> Initializes a new instance of <see cref="CreateRequest1"/>. </summary>
        /// <param name="name"> User defined name, maximum length is 128. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal CreateRequest1(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="CreateRequest1"/>. </summary>
        /// <param name="name"> User defined name, maximum length is 128. </param>
        /// <param name="userData"> Optional user defined data. Length should not exceed 16K. </param>
        /// <param name="recognitionModel"> The 'recognitionModel' associated with this face list. Supported 'recognitionModel' values include 'recognition_01', 'recognition_02, 'recognition_03', and 'recognition_04'. The default value is 'recognition_01'. 'recognition_04' is recommended since its accuracy is improved on faces wearing masks compared with 'recognition_03', and its overall accuracy is improved compared with 'recognition_01' and 'recognition_02'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateRequest1(string name, string userData, FaceRecognitionModel? recognitionModel, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            UserData = userData;
            RecognitionModel = recognitionModel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateRequest1"/> for deserialization. </summary>
        internal CreateRequest1()
        {
        }

        /// <summary> User defined name, maximum length is 128. </summary>
        public string Name { get; }
        /// <summary> Optional user defined data. Length should not exceed 16K. </summary>
        public string UserData { get; }
        /// <summary> The 'recognitionModel' associated with this face list. Supported 'recognitionModel' values include 'recognition_01', 'recognition_02, 'recognition_03', and 'recognition_04'. The default value is 'recognition_01'. 'recognition_04' is recommended since its accuracy is improved on faces wearing masks compared with 'recognition_03', and its overall accuracy is improved compared with 'recognition_01' and 'recognition_02'. </summary>
        public FaceRecognitionModel? RecognitionModel { get; }
    }
}
