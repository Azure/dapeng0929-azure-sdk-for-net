// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> The type of Azure Search retrieval query that should be executed when using it as an Azure OpenAI chat extension. </summary>
    public readonly partial struct AzureSearchQueryType : IEquatable<AzureSearchQueryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureSearchQueryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureSearchQueryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SimpleValue = "simple";
        private const string SemanticValue = "semantic";
        private const string VectorValue = "vector";
        private const string VectorSimpleHybridValue = "vector_simple_hybrid";
        private const string VectorSemanticHybridValue = "vector_semantic_hybrid";

        /// <summary> Represents the default, simple query parser. </summary>
        public static AzureSearchQueryType Simple { get; } = new AzureSearchQueryType(SimpleValue);
        /// <summary> Represents the semantic query parser for advanced semantic modeling. </summary>
        public static AzureSearchQueryType Semantic { get; } = new AzureSearchQueryType(SemanticValue);
        /// <summary> Represents vector search over computed data. </summary>
        public static AzureSearchQueryType Vector { get; } = new AzureSearchQueryType(VectorValue);
        /// <summary> Represents a combination of the simple query strategy with vector data. </summary>
        public static AzureSearchQueryType VectorSimpleHybrid { get; } = new AzureSearchQueryType(VectorSimpleHybridValue);
        /// <summary> Represents a combination of semantic search and vector data querying. </summary>
        public static AzureSearchQueryType VectorSemanticHybrid { get; } = new AzureSearchQueryType(VectorSemanticHybridValue);
        /// <summary> Determines if two <see cref="AzureSearchQueryType"/> values are the same. </summary>
        public static bool operator ==(AzureSearchQueryType left, AzureSearchQueryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureSearchQueryType"/> values are not the same. </summary>
        public static bool operator !=(AzureSearchQueryType left, AzureSearchQueryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureSearchQueryType"/>. </summary>
        public static implicit operator AzureSearchQueryType(string value) => new AzureSearchQueryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureSearchQueryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureSearchQueryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
