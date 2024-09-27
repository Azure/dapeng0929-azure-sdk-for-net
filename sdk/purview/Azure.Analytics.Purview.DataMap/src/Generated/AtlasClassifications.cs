// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.DataMap
{
    /// <summary> The AtlasClassifications. </summary>
    public partial class AtlasClassifications
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

        /// <summary> Initializes a new instance of <see cref="AtlasClassifications"/>. </summary>
        internal AtlasClassifications()
        {
            List = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="AtlasClassifications"/>. </summary>
        /// <param name="list"></param>
        /// <param name="pageSize"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortType"></param>
        /// <param name="startIndex"></param>
        /// <param name="totalCount"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AtlasClassifications(IReadOnlyList<BinaryData> list, int? pageSize, string sortBy, AtlasSortType? sortType, int? startIndex, int? totalCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            List = list;
            PageSize = pageSize;
            SortBy = sortBy;
            SortType = sortType;
            StartIndex = startIndex;
            TotalCount = totalCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Gets the list
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyList<BinaryData> List { get; }
        /// <summary> Gets the page size. </summary>
        public int? PageSize { get; }
        /// <summary> Gets the sort by. </summary>
        public string SortBy { get; }
        /// <summary> Gets the sort type. </summary>
        public AtlasSortType? SortType { get; }
        /// <summary> Gets the start index. </summary>
        public int? StartIndex { get; }
        /// <summary> Gets the total count. </summary>
        public int? TotalCount { get; }
    }
}
