// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace LiveMetrics
{
    // Data plane generated client.
    /// <summary> Live Metrics REST APIs. </summary>
    public partial class LiveMetricsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://monitor.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of LiveMetricsClient for mocking. </summary>
        protected LiveMetricsClient()
        {
        }

        /// <summary> Initializes a new instance of LiveMetricsClient. </summary>
        /// <param name="endpoint"> The endpoint of the Live Metrics service. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public LiveMetricsClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new LiveMetricsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of LiveMetricsClient. </summary>
        /// <param name="endpoint"> The endpoint of the Live Metrics service. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public LiveMetricsClient(Uri endpoint, TokenCredential credential, LiveMetricsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new LiveMetricsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Determine whether there is any subscription to the metrics and documents. </summary>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="monitoringDataPoint"> Data contract between Application Insights client SDK and Live Metrics. /QuickPulseService.svc/ping uses this as a backup source of machine name, instance name and invariant version. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="machineName"> Computer name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="instanceName"> Service instance name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="streamId"> Identifies an Application Insights SDK as trusted agent to report metrics and documents. </param>
        /// <param name="roleName"> Cloud role name of the service. </param>
        /// <param name="invariantVersion"> Version/generation of the data contract (MonitoringDataPoint) between the client and Live Metrics. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ikey"/> is null. </exception>
        /// <include file="Docs/LiveMetricsClient.xml" path="doc/members/member[@name='IsSubscribedAsync(string,MonitoringDataPoint,long?,string,string,string,string,string,ETag?,CancellationToken)']/*" />
        public virtual async Task<Response<CollectionConfigurationInfo>> IsSubscribedAsync(string ikey, MonitoringDataPoint monitoringDataPoint = null, long? transmissionTime = null, string machineName = null, string instanceName = null, string streamId = null, string roleName = null, string invariantVersion = null, ETag? configurationEtag = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ikey, nameof(ikey));

            using RequestContent content = monitoringDataPoint?.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await IsSubscribedAsync(ikey, content, transmissionTime, machineName, instanceName, streamId, roleName, invariantVersion, configurationEtag, context).ConfigureAwait(false);
            return Response.FromValue(CollectionConfigurationInfo.FromResponse(response), response);
        }

        /// <summary> Determine whether there is any subscription to the metrics and documents. </summary>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="monitoringDataPoint"> Data contract between Application Insights client SDK and Live Metrics. /QuickPulseService.svc/ping uses this as a backup source of machine name, instance name and invariant version. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="machineName"> Computer name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="instanceName"> Service instance name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="streamId"> Identifies an Application Insights SDK as trusted agent to report metrics and documents. </param>
        /// <param name="roleName"> Cloud role name of the service. </param>
        /// <param name="invariantVersion"> Version/generation of the data contract (MonitoringDataPoint) between the client and Live Metrics. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ikey"/> is null. </exception>
        /// <include file="Docs/LiveMetricsClient.xml" path="doc/members/member[@name='IsSubscribed(string,MonitoringDataPoint,long?,string,string,string,string,string,ETag?,CancellationToken)']/*" />
        public virtual Response<CollectionConfigurationInfo> IsSubscribed(string ikey, MonitoringDataPoint monitoringDataPoint = null, long? transmissionTime = null, string machineName = null, string instanceName = null, string streamId = null, string roleName = null, string invariantVersion = null, ETag? configurationEtag = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ikey, nameof(ikey));

            using RequestContent content = monitoringDataPoint?.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = IsSubscribed(ikey, content, transmissionTime, machineName, instanceName, streamId, roleName, invariantVersion, configurationEtag, context);
            return Response.FromValue(CollectionConfigurationInfo.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Determine whether there is any subscription to the metrics and documents.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="IsSubscribedAsync(string,MonitoringDataPoint,long?,string,string,string,string,string,ETag?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="machineName"> Computer name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="instanceName"> Service instance name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="streamId"> Identifies an Application Insights SDK as trusted agent to report metrics and documents. </param>
        /// <param name="roleName"> Cloud role name of the service. </param>
        /// <param name="invariantVersion"> Version/generation of the data contract (MonitoringDataPoint) between the client and Live Metrics. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ikey"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/LiveMetricsClient.xml" path="doc/members/member[@name='IsSubscribedAsync(string,RequestContent,long?,string,string,string,string,string,ETag?,RequestContext)']/*" />
        public virtual async Task<Response> IsSubscribedAsync(string ikey, RequestContent content, long? transmissionTime = null, string machineName = null, string instanceName = null, string streamId = null, string roleName = null, string invariantVersion = null, ETag? configurationEtag = null, RequestContext context = null)
        {
            Argument.AssertNotNull(ikey, nameof(ikey));

            using var scope = ClientDiagnostics.CreateScope("LiveMetricsClient.IsSubscribed");
            scope.Start();
            try
            {
                using HttpMessage message = CreateIsSubscribedRequest(ikey, content, transmissionTime, machineName, instanceName, streamId, roleName, invariantVersion, configurationEtag, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (System.Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Determine whether there is any subscription to the metrics and documents.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="IsSubscribed(string,MonitoringDataPoint,long?,string,string,string,string,string,ETag?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="machineName"> Computer name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="instanceName"> Service instance name where Application Insights SDK lives. Live Metrics uses machine name with instance name as a backup. </param>
        /// <param name="streamId"> Identifies an Application Insights SDK as trusted agent to report metrics and documents. </param>
        /// <param name="roleName"> Cloud role name of the service. </param>
        /// <param name="invariantVersion"> Version/generation of the data contract (MonitoringDataPoint) between the client and Live Metrics. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ikey"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/LiveMetricsClient.xml" path="doc/members/member[@name='IsSubscribed(string,RequestContent,long?,string,string,string,string,string,ETag?,RequestContext)']/*" />
        public virtual Response IsSubscribed(string ikey, RequestContent content, long? transmissionTime = null, string machineName = null, string instanceName = null, string streamId = null, string roleName = null, string invariantVersion = null, ETag? configurationEtag = null, RequestContext context = null)
        {
            Argument.AssertNotNull(ikey, nameof(ikey));

            using var scope = ClientDiagnostics.CreateScope("LiveMetricsClient.IsSubscribed");
            scope.Start();
            try
            {
                using HttpMessage message = CreateIsSubscribedRequest(ikey, content, transmissionTime, machineName, instanceName, streamId, roleName, invariantVersion, configurationEtag, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (System.Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Publish live metrics to the Live Metrics service when there is an active subscription to the metrics. </summary>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="monitoringDataPoints"> Data contract between the client and Live Metrics. /QuickPulseService.svc/ping uses this as a backup source of machine name, instance name and invariant version. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ikey"/> is null. </exception>
        /// <include file="Docs/LiveMetricsClient.xml" path="doc/members/member[@name='PublishAsync(string,IEnumerable{MonitoringDataPoint},ETag?,long?,CancellationToken)']/*" />
        public virtual async Task<Response<CollectionConfigurationInfo>> PublishAsync(string ikey, IEnumerable<MonitoringDataPoint> monitoringDataPoints = null, ETag? configurationEtag = null, long? transmissionTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ikey, nameof(ikey));

            using RequestContent content = monitoringDataPoints != null ? RequestContentHelper.FromEnumerable(monitoringDataPoints) : null;
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await PublishAsync(ikey, content, configurationEtag, transmissionTime, context).ConfigureAwait(false);
            return Response.FromValue(CollectionConfigurationInfo.FromResponse(response), response);
        }

        /// <summary> Publish live metrics to the Live Metrics service when there is an active subscription to the metrics. </summary>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="monitoringDataPoints"> Data contract between the client and Live Metrics. /QuickPulseService.svc/ping uses this as a backup source of machine name, instance name and invariant version. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ikey"/> is null. </exception>
        /// <include file="Docs/LiveMetricsClient.xml" path="doc/members/member[@name='Publish(string,IEnumerable{MonitoringDataPoint},ETag?,long?,CancellationToken)']/*" />
        public virtual Response<CollectionConfigurationInfo> Publish(string ikey, IEnumerable<MonitoringDataPoint> monitoringDataPoints = null, ETag? configurationEtag = null, long? transmissionTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(ikey, nameof(ikey));

            using RequestContent content = monitoringDataPoints != null ? RequestContentHelper.FromEnumerable(monitoringDataPoints) : null;
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Publish(ikey, content, configurationEtag, transmissionTime, context);
            return Response.FromValue(CollectionConfigurationInfo.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Publish live metrics to the Live Metrics service when there is an active subscription to the metrics.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="PublishAsync(string,IEnumerable{MonitoringDataPoint},ETag?,long?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ikey"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/LiveMetricsClient.xml" path="doc/members/member[@name='PublishAsync(string,RequestContent,ETag?,long?,RequestContext)']/*" />
        public virtual async Task<Response> PublishAsync(string ikey, RequestContent content, ETag? configurationEtag = null, long? transmissionTime = null, RequestContext context = null)
        {
            Argument.AssertNotNull(ikey, nameof(ikey));

            using var scope = ClientDiagnostics.CreateScope("LiveMetricsClient.Publish");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePublishRequest(ikey, content, configurationEtag, transmissionTime, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (System.Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Publish live metrics to the Live Metrics service when there is an active subscription to the metrics.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Publish(string,IEnumerable{MonitoringDataPoint},ETag?,long?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ikey"> The instrumentation key of the target Application Insights component for which the client checks whether there's any subscription to it. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="configurationEtag"> An encoded string that indicates whether the collection configuration is changed. </param>
        /// <param name="transmissionTime"> Timestamp when the client transmits the metrics and documents to Live Metrics. A 8-byte long type of ticks. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ikey"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/LiveMetricsClient.xml" path="doc/members/member[@name='Publish(string,RequestContent,ETag?,long?,RequestContext)']/*" />
        public virtual Response Publish(string ikey, RequestContent content, ETag? configurationEtag = null, long? transmissionTime = null, RequestContext context = null)
        {
            Argument.AssertNotNull(ikey, nameof(ikey));

            using var scope = ClientDiagnostics.CreateScope("LiveMetricsClient.Publish");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePublishRequest(ikey, content, configurationEtag, transmissionTime, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (System.Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateIsSubscribedRequest(string ikey, RequestContent content, long? transmissionTime, string machineName, string instanceName, string streamId, string roleName, string invariantVersion, ETag? configurationEtag, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/QuickPulseService.svc/ping", false);
            uri.AppendQuery("ikey", ikey, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (transmissionTime != null)
            {
                request.Headers.Add("x-ms-qps-transmission-time", transmissionTime.Value);
            }
            if (machineName != null)
            {
                request.Headers.Add("x-ms-qps-machine-name", machineName);
            }
            if (instanceName != null)
            {
                request.Headers.Add("x-ms-qps-instance-name", instanceName);
            }
            if (streamId != null)
            {
                request.Headers.Add("x-ms-qps-stream-id", streamId);
            }
            if (roleName != null)
            {
                request.Headers.Add("x-ms-qps-role-name", roleName);
            }
            if (invariantVersion != null)
            {
                request.Headers.Add("x-ms-qps-invariant-version", invariantVersion);
            }
            if (configurationEtag != null)
            {
                request.Headers.Add("x-ms-qps-configuration-etag", configurationEtag.Value);
            }
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreatePublishRequest(string ikey, RequestContent content, ETag? configurationEtag, long? transmissionTime, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/QuickPulseService.svc/post", false);
            uri.AppendQuery("ikey", ikey, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (configurationEtag != null)
            {
                request.Headers.Add("x-ms-qps-configuration-etag", configurationEtag.Value);
            }
            if (transmissionTime != null)
            {
                request.Headers.Add("x-ms-qps-transmission-time", transmissionTime.Value);
            }
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
