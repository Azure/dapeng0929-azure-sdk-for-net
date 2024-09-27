// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI
{
    /// <summary> Log probability information for a choice, as requested via 'logprobs' and 'top_logprobs'. </summary>
    public partial class ChatChoiceLogProbabilityInfo
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

        /// <summary> Initializes a new instance of <see cref="ChatChoiceLogProbabilityInfo"/>. </summary>
        /// <param name="tokenLogProbabilityResults"> The list of log probability information entries for the choice's message content tokens, as requested via the 'logprobs' option. </param>
        /// <param name="refusal"> The list of log probability information entries for the choice's message refusal message tokens, as requested via the 'logprobs' option. </param>
        internal ChatChoiceLogProbabilityInfo(IEnumerable<ChatTokenLogProbabilityResult> tokenLogProbabilityResults, IEnumerable<ChatTokenLogProbabilityResult> refusal)
        {
            TokenLogProbabilityResults = tokenLogProbabilityResults?.ToList();
            Refusal = refusal?.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ChatChoiceLogProbabilityInfo"/>. </summary>
        /// <param name="tokenLogProbabilityResults"> The list of log probability information entries for the choice's message content tokens, as requested via the 'logprobs' option. </param>
        /// <param name="refusal"> The list of log probability information entries for the choice's message refusal message tokens, as requested via the 'logprobs' option. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatChoiceLogProbabilityInfo(IReadOnlyList<ChatTokenLogProbabilityResult> tokenLogProbabilityResults, IReadOnlyList<ChatTokenLogProbabilityResult> refusal, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TokenLogProbabilityResults = tokenLogProbabilityResults;
            Refusal = refusal;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatChoiceLogProbabilityInfo"/> for deserialization. </summary>
        internal ChatChoiceLogProbabilityInfo()
        {
        }

        /// <summary> The list of log probability information entries for the choice's message content tokens, as requested via the 'logprobs' option. </summary>
        public IReadOnlyList<ChatTokenLogProbabilityResult> TokenLogProbabilityResults { get; }
        /// <summary> The list of log probability information entries for the choice's message refusal message tokens, as requested via the 'logprobs' option. </summary>
        public IReadOnlyList<ChatTokenLogProbabilityResult> Refusal { get; }
    }
}
