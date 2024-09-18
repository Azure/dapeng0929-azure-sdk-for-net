// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.AI.ContentSafety;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ContentSafetyClient"/>, <see cref="BlocklistClient"/> to client builder. </summary>
    public static partial class ContentSafetyClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="ContentSafetyClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint">
        /// test
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://&lt;resource-name&gt;.cognitiveservices.azure.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<ContentSafetyClient, ContentSafetyClientOptions> AddContentSafetyClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ContentSafetyClient, ContentSafetyClientOptions>((options) => new ContentSafetyClient(endpoint, credential, options));
        }

        /// <summary> Registers a <see cref="ContentSafetyClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint">
        /// test
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://&lt;resource-name&gt;.cognitiveservices.azure.com).
        /// </param>
        public static IAzureClientBuilder<ContentSafetyClient, ContentSafetyClientOptions> AddContentSafetyClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<ContentSafetyClient, ContentSafetyClientOptions>((options, cred) => new ContentSafetyClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="BlocklistClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint">
        /// test
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://&lt;resource-name&gt;.cognitiveservices.azure.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<BlocklistClient, ContentSafetyClientOptions> AddBlocklistClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<BlocklistClient, ContentSafetyClientOptions>((options) => new BlocklistClient(endpoint, credential, options));
        }

        /// <summary> Registers a <see cref="BlocklistClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint">
        /// test
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://&lt;resource-name&gt;.cognitiveservices.azure.com).
        /// </param>
        public static IAzureClientBuilder<BlocklistClient, ContentSafetyClientOptions> AddBlocklistClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<BlocklistClient, ContentSafetyClientOptions>((options, cred) => new BlocklistClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="ContentSafetyClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<ContentSafetyClient, ContentSafetyClientOptions> AddContentSafetyClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ContentSafetyClient, ContentSafetyClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="BlocklistClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<BlocklistClient, ContentSafetyClientOptions> AddBlocklistClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<BlocklistClient, ContentSafetyClientOptions>(configuration);
        }
    }
}
