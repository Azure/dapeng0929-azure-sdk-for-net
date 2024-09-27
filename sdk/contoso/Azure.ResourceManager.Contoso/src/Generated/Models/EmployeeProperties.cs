// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Contoso.Models
{
    /// <summary> Employee properties. </summary>
    public partial class EmployeeProperties
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

        /// <summary> Initializes a new instance of <see cref="EmployeeProperties"/>. </summary>
        public EmployeeProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EmployeeProperties"/>. </summary>
        /// <param name="age"> Age of employee. </param>
        /// <param name="city"> City of employee. </param>
        /// <param name="profile"> Profile of employee. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EmployeeProperties(int? age, string city, byte[] profile, ProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Age = age;
            City = city;
            Profile = profile;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Age of employee. </summary>
        public int? Age { get; set; }
        /// <summary> City of employee. </summary>
        public string City { get; set; }
        /// <summary> Profile of employee. </summary>
        public byte[] Profile { get; set; }
        /// <summary> The status of the last operation. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
