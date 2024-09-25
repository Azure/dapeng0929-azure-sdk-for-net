// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing the ScalingPlan data model.
    /// Represents a scaling plan definition.
    /// </summary>
    public partial class ScalingPlanData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="ScalingPlanData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="timeZone"> Timezone of the scaling plan. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="timeZone"/> is null. </exception>
        public ScalingPlanData(AzureLocation location, string timeZone) : base(location)
        {
            Argument.AssertNotNull(timeZone, nameof(timeZone));

            TimeZone = timeZone;
            Schedules = new ChangeTrackingList<ScalingSchedule>();
            HostPoolReferences = new ChangeTrackingList<ScalingHostPoolReference>();
        }

        /// <summary> Initializes a new instance of <see cref="ScalingPlanData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="objectId"> ObjectId of scaling plan. (internal use). </param>
        /// <param name="description"> Description of scaling plan. </param>
        /// <param name="friendlyName"> User friendly name of scaling plan. </param>
        /// <param name="timeZone"> Timezone of the scaling plan. </param>
        /// <param name="scalingHostPoolType"> HostPool type for desktop. </param>
        /// <param name="exclusionTag"> Exclusion tag for scaling plan. </param>
        /// <param name="schedules"> List of Pooled ScalingSchedule definitions. </param>
        /// <param name="hostPoolReferences"> List of ScalingHostPoolReference definitions. </param>
        /// <param name="managedBy"> The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource if it is removed from the template since it is managed by another resource. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. E.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="etag"> The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="sku"> The resource model definition representing SKU. </param>
        /// <param name="plan"> Plan for the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScalingPlanData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string objectId, string description, string friendlyName, string timeZone, ScalingHostPoolType? scalingHostPoolType, string exclusionTag, IList<ScalingSchedule> schedules, IList<ScalingHostPoolReference> hostPoolReferences, ResourceIdentifier managedBy, string kind, ETag? etag, ManagedServiceIdentity identity, DesktopVirtualizationSku sku, ArmPlan plan, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ObjectId = objectId;
            Description = description;
            FriendlyName = friendlyName;
            TimeZone = timeZone;
            ScalingHostPoolType = scalingHostPoolType;
            ExclusionTag = exclusionTag;
            Schedules = schedules;
            HostPoolReferences = hostPoolReferences;
            ManagedBy = managedBy;
            Kind = kind;
            ETag = etag;
            Identity = identity;
            Sku = sku;
            Plan = plan;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScalingPlanData"/> for deserialization. </summary>
        internal ScalingPlanData()
        {
        }

        /// <summary> ObjectId of scaling plan. (internal use). </summary>
        [WirePath("properties.objectId")]
        public string ObjectId { get; }
        /// <summary> Description of scaling plan. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> User friendly name of scaling plan. </summary>
        [WirePath("properties.friendlyName")]
        public string FriendlyName { get; set; }
        /// <summary> Timezone of the scaling plan. </summary>
        [WirePath("properties.timeZone")]
        public string TimeZone { get; set; }
        /// <summary> HostPool type for desktop. </summary>
        [WirePath("properties.hostPoolType")]
        public ScalingHostPoolType? ScalingHostPoolType { get; set; }
        /// <summary> Exclusion tag for scaling plan. </summary>
        [WirePath("properties.exclusionTag")]
        public string ExclusionTag { get; set; }
        /// <summary> List of Pooled ScalingSchedule definitions. </summary>
        [WirePath("properties.schedules")]
        public IList<ScalingSchedule> Schedules { get; }
        /// <summary> List of ScalingHostPoolReference definitions. </summary>
        [WirePath("properties.hostPoolReferences")]
        public IList<ScalingHostPoolReference> HostPoolReferences { get; }
        /// <summary> The fully qualified resource ID of the resource that manages this resource. Indicates if this resource is managed by another Azure resource. If this is present, complete mode deployment will not delete the resource if it is removed from the template since it is managed by another resource. </summary>
        [WirePath("managedBy")]
        public ResourceIdentifier ManagedBy { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. E.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
        /// <summary> The etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields. </summary>
        [WirePath("etag")]
        public ETag? ETag { get; }
        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The resource model definition representing SKU. </summary>
        [WirePath("sku")]
        public DesktopVirtualizationSku Sku { get; set; }
        /// <summary> Plan for the resource. </summary>
        [WirePath("plan")]
        public ArmPlan Plan { get; set; }
    }
}
