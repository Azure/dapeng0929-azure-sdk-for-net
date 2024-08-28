// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> cisa cve in a given workspace. </summary>
    public partial class CisaCveResult
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

        /// <summary> Initializes a new instance of <see cref="CisaCveResult"/>. </summary>
        /// <param name="vendorProject"> The vendor or project name for the vulnerability. </param>
        /// <param name="product"> The vulnerability product. </param>
        /// <param name="vulnerabilityName"> The name of the vulnerability. </param>
        /// <param name="shortDescription"> A short description of the vulnerability. </param>
        /// <param name="requiredAction"> The required action to address the vulnerability. </param>
        /// <param name="notes"> Any additional notes about the vulnerability. </param>
        /// <param name="dateAdded"> The date the vulnerability was added to the catalog in the format YYYY-MM-DD. </param>
        /// <param name="dueDate"> The date the required action is due in the format YYYY-MM-DD. </param>
        /// <param name="updatedAt"> The date the vulnerability was updated. </param>
        /// <param name="count"> The number of assets affected by the vulnerability. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vendorProject"/>, <paramref name="product"/>, <paramref name="vulnerabilityName"/>, <paramref name="shortDescription"/>, <paramref name="requiredAction"/> or <paramref name="notes"/> is null. </exception>
        internal CisaCveResult(string vendorProject, string product, string vulnerabilityName, string shortDescription, string requiredAction, string notes, DateTimeOffset dateAdded, DateTimeOffset dueDate, DateTimeOffset updatedAt, long count)
        {
            Argument.AssertNotNull(vendorProject, nameof(vendorProject));
            Argument.AssertNotNull(product, nameof(product));
            Argument.AssertNotNull(vulnerabilityName, nameof(vulnerabilityName));
            Argument.AssertNotNull(shortDescription, nameof(shortDescription));
            Argument.AssertNotNull(requiredAction, nameof(requiredAction));
            Argument.AssertNotNull(notes, nameof(notes));

            VendorProject = vendorProject;
            Product = product;
            VulnerabilityName = vulnerabilityName;
            ShortDescription = shortDescription;
            RequiredAction = requiredAction;
            Notes = notes;
            DateAdded = dateAdded;
            DueDate = dueDate;
            UpdatedAt = updatedAt;
            Count = count;
        }

        /// <summary> Initializes a new instance of <see cref="CisaCveResult"/>. </summary>
        /// <param name="cveId"> The CVE ID of the vulnerability in the format CVE-YYYY-NNNN, note that the number portion can have more than 4 digits. </param>
        /// <param name="vendorProject"> The vendor or project name for the vulnerability. </param>
        /// <param name="product"> The vulnerability product. </param>
        /// <param name="vulnerabilityName"> The name of the vulnerability. </param>
        /// <param name="shortDescription"> A short description of the vulnerability. </param>
        /// <param name="requiredAction"> The required action to address the vulnerability. </param>
        /// <param name="notes"> Any additional notes about the vulnerability. </param>
        /// <param name="dateAdded"> The date the vulnerability was added to the catalog in the format YYYY-MM-DD. </param>
        /// <param name="dueDate"> The date the required action is due in the format YYYY-MM-DD. </param>
        /// <param name="updatedAt"> The date the vulnerability was updated. </param>
        /// <param name="count"> The number of assets affected by the vulnerability. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CisaCveResult(string cveId, string vendorProject, string product, string vulnerabilityName, string shortDescription, string requiredAction, string notes, DateTimeOffset dateAdded, DateTimeOffset dueDate, DateTimeOffset updatedAt, long count, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CveId = cveId;
            VendorProject = vendorProject;
            Product = product;
            VulnerabilityName = vulnerabilityName;
            ShortDescription = shortDescription;
            RequiredAction = requiredAction;
            Notes = notes;
            DateAdded = dateAdded;
            DueDate = dueDate;
            UpdatedAt = updatedAt;
            Count = count;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CisaCveResult"/> for deserialization. </summary>
        internal CisaCveResult()
        {
        }

        /// <summary> The CVE ID of the vulnerability in the format CVE-YYYY-NNNN, note that the number portion can have more than 4 digits. </summary>
        public string CveId { get; }
        /// <summary> The vendor or project name for the vulnerability. </summary>
        public string VendorProject { get; }
        /// <summary> The vulnerability product. </summary>
        public string Product { get; }
        /// <summary> The name of the vulnerability. </summary>
        public string VulnerabilityName { get; }
        /// <summary> A short description of the vulnerability. </summary>
        public string ShortDescription { get; }
        /// <summary> The required action to address the vulnerability. </summary>
        public string RequiredAction { get; }
        /// <summary> Any additional notes about the vulnerability. </summary>
        public string Notes { get; }
        /// <summary> The date the vulnerability was added to the catalog in the format YYYY-MM-DD. </summary>
        public DateTimeOffset DateAdded { get; }
        /// <summary> The date the required action is due in the format YYYY-MM-DD. </summary>
        public DateTimeOffset DueDate { get; }
        /// <summary> The date the vulnerability was updated. </summary>
        public DateTimeOffset UpdatedAt { get; }
        /// <summary> The number of assets affected by the vulnerability. </summary>
        public long Count { get; }
    }
}
