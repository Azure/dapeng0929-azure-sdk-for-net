// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DesktopVirtualization;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_ScalingPlanResource
    {
        // ScalingPlans_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ScalingPlansGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/ScalingPlan_Get.json
            // this example is just showing the usage of "ScalingPlans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanResource created on azure
            // for more information of creating ScalingPlanResource, please refer to the document of ScalingPlanResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            ResourceIdentifier scalingPlanResourceId = ScalingPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName);
            ScalingPlanResource scalingPlan = client.GetScalingPlanResource(scalingPlanResourceId);

            // invoke the operation
            ScalingPlanResource result = await scalingPlan.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScalingPlans_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ScalingPlansDelete()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/ScalingPlan_Delete.json
            // this example is just showing the usage of "ScalingPlans_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanResource created on azure
            // for more information of creating ScalingPlanResource, please refer to the document of ScalingPlanResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            ResourceIdentifier scalingPlanResourceId = ScalingPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName);
            ScalingPlanResource scalingPlan = client.GetScalingPlanResource(scalingPlanResourceId);

            // invoke the operation
            await scalingPlan.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ScalingPlans_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ScalingPlansUpdate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/ScalingPlan_Update.json
            // this example is just showing the usage of "ScalingPlans_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ScalingPlanResource created on azure
            // for more information of creating ScalingPlanResource, please refer to the document of ScalingPlanResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string scalingPlanName = "scalingPlan1";
            ResourceIdentifier scalingPlanResourceId = ScalingPlanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, scalingPlanName);
            ScalingPlanResource scalingPlan = client.GetScalingPlanResource(scalingPlanResourceId);

            // invoke the operation
            ScalingPlanPatch patch = new ScalingPlanPatch();
            ScalingPlanResource result = await scalingPlan.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScalingPlans_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetScalingPlans_ScalingPlansListBySubscription()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/ScalingPlan_ListBySubscription.json
            // this example is just showing the usage of "ScalingPlans_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (ScalingPlanResource item in subscriptionResource.GetScalingPlansAsync(pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScalingPlanData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
