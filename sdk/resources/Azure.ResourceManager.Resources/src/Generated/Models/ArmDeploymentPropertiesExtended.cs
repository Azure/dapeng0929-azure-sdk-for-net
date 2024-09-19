// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment properties with additional details. </summary>
    public partial class ArmDeploymentPropertiesExtended
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

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentPropertiesExtended"/>. </summary>
        internal ArmDeploymentPropertiesExtended()
        {
            Providers = new ChangeTrackingList<ResourceProviderData>();
            Dependencies = new ChangeTrackingList<ArmDependency>();
            OutputResources = new ChangeTrackingList<SubResource>();
            ValidatedResources = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmDeploymentPropertiesExtended"/>. </summary>
        /// <param name="provisioningState"> Denotes the state of provisioning. </param>
        /// <param name="correlationId"> The correlation ID of the deployment. </param>
        /// <param name="timestamp"> The timestamp of the template deployment. </param>
        /// <param name="duration"> The duration of the template deployment. </param>
        /// <param name="outputs"> Key/value pairs that represent deployment output. </param>
        /// <param name="providers"> The list of resource providers needed for the deployment. </param>
        /// <param name="dependencies"> The list of deployment dependencies. </param>
        /// <param name="templateLink"> The URI referencing the template. </param>
        /// <param name="parameters"> Deployment parameters. </param>
        /// <param name="parametersLink"> The URI referencing the parameters. </param>
        /// <param name="mode"> The deployment mode. Possible values are Incremental and Complete. </param>
        /// <param name="debugSetting"> The debug setting of the deployment. </param>
        /// <param name="errorDeployment"> The deployment on error behavior. </param>
        /// <param name="templateHash"> The hash produced for the template. </param>
        /// <param name="outputResources"> Array of provisioned resources. </param>
        /// <param name="validatedResources"> Array of validated resources. </param>
        /// <param name="error"> The deployment error. </param>
        /// <param name="validationLevel"> The validation level of the deployment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmDeploymentPropertiesExtended(ResourcesProvisioningState? provisioningState, string correlationId, DateTimeOffset? timestamp, TimeSpan? duration, BinaryData outputs, IReadOnlyList<ResourceProviderData> providers, IReadOnlyList<ArmDependency> dependencies, ArmDeploymentTemplateLink templateLink, BinaryData parameters, ArmDeploymentParametersLink parametersLink, ArmDeploymentMode? mode, DebugSetting debugSetting, ErrorDeploymentExtended errorDeployment, string templateHash, IReadOnlyList<SubResource> outputResources, IReadOnlyList<SubResource> validatedResources, ResponseError error, ValidationLevel? validationLevel, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            CorrelationId = correlationId;
            Timestamp = timestamp;
            Duration = duration;
            Outputs = outputs;
            Providers = providers;
            Dependencies = dependencies;
            TemplateLink = templateLink;
            Parameters = parameters;
            ParametersLink = parametersLink;
            Mode = mode;
            DebugSetting = debugSetting;
            ErrorDeployment = errorDeployment;
            TemplateHash = templateHash;
            OutputResources = outputResources;
            ValidatedResources = validatedResources;
            Error = error;
            ValidationLevel = validationLevel;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Denotes the state of provisioning. </summary>
        [WirePath("provisioningState")]
        public ResourcesProvisioningState? ProvisioningState { get; }
        /// <summary> The correlation ID of the deployment. </summary>
        [WirePath("correlationId")]
        public string CorrelationId { get; }
        /// <summary> The timestamp of the template deployment. </summary>
        [WirePath("timestamp")]
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The duration of the template deployment. </summary>
        [WirePath("duration")]
        public TimeSpan? Duration { get; }
        /// <summary>
        /// Key/value pairs that represent deployment output.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("outputs")]
        public BinaryData Outputs { get; }
        /// <summary> The list of resource providers needed for the deployment. </summary>
        [WirePath("providers")]
        public IReadOnlyList<ResourceProviderData> Providers { get; }
        /// <summary> The list of deployment dependencies. </summary>
        [WirePath("dependencies")]
        public IReadOnlyList<ArmDependency> Dependencies { get; }
        /// <summary> The URI referencing the template. </summary>
        [WirePath("templateLink")]
        public ArmDeploymentTemplateLink TemplateLink { get; }
        /// <summary>
        /// Deployment parameters.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        [WirePath("parameters")]
        public BinaryData Parameters { get; }
        /// <summary> The URI referencing the parameters. </summary>
        [WirePath("parametersLink")]
        public ArmDeploymentParametersLink ParametersLink { get; }
        /// <summary> The deployment mode. Possible values are Incremental and Complete. </summary>
        [WirePath("mode")]
        public ArmDeploymentMode? Mode { get; }
        /// <summary> The debug setting of the deployment. </summary>
        internal DebugSetting DebugSetting { get; }

        /// <summary> The deployment on error behavior. </summary>
        [WirePath("onErrorDeployment")]
        public ErrorDeploymentExtended ErrorDeployment { get; }
        /// <summary> The hash produced for the template. </summary>
        [WirePath("templateHash")]
        public string TemplateHash { get; }
        /// <summary> Array of provisioned resources. </summary>
        [WirePath("outputResources")]
        public IReadOnlyList<SubResource> OutputResources { get; }
        /// <summary> Array of validated resources. </summary>
        [WirePath("validatedResources")]
        public IReadOnlyList<SubResource> ValidatedResources { get; }
        /// <summary> The deployment error. </summary>
        [WirePath("error")]
        public ResponseError Error { get; }
        /// <summary> The validation level of the deployment. </summary>
        [WirePath("validationLevel")]
        public ValidationLevel? ValidationLevel { get; }
    }
}
