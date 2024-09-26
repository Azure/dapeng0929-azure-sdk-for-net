// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AVS.ScriptExecutionFinished event. </summary>
    public partial class AvsScriptExecutionFinishedEventData : AvsScriptExecutionEventData
    {
        /// <summary> Initializes a new instance of <see cref="AvsScriptExecutionFinishedEventData"/>. </summary>
        /// <param name="operationId"> Id of the operation that caused this event. </param>
        /// <param name="cmdletId"> Cmdlet referenced in the execution that caused this event. </param>
        /// <param name="namedOutputs"> Named outputs of completed execution, if any. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/>, <paramref name="cmdletId"/> or <paramref name="namedOutputs"/> is null. </exception>
        internal AvsScriptExecutionFinishedEventData(string operationId, string cmdletId, IReadOnlyDictionary<string, string> namedOutputs) : base(operationId, cmdletId)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
            Argument.AssertNotNull(cmdletId, nameof(cmdletId));
            Argument.AssertNotNull(namedOutputs, nameof(namedOutputs));

            NamedOutputs = namedOutputs;
        }

        /// <summary> Initializes a new instance of <see cref="AvsScriptExecutionFinishedEventData"/>. </summary>
        /// <param name="operationId"> Id of the operation that caused this event. </param>
        /// <param name="cmdletId"> Cmdlet referenced in the execution that caused this event. </param>
        /// <param name="output"> Stdout outputs from the execution, if any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="namedOutputs"> Named outputs of completed execution, if any. </param>
        internal AvsScriptExecutionFinishedEventData(string operationId, string cmdletId, IReadOnlyList<string> output, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyDictionary<string, string> namedOutputs) : base(operationId, cmdletId, output, serializedAdditionalRawData)
        {
            NamedOutputs = namedOutputs;
        }

        /// <summary> Initializes a new instance of <see cref="AvsScriptExecutionFinishedEventData"/> for deserialization. </summary>
        internal AvsScriptExecutionFinishedEventData()
        {
        }

        /// <summary> Named outputs of completed execution, if any. </summary>
        public IReadOnlyDictionary<string, string> NamedOutputs { get; }
    }
}
