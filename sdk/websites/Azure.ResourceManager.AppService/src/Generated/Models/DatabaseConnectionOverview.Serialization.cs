// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DatabaseConnectionOverview
    {
        internal static DatabaseConnectionOverview DeserializeDatabaseConnectionOverview(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceId = default;
            Optional<string> connectionIdentity = default;
            Optional<string> region = default;
            Optional<IReadOnlyList<StaticSiteDatabaseConnectionConfigurationFileOverview>> configurationFiles = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionIdentity"u8))
                {
                    connectionIdentity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticSiteDatabaseConnectionConfigurationFileOverview> array = new List<StaticSiteDatabaseConnectionConfigurationFileOverview>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticSiteDatabaseConnectionConfigurationFileOverview.DeserializeStaticSiteDatabaseConnectionConfigurationFileOverview(item));
                    }
                    configurationFiles = array;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new DatabaseConnectionOverview(resourceId.Value, connectionIdentity.Value, region.Value, Optional.ToList(configurationFiles), name.Value);
        }
    }
}
