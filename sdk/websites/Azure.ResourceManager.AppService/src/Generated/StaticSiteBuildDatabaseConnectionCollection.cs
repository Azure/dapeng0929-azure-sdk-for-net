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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="StaticSiteBuildDatabaseConnectionResource" /> and their operations.
    /// Each <see cref="StaticSiteBuildDatabaseConnectionResource" /> in the collection will belong to the same instance of <see cref="StaticSiteBuildResource" />.
    /// To get a <see cref="StaticSiteBuildDatabaseConnectionCollection" /> instance call the GetStaticSiteBuildDatabaseConnections method from an instance of <see cref="StaticSiteBuildResource" />.
    /// </summary>
    public partial class StaticSiteBuildDatabaseConnectionCollection : ArmCollection, IEnumerable<StaticSiteBuildDatabaseConnectionResource>, IAsyncEnumerable<StaticSiteBuildDatabaseConnectionResource>
    {
        private readonly ClientDiagnostics _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteBuildDatabaseConnectionStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildDatabaseConnectionCollection"/> class for mocking. </summary>
        protected StaticSiteBuildDatabaseConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteBuildDatabaseConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteBuildDatabaseConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteBuildDatabaseConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StaticSiteBuildDatabaseConnectionResource.ResourceType, out string staticSiteBuildDatabaseConnectionStaticSitesApiVersion);
            _staticSiteBuildDatabaseConnectionStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteBuildDatabaseConnectionStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteBuildResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteBuildResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Create or update a database connection for a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateBuildDatabaseConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseConnectionName"> Name of the database connection. </param>
        /// <param name="data"> A JSON representation of the database connection request properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteBuildDatabaseConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string databaseConnectionName, DatabaseConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseConnectionName, nameof(databaseConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildDatabaseConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildDatabaseConnectionStaticSitesRestClient.CreateOrUpdateBuildDatabaseConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteBuildDatabaseConnectionResource>(Response.FromValue(new StaticSiteBuildDatabaseConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Description for Create or update a database connection for a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_CreateOrUpdateBuildDatabaseConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="databaseConnectionName"> Name of the database connection. </param>
        /// <param name="data"> A JSON representation of the database connection request properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StaticSiteBuildDatabaseConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string databaseConnectionName, DatabaseConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseConnectionName, nameof(databaseConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildDatabaseConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteBuildDatabaseConnectionStaticSitesRestClient.CreateOrUpdateBuildDatabaseConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseConnectionName, data, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteBuildDatabaseConnectionResource>(Response.FromValue(new StaticSiteBuildDatabaseConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Returns overview of a database connection for a static site build by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetBuildDatabaseConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseConnectionName"> Name of the database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseConnectionName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteBuildDatabaseConnectionResource>> GetAsync(string databaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseConnectionName, nameof(databaseConnectionName));

            using var scope = _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildDatabaseConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildDatabaseConnectionStaticSitesRestClient.GetBuildDatabaseConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns overview of a database connection for a static site build by name
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetBuildDatabaseConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseConnectionName"> Name of the database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseConnectionName"/> is null. </exception>
        public virtual Response<StaticSiteBuildDatabaseConnectionResource> Get(string databaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseConnectionName, nameof(databaseConnectionName));

            using var scope = _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildDatabaseConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteBuildDatabaseConnectionStaticSitesRestClient.GetBuildDatabaseConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns overviews of database connections for a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetBuildDatabaseConnections</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteBuildDatabaseConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteBuildDatabaseConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildDatabaseConnectionStaticSitesRestClient.CreateGetBuildDatabaseConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildDatabaseConnectionStaticSitesRestClient.CreateGetBuildDatabaseConnectionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StaticSiteBuildDatabaseConnectionResource(Client, DatabaseConnectionData.DeserializeDatabaseConnectionData(e)), _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildDatabaseConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns overviews of database connections for a static site build
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetBuildDatabaseConnections</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteBuildDatabaseConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteBuildDatabaseConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _staticSiteBuildDatabaseConnectionStaticSitesRestClient.CreateGetBuildDatabaseConnectionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _staticSiteBuildDatabaseConnectionStaticSitesRestClient.CreateGetBuildDatabaseConnectionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StaticSiteBuildDatabaseConnectionResource(Client, DatabaseConnectionData.DeserializeDatabaseConnectionData(e)), _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics, Pipeline, "StaticSiteBuildDatabaseConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetBuildDatabaseConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseConnectionName"> Name of the database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string databaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseConnectionName, nameof(databaseConnectionName));

            using var scope = _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildDatabaseConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildDatabaseConnectionStaticSitesRestClient.GetBuildDatabaseConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetBuildDatabaseConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseConnectionName"> Name of the database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string databaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseConnectionName, nameof(databaseConnectionName));

            using var scope = _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildDatabaseConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _staticSiteBuildDatabaseConnectionStaticSitesRestClient.GetBuildDatabaseConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseConnectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetBuildDatabaseConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseConnectionName"> Name of the database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<StaticSiteBuildDatabaseConnectionResource>> GetIfExistsAsync(string databaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseConnectionName, nameof(databaseConnectionName));

            using var scope = _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildDatabaseConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _staticSiteBuildDatabaseConnectionStaticSitesRestClient.GetBuildDatabaseConnectionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StaticSiteBuildDatabaseConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/builds/{environmentName}/databaseConnections/{databaseConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StaticSites_GetBuildDatabaseConnection</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="databaseConnectionName"> Name of the database connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="databaseConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseConnectionName"/> is null. </exception>
        public virtual NullableResponse<StaticSiteBuildDatabaseConnectionResource> GetIfExists(string databaseConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(databaseConnectionName, nameof(databaseConnectionName));

            using var scope = _staticSiteBuildDatabaseConnectionStaticSitesClientDiagnostics.CreateScope("StaticSiteBuildDatabaseConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _staticSiteBuildDatabaseConnectionStaticSitesRestClient.GetBuildDatabaseConnection(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, databaseConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StaticSiteBuildDatabaseConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new StaticSiteBuildDatabaseConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteBuildDatabaseConnectionResource> IEnumerable<StaticSiteBuildDatabaseConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteBuildDatabaseConnectionResource> IAsyncEnumerable<StaticSiteBuildDatabaseConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
