// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The ListKey. </summary>
    public partial class ListKey : ConversationEntityExtraInformation
    {
        /// <summary> Initializes a new instance of <see cref="ListKey"/>. </summary>
        internal ListKey()
        {
            ExtraInformationKind = ExtraInformationKind.ListKey;
        }

        /// <summary> Initializes a new instance of <see cref="ListKey"/>. </summary>
        /// <param name="extraInformationKind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="key"></param>
        internal ListKey(ExtraInformationKind extraInformationKind, IDictionary<string, BinaryData> serializedAdditionalRawData, string key) : base(extraInformationKind, serializedAdditionalRawData)
        {
            Key = key;
        }

        /// <summary> Gets the key. </summary>
        public string Key { get; }
    }
}
