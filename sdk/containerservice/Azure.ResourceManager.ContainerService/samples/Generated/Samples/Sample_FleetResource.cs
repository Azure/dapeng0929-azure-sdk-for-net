// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerService.Samples
{
    public partial class Sample_FleetResource
    {
        // Lists the Fleet resources in a subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetFleets_ListsTheFleetResourcesInASubscription()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_ListBySub.json
            // this example is just showing the usage of "Fleets_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid1";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (FleetResource item in subscriptionResource.GetFleetsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FleetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Gets a Fleet resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsAFleetResource()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_Get.json
            // this example is just showing the usage of "Fleets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            FleetResource result = await fleet.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a Fleet.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAFleet()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_PatchTags.json
            // this example is just showing the usage of "Fleets_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            FleetPatch patch = new FleetPatch()
            {
                Tags =
{
["env"] = "prod",
["tier"] = "secure",
},
            };
            string ifMatch = "dfjkwelr7384";
            ArmOperation<FleetResource> lro = await fleet.UpdateAsync(WaitUntil.Completed, patch, ifMatch: ifMatch);
            FleetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FleetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes a Fleet resource asynchronously with a long running operation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesAFleetResourceAsynchronouslyWithALongRunningOperation()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_Delete.json
            // this example is just showing the usage of "Fleets_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string fleetName = "fleet1";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            await fleet.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Lists the user credentials of a Fleet.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetCredentials_ListsTheUserCredentialsOfAFleet()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/fleet/preview/2024-05-02-preview/examples/Fleets_ListCredentialsResult.json
            // this example is just showing the usage of "Fleets_ListCredentials" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FleetResource created on azure
            // for more information of creating FleetResource, please refer to the document of FleetResource
            string subscriptionId = "subid1";
            string resourceGroupName = "rg1";
            string fleetName = "fleet";
            ResourceIdentifier fleetResourceId = FleetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, fleetName);
            FleetResource fleet = client.GetFleetResource(fleetResourceId);

            // invoke the operation
            FleetCredentialResults result = await fleet.GetCredentialsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
