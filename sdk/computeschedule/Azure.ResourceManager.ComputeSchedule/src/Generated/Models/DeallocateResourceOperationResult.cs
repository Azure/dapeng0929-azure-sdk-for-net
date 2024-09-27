// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ComputeSchedule.Models
{
    /// <summary> The DeallocateResourceOperationResult. </summary>
    public partial class DeallocateResourceOperationResult
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

        /// <summary> Initializes a new instance of <see cref="DeallocateResourceOperationResult"/>. </summary>
        /// <param name="description"></param>
        /// <param name="resourceType"></param>
        /// <param name="location"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="description"/> or <paramref name="resourceType"/> is null. </exception>
        internal DeallocateResourceOperationResult(string description, string resourceType, AzureLocation location)
        {
            Argument.AssertNotNull(description, nameof(description));
            Argument.AssertNotNull(resourceType, nameof(resourceType));

            Description = description;
            ResourceType = resourceType;
            Location = location;
            Results = new ChangeTrackingList<ResourceOperationResult>();
        }

        /// <summary> Initializes a new instance of <see cref="DeallocateResourceOperationResult"/>. </summary>
        /// <param name="description"></param>
        /// <param name="resourceType"></param>
        /// <param name="location"></param>
        /// <param name="results"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeallocateResourceOperationResult(string description, string resourceType, AzureLocation location, IReadOnlyList<ResourceOperationResult> results, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            ResourceType = resourceType;
            Location = location;
            Results = results;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeallocateResourceOperationResult"/> for deserialization. </summary>
        internal DeallocateResourceOperationResult()
        {
        }

        /// <summary> Gets the description. </summary>
        public string Description { get; }
        /// <summary> Gets the resource type. </summary>
        public string ResourceType { get; }
        /// <summary> Gets the location. </summary>
        public AzureLocation Location { get; }
        /// <summary> Gets the results. </summary>
        public IReadOnlyList<ResourceOperationResult> Results { get; }
    }
}
