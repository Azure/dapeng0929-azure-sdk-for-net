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
    public partial class Sample_NetworkManagerRoutingRulesResource
    {
        // Gets routing rule collection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsRoutingRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerRoutingRuleCollectionGet.json
            // this example is just showing the usage of "RoutingRuleCollections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingRulesResource created on azure
            // for more information of creating NetworkManagerRoutingRulesResource, please refer to the document of NetworkManagerRoutingRulesResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestRoutingConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier networkManagerRoutingRulesResourceId = NetworkManagerRoutingRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            NetworkManagerRoutingRulesResource networkManagerRoutingRules = client.GetNetworkManagerRoutingRulesResource(networkManagerRoutingRulesResourceId);

            // invoke the operation
            NetworkManagerRoutingRulesResource result = await networkManagerRoutingRules.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerRoutingRulesData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or Update a routing rule collection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateARoutingRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerRoutingRuleCollectionPut.json
            // this example is just showing the usage of "RoutingRuleCollections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingRulesResource created on azure
            // for more information of creating NetworkManagerRoutingRulesResource, please refer to the document of NetworkManagerRoutingRulesResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestRoutingConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier networkManagerRoutingRulesResourceId = NetworkManagerRoutingRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            NetworkManagerRoutingRulesResource networkManagerRoutingRules = client.GetNetworkManagerRoutingRulesResource(networkManagerRoutingRulesResourceId);

            // invoke the operation
            NetworkManagerRoutingRulesData data = new NetworkManagerRoutingRulesData()
            {
                Description = "A sample policy",
                AppliesTo =
{
new NetworkManagerRoutingGroupItem("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Network/networkManagers/testNetworkManager/networkGroups/testGroup")
},
            };
            ArmOperation<NetworkManagerRoutingRulesResource> lro = await networkManagerRoutingRules.UpdateAsync(WaitUntil.Completed, data);
            NetworkManagerRoutingRulesResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkManagerRoutingRulesData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes an routing rule collection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesAnRoutingRuleCollection()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerRoutingRuleCollectionDelete.json
            // this example is just showing the usage of "RoutingRuleCollections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerRoutingRulesResource created on azure
            // for more information of creating NetworkManagerRoutingRulesResource, please refer to the document of NetworkManagerRoutingRulesResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string configurationName = "myTestRoutingConfig";
            string ruleCollectionName = "testRuleCollection";
            ResourceIdentifier networkManagerRoutingRulesResourceId = NetworkManagerRoutingRulesResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, configurationName, ruleCollectionName);
            NetworkManagerRoutingRulesResource networkManagerRoutingRules = client.GetNetworkManagerRoutingRulesResource(networkManagerRoutingRulesResourceId);

            // invoke the operation
            await networkManagerRoutingRules.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
