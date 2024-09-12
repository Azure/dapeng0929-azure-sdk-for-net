// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class ReservationPurchaseRequest : IUtf8JsonSerializable, IJsonModel<ReservationPurchaseRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationPurchaseRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ReservationPurchaseRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPurchaseRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationPurchaseRequest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ReservedResourceType))
            {
                writer.WritePropertyName("reservedResourceType"u8);
                writer.WriteStringValue(ReservedResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingScopeId))
            {
                writer.WritePropertyName("billingScopeId"u8);
                writer.WriteStringValue(BillingScopeId);
            }
            if (options.Format != "W" && Optional.IsDefined(Term))
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term);
            }
            if (Optional.IsDefined(BillingPlan))
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (Optional.IsDefined(Quantity))
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(AppliedScopeType))
            {
                writer.WritePropertyName("appliedScopeType"u8);
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AppliedScopes))
            {
                writer.WritePropertyName("appliedScopes"u8);
                writer.WriteStartArray();
                foreach (var item in AppliedScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AppliedScopeProperties))
            {
                writer.WritePropertyName("appliedScopeProperties"u8);
                writer.WriteObjectValue(AppliedScopeProperties, options);
            }
            if (Optional.IsDefined(IsRenewed))
            {
                writer.WritePropertyName("renew"u8);
                writer.WriteBooleanValue(IsRenewed.Value);
            }
            if (Optional.IsDefined(ReviewOn))
            {
                writer.WritePropertyName("reviewDateTime"u8);
                writer.WriteStringValue(ReviewOn.Value, "O");
            }
            writer.WritePropertyName("reservedResourceProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(InstanceFlexibility))
            {
                writer.WritePropertyName("instanceFlexibility"u8);
                writer.WriteStringValue(InstanceFlexibility.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ReservationPurchaseRequest IJsonModel<ReservationPurchaseRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPurchaseRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationPurchaseRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationPurchaseRequest(document.RootElement, options);
        }

        internal static ReservationPurchaseRequest DeserializeReservationPurchaseRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BillingSkuName sku = default;
            AzureLocation? location = default;
            string reservedResourceType = default;
            string billingScopeId = default;
            string term = default;
            ReservationBillingPlan? billingPlan = default;
            int? quantity = default;
            string displayName = default;
            BillingAppliedScopeType? appliedScopeType = default;
            IList<string> appliedScopes = default;
            ReservationAppliedScopeProperties appliedScopeProperties = default;
            bool? renew = default;
            DateTimeOffset? reviewDateTime = default;
            InstanceFlexibility? instanceFlexibility = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = BillingSkuName.DeserializeBillingSkuName(property.Value, options);
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("reservedResourceType"u8))
                        {
                            reservedResourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingScopeId"u8))
                        {
                            billingScopeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("term"u8))
                        {
                            term = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("billingPlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            billingPlan = new ReservationBillingPlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("quantity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            quantity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeType = new BillingAppliedScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            appliedScopes = array;
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeProperties = ReservationAppliedScopeProperties.DeserializeReservationAppliedScopeProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("renew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            renew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("reviewDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reviewDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("reservedResourceProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("instanceFlexibility"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    instanceFlexibility = new InstanceFlexibility(property1.Value.GetString());
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ReservationPurchaseRequest(
                sku,
                location,
                reservedResourceType,
                billingScopeId,
                term,
                billingPlan,
                quantity,
                displayName,
                appliedScopeType,
                appliedScopes ?? new ChangeTrackingList<string>(),
                appliedScopeProperties,
                renew,
                reviewDateTime,
                instanceFlexibility,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("SkuName", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sku: ");
                builder.AppendLine("{");
                builder.Append("    name: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Sku))
                {
                    builder.Append("  sku: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Sku, options, 2, false, "  sku: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Location))
                {
                    builder.Append("  location: ");
                    builder.AppendLine($"'{Location.Value.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReservedResourceType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    reservedResourceType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReservedResourceType))
                {
                    builder.Append("    reservedResourceType: ");
                    if (ReservedResourceType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ReservedResourceType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ReservedResourceType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingScopeId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    billingScopeId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingScopeId))
                {
                    builder.Append("    billingScopeId: ");
                    if (BillingScopeId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BillingScopeId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BillingScopeId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Term), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    term: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Term))
                {
                    builder.Append("    term: ");
                    if (Term.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Term}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Term}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingPlan), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    billingPlan: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingPlan))
                {
                    builder.Append("    billingPlan: ");
                    builder.AppendLine($"'{BillingPlan.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Quantity), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    quantity: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Quantity))
                {
                    builder.Append("    quantity: ");
                    builder.AppendLine($"{Quantity.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    displayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DisplayName))
                {
                    builder.Append("    displayName: ");
                    if (DisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppliedScopeType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    appliedScopeType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppliedScopeType))
                {
                    builder.Append("    appliedScopeType: ");
                    builder.AppendLine($"'{AppliedScopeType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppliedScopes), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    appliedScopes: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AppliedScopes))
                {
                    if (AppliedScopes.Any())
                    {
                        builder.Append("    appliedScopes: ");
                        builder.AppendLine("[");
                        foreach (var item in AppliedScopes)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("      '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"      '{item}'");
                            }
                        }
                        builder.AppendLine("    ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppliedScopeProperties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    appliedScopeProperties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppliedScopeProperties))
                {
                    builder.Append("    appliedScopeProperties: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AppliedScopeProperties, options, 4, false, "    appliedScopeProperties: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsRenewed), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    renew: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsRenewed))
                {
                    builder.Append("    renew: ");
                    var boolValue = IsRenewed.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ReviewOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    reviewDateTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ReviewOn))
                {
                    builder.Append("    reviewDateTime: ");
                    var formattedDateTimeString = TypeFormatters.ToString(ReviewOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            builder.Append("    reservedResourceProperties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InstanceFlexibility), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("      instanceFlexibility: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InstanceFlexibility))
                {
                    builder.Append("      instanceFlexibility: ");
                    builder.AppendLine($"'{InstanceFlexibility.Value.ToString()}'");
                }
            }

            builder.AppendLine("    }");
            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ReservationPurchaseRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPurchaseRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ReservationPurchaseRequest)} does not support writing '{options.Format}' format.");
            }
        }

        ReservationPurchaseRequest IPersistableModel<ReservationPurchaseRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationPurchaseRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationPurchaseRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationPurchaseRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationPurchaseRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
