// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> The MultiInstanceSettings. </summary>
    public partial class MultiInstanceSettings
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

        /// <summary> Initializes a new instance of <see cref="MultiInstanceSettings"/>. </summary>
        /// <param name="coordinationCommandLine"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinationCommandLine"/> is null. </exception>
        public MultiInstanceSettings(string coordinationCommandLine)
        {
            Argument.AssertNotNull(coordinationCommandLine, nameof(coordinationCommandLine));

            CoordinationCommandLine = coordinationCommandLine;
            CommonResourceFiles = new ChangeTrackingList<ResourceFile>();
        }

        /// <summary> Initializes a new instance of <see cref="MultiInstanceSettings"/>. </summary>
        /// <param name="numberOfInstances"></param>
        /// <param name="coordinationCommandLine"></param>
        /// <param name="commonResourceFiles"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MultiInstanceSettings(int? numberOfInstances, string coordinationCommandLine, IList<ResourceFile> commonResourceFiles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NumberOfInstances = numberOfInstances;
            CoordinationCommandLine = coordinationCommandLine;
            CommonResourceFiles = commonResourceFiles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MultiInstanceSettings"/> for deserialization. </summary>
        internal MultiInstanceSettings()
        {
        }

        /// <summary> Gets or sets the number of instances. </summary>
        public int? NumberOfInstances { get; set; }
        /// <summary> Gets or sets the coordination command line. </summary>
        public string CoordinationCommandLine { get; set; }
        /// <summary> Gets the common resource files. </summary>
        public IList<ResourceFile> CommonResourceFiles { get; }
    }
}
