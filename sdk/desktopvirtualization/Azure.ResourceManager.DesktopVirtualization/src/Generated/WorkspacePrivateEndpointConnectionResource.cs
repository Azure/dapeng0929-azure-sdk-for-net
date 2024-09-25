// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A Class representing a WorkspacePrivateEndpointConnection along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="WorkspacePrivateEndpointConnectionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetWorkspacePrivateEndpointConnectionResource method.
    /// Otherwise you can get one from its parent resource <see cref="VirtualWorkspaceResource"/> using the GetWorkspacePrivateEndpointConnection method.
    /// </summary>
    public partial class WorkspacePrivateEndpointConnectionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WorkspacePrivateEndpointConnectionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="privateEndpointConnectionName"> The privateEndpointConnectionName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient;
        private readonly DesktopVirtualizationPrivateEndpointConnectionDataData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DesktopVirtualization/workspaces/privateEndpointConnections";

        /// <summary> Initializes a new instance of the <see cref="WorkspacePrivateEndpointConnectionResource"/> class for mocking. </summary>
        protected WorkspacePrivateEndpointConnectionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkspacePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WorkspacePrivateEndpointConnectionResource(ArmClient client, DesktopVirtualizationPrivateEndpointConnectionDataData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WorkspacePrivateEndpointConnectionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WorkspacePrivateEndpointConnectionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workspacePrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workspacePrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DesktopVirtualizationPrivateEndpointConnectionDataData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspacePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkspacePrivateEndpointConnectionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = await _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspacePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkspacePrivateEndpointConnectionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionResource.Get");
            scope.Start();
            try
            {
                var response = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove a connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_DeleteByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspacePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = await _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.DeleteByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateDeleteByWorkspaceRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove a connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_DeleteByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspacePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionResource.Delete");
            scope.Start();
            try
            {
                var response = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.DeleteByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateDeleteByWorkspaceRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Approve or reject a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_UpdateByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspacePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connection"> Object containing the updated connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connection"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkspacePrivateEndpointConnectionResource>> UpdateAsync(WaitUntil waitUntil, DesktopVirtualizationPrivateEndpointConnection connection, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connection, nameof(connection));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = await _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.UpdateByWorkspaceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connection, cancellationToken).ConfigureAwait(false);
                var uri = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateUpdateByWorkspaceRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connection);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation<WorkspacePrivateEndpointConnectionResource>(Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Approve or reject a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_UpdateByWorkspace</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-08-08-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WorkspacePrivateEndpointConnectionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connection"> Object containing the updated connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connection"/> is null. </exception>
        public virtual ArmOperation<WorkspacePrivateEndpointConnectionResource> Update(WaitUntil waitUntil, DesktopVirtualizationPrivateEndpointConnection connection, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(connection, nameof(connection));

            using var scope = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("WorkspacePrivateEndpointConnectionResource.Update");
            scope.Start();
            try
            {
                var response = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.UpdateByWorkspace(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connection, cancellationToken);
                var uri = _workspacePrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateUpdateByWorkspaceRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, connection);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DesktopVirtualizationArmOperation<WorkspacePrivateEndpointConnectionResource>(Response.FromValue(new WorkspacePrivateEndpointConnectionResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
    }
}
