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

namespace Azure.AI.ChatProtocol
{
    // Data plane generated sub-client.
    /// <summary> The Chat sub-client. </summary>
    public partial class Chat
    {
        private const string AuthorizationHeader = "api-key";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = Array.Empty<string>();
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Chat for mocking. </summary>
        protected Chat()
        {
        }

        /// <summary> Initializes a new instance of Chat. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        internal Chat(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, AzureKeyCredential keyCredential, TokenCredential tokenCredential, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
        }

        /// <summary> Creates a new streaming chat completion. </summary>
        /// <param name="operationRoute"> The route where the endpoint exposes the chat operations. </param>
        /// <param name="messages"> The collection of context messages associated with this completion request. </param>
        /// <param name="stream"> Indicates whether the completion is a streaming or non-streaming completion. </param>
        /// <param name="sessionState">
        /// Field that allows the chat app to store and retrieve data, the structure of such data is dependant on the backend
        /// being used. The client must send back the data in this field unchanged in subsequent requests, until the chat app
        /// sends a new one. The data in this field can be used to implement stateful services, such as remembering previous
        /// conversations or user preferences.
        /// </param>
        /// <param name="context">
        /// Context allows the chat app to receive extra parameters from the client, such as temperature, functions, or
        /// customer_info. These parameters are specific to the chat app and not understood by the generic clients.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationRoute"/> or <paramref name="messages"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationRoute"/> is an empty string, and was expected to be non-empty. </exception>
        internal virtual async Task<Response<ChatCompletionChunk>> CreateStreamingAsync(string operationRoute, IEnumerable<ChatMessage> messages, bool stream, BinaryData sessionState = null, IReadOnlyDictionary<string, BinaryData> context = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationRoute, nameof(operationRoute));
            Argument.AssertNotNull(messages, nameof(messages));

            CreateStreamingRequest createStreamingRequest = new CreateStreamingRequest(messages.ToList(), stream, sessionState, context ?? new ChangeTrackingDictionary<string, BinaryData>(), null);
            RequestContext context0 = FromCancellationToken(cancellationToken);
            Response response = await CreateStreamingAsync(operationRoute, createStreamingRequest.ToRequestContent(), context0).ConfigureAwait(false);
            return Response.FromValue(ChatCompletionChunk.FromResponse(response), response);
        }

        /// <summary> Creates a new streaming chat completion. </summary>
        /// <param name="operationRoute"> The route where the endpoint exposes the chat operations. </param>
        /// <param name="messages"> The collection of context messages associated with this completion request. </param>
        /// <param name="stream"> Indicates whether the completion is a streaming or non-streaming completion. </param>
        /// <param name="sessionState">
        /// Field that allows the chat app to store and retrieve data, the structure of such data is dependant on the backend
        /// being used. The client must send back the data in this field unchanged in subsequent requests, until the chat app
        /// sends a new one. The data in this field can be used to implement stateful services, such as remembering previous
        /// conversations or user preferences.
        /// </param>
        /// <param name="context">
        /// Context allows the chat app to receive extra parameters from the client, such as temperature, functions, or
        /// customer_info. These parameters are specific to the chat app and not understood by the generic clients.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationRoute"/> or <paramref name="messages"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationRoute"/> is an empty string, and was expected to be non-empty. </exception>
        internal virtual Response<ChatCompletionChunk> CreateStreaming(string operationRoute, IEnumerable<ChatMessage> messages, bool stream, BinaryData sessionState = null, IReadOnlyDictionary<string, BinaryData> context = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationRoute, nameof(operationRoute));
            Argument.AssertNotNull(messages, nameof(messages));

            CreateStreamingRequest createStreamingRequest = new CreateStreamingRequest(messages.ToList(), stream, sessionState, context ?? new ChangeTrackingDictionary<string, BinaryData>(), null);
            RequestContext context0 = FromCancellationToken(cancellationToken);
            Response response = CreateStreaming(operationRoute, createStreamingRequest.ToRequestContent(), context0);
            return Response.FromValue(ChatCompletionChunk.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Creates a new streaming chat completion.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateStreamingAsync(string,IEnumerable{ChatMessage},bool,BinaryData,IReadOnlyDictionary{string,BinaryData},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationRoute"> The route where the endpoint exposes the chat operations. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationRoute"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationRoute"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual async Task<Response> CreateStreamingAsync(string operationRoute, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(operationRoute, nameof(operationRoute));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Chat.CreateStreaming");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateStreamingRequest(operationRoute, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates a new streaming chat completion.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateStreaming(string,IEnumerable{ChatMessage},bool,BinaryData,IReadOnlyDictionary{string,BinaryData},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationRoute"> The route where the endpoint exposes the chat operations. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationRoute"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationRoute"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        internal virtual Response CreateStreaming(string operationRoute, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(operationRoute, nameof(operationRoute));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Chat.CreateStreaming");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateStreamingRequest(operationRoute, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new chat completion. </summary>
        /// <param name="operationRoute"> The route where the endpoint exposes the chat operations. </param>
        /// <param name="messages"> The collection of context messages associated with this completion request. </param>
        /// <param name="stream"> Indicates whether the completion is a streaming or non-streaming completion. </param>
        /// <param name="sessionState">
        /// Field that allows the chat app to store and retrieve data, the structure of such data is dependant on the backend
        /// being used. The client must send back the data in this field unchanged in subsequent requests, until the chat app
        /// sends a new one. The data in this field can be used to implement stateful services, such as remembering previous
        /// conversations or user preferences.
        /// </param>
        /// <param name="context">
        /// Context allows the chat app to receive extra parameters from the client, such as temperature, functions, or
        /// customer_info. These parameters are specific to the chat app and not understood by the generic clients.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationRoute"/> or <paramref name="messages"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationRoute"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/Chat.xml" path="doc/members/member[@name='CreateAsync(string,IEnumerable{ChatMessage},bool,BinaryData,IReadOnlyDictionary{string,BinaryData},CancellationToken)']/*" />
        public virtual async Task<Response<ChatCompletion>> CreateAsync(string operationRoute, IEnumerable<ChatMessage> messages, bool stream, BinaryData sessionState = null, IReadOnlyDictionary<string, BinaryData> context = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationRoute, nameof(operationRoute));
            Argument.AssertNotNull(messages, nameof(messages));

            CreateRequest createRequest = new CreateRequest(messages.ToList(), stream, sessionState, context ?? new ChangeTrackingDictionary<string, BinaryData>(), null);
            RequestContext context0 = FromCancellationToken(cancellationToken);
            Response response = await CreateAsync(operationRoute, createRequest.ToRequestContent(), context0).ConfigureAwait(false);
            return Response.FromValue(ChatCompletion.FromResponse(response), response);
        }

        /// <summary> Creates a new chat completion. </summary>
        /// <param name="operationRoute"> The route where the endpoint exposes the chat operations. </param>
        /// <param name="messages"> The collection of context messages associated with this completion request. </param>
        /// <param name="stream"> Indicates whether the completion is a streaming or non-streaming completion. </param>
        /// <param name="sessionState">
        /// Field that allows the chat app to store and retrieve data, the structure of such data is dependant on the backend
        /// being used. The client must send back the data in this field unchanged in subsequent requests, until the chat app
        /// sends a new one. The data in this field can be used to implement stateful services, such as remembering previous
        /// conversations or user preferences.
        /// </param>
        /// <param name="context">
        /// Context allows the chat app to receive extra parameters from the client, such as temperature, functions, or
        /// customer_info. These parameters are specific to the chat app and not understood by the generic clients.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationRoute"/> or <paramref name="messages"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationRoute"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/Chat.xml" path="doc/members/member[@name='Create(string,IEnumerable{ChatMessage},bool,BinaryData,IReadOnlyDictionary{string,BinaryData},CancellationToken)']/*" />
        public virtual Response<ChatCompletion> Create(string operationRoute, IEnumerable<ChatMessage> messages, bool stream, BinaryData sessionState = null, IReadOnlyDictionary<string, BinaryData> context = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationRoute, nameof(operationRoute));
            Argument.AssertNotNull(messages, nameof(messages));

            CreateRequest createRequest = new CreateRequest(messages.ToList(), stream, sessionState, context ?? new ChangeTrackingDictionary<string, BinaryData>(), null);
            RequestContext context0 = FromCancellationToken(cancellationToken);
            Response response = Create(operationRoute, createRequest.ToRequestContent(), context0);
            return Response.FromValue(ChatCompletion.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Creates a new chat completion.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateAsync(string,IEnumerable{ChatMessage},bool,BinaryData,IReadOnlyDictionary{string,BinaryData},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationRoute"> The route where the endpoint exposes the chat operations. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationRoute"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationRoute"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Chat.xml" path="doc/members/member[@name='CreateAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateAsync(string operationRoute, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(operationRoute, nameof(operationRoute));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Chat.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(operationRoute, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Creates a new chat completion.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Create(string,IEnumerable{ChatMessage},bool,BinaryData,IReadOnlyDictionary{string,BinaryData},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="operationRoute"> The route where the endpoint exposes the chat operations. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationRoute"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="operationRoute"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/Chat.xml" path="doc/members/member[@name='Create(string,RequestContent,RequestContext)']/*" />
        public virtual Response Create(string operationRoute, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(operationRoute, nameof(operationRoute));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("Chat.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(operationRoute, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateStreamingRequest(string operationRoute, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(operationRoute, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateCreateRequest(string operationRoute, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(operationRoute, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
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
