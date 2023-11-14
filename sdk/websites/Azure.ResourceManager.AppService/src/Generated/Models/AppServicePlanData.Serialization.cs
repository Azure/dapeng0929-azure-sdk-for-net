// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServicePlanData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(WorkerTierName))
            {
                writer.WritePropertyName("workerTierName"u8);
                writer.WriteStringValue(WorkerTierName);
            }
            if (Optional.IsDefined(HostingEnvironmentProfile))
            {
                if (HostingEnvironmentProfile != null)
                {
                    writer.WritePropertyName("hostingEnvironmentProfile"u8);
                    writer.WriteObjectValue(HostingEnvironmentProfile);
                }
                else
                {
                    writer.WriteNull("hostingEnvironmentProfile");
                }
            }
            if (Optional.IsDefined(IsPerSiteScaling))
            {
                writer.WritePropertyName("perSiteScaling"u8);
                writer.WriteBooleanValue(IsPerSiteScaling.Value);
            }
            if (Optional.IsDefined(IsElasticScaleEnabled))
            {
                writer.WritePropertyName("elasticScaleEnabled"u8);
                writer.WriteBooleanValue(IsElasticScaleEnabled.Value);
            }
            if (Optional.IsDefined(MaximumElasticWorkerCount))
            {
                writer.WritePropertyName("maximumElasticWorkerCount"u8);
                writer.WriteNumberValue(MaximumElasticWorkerCount.Value);
            }
            if (Optional.IsDefined(IsSpot))
            {
                writer.WritePropertyName("isSpot"u8);
                writer.WriteBooleanValue(IsSpot.Value);
            }
            if (Optional.IsDefined(SpotExpireOn))
            {
                if (SpotExpireOn != null)
                {
                    writer.WritePropertyName("spotExpirationTime"u8);
                    writer.WriteStringValue(SpotExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("spotExpirationTime");
                }
            }
            if (Optional.IsDefined(FreeOfferExpireOn))
            {
                if (FreeOfferExpireOn != null)
                {
                    writer.WritePropertyName("freeOfferExpirationTime"u8);
                    writer.WriteStringValue(FreeOfferExpireOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("freeOfferExpirationTime");
                }
            }
            if (Optional.IsDefined(IsReserved))
            {
                writer.WritePropertyName("reserved"u8);
                writer.WriteBooleanValue(IsReserved.Value);
            }
            if (Optional.IsDefined(IsXenon))
            {
                writer.WritePropertyName("isXenon"u8);
                writer.WriteBooleanValue(IsXenon.Value);
            }
            if (Optional.IsDefined(IsHyperV))
            {
                writer.WritePropertyName("hyperV"u8);
                writer.WriteBooleanValue(IsHyperV.Value);
            }
            if (Optional.IsDefined(TargetWorkerCount))
            {
                writer.WritePropertyName("targetWorkerCount"u8);
                writer.WriteNumberValue(TargetWorkerCount.Value);
            }
            if (Optional.IsDefined(TargetWorkerSizeId))
            {
                writer.WritePropertyName("targetWorkerSizeId"u8);
                writer.WriteNumberValue(TargetWorkerSizeId.Value);
            }
            if (Optional.IsDefined(KubeEnvironmentProfile))
            {
                if (KubeEnvironmentProfile != null)
                {
                    writer.WritePropertyName("kubeEnvironmentProfile"u8);
                    writer.WriteObjectValue(KubeEnvironmentProfile);
                }
                else
                {
                    writer.WriteNull("kubeEnvironmentProfile");
                }
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServicePlanData DeserializeAppServicePlanData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppServiceSkuDescription> sku = default;
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> workerTierName = default;
            Optional<AppServicePlanStatus> status = default;
            Optional<string> subscription = default;
            Optional<HostingEnvironmentProfile> hostingEnvironmentProfile = default;
            Optional<int> maximumNumberOfWorkers = default;
            Optional<int> numberOfWorkers = default;
            Optional<string> geoRegion = default;
            Optional<bool> perSiteScaling = default;
            Optional<bool> elasticScaleEnabled = default;
            Optional<int> maximumElasticWorkerCount = default;
            Optional<int> numberOfSites = default;
            Optional<bool> isSpot = default;
            Optional<DateTimeOffset?> spotExpirationTime = default;
            Optional<DateTimeOffset?> freeOfferExpirationTime = default;
            Optional<string> resourceGroup = default;
            Optional<bool> reserved = default;
            Optional<bool> isXenon = default;
            Optional<bool> hyperV = default;
            Optional<int> targetWorkerCount = default;
            Optional<int> targetWorkerSizeId = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<KubeEnvironmentProfile> kubeEnvironmentProfile = default;
            Optional<bool> zoneRedundant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = AppServiceSkuDescription.DeserializeAppServiceSkuDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("workerTierName"u8))
                        {
                            workerTierName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToAppServicePlanStatus();
                            continue;
                        }
                        if (property0.NameEquals("subscription"u8))
                        {
                            subscription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironmentProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                hostingEnvironmentProfile = null;
                                continue;
                            }
                            hostingEnvironmentProfile = HostingEnvironmentProfile.DeserializeHostingEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maximumNumberOfWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumNumberOfWorkers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfWorkers = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("geoRegion"u8))
                        {
                            geoRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("perSiteScaling"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            perSiteScaling = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("elasticScaleEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            elasticScaleEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("maximumElasticWorkerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumElasticWorkerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfSites"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfSites = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isSpot"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSpot = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("spotExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                spotExpirationTime = null;
                                continue;
                            }
                            spotExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("freeOfferExpirationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                freeOfferExpirationTime = null;
                                continue;
                            }
                            freeOfferExpirationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("resourceGroup"u8))
                        {
                            resourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reserved"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reserved = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isXenon"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isXenon = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hyperV"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hyperV = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("targetWorkerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetWorkerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("targetWorkerSizeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetWorkerSizeId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("kubeEnvironmentProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                kubeEnvironmentProfile = null;
                                continue;
                            }
                            kubeEnvironmentProfile = KubeEnvironmentProfile.DeserializeKubeEnvironmentProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServicePlanData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, extendedLocation, workerTierName.Value, Optional.ToNullable(status), subscription.Value, hostingEnvironmentProfile.Value, Optional.ToNullable(maximumNumberOfWorkers), Optional.ToNullable(numberOfWorkers), geoRegion.Value, Optional.ToNullable(perSiteScaling), Optional.ToNullable(elasticScaleEnabled), Optional.ToNullable(maximumElasticWorkerCount), Optional.ToNullable(numberOfSites), Optional.ToNullable(isSpot), Optional.ToNullable(spotExpirationTime), Optional.ToNullable(freeOfferExpirationTime), resourceGroup.Value, Optional.ToNullable(reserved), Optional.ToNullable(isXenon), Optional.ToNullable(hyperV), Optional.ToNullable(targetWorkerCount), Optional.ToNullable(targetWorkerSizeId), Optional.ToNullable(provisioningState), kubeEnvironmentProfile.Value, Optional.ToNullable(zoneRedundant), kind.Value);
        }
    }
}
