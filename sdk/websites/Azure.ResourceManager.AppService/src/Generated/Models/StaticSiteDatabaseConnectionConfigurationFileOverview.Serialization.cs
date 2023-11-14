// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteDatabaseConnectionConfigurationFileOverview
    {
        internal static StaticSiteDatabaseConnectionConfigurationFileOverview DeserializeStaticSiteDatabaseConnectionConfigurationFileOverview(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> fileName = default;
            Optional<string> contents = default;
            Optional<string> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileName"u8))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contents"u8))
                {
                    contents = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new StaticSiteDatabaseConnectionConfigurationFileOverview(fileName.Value, contents.Value, type.Value);
        }
    }
}
