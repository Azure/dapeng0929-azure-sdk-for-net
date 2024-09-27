// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The EventGridMQTTClientDisconnectionReason. </summary>
    public readonly partial struct EventGridMQTTClientDisconnectionReason : IEquatable<EventGridMQTTClientDisconnectionReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridMQTTClientDisconnectionReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridMQTTClientDisconnectionReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ClientAuthenticationErrorValue = "ClientAuthenticationError";
        private const string ClientAuthorizationErrorValue = "ClientAuthorizationError";
        private const string ClientErrorValue = "ClientError";
        private const string ClientInitiatedDisconnectValue = "ClientInitiatedDisconnect";
        private const string ConnectionLostValue = "ConnectionLost";
        private const string IpForbiddenValue = "IpForbidden";
        private const string QuotaExceededValue = "QuotaExceeded";
        private const string ServerErrorValue = "ServerError";
        private const string ServerInitiatedDisconnectValue = "ServerInitiatedDisconnect";
        private const string SessionOverflowValue = "SessionOverflow";
        private const string SessionTakenOverValue = "SessionTakenOver";

        /// <summary> ClientAuthenticationError. </summary>
        public static EventGridMQTTClientDisconnectionReason ClientAuthenticationError { get; } = new EventGridMQTTClientDisconnectionReason(ClientAuthenticationErrorValue);
        /// <summary> ClientAuthorizationError. </summary>
        public static EventGridMQTTClientDisconnectionReason ClientAuthorizationError { get; } = new EventGridMQTTClientDisconnectionReason(ClientAuthorizationErrorValue);
        /// <summary> ClientError. </summary>
        public static EventGridMQTTClientDisconnectionReason ClientError { get; } = new EventGridMQTTClientDisconnectionReason(ClientErrorValue);
        /// <summary> ClientInitiatedDisconnect. </summary>
        public static EventGridMQTTClientDisconnectionReason ClientInitiatedDisconnect { get; } = new EventGridMQTTClientDisconnectionReason(ClientInitiatedDisconnectValue);
        /// <summary> ConnectionLost. </summary>
        public static EventGridMQTTClientDisconnectionReason ConnectionLost { get; } = new EventGridMQTTClientDisconnectionReason(ConnectionLostValue);
        /// <summary> IpForbidden. </summary>
        public static EventGridMQTTClientDisconnectionReason IpForbidden { get; } = new EventGridMQTTClientDisconnectionReason(IpForbiddenValue);
        /// <summary> QuotaExceeded. </summary>
        public static EventGridMQTTClientDisconnectionReason QuotaExceeded { get; } = new EventGridMQTTClientDisconnectionReason(QuotaExceededValue);
        /// <summary> ServerError. </summary>
        public static EventGridMQTTClientDisconnectionReason ServerError { get; } = new EventGridMQTTClientDisconnectionReason(ServerErrorValue);
        /// <summary> ServerInitiatedDisconnect. </summary>
        public static EventGridMQTTClientDisconnectionReason ServerInitiatedDisconnect { get; } = new EventGridMQTTClientDisconnectionReason(ServerInitiatedDisconnectValue);
        /// <summary> SessionOverflow. </summary>
        public static EventGridMQTTClientDisconnectionReason SessionOverflow { get; } = new EventGridMQTTClientDisconnectionReason(SessionOverflowValue);
        /// <summary> SessionTakenOver. </summary>
        public static EventGridMQTTClientDisconnectionReason SessionTakenOver { get; } = new EventGridMQTTClientDisconnectionReason(SessionTakenOverValue);
        /// <summary> Determines if two <see cref="EventGridMQTTClientDisconnectionReason"/> values are the same. </summary>
        public static bool operator ==(EventGridMQTTClientDisconnectionReason left, EventGridMQTTClientDisconnectionReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridMQTTClientDisconnectionReason"/> values are not the same. </summary>
        public static bool operator !=(EventGridMQTTClientDisconnectionReason left, EventGridMQTTClientDisconnectionReason right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EventGridMQTTClientDisconnectionReason"/>. </summary>
        public static implicit operator EventGridMQTTClientDisconnectionReason(string value) => new EventGridMQTTClientDisconnectionReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridMQTTClientDisconnectionReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridMQTTClientDisconnectionReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
