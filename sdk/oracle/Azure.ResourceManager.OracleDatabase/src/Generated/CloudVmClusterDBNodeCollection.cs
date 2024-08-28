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

namespace Azure.ResourceManager.OracleDatabase
{
    /// <summary>
    /// A class representing a collection of <see cref="CloudVmClusterDBNodeResource"/> and their operations.
    /// Each <see cref="CloudVmClusterDBNodeResource"/> in the collection will belong to the same instance of <see cref="CloudVmClusterResource"/>.
    /// To get a <see cref="CloudVmClusterDBNodeCollection"/> instance call the GetCloudVmClusterDBNodes method from an instance of <see cref="CloudVmClusterResource"/>.
    /// </summary>
    public partial class CloudVmClusterDBNodeCollection : ArmCollection, IEnumerable<CloudVmClusterDBNodeResource>, IAsyncEnumerable<CloudVmClusterDBNodeResource>
    {
        private readonly ClientDiagnostics _cloudVmClusterDBNodeDBNodesClientDiagnostics;
        private readonly DbNodesRestOperations _cloudVmClusterDBNodeDBNodesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudVmClusterDBNodeCollection"/> class for mocking. </summary>
        protected CloudVmClusterDBNodeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudVmClusterDBNodeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CloudVmClusterDBNodeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cloudVmClusterDBNodeDBNodesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.OracleDatabase", CloudVmClusterDBNodeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CloudVmClusterDBNodeResource.ResourceType, out string cloudVmClusterDBNodeDBNodesApiVersion);
            _cloudVmClusterDBNodeDBNodesRestClient = new DbNodesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cloudVmClusterDBNodeDBNodesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CloudVmClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CloudVmClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a DbNode
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dbnodeocid"/> is null. </exception>
        public virtual async Task<Response<CloudVmClusterDBNodeResource>> GetAsync(string dbnodeocid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));

            using var scope = _cloudVmClusterDBNodeDBNodesClientDiagnostics.CreateScope("CloudVmClusterDBNodeCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterDBNodeDBNodesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dbnodeocid, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterDBNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DbNode
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dbnodeocid"/> is null. </exception>
        public virtual Response<CloudVmClusterDBNodeResource> Get(string dbnodeocid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));

            using var scope = _cloudVmClusterDBNodeDBNodesClientDiagnostics.CreateScope("CloudVmClusterDBNodeCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudVmClusterDBNodeDBNodesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dbnodeocid, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterDBNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DbNode resources by CloudVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_ListByCloudVmCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudVmClusterDBNodeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudVmClusterDBNodeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudVmClusterDBNodeDBNodesRestClient.CreateListByCloudVmClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudVmClusterDBNodeDBNodesRestClient.CreateListByCloudVmClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CloudVmClusterDBNodeResource(Client, CloudVmClusterDBNodeData.DeserializeCloudVmClusterDBNodeData(e)), _cloudVmClusterDBNodeDBNodesClientDiagnostics, Pipeline, "CloudVmClusterDBNodeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DbNode resources by CloudVmCluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_ListByCloudVmCluster</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudVmClusterDBNodeResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudVmClusterDBNodeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cloudVmClusterDBNodeDBNodesRestClient.CreateListByCloudVmClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _cloudVmClusterDBNodeDBNodesRestClient.CreateListByCloudVmClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CloudVmClusterDBNodeResource(Client, CloudVmClusterDBNodeData.DeserializeCloudVmClusterDBNodeData(e)), _cloudVmClusterDBNodeDBNodesClientDiagnostics, Pipeline, "CloudVmClusterDBNodeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dbnodeocid"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dbnodeocid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));

            using var scope = _cloudVmClusterDBNodeDBNodesClientDiagnostics.CreateScope("CloudVmClusterDBNodeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterDBNodeDBNodesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dbnodeocid, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dbnodeocid"/> is null. </exception>
        public virtual Response<bool> Exists(string dbnodeocid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));

            using var scope = _cloudVmClusterDBNodeDBNodesClientDiagnostics.CreateScope("CloudVmClusterDBNodeCollection.Exists");
            scope.Start();
            try
            {
                var response = _cloudVmClusterDBNodeDBNodesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dbnodeocid, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dbnodeocid"/> is null. </exception>
        public virtual async Task<NullableResponse<CloudVmClusterDBNodeResource>> GetIfExistsAsync(string dbnodeocid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));

            using var scope = _cloudVmClusterDBNodeDBNodesClientDiagnostics.CreateScope("CloudVmClusterDBNodeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudVmClusterDBNodeDBNodesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dbnodeocid, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CloudVmClusterDBNodeResource>(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterDBNodeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Oracle.Database/cloudVmClusters/{cloudvmclustername}/dbNodes/{dbnodeocid}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DbNodes_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CloudVmClusterDBNodeResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dbnodeocid"> DbNode OCID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dbnodeocid"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dbnodeocid"/> is null. </exception>
        public virtual NullableResponse<CloudVmClusterDBNodeResource> GetIfExists(string dbnodeocid, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dbnodeocid, nameof(dbnodeocid));

            using var scope = _cloudVmClusterDBNodeDBNodesClientDiagnostics.CreateScope("CloudVmClusterDBNodeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudVmClusterDBNodeDBNodesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dbnodeocid, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CloudVmClusterDBNodeResource>(response.GetRawResponse());
                return Response.FromValue(new CloudVmClusterDBNodeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CloudVmClusterDBNodeResource> IEnumerable<CloudVmClusterDBNodeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudVmClusterDBNodeResource> IAsyncEnumerable<CloudVmClusterDBNodeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
