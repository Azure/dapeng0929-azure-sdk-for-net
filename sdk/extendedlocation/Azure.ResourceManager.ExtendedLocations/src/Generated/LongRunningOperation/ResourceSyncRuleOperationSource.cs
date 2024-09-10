// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ExtendedLocations
{
    internal class ResourceSyncRuleOperationSource : IOperationSource<ResourceSyncRuleResource>
    {
        private readonly ArmClient _client;

        internal ResourceSyncRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        ResourceSyncRuleResource IOperationSource<ResourceSyncRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ResourceSyncRuleData.DeserializeResourceSyncRuleData(document.RootElement);
            return new ResourceSyncRuleResource(_client, data);
        }

        async ValueTask<ResourceSyncRuleResource> IOperationSource<ResourceSyncRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ResourceSyncRuleData.DeserializeResourceSyncRuleData(document.RootElement);
            return new ResourceSyncRuleResource(_client, data);
        }
    }
}
