// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.Inference
{
    // Data plane generated client.
    /// <summary> The ChatCompletions service client. </summary>
    public partial class ChatCompletionsClient
    {
        private const string AuthorizationHeader = "api-key";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://ml.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ChatCompletionsClient for mocking. </summary>
        protected ChatCompletionsClient()
        {
        }

        /// <summary> Initializes a new instance of ChatCompletionsClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ChatCompletionsClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new ChatCompletionsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ChatCompletionsClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ChatCompletionsClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new ChatCompletionsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ChatCompletionsClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ChatCompletionsClient(Uri endpoint, AzureKeyCredential credential, ChatCompletionsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new ChatCompletionsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Initializes a new instance of ChatCompletionsClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ChatCompletionsClient(Uri endpoint, TokenCredential credential, ChatCompletionsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new ChatCompletionsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary>
        /// Gets chat completions for the provided chat messages.
        /// Completions support a wide variety of tasks and generate text that continues from or "completes"
        /// provided prompt data. The method makes a REST API call to the `/chat/completions` route
        /// on the given endpoint.
        /// </summary>
        /// <param name="messages">
        /// The collection of context messages associated with this chat completions request.
        /// Typical usage begins with a chat message for the System role that provides instructions for
        /// the behavior of the assistant, followed by alternating messages between the User and
        /// Assistant roles.
        /// </param>
        /// <param name="frequencyPenalty">
        /// A value that influences the probability of generated tokens appearing based on their cumulative
        /// frequency in generated text.
        /// Positive values will make tokens less likely to appear as their frequency increases and
        /// decrease the likelihood of the model repeating the same statements verbatim.
        /// Supported range is [-2, 2].
        /// </param>
        /// <param name="internalShouldStreamResponse"> A value indicating whether chat completions should be streamed for this request. </param>
        /// <param name="presencePenalty">
        /// A value that influences the probability of generated tokens appearing based on their existing
        /// presence in generated text.
        /// Positive values will make tokens less likely to appear when they already exist and increase the
        /// model's likelihood to output new topics.
        /// Supported range is [-2, 2].
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature to use that controls the apparent creativity of generated completions.
        /// Higher values will make output more random while lower values will make results more focused
        /// and deterministic.
        /// It is not recommended to modify temperature and top_p for the same completions request as the
        /// interaction of these two settings is difficult to predict.
        /// Supported range is [0, 1].
        /// </param>
        /// <param name="nucleusSamplingFactor">
        /// An alternative to sampling with temperature called nucleus sampling. This value causes the
        /// model to consider the results of tokens with the provided probability mass. As an example, a
        /// value of 0.15 will cause only the tokens comprising the top 15% of probability mass to be
        /// considered.
        /// It is not recommended to modify temperature and top_p for the same completions request as the
        /// interaction of these two settings is difficult to predict.
        /// Supported range is [0, 1].
        /// </param>
        /// <param name="maxTokens"> The maximum number of tokens to generate. </param>
        /// <param name="responseFormat">
        /// The format that the model must output. Use this to enable JSON mode instead of the default text mode.
        /// Note that to enable JSON mode, some AI models may also require you to instruct the model to produce JSON
        /// via a system or user message.
        /// </param>
        /// <param name="stopSequences"> A collection of textual sequences that will end completions generation. </param>
        /// <param name="tools">
        /// A list of tools the model may request to call. Currently, only functions are supported as a tool. The model
        /// may response with a function call request and provide the input arguments in JSON format for that function.
        /// </param>
        /// <param name="toolChoice"> If specified, the model will configure which of the provided tools it can use for the chat completions response. </param>
        /// <param name="seed">
        /// If specified, the system will make a best effort to sample deterministically such that repeated requests with the
        /// same seed and parameters should return the same result. Determinism is not guaranteed.
        /// </param>
        /// <param name="model"> ID of the specific AI model to use, if more than one model is available on the endpoint. </param>
        /// <param name="extraParams">
        /// Controls what happens if extra parameters, undefined by the REST API,
        /// are passed in the JSON request payload.
        /// This sets the HTTP request header `extra-parameters`.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messages"/> is null. </exception>
        internal virtual async Task<Response<ChatCompletions>> CompleteAsync(IEnumerable<ChatRequestMessage> messages, float? frequencyPenalty = null, bool? internalShouldStreamResponse = null, float? presencePenalty = null, float? temperature = null, float? nucleusSamplingFactor = null, int? maxTokens = null, ChatCompletionsResponseFormat responseFormat = null, IEnumerable<string> stopSequences = null, IEnumerable<ChatCompletionsToolDefinition> tools = null, BinaryData toolChoice = null, long? seed = null, string model = null, ExtraParameters? extraParams = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(messages, nameof(messages));

            CompleteRequest completeRequest = new CompleteRequest(
                messages.ToList(),
                frequencyPenalty,
                internalShouldStreamResponse,
                presencePenalty,
                temperature,
                nucleusSamplingFactor,
                maxTokens,
                responseFormat,
                stopSequences?.ToList() as IReadOnlyList<string> ?? new ChangeTrackingList<string>(),
                tools?.ToList() as IReadOnlyList<ChatCompletionsToolDefinition> ?? new ChangeTrackingList<ChatCompletionsToolDefinition>(),
                toolChoice,
                seed,
                model,
                null);
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await CompleteAsync(completeRequest.ToRequestContent(), extraParams?.ToString(), context).ConfigureAwait(false);
            return Response.FromValue(ChatCompletions.FromResponse(response), response);
        }

        /// <summary>
        /// Gets chat completions for the provided chat messages.
        /// Completions support a wide variety of tasks and generate text that continues from or "completes"
        /// provided prompt data. The method makes a REST API call to the `/chat/completions` route
        /// on the given endpoint.
        /// </summary>
        /// <param name="messages">
        /// The collection of context messages associated with this chat completions request.
        /// Typical usage begins with a chat message for the System role that provides instructions for
        /// the behavior of the assistant, followed by alternating messages between the User and
        /// Assistant roles.
        /// </param>
        /// <param name="frequencyPenalty">
        /// A value that influences the probability of generated tokens appearing based on their cumulative
        /// frequency in generated text.
        /// Positive values will make tokens less likely to appear as their frequency increases and
        /// decrease the likelihood of the model repeating the same statements verbatim.
        /// Supported range is [-2, 2].
        /// </param>
        /// <param name="internalShouldStreamResponse"> A value indicating whether chat completions should be streamed for this request. </param>
        /// <param name="presencePenalty">
        /// A value that influences the probability of generated tokens appearing based on their existing
        /// presence in generated text.
        /// Positive values will make tokens less likely to appear when they already exist and increase the
        /// model's likelihood to output new topics.
        /// Supported range is [-2, 2].
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature to use that controls the apparent creativity of generated completions.
        /// Higher values will make output more random while lower values will make results more focused
        /// and deterministic.
        /// It is not recommended to modify temperature and top_p for the same completions request as the
        /// interaction of these two settings is difficult to predict.
        /// Supported range is [0, 1].
        /// </param>
        /// <param name="nucleusSamplingFactor">
        /// An alternative to sampling with temperature called nucleus sampling. This value causes the
        /// model to consider the results of tokens with the provided probability mass. As an example, a
        /// value of 0.15 will cause only the tokens comprising the top 15% of probability mass to be
        /// considered.
        /// It is not recommended to modify temperature and top_p for the same completions request as the
        /// interaction of these two settings is difficult to predict.
        /// Supported range is [0, 1].
        /// </param>
        /// <param name="maxTokens"> The maximum number of tokens to generate. </param>
        /// <param name="responseFormat">
        /// The format that the model must output. Use this to enable JSON mode instead of the default text mode.
        /// Note that to enable JSON mode, some AI models may also require you to instruct the model to produce JSON
        /// via a system or user message.
        /// </param>
        /// <param name="stopSequences"> A collection of textual sequences that will end completions generation. </param>
        /// <param name="tools">
        /// A list of tools the model may request to call. Currently, only functions are supported as a tool. The model
        /// may response with a function call request and provide the input arguments in JSON format for that function.
        /// </param>
        /// <param name="toolChoice"> If specified, the model will configure which of the provided tools it can use for the chat completions response. </param>
        /// <param name="seed">
        /// If specified, the system will make a best effort to sample deterministically such that repeated requests with the
        /// same seed and parameters should return the same result. Determinism is not guaranteed.
        /// </param>
        /// <param name="model"> ID of the specific AI model to use, if more than one model is available on the endpoint. </param>
        /// <param name="extraParams">
        /// Controls what happens if extra parameters, undefined by the REST API,
        /// are passed in the JSON request payload.
        /// This sets the HTTP request header `extra-parameters`.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messages"/> is null. </exception>
        internal virtual Response<ChatCompletions> Complete(IEnumerable<ChatRequestMessage> messages, float? frequencyPenalty = null, bool? internalShouldStreamResponse = null, float? presencePenalty = null, float? temperature = null, float? nucleusSamplingFactor = null, int? maxTokens = null, ChatCompletionsResponseFormat responseFormat = null, IEnumerable<string> stopSequences = null, IEnumerable<ChatCompletionsToolDefinition> tools = null, BinaryData toolChoice = null, long? seed = null, string model = null, ExtraParameters? extraParams = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(messages, nameof(messages));

            CompleteRequest completeRequest = new CompleteRequest(
                messages.ToList(),
                frequencyPenalty,
                internalShouldStreamResponse,
                presencePenalty,
                temperature,
                nucleusSamplingFactor,
                maxTokens,
                responseFormat,
                stopSequences?.ToList() as IReadOnlyList<string> ?? new ChangeTrackingList<string>(),
                tools?.ToList() as IReadOnlyList<ChatCompletionsToolDefinition> ?? new ChangeTrackingList<ChatCompletionsToolDefinition>(),
                toolChoice,
                seed,
                model,
                null);
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Complete(completeRequest.ToRequestContent(), extraParams?.ToString(), context);
            return Response.FromValue(ChatCompletions.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Gets chat completions for the provided chat messages.
        /// Completions support a wide variety of tasks and generate text that continues from or "completes"
        /// provided prompt data. The method makes a REST API call to the `/chat/completions` route
        /// on the given endpoint.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CompleteAsync(IEnumerable{ChatRequestMessage},float?,bool?,float?,float?,float?,int?,ChatCompletionsResponseFormat,IEnumerable{string},IEnumerable{ChatCompletionsToolDefinition},BinaryData,long?,string,ExtraParameters?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="extraParams">
        /// Controls what happens if extra parameters, undefined by the REST API,
        /// are passed in the JSON request payload.
        /// This sets the HTTP request header `extra-parameters`. Allowed values: "error" | "drop" | "pass-through"
        /// </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> CompleteAsync(RequestContent content, string extraParams = null, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ChatCompletionsClient.Complete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCompleteRequest(content, extraParams, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Gets chat completions for the provided chat messages.
        /// Completions support a wide variety of tasks and generate text that continues from or "completes"
        /// provided prompt data. The method makes a REST API call to the `/chat/completions` route
        /// on the given endpoint.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Complete(IEnumerable{ChatRequestMessage},float?,bool?,float?,float?,float?,int?,ChatCompletionsResponseFormat,IEnumerable{string},IEnumerable{ChatCompletionsToolDefinition},BinaryData,long?,string,ExtraParameters?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="extraParams">
        /// Controls what happens if extra parameters, undefined by the REST API,
        /// are passed in the JSON request payload.
        /// This sets the HTTP request header `extra-parameters`. Allowed values: "error" | "drop" | "pass-through"
        /// </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response Complete(RequestContent content, string extraParams = null, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("ChatCompletionsClient.Complete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCompleteRequest(content, extraParams, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns information about the AI model.
        /// The method makes a REST API call to the `/info` route on the given endpoint.
        /// This method will only work when using Serverless API or Managed Compute endpoint.
        /// It will not work for GitHub Models endpoint or Azure OpenAI endpoint.
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/ChatCompletionsClient.xml" path="doc/members/member[@name='GetModelInfoAsync(CancellationToken)']/*" />
        public virtual async Task<Response<ModelInfo>> GetModelInfoAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetModelInfoAsync(context).ConfigureAwait(false);
            return Response.FromValue(ModelInfo.FromResponse(response), response);
        }

        /// <summary>
        /// Returns information about the AI model.
        /// The method makes a REST API call to the `/info` route on the given endpoint.
        /// This method will only work when using Serverless API or Managed Compute endpoint.
        /// It will not work for GitHub Models endpoint or Azure OpenAI endpoint.
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/ChatCompletionsClient.xml" path="doc/members/member[@name='GetModelInfo(CancellationToken)']/*" />
        public virtual Response<ModelInfo> GetModelInfo(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetModelInfo(context);
            return Response.FromValue(ModelInfo.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Returns information about the AI model.
        /// The method makes a REST API call to the `/info` route on the given endpoint.
        /// This method will only work when using Serverless API or Managed Compute endpoint.
        /// It will not work for GitHub Models endpoint or Azure OpenAI endpoint.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetModelInfoAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ChatCompletionsClient.xml" path="doc/members/member[@name='GetModelInfoAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetModelInfoAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("ChatCompletionsClient.GetModelInfo");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetModelInfoRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Returns information about the AI model.
        /// The method makes a REST API call to the `/info` route on the given endpoint.
        /// This method will only work when using Serverless API or Managed Compute endpoint.
        /// It will not work for GitHub Models endpoint or Azure OpenAI endpoint.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetModelInfo(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/ChatCompletionsClient.xml" path="doc/members/member[@name='GetModelInfo(RequestContext)']/*" />
        public virtual Response GetModelInfo(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("ChatCompletionsClient.GetModelInfo");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetModelInfoRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCompleteRequest(RequestContent content, string extraParams, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/chat/completions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (extraParams != null)
            {
                request.Headers.Add("extra-parameters", extraParams);
            }
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetModelInfoRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/info", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
