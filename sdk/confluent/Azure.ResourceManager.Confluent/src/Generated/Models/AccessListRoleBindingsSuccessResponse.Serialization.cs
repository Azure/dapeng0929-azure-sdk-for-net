// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class AccessListRoleBindingsSuccessResponse
    {
        internal static AccessListRoleBindingsSuccessResponse DeserializeAccessListRoleBindingsSuccessResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<ConfluentListMetadata> metadata = default;
            Optional<IReadOnlyList<RoleBindingRecord>> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = ConfluentListMetadata.DeserializeConfluentListMetadata(property.Value);
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoleBindingRecord> array = new List<RoleBindingRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleBindingRecord.DeserializeRoleBindingRecord(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new AccessListRoleBindingsSuccessResponse(kind.Value, metadata.Value, Optional.ToList(data));
        }
    }
}
