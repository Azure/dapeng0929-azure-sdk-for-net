// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Authoring.Analyzeconversations.Models
{
    /// <summary> Represents the assets of an orchestration project. </summary>
    public partial class ConversationalAnalysisAuthoringOrchestrationExportedProjectAssets : ConversationalAnalysisAuthoringExportedProjectAssets
    {
        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringOrchestrationExportedProjectAssets"/>. </summary>
        public ConversationalAnalysisAuthoringOrchestrationExportedProjectAssets()
        {
            ProjectKind = ConversationalAnalysisAuthoringProjectKind.Orchestration;
            Intents = new ChangeTrackingList<ConversationalAnalysisAuthoringOrchestrationExportedIntent>();
            Utterances = new ChangeTrackingList<ConversationalAnalysisAuthoringOrchestrationExportedUtterance>();
        }

        /// <summary> Initializes a new instance of <see cref="ConversationalAnalysisAuthoringOrchestrationExportedProjectAssets"/>. </summary>
        /// <param name="projectKind"> Discriminator. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="intents"> Represents the intents of the project. </param>
        /// <param name="utterances"> Represents the utterances of the project. </param>
        internal ConversationalAnalysisAuthoringOrchestrationExportedProjectAssets(ConversationalAnalysisAuthoringProjectKind projectKind, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<ConversationalAnalysisAuthoringOrchestrationExportedIntent> intents, IList<ConversationalAnalysisAuthoringOrchestrationExportedUtterance> utterances) : base(projectKind, serializedAdditionalRawData)
        {
            Intents = intents;
            Utterances = utterances;
        }

        /// <summary> Represents the intents of the project. </summary>
        public IList<ConversationalAnalysisAuthoringOrchestrationExportedIntent> Intents { get; }
        /// <summary> Represents the utterances of the project. </summary>
        public IList<ConversationalAnalysisAuthoringOrchestrationExportedUtterance> Utterances { get; }
    }
}
