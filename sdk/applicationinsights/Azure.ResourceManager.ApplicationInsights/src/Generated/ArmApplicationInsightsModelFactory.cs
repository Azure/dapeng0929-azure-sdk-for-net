// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmApplicationInsightsModelFactory
    {
        /// <summary> Initializes a new instance of ApplicationInsightsComponentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of application that this component refers to, used to customize UI. This value is a freeform string, values should typically be one of the following: web, ios, other, store, java, phone. </param>
        /// <param name="etag"> Resource etag. </param>
        /// <param name="applicationId"> The unique ID of your application. This field mirrors the 'Name' field and cannot be changed. </param>
        /// <param name="appId"> Application Insights Unique ID for your Application. </param>
        /// <param name="namePropertiesName"> Application name. </param>
        /// <param name="applicationType"> Type of application being monitored. </param>
        /// <param name="flowType"> Used by the Application Insights system to determine what kind of flow this component was created by. This is to be set to 'Bluefield' when creating/updating a component via the REST API. </param>
        /// <param name="requestSource"> Describes what tool created this Application Insights component. Customers using this API should set this to the default 'rest'. </param>
        /// <param name="instrumentationKey"> Application Insights Instrumentation key. A read-only value that applications can use to identify the destination for all telemetry sent to Azure Application Insights. This value will be supplied upon construction of each new Application Insights component. </param>
        /// <param name="createdOn"> Creation Date for the Application Insights component, in ISO 8601 format. </param>
        /// <param name="tenantId"> Azure Tenant Id. </param>
        /// <param name="hockeyAppId"> The unique application ID created when a new application is added to HockeyApp, used for communications with HockeyApp. </param>
        /// <param name="hockeyAppToken"> Token used to authenticate communications with between Application Insights and HockeyApp. </param>
        /// <param name="provisioningState"> Current state of this component: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed. </param>
        /// <param name="samplingPercentage"> Percentage of the data produced by the application being monitored that is being sampled for Application Insights telemetry. </param>
        /// <param name="connectionString"> Application Insights component connection string. </param>
        /// <param name="retentionInDays"> Retention period in days. </param>
        /// <param name="isDisableIPMasking"> Disable IP masking. </param>
        /// <param name="isImmediatePurgeDataOn30Days"> Purge data immediately after 30 days. </param>
        /// <param name="workspaceResourceId"> Resource Id of the log analytics workspace which the data will be ingested to. This property is required to create an application with this API version. Applications from older versions will not have this property. </param>
        /// <param name="laMigrationOn"> The date which the component got migrated to LA, in ISO 8601 format. </param>
        /// <param name="privateLinkScopedResources"> List of linked private link scope resources. </param>
        /// <param name="publicNetworkAccessForIngestion"> The network access type for accessing Application Insights ingestion. </param>
        /// <param name="publicNetworkAccessForQuery"> The network access type for accessing Application Insights query. </param>
        /// <param name="ingestionMode"> Indicates the flow of the ingestion. </param>
        /// <param name="isDisableLocalAuth"> Disable Non-AAD based Auth. </param>
        /// <param name="isForceCustomerStorageForProfiler"> Force users to create their own storage account for profiler and debugger. </param>
        /// <returns> A new <see cref="ApplicationInsights.ApplicationInsightsComponentData"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentData ApplicationInsightsComponentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string kind = null, ETag? etag = null, string applicationId = null, string appId = null, string namePropertiesName = null, ApplicationType? applicationType = null, FlowType? flowType = null, RequestSource? requestSource = null, string instrumentationKey = null, DateTimeOffset? createdOn = null, Guid? tenantId = null, string hockeyAppId = null, string hockeyAppToken = null, string provisioningState = null, double? samplingPercentage = null, string connectionString = null, int? retentionInDays = null, bool? isDisableIPMasking = null, bool? isImmediatePurgeDataOn30Days = null, string workspaceResourceId = null, DateTimeOffset? laMigrationOn = null, IEnumerable<PrivateLinkScopedResourceContent> privateLinkScopedResources = null, PublicNetworkAccessType? publicNetworkAccessForIngestion = null, PublicNetworkAccessType? publicNetworkAccessForQuery = null, IngestionMode? ingestionMode = null, bool? isDisableLocalAuth = null, bool? isForceCustomerStorageForProfiler = null)
        {
            tags ??= new Dictionary<string, string>();
            privateLinkScopedResources ??= new List<PrivateLinkScopedResourceContent>();

            return new ApplicationInsightsComponentData(id, name, resourceType, systemData, tags, location, kind, etag, applicationId, appId, namePropertiesName, applicationType, flowType, requestSource, instrumentationKey, createdOn, tenantId, hockeyAppId, hockeyAppToken, provisioningState, samplingPercentage, connectionString, retentionInDays, isDisableIPMasking, isImmediatePurgeDataOn30Days, workspaceResourceId, laMigrationOn, privateLinkScopedResources?.ToList(), publicNetworkAccessForIngestion, publicNetworkAccessForQuery, ingestionMode, isDisableLocalAuth, isForceCustomerStorageForProfiler);
        }

        /// <summary> Initializes a new instance of PrivateLinkScopedResourceContent. </summary>
        /// <param name="resourceId"> The full resource Id of the private link scope resource. </param>
        /// <param name="scopeId"> The private link scope unique Identifier. </param>
        /// <returns> A new <see cref="Models.PrivateLinkScopedResourceContent"/> instance for mocking. </returns>
        public static PrivateLinkScopedResourceContent PrivateLinkScopedResourceContent(string resourceId = null, string scopeId = null)
        {
            return new PrivateLinkScopedResourceContent(resourceId, scopeId);
        }

        /// <summary> Initializes a new instance of ComponentPurgeResponse. </summary>
        /// <param name="operationId"> Id to use when querying for status for a particular purge operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        /// <returns> A new <see cref="Models.ComponentPurgeResponse"/> instance for mocking. </returns>
        public static ComponentPurgeResponse ComponentPurgeResponse(string operationId = null)
        {
            if (operationId == null)
            {
                throw new ArgumentNullException(nameof(operationId));
            }

            return new ComponentPurgeResponse(operationId);
        }

        /// <summary> Initializes a new instance of ComponentPurgeStatusResponse. </summary>
        /// <param name="status"> Status of the operation represented by the requested Id. </param>
        /// <returns> A new <see cref="Models.ComponentPurgeStatusResponse"/> instance for mocking. </returns>
        public static ComponentPurgeStatusResponse ComponentPurgeStatusResponse(PurgeState status = default)
        {
            return new ComponentPurgeStatusResponse(status);
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentAPIKey. </summary>
        /// <param name="id"> The unique ID of the API key inside an Application Insights component. It is auto generated when the API key is created. </param>
        /// <param name="apiKey"> The API key value. It will be only return once when the API Key was created. </param>
        /// <param name="createdDate"> The create date of this API key. </param>
        /// <param name="name"> The name of the API key. </param>
        /// <param name="linkedReadProperties"> The read access rights of this API Key. </param>
        /// <param name="linkedWriteProperties"> The write access rights of this API Key. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentAPIKey"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentAPIKey ApplicationInsightsComponentAPIKey(string id = null, string apiKey = null, string createdDate = null, string name = null, IEnumerable<string> linkedReadProperties = null, IEnumerable<string> linkedWriteProperties = null)
        {
            linkedReadProperties ??= new List<string>();
            linkedWriteProperties ??= new List<string>();

            return new ApplicationInsightsComponentAPIKey(id, apiKey, createdDate, name, linkedReadProperties?.ToList(), linkedWriteProperties?.ToList());
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentExportConfiguration. </summary>
        /// <param name="exportId"> The unique ID of the export configuration inside an Application Insights component. It is auto generated when the Continuous Export configuration is created. </param>
        /// <param name="instrumentationKey"> The instrumentation key of the Application Insights component. </param>
        /// <param name="recordTypes"> This comma separated list of document types that will be exported. The possible values include 'Requests', 'Event', 'Exceptions', 'Metrics', 'PageViews', 'PageViewPerformance', 'Rdd', 'PerformanceCounters', 'Availability', 'Messages'. </param>
        /// <param name="applicationName"> The name of the Application Insights component. </param>
        /// <param name="subscriptionId"> The subscription of the Application Insights component. </param>
        /// <param name="resourceGroup"> The resource group of the Application Insights component. </param>
        /// <param name="destinationStorageSubscriptionId"> The destination storage account subscription ID. </param>
        /// <param name="destinationStorageLocationId"> The destination account location ID. </param>
        /// <param name="destinationAccountId"> The name of destination account. </param>
        /// <param name="destinationType"> The destination type. </param>
        /// <param name="isUserEnabled"> This will be 'true' if the Continuous Export configuration is enabled, otherwise it will be 'false'. </param>
        /// <param name="lastUserUpdate"> Last time the Continuous Export configuration was updated. </param>
        /// <param name="notificationQueueEnabled"> Deprecated. </param>
        /// <param name="exportStatus"> This indicates current Continuous Export configuration status. The possible values are 'Preparing', 'Success', 'Failure'. </param>
        /// <param name="lastSuccessTime"> The last time data was successfully delivered to the destination storage container for this Continuous Export configuration. </param>
        /// <param name="lastGapTime"> The last time the Continuous Export configuration started failing. </param>
        /// <param name="permanentErrorReason"> This is the reason the Continuous Export configuration started failing. It can be 'AzureStorageNotFound' or 'AzureStorageAccessDenied'. </param>
        /// <param name="storageName"> The name of the destination storage account. </param>
        /// <param name="containerName"> The name of the destination storage container. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentExportConfiguration"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentExportConfiguration ApplicationInsightsComponentExportConfiguration(string exportId = null, string instrumentationKey = null, string recordTypes = null, string applicationName = null, string subscriptionId = null, string resourceGroup = null, string destinationStorageSubscriptionId = null, string destinationStorageLocationId = null, string destinationAccountId = null, string destinationType = null, string isUserEnabled = null, string lastUserUpdate = null, string notificationQueueEnabled = null, string exportStatus = null, string lastSuccessTime = null, string lastGapTime = null, string permanentErrorReason = null, string storageName = null, string containerName = null)
        {
            return new ApplicationInsightsComponentExportConfiguration(exportId, instrumentationKey, recordTypes, applicationName, subscriptionId, resourceGroup, destinationStorageSubscriptionId, destinationStorageLocationId, destinationAccountId, destinationType, isUserEnabled, lastUserUpdate, notificationQueueEnabled, exportStatus, lastSuccessTime, lastGapTime, permanentErrorReason, storageName, containerName);
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentDataVolumeCap. </summary>
        /// <param name="cap"> Daily data volume cap in GB. </param>
        /// <param name="resetTime"> Daily data volume cap UTC reset hour. </param>
        /// <param name="warningThreshold"> Reserved, not used for now. </param>
        /// <param name="isStopSendNotificationWhenHitThreshold"> Reserved, not used for now. </param>
        /// <param name="isStopSendNotificationWhenHitCap"> Do not send a notification email when the daily data volume cap is met. </param>
        /// <param name="maxHistoryCap"> Maximum daily data volume cap that the user can set for this component. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentDataVolumeCap"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentDataVolumeCap ApplicationInsightsComponentDataVolumeCap(float? cap = null, int? resetTime = null, int? warningThreshold = null, bool? isStopSendNotificationWhenHitThreshold = null, bool? isStopSendNotificationWhenHitCap = null, float? maxHistoryCap = null)
        {
            return new ApplicationInsightsComponentDataVolumeCap(cap, resetTime, warningThreshold, isStopSendNotificationWhenHitThreshold, isStopSendNotificationWhenHitCap, maxHistoryCap);
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentQuotaStatus. </summary>
        /// <param name="appId"> The Application ID for the Application Insights component. </param>
        /// <param name="shouldBeThrottled"> The daily data volume cap is met, and data ingestion will be stopped. </param>
        /// <param name="expirationTime"> Date and time when the daily data volume cap will be reset, and data ingestion will resume. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentQuotaStatus"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentQuotaStatus ApplicationInsightsComponentQuotaStatus(string appId = null, bool? shouldBeThrottled = null, string expirationTime = null)
        {
            return new ApplicationInsightsComponentQuotaStatus(appId, shouldBeThrottled, expirationTime);
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentFeatureCapabilities. </summary>
        /// <param name="supportExportData"> Whether allow to use continuous export feature. </param>
        /// <param name="burstThrottlePolicy"> Reserved, not used now. </param>
        /// <param name="metadataClass"> Reserved, not used now. </param>
        /// <param name="liveStreamMetrics"> Reserved, not used now. </param>
        /// <param name="applicationMap"> Reserved, not used now. </param>
        /// <param name="workItemIntegration"> Whether allow to use work item integration feature. </param>
        /// <param name="powerBIIntegration"> Reserved, not used now. </param>
        /// <param name="openSchema"> Reserved, not used now. </param>
        /// <param name="proactiveDetection"> Reserved, not used now. </param>
        /// <param name="analyticsIntegration"> Reserved, not used now. </param>
        /// <param name="multipleStepWebTest"> Whether allow to use multiple steps web test feature. </param>
        /// <param name="apiAccessLevel"> Reserved, not used now. </param>
        /// <param name="trackingType"> The application insights component used tracking type. </param>
        /// <param name="dailyCap"> Daily data volume cap in GB. </param>
        /// <param name="dailyCapResetTime"> Daily data volume cap UTC reset hour. </param>
        /// <param name="throttleRate"> Reserved, not used now. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentFeatureCapabilities"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentFeatureCapabilities ApplicationInsightsComponentFeatureCapabilities(bool? supportExportData = null, string burstThrottlePolicy = null, string metadataClass = null, bool? liveStreamMetrics = null, bool? applicationMap = null, bool? workItemIntegration = null, bool? powerBIIntegration = null, bool? openSchema = null, bool? proactiveDetection = null, bool? analyticsIntegration = null, bool? multipleStepWebTest = null, string apiAccessLevel = null, string trackingType = null, float? dailyCap = null, float? dailyCapResetTime = null, float? throttleRate = null)
        {
            return new ApplicationInsightsComponentFeatureCapabilities(supportExportData, burstThrottlePolicy, metadataClass, liveStreamMetrics, applicationMap, workItemIntegration, powerBIIntegration, openSchema, proactiveDetection, analyticsIntegration, multipleStepWebTest, apiAccessLevel, trackingType, dailyCap, dailyCapResetTime, throttleRate);
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentAvailableFeatures. </summary>
        /// <param name="result"> A list of Application Insights component feature. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentAvailableFeatures"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentAvailableFeatures ApplicationInsightsComponentAvailableFeatures(IEnumerable<ApplicationInsightsComponentFeature> result = null)
        {
            result ??= new List<ApplicationInsightsComponentFeature>();

            return new ApplicationInsightsComponentAvailableFeatures(result?.ToList());
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentFeature. </summary>
        /// <param name="featureName"> The pricing feature name. </param>
        /// <param name="meterId"> The meter id used for the feature. </param>
        /// <param name="meterRateFrequency"> The meter rate for the feature's meter. </param>
        /// <param name="resourceId"> Reserved, not used now. </param>
        /// <param name="isHidden"> Reserved, not used now. </param>
        /// <param name="capabilities"> A list of Application Insights component feature capability. </param>
        /// <param name="title"> Display name of the feature. </param>
        /// <param name="isMainFeature"> Whether can apply addon feature on to it. </param>
        /// <param name="supportedAddonFeatures"> The add on features on main feature. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentFeature"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentFeature ApplicationInsightsComponentFeature(string featureName = null, string meterId = null, string meterRateFrequency = null, string resourceId = null, bool? isHidden = null, IEnumerable<ApplicationInsightsComponentFeatureCapability> capabilities = null, string title = null, bool? isMainFeature = null, string supportedAddonFeatures = null)
        {
            capabilities ??= new List<ApplicationInsightsComponentFeatureCapability>();

            return new ApplicationInsightsComponentFeature(featureName, meterId, meterRateFrequency, resourceId, isHidden, capabilities?.ToList(), title, isMainFeature, supportedAddonFeatures);
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentFeatureCapability. </summary>
        /// <param name="name"> The name of the capability. </param>
        /// <param name="description"> The description of the capability. </param>
        /// <param name="value"> The value of the capability. </param>
        /// <param name="unit"> The unit of the capability. </param>
        /// <param name="meterId"> The meter used for the capability. </param>
        /// <param name="meterRateFrequency"> The meter rate of the meter. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentFeatureCapability"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentFeatureCapability ApplicationInsightsComponentFeatureCapability(string name = null, string description = null, string value = null, string unit = null, string meterId = null, string meterRateFrequency = null)
        {
            return new ApplicationInsightsComponentFeatureCapability(name, description, value, unit, meterId, meterRateFrequency);
        }

        /// <summary> Initializes a new instance of WorkItemConfiguration. </summary>
        /// <param name="connectorId"> Connector identifier where work item is created. </param>
        /// <param name="configDisplayName"> Configuration friendly name. </param>
        /// <param name="isDefault"> Boolean value indicating whether configuration is default. </param>
        /// <param name="id"> Unique Id for work item. </param>
        /// <param name="configProperties"> Serialized JSON object for detailed properties. </param>
        /// <returns> A new <see cref="Models.WorkItemConfiguration"/> instance for mocking. </returns>
        public static WorkItemConfiguration WorkItemConfiguration(string connectorId = null, string configDisplayName = null, bool? isDefault = null, string id = null, string configProperties = null)
        {
            return new WorkItemConfiguration(connectorId, configDisplayName, isDefault, id, configProperties);
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentFavorite. </summary>
        /// <param name="name"> The user-defined name of the favorite. </param>
        /// <param name="config"> Configuration of this particular favorite, which are driven by the Azure portal UX. Configuration data is a string containing valid JSON. </param>
        /// <param name="version"> This instance's version of the data model. This can change as new features are added that can be marked favorite. Current examples include MetricsExplorer (ME) and Search. </param>
        /// <param name="favoriteId"> Internally assigned unique id of the favorite definition. </param>
        /// <param name="favoriteType"> Enum indicating if this favorite definition is owned by a specific user or is shared between all users with access to the Application Insights component. </param>
        /// <param name="sourceType"> The source of the favorite definition. </param>
        /// <param name="timeModified"> Date and time in UTC of the last modification that was made to this favorite definition. </param>
        /// <param name="tags"> A list of 0 or more tags that are associated with this favorite definition. </param>
        /// <param name="category"> Favorite category, as defined by the user at creation time. </param>
        /// <param name="isGeneratedFromTemplate"> Flag denoting wether or not this favorite was generated from a template. </param>
        /// <param name="userId"> Unique user id of the specific user that owns this favorite. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentFavorite"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentFavorite ApplicationInsightsComponentFavorite(string name = null, string config = null, string version = null, string favoriteId = null, FavoriteType? favoriteType = null, string sourceType = null, string timeModified = null, IEnumerable<string> tags = null, string category = null, bool? isGeneratedFromTemplate = null, string userId = null)
        {
            tags ??= new List<string>();

            return new ApplicationInsightsComponentFavorite(name, config, version, favoriteId, favoriteType, sourceType, timeModified, tags?.ToList(), category, isGeneratedFromTemplate, userId);
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentWebTestLocation. </summary>
        /// <param name="displayName"> The display name of the web test location. </param>
        /// <param name="tag"> Internally defined geographic location tag. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentWebTestLocation"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentWebTestLocation ApplicationInsightsComponentWebTestLocation(string displayName = null, string tag = null)
        {
            return new ApplicationInsightsComponentWebTestLocation(displayName, tag);
        }

        /// <summary> Initializes a new instance of WebTestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of WebTest that this web test watches. Choices are ping, multistep and standard. </param>
        /// <param name="syntheticMonitorId"> Unique ID of this WebTest. This is typically the same value as the Name field. </param>
        /// <param name="webTestName"> User defined name if this WebTest. </param>
        /// <param name="description"> User defined description for this WebTest. </param>
        /// <param name="isEnabled"> Is the test actively being monitored. </param>
        /// <param name="frequencyInSeconds"> Interval in seconds between test runs for this WebTest. Default value is 300. </param>
        /// <param name="timeoutInSeconds"> Seconds until this WebTest will timeout and fail. Default value is 30. </param>
        /// <param name="webTestKind"> The kind of web test this is, valid choices are ping, multistep and standard. </param>
        /// <param name="isRetryEnabled"> Allow for retries should this WebTest fail. </param>
        /// <param name="locations"> A list of where to physically run the tests from to give global coverage for accessibility of your application. </param>
        /// <param name="webTest"> An XML configuration specification for a WebTest. </param>
        /// <param name="provisioningState"> Current state of this component, whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Succeeded, Deploying, Canceled, and Failed. </param>
        /// <param name="request"> The collection of request properties. </param>
        /// <param name="validationRules"> The collection of validation rule properties. </param>
        /// <returns> A new <see cref="ApplicationInsights.WebTestData"/> instance for mocking. </returns>
        public static WebTestData WebTestData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, WebTestKind? kind = null, string syntheticMonitorId = null, string webTestName = null, string description = null, bool? isEnabled = null, int? frequencyInSeconds = null, int? timeoutInSeconds = null, WebTestKind? webTestKind = null, bool? isRetryEnabled = null, IEnumerable<WebTestGeolocation> locations = null, string webTest = null, string provisioningState = null, WebTestPropertiesRequest request = null, WebTestPropertiesValidationRules validationRules = null)
        {
            tags ??= new Dictionary<string, string>();
            locations ??= new List<WebTestGeolocation>();

            return new WebTestData(id, name, resourceType, systemData, tags, location, kind, syntheticMonitorId, webTestName, description, isEnabled, frequencyInSeconds, timeoutInSeconds, webTestKind, isRetryEnabled, locations?.ToList(), webTest != null ? new WebTestPropertiesConfiguration(webTest) : null, provisioningState, request, validationRules);
        }

        /// <summary> Initializes a new instance of ApplicationInsightsComponentAnalyticsItem. </summary>
        /// <param name="id"> Internally assigned unique id of the item definition. </param>
        /// <param name="name"> The user-defined name of the item. </param>
        /// <param name="content"> The content of this item. </param>
        /// <param name="version"> This instance's version of the data model. This can change as new features are added. </param>
        /// <param name="scope"> Enum indicating if this item definition is owned by a specific user or is shared between all users with access to the Application Insights component. </param>
        /// <param name="itemType"> Enum indicating the type of the Analytics item. </param>
        /// <param name="timeCreated"> Date and time in UTC when this item was created. </param>
        /// <param name="timeModified"> Date and time in UTC of the last modification that was made to this item. </param>
        /// <param name="applicationInsightsComponentAnalyticsItemFunctionAlias"> A set of properties that can be defined in the context of a specific item type. Each type may have its own properties. </param>
        /// <returns> A new <see cref="Models.ApplicationInsightsComponentAnalyticsItem"/> instance for mocking. </returns>
        public static ApplicationInsightsComponentAnalyticsItem ApplicationInsightsComponentAnalyticsItem(string id = null, string name = null, string content = null, string version = null, ItemScope? scope = null, ItemType? itemType = null, string timeCreated = null, string timeModified = null, string applicationInsightsComponentAnalyticsItemFunctionAlias = null)
        {
            return new ApplicationInsightsComponentAnalyticsItem(id, name, content, version, scope, itemType, timeCreated, timeModified, applicationInsightsComponentAnalyticsItemFunctionAlias != null ? new ApplicationInsightsComponentAnalyticsItemProperties(applicationInsightsComponentAnalyticsItemFunctionAlias) : null);
        }

        /// <summary> Initializes a new instance of WorkbookTemplateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="priority"> Priority of the template. Determines which template to open when a workbook gallery is opened in viewer mode. </param>
        /// <param name="author"> Information about the author of the workbook template. </param>
        /// <param name="templateData"> Valid JSON object containing workbook template payload. </param>
        /// <param name="galleries"> Workbook galleries supported by the template. </param>
        /// <param name="localizedGalleries"> Key value pair of localized gallery. Each key is the locale code of languages supported by the Azure portal. </param>
        /// <returns> A new <see cref="ApplicationInsights.WorkbookTemplateData"/> instance for mocking. </returns>
        public static WorkbookTemplateData WorkbookTemplateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, int? priority = null, string author = null, BinaryData templateData = null, IEnumerable<WorkbookTemplateGallery> galleries = null, IDictionary<string, IList<WorkbookTemplateLocalizedGallery>> localizedGalleries = null)
        {
            tags ??= new Dictionary<string, string>();
            galleries ??= new List<WorkbookTemplateGallery>();
            localizedGalleries ??= new Dictionary<string, IList<WorkbookTemplateLocalizedGallery>>();

            return new WorkbookTemplateData(id, name, resourceType, systemData, tags, location, priority, author, templateData, galleries?.ToList(), localizedGalleries);
        }

        /// <summary> Initializes a new instance of WorkbookData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="displayName"> The user-defined name (display name) of the workbook. </param>
        /// <param name="serializedData"> Configuration of this particular workbook. Configuration data is a string containing valid JSON. </param>
        /// <param name="version"> Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData. </param>
        /// <param name="modifiedOn"> Date and time in UTC of the last modification that was made to this workbook definition. </param>
        /// <param name="category"> Workbook category, as defined by the user at creation time. </param>
        /// <param name="userId"> Unique user id of the specific user that owns this workbook. </param>
        /// <param name="sourceId"> ResourceId for a source resource. </param>
        /// <param name="storageUri"> The resourceId to the storage account when bring your own storage is used. </param>
        /// <param name="description"> The description of the workbook. </param>
        /// <param name="revision"> The unique revision id for this workbook definition. </param>
        /// <param name="identity"> Identity used for BYOS. </param>
        /// <param name="kind"> The kind of workbook. Only valid value is shared. </param>
        /// <param name="etag"> Resource etag. </param>
        /// <returns> A new <see cref="ApplicationInsights.WorkbookData"/> instance for mocking. </returns>
        public static WorkbookData WorkbookData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string displayName = null, string serializedData = null, string version = null, DateTimeOffset? modifiedOn = null, string category = null, string userId = null, string sourceId = null, Uri storageUri = null, string description = null, string revision = null, ManagedServiceIdentity identity = null, WorkbookSharedTypeKind? kind = null, ETag? etag = null)
        {
            tags ??= new Dictionary<string, string>();

            return new WorkbookData(id, name, resourceType, systemData, tags, location, displayName, serializedData, version, modifiedOn, category, userId, sourceId, storageUri, description, revision, identity, kind, etag);
        }

        /// <summary> Initializes a new instance of LiveTokenResponse. </summary>
        /// <param name="liveToken"> JWT token for accessing live metrics stream data. </param>
        /// <returns> A new <see cref="Models.LiveTokenResponse"/> instance for mocking. </returns>
        public static LiveTokenResponse LiveTokenResponse(string liveToken = null)
        {
            return new LiveTokenResponse(liveToken);
        }

        /// <summary> Initializes a new instance of ComponentLinkedStorageAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="linkedStorageAccount"> Linked storage account resource ID. </param>
        /// <returns> A new <see cref="ApplicationInsights.ComponentLinkedStorageAccountData"/> instance for mocking. </returns>
        public static ComponentLinkedStorageAccountData ComponentLinkedStorageAccountData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string linkedStorageAccount = null)
        {
            return new ComponentLinkedStorageAccountData(id, name, resourceType, systemData, linkedStorageAccount);
        }
    }
}
