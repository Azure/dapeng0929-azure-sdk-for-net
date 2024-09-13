// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Microsoft.VoiceServices.Provisioning
{
    /// <summary> Account details specific to Teams Direct Routing on this Account. </summary>
    public partial class TeamsDirectRoutingAccountDetails
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

        /// <summary> Initializes a new instance of <see cref="TeamsDirectRoutingAccountDetails"/>. </summary>
        /// <param name="syncEnabled"> Boolean indicating if data is being provisioned through the backend service. </param>
        /// <param name="enabled"> Boolean indicating if the service is enabled on this Account. </param>
        public TeamsDirectRoutingAccountDetails(bool syncEnabled, bool enabled)
        {
            SyncEnabled = syncEnabled;
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of <see cref="TeamsDirectRoutingAccountDetails"/>. </summary>
        /// <param name="syncEnabled"> Boolean indicating if data is being provisioned through the backend service. </param>
        /// <param name="enabled"> Boolean indicating if the service is enabled on this Account. </param>
        /// <param name="numberCount"> The count of telephone numbers associated with this account that have this backend service enabled. </param>
        /// <param name="configuration"> The configuration for Teams Direct Routing on this account. </param>
        /// <param name="subdomainStatus"> The provisioning status of the domains. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TeamsDirectRoutingAccountDetails(bool syncEnabled, bool enabled, long? numberCount, TeamsDirectRoutingAccountConfig configuration, TeamsDirectRoutingSubdomainProvisioningStatus subdomainStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SyncEnabled = syncEnabled;
            Enabled = enabled;
            NumberCount = numberCount;
            Configuration = configuration;
            SubdomainStatus = subdomainStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TeamsDirectRoutingAccountDetails"/> for deserialization. </summary>
        internal TeamsDirectRoutingAccountDetails()
        {
        }

        /// <summary> Boolean indicating if data is being provisioned through the backend service. </summary>
        public bool SyncEnabled { get; set; }
        /// <summary> Boolean indicating if the service is enabled on this Account. </summary>
        public bool Enabled { get; set; }
        /// <summary> The count of telephone numbers associated with this account that have this backend service enabled. </summary>
        public long? NumberCount { get; }
        /// <summary> The configuration for Teams Direct Routing on this account. </summary>
        public TeamsDirectRoutingAccountConfig Configuration { get; set; }
        /// <summary> The provisioning status of the domains. </summary>
        public TeamsDirectRoutingSubdomainProvisioningStatus SubdomainStatus { get; }
    }
}
