// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The VMExtensionInstanceView. </summary>
    public partial class VMExtensionInstanceView
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

        /// <summary> Initializes a new instance of <see cref="VMExtensionInstanceView"/>. </summary>
        internal VMExtensionInstanceView()
        {
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
            SubStatuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="VMExtensionInstanceView"/>. </summary>
        /// <param name="name"></param>
        /// <param name="statuses"></param>
        /// <param name="subStatuses"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMExtensionInstanceView(string name, IReadOnlyList<InstanceViewStatus> statuses, IReadOnlyList<InstanceViewStatus> subStatuses, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Statuses = statuses;
            SubStatuses = subStatuses;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
        /// <summary> Gets the statuses. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
        /// <summary> Gets the sub statuses. </summary>
        public IReadOnlyList<InstanceViewStatus> SubStatuses { get; }
    }
}
