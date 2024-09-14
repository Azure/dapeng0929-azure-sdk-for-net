// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A class representing the RestorableCosmosDBAccount data model.
    /// A Azure Cosmos DB restorable database account.
    /// </summary>
    public partial class RestorableCosmosDBAccountData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="RestorableCosmosDBAccountData"/>. </summary>
        internal RestorableCosmosDBAccountData()
        {
            RestorableLocations = new ChangeTrackingList<RestorableLocationResourceInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="RestorableCosmosDBAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the resource group to which the resource belongs. </param>
        /// <param name="accountName"> The name of the global database account. </param>
        /// <param name="createdOn"> The creation time of the restorable database account (ISO-8601 format). </param>
        /// <param name="deletedOn"> The time at which the restorable database account has been deleted (ISO-8601 format). </param>
        /// <param name="oldestRestorableOn"> The least recent time at which the database account can be restored to (ISO-8601 format). </param>
        /// <param name="apiType"> The API type of the restorable database account. </param>
        /// <param name="restorableLocations"> List of regions where the of the database account can be restored from. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorableCosmosDBAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string accountName, DateTimeOffset? createdOn, DateTimeOffset? deletedOn, DateTimeOffset? oldestRestorableOn, CosmosDBApiType? apiType, IReadOnlyList<RestorableLocationResourceInfo> restorableLocations, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Location = location;
            AccountName = accountName;
            CreatedOn = createdOn;
            DeletedOn = deletedOn;
            OldestRestorableOn = oldestRestorableOn;
            ApiType = apiType;
            RestorableLocations = restorableLocations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The location of the resource group to which the resource belongs. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; }
        /// <summary> The name of the global database account. </summary>
        [WirePath("properties.accountName")]
        public string AccountName { get; }
        /// <summary> The creation time of the restorable database account (ISO-8601 format). </summary>
        [WirePath("properties.creationTime")]
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time at which the restorable database account has been deleted (ISO-8601 format). </summary>
        [WirePath("properties.deletionTime")]
        public DateTimeOffset? DeletedOn { get; }
        /// <summary> The least recent time at which the database account can be restored to (ISO-8601 format). </summary>
        [WirePath("properties.oldestRestorableTime")]
        public DateTimeOffset? OldestRestorableOn { get; }
        /// <summary> The API type of the restorable database account. </summary>
        [WirePath("properties.apiType")]
        public CosmosDBApiType? ApiType { get; }
        /// <summary> List of regions where the of the database account can be restored from. </summary>
        [WirePath("properties.restorableLocations")]
        public IReadOnlyList<RestorableLocationResourceInfo> RestorableLocations { get; }
    }
}
