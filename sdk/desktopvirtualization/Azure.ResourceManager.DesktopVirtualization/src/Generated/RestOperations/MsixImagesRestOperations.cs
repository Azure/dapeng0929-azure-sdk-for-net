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
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    internal partial class MsixImagesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of MsixImagesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public MsixImagesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-04-08-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateExpandRequestUri(string subscriptionId, string resourceGroupName, string hostPoolName, MsixImageUri msixImageUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DesktopVirtualization/hostPools/", false);
            uri.AppendPath(hostPoolName, true);
            uri.AppendPath("/expandMsixImage", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateExpandRequest(string subscriptionId, string resourceGroupName, string hostPoolName, MsixImageUri msixImageUri)
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
            uri.AppendPath("/providers/Microsoft.DesktopVirtualization/hostPools/", false);
            uri.AppendPath(hostPoolName, true);
            uri.AppendPath("/expandMsixImage", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(msixImageUri, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Expands and Lists MSIX packages in an Image, given the Image Path. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="msixImageUri"> Object containing URI to MSIX Image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostPoolName"/> or <paramref name="msixImageUri"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExpandMsixImageList>> ExpandAsync(string subscriptionId, string resourceGroupName, string hostPoolName, MsixImageUri msixImageUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));
            Argument.AssertNotNull(msixImageUri, nameof(msixImageUri));

            using var message = CreateExpandRequest(subscriptionId, resourceGroupName, hostPoolName, msixImageUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpandMsixImageList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpandMsixImageList.DeserializeExpandMsixImageList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Expands and Lists MSIX packages in an Image, given the Image Path. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="msixImageUri"> Object containing URI to MSIX Image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostPoolName"/> or <paramref name="msixImageUri"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExpandMsixImageList> Expand(string subscriptionId, string resourceGroupName, string hostPoolName, MsixImageUri msixImageUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));
            Argument.AssertNotNull(msixImageUri, nameof(msixImageUri));

            using var message = CreateExpandRequest(subscriptionId, resourceGroupName, hostPoolName, msixImageUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpandMsixImageList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpandMsixImageList.DeserializeExpandMsixImageList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateExpandNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string hostPoolName, MsixImageUri msixImageUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateExpandNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string hostPoolName, MsixImageUri msixImageUri)
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

        /// <summary> Expands and Lists MSIX packages in an Image, given the Image Path. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="msixImageUri"> Object containing URI to MSIX Image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostPoolName"/> or <paramref name="msixImageUri"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExpandMsixImageList>> ExpandNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string hostPoolName, MsixImageUri msixImageUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));
            Argument.AssertNotNull(msixImageUri, nameof(msixImageUri));

            using var message = CreateExpandNextPageRequest(nextLink, subscriptionId, resourceGroupName, hostPoolName, msixImageUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpandMsixImageList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExpandMsixImageList.DeserializeExpandMsixImageList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Expands and Lists MSIX packages in an Image, given the Image Path. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="msixImageUri"> Object containing URI to MSIX Image. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="hostPoolName"/> or <paramref name="msixImageUri"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExpandMsixImageList> ExpandNextPage(string nextLink, string subscriptionId, string resourceGroupName, string hostPoolName, MsixImageUri msixImageUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));
            Argument.AssertNotNull(msixImageUri, nameof(msixImageUri));

            using var message = CreateExpandNextPageRequest(nextLink, subscriptionId, resourceGroupName, hostPoolName, msixImageUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExpandMsixImageList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExpandMsixImageList.DeserializeExpandMsixImageList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
