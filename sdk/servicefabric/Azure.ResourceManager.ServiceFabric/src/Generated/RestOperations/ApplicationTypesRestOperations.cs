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
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    internal partial class ApplicationTypesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ApplicationTypesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ApplicationTypesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabric/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/applicationTypes/", false);
            uri.AppendPath(applicationTypeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a Service Fabric application type name resource created or in the process of being created in the Service Fabric cluster resource. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ServiceFabricApplicationTypeData>> GetAsync(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterName, applicationTypeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricApplicationTypeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceFabricApplicationTypeData.DeserializeServiceFabricApplicationTypeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServiceFabricApplicationTypeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a Service Fabric application type name resource created or in the process of being created in the Service Fabric cluster resource. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ServiceFabricApplicationTypeData> Get(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, clusterName, applicationTypeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricApplicationTypeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceFabricApplicationTypeData.DeserializeServiceFabricApplicationTypeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServiceFabricApplicationTypeData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName, ServiceFabricApplicationTypeData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ServiceFabric/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/applicationTypes/", false);
            uri.AppendPath(applicationTypeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update a Service Fabric application type name resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationTypeName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ServiceFabricApplicationTypeData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName, ServiceFabricApplicationTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, clusterName, applicationTypeName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricApplicationTypeData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceFabricApplicationTypeData.DeserializeServiceFabricApplicationTypeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a Service Fabric application type name resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="data"> The application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/>, <paramref name="applicationTypeName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ServiceFabricApplicationTypeData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName, ServiceFabricApplicationTypeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, clusterName, applicationTypeName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricApplicationTypeData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceFabricApplicationTypeData.DeserializeServiceFabricApplicationTypeData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ServiceFabric/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/applicationTypes/", false);
            uri.AppendPath(applicationTypeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a Service Fabric application type name resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, clusterName, applicationTypeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a Service Fabric application type name resource with the specified name. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="applicationTypeName"> The name of the application type name resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="clusterName"/> or <paramref name="applicationTypeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string clusterName, string applicationTypeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));
            Argument.AssertNotNullOrEmpty(applicationTypeName, nameof(applicationTypeName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, clusterName, applicationTypeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string clusterName)
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
            uri.AppendPath("/providers/Microsoft.ServiceFabric/clusters/", false);
            uri.AppendPath(clusterName, true);
            uri.AppendPath("/applicationTypes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all application type name resources created or in the process of being created in the Service Fabric cluster resource. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ServiceFabricApplicationTypeList>> ListAsync(string subscriptionId, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, clusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricApplicationTypeList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceFabricApplicationTypeList.DeserializeServiceFabricApplicationTypeList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all application type name resources created or in the process of being created in the Service Fabric cluster resource. </summary>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ServiceFabricApplicationTypeList> List(string subscriptionId, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, clusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricApplicationTypeList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceFabricApplicationTypeList.DeserializeServiceFabricApplicationTypeList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string clusterName)
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

        /// <summary> Gets all application type name resources created or in the process of being created in the Service Fabric cluster resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ServiceFabricApplicationTypeList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, clusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricApplicationTypeList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceFabricApplicationTypeList.DeserializeServiceFabricApplicationTypeList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all application type name resources created or in the process of being created in the Service Fabric cluster resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The customer subscription identifier. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="clusterName"> The name of the cluster resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ServiceFabricApplicationTypeList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string clusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(clusterName, nameof(clusterName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, clusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceFabricApplicationTypeList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceFabricApplicationTypeList.DeserializeServiceFabricApplicationTypeList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
