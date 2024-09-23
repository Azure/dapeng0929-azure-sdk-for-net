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
    public partial class Sample_DdosProtectionPlanResource
    {
        // Delete DDoS protection plan
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteDDoSProtectionPlan()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/DdosProtectionPlanDelete.json
            // this example is just showing the usage of "DdosProtectionPlans_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DdosProtectionPlanResource created on azure
            // for more information of creating DdosProtectionPlanResource, please refer to the document of DdosProtectionPlanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string ddosProtectionPlanName = "test-plan";
            ResourceIdentifier ddosProtectionPlanResourceId = DdosProtectionPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ddosProtectionPlanName);
            DdosProtectionPlanResource ddosProtectionPlan = client.GetDdosProtectionPlanResource(ddosProtectionPlanResourceId);

            // invoke the operation
            await ddosProtectionPlan.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get DDoS protection plan
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDDoSProtectionPlan()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/DdosProtectionPlanGet.json
            // this example is just showing the usage of "DdosProtectionPlans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DdosProtectionPlanResource created on azure
            // for more information of creating DdosProtectionPlanResource, please refer to the document of DdosProtectionPlanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string ddosProtectionPlanName = "test-plan";
            ResourceIdentifier ddosProtectionPlanResourceId = DdosProtectionPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ddosProtectionPlanName);
            DdosProtectionPlanResource ddosProtectionPlan = client.GetDdosProtectionPlanResource(ddosProtectionPlanResourceId);

            // invoke the operation
            DdosProtectionPlanResource result = await ddosProtectionPlan.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DdosProtectionPlanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DDoS protection plan Update tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DDoSProtectionPlanUpdateTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/DdosProtectionPlanUpdateTags.json
            // this example is just showing the usage of "DdosProtectionPlans_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DdosProtectionPlanResource created on azure
            // for more information of creating DdosProtectionPlanResource, please refer to the document of DdosProtectionPlanResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string ddosProtectionPlanName = "test-plan";
            ResourceIdentifier ddosProtectionPlanResourceId = DdosProtectionPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ddosProtectionPlanName);
            DdosProtectionPlanResource ddosProtectionPlan = client.GetDdosProtectionPlanResource(ddosProtectionPlanResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            DdosProtectionPlanResource result = await ddosProtectionPlan.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DdosProtectionPlanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all DDoS protection plans
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDdosProtectionPlans_ListAllDDoSProtectionPlans()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/DdosProtectionPlanListAll.json
            // this example is just showing the usage of "DdosProtectionPlans_List" operation, for the dependent resources, they will have to be created separately.

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
            await foreach (DdosProtectionPlanResource item in subscriptionResource.GetDdosProtectionPlansAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DdosProtectionPlanData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
