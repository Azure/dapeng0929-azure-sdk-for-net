// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class IPModeExtensions
    {
        public static string ToSerialString(this IPMode value) => value switch
        {
            IPMode.IPv4 => "IPv4",
            IPMode.IPv6 => "IPv6",
            IPMode.IPv4AndIPv6 => "IPv4AndIPv6",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IPMode value.")
        };

        public static IPMode ToIPMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "IPv4")) return IPMode.IPv4;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "IPv6")) return IPMode.IPv6;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "IPv4AndIPv6")) return IPMode.IPv4AndIPv6;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown IPMode value.");
        }
    }
}
