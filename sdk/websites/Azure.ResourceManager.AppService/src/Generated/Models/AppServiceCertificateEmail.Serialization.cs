// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceCertificateEmail
    {
        internal static AppServiceCertificateEmail DeserializeAppServiceCertificateEmail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> emailId = default;
            Optional<DateTimeOffset> timeStamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("emailId"u8))
                {
                    emailId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AppServiceCertificateEmail(emailId.Value, Optional.ToNullable(timeStamp));
        }
    }
}
