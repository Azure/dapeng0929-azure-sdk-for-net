// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The BatchApplicationPackageReference. </summary>
    public partial class BatchApplicationPackageReference
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

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageReference"/>. </summary>
        /// <param name="applicationId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/> is null. </exception>
        public BatchApplicationPackageReference(string applicationId)
        {
            Argument.AssertNotNull(applicationId, nameof(applicationId));

            ApplicationId = applicationId;
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageReference"/>. </summary>
        /// <param name="applicationId"></param>
        /// <param name="version"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchApplicationPackageReference(string applicationId, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApplicationId = applicationId;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchApplicationPackageReference"/> for deserialization. </summary>
        internal BatchApplicationPackageReference()
        {
        }

        /// <summary> Gets or sets the application id. </summary>
        public string ApplicationId { get; set; }
        /// <summary> Gets or sets the version. </summary>
        public string Version { get; set; }
    }
}
