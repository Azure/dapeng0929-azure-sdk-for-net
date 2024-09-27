// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.ContentSafety
{
    /// <summary> The AnalyzeImageOptions. </summary>
    public partial class AnalyzeImageOptions
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeImageOptions"/>. </summary>
        /// <param name="image"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        public AnalyzeImageOptions(ContentSafetyImageData image)
        {
            Argument.AssertNotNull(image, nameof(image));

            Image = image;
            Categories = new ChangeTrackingList<ImageCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeImageOptions"/>. </summary>
        /// <param name="image"></param>
        /// <param name="categories"></param>
        /// <param name="outputType"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeImageOptions(ContentSafetyImageData image, IList<ImageCategory> categories, AnalyzeImageOutputType? outputType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Image = image;
            Categories = categories;
            OutputType = outputType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeImageOptions"/> for deserialization. </summary>
        internal AnalyzeImageOptions()
        {
        }

        /// <summary> Gets the image. </summary>
        public ContentSafetyImageData Image { get; }
        /// <summary> Gets the categories. </summary>
        public IList<ImageCategory> Categories { get; }
        /// <summary> Gets or sets the output type. </summary>
        public AnalyzeImageOutputType? OutputType { get; set; }
    }
}
