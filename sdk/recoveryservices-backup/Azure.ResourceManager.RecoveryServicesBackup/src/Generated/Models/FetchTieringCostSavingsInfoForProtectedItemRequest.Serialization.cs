// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class FetchTieringCostSavingsInfoForProtectedItemRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("containerName"u8);
            writer.WriteStringValue(ContainerName);
            writer.WritePropertyName("protectedItemName"u8);
            writer.WriteStringValue(ProtectedItemName);
            writer.WritePropertyName("sourceTierType"u8);
            writer.WriteStringValue(SourceTierType.ToSerialString());
            writer.WritePropertyName("targetTierType"u8);
            writer.WriteStringValue(TargetTierType.ToSerialString());
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }
    }
}
