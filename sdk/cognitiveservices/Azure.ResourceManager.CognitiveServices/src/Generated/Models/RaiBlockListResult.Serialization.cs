// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class RaiBlockListResult
    {
        internal static RaiBlockListResult DeserializeRaiBlockListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<RaiBlocklistData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RaiBlocklistData> array = new List<RaiBlocklistData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RaiBlocklistData.DeserializeRaiBlocklistData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new RaiBlockListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
