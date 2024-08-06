// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> Represents the request data used to generate images. </summary>
    public partial class ImageGenerationOptions
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

        /// <summary> Initializes a new instance of <see cref="ImageGenerationOptions"/>. </summary>
        /// <param name="prompt"> A description of the desired images. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prompt"/> is null. </exception>
        public ImageGenerationOptions(string prompt)
        {
            Argument.AssertNotNull(prompt, nameof(prompt));

            Prompt = prompt;
        }

        /// <summary> Initializes a new instance of <see cref="ImageGenerationOptions"/>. </summary>
        /// <param name="deploymentName">
        /// The model name or Azure OpenAI model deployment name to use for image generation. If not specified, dall-e-2 will be
        /// inferred as a default.
        /// </param>
        /// <param name="prompt"> A description of the desired images. </param>
        /// <param name="imageCount">
        /// The number of images to generate.
        /// Dall-e-2 models support values between 1 and 10.
        /// Dall-e-3 models only support a value of 1.
        /// </param>
        /// <param name="size">
        /// The desired dimensions for generated images.
        /// Dall-e-2 models support 256x256, 512x512, or 1024x1024.
        /// Dall-e-3 models support 1024x1024, 1792x1024, or 1024x1792.
        /// </param>
        /// <param name="responseFormat"> The format in which image generation response items should be presented. </param>
        /// <param name="quality">
        /// The desired image generation quality level to use.
        /// Only configurable with dall-e-3 models.
        /// </param>
        /// <param name="style">
        /// The desired image generation style to use.
        /// Only configurable with dall-e-3 models.
        /// </param>
        /// <param name="user"> A unique identifier representing your end-user, which can help to monitor and detect abuse. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageGenerationOptions(string deploymentName, string prompt, int? imageCount, ImageSize? size, ImageGenerationResponseFormat? responseFormat, ImageGenerationQuality? quality, ImageGenerationStyle? style, string user, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeploymentName = deploymentName;
            Prompt = prompt;
            ImageCount = imageCount;
            Size = size;
            ResponseFormat = responseFormat;
            Quality = quality;
            Style = style;
            User = user;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ImageGenerationOptions"/> for deserialization. </summary>
        internal ImageGenerationOptions()
        {
        }

        /// <summary>
        /// The model name or Azure OpenAI model deployment name to use for image generation. If not specified, dall-e-2 will be
        /// inferred as a default.
        /// </summary>
        public string DeploymentName { get; set; }
        /// <summary> A description of the desired images. </summary>
        public string Prompt { get; set; }
        /// <summary>
        /// The number of images to generate.
        /// Dall-e-2 models support values between 1 and 10.
        /// Dall-e-3 models only support a value of 1.
        /// </summary>
        public int? ImageCount { get; set; }
        /// <summary>
        /// The desired dimensions for generated images.
        /// Dall-e-2 models support 256x256, 512x512, or 1024x1024.
        /// Dall-e-3 models support 1024x1024, 1792x1024, or 1024x1792.
        /// </summary>
        public ImageSize? Size { get; set; }
        /// <summary> The format in which image generation response items should be presented. </summary>
        public ImageGenerationResponseFormat? ResponseFormat { get; set; }
        /// <summary>
        /// The desired image generation quality level to use.
        /// Only configurable with dall-e-3 models.
        /// </summary>
        public ImageGenerationQuality? Quality { get; set; }
        /// <summary>
        /// The desired image generation style to use.
        /// Only configurable with dall-e-3 models.
        /// </summary>
        public ImageGenerationStyle? Style { get; set; }
        /// <summary> A unique identifier representing your end-user, which can help to monitor and detect abuse. </summary>
        public string User { get; set; }
    }
}
