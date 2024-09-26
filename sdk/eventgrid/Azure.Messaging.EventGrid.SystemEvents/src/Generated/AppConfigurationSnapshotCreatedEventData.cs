// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AppConfiguration.SnapshotCreated event. </summary>
    public partial class AppConfigurationSnapshotCreatedEventData : AppConfigurationSnapshotEventData
    {
        /// <summary> Initializes a new instance of <see cref="AppConfigurationSnapshotCreatedEventData"/>. </summary>
        /// <param name="name"> The name of the snapshot. </param>
        /// <param name="etag"> The etag representing the new state of the snapshot. </param>
        /// <param name="syncToken"> The sync token representing the server state after the event. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="etag"/> or <paramref name="syncToken"/> is null. </exception>
        internal AppConfigurationSnapshotCreatedEventData(string name, string etag, string syncToken) : base(name, etag, syncToken)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(etag, nameof(etag));
            Argument.AssertNotNull(syncToken, nameof(syncToken));
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationSnapshotCreatedEventData"/>. </summary>
        /// <param name="name"> The name of the snapshot. </param>
        /// <param name="etag"> The etag representing the new state of the snapshot. </param>
        /// <param name="syncToken"> The sync token representing the server state after the event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppConfigurationSnapshotCreatedEventData(string name, string etag, string syncToken, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(name, etag, syncToken, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppConfigurationSnapshotCreatedEventData"/> for deserialization. </summary>
        internal AppConfigurationSnapshotCreatedEventData()
        {
        }
    }
}
