// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class GuidPair
    {
        internal static GuidPair DeserializeGuidPair(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> pageGuid = default;
            Optional<string> crawlStateGuid = default;
            Optional<DateTimeOffset> loadDate = default;
            Optional<bool> recent = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pageGuid"u8))
                {
                    pageGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crawlStateGuid"u8))
                {
                    crawlStateGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loadDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recent = property.Value.GetBoolean();
                    continue;
                }
            }
            return new GuidPair(pageGuid.Value, crawlStateGuid.Value, Optional.ToNullable(loadDate), Optional.ToNullable(recent));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GuidPair FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGuidPair(document.RootElement);
        }
    }
}
