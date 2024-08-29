// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_BaseAdminRuleCollection
    {
        // List security admin rules
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSecurityAdminRules()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerAdminRuleList.json
            // this example is just showing the usage of "AdminRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // get the collection of this BaseAdminRuleResource
            BaseAdminRuleCollection collection = adminRuleGroup.GetBaseAdminRules();

            // invoke the operation and iterate over the result
            await foreach (BaseAdminRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BaseAdminRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets security admin rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsSecurityAdminRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerAdminRuleGet.json
            // this example is just showing the usage of "AdminRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // get the collection of this BaseAdminRuleResource
            BaseAdminRuleCollection collection = adminRuleGroup.GetBaseAdminRules();

            // invoke the operation
            string ruleName = "SampleAdminRule";
            BaseAdminRuleResource result = await collection.GetAsync(ruleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BaseAdminRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets security admin rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsSecurityAdminRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerAdminRuleGet.json
            // this example is just showing the usage of "AdminRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // get the collection of this BaseAdminRuleResource
            BaseAdminRuleCollection collection = adminRuleGroup.GetBaseAdminRules();

            // invoke the operation
            string ruleName = "SampleAdminRule";
            bool result = await collection.ExistsAsync(ruleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets security admin rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsSecurityAdminRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerAdminRuleGet.json
            // this example is just showing the usage of "AdminRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // get the collection of this BaseAdminRuleResource
            BaseAdminRuleCollection collection = adminRuleGroup.GetBaseAdminRules();

            // invoke the operation
            string ruleName = "SampleAdminRule";
            NullableResponse<BaseAdminRuleResource> response = await collection.GetIfExistsAsync(ruleName);
            BaseAdminRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BaseAdminRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Gets security default admin rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsSecurityDefaultAdminRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerDefaultAdminRuleGet.json
            // this example is just showing the usage of "AdminRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // get the collection of this BaseAdminRuleResource
            BaseAdminRuleCollection collection = adminRuleGroup.GetBaseAdminRules();

            // invoke the operation
            string ruleName = "SampleDefaultAdminRule";
            BaseAdminRuleResource result = await collection.GetAsync(ruleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BaseAdminRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets security default admin rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsSecurityDefaultAdminRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerDefaultAdminRuleGet.json
            // this example is just showing the usage of "AdminRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // get the collection of this BaseAdminRuleResource
            BaseAdminRuleCollection collection = adminRuleGroup.GetBaseAdminRules();

            // invoke the operation
            string ruleName = "SampleDefaultAdminRule";
            bool result = await collection.ExistsAsync(ruleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Gets security default admin rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetsSecurityDefaultAdminRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerDefaultAdminRuleGet.json
            // this example is just showing the usage of "AdminRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // get the collection of this BaseAdminRuleResource
            BaseAdminRuleCollection collection = adminRuleGroup.GetBaseAdminRules();

            // invoke the operation
            string ruleName = "SampleDefaultAdminRule";
            NullableResponse<BaseAdminRuleResource> response = await collection.GetIfExistsAsync(ruleName);
            BaseAdminRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BaseAdminRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create a admin rule with network group as source or destination
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAAdminRuleWithNetworkGroupAsSourceOrDestination()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerAdminRulePut_NetworkGroupSource.json
            // this example is just showing the usage of "AdminRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // get the collection of this BaseAdminRuleResource
            BaseAdminRuleCollection collection = adminRuleGroup.GetBaseAdminRules();

            // invoke the operation
            string ruleName = "SampleAdminRule";
            BaseAdminRuleData data = new NetworkAdminRule()
            {
                Description = "This is Sample Admin Rule",
                Protocol = SecurityConfigurationRuleProtocol.Tcp,
                Sources =
{
new AddressPrefixItem()
{
AddressPrefix = "Internet",
AddressPrefixType = AddressPrefixType.ServiceTag,
}
},
                Destinations =
{
new AddressPrefixItem()
{
AddressPrefix = "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkManagers/testNetworkManager/networkGroups/ng1",
AddressPrefixType = AddressPrefixType.NetworkGroup,
}
},
                SourcePortRanges =
{
"0-65535"
},
                DestinationPortRanges =
{
"22"
},
                Access = SecurityConfigurationRuleAccess.Deny,
                Priority = 1,
                Direction = SecurityConfigurationRuleDirection.Inbound,
            };
            ArmOperation<BaseAdminRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleName, data);
            BaseAdminRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BaseAdminRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create an admin rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAnAdminRule()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerAdminRulePut.json
            // this example is just showing the usage of "AdminRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AdminRuleGroupResource created on azure
            // for more information of creating AdminRuleGroupResource, please refer to the document of AdminRuleGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestSecurityConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier adminRuleGroupResourceId = AdminRuleGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            AdminRuleGroupResource adminRuleGroup = client.GetAdminRuleGroupResource(adminRuleGroupResourceId);

            // get the collection of this BaseAdminRuleResource
            BaseAdminRuleCollection collection = adminRuleGroup.GetBaseAdminRules();

            // invoke the operation
            string ruleName = "SampleAdminRule";
            BaseAdminRuleData data = new NetworkAdminRule()
            {
                Description = "This is Sample Admin Rule",
                Protocol = SecurityConfigurationRuleProtocol.Tcp,
                Sources =
{
new AddressPrefixItem()
{
AddressPrefix = "Internet",
AddressPrefixType = AddressPrefixType.ServiceTag,
}
},
                Destinations =
{
new AddressPrefixItem()
{
AddressPrefix = "*",
AddressPrefixType = AddressPrefixType.IPPrefix,
}
},
                SourcePortRanges =
{
"0-65535"
},
                DestinationPortRanges =
{
"22"
},
                Access = SecurityConfigurationRuleAccess.Deny,
                Priority = 1,
                Direction = SecurityConfigurationRuleDirection.Inbound,
            };
            ArmOperation<BaseAdminRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleName, data);
            BaseAdminRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BaseAdminRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
