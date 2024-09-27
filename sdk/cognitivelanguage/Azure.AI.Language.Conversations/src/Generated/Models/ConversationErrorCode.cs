// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> The ConversationErrorCode. </summary>
    public readonly partial struct ConversationErrorCode : IEquatable<ConversationErrorCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConversationErrorCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConversationErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidRequestValue = "InvalidRequest";
        private const string InvalidArgumentValue = "InvalidArgument";
        private const string UnauthorizedValue = "Unauthorized";
        private const string ForbiddenValue = "Forbidden";
        private const string NotFoundValue = "NotFound";
        private const string ProjectNotFoundValue = "ProjectNotFound";
        private const string OperationNotFoundValue = "OperationNotFound";
        private const string AzureCognitiveSearchNotFoundValue = "AzureCognitiveSearchNotFound";
        private const string AzureCognitiveSearchIndexNotFoundValue = "AzureCognitiveSearchIndexNotFound";
        private const string TooManyRequestsValue = "TooManyRequests";
        private const string AzureCognitiveSearchThrottlingValue = "AzureCognitiveSearchThrottling";
        private const string AzureCognitiveSearchIndexLimitReachedValue = "AzureCognitiveSearchIndexLimitReached";
        private const string InternalServerErrorValue = "InternalServerError";
        private const string ServiceUnavailableValue = "ServiceUnavailable";
        private const string TimeoutValue = "Timeout";
        private const string QuotaExceededValue = "QuotaExceeded";
        private const string ConflictValue = "Conflict";
        private const string WarningValue = "Warning";

        /// <summary> InvalidRequest. </summary>
        public static ConversationErrorCode InvalidRequest { get; } = new ConversationErrorCode(InvalidRequestValue);
        /// <summary> InvalidArgument. </summary>
        public static ConversationErrorCode InvalidArgument { get; } = new ConversationErrorCode(InvalidArgumentValue);
        /// <summary> Unauthorized. </summary>
        public static ConversationErrorCode Unauthorized { get; } = new ConversationErrorCode(UnauthorizedValue);
        /// <summary> Forbidden. </summary>
        public static ConversationErrorCode Forbidden { get; } = new ConversationErrorCode(ForbiddenValue);
        /// <summary> NotFound. </summary>
        public static ConversationErrorCode NotFound { get; } = new ConversationErrorCode(NotFoundValue);
        /// <summary> ProjectNotFound. </summary>
        public static ConversationErrorCode ProjectNotFound { get; } = new ConversationErrorCode(ProjectNotFoundValue);
        /// <summary> OperationNotFound. </summary>
        public static ConversationErrorCode OperationNotFound { get; } = new ConversationErrorCode(OperationNotFoundValue);
        /// <summary> AzureCognitiveSearchNotFound. </summary>
        public static ConversationErrorCode AzureCognitiveSearchNotFound { get; } = new ConversationErrorCode(AzureCognitiveSearchNotFoundValue);
        /// <summary> AzureCognitiveSearchIndexNotFound. </summary>
        public static ConversationErrorCode AzureCognitiveSearchIndexNotFound { get; } = new ConversationErrorCode(AzureCognitiveSearchIndexNotFoundValue);
        /// <summary> TooManyRequests. </summary>
        public static ConversationErrorCode TooManyRequests { get; } = new ConversationErrorCode(TooManyRequestsValue);
        /// <summary> AzureCognitiveSearchThrottling. </summary>
        public static ConversationErrorCode AzureCognitiveSearchThrottling { get; } = new ConversationErrorCode(AzureCognitiveSearchThrottlingValue);
        /// <summary> AzureCognitiveSearchIndexLimitReached. </summary>
        public static ConversationErrorCode AzureCognitiveSearchIndexLimitReached { get; } = new ConversationErrorCode(AzureCognitiveSearchIndexLimitReachedValue);
        /// <summary> InternalServerError. </summary>
        public static ConversationErrorCode InternalServerError { get; } = new ConversationErrorCode(InternalServerErrorValue);
        /// <summary> ServiceUnavailable. </summary>
        public static ConversationErrorCode ServiceUnavailable { get; } = new ConversationErrorCode(ServiceUnavailableValue);
        /// <summary> Timeout. </summary>
        public static ConversationErrorCode Timeout { get; } = new ConversationErrorCode(TimeoutValue);
        /// <summary> QuotaExceeded. </summary>
        public static ConversationErrorCode QuotaExceeded { get; } = new ConversationErrorCode(QuotaExceededValue);
        /// <summary> Conflict. </summary>
        public static ConversationErrorCode Conflict { get; } = new ConversationErrorCode(ConflictValue);
        /// <summary> Warning. </summary>
        public static ConversationErrorCode Warning { get; } = new ConversationErrorCode(WarningValue);
        /// <summary> Determines if two <see cref="ConversationErrorCode"/> values are the same. </summary>
        public static bool operator ==(ConversationErrorCode left, ConversationErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConversationErrorCode"/> values are not the same. </summary>
        public static bool operator !=(ConversationErrorCode left, ConversationErrorCode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ConversationErrorCode"/>. </summary>
        public static implicit operator ConversationErrorCode(string value) => new ConversationErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConversationErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConversationErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
