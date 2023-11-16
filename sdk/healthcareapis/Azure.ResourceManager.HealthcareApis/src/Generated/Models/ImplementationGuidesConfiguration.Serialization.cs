// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    internal partial class ImplementationGuidesConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UsCoreMissingData))
            {
                writer.WritePropertyName("usCoreMissingData"u8);
                writer.WriteBooleanValue(UsCoreMissingData.Value);
            }
            writer.WriteEndObject();
        }

        internal static ImplementationGuidesConfiguration DeserializeImplementationGuidesConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> usCoreMissingData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("usCoreMissingData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    usCoreMissingData = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ImplementationGuidesConfiguration(Optional.ToNullable(usCoreMissingData));
        }
    }
}
