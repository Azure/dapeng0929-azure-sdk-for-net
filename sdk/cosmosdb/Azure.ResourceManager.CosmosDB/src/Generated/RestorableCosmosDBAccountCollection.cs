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

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing a collection of <see cref="RestorableCosmosDBAccountResource"/> and their operations.
    /// Each <see cref="RestorableCosmosDBAccountResource"/> in the collection will belong to the same instance of <see cref="CosmosDBLocationResource"/>.
    /// To get a <see cref="RestorableCosmosDBAccountCollection"/> instance call the GetRestorableCosmosDBAccounts method from an instance of <see cref="CosmosDBLocationResource"/>.
    /// </summary>
    public partial class RestorableCosmosDBAccountCollection : ArmCollection, IEnumerable<RestorableCosmosDBAccountResource>, IAsyncEnumerable<RestorableCosmosDBAccountResource>
    {
        private readonly ClientDiagnostics _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics;
        private readonly RestorableDatabaseAccountsRestOperations _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RestorableCosmosDBAccountCollection"/> class for mocking. </summary>
        protected RestorableCosmosDBAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableCosmosDBAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RestorableCosmosDBAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", RestorableCosmosDBAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RestorableCosmosDBAccountResource.ResourceType, out string restorableCosmosDBAccountRestorableDatabaseAccountsApiVersion);
            _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient = new RestorableDatabaseAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, restorableCosmosDBAccountRestorableDatabaseAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBLocationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBLocationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*' permission.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_GetByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableCosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RestorableCosmosDBAccountResource>> GetAsync(Guid instanceId, CancellationToken cancellationToken = default)
        {
            using var scope = _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics.CreateScope("RestorableCosmosDBAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.GetByLocationAsync(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableCosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*' permission.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_GetByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableCosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RestorableCosmosDBAccountResource> Get(Guid instanceId, CancellationToken cancellationToken = default)
        {
            using var scope = _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics.CreateScope("RestorableCosmosDBAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.GetByLocation(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableCosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read' permission.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableCosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableCosmosDBAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableCosmosDBAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new RestorableCosmosDBAccountResource(Client, RestorableCosmosDBAccountData.DeserializeRestorableCosmosDBAccountData(e)), _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics, Pipeline, "RestorableCosmosDBAccountCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription and in a region.  This call requires 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read' permission.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_ListByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableCosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableCosmosDBAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableCosmosDBAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.CreateListByLocationRequest(Id.SubscriptionId, new AzureLocation(Id.Name));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new RestorableCosmosDBAccountResource(Client, RestorableCosmosDBAccountData.DeserializeRestorableCosmosDBAccountData(e)), _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics, Pipeline, "RestorableCosmosDBAccountCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_GetByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableCosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid instanceId, CancellationToken cancellationToken = default)
        {
            using var scope = _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics.CreateScope("RestorableCosmosDBAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.GetByLocationAsync(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_GetByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableCosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid instanceId, CancellationToken cancellationToken = default)
        {
            using var scope = _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics.CreateScope("RestorableCosmosDBAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.GetByLocation(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_GetByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableCosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<RestorableCosmosDBAccountResource>> GetIfExistsAsync(Guid instanceId, CancellationToken cancellationToken = default)
        {
            using var scope = _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics.CreateScope("RestorableCosmosDBAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.GetByLocationAsync(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RestorableCosmosDBAccountResource>(response.GetRawResponse());
                return Response.FromValue(new RestorableCosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_GetByLocation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RestorableCosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<RestorableCosmosDBAccountResource> GetIfExists(Guid instanceId, CancellationToken cancellationToken = default)
        {
            using var scope = _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics.CreateScope("RestorableCosmosDBAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.GetByLocation(Id.SubscriptionId, new AzureLocation(Id.Name), instanceId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RestorableCosmosDBAccountResource>(response.GetRawResponse());
                return Response.FromValue(new RestorableCosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RestorableCosmosDBAccountResource> IEnumerable<RestorableCosmosDBAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RestorableCosmosDBAccountResource> IAsyncEnumerable<RestorableCosmosDBAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
