// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.App
{
    /// <summary> Client options for AppClient. </summary>
    public partial class AppClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2023_08_01_Preview;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2023-08-01-preview". </summary>
            V2023_08_01_Preview = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of AppClientOptions. </summary>
        public AppClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2023_08_01_Preview => "2023-08-01-preview",
                _ => throw new NotSupportedException()
            };
        }
    }
}
