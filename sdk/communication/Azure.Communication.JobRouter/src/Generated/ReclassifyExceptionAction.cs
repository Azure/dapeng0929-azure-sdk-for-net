// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> The ReclassifyExceptionAction. </summary>
    public partial class ReclassifyExceptionAction : ExceptionAction
    {
        /// <summary> Initializes a new instance of <see cref="ReclassifyExceptionAction"/>. </summary>
        /// <param name="id"></param>
        /// <param name="kind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="classificationPolicyId"></param>
        /// <param name="labelsToUpsert"></param>
        internal ReclassifyExceptionAction(string id, ExceptionActionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string classificationPolicyId, IDictionary<string, BinaryData> labelsToUpsert) : base(id, kind, serializedAdditionalRawData)
        {
            ClassificationPolicyId = classificationPolicyId;
            _labelsToUpsert = labelsToUpsert;
        }
    }
}
