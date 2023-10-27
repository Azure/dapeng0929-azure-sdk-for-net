// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class PiiDetectionSkill : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultLanguageCode))
            {
                if (DefaultLanguageCode != null)
                {
                    writer.WritePropertyName("defaultLanguageCode"u8);
                    writer.WriteStringValue(DefaultLanguageCode);
                }
                else
                {
                    writer.WriteNull("defaultLanguageCode");
                }
            }
            if (Optional.IsDefined(MinimumPrecision))
            {
                if (MinimumPrecision != null)
                {
                    writer.WritePropertyName("minimumPrecision"u8);
                    writer.WriteNumberValue(MinimumPrecision.Value);
                }
                else
                {
                    writer.WriteNull("minimumPrecision");
                }
            }
            if (Optional.IsDefined(MaskingMode))
            {
                writer.WritePropertyName("maskingMode"u8);
                writer.WriteStringValue(MaskingMode.Value.ToString());
            }
            if (Optional.IsDefined(Mask))
            {
                if (Mask != null)
                {
                    writer.WritePropertyName("maskingCharacter"u8);
                    writer.WriteStringValue(Mask);
                }
                else
                {
                    writer.WriteNull("maskingCharacter");
                }
            }
            if (Optional.IsDefined(ModelVersion))
            {
                if (ModelVersion != null)
                {
                    writer.WritePropertyName("modelVersion"u8);
                    writer.WriteStringValue(ModelVersion);
                }
                else
                {
                    writer.WriteNull("modelVersion");
                }
            }
            if (Optional.IsCollectionDefined(PiiCategories))
            {
                writer.WritePropertyName("piiCategories"u8);
                writer.WriteStartArray();
                foreach (var item in PiiCategories)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Domain))
            {
                if (Domain != null)
                {
                    writer.WritePropertyName("domain"u8);
                    writer.WriteStringValue(Domain);
                }
                else
                {
                    writer.WriteNull("domain");
                }
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static PiiDetectionSkill DeserializePiiDetectionSkill(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> defaultLanguageCode = default;
            Optional<double?> minimumPrecision = default;
            Optional<PiiDetectionSkillMaskingMode> maskingMode = default;
            Optional<string> maskingCharacter = default;
            Optional<string> modelVersion = default;
            Optional<IList<string>> piiCategories = default;
            Optional<string> domain = default;
            string odataType = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultLanguageCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultLanguageCode = null;
                        continue;
                    }
                    defaultLanguageCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumPrecision"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        minimumPrecision = null;
                        continue;
                    }
                    minimumPrecision = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maskingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maskingMode = new PiiDetectionSkillMaskingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maskingCharacter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maskingCharacter = null;
                        continue;
                    }
                    maskingCharacter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelVersion = null;
                        continue;
                    }
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("piiCategories"u8))
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
                    piiCategories = array;
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        domain = null;
                        continue;
                    }
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
            }
            return new PiiDetectionSkill(odataType, name.Value, description.Value, context.Value, inputs, outputs, defaultLanguageCode.Value, Optional.ToNullable(minimumPrecision), Optional.ToNullable(maskingMode), maskingCharacter.Value, modelVersion.Value, Optional.ToList(piiCategories), domain.Value);
        }
    }
}
