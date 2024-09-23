// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // Get available delegations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableDelegations_GetAvailableDelegations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/AvailableDelegationsSubscriptionGet.json
            // this example is just showing the usage of "AvailableDelegations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westcentralus");
            await foreach (AvailableDelegation item in subscriptionResource.GetAvailableDelegationsAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get available service aliases
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableServiceAliases_GetAvailableServiceAliases()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/AvailableServiceAliasesList.json
            // this example is just showing the usage of "AvailableServiceAliases_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westcentralus");
            await foreach (AvailableServiceAlias item in subscriptionResource.GetAvailableServiceAliasesAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List all Azure Firewall FQDN Tags for a given subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAzureFirewallFqdnTags_ListAllAzureFirewallFQDNTagsForAGivenSubscription()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/AzureFirewallFqdnTagsListBySubscription.json
            // this example is just showing the usage of "AzureFirewallFqdnTags_ListAll" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (AzureFirewallFqdnTag item in subscriptionResource.GetAzureFirewallFqdnTagsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // EndpointServicesList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableEndpointServices_EndpointServicesList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/EndpointServicesList.json
            // this example is just showing the usage of "AvailableEndpointServices_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westus");
            await foreach (EndpointServiceResult item in subscriptionResource.GetAvailableEndpointServicesAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List ExpressRoute providers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetExpressRouteServiceProviders_ListExpressRouteProviders()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteProviderList.json
            // this example is just showing the usage of "ExpressRouteServiceProviders_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ExpressRouteServiceProvider item in subscriptionResource.GetExpressRouteServiceProvidersAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get available PrivateEndpoint types
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailablePrivateEndpointTypes_GetAvailablePrivateEndpointTypes()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/AvailablePrivateEndpointTypesGet.json
            // this example is just showing the usage of "AvailablePrivateEndpointTypes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("regionName");
            await foreach (AvailablePrivateEndpointType item in subscriptionResource.GetAvailablePrivateEndpointTypesAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Check private link service visibility
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckPrivateLinkServiceVisibilityPrivateLinkService_CheckPrivateLinkServiceVisibility()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/CheckPrivateLinkServiceVisibility.json
            // this example is just showing the usage of "PrivateLinkServices_CheckPrivateLinkServiceVisibility" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westus");
            CheckPrivateLinkServiceVisibilityRequest checkPrivateLinkServiceVisibilityRequest = new CheckPrivateLinkServiceVisibilityRequest()
            {
                PrivateLinkServiceAlias = "mypls.00000000-0000-0000-0000-000000000000.azure.privatelinkservice",
            };
            ArmOperation<PrivateLinkServiceVisibility> lro = await subscriptionResource.CheckPrivateLinkServiceVisibilityPrivateLinkServiceAsync(WaitUntil.Completed, location, checkPrivateLinkServiceVisibilityRequest);
            PrivateLinkServiceVisibility result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get list of private link service id that can be linked to a private end point with auto approved
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAutoApprovedPrivateLinkServicesPrivateLinkServices_GetListOfPrivateLinkServiceIdThatCanBeLinkedToAPrivateEndPointWithAutoApproved()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/AutoApprovedPrivateLinkServicesGet.json
            // this example is just showing the usage of "PrivateLinkServices_ListAutoApprovedPrivateLinkServices" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("regionName");
            await foreach (AutoApprovedPrivateLinkService item in subscriptionResource.GetAutoApprovedPrivateLinkServicesPrivateLinkServicesAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ServiceCommunityList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBgpServiceCommunities_ServiceCommunityList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ServiceCommunityList.json
            // this example is just showing the usage of "BgpServiceCommunities_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (BgpServiceCommunity item in subscriptionResource.GetBgpServiceCommunitiesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get list of service tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetServiceTag_GetListOfServiceTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ServiceTagsList.json
            // this example is just showing the usage of "ServiceTags_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subId";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("westcentralus");
            ServiceTagsListResult result = await subscriptionResource.GetServiceTagAsync(location);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get list of service tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAllServiceTagInformation_GetListOfServiceTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ServiceTagInformationListResult.json
            // this example is just showing the usage of "ServiceTagInformation_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westeurope");
            await foreach (ServiceTagInformation item in subscriptionResource.GetAllServiceTagInformationAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get list of service tags with no address prefixes
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAllServiceTagInformation_GetListOfServiceTagsWithNoAddressPrefixes()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ServiceTagInformationListResultWithNoAddressPrefixes.json
            // this example is just showing the usage of "ServiceTagInformation_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westeurope");
            bool? noAddressPrefixes = true;
            await foreach (ServiceTagInformation item in subscriptionResource.GetAllServiceTagInformationAsync(location, noAddressPrefixes: noAddressPrefixes))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get list of service tags with tag name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAllServiceTagInformation_GetListOfServiceTagsWithTagName()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ServiceTagInformationListResultWithTagname.json
            // this example is just showing the usage of "ServiceTagInformation_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westeurope");
            string tagName = "ApiManagement";
            await foreach (ServiceTagInformation item in subscriptionResource.GetAllServiceTagInformationAsync(location, tagName: tagName))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List usages
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUsages_ListUsages()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/UsageList.json
            // this example is just showing the usage of "Usages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("westus");
            await foreach (NetworkUsage item in subscriptionResource.GetUsagesAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List usages spaced location
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUsages_ListUsagesSpacedLocation()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/UsageListSpacedLocation.json
            // this example is just showing the usage of "Usages_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("West US");
            await foreach (NetworkUsage item in subscriptionResource.GetUsagesAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
