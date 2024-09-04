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
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    internal partial class ClusterRecoveryPointsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ClusterRecoveryPointsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ClusterRecoveryPointsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListByReplicationProtectionClusterRequestUri(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicationProtectionClusterName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/replicationFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/replicationProtectionContainers/", false);
            uri.AppendPath(protectionContainerName, true);
            uri.AppendPath("/replicationProtectionClusters/", false);
            uri.AppendPath(replicationProtectionClusterName, true);
            uri.AppendPath("/recoveryPoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListByReplicationProtectionClusterRequest(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicationProtectionClusterName)
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
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/replicationFabrics/", false);
            uri.AppendPath(fabricName, true);
            uri.AppendPath("/replicationProtectionContainers/", false);
            uri.AppendPath(protectionContainerName, true);
            uri.AppendPath("/replicationProtectionClusters/", false);
            uri.AppendPath(replicationProtectionClusterName, true);
            uri.AppendPath("/recoveryPoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> The list of cluster recovery points. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="replicationProtectionClusterName"> Replication protection cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="replicationProtectionClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="replicationProtectionClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Models.ClusterRecoveryPointCollection>> ListByReplicationProtectionClusterAsync(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicationProtectionClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));
            Argument.AssertNotNullOrEmpty(replicationProtectionClusterName, nameof(replicationProtectionClusterName));

            using var message = CreateListByReplicationProtectionClusterRequest(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, replicationProtectionClusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.ClusterRecoveryPointCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.ClusterRecoveryPointCollection.DeserializeClusterRecoveryPointCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The list of cluster recovery points. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="replicationProtectionClusterName"> Replication protection cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="replicationProtectionClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="replicationProtectionClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Models.ClusterRecoveryPointCollection> ListByReplicationProtectionCluster(string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicationProtectionClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));
            Argument.AssertNotNullOrEmpty(replicationProtectionClusterName, nameof(replicationProtectionClusterName));

            using var message = CreateListByReplicationProtectionClusterRequest(subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, replicationProtectionClusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.ClusterRecoveryPointCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.ClusterRecoveryPointCollection.DeserializeClusterRecoveryPointCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByReplicationProtectionClusterNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicationProtectionClusterName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByReplicationProtectionClusterNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicationProtectionClusterName)
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

        /// <summary> The list of cluster recovery points. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="replicationProtectionClusterName"> Replication protection cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="replicationProtectionClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="replicationProtectionClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Models.ClusterRecoveryPointCollection>> ListByReplicationProtectionClusterNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicationProtectionClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));
            Argument.AssertNotNullOrEmpty(replicationProtectionClusterName, nameof(replicationProtectionClusterName));

            using var message = CreateListByReplicationProtectionClusterNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, replicationProtectionClusterName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.ClusterRecoveryPointCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.ClusterRecoveryPointCollection.DeserializeClusterRecoveryPointCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> The list of cluster recovery points. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <param name="fabricName"> Fabric name. </param>
        /// <param name="protectionContainerName"> Protection container name. </param>
        /// <param name="replicationProtectionClusterName"> Replication protection cluster name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="replicationProtectionClusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="fabricName"/>, <paramref name="protectionContainerName"/> or <paramref name="replicationProtectionClusterName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Models.ClusterRecoveryPointCollection> ListByReplicationProtectionClusterNextPage(string nextLink, string subscriptionId, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicationProtectionClusterName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(fabricName, nameof(fabricName));
            Argument.AssertNotNullOrEmpty(protectionContainerName, nameof(protectionContainerName));
            Argument.AssertNotNullOrEmpty(replicationProtectionClusterName, nameof(replicationProtectionClusterName));

            using var message = CreateListByReplicationProtectionClusterNextPageRequest(nextLink, subscriptionId, resourceGroupName, resourceName, fabricName, protectionContainerName, replicationProtectionClusterName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.ClusterRecoveryPointCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.ClusterRecoveryPointCollection.DeserializeClusterRecoveryPointCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
