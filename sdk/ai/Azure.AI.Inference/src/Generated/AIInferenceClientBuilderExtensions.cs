// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.AI.Inference;
using Azure.Core.Extensions;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="ChatCompletionsClient"/>, <see cref="EmbeddingsClient"/> to client builder. </summary>
    public static partial class AIInferenceClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="ChatCompletionsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<ChatCompletionsClient, AzureAIInferenceClientOptions> AddChatCompletionsClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<ChatCompletionsClient, AzureAIInferenceClientOptions>((options) => new ChatCompletionsClient(endpoint, credential, options));
        }

        /// <summary> Registers a <see cref="ChatCompletionsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        public static IAzureClientBuilder<ChatCompletionsClient, AzureAIInferenceClientOptions> AddChatCompletionsClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<ChatCompletionsClient, AzureAIInferenceClientOptions>((options, cred) => new ChatCompletionsClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="EmbeddingsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        public static IAzureClientBuilder<EmbeddingsClient, AzureAIInferenceClientOptions> AddEmbeddingsClient<TBuilder>(this TBuilder builder, Uri endpoint, AzureKeyCredential credential)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<EmbeddingsClient, AzureAIInferenceClientOptions>((options) => new EmbeddingsClient(endpoint, credential, options));
        }

        /// <summary> Registers a <see cref="EmbeddingsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        public static IAzureClientBuilder<EmbeddingsClient, AzureAIInferenceClientOptions> AddEmbeddingsClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilderWithCredential
        {
            return builder.RegisterClientFactory<EmbeddingsClient, AzureAIInferenceClientOptions>((options, cred) => new EmbeddingsClient(endpoint, cred, options));
        }

        /// <summary> Registers a <see cref="ChatCompletionsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<ChatCompletionsClient, AzureAIInferenceClientOptions> AddChatCompletionsClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<ChatCompletionsClient, AzureAIInferenceClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="EmbeddingsClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<EmbeddingsClient, AzureAIInferenceClientOptions> AddEmbeddingsClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<EmbeddingsClient, AzureAIInferenceClientOptions>(configuration);
        }
    }
}
