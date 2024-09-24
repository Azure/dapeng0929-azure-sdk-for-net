// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Ingress type for the default NginxIngressController custom resource. </summary>
    public readonly partial struct NginxIngressControllerType : IEquatable<NginxIngressControllerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NginxIngressControllerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NginxIngressControllerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnnotationControlledValue = "AnnotationControlled";
        private const string ExternalValue = "External";
        private const string InternalValue = "Internal";
        private const string NoneValue = "None";

        /// <summary> The default NginxIngressController will be created. Users can edit the default NginxIngressController Custom Resource to configure load balancer annotations. </summary>
        public static NginxIngressControllerType AnnotationControlled { get; } = new NginxIngressControllerType(AnnotationControlledValue);
        /// <summary> The default NginxIngressController will be created and the operator will provision an external loadbalancer with it. Any annotation to make the default loadbalancer internal will be overwritten. </summary>
        public static NginxIngressControllerType External { get; } = new NginxIngressControllerType(ExternalValue);
        /// <summary> The default NginxIngressController will be created and the operator will provision an internal loadbalancer with it. Any annotation to make the default loadbalancer external will be overwritten. </summary>
        public static NginxIngressControllerType Internal { get; } = new NginxIngressControllerType(InternalValue);
        /// <summary> The default Ingress Controller will not be created. It will not be deleted by the system if it exists. Users should delete the default NginxIngressController Custom Resource manually if desired. </summary>
        public static NginxIngressControllerType None { get; } = new NginxIngressControllerType(NoneValue);
        /// <summary> Determines if two <see cref="NginxIngressControllerType"/> values are the same. </summary>
        public static bool operator ==(NginxIngressControllerType left, NginxIngressControllerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NginxIngressControllerType"/> values are not the same. </summary>
        public static bool operator !=(NginxIngressControllerType left, NginxIngressControllerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NginxIngressControllerType"/>. </summary>
        public static implicit operator NginxIngressControllerType(string value) => new NginxIngressControllerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NginxIngressControllerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NginxIngressControllerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
