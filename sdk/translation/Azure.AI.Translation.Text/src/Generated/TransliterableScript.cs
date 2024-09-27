// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Translation.Text
{
    /// <summary> The TransliterableScript. </summary>
    public partial class TransliterableScript : LanguageScript
    {
        /// <summary> Initializes a new instance of <see cref="TransliterableScript"/>. </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="nativeName"></param>
        /// <param name="directionality"></param>
        /// <param name="targetLanguageScripts"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/>, <paramref name="name"/>, <paramref name="nativeName"/> or <paramref name="targetLanguageScripts"/> is null. </exception>
        internal TransliterableScript(string code, string name, string nativeName, LanguageDirectionality directionality, IEnumerable<LanguageScript> targetLanguageScripts) : base(code, name, nativeName, directionality)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(nativeName, nameof(nativeName));
            Argument.AssertNotNull(targetLanguageScripts, nameof(targetLanguageScripts));

            TargetLanguageScripts = targetLanguageScripts.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="TransliterableScript"/>. </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="nativeName"></param>
        /// <param name="directionality"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="targetLanguageScripts"></param>
        internal TransliterableScript(string code, string name, string nativeName, LanguageDirectionality directionality, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<LanguageScript> targetLanguageScripts) : base(code, name, nativeName, directionality, serializedAdditionalRawData)
        {
            TargetLanguageScripts = targetLanguageScripts;
        }

        /// <summary> Initializes a new instance of <see cref="TransliterableScript"/> for deserialization. </summary>
        internal TransliterableScript()
        {
        }

        /// <summary> Gets the target language scripts. </summary>
        public IReadOnlyList<LanguageScript> TargetLanguageScripts { get; }
    }
}
