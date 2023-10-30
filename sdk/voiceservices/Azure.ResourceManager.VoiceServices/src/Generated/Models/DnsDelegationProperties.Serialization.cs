// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.VoiceServices.Models
{
    public partial class DnsDelegationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            writer.WriteEndObject();
        }

        internal static DnsDelegationProperties DeserializeDnsDelegationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> domain = default;
            Optional<IReadOnlyList<string>> nameServers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nameServers = array;
                    continue;
                }
            }
            return new DnsDelegationProperties(domain.Value, Optional.ToList(nameServers));
        }
    }
}
