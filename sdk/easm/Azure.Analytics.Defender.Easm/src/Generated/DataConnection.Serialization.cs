// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.Analytics.Defender.Easm
{
    public partial class DataConnection
    {
        internal static DataConnection DeserializeDataConnection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "logAnalytics": return LogAnalyticsDataConnection.DeserializeLogAnalyticsDataConnection(element);
                    case "azureDataExplorer": return AzureDataExplorerDataConnection.DeserializeAzureDataExplorerDataConnection(element);
                }
            }
            return UnknownDataConnection.DeserializeUnknownDataConnection(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DataConnection FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDataConnection(document.RootElement);
        }
    }
}
