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
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents
{
    internal partial class IndexesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly Guid? _xMsClientRequestId;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of IndexesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint URL of the search service. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public IndexesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, Guid? xMsClientRequestId = null, string apiVersion = "2024-11-01-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _xMsClientRequestId = xMsClientRequestId;
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateCreateRequest(SearchIndex index)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(index);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new search index. </summary>
        /// <param name="index"> The definition of the index to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="index"/> is null. </exception>
        public async Task<Response<SearchIndex>> CreateAsync(SearchIndex index, CancellationToken cancellationToken = default)
        {
            if (index == null)
            {
                throw new ArgumentNullException(nameof(index));
            }

            using var message = CreateCreateRequest(index);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        SearchIndex value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndex.DeserializeSearchIndex(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new search index. </summary>
        /// <param name="index"> The definition of the index to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="index"/> is null. </exception>
        public Response<SearchIndex> Create(SearchIndex index, CancellationToken cancellationToken = default)
        {
            if (index == null)
            {
                throw new ArgumentNullException(nameof(index));
            }

            using var message = CreateCreateRequest(index);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        SearchIndex value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndex.DeserializeSearchIndex(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string select)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexes", false);
            if (select != null)
            {
                uri.AppendQuery("$select", select, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Lists all indexes available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the index definitions to retrieve. Specified as a comma-separated list of JSON property names, or '*' for all properties. The default is all properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ListIndexesResult>> ListAsync(string select = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListIndexesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListIndexesResult.DeserializeListIndexesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all indexes available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the index definitions to retrieve. Specified as a comma-separated list of JSON property names, or '*' for all properties. The default is all properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ListIndexesResult> List(string select = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(select);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListIndexesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListIndexesResult.DeserializeListIndexesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string indexName, SearchIndex index, bool? allowIndexDowntime, string ifMatch, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexes('", false);
            uri.AppendPath(indexName, true);
            uri.AppendPath("')", false);
            if (allowIndexDowntime != null)
            {
                uri.AppendQuery("allowIndexDowntime", allowIndexDowntime.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Prefer", "return=representation");
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(index);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new search index or updates an index if it already exists. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="index"> The definition of the index to create or update. </param>
        /// <param name="allowIndexDowntime"> Allows new analyzers, tokenizers, token filters, or char filters to be added to an index by taking the index offline for at least a few seconds. This temporarily causes indexing and query requests to fail. Performance and write availability of the index can be impaired for several minutes after the index is updated, or longer for very large indexes. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> or <paramref name="index"/> is null. </exception>
        public async Task<Response<SearchIndex>> CreateOrUpdateAsync(string indexName, SearchIndex index, bool? allowIndexDowntime = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }
            if (index == null)
            {
                throw new ArgumentNullException(nameof(index));
            }

            using var message = CreateCreateOrUpdateRequest(indexName, index, allowIndexDowntime, ifMatch, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SearchIndex value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndex.DeserializeSearchIndex(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new search index or updates an index if it already exists. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="index"> The definition of the index to create or update. </param>
        /// <param name="allowIndexDowntime"> Allows new analyzers, tokenizers, token filters, or char filters to be added to an index by taking the index offline for at least a few seconds. This temporarily causes indexing and query requests to fail. Performance and write availability of the index can be impaired for several minutes after the index is updated, or longer for very large indexes. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> or <paramref name="index"/> is null. </exception>
        public Response<SearchIndex> CreateOrUpdate(string indexName, SearchIndex index, bool? allowIndexDowntime = null, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }
            if (index == null)
            {
                throw new ArgumentNullException(nameof(index));
            }

            using var message = CreateCreateOrUpdateRequest(indexName, index, allowIndexDowntime, ifMatch, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SearchIndex value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndex.DeserializeSearchIndex(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string indexName, string ifMatch, string ifNoneMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexes('", false);
            uri.AppendPath(indexName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            if (ifNoneMatch != null)
            {
                request.Headers.Add("If-None-Match", ifNoneMatch);
            }
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Deletes a search index and all the documents it contains. This operation is permanent, with no recovery option. Make sure you have a master copy of your index definition, data ingestion code, and a backup of the primary data source in case you need to re-build the index. </summary>
        /// <param name="indexName"> The name of the index to delete. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string indexName, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }

            using var message = CreateDeleteRequest(indexName, ifMatch, ifNoneMatch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a search index and all the documents it contains. This operation is permanent, with no recovery option. Make sure you have a master copy of your index definition, data ingestion code, and a backup of the primary data source in case you need to re-build the index. </summary>
        /// <param name="indexName"> The name of the index to delete. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> is null. </exception>
        public Response Delete(string indexName, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }

            using var message = CreateDeleteRequest(indexName, ifMatch, ifNoneMatch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                case 404:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string indexName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexes('", false);
            uri.AppendPath(indexName, true);
            uri.AppendPath("')", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Retrieves an index definition. </summary>
        /// <param name="indexName"> The name of the index to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> is null. </exception>
        public async Task<Response<SearchIndex>> GetAsync(string indexName, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }

            using var message = CreateGetRequest(indexName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndex value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndex.DeserializeSearchIndex(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves an index definition. </summary>
        /// <param name="indexName"> The name of the index to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> is null. </exception>
        public Response<SearchIndex> Get(string indexName, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }

            using var message = CreateGetRequest(indexName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndex value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndex.DeserializeSearchIndex(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetStatisticsRequest(string indexName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexes('", false);
            uri.AppendPath(indexName, true);
            uri.AppendPath("')/search.stats", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            return message;
        }

        /// <summary> Returns statistics for the given index, including a document count and storage usage. </summary>
        /// <param name="indexName"> The name of the index for which to retrieve statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> is null. </exception>
        public async Task<Response<SearchIndexStatistics>> GetStatisticsAsync(string indexName, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }

            using var message = CreateGetStatisticsRequest(indexName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndexStatistics value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SearchIndexStatistics.DeserializeSearchIndexStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns statistics for the given index, including a document count and storage usage. </summary>
        /// <param name="indexName"> The name of the index for which to retrieve statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> is null. </exception>
        public Response<SearchIndexStatistics> GetStatistics(string indexName, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }

            using var message = CreateGetStatisticsRequest(indexName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SearchIndexStatistics value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SearchIndexStatistics.DeserializeSearchIndexStatistics(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAnalyzeRequest(string indexName, AnalyzeTextOptions request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/indexes('", false);
            uri.AppendPath(indexName, true);
            uri.AppendPath("')/search.analyze", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json; odata.metadata=minimal");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Shows how an analyzer breaks text into tokens. </summary>
        /// <param name="indexName"> The name of the index for which to test an analyzer. </param>
        /// <param name="request"> The text and analyzer or analysis components to test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> or <paramref name="request"/> is null. </exception>
        public async Task<Response<AnalyzeResult>> AnalyzeAsync(string indexName, AnalyzeTextOptions request, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAnalyzeRequest(indexName, request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnalyzeResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AnalyzeResult.DeserializeAnalyzeResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Shows how an analyzer breaks text into tokens. </summary>
        /// <param name="indexName"> The name of the index for which to test an analyzer. </param>
        /// <param name="request"> The text and analyzer or analysis components to test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="indexName"/> or <paramref name="request"/> is null. </exception>
        public Response<AnalyzeResult> Analyze(string indexName, AnalyzeTextOptions request, CancellationToken cancellationToken = default)
        {
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAnalyzeRequest(indexName, request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AnalyzeResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AnalyzeResult.DeserializeAnalyzeResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
