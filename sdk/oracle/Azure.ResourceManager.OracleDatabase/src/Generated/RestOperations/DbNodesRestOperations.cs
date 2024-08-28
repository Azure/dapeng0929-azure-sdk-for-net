// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.OracleDatabase.Models;

namespace Azure.ResourceManager.OracleDatabase
{
    internal partial class DbNodesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DbNodesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DbNodesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByCloudVmClusterRequestUri(string subscriptionId, string resourceGroupName, string cloudvmclustername)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/dbNodes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByCloudVmClusterRequest(string subscriptionId, string resourceGroupName, string cloudvmclustername)
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
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/dbNodes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List DbNode resources by CloudVmCluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DBNodeListResult>> ListByCloudVmClusterAsync(string subscriptionId, string resourceGroupName, string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var message = CreateListByCloudVmClusterRequest(subscriptionId, resourceGroupName, cloudvmclustername);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DBNodeListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DBNodeListResult.DeserializeDBNodeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List DbNode resources by CloudVmCluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DBNodeListResult> ListByCloudVmCluster(string subscriptionId, string resourceGroupName, string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var message = CreateListByCloudVmClusterRequest(subscriptionId, resourceGroupName, cloudvmclustername);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DBNodeListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DBNodeListResult.DeserializeDBNodeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string cloudvmclustername, string dbnodeocid)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/dbNodes/", false);
            uri.AppendPath(dbnodeocid, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string cloudvmclustername, string dbnodeocid)
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
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/dbNodes/", false);
            uri.AppendPath(dbnodeocid, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a DbNode. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="dbnodeocid"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CloudVmClusterDBNodeData>> GetAsync(string subscriptionId, string resourceGroupName, string cloudvmclustername, string dbnodeocid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudvmclustername, dbnodeocid);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudVmClusterDBNodeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CloudVmClusterDBNodeData.DeserializeCloudVmClusterDBNodeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CloudVmClusterDBNodeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a DbNode. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="dbnodeocid"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CloudVmClusterDBNodeData> Get(string subscriptionId, string resourceGroupName, string cloudvmclustername, string dbnodeocid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudvmclustername, dbnodeocid);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudVmClusterDBNodeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CloudVmClusterDBNodeData.DeserializeCloudVmClusterDBNodeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CloudVmClusterDBNodeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateActionRequestUri(string subscriptionId, string resourceGroupName, string cloudvmclustername, string dbnodeocid, DBNodeAction body)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/dbNodes/", false);
            uri.AppendPath(dbnodeocid, true);
            uri.AppendPath("/action", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateActionRequest(string subscriptionId, string resourceGroupName, string cloudvmclustername, string dbnodeocid, DBNodeAction body)
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
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/dbNodes/", false);
            uri.AppendPath(dbnodeocid, true);
            uri.AppendPath("/action", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(body, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> VM actions on DbNode of VM Cluster by the provided filter. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="body"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/>, <paramref name="dbnodeocid"/> or <paramref name="body"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> ActionAsync(string subscriptionId, string resourceGroupName, string cloudvmclustername, string dbnodeocid, DBNodeAction body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));
            Argument.AssertNotNull(body, nameof(body));

            using var message = CreateActionRequest(subscriptionId, resourceGroupName, cloudvmclustername, dbnodeocid, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> VM actions on DbNode of VM Cluster by the provided filter. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="body"> The content of the action request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/>, <paramref name="dbnodeocid"/> or <paramref name="body"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Action(string subscriptionId, string resourceGroupName, string cloudvmclustername, string dbnodeocid, DBNodeAction body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));
            Argument.AssertNotNull(body, nameof(body));

            using var message = CreateActionRequest(subscriptionId, resourceGroupName, cloudvmclustername, dbnodeocid, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByCloudVmClusterNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string cloudvmclustername)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByCloudVmClusterNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string cloudvmclustername)
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

        /// <summary> List DbNode resources by CloudVmCluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DBNodeListResult>> ListByCloudVmClusterNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var message = CreateListByCloudVmClusterNextPageRequest(nextLink, subscriptionId, resourceGroupName, cloudvmclustername);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DBNodeListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DBNodeListResult.DeserializeDBNodeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List DbNode resources by CloudVmCluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DBNodeListResult> ListByCloudVmClusterNextPage(string nextLink, string subscriptionId, string resourceGroupName, string cloudvmclustername, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));

            using var message = CreateListByCloudVmClusterNextPageRequest(nextLink, subscriptionId, resourceGroupName, cloudvmclustername);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DBNodeListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DBNodeListResult.DeserializeDBNodeListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
