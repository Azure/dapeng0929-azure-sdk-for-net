// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class OpenAuthenticationAccessPolicies : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Policies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteStartObject();
                foreach (var item in Policies)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static OpenAuthenticationAccessPolicies DeserializeOpenAuthenticationAccessPolicies(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, OpenAuthenticationAccessPolicy>> policies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, OpenAuthenticationAccessPolicy> dictionary = new Dictionary<string, OpenAuthenticationAccessPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, OpenAuthenticationAccessPolicy.DeserializeOpenAuthenticationAccessPolicy(property0.Value));
                    }
                    policies = dictionary;
                    continue;
                }
            }
            return new OpenAuthenticationAccessPolicies(Optional.ToDictionary(policies));
        }
    }
}
