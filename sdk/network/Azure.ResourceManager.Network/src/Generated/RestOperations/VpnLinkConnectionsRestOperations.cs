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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class VpnLinkConnectionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VpnLinkConnectionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VpnLinkConnectionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateResetConnectionRequest(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, string linkConnectionName)
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
            uri.AppendPath("/providers/Microsoft.Network/vpnGateways/", false);
            uri.AppendPath(gatewayName, true);
            uri.AppendPath("/vpnConnections/", false);
            uri.AppendPath(connectionName, true);
            uri.AppendPath("/vpnLinkConnections/", false);
            uri.AppendPath(linkConnectionName, true);
            uri.AppendPath("/resetconnection", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Resets the VpnLink connection specified. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="linkConnectionName"> The name of the vpn link connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/> or <paramref name="linkConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/> or <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> ResetConnectionAsync(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var message = CreateResetConnectionRequest(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Resets the VpnLink connection specified. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="linkConnectionName"> The name of the vpn link connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/> or <paramref name="linkConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/> or <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response ResetConnection(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var message = CreateResetConnectionRequest(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetIkeSasRequest(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, string linkConnectionName)
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
            uri.AppendPath("/providers/Microsoft.Network/vpnGateways/", false);
            uri.AppendPath(gatewayName, true);
            uri.AppendPath("/vpnConnections/", false);
            uri.AppendPath(connectionName, true);
            uri.AppendPath("/vpnLinkConnections/", false);
            uri.AppendPath(linkConnectionName, true);
            uri.AppendPath("/getikesas", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists IKE Security Associations for Vpn Site Link Connection in the specified resource group. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="linkConnectionName"> The name of the vpn link connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/> or <paramref name="linkConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/> or <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> GetIkeSasAsync(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var message = CreateGetIkeSasRequest(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
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

        /// <summary> Lists IKE Security Associations for Vpn Site Link Connection in the specified resource group. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="linkConnectionName"> The name of the vpn link connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/> or <paramref name="linkConnectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/>, <paramref name="connectionName"/> or <paramref name="linkConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response GetIkeSas(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, string linkConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));
            Argument.AssertNotNullOrEmpty(linkConnectionName, nameof(linkConnectionName));

            using var message = CreateGetIkeSasRequest(subscriptionId, resourceGroupName, gatewayName, connectionName, linkConnectionName);
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

        internal HttpMessage CreateListByVpnConnectionRequest(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName)
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
            uri.AppendPath("/providers/Microsoft.Network/vpnGateways/", false);
            uri.AppendPath(gatewayName, true);
            uri.AppendPath("/vpnConnections/", false);
            uri.AppendPath(connectionName, true);
            uri.AppendPath("/vpnLinkConnections", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the vpn gateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/> or <paramref name="connectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/> or <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListVpnSiteLinkConnectionsResult>> ListByVpnConnectionAsync(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var message = CreateListByVpnConnectionRequest(subscriptionId, resourceGroupName, gatewayName, connectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinkConnectionsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnSiteLinkConnectionsResult.DeserializeListVpnSiteLinkConnectionsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the vpn gateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/> or <paramref name="connectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/> or <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListVpnSiteLinkConnectionsResult> ListByVpnConnection(string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var message = CreateListByVpnConnectionRequest(subscriptionId, resourceGroupName, gatewayName, connectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinkConnectionsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnSiteLinkConnectionsResult.DeserializeListVpnSiteLinkConnectionsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVpnConnectionNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string gatewayName, string connectionName)
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

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the vpn gateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/> or <paramref name="connectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/> or <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListVpnSiteLinkConnectionsResult>> ListByVpnConnectionNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var message = CreateListByVpnConnectionNextPageRequest(nextLink, subscriptionId, resourceGroupName, gatewayName, connectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinkConnectionsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVpnSiteLinkConnectionsResult.DeserializeListVpnSiteLinkConnectionsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the vpn gateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/> or <paramref name="connectionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="gatewayName"/> or <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListVpnSiteLinkConnectionsResult> ListByVpnConnectionNextPage(string nextLink, string subscriptionId, string resourceGroupName, string gatewayName, string connectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            Argument.AssertNotNullOrEmpty(connectionName, nameof(connectionName));

            using var message = CreateListByVpnConnectionNextPageRequest(nextLink, subscriptionId, resourceGroupName, gatewayName, connectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVpnSiteLinkConnectionsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVpnSiteLinkConnectionsResult.DeserializeListVpnSiteLinkConnectionsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
