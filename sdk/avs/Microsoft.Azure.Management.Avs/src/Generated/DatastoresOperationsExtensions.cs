// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Avs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DatastoresOperations.
    /// </summary>
    public static partial class DatastoresOperationsExtensions
    {
            /// <summary>
            /// List Datastore resources by Cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            public static IPage<Datastore> List(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName)
            {
                return operations.ListAsync(resourceGroupName, privateCloudName, clusterName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Datastore resources by Cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Datastore>> ListAsync(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            public static Datastore Get(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName)
            {
                return operations.GetAsync(resourceGroupName, privateCloudName, clusterName, datastoreName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Datastore> GetAsync(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, datastoreName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            /// <param name='datastore'>
            /// Resource create parameters.
            /// </param>
            public static Datastore CreateOrUpdate(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName, Datastore datastore)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, privateCloudName, clusterName, datastoreName, datastore).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            /// <param name='datastore'>
            /// Resource create parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Datastore> CreateOrUpdateAsync(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName, Datastore datastore, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, datastoreName, datastore, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            public static DatastoresDeleteHeaders Delete(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName)
            {
                return operations.DeleteAsync(resourceGroupName, privateCloudName, clusterName, datastoreName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatastoresDeleteHeaders> DeleteAsync(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, datastoreName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Create a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            /// <param name='datastore'>
            /// Resource create parameters.
            /// </param>
            public static Datastore BeginCreateOrUpdate(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName, Datastore datastore)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, privateCloudName, clusterName, datastoreName, datastore).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            /// <param name='datastore'>
            /// Resource create parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Datastore> BeginCreateOrUpdateAsync(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName, Datastore datastore, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, datastoreName, datastore, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            public static DatastoresDeleteHeaders BeginDelete(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, privateCloudName, clusterName, datastoreName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Datastore
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='privateCloudName'>
            /// Name of the private cloud
            /// </param>
            /// <param name='clusterName'>
            /// Name of the cluster
            /// </param>
            /// <param name='datastoreName'>
            /// Name of the datastore
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatastoresDeleteHeaders> BeginDeleteAsync(this IDatastoresOperations operations, string resourceGroupName, string privateCloudName, string clusterName, string datastoreName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, privateCloudName, clusterName, datastoreName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// List Datastore resources by Cluster
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Datastore> ListNext(this IDatastoresOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List Datastore resources by Cluster
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
            public static async Task<IPage<Datastore>> ListNextAsync(this IDatastoresOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
