// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkbookResource" /> and their operations.
    /// Each <see cref="WorkbookResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="WorkbookCollection" /> instance call the GetWorkbooks method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class WorkbookCollection : ArmCollection
    {
        private readonly ClientDiagnostics _workbookClientDiagnostics;
        private readonly WorkbooksRestOperations _workbookRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkbookCollection"/> class for mocking. </summary>
        protected WorkbookCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkbookCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkbookCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workbookClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApplicationInsights", WorkbookResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkbookResource.ResourceType, out string workbookApiVersion);
            _workbookRestClient = new WorkbooksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workbookApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new workbook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the workbook resource. The value must be an UUID. </param>
        /// <param name="data"> Properties that need to be specified to create a new workbook. </param>
        /// <param name="sourceId"> Azure Resource Id that will fetch all linked workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkbookResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceName, WorkbookData data, string sourceId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workbookClientDiagnostics.CreateScope("WorkbookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workbookRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, sourceId, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationInsightsArmOperation<WorkbookResource>(Response.FromValue(new WorkbookResource(Client, response), response.GetRawResponse()));
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
        /// Create a new workbook.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the workbook resource. The value must be an UUID. </param>
        /// <param name="data"> Properties that need to be specified to create a new workbook. </param>
        /// <param name="sourceId"> Azure Resource Id that will fetch all linked workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkbookResource> CreateOrUpdate(WaitUntil waitUntil, string resourceName, WorkbookData data, string sourceId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workbookClientDiagnostics.CreateScope("WorkbookCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workbookRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resourceName, data, sourceId, cancellationToken);
                var operation = new ApplicationInsightsArmOperation<WorkbookResource>(Response.FromValue(new WorkbookResource(Client, response), response.GetRawResponse()));
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
        /// Get a single workbook by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the workbook resource. The value must be an UUID. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<WorkbookResource>> GetAsync(string resourceName, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _workbookClientDiagnostics.CreateScope("WorkbookCollection.Get");
            scope.Start();
            try
            {
                var response = await _workbookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, canFetchContent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a single workbook by its resourceName.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the workbook resource. The value must be an UUID. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<WorkbookResource> Get(string resourceName, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _workbookClientDiagnostics.CreateScope("WorkbookCollection.Get");
            scope.Start();
            try
            {
                var response = _workbookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, canFetchContent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all Workbooks defined within a specified resource group and category.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="category"> Category of workbook to return. </param>
        /// <param name="tags"> Tags presents on each workbook returned. </param>
        /// <param name="sourceId"> Azure Resource Id that will fetch all linked workbooks. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkbookResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkbookResource> GetAllAsync(CategoryType category, IEnumerable<string> tags = null, string sourceId = null, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workbookRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, category, tags, sourceId, canFetchContent);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workbookRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, category, tags, sourceId, canFetchContent);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkbookResource(Client, WorkbookData.DeserializeWorkbookData(e)), _workbookClientDiagnostics, Pipeline, "WorkbookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all Workbooks defined within a specified resource group and category.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="category"> Category of workbook to return. </param>
        /// <param name="tags"> Tags presents on each workbook returned. </param>
        /// <param name="sourceId"> Azure Resource Id that will fetch all linked workbooks. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkbookResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkbookResource> GetAll(CategoryType category, IEnumerable<string> tags = null, string sourceId = null, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workbookRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, category, tags, sourceId, canFetchContent);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workbookRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, category, tags, sourceId, canFetchContent);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkbookResource(Client, WorkbookData.DeserializeWorkbookData(e)), _workbookClientDiagnostics, Pipeline, "WorkbookCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the workbook resource. The value must be an UUID. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _workbookClientDiagnostics.CreateScope("WorkbookCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workbookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, canFetchContent, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the workbook resource. The value must be an UUID. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _workbookClientDiagnostics.CreateScope("WorkbookCollection.Exists");
            scope.Start();
            try
            {
                var response = _workbookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, canFetchContent, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the workbook resource. The value must be an UUID. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<WorkbookResource>> GetIfExistsAsync(string resourceName, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _workbookClientDiagnostics.CreateScope("WorkbookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _workbookRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, canFetchContent, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WorkbookResource>(response.GetRawResponse());
                return Response.FromValue(new WorkbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/workbooks/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workbooks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the workbook resource. The value must be an UUID. </param>
        /// <param name="canFetchContent"> Flag indicating whether or not to return the full content for each applicable workbook. If false, only return summary content for workbooks. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual NullableResponse<WorkbookResource> GetIfExists(string resourceName, bool? canFetchContent = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _workbookClientDiagnostics.CreateScope("WorkbookCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workbookRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, canFetchContent, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WorkbookResource>(response.GetRawResponse());
                return Response.FromValue(new WorkbookResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
