// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> Parameters for creating an Azure Batch Job Schedule. </summary>
    public partial class BatchJobScheduleCreateContent
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

        /// <summary> Initializes a new instance of <see cref="BatchJobScheduleCreateContent"/>. </summary>
        /// <param name="id"> A string that uniquely identifies the schedule within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an Account that differ only by case). </param>
        /// <param name="schedule"> The schedule according to which Jobs will be created. All times are fixed respective to UTC and are not impacted by daylight saving time. </param>
        /// <param name="jobSpecification"> The details of the Jobs to be created on this schedule. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="schedule"/> or <paramref name="jobSpecification"/> is null. </exception>
        public BatchJobScheduleCreateContent(string id, BatchJobScheduleConfiguration schedule, BatchJobSpecification jobSpecification)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(schedule, nameof(schedule));
            Argument.AssertNotNull(jobSpecification, nameof(jobSpecification));

            Id = id;
            Schedule = schedule;
            JobSpecification = jobSpecification;
            Metadata = new ChangeTrackingList<MetadataItem>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobScheduleCreateContent"/>. </summary>
        /// <param name="id"> A string that uniquely identifies the schedule within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an Account that differ only by case). </param>
        /// <param name="displayName"> The display name for the schedule. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </param>
        /// <param name="schedule"> The schedule according to which Jobs will be created. All times are fixed respective to UTC and are not impacted by daylight saving time. </param>
        /// <param name="jobSpecification"> The details of the Jobs to be created on this schedule. </param>
        /// <param name="metadata"> A list of name-value pairs associated with the schedule as metadata. The Batch service does not assign any meaning to metadata; it is solely for the use of user code. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchJobScheduleCreateContent(string id, string displayName, BatchJobScheduleConfiguration schedule, BatchJobSpecification jobSpecification, IList<MetadataItem> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            DisplayName = displayName;
            Schedule = schedule;
            JobSpecification = jobSpecification;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchJobScheduleCreateContent"/> for deserialization. </summary>
        internal BatchJobScheduleCreateContent()
        {
        }

        /// <summary> A string that uniquely identifies the schedule within the Account. The ID can contain any combination of alphanumeric characters including hyphens and underscores, and cannot contain more than 64 characters. The ID is case-preserving and case-insensitive (that is, you may not have two IDs within an Account that differ only by case). </summary>
        public string Id { get; }
        /// <summary> The display name for the schedule. The display name need not be unique and can contain any Unicode characters up to a maximum length of 1024. </summary>
        public string DisplayName { get; set; }
        /// <summary> The schedule according to which Jobs will be created. All times are fixed respective to UTC and are not impacted by daylight saving time. </summary>
        public BatchJobScheduleConfiguration Schedule { get; }
        /// <summary> The details of the Jobs to be created on this schedule. </summary>
        public BatchJobSpecification JobSpecification { get; }
        /// <summary> A list of name-value pairs associated with the schedule as metadata. The Batch service does not assign any meaning to metadata; it is solely for the use of user code. </summary>
        public IList<MetadataItem> Metadata { get; }
    }
}
