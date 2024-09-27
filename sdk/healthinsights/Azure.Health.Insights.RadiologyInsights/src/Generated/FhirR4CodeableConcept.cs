// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> The Fhir_R4_CodeableConcept. </summary>
    public partial class FhirR4CodeableConcept : FhirR4Element
    {
        /// <summary> Initializes a new instance of <see cref="FhirR4CodeableConcept"/>. </summary>
        public FhirR4CodeableConcept()
        {
            Coding = new ChangeTrackingList<FhirR4Coding>();
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4CodeableConcept"/>. </summary>
        /// <param name="id"></param>
        /// <param name="extension"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="coding"></param>
        /// <param name="text"></param>
        internal FhirR4CodeableConcept(string id, IList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<FhirR4Coding> coding, string text) : base(id, extension, serializedAdditionalRawData)
        {
            Coding = coding;
            Text = text;
        }

        /// <summary> Gets the coding. </summary>
        public IList<FhirR4Coding> Coding { get; }
        /// <summary> Gets or sets the text. </summary>
        public string Text { get; set; }
    }
}
