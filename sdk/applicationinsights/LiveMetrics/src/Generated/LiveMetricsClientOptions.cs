// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace LiveMetrics
{
    /// <summary> Client options for LiveMetricsClient. </summary>
    public partial class LiveMetricsClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2024_04_01_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2024-04-01-preview". </summary>
            V2024_04_01_Preview = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of LiveMetricsClientOptions. </summary>
        public LiveMetricsClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2024_04_01_Preview => "2024-04-01-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
