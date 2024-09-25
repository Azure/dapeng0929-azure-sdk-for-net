// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> Represents a streamed image file content part within a streaming message delta chunk. </summary>
    public partial class MessageDeltaImageFileContent : MessageDeltaContent
    {
        /// <summary> Initializes a new instance of <see cref="MessageDeltaImageFileContent"/>. </summary>
        /// <param name="index"> The index of the content part of the message. </param>
        internal MessageDeltaImageFileContent(int index) : base(index)
        {
            Type = "image_file";
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaImageFileContent"/>. </summary>
        /// <param name="index"> The index of the content part of the message. </param>
        /// <param name="type"> The type of content for this content part. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="imageFile"> The image_file data. </param>
        internal MessageDeltaImageFileContent(int index, string type, IDictionary<string, BinaryData> serializedAdditionalRawData, MessageDeltaImageFileContentObject imageFile) : base(index, type, serializedAdditionalRawData)
        {
            ImageFile = imageFile;
        }

        /// <summary> Initializes a new instance of <see cref="MessageDeltaImageFileContent"/> for deserialization. </summary>
        internal MessageDeltaImageFileContent()
        {
        }

        /// <summary> The image_file data. </summary>
        public MessageDeltaImageFileContentObject ImageFile { get; }
    }
}
