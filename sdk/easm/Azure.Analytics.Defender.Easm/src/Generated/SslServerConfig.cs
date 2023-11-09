// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The SslServerConfig. </summary>
    public partial class SslServerConfig
    {
        /// <summary> Initializes a new instance of SslServerConfig. </summary>
        internal SslServerConfig()
        {
            TlsVersions = new ChangeTrackingList<string>();
            CipherSuites = new ChangeTrackingList<string>();
            Sources = new ChangeTrackingList<Source>();
        }

        /// <summary> Initializes a new instance of SslServerConfig. </summary>
        /// <param name="tlsVersions"></param>
        /// <param name="cipherSuites"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="sources"></param>
        internal SslServerConfig(IReadOnlyList<string> tlsVersions, IReadOnlyList<string> cipherSuites, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, IReadOnlyList<Source> sources)
        {
            TlsVersions = tlsVersions;
            CipherSuites = cipherSuites;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Sources = sources;
        }

        /// <summary> Gets the tls versions. </summary>
        public IReadOnlyList<string> TlsVersions { get; }
        /// <summary> Gets the cipher suites. </summary>
        public IReadOnlyList<string> CipherSuites { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<Source> Sources { get; }
    }
}
