// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class ReportBillableAssetBreakdown
    {
        internal static ReportBillableAssetBreakdown DeserializeReportBillableAssetBreakdown(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReportBillableAssetBreakdownKind> kind = default;
            Optional<long> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new ReportBillableAssetBreakdownKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
            }
            return new ReportBillableAssetBreakdown(Optional.ToNullable(kind), Optional.ToNullable(count));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ReportBillableAssetBreakdown FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeReportBillableAssetBreakdown(document.RootElement);
        }
    }
}
