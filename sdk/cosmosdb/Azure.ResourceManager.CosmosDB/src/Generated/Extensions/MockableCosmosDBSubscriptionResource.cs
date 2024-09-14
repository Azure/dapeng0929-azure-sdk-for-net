// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.CosmosDB.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableCosmosDBSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _cosmosDBAccountDatabaseAccountsClientDiagnostics;
        private DatabaseAccountsRestOperations _cosmosDBAccountDatabaseAccountsRestClient;
        private ClientDiagnostics _cassandraClusterClientDiagnostics;
        private CassandraClustersRestOperations _cassandraClusterRestClient;
        private ClientDiagnostics _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics;
        private RestorableDatabaseAccountsRestOperations _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableCosmosDBSubscriptionResource"/> class for mocking. </summary>
        protected MockableCosmosDBSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableCosmosDBSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableCosmosDBSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics CosmosDBAccountDatabaseAccountsClientDiagnostics => _cosmosDBAccountDatabaseAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CosmosDBAccountResource.ResourceType.Namespace, Diagnostics);
        private DatabaseAccountsRestOperations CosmosDBAccountDatabaseAccountsRestClient => _cosmosDBAccountDatabaseAccountsRestClient ??= new DatabaseAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CosmosDBAccountResource.ResourceType));
        private ClientDiagnostics CassandraClusterClientDiagnostics => _cassandraClusterClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CosmosDB", CassandraClusterResource.ResourceType.Namespace, Diagnostics);
        private CassandraClustersRestOperations CassandraClusterRestClient => _cassandraClusterRestClient ??= new CassandraClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CassandraClusterResource.ResourceType));
        private ClientDiagnostics RestorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics => _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.CosmosDB", RestorableCosmosDBAccountResource.ResourceType.Namespace, Diagnostics);
        private RestorableDatabaseAccountsRestOperations RestorableCosmosDBAccountRestorableDatabaseAccountsRestClient => _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient ??= new RestorableDatabaseAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(RestorableCosmosDBAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of CosmosDBLocationResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of CosmosDBLocationResources and their operations over a CosmosDBLocationResource. </returns>
        public virtual CosmosDBLocationCollection GetCosmosDBLocations()
        {
            return GetCachedClient(client => new CosmosDBLocationCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of an existing Cosmos DB location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual async Task<Response<CosmosDBLocationResource>> GetCosmosDBLocationAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            return await GetCosmosDBLocations().GetAsync(location, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of an existing Cosmos DB location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public virtual Response<CosmosDBLocationResource> GetCosmosDBLocation(AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetCosmosDBLocations().Get(location, cancellationToken);
        }

        /// <summary>
        /// Lists all the Azure Cosmos DB database accounts available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/databaseAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBAccountResource> GetCosmosDBAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CosmosDBAccountDatabaseAccountsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBAccountResource(Client, CosmosDBAccountData.DeserializeCosmosDBAccountData(e)), CosmosDBAccountDatabaseAccountsClientDiagnostics, Pipeline, "MockableCosmosDBSubscriptionResource.GetCosmosDBAccounts", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the Azure Cosmos DB database accounts available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/databaseAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseAccounts_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CosmosDBAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBAccountResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBAccountResource> GetCosmosDBAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CosmosDBAccountDatabaseAccountsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBAccountResource(Client, CosmosDBAccountData.DeserializeCosmosDBAccountData(e)), CosmosDBAccountDatabaseAccountsClientDiagnostics, Pipeline, "MockableCosmosDBSubscriptionResource.GetCosmosDBAccounts", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all managed Cassandra clusters in this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/cassandraClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraClusters_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CassandraClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CassandraClusterResource> GetCassandraClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CassandraClusterRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CassandraClusterResource(Client, CassandraClusterData.DeserializeCassandraClusterData(e)), CassandraClusterClientDiagnostics, Pipeline, "MockableCosmosDBSubscriptionResource.GetCassandraClusters", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all managed Cassandra clusters in this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/cassandraClusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CassandraClusters_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CassandraClusterResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CassandraClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CassandraClusterResource> GetCassandraClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CassandraClusterRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CassandraClusterResource(Client, CassandraClusterData.DeserializeCassandraClusterData(e)), CassandraClusterClientDiagnostics, Pipeline, "MockableCosmosDBSubscriptionResource.GetCassandraClusters", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription. This call requires 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read' permission.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/restorableDatabaseAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_List</description>
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
        public virtual AsyncPageable<RestorableCosmosDBAccountResource> GetRestorableCosmosDBAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestorableCosmosDBAccountRestorableDatabaseAccountsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new RestorableCosmosDBAccountResource(Client, RestorableCosmosDBAccountData.DeserializeRestorableCosmosDBAccountData(e)), RestorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics, Pipeline, "MockableCosmosDBSubscriptionResource.GetRestorableCosmosDBAccounts", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all the restorable Azure Cosmos DB database accounts available under the subscription. This call requires 'Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read' permission.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/restorableDatabaseAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RestorableDatabaseAccounts_List</description>
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
        public virtual Pageable<RestorableCosmosDBAccountResource> GetRestorableCosmosDBAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestorableCosmosDBAccountRestorableDatabaseAccountsRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new RestorableCosmosDBAccountResource(Client, RestorableCosmosDBAccountData.DeserializeRestorableCosmosDBAccountData(e)), RestorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics, Pipeline, "MockableCosmosDBSubscriptionResource.GetRestorableCosmosDBAccounts", "value", null, cancellationToken);
        }
    }
}
