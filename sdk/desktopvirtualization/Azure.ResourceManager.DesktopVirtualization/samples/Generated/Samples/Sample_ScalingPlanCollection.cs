// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_ScalingPlanCollection
    {
        // ScalingPlans_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ScalingPlansGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-09-10/examples/ScalingPlan_Get.json
            // this example is just showing the usage of "ScalingPlans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScalingPlanResource
            ScalingPlanCollection collection = resourceGroupResource.GetScalingPlans();

            // invoke the operation
            string scalingPlanName = "scalingPlan1";
            ScalingPlanResource result = await collection.GetAsync(scalingPlanName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScalingPlans_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ScalingPlansGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-09-10/examples/ScalingPlan_Get.json
            // this example is just showing the usage of "ScalingPlans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScalingPlanResource
            ScalingPlanCollection collection = resourceGroupResource.GetScalingPlans();

            // invoke the operation
            string scalingPlanName = "scalingPlan1";
            bool result = await collection.ExistsAsync(scalingPlanName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ScalingPlans_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ScalingPlansGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-09-10/examples/ScalingPlan_Get.json
            // this example is just showing the usage of "ScalingPlans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScalingPlanResource
            ScalingPlanCollection collection = resourceGroupResource.GetScalingPlans();

            // invoke the operation
            string scalingPlanName = "scalingPlan1";
            NullableResponse<ScalingPlanResource> response = await collection.GetIfExistsAsync(scalingPlanName);
            ScalingPlanResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScalingPlanData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ScalingPlans_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ScalingPlansCreate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-09-10/examples/ScalingPlan_Create.json
            // this example is just showing the usage of "ScalingPlans_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScalingPlanResource
            ScalingPlanCollection collection = resourceGroupResource.GetScalingPlans();

            // invoke the operation
            string scalingPlanName = "scalingPlan1";
            ScalingPlanData data = new ScalingPlanData(new AzureLocation("centralus"), "Central Standard Time")
            {
                Description = "Description of Scaling Plan",
                FriendlyName = "Scaling Plan 1",
                ScalingHostPoolType = ScalingHostPoolType.Pooled,
                ExclusionTag = "value",
                Schedules =
{
new ScalingSchedule()
{
Name = "schedule1",
DaysOfWeek =
{
ScalingScheduleDaysOfWeekItem.Monday,ScalingScheduleDaysOfWeekItem.Tuesday,ScalingScheduleDaysOfWeekItem.Wednesday,ScalingScheduleDaysOfWeekItem.Thursday,ScalingScheduleDaysOfWeekItem.Friday
},
RampUpStartTime = new ScalingActionTime(6,0),
RampUpLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.DepthFirst,
RampUpMinimumHostsPct = 20,
RampUpCapacityThresholdPct = 80,
PeakStartTime = new ScalingActionTime(8,0),
PeakLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.BreadthFirst,
RampDownStartTime = new ScalingActionTime(18,0),
RampDownLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.DepthFirst,
RampDownMinimumHostsPct = 20,
RampDownCapacityThresholdPct = 50,
RampDownForceLogoffUsers = true,
RampDownWaitTimeMinutes = 30,
RampDownNotificationMessage = "message",
OffPeakStartTime = new ScalingActionTime(20,0),
OffPeakLoadBalancingAlgorithm = SessionHostLoadBalancingAlgorithm.DepthFirst,
}
},
                HostPoolReferences =
{
new ScalingHostPoolReference()
{
HostPoolId = new ResourceIdentifier("/subscriptions/daefabc0-95b4-48b3-b645-8a753a63c4fa/resourceGroups/resourceGroup1/providers/Microsoft.DesktopVirtualization/hostPools/hostPool1"),
IsScalingPlanEnabled = true,
}
},
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<ScalingPlanResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scalingPlanName, data);
            ScalingPlanResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ScalingPlanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ScalingPlans_ListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ScalingPlansListByResourceGroup()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2024-09-10/examples/ScalingPlan_ListByResourceGroup.json
            // this example is just showing the usage of "ScalingPlans_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ScalingPlanResource
            ScalingPlanCollection collection = resourceGroupResource.GetScalingPlans();

            // invoke the operation and iterate over the result
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (ScalingPlanResource item in collection.GetAllAsync(pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
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
