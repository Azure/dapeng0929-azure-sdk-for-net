// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The NetworkSecurityGroupRule. </summary>
    public partial class NetworkSecurityGroupRule
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

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupRule"/>. </summary>
        /// <param name="priority"></param>
        /// <param name="access"></param>
        /// <param name="sourceAddressPrefix"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceAddressPrefix"/> is null. </exception>
        public NetworkSecurityGroupRule(int priority, NetworkSecurityGroupRuleAccess access, string sourceAddressPrefix)
        {
            Argument.AssertNotNull(sourceAddressPrefix, nameof(sourceAddressPrefix));

            Priority = priority;
            Access = access;
            SourceAddressPrefix = sourceAddressPrefix;
            SourcePortRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupRule"/>. </summary>
        /// <param name="priority"></param>
        /// <param name="access"></param>
        /// <param name="sourceAddressPrefix"></param>
        /// <param name="sourcePortRanges"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityGroupRule(int priority, NetworkSecurityGroupRuleAccess access, string sourceAddressPrefix, IList<string> sourcePortRanges, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Priority = priority;
            Access = access;
            SourceAddressPrefix = sourceAddressPrefix;
            SourcePortRanges = sourcePortRanges;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupRule"/> for deserialization. </summary>
        internal NetworkSecurityGroupRule()
        {
        }

        /// <summary> Gets or sets the priority. </summary>
        public int Priority { get; set; }
        /// <summary> Gets or sets the access. </summary>
        public NetworkSecurityGroupRuleAccess Access { get; set; }
        /// <summary> Gets or sets the source address prefix. </summary>
        public string SourceAddressPrefix { get; set; }
        /// <summary> Gets the source port ranges. </summary>
        public IList<string> SourcePortRanges { get; }
    }
}
