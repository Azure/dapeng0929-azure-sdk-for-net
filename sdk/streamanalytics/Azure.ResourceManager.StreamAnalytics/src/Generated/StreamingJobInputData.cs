// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics.Models;

namespace Azure.ResourceManager.StreamAnalytics
{
    /// <summary>
    /// A class representing the StreamingJobInput data model.
    /// An input object, containing all information associated with the named input. All inputs are contained under a streaming job.
    /// </summary>
    public partial class StreamingJobInputData : StreamAnalyticsSubResource
    {
        /// <summary> Initializes a new instance of <see cref="StreamingJobInputData"/>. </summary>
        public StreamingJobInputData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamingJobInputData"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties">
        /// The properties that are associated with an input. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamingJobInputProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ReferenceInputProperties"/> and <see cref="StreamInputProperties"/>.
        /// </param>
        internal StreamingJobInputData(ResourceIdentifier id, string name, Core.ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, StreamingJobInputProperties properties) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            Properties = properties;
        }

        /// <summary>
        /// The properties that are associated with an input. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamingJobInputProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ReferenceInputProperties"/> and <see cref="StreamInputProperties"/>.
        /// </summary>
        public StreamingJobInputProperties Properties { get; set; }
    }
}
