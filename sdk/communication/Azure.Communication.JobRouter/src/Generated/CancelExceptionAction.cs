// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> An action that marks a job as cancelled. </summary>
    public partial class CancelExceptionAction : ExceptionAction
    {
        /// <summary> Initializes a new instance of <see cref="CancelExceptionAction"/>. </summary>
        /// <param name="exceptionActionKind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        internal CancelExceptionAction(ExceptionActionKind exceptionActionKind) : base(exceptionActionKind)
        {
            Kind = ExceptionActionKind.Cancel;
        }

        /// <summary> Initializes a new instance of <see cref="CancelExceptionAction"/>. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="exceptionActionKind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="note"> A note that will be appended to a job's notes collection with the current timestamp. </param>
        /// <param name="dispositionCode"> Indicates the outcome of a job, populate this field with your own custom values. </param>
        internal CancelExceptionAction(string id, ExceptionActionKind exceptionActionKind, ExceptionActionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string note, string dispositionCode) : base(id, exceptionActionKind, kind, serializedAdditionalRawData)
        {
            Note = note;
            DispositionCode = dispositionCode;
        }
    }
}
