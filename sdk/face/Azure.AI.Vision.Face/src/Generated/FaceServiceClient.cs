// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Vision.Face
{
    // Data plane generated client.
    /// <summary> The FaceService service client. </summary>
    public partial class FaceServiceClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://cognitiveservices.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FaceServiceClient for mocking. </summary>
        protected FaceServiceClient()
        {
        }

        /// <summary> Initializes a new instance of FaceServiceClient. </summary>
        /// <param name="endpoint">
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://{resource-name}.cognitiveservices.azure.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FaceServiceClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new AzureAIVisionFaceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of FaceServiceClient. </summary>
        /// <param name="endpoint">
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://{resource-name}.cognitiveservices.azure.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FaceServiceClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new AzureAIVisionFaceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of FaceServiceClient. </summary>
        /// <param name="endpoint">
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://{resource-name}.cognitiveservices.azure.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FaceServiceClient(Uri endpoint, AzureKeyCredential credential, AzureAIVisionFaceClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new AzureAIVisionFaceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Initializes a new instance of FaceServiceClient. </summary>
        /// <param name="endpoint">
        /// Supported Cognitive Services endpoints (protocol and hostname, for example:
        /// https://{resource-name}.cognitiveservices.azure.com).
        /// </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FaceServiceClient(Uri endpoint, TokenCredential credential, AzureAIVisionFaceClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new AzureAIVisionFaceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        private FaceListClientImpl _cachedFaceListClientImpl;
        private LargeFaceListClientImpl _cachedLargeFaceListClientImpl;
        private PersonGroupClientImpl _cachedPersonGroupClientImpl;
        private LargePersonGroupClientImpl _cachedLargePersonGroupClientImpl;

        /// <summary> Initializes a new instance of FaceListClientImpl. </summary>
        public virtual FaceListClientImpl GetFaceListClientImplClient()
        {
            return Volatile.Read(ref _cachedFaceListClientImpl) ?? Interlocked.CompareExchange(ref _cachedFaceListClientImpl, new FaceListClientImpl(ClientDiagnostics, _pipeline, _keyCredential, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedFaceListClientImpl;
        }

        /// <summary> Initializes a new instance of LargeFaceListClientImpl. </summary>
        public virtual LargeFaceListClientImpl GetLargeFaceListClientImplClient()
        {
            return Volatile.Read(ref _cachedLargeFaceListClientImpl) ?? Interlocked.CompareExchange(ref _cachedLargeFaceListClientImpl, new LargeFaceListClientImpl(ClientDiagnostics, _pipeline, _keyCredential, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedLargeFaceListClientImpl;
        }

        /// <summary> Initializes a new instance of PersonGroupClientImpl. </summary>
        public virtual PersonGroupClientImpl GetPersonGroupClientImplClient()
        {
            return Volatile.Read(ref _cachedPersonGroupClientImpl) ?? Interlocked.CompareExchange(ref _cachedPersonGroupClientImpl, new PersonGroupClientImpl(ClientDiagnostics, _pipeline, _keyCredential, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedPersonGroupClientImpl;
        }

        /// <summary> Initializes a new instance of LargePersonGroupClientImpl. </summary>
        public virtual LargePersonGroupClientImpl GetLargePersonGroupClientImplClient()
        {
            return Volatile.Read(ref _cachedLargePersonGroupClientImpl) ?? Interlocked.CompareExchange(ref _cachedLargePersonGroupClientImpl, new LargePersonGroupClientImpl(ClientDiagnostics, _pipeline, _keyCredential, _tokenCredential, _endpoint, _apiVersion), null) ?? _cachedLargePersonGroupClientImpl;
        }
    }
}
