// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    internal class VaultReplicationFabricReplicationProtectionContainerReplicationProtectionClusterOperationSource : IOperationSource<VaultReplicationFabricReplicationProtectionContainerReplicationProtectionClusterResource>
    {
        private readonly ArmClient _client;

        internal VaultReplicationFabricReplicationProtectionContainerReplicationProtectionClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        VaultReplicationFabricReplicationProtectionContainerReplicationProtectionClusterResource IOperationSource<VaultReplicationFabricReplicationProtectionContainerReplicationProtectionClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ReplicationProtectionClusterData.DeserializeReplicationProtectionClusterData(document.RootElement);
            return new VaultReplicationFabricReplicationProtectionContainerReplicationProtectionClusterResource(_client, data);
        }

        async ValueTask<VaultReplicationFabricReplicationProtectionContainerReplicationProtectionClusterResource> IOperationSource<VaultReplicationFabricReplicationProtectionContainerReplicationProtectionClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ReplicationProtectionClusterData.DeserializeReplicationProtectionClusterData(document.RootElement);
            return new VaultReplicationFabricReplicationProtectionContainerReplicationProtectionClusterResource(_client, data);
        }
    }
}
