// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// A specific representation of configurable options for Elasticsearch when using it as an Azure OpenAI chat
    /// extension.
    /// </summary>
    public partial class ElasticsearchChatExtensionConfiguration : AzureChatExtensionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ElasticsearchChatExtensionConfiguration"/>. </summary>
        /// <param name="parameters"> The parameters to use when configuring Elasticsearch®. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public ElasticsearchChatExtensionConfiguration(ElasticsearchChatExtensionParameters parameters)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            Type = AzureChatExtensionType.Elasticsearch;
            Parameters = parameters;
        }

        /// <summary> Initializes a new instance of <see cref="ElasticsearchChatExtensionConfiguration"/>. </summary>
        /// <param name="type">
        ///   The label for the type of an Azure chat extension. This typically corresponds to a matching Azure resource.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"> The parameters to use when configuring Elasticsearch®. </param>
        internal ElasticsearchChatExtensionConfiguration(AzureChatExtensionType type, IDictionary<string, BinaryData> serializedAdditionalRawData, ElasticsearchChatExtensionParameters parameters) : base(type, serializedAdditionalRawData)
        {
            Parameters = parameters;
        }

        /// <summary> Initializes a new instance of <see cref="ElasticsearchChatExtensionConfiguration"/> for deserialization. </summary>
        internal ElasticsearchChatExtensionConfiguration()
        {
        }

        /// <summary> The parameters to use when configuring Elasticsearch®. </summary>
        public ElasticsearchChatExtensionParameters Parameters { get; }
    }
}
