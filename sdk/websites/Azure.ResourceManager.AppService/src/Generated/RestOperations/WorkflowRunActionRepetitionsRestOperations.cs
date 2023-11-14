// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    internal partial class WorkflowRunActionRepetitionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of WorkflowRunActionRepetitionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public WorkflowRunActionRepetitionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-01-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Web/sites/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/hostruntime/runtime/webhooks/workflow/api/management/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all of a workflow run action repetitions. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WorkflowRunActionRepetitionDefinitionCollection>> ListAsync(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkflowRunActionRepetitionDefinitionCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WorkflowRunActionRepetitionDefinitionCollection.DeserializeWorkflowRunActionRepetitionDefinitionCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all of a workflow run action repetitions. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WorkflowRunActionRepetitionDefinitionCollection> List(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkflowRunActionRepetitionDefinitionCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WorkflowRunActionRepetitionDefinitionCollection.DeserializeWorkflowRunActionRepetitionDefinitionCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Web/sites/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/hostruntime/runtime/webhooks/workflow/api/management/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a workflow run action repetition. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WorkflowRunActionRepetitionDefinitionData>> GetAsync(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkflowRunActionRepetitionDefinitionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WorkflowRunActionRepetitionDefinitionData.DeserializeWorkflowRunActionRepetitionDefinitionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((WorkflowRunActionRepetitionDefinitionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a workflow run action repetition. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WorkflowRunActionRepetitionDefinitionData> Get(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkflowRunActionRepetitionDefinitionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WorkflowRunActionRepetitionDefinitionData.DeserializeWorkflowRunActionRepetitionDefinitionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((WorkflowRunActionRepetitionDefinitionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListExpressionTracesRequest(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Web/sites/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/hostruntime/runtime/webhooks/workflow/api/management/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/runs/", false);
            uri.AppendPath(runName, true);
            uri.AppendPath("/actions/", false);
            uri.AppendPath(actionName, true);
            uri.AppendPath("/repetitions/", false);
            uri.AppendPath(repetitionName, true);
            uri.AppendPath("/listExpressionTraces", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists a workflow run expression trace. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExpressionTraces>> ListExpressionTracesAsync(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListExpressionTracesRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressionTraces value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpressionTraces.DeserializeExpressionTraces(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists a workflow run expression trace. </summary>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExpressionTraces> ListExpressionTraces(string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListExpressionTracesRequest(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressionTraces value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpressionTraces.DeserializeExpressionTraces(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all of a workflow run action repetitions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WorkflowRunActionRepetitionDefinitionCollection>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, name, workflowName, runName, actionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkflowRunActionRepetitionDefinitionCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WorkflowRunActionRepetitionDefinitionCollection.DeserializeWorkflowRunActionRepetitionDefinitionCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all of a workflow run action repetitions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/> or <paramref name="actionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WorkflowRunActionRepetitionDefinitionCollection> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, name, workflowName, runName, actionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkflowRunActionRepetitionDefinitionCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WorkflowRunActionRepetitionDefinitionCollection.DeserializeWorkflowRunActionRepetitionDefinitionCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListExpressionTracesNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists a workflow run expression trace. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExpressionTraces>> ListExpressionTracesNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListExpressionTracesNextPageRequest(nextLink, subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressionTraces value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpressionTraces.DeserializeExpressionTraces(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists a workflow run expression trace. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Your Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> Name of the resource group to which the resource belongs. </param>
        /// <param name="name"> Site name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="runName"> The workflow run name. </param>
        /// <param name="actionName"> The workflow action name. </param>
        /// <param name="repetitionName"> The workflow repetition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="name"/>, <paramref name="workflowName"/>, <paramref name="runName"/>, <paramref name="actionName"/> or <paramref name="repetitionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExpressionTraces> ListExpressionTracesNextPage(string nextLink, string subscriptionId, string resourceGroupName, string name, string workflowName, string runName, string actionName, string repetitionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(runName, nameof(runName));
            Argument.AssertNotNullOrEmpty(actionName, nameof(actionName));
            Argument.AssertNotNullOrEmpty(repetitionName, nameof(repetitionName));

            using var message = CreateListExpressionTracesNextPageRequest(nextLink, subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpressionTraces value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpressionTraces.DeserializeExpressionTraces(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
