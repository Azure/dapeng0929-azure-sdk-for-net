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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="UserSessionResource"/> and their operations.
    /// Each <see cref="UserSessionResource"/> in the collection will belong to the same instance of <see cref="SessionHostResource"/>.
    /// To get an <see cref="UserSessionCollection"/> instance call the GetUserSessions method from an instance of <see cref="SessionHostResource"/>.
    /// </summary>
    public partial class UserSessionCollection : ArmCollection, IEnumerable<UserSessionResource>, IAsyncEnumerable<UserSessionResource>
    {
        private readonly ClientDiagnostics _userSessionClientDiagnostics;
        private readonly UserSessionsRestOperations _userSessionRestClient;

        /// <summary> Initializes a new instance of the <see cref="UserSessionCollection"/> class for mocking. </summary>
        protected UserSessionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="UserSessionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal UserSessionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _userSessionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", UserSessionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(UserSessionResource.ResourceType, out string userSessionApiVersion);
            _userSessionRestClient = new UserSessionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, userSessionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SessionHostResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SessionHostResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a userSession.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userSessionId"> The name of the user session within the specified session host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userSessionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userSessionId"/> is null. </exception>
        public virtual async Task<Response<UserSessionResource>> GetAsync(string userSessionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userSessionId, nameof(userSessionId));

            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionCollection.Get");
            scope.Start();
            try
            {
                var response = await _userSessionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userSessionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UserSessionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a userSession.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userSessionId"> The name of the user session within the specified session host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userSessionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userSessionId"/> is null. </exception>
        public virtual Response<UserSessionResource> Get(string userSessionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userSessionId, nameof(userSessionId));

            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionCollection.Get");
            scope.Start();
            try
            {
                var response = _userSessionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userSessionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UserSessionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List userSessions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="UserSessionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<UserSessionResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _userSessionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _userSessionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new UserSessionResource(Client, UserSessionData.DeserializeUserSessionData(e)), _userSessionClientDiagnostics, Pipeline, "UserSessionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List userSessions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="UserSessionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<UserSessionResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _userSessionRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _userSessionRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new UserSessionResource(Client, UserSessionData.DeserializeUserSessionData(e)), _userSessionClientDiagnostics, Pipeline, "UserSessionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userSessionId"> The name of the user session within the specified session host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userSessionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userSessionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string userSessionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userSessionId, nameof(userSessionId));

            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _userSessionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userSessionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userSessionId"> The name of the user session within the specified session host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userSessionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userSessionId"/> is null. </exception>
        public virtual Response<bool> Exists(string userSessionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userSessionId, nameof(userSessionId));

            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionCollection.Exists");
            scope.Start();
            try
            {
                var response = _userSessionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userSessionId, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userSessionId"> The name of the user session within the specified session host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userSessionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userSessionId"/> is null. </exception>
        public virtual async Task<NullableResponse<UserSessionResource>> GetIfExistsAsync(string userSessionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userSessionId, nameof(userSessionId));

            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _userSessionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userSessionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<UserSessionResource>(response.GetRawResponse());
                return Response.FromValue(new UserSessionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UserSessions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="UserSessionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="userSessionId"> The name of the user session within the specified session host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="userSessionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="userSessionId"/> is null. </exception>
        public virtual NullableResponse<UserSessionResource> GetIfExists(string userSessionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(userSessionId, nameof(userSessionId));

            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _userSessionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, userSessionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<UserSessionResource>(response.GetRawResponse());
                return Response.FromValue(new UserSessionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<UserSessionResource> IEnumerable<UserSessionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<UserSessionResource> IAsyncEnumerable<UserSessionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
