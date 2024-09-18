// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.VoiceServices.Provisioning
{
    /// <summary> List of telephone numbers to be uploaded to an account via a PUT request. </summary>
    public partial class BatchNumbers
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

        /// <summary> Initializes a new instance of <see cref="BatchNumbers"/>. </summary>
        /// <param name="numbers"> The list of numbers to upload. At most 100 can be uploaded in one request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="numbers"/> is null. </exception>
        public BatchNumbers(IEnumerable<NumberResource> numbers)
        {
            Argument.AssertNotNull(numbers, nameof(numbers));

            Numbers = numbers.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="BatchNumbers"/>. </summary>
        /// <param name="numbers"> The list of numbers to upload. At most 100 can be uploaded in one request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNumbers(IList<NumberResource> numbers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Numbers = numbers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNumbers"/> for deserialization. </summary>
        internal BatchNumbers()
        {
        }

        /// <summary> The list of numbers to upload. At most 100 can be uploaded in one request. </summary>
        public IList<NumberResource> Numbers { get; }
    }
}
