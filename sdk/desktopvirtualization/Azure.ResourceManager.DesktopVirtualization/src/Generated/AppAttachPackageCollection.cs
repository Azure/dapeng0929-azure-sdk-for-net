// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="AppAttachPackageResource"/> and their operations.
    /// Each <see cref="AppAttachPackageResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="AppAttachPackageCollection"/> instance call the GetAppAttachPackages method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class AppAttachPackageCollection : ArmCollection, IEnumerable<AppAttachPackageResource>, IAsyncEnumerable<AppAttachPackageResource>
    {
        private readonly ClientDiagnostics _appAttachPackageClientDiagnostics;
        private readonly AppAttachPackageRestOperations _appAttachPackageRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppAttachPackageCollection"/> class for mocking. </summary>
        protected AppAttachPackageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppAttachPackageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AppAttachPackageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appAttachPackageClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", AppAttachPackageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AppAttachPackageResource.ResourceType, out string appAttachPackageApiVersion);
            _appAttachPackageRestClient = new AppAttachPackageRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appAttachPackageApiVersion);
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
        /// Create or update an App Attach package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="appAttachPackageName"> The name of the App Attach package arm object. </param>
        /// <param name="data"> Object containing App Attach Package definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppAttachPackageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string appAttachPackageName, AppAttachPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appAttachPackageName, nameof(appAttachPackageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appAttachPackageClientDiagnostics.CreateScope("AppAttachPackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appAttachPackageRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, data, cancellationToken).ConfigureAwait(false);
                var uri = _appAttachPackageRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation<AppAttachPackageResource>(Response.FromValue(new AppAttachPackageResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update an App Attach package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="appAttachPackageName"> The name of the App Attach package arm object. </param>
        /// <param name="data"> Object containing App Attach Package definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppAttachPackageResource> CreateOrUpdate(WaitUntil waitUntil, string appAttachPackageName, AppAttachPackageData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appAttachPackageName, nameof(appAttachPackageName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appAttachPackageClientDiagnostics.CreateScope("AppAttachPackageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appAttachPackageRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, data, cancellationToken);
                var uri = _appAttachPackageRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation<AppAttachPackageResource>(Response.FromValue(new AppAttachPackageResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Get an app attach package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appAttachPackageName"> The name of the App Attach package arm object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> is null. </exception>
        public virtual async Task<Response<AppAttachPackageResource>> GetAsync(string appAttachPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appAttachPackageName, nameof(appAttachPackageName));

            using var scope = _appAttachPackageClientDiagnostics.CreateScope("AppAttachPackageCollection.Get");
            scope.Start();
            try
            {
                var response = await _appAttachPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppAttachPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an app attach package.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appAttachPackageName"> The name of the App Attach package arm object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> is null. </exception>
        public virtual Response<AppAttachPackageResource> Get(string appAttachPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appAttachPackageName, nameof(appAttachPackageName));

            using var scope = _appAttachPackageClientDiagnostics.CreateScope("AppAttachPackageCollection.Get");
            scope.Start();
            try
            {
                var response = _appAttachPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppAttachPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List App Attach packages in resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are package name, host pool, package owner name, and custom data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppAttachPackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppAttachPackageResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appAttachPackageRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appAttachPackageRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AppAttachPackageResource(Client, AppAttachPackageData.DeserializeAppAttachPackageData(e)), _appAttachPackageClientDiagnostics, Pipeline, "AppAttachPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List App Attach packages in resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> OData filter expression. Valid properties for filtering are package name, host pool, package owner name, and custom data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppAttachPackageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppAttachPackageResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _appAttachPackageRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _appAttachPackageRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AppAttachPackageResource(Client, AppAttachPackageData.DeserializeAppAttachPackageData(e)), _appAttachPackageClientDiagnostics, Pipeline, "AppAttachPackageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appAttachPackageName"> The name of the App Attach package arm object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string appAttachPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appAttachPackageName, nameof(appAttachPackageName));

            using var scope = _appAttachPackageClientDiagnostics.CreateScope("AppAttachPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _appAttachPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appAttachPackageName"> The name of the App Attach package arm object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> is null. </exception>
        public virtual Response<bool> Exists(string appAttachPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appAttachPackageName, nameof(appAttachPackageName));

            using var scope = _appAttachPackageClientDiagnostics.CreateScope("AppAttachPackageCollection.Exists");
            scope.Start();
            try
            {
                var response = _appAttachPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appAttachPackageName"> The name of the App Attach package arm object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> is null. </exception>
        public virtual async Task<NullableResponse<AppAttachPackageResource>> GetIfExistsAsync(string appAttachPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appAttachPackageName, nameof(appAttachPackageName));

            using var scope = _appAttachPackageClientDiagnostics.CreateScope("AppAttachPackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appAttachPackageRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AppAttachPackageResource>(response.GetRawResponse());
                return Response.FromValue(new AppAttachPackageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/appAttachPackages/{appAttachPackageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AppAttachPackage_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppAttachPackageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="appAttachPackageName"> The name of the App Attach package arm object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="appAttachPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="appAttachPackageName"/> is null. </exception>
        public virtual NullableResponse<AppAttachPackageResource> GetIfExists(string appAttachPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(appAttachPackageName, nameof(appAttachPackageName));

            using var scope = _appAttachPackageClientDiagnostics.CreateScope("AppAttachPackageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appAttachPackageRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, appAttachPackageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AppAttachPackageResource>(response.GetRawResponse());
                return Response.FromValue(new AppAttachPackageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AppAttachPackageResource> IEnumerable<AppAttachPackageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppAttachPackageResource> IAsyncEnumerable<AppAttachPackageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
