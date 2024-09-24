// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the validations profile of a Gallery Image Version. </summary>
    public partial class ValidationsProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ValidationsProfile"/>. </summary>
        public ValidationsProfile()
        {
            ExecutedValidations = new ChangeTrackingList<ExecutedValidation>();
            PlatformAttributes = new ChangeTrackingList<PlatformAttribute>();
        }

        /// <summary> Initializes a new instance of <see cref="ValidationsProfile"/>. </summary>
        /// <param name="validationETag"> The published time of the image version. </param>
        /// <param name="executedValidations"></param>
        /// <param name="platformAttributes"> This specifies the pub, offer, sku and version of the image version metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ValidationsProfile(string validationETag, IList<ExecutedValidation> executedValidations, IList<PlatformAttribute> platformAttributes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ValidationETag = validationETag;
            ExecutedValidations = executedValidations;
            PlatformAttributes = platformAttributes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The published time of the image version. </summary>
        public string ValidationETag { get; set; }
        /// <summary> Gets the executed validations. </summary>
        public IList<ExecutedValidation> ExecutedValidations { get; }
        /// <summary> This specifies the pub, offer, sku and version of the image version metadata. </summary>
        public IList<PlatformAttribute> PlatformAttributes { get; }
    }
}
