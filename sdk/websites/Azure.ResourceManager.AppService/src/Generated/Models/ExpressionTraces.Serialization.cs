// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class ExpressionTraces
    {
        internal static ExpressionTraces DeserializeExpressionTraces(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> value = default;
            Optional<IReadOnlyList<ExpressionRoot>> inputs = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExpressionRoot> array = new List<ExpressionRoot>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressionRoot.DeserializeExpressionRoot(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ExpressionTraces(value.Value, Optional.ToList(inputs), nextLink.Value);
        }
    }
}
