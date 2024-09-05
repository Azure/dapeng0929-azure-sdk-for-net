// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A Class representing a StreamingJobFunction along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="StreamingJobFunctionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetStreamingJobFunctionResource method.
    /// Otherwise you can get one from its parent resource <see cref="StreamingJobResource"/> using the GetStreamingJobFunction method.
    /// </summary>
    public partial class StreamingJobFunctionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StreamingJobFunctionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="jobName"> The jobName. </param>
        /// <param name="functionName"> The functionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string jobName, string functionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _streamingJobFunctionFunctionsClientDiagnostics;
        private readonly FunctionsRestOperations _streamingJobFunctionFunctionsRestClient;
        private readonly StreamingJobFunctionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly Core.ResourceType ResourceType = "Microsoft.StreamAnalytics/streamingjobs/functions";

        /// <summary> Initializes a new instance of the <see cref="StreamingJobFunctionResource"/> class for mocking. </summary>
        protected StreamingJobFunctionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingJobFunctionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StreamingJobFunctionResource(ArmClient client, StreamingJobFunctionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="StreamingJobFunctionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StreamingJobFunctionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _streamingJobFunctionFunctionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.StreamAnalytics", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string streamingJobFunctionFunctionsApiVersion);
            _streamingJobFunctionFunctionsRestClient = new FunctionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, streamingJobFunctionFunctionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual StreamingJobFunctionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets details about the specified function.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StreamingJobFunctionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.Get");
            scope.Start();
            try
            {
                var response = await _streamingJobFunctionFunctionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details about the specified function.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StreamingJobFunctionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.Get");
            scope.Start();
            try
            {
                var response = _streamingJobFunctionFunctionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StreamingJobFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a function from the streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.Delete");
            scope.Start();
            try
            {
                var response = await _streamingJobFunctionFunctionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _streamingJobFunctionFunctionsRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StreamAnalyticsArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a function from the streaming job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.Delete");
            scope.Start();
            try
            {
                var response = _streamingJobFunctionFunctionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _streamingJobFunctionFunctionsRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new StreamAnalyticsArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing function under an existing streaming job. This can be used to partially update (ie. update one or two properties) a function without affecting the rest the job or function definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> A function object. The properties specified here will overwrite the corresponding properties in the existing function (ie. Those properties will be updated). Any properties that are set to null here will mean that the corresponding property in the existing function will remain the same and not change as a result of this PATCH operation. </param>
        /// <param name="ifMatch"> The ETag of the function. Omit this value to always overwrite the current function. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<StreamingJobFunctionResource>> UpdateAsync(StreamingJobFunctionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.Update");
            scope.Start();
            try
            {
                var response = await _streamingJobFunctionFunctionsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new StreamingJobFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing function under an existing streaming job. This can be used to partially update (ie. update one or two properties) a function without affecting the rest the job or function definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="data"> A function object. The properties specified here will overwrite the corresponding properties in the existing function (ie. Those properties will be updated). Any properties that are set to null here will mean that the corresponding property in the existing function will remain the same and not change as a result of this PATCH operation. </param>
        /// <param name="ifMatch"> The ETag of the function. Omit this value to always overwrite the current function. Specify the last-seen ETag value to prevent accidentally overwriting concurrent changes. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<StreamingJobFunctionResource> Update(StreamingJobFunctionData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.Update");
            scope.Start();
            try
            {
                var response = _streamingJobFunctionFunctionsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken);
                return Response.FromValue(new StreamingJobFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tests if the information provided for a function is valid. This can range from testing the connection to the underlying web service behind the function or making sure the function code provided is syntactically correct.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}/test</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Test</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> If the function specified does not already exist, this parameter must contain the full function definition intended to be tested. If the function specified already exists, this parameter can be left null to test the existing function as is or if specified, the properties specified will overwrite the corresponding properties in the existing function (exactly like a PATCH operation) and the resulting function will be tested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<StreamAnalyticsResourceTestStatus>> TestAsync(WaitUntil waitUntil, StreamingJobFunctionData data = null, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.Test");
            scope.Start();
            try
            {
                var response = await _streamingJobFunctionFunctionsRestClient.TestAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new StreamAnalyticsArmOperation<StreamAnalyticsResourceTestStatus>(new StreamAnalyticsResourceTestStatusOperationSource(), _streamingJobFunctionFunctionsClientDiagnostics, Pipeline, _streamingJobFunctionFunctionsRestClient.CreateTestRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tests if the information provided for a function is valid. This can range from testing the connection to the underlying web service behind the function or making sure the function code provided is syntactically correct.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}/test</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_Test</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> If the function specified does not already exist, this parameter must contain the full function definition intended to be tested. If the function specified already exists, this parameter can be left null to test the existing function as is or if specified, the properties specified will overwrite the corresponding properties in the existing function (exactly like a PATCH operation) and the resulting function will be tested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<StreamAnalyticsResourceTestStatus> Test(WaitUntil waitUntil, StreamingJobFunctionData data = null, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.Test");
            scope.Start();
            try
            {
                var response = _streamingJobFunctionFunctionsRestClient.Test(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new StreamAnalyticsArmOperation<StreamAnalyticsResourceTestStatus>(new StreamAnalyticsResourceTestStatusOperationSource(), _streamingJobFunctionFunctionsClientDiagnostics, Pipeline, _streamingJobFunctionFunctionsRestClient.CreateTestRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the default definition of a function based on the parameters specified.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}/retrieveDefaultDefinition</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_RetrieveDefaultDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters used to specify the type of function to retrieve the default definition for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<StreamingJobFunctionResource>> RetrieveDefaultDefinitionAsync(FunctionRetrieveDefaultDefinitionContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.RetrieveDefaultDefinition");
            scope.Start();
            try
            {
                var response = await _streamingJobFunctionFunctionsRestClient.RetrieveDefaultDefinitionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new StreamingJobFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the default definition of a function based on the parameters specified.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StreamAnalytics/streamingjobs/{jobName}/functions/{functionName}/retrieveDefaultDefinition</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Functions_RetrieveDefaultDefinition</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StreamingJobFunctionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters used to specify the type of function to retrieve the default definition for. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<StreamingJobFunctionResource> RetrieveDefaultDefinition(FunctionRetrieveDefaultDefinitionContent content = null, CancellationToken cancellationToken = default)
        {
            using var scope = _streamingJobFunctionFunctionsClientDiagnostics.CreateScope("StreamingJobFunctionResource.RetrieveDefaultDefinition");
            scope.Start();
            try
            {
                var response = _streamingJobFunctionFunctionsRestClient.RetrieveDefaultDefinition(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, cancellationToken);
                return Response.FromValue(new StreamingJobFunctionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
