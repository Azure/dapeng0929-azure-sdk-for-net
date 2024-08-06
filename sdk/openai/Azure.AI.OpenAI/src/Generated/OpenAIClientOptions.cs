// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> Client options for OpenAIClient. </summary>
    public partial class OpenAIClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2024_06_01;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2022-12-01". </summary>
            V2022_12_01 = 1,
            /// <summary> Service version "2023-05-15". </summary>
            V2023_05_15 = 2,
            /// <summary> Service version "2023-06-01-preview". </summary>
            V2023_06_01_Preview = 3,
            /// <summary> Service version "2023-07-01-preview". </summary>
            V2023_07_01_Preview = 4,
            /// <summary> Service version "2024-02-01". </summary>
            V2024_02_01 = 5,
            /// <summary> Service version "2024-02-15-preview". </summary>
            V2024_02_15_Preview = 6,
            /// <summary> Service version "2024-03-01-preview". </summary>
            V2024_03_01_Preview = 7,
            /// <summary> Service version "2024-04-01-preview". </summary>
            V2024_04_01_Preview = 8,
            /// <summary> Service version "2024-05-01-preview". </summary>
            V2024_05_01_Preview = 9,
            /// <summary> Service version "2024-06-01". </summary>
            V2024_06_01 = 10,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of OpenAIClientOptions. </summary>
        public OpenAIClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2022_12_01 => "2022-12-01",
                ServiceVersion.V2023_05_15 => "2023-05-15",
                ServiceVersion.V2023_06_01_Preview => "2023-06-01-preview",
                ServiceVersion.V2023_07_01_Preview => "2023-07-01-preview",
                ServiceVersion.V2024_02_01 => "2024-02-01",
                ServiceVersion.V2024_02_15_Preview => "2024-02-15-preview",
                ServiceVersion.V2024_03_01_Preview => "2024-03-01-preview",
                ServiceVersion.V2024_04_01_Preview => "2024-04-01-preview",
                ServiceVersion.V2024_05_01_Preview => "2024-05-01-preview",
                ServiceVersion.V2024_06_01 => "2024-06-01",
                _ => throw new NotSupportedException()
            };
        }
    }
}
