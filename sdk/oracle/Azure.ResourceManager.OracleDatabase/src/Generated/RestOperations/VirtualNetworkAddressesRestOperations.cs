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
    internal partial class VirtualNetworkAddressesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VirtualNetworkAddressesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VirtualNetworkAddressesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
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
            uri.AppendPath("/virtualNetworkAddresses", false);
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
            uri.AppendPath("/virtualNetworkAddresses", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List VirtualNetworkAddress resources by CloudVmCluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualNetworkAddressListResult>> ListByCloudVmClusterAsync(string subscriptionId, string resourceGroupName, string cloudvmclustername, CancellationToken cancellationToken = default)
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
                        VirtualNetworkAddressListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualNetworkAddressListResult.DeserializeVirtualNetworkAddressListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List VirtualNetworkAddress resources by CloudVmCluster. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualNetworkAddressListResult> ListByCloudVmCluster(string subscriptionId, string resourceGroupName, string cloudvmclustername, CancellationToken cancellationToken = default)
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
                        VirtualNetworkAddressListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualNetworkAddressListResult.DeserializeVirtualNetworkAddressListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/virtualNetworkAddresses/", false);
            uri.AppendPath(virtualnetworkaddressname, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname)
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
            uri.AppendPath("/virtualNetworkAddresses/", false);
            uri.AppendPath(virtualnetworkaddressname, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a VirtualNetworkAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CloudVmClusterVirtualNetworkAddressData>> GetAsync(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudvmclustername, virtualnetworkaddressname);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudVmClusterVirtualNetworkAddressData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CloudVmClusterVirtualNetworkAddressData.DeserializeCloudVmClusterVirtualNetworkAddressData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CloudVmClusterVirtualNetworkAddressData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a VirtualNetworkAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CloudVmClusterVirtualNetworkAddressData> Get(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudvmclustername, virtualnetworkaddressname);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudVmClusterVirtualNetworkAddressData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CloudVmClusterVirtualNetworkAddressData.DeserializeCloudVmClusterVirtualNetworkAddressData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((CloudVmClusterVirtualNetworkAddressData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname, CloudVmClusterVirtualNetworkAddressData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/virtualNetworkAddresses/", false);
            uri.AppendPath(virtualnetworkaddressname, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname, CloudVmClusterVirtualNetworkAddressData data)
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
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/virtualNetworkAddresses/", false);
            uri.AppendPath(virtualnetworkaddressname, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a VirtualNetworkAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/>, <paramref name="virtualnetworkaddressname"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname, CloudVmClusterVirtualNetworkAddressData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, cloudvmclustername, virtualnetworkaddressname, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a VirtualNetworkAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/>, <paramref name="virtualnetworkaddressname"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname, CloudVmClusterVirtualNetworkAddressData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, cloudvmclustername, virtualnetworkaddressname, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/virtualNetworkAddresses/", false);
            uri.AppendPath(virtualnetworkaddressname, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname)
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
            uri.AppendPath("/providers/Oracle.Database/cloudVmClusters/", false);
            uri.AppendPath(cloudvmclustername, true);
            uri.AppendPath("/virtualNetworkAddresses/", false);
            uri.AppendPath(virtualnetworkaddressname, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a VirtualNetworkAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, cloudvmclustername, virtualnetworkaddressname);
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

        /// <summary> Delete a VirtualNetworkAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="virtualnetworkaddressname"> Virtual IP address hostname. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudvmclustername"/> or <paramref name="virtualnetworkaddressname"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string cloudvmclustername, string virtualnetworkaddressname, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudvmclustername, nameof(cloudvmclustername));
            Argument.AssertNotNullOrEmpty(virtualnetworkaddressname, nameof(virtualnetworkaddressname));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, cloudvmclustername, virtualnetworkaddressname);
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

        /// <summary> List VirtualNetworkAddress resources by CloudVmCluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualNetworkAddressListResult>> ListByCloudVmClusterNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string cloudvmclustername, CancellationToken cancellationToken = default)
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
                        VirtualNetworkAddressListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualNetworkAddressListResult.DeserializeVirtualNetworkAddressListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List VirtualNetworkAddress resources by CloudVmCluster. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cloudvmclustername"> CloudVmCluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudvmclustername"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualNetworkAddressListResult> ListByCloudVmClusterNextPage(string nextLink, string subscriptionId, string resourceGroupName, string cloudvmclustername, CancellationToken cancellationToken = default)
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
                        VirtualNetworkAddressListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualNetworkAddressListResult.DeserializeVirtualNetworkAddressListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
