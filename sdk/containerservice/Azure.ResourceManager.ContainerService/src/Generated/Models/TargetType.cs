// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The target type of a skip request. </summary>
    public readonly partial struct TargetType : IEquatable<TargetType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TargetType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TargetType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MemberValue = "Member";
        private const string GroupValue = "Group";
        private const string StageValue = "Stage";
        private const string AfterStageWaitValue = "AfterStageWait";

        /// <summary> Skip the update of a member. </summary>
        public static TargetType Member { get; } = new TargetType(MemberValue);
        /// <summary> Skip the update of a group. </summary>
        public static TargetType Group { get; } = new TargetType(GroupValue);
        /// <summary> Skip the update of an entire stage including the after stage wait. </summary>
        public static TargetType Stage { get; } = new TargetType(StageValue);
        /// <summary> Skip the update of the after stage wait of a certain stage. </summary>
        public static TargetType AfterStageWait { get; } = new TargetType(AfterStageWaitValue);
        /// <summary> Determines if two <see cref="TargetType"/> values are the same. </summary>
        public static bool operator ==(TargetType left, TargetType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TargetType"/> values are not the same. </summary>
        public static bool operator !=(TargetType left, TargetType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TargetType"/>. </summary>
        public static implicit operator TargetType(string value) => new TargetType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TargetType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TargetType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
