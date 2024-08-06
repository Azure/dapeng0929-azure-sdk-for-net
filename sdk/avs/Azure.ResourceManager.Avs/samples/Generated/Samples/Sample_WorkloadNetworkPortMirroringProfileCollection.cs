// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_WorkloadNetworkPortMirroringProfileCollection
    {
        // WorkloadNetworks_ListPortMirroring
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WorkloadNetworksListPortMirroring()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_ListPortMirroring.json
            // this example is just showing the usage of "WorkloadNetworks_ListPortMirroring" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPortMirroringProfileResource
            WorkloadNetworkPortMirroringProfileCollection collection = workloadNetwork.GetWorkloadNetworkPortMirroringProfiles();

            // invoke the operation and iterate over the result
            await foreach (WorkloadNetworkPortMirroringProfileResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkPortMirroringProfileData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WorkloadNetworks_GetPortMirroring
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkloadNetworksGetPortMirroring()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetPortMirroring.json
            // this example is just showing the usage of "WorkloadNetworks_GetPortMirroring" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPortMirroringProfileResource
            WorkloadNetworkPortMirroringProfileCollection collection = workloadNetwork.GetWorkloadNetworkPortMirroringProfiles();

            // invoke the operation
            string portMirroringId = "portMirroring1";
            WorkloadNetworkPortMirroringProfileResource result = await collection.GetAsync(portMirroringId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkPortMirroringProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkloadNetworks_GetPortMirroring
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WorkloadNetworksGetPortMirroring()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetPortMirroring.json
            // this example is just showing the usage of "WorkloadNetworks_GetPortMirroring" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPortMirroringProfileResource
            WorkloadNetworkPortMirroringProfileCollection collection = workloadNetwork.GetWorkloadNetworkPortMirroringProfiles();

            // invoke the operation
            string portMirroringId = "portMirroring1";
            bool result = await collection.ExistsAsync(portMirroringId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WorkloadNetworks_GetPortMirroring
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_WorkloadNetworksGetPortMirroring()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_GetPortMirroring.json
            // this example is just showing the usage of "WorkloadNetworks_GetPortMirroring" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPortMirroringProfileResource
            WorkloadNetworkPortMirroringProfileCollection collection = workloadNetwork.GetWorkloadNetworkPortMirroringProfiles();

            // invoke the operation
            string portMirroringId = "portMirroring1";
            NullableResponse<WorkloadNetworkPortMirroringProfileResource> response = await collection.GetIfExistsAsync(portMirroringId);
            WorkloadNetworkPortMirroringProfileResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkloadNetworkPortMirroringProfileData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // WorkloadNetworks_CreatePortMirroring
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_WorkloadNetworksCreatePortMirroring()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2023-09-01/examples/WorkloadNetworks_CreatePortMirroring.json
            // this example is just showing the usage of "WorkloadNetworks_CreatePortMirroring" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkloadNetworkResource created on azure
            // for more information of creating WorkloadNetworkResource, please refer to the document of WorkloadNetworkResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier workloadNetworkResourceId = WorkloadNetworkResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            WorkloadNetworkResource workloadNetwork = client.GetWorkloadNetworkResource(workloadNetworkResourceId);

            // get the collection of this WorkloadNetworkPortMirroringProfileResource
            WorkloadNetworkPortMirroringProfileCollection collection = workloadNetwork.GetWorkloadNetworkPortMirroringProfiles();

            // invoke the operation
            string portMirroringId = "portMirroring1";
            WorkloadNetworkPortMirroringProfileData data = new WorkloadNetworkPortMirroringProfileData()
            {
                DisplayName = "portMirroring1",
                Direction = PortMirroringProfileDirection.Bidirectional,
                Source = "vmGroup1",
                Destination = "vmGroup2",
                Revision = 1,
            };
            ArmOperation<WorkloadNetworkPortMirroringProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, portMirroringId, data);
            WorkloadNetworkPortMirroringProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkloadNetworkPortMirroringProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
