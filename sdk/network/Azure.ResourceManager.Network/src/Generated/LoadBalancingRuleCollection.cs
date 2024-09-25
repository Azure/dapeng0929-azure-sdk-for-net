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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="LoadBalancingRuleResource"/> and their operations.
    /// Each <see cref="LoadBalancingRuleResource"/> in the collection will belong to the same instance of <see cref="LoadBalancerResource"/>.
    /// To get a <see cref="LoadBalancingRuleCollection"/> instance call the GetLoadBalancingRules method from an instance of <see cref="LoadBalancerResource"/>.
    /// </summary>
    public partial class LoadBalancingRuleCollection : ArmCollection, IEnumerable<LoadBalancingRuleResource>, IAsyncEnumerable<LoadBalancingRuleResource>
    {
        private readonly ClientDiagnostics _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics;
        private readonly LoadBalancerLoadBalancingRulesRestOperations _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="LoadBalancingRuleCollection"/> class for mocking. </summary>
        protected LoadBalancingRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LoadBalancingRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LoadBalancingRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", LoadBalancingRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LoadBalancingRuleResource.ResourceType, out string loadBalancingRuleLoadBalancerLoadBalancingRulesApiVersion);
            _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient = new LoadBalancerLoadBalancingRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, loadBalancingRuleLoadBalancerLoadBalancingRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != LoadBalancerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, LoadBalancerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified load balancer load balancing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual async Task<Response<LoadBalancingRuleResource>> GetAsync(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified load balancer load balancing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual Response<LoadBalancingRuleResource> Get(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the load balancing rules in a load balancer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LoadBalancingRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LoadBalancingRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new LoadBalancingRuleResource(Client, LoadBalancingRuleData.DeserializeLoadBalancingRuleData(e)), _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics, Pipeline, "LoadBalancingRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the load balancing rules in a load balancer.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LoadBalancingRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LoadBalancingRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new LoadBalancingRuleResource(Client, LoadBalancingRuleData.DeserializeLoadBalancingRuleData(e)), _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics, Pipeline, "LoadBalancingRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<LoadBalancingRuleResource>> GetIfExistsAsync(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<LoadBalancingRuleResource>(response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/loadBalancingRules/{loadBalancingRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerLoadBalancingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LoadBalancingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loadBalancingRuleName"> The name of the load balancing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loadBalancingRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loadBalancingRuleName"/> is null. </exception>
        public virtual NullableResponse<LoadBalancingRuleResource> GetIfExists(string loadBalancingRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loadBalancingRuleName, nameof(loadBalancingRuleName));

            using var scope = _loadBalancingRuleLoadBalancerLoadBalancingRulesClientDiagnostics.CreateScope("LoadBalancingRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _loadBalancingRuleLoadBalancerLoadBalancingRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loadBalancingRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<LoadBalancingRuleResource>(response.GetRawResponse());
                return Response.FromValue(new LoadBalancingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LoadBalancingRuleResource> IEnumerable<LoadBalancingRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LoadBalancingRuleResource> IAsyncEnumerable<LoadBalancingRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
