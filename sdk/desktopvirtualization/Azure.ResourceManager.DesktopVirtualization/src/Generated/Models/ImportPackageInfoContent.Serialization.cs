// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ImportPackageInfoContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(PackageArchitecture))
            {
                if (PackageArchitecture != null)
                {
                    writer.WritePropertyName("packageArchitecture"u8);
                    writer.WriteStringValue(PackageArchitecture.Value.ToString());
                }
                else
                {
                    writer.WriteNull("packageArchitecture");
                }
            }
            writer.WriteEndObject();
        }
    }
}
