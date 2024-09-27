// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Test app components. </summary>
    public partial class TestAppComponents
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

        /// <summary> Initializes a new instance of <see cref="TestAppComponents"/>. </summary>
        /// <param name="components">
        /// Azure resource collection { resource id (fully qualified resource Id e.g
        /// subscriptions/{subId}/resourceGroups/{rg}/providers/Microsoft.LoadTestService/loadtests/{resName})
        /// : resource object }
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="components"/> is null. </exception>
        public TestAppComponents(IDictionary<string, AppComponent> components)
        {
            Argument.AssertNotNull(components, nameof(components));

            Components = components;
        }

        /// <summary> Initializes a new instance of <see cref="TestAppComponents"/>. </summary>
        /// <param name="components">
        /// Azure resource collection { resource id (fully qualified resource Id e.g
        /// subscriptions/{subId}/resourceGroups/{rg}/providers/Microsoft.LoadTestService/loadtests/{resName})
        /// : resource object }
        /// </param>
        /// <param name="testId"> Test identifier. </param>
        /// <param name="createdDateTime"> The creation datetime(RFC 3339 literal format). </param>
        /// <param name="createdBy"> The user that created. </param>
        /// <param name="lastModifiedDateTime"> The last Modified datetime(RFC 3339 literal format). </param>
        /// <param name="lastModifiedBy"> The user that last modified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TestAppComponents(IDictionary<string, AppComponent> components, string testId, DateTimeOffset? createdDateTime, string createdBy, DateTimeOffset? lastModifiedDateTime, string lastModifiedBy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Components = components;
            TestId = testId;
            CreatedDateTime = createdDateTime;
            CreatedBy = createdBy;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedBy = lastModifiedBy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TestAppComponents"/> for deserialization. </summary>
        internal TestAppComponents()
        {
        }

        /// <summary>
        /// Azure resource collection { resource id (fully qualified resource Id e.g
        /// subscriptions/{subId}/resourceGroups/{rg}/providers/Microsoft.LoadTestService/loadtests/{resName})
        /// : resource object }
        /// </summary>
        public IDictionary<string, AppComponent> Components { get; }
        /// <summary> Test identifier. </summary>
        public string TestId { get; }
        /// <summary> The creation datetime(RFC 3339 literal format). </summary>
        public DateTimeOffset? CreatedDateTime { get; }
        /// <summary> The user that created. </summary>
        public string CreatedBy { get; }
        /// <summary> The last Modified datetime(RFC 3339 literal format). </summary>
        public DateTimeOffset? LastModifiedDateTime { get; }
        /// <summary> The user that last modified. </summary>
        public string LastModifiedBy { get; }
    }
}
