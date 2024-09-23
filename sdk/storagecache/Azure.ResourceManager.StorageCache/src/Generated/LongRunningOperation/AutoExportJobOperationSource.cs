// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache
{
    internal class AutoExportJobOperationSource : IOperationSource<AutoExportJobResource>
    {
        private readonly ArmClient _client;

        internal AutoExportJobOperationSource(ArmClient client)
        {
            _client = client;
        }

        AutoExportJobResource IOperationSource<AutoExportJobResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AutoExportJobData.DeserializeAutoExportJobData(document.RootElement);
            return new AutoExportJobResource(_client, data);
        }

        async ValueTask<AutoExportJobResource> IOperationSource<AutoExportJobResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AutoExportJobData.DeserializeAutoExportJobData(document.RootElement);
            return new AutoExportJobResource(_client, data);
        }
    }
}
