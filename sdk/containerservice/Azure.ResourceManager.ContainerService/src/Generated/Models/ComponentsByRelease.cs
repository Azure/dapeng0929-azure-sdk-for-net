// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> components of given Kubernetes version. </summary>
    public partial class ComponentsByRelease
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

        /// <summary> Initializes a new instance of <see cref="ComponentsByRelease"/>. </summary>
        internal ComponentsByRelease()
        {
            Components = new ChangeTrackingList<Component>();
        }

        /// <summary> Initializes a new instance of <see cref="ComponentsByRelease"/>. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version (major.minor). </param>
        /// <param name="components"> components of current or upgraded Kubernetes version in the cluster. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentsByRelease(string kubernetesVersion, IReadOnlyList<Component> components, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KubernetesVersion = kubernetesVersion;
            Components = components;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Kubernetes version (major.minor). </summary>
        [WirePath("kubernetesVersion")]
        public string KubernetesVersion { get; }
        /// <summary> components of current or upgraded Kubernetes version in the cluster. </summary>
        [WirePath("components")]
        public IReadOnlyList<Component> Components { get; }
    }
}
