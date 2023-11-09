// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> Source entity used to drive discovery. </summary>
    public partial class DiscoSource
    {
        /// <summary> Initializes a new instance of DiscoSource. </summary>
        public DiscoSource()
        {
        }

        /// <summary> Initializes a new instance of DiscoSource. </summary>
        /// <param name="kind"> The kind of disco source. </param>
        /// <param name="name"> The name for the disco source. </param>
        internal DiscoSource(DiscoSourceKind? kind, string name)
        {
            Kind = kind;
            Name = name;
        }

        /// <summary> The kind of disco source. </summary>
        public DiscoSourceKind? Kind { get; set; }
        /// <summary> The name for the disco source. </summary>
        public string Name { get; set; }
    }
}
