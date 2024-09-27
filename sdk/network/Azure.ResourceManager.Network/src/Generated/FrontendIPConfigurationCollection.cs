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
    /// A class representing a collection of <see cref="FrontendIPConfigurationResource"/> and their operations.
    /// Each <see cref="FrontendIPConfigurationResource"/> in the collection will belong to the same instance of <see cref="LoadBalancerResource"/>.
    /// To get a <see cref="FrontendIPConfigurationCollection"/> instance call the GetFrontendIPConfigurations method from an instance of <see cref="LoadBalancerResource"/>.
    /// </summary>
    public partial class FrontendIPConfigurationCollection : ArmCollection, IEnumerable<FrontendIPConfigurationResource>, IAsyncEnumerable<FrontendIPConfigurationResource>
    {
        private readonly ClientDiagnostics _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics;
        private readonly LoadBalancerFrontendIPConfigurationsRestOperations _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontendIPConfigurationCollection"/> class for mocking. </summary>
        protected FrontendIPConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontendIPConfigurationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontendIPConfigurationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", FrontendIPConfigurationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontendIPConfigurationResource.ResourceType, out string frontendIPConfigurationLoadBalancerFrontendIPConfigurationsApiVersion);
            _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient = new LoadBalancerFrontendIPConfigurationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontendIPConfigurationLoadBalancerFrontendIPConfigurationsApiVersion);
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
        /// Gets load balancer frontend IP configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual async Task<Response<FrontendIPConfigurationResource>> GetAsync(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets load balancer frontend IP configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual Response<FrontendIPConfigurationResource> Get(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the load balancer frontend IP configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontendIPConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontendIPConfigurationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontendIPConfigurationResource(Client, FrontendIPConfigurationData.DeserializeFrontendIPConfigurationData(e)), _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics, Pipeline, "FrontendIPConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all the load balancer frontend IP configurations.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontendIPConfigurationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontendIPConfigurationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontendIPConfigurationResource(Client, FrontendIPConfigurationData.DeserializeFrontendIPConfigurationData(e)), _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics, Pipeline, "FrontendIPConfigurationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual Response<bool> Exists(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual async Task<NullableResponse<FrontendIPConfigurationResource>> GetIfExistsAsync(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FrontendIPConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfigurationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/frontendIPConfigurations/{frontendIPConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LoadBalancerFrontendIPConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="FrontendIPConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="frontendIPConfigurationName"> The name of the frontend IP configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="frontendIPConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="frontendIPConfigurationName"/> is null. </exception>
        public virtual NullableResponse<FrontendIPConfigurationResource> GetIfExists(string frontendIPConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(frontendIPConfigurationName, nameof(frontendIPConfigurationName));

            using var scope = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsClientDiagnostics.CreateScope("FrontendIPConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _frontendIPConfigurationLoadBalancerFrontendIPConfigurationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, frontendIPConfigurationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FrontendIPConfigurationResource>(response.GetRawResponse());
                return Response.FromValue(new FrontendIPConfigurationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontendIPConfigurationResource> IEnumerable<FrontendIPConfigurationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontendIPConfigurationResource> IAsyncEnumerable<FrontendIPConfigurationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
