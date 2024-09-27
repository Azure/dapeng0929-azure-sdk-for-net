// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.AVS.ScriptExecutionFailed event. </summary>
    public partial class AvsScriptExecutionFailedEventData : AvsScriptExecutionEventData
    {
        /// <summary> Initializes a new instance of <see cref="AvsScriptExecutionFailedEventData"/>. </summary>
        /// <param name="operationId"> Id of the operation that caused this event. </param>
        /// <param name="cmdletId"> Cmdlet referenced in the execution that caused this event. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> or <paramref name="cmdletId"/> is null. </exception>
        internal AvsScriptExecutionFailedEventData(string operationId, string cmdletId) : base(operationId, cmdletId)
        {
            Argument.AssertNotNull(operationId, nameof(operationId));
            Argument.AssertNotNull(cmdletId, nameof(cmdletId));
        }

        /// <summary> Initializes a new instance of <see cref="AvsScriptExecutionFailedEventData"/>. </summary>
        /// <param name="operationId"> Id of the operation that caused this event. </param>
        /// <param name="cmdletId"> Cmdlet referenced in the execution that caused this event. </param>
        /// <param name="output"> Stdout outputs from the execution, if any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="failureMessage"> Failure reason of an event. </param>
        internal AvsScriptExecutionFailedEventData(string operationId, string cmdletId, IReadOnlyList<string> output, IDictionary<string, BinaryData> serializedAdditionalRawData, string failureMessage) : base(operationId, cmdletId, output, serializedAdditionalRawData)
        {
            FailureMessage = failureMessage;
        }

        /// <summary> Initializes a new instance of <see cref="AvsScriptExecutionFailedEventData"/> for deserialization. </summary>
        internal AvsScriptExecutionFailedEventData()
        {
        }

        /// <summary> Failure reason of an event. </summary>
        public string FailureMessage { get; }
    }
}
