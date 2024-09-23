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
    public partial class Sample_NetworkManagerResource
    {
        // List Active Connectivity Configurations
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetActiveConnectivityConfigurations_ListActiveConnectivityConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerActiveConnectivityConfigurationsList.json
            // this example is just showing the usage of "ListActiveConnectivityConfigurations" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // invoke the operation and iterate over the result
            ActiveConfigurationContent content = new ActiveConfigurationContent()
            {
                Regions =
{
new AzureLocation("westus")
},
                SkipToken = "fakeSkipTokenCode",
            };
            await foreach (ActiveConnectivityConfiguration item in networkManager.GetActiveConnectivityConfigurationsAsync(content))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List Active Security Admin Rules
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetActiveSecurityAdminRules_ListActiveSecurityAdminRules()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerActiveSecurityAdminRulesList.json
            // this example is just showing the usage of "ListActiveSecurityAdminRules" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // invoke the operation and iterate over the result
            ActiveConfigurationContent content = new ActiveConfigurationContent()
            {
                Regions =
{
new AzureLocation("westus")
},
                SkipToken = "fakeSkipTokenCode",
            };
            await foreach (ActiveBaseSecurityAdminRule item in networkManager.GetActiveSecurityAdminRulesAsync(content))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // NetworkManagersGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkManagersGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerGet.json
            // this example is just showing the usage of "NetworkManagers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // invoke the operation
            NetworkManagerResource result = await networkManager.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkManagersDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NetworkManagersDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerDelete.json
            // this example is just showing the usage of "NetworkManagers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // invoke the operation
            bool? force = false;
            await networkManager.DeleteAsync(WaitUntil.Completed, force: force);

            Console.WriteLine($"Succeeded");
        }

        // NetworkManagesPatch
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NetworkManagesPatch()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerPatch.json
            // this example is just showing the usage of "NetworkManagers_Patch" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // invoke the operation
            NetworkManagerPatch patch = new NetworkManagerPatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            NetworkManagerResource result = await networkManager.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkManagersList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkManagers_NetworkManagersList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerListAll.json
            // this example is just showing the usage of "NetworkManagers_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkManagerResource item in subscriptionResource.GetNetworkManagersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkManagerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // NetworkManageCommitPost
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PostNetworkManagerCommit_NetworkManageCommitPost()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerCommitPost.json
            // this example is just showing the usage of "NetworkManagerCommits_Post" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resoureGroupSample";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // invoke the operation
            NetworkManagerCommit networkManagerCommit = new NetworkManagerCommit(new string[]
            {
"useast"
            }, NetworkConfigurationDeploymentType.SecurityAdmin)
            {
                ConfigurationIds =
{
"/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/resoureGroupSample/providers/Microsoft.Network/networkManagers/testNetworkManager/securityAdminConfigurations/SampleSecurityAdminConfig"
},
            };
            ArmOperation<NetworkManagerCommit> lro = await networkManager.PostNetworkManagerCommitAsync(WaitUntil.Completed, networkManagerCommit);
            NetworkManagerCommit result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // NetworkManagerDeploymentStatusList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkManagerDeploymentStatus_NetworkManagerDeploymentStatusList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerDeploymentStatusList.json
            // this example is just showing the usage of "NetworkManagerDeploymentStatus_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resoureGroupSample";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // invoke the operation and iterate over the result
            NetworkManagerDeploymentStatusContent content = new NetworkManagerDeploymentStatusContent()
            {
                Regions =
{
"eastus","westus"
},
                DeploymentTypes =
{
NetworkConfigurationDeploymentType.Connectivity,new NetworkConfigurationDeploymentType("AdminPolicy")
},
                SkipToken = "FakeSkipTokenCode",
            };
            await foreach (NetworkManagerDeploymentStatus item in networkManager.GetNetworkManagerDeploymentStatusAsync(content))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
