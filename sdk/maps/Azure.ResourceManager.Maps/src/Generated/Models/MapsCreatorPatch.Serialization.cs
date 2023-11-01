// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    public partial class MapsCreatorPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageUnits))
            {
                writer.WritePropertyName("storageUnits"u8);
                writer.WriteNumberValue(StorageUnits.Value);
            }
            if (Optional.IsDefined(TotalStorageUnitSizeInBytes))
            {
                writer.WritePropertyName("totalStorageUnitSizeInBytes"u8);
                writer.WriteNumberValue(TotalStorageUnitSizeInBytes.Value);
            }
            if (Optional.IsDefined(ConsumedStorageUnitSizeInBytes))
            {
                writer.WritePropertyName("consumedStorageUnitSizeInBytes"u8);
                writer.WriteNumberValue(ConsumedStorageUnitSizeInBytes.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
