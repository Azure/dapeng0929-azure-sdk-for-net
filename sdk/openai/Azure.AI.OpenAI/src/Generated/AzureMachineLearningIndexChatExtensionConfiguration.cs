// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// A specific representation of configurable options for Azure Machine Learning vector index when using it as an Azure
    /// OpenAI chat extension.
    /// </summary>
    public partial class AzureMachineLearningIndexChatExtensionConfiguration : AzureChatExtensionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="AzureMachineLearningIndexChatExtensionConfiguration"/>. </summary>
        /// <param name="parameters"> The parameters for the Azure Machine Learning vector index chat extension. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public AzureMachineLearningIndexChatExtensionConfiguration(AzureMachineLearningIndexChatExtensionParameters parameters)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            Type = AzureChatExtensionType.AzureMachineLearningIndex;
            Parameters = parameters;
        }

        /// <summary> Initializes a new instance of <see cref="AzureMachineLearningIndexChatExtensionConfiguration"/>. </summary>
        /// <param name="type">
        ///   The label for the type of an Azure chat extension. This typically corresponds to a matching Azure resource.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"> The parameters for the Azure Machine Learning vector index chat extension. </param>
        internal AzureMachineLearningIndexChatExtensionConfiguration(AzureChatExtensionType type, IDictionary<string, BinaryData> serializedAdditionalRawData, AzureMachineLearningIndexChatExtensionParameters parameters) : base(type, serializedAdditionalRawData)
        {
            Parameters = parameters;
        }

        /// <summary> Initializes a new instance of <see cref="AzureMachineLearningIndexChatExtensionConfiguration"/> for deserialization. </summary>
        internal AzureMachineLearningIndexChatExtensionConfiguration()
        {
        }

        /// <summary> The parameters for the Azure Machine Learning vector index chat extension. </summary>
        public AzureMachineLearningIndexChatExtensionParameters Parameters { get; }
    }
}
