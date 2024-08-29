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
    /// A class representing a collection of <see cref="RoutingRuleResource"/> and their operations.
    /// Each <see cref="RoutingRuleResource"/> in the collection will belong to the same instance of <see cref="RoutingRuleCollectionResource"/>.
    /// To get a <see cref="RoutingRuleCollection"/> instance call the GetRoutingRules method from an instance of <see cref="RoutingRuleCollectionResource"/>.
    /// </summary>
    public partial class RoutingRuleCollection : ArmCollection, IEnumerable<RoutingRuleResource>, IAsyncEnumerable<RoutingRuleResource>
    {
        private readonly ClientDiagnostics _routingRuleClientDiagnostics;
        private readonly RoutingRulesRestOperations _routingRuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoutingRuleCollection"/> class for mocking. </summary>
        protected RoutingRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoutingRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoutingRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _routingRuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", RoutingRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoutingRuleResource.ResourceType, out string routingRuleApiVersion);
            _routingRuleRestClient = new RoutingRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, routingRuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RoutingRuleCollectionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RoutingRuleCollectionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an routing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="data"> The routing rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RoutingRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleName, RoutingRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _routingRuleClientDiagnostics.CreateScope("RoutingRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routingRuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, data, cancellationToken).ConfigureAwait(false);
                var uri = _routingRuleRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<RoutingRuleResource>(Response.FromValue(new RoutingRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Creates or updates an routing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="data"> The routing rule to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RoutingRuleResource> CreateOrUpdate(WaitUntil waitUntil, string ruleName, RoutingRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _routingRuleClientDiagnostics.CreateScope("RoutingRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routingRuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, data, cancellationToken);
                var uri = _routingRuleRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new NetworkArmOperation<RoutingRuleResource>(Response.FromValue(new RoutingRuleResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Gets a network manager routing configuration routing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<RoutingRuleResource>> GetAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _routingRuleClientDiagnostics.CreateScope("RoutingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _routingRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoutingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a network manager routing configuration routing rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<RoutingRuleResource> Get(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _routingRuleClientDiagnostics.CreateScope("RoutingRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _routingRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoutingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all network manager routing configuration routing rules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoutingRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoutingRuleResource> GetAllAsync(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _routingRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _routingRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RoutingRuleResource(Client, RoutingRuleData.DeserializeRoutingRuleData(e)), _routingRuleClientDiagnostics, Pipeline, "RoutingRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all network manager routing configuration routing rules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> An optional query parameter which specifies the maximum number of records to be returned by the server. </param>
        /// <param name="skipToken"> SkipToken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoutingRuleResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoutingRuleResource> GetAll(int? top = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _routingRuleRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, top, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _routingRuleRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, top, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RoutingRuleResource(Client, RoutingRuleData.DeserializeRoutingRuleData(e)), _routingRuleClientDiagnostics, Pipeline, "RoutingRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _routingRuleClientDiagnostics.CreateScope("RoutingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _routingRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _routingRuleClientDiagnostics.CreateScope("RoutingRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _routingRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<NullableResponse<RoutingRuleResource>> GetIfExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _routingRuleClientDiagnostics.CreateScope("RoutingRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _routingRuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RoutingRuleResource>(response.GetRawResponse());
                return Response.FromValue(new RoutingRuleResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/networkManagers/{networkManagerName}/routingConfigurations/{configurationName}/ruleCollections/{ruleCollectionName}/rules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoutingRules_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RoutingRuleResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The name of the rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual NullableResponse<RoutingRuleResource> GetIfExists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _routingRuleClientDiagnostics.CreateScope("RoutingRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routingRuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, ruleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RoutingRuleResource>(response.GetRawResponse());
                return Response.FromValue(new RoutingRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoutingRuleResource> IEnumerable<RoutingRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoutingRuleResource> IAsyncEnumerable<RoutingRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
