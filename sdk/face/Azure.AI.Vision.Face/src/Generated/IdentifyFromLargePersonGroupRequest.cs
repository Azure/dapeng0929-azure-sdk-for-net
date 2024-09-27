// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Vision.Face
{
    /// <summary> The IdentifyFromLargePersonGroupRequest. </summary>
    internal partial class IdentifyFromLargePersonGroupRequest
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

        /// <summary> Initializes a new instance of <see cref="IdentifyFromLargePersonGroupRequest"/>. </summary>
        /// <param name="faceIds"> Array of query faces faceIds, created by the "Detect". Each of the faces are identified independently. The valid number of faceIds is between [1, 10]. </param>
        /// <param name="largePersonGroupId"> largePersonGroupId of the target Large Person Group, created by "Create Large Person Group". Parameter personGroupId and largePersonGroupId should not be provided at the same time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="faceIds"/> or <paramref name="largePersonGroupId"/> is null. </exception>
        internal IdentifyFromLargePersonGroupRequest(IEnumerable<Guid> faceIds, string largePersonGroupId)
        {
            Argument.AssertNotNull(faceIds, nameof(faceIds));
            Argument.AssertNotNull(largePersonGroupId, nameof(largePersonGroupId));

            FaceIds = faceIds.ToList();
            LargePersonGroupId = largePersonGroupId;
        }

        /// <summary> Initializes a new instance of <see cref="IdentifyFromLargePersonGroupRequest"/>. </summary>
        /// <param name="faceIds"> Array of query faces faceIds, created by the "Detect". Each of the faces are identified independently. The valid number of faceIds is between [1, 10]. </param>
        /// <param name="largePersonGroupId"> largePersonGroupId of the target Large Person Group, created by "Create Large Person Group". Parameter personGroupId and largePersonGroupId should not be provided at the same time. </param>
        /// <param name="maxNumOfCandidatesReturned"> The range of maxNumOfCandidatesReturned is between 1 and 100. Default value is 10. </param>
        /// <param name="confidenceThreshold"> Customized identification confidence threshold, in the range of [0, 1]. Advanced user can tweak this value to override default internal threshold for better precision on their scenario data. Note there is no guarantee of this threshold value working on other data and after algorithm updates. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IdentifyFromLargePersonGroupRequest(IReadOnlyList<Guid> faceIds, string largePersonGroupId, int? maxNumOfCandidatesReturned, float? confidenceThreshold, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FaceIds = faceIds;
            LargePersonGroupId = largePersonGroupId;
            MaxNumOfCandidatesReturned = maxNumOfCandidatesReturned;
            ConfidenceThreshold = confidenceThreshold;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="IdentifyFromLargePersonGroupRequest"/> for deserialization. </summary>
        internal IdentifyFromLargePersonGroupRequest()
        {
        }

        /// <summary> Array of query faces faceIds, created by the "Detect". Each of the faces are identified independently. The valid number of faceIds is between [1, 10]. </summary>
        public IReadOnlyList<Guid> FaceIds { get; }
        /// <summary> largePersonGroupId of the target Large Person Group, created by "Create Large Person Group". Parameter personGroupId and largePersonGroupId should not be provided at the same time. </summary>
        public string LargePersonGroupId { get; }
        /// <summary> The range of maxNumOfCandidatesReturned is between 1 and 100. Default value is 10. </summary>
        public int? MaxNumOfCandidatesReturned { get; }
        /// <summary> Customized identification confidence threshold, in the range of [0, 1]. Advanced user can tweak this value to override default internal threshold for better precision on their scenario data. Note there is no guarantee of this threshold value working on other data and after algorithm updates. </summary>
        public float? ConfidenceThreshold { get; }
    }
}
