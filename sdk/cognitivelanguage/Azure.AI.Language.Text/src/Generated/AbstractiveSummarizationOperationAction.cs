// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary> The AbstractiveSummarizationOperationAction. </summary>
    public partial class AbstractiveSummarizationOperationAction : AnalyzeTextOperationAction
    {
        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationOperationAction"/>. </summary>
        public AbstractiveSummarizationOperationAction()
        {
            Kind = AnalyzeTextOperationActionKind.AbstractiveSummarization;
        }

        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationOperationAction"/>. </summary>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="actionContent"></param>
        internal AbstractiveSummarizationOperationAction(string name, AnalyzeTextOperationActionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, AbstractiveSummarizationActionContent actionContent) : base(name, kind, serializedAdditionalRawData)
        {
            ActionContent = actionContent;
        }

        /// <summary> Gets or sets the action content. </summary>
        public AbstractiveSummarizationActionContent ActionContent { get; set; }
    }
}
