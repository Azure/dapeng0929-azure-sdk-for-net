// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class QueueScaleRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(QueueName))
            {
                writer.WritePropertyName("queueName"u8);
                writer.WriteStringValue(QueueName);
            }
            if (Optional.IsDefined(QueueLength))
            {
                writer.WritePropertyName("queueLength"u8);
                writer.WriteNumberValue(QueueLength.Value);
            }
            if (Optional.IsCollectionDefined(Auth))
            {
                writer.WritePropertyName("auth"u8);
                writer.WriteStartArray();
                foreach (var item in Auth)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static QueueScaleRule DeserializeQueueScaleRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> queueName = default;
            Optional<int> queueLength = default;
            Optional<IList<ScaleRuleAuth>> auth = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueName"u8))
                {
                    queueName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queueLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("auth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScaleRuleAuth> array = new List<ScaleRuleAuth>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScaleRuleAuth.DeserializeScaleRuleAuth(item));
                    }
                    auth = array;
                    continue;
                }
            }
            return new QueueScaleRule(queueName.Value, Optional.ToNullable(queueLength), Optional.ToList(auth));
        }
    }
}
