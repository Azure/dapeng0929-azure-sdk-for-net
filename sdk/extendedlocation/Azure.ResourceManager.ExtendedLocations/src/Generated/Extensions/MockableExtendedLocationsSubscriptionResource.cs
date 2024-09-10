// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ExtendedLocations.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableExtendedLocationsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _customLocationClientDiagnostics;
        private CustomLocationsRestOperations _customLocationRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableExtendedLocationsSubscriptionResource"/> class for mocking. </summary>
        protected MockableExtendedLocationsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableExtendedLocationsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableExtendedLocationsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics CustomLocationClientDiagnostics => _customLocationClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ExtendedLocations", CustomLocationResource.ResourceType.Namespace, Diagnostics);
        private CustomLocationsRestOperations CustomLocationRestClient => _customLocationRestClient ??= new CustomLocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(CustomLocationResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets a list of Custom Locations in the specified subscription. The operation returns properties of each Custom Location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ExtendedLocation/customLocations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomLocations_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomLocationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomLocationResource> GetCustomLocationsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CustomLocationRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CustomLocationRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CustomLocationResource(Client, CustomLocationData.DeserializeCustomLocationData(e)), CustomLocationClientDiagnostics, Pipeline, "MockableExtendedLocationsSubscriptionResource.GetCustomLocations", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Custom Locations in the specified subscription. The operation returns properties of each Custom Location
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ExtendedLocation/customLocations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomLocations_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomLocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomLocationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomLocationResource> GetCustomLocations(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => CustomLocationRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => CustomLocationRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CustomLocationResource(Client, CustomLocationData.DeserializeCustomLocationData(e)), CustomLocationClientDiagnostics, Pipeline, "MockableExtendedLocationsSubscriptionResource.GetCustomLocations", "value", "nextLink", cancellationToken);
        }
    }
}
