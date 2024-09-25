// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Type of paging. </summary>
    public readonly partial struct RestApiPollerRequestPagingKind : IEquatable<RestApiPollerRequestPagingKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RestApiPollerRequestPagingKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RestApiPollerRequestPagingKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinkHeaderValue = "LinkHeader";
        private const string NextPageTokenValue = "NextPageToken";
        private const string NextPageUrlValue = "NextPageUrl";
        private const string PersistentTokenValue = "PersistentToken";
        private const string PersistentLinkHeaderValue = "PersistentLinkHeader";
        private const string OffsetValue = "Offset";
        private const string CountBasedPagingValue = "CountBasedPaging";

        /// <summary> LinkHeader. </summary>
        public static RestApiPollerRequestPagingKind LinkHeader { get; } = new RestApiPollerRequestPagingKind(LinkHeaderValue);
        /// <summary> NextPageToken. </summary>
        public static RestApiPollerRequestPagingKind NextPageToken { get; } = new RestApiPollerRequestPagingKind(NextPageTokenValue);
        /// <summary> NextPageUrl. </summary>
        public static RestApiPollerRequestPagingKind NextPageUrl { get; } = new RestApiPollerRequestPagingKind(NextPageUrlValue);
        /// <summary> PersistentToken. </summary>
        public static RestApiPollerRequestPagingKind PersistentToken { get; } = new RestApiPollerRequestPagingKind(PersistentTokenValue);
        /// <summary> PersistentLinkHeader. </summary>
        public static RestApiPollerRequestPagingKind PersistentLinkHeader { get; } = new RestApiPollerRequestPagingKind(PersistentLinkHeaderValue);
        /// <summary> Offset. </summary>
        public static RestApiPollerRequestPagingKind Offset { get; } = new RestApiPollerRequestPagingKind(OffsetValue);
        /// <summary> CountBasedPaging. </summary>
        public static RestApiPollerRequestPagingKind CountBasedPaging { get; } = new RestApiPollerRequestPagingKind(CountBasedPagingValue);
        /// <summary> Determines if two <see cref="RestApiPollerRequestPagingKind"/> values are the same. </summary>
        public static bool operator ==(RestApiPollerRequestPagingKind left, RestApiPollerRequestPagingKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RestApiPollerRequestPagingKind"/> values are not the same. </summary>
        public static bool operator !=(RestApiPollerRequestPagingKind left, RestApiPollerRequestPagingKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RestApiPollerRequestPagingKind"/>. </summary>
        public static implicit operator RestApiPollerRequestPagingKind(string value) => new RestApiPollerRequestPagingKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RestApiPollerRequestPagingKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RestApiPollerRequestPagingKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
