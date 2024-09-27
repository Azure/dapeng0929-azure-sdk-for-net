// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> Unknown version of MessageTemplateBindings. </summary>
    internal partial class UnknownMessageTemplateBindings : MessageTemplateBindings
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMessageTemplateBindings"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownMessageTemplateBindings(MessageTemplateBindingsKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownMessageTemplateBindings"/> for deserialization. </summary>
        internal UnknownMessageTemplateBindings()
        {
        }
    }
}
