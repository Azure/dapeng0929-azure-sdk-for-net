// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Compute.Batch
{
    /// <summary> Contains information about an application in an Azure Batch Account. </summary>
    public partial class BatchApplication
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

        /// <summary> Initializes a new instance of <see cref="BatchApplication"/>. </summary>
        /// <param name="id"> A string that uniquely identifies the application within the Account. </param>
        /// <param name="displayName"> The display name for the application. </param>
        /// <param name="versions"> The list of available versions of the application. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="displayName"/> or <paramref name="versions"/> is null. </exception>
        internal BatchApplication(string id, string displayName, IEnumerable<string> versions)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(displayName, nameof(displayName));
            Argument.AssertNotNull(versions, nameof(versions));

            Id = id;
            DisplayName = displayName;
            Versions = versions.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplication"/>. </summary>
        /// <param name="id"> A string that uniquely identifies the application within the Account. </param>
        /// <param name="displayName"> The display name for the application. </param>
        /// <param name="versions"> The list of available versions of the application. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchApplication(string id, string displayName, IReadOnlyList<string> versions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            DisplayName = displayName;
            Versions = versions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplication"/> for deserialization. </summary>
        internal BatchApplication()
        {
        }

        /// <summary> A string that uniquely identifies the application within the Account. </summary>
        public string Id { get; }
        /// <summary> The display name for the application. </summary>
        public string DisplayName { get; }
        /// <summary> The list of available versions of the application. </summary>
        public IReadOnlyList<string> Versions { get; }
    }
}
