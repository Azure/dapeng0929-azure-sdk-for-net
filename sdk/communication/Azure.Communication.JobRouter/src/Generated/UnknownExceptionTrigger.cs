// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> Unknown version of ExceptionTrigger. </summary>
    internal partial class UnknownExceptionTrigger : ExceptionTrigger
    {
        /// <summary> Initializes a new instance of <see cref="UnknownExceptionTrigger"/>. </summary>
        /// <param name="exceptionTriggerKind"> The type discriminator describing a sub-type of ExceptionTrigger. </param>
        /// <param name="kind"> The type discriminator describing a kind of ExceptionTrigger. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownExceptionTrigger(ExceptionTriggerKind exceptionTriggerKind, ExceptionTriggerKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(exceptionTriggerKind, kind, serializedAdditionalRawData)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UnknownExceptionTrigger"/> for deserialization. </summary>
        internal UnknownExceptionTrigger()
        {
        }
    }
}
