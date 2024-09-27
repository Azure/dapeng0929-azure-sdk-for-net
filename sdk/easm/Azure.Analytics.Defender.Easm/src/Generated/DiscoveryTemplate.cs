// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The DiscoveryTemplate. </summary>
    public partial class DiscoveryTemplate
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiscoveryTemplate"/>. </summary>
        internal DiscoveryTemplate()
        {
            Seeds = new ChangeTrackingList<DiscoverySource>();
            Names = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DiscoveryTemplate"/>. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="industry"></param>
        /// <param name="region"></param>
        /// <param name="countryCode"></param>
        /// <param name="stateCode"></param>
        /// <param name="city"></param>
        /// <param name="seeds"></param>
        /// <param name="names"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiscoveryTemplate(string id, string name, string displayName, string industry, string region, string countryCode, string stateCode, string city, IReadOnlyList<DiscoverySource> seeds, IReadOnlyList<string> names, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            DisplayName = displayName;
            Industry = industry;
            Region = region;
            CountryCode = countryCode;
            StateCode = stateCode;
            City = city;
            Seeds = seeds;
            Names = names;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the id. </summary>
        public string Id { get; }
        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the display name. </summary>
        public string DisplayName { get; }
        /// <summary> Gets the industry. </summary>
        public string Industry { get; }
        /// <summary> Gets the region. </summary>
        public string Region { get; }
        /// <summary> Gets the country code. </summary>
        public string CountryCode { get; }
        /// <summary> Gets the state code. </summary>
        public string StateCode { get; }
        /// <summary> Gets the city. </summary>
        public string City { get; }
        /// <summary> Gets the seeds. </summary>
        public IReadOnlyList<DiscoverySource> Seeds { get; }
        /// <summary> Gets the names. </summary>
        public IReadOnlyList<string> Names { get; }
    }
}
