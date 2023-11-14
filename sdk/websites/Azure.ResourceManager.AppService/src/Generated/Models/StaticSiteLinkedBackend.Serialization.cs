// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteLinkedBackend
    {
        internal static StaticSiteLinkedBackend DeserializeStaticSiteLinkedBackend(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> backendResourceId = default;
            Optional<string> region = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backendResourceId"u8))
                {
                    backendResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
            }
            return new StaticSiteLinkedBackend(backendResourceId.Value, region.Value, Optional.ToNullable(createdOn), provisioningState.Value);
        }
    }
}
