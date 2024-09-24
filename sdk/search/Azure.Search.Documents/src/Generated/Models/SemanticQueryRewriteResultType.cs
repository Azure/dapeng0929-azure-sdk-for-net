// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> Type of query rewrite that was used for this request. </summary>
    public readonly partial struct SemanticQueryRewriteResultType : IEquatable<SemanticQueryRewriteResultType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SemanticQueryRewriteResultType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SemanticQueryRewriteResultType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OriginalQueryOnlyValue = "originalQueryOnly";

        /// <summary> Query rewrites were not succesfully generated for this request. Only the original query was used to retrieve the results. </summary>
        public static SemanticQueryRewriteResultType OriginalQueryOnly { get; } = new SemanticQueryRewriteResultType(OriginalQueryOnlyValue);
        /// <summary> Determines if two <see cref="SemanticQueryRewriteResultType"/> values are the same. </summary>
        public static bool operator ==(SemanticQueryRewriteResultType left, SemanticQueryRewriteResultType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SemanticQueryRewriteResultType"/> values are not the same. </summary>
        public static bool operator !=(SemanticQueryRewriteResultType left, SemanticQueryRewriteResultType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SemanticQueryRewriteResultType"/>. </summary>
        public static implicit operator SemanticQueryRewriteResultType(string value) => new SemanticQueryRewriteResultType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SemanticQueryRewriteResultType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SemanticQueryRewriteResultType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
