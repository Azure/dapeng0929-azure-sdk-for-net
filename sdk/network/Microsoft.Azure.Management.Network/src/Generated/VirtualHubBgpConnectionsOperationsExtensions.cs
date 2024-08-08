// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualHubBgpConnectionsOperations.
    /// </summary>
    public static partial class VirtualHubBgpConnectionsOperationsExtensions
    {
            /// <summary>
            /// Retrieves the details of all VirtualHubBgpConnections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            public static IPage<BgpConnection> List(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string virtualHubName)
            {
                return operations.ListAsync(resourceGroupName, virtualHubName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of all VirtualHubBgpConnections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VirtualHub.
            /// </param>
            /// <param name='virtualHubName'>
            /// The name of the VirtualHub.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BgpConnection>> ListAsync(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a list of routes the virtual hub bgp connection has learned.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the virtual hub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the virtual hub bgp connection.
            /// </param>
            public static IDictionary<string, IList<PeerRoute>> ListLearnedRoutes(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string hubName, string connectionName)
            {
                return operations.ListLearnedRoutesAsync(resourceGroupName, hubName, connectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a list of routes the virtual hub bgp connection has learned.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the virtual hub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the virtual hub bgp connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, IList<PeerRoute>>> ListLearnedRoutesAsync(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string hubName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListLearnedRoutesWithHttpMessagesAsync(resourceGroupName, hubName, connectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a list of routes the virtual hub bgp connection is advertising to
            /// the specified peer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the virtual hub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the virtual hub bgp connection.
            /// </param>
            public static IDictionary<string, IList<PeerRoute>> ListAdvertisedRoutes(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string hubName, string connectionName)
            {
                return operations.ListAdvertisedRoutesAsync(resourceGroupName, hubName, connectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a list of routes the virtual hub bgp connection is advertising to
            /// the specified peer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the virtual hub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the virtual hub bgp connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, IList<PeerRoute>>> ListAdvertisedRoutesAsync(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string hubName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAdvertisedRoutesWithHttpMessagesAsync(resourceGroupName, hubName, connectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a list of routes the virtual hub bgp connection has learned.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the virtual hub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the virtual hub bgp connection.
            /// </param>
            public static IDictionary<string, IList<PeerRoute>> BeginListLearnedRoutes(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string hubName, string connectionName)
            {
                return operations.BeginListLearnedRoutesAsync(resourceGroupName, hubName, connectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a list of routes the virtual hub bgp connection has learned.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the virtual hub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the virtual hub bgp connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, IList<PeerRoute>>> BeginListLearnedRoutesAsync(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string hubName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListLearnedRoutesWithHttpMessagesAsync(resourceGroupName, hubName, connectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a list of routes the virtual hub bgp connection is advertising to
            /// the specified peer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the virtual hub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the virtual hub bgp connection.
            /// </param>
            public static IDictionary<string, IList<PeerRoute>> BeginListAdvertisedRoutes(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string hubName, string connectionName)
            {
                return operations.BeginListAdvertisedRoutesAsync(resourceGroupName, hubName, connectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a list of routes the virtual hub bgp connection is advertising to
            /// the specified peer.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='hubName'>
            /// The name of the virtual hub.
            /// </param>
            /// <param name='connectionName'>
            /// The name of the virtual hub bgp connection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, IList<PeerRoute>>> BeginListAdvertisedRoutesAsync(this IVirtualHubBgpConnectionsOperations operations, string resourceGroupName, string hubName, string connectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginListAdvertisedRoutesWithHttpMessagesAsync(resourceGroupName, hubName, connectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves the details of all VirtualHubBgpConnections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BgpConnection> ListNext(this IVirtualHubBgpConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of all VirtualHubBgpConnections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BgpConnection>> ListNextAsync(this IVirtualHubBgpConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
