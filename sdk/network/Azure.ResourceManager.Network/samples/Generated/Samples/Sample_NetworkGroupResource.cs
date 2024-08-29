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
    public partial class Sample_NetworkGroupResource
    {
        // NetworkGroupsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkGroupsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerGroupGet.json
            // this example is just showing the usage of "NetworkGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupResource created on azure
            // for more information of creating NetworkGroupResource, please refer to the document of NetworkGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string networkGroupName = "testNetworkGroup";
            ResourceIdentifier networkGroupResourceId = NetworkGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName);
            NetworkGroupResource networkGroup = client.GetNetworkGroupResource(networkGroupResourceId);

            // invoke the operation
            NetworkGroupResource result = await networkGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkGroupsPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NetworkGroupsPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerGroupPut.json
            // this example is just showing the usage of "NetworkGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupResource created on azure
            // for more information of creating NetworkGroupResource, please refer to the document of NetworkGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string networkGroupName = "testNetworkGroup";
            ResourceIdentifier networkGroupResourceId = NetworkGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName);
            NetworkGroupResource networkGroup = client.GetNetworkGroupResource(networkGroupResourceId);

            // invoke the operation
            NetworkGroupData data = new NetworkGroupData()
            {
                Description = "A sample group",
                MemberType = GroupMemberType.VirtualNetwork,
            };
            ArmOperation<NetworkGroupResource> lro = await networkGroup.UpdateAsync(WaitUntil.Completed, data);
            NetworkGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkGroupsDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NetworkGroupsDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/NetworkManagerGroupDelete.json
            // this example is just showing the usage of "NetworkGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkGroupResource created on azure
            // for more information of creating NetworkGroupResource, please refer to the document of NetworkGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            string networkGroupName = "testNetworkGroup";
            ResourceIdentifier networkGroupResourceId = NetworkGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, networkGroupName);
            NetworkGroupResource networkGroup = client.GetNetworkGroupResource(networkGroupResourceId);

            // invoke the operation
            bool? force = false;
            await networkGroup.DeleteAsync(WaitUntil.Completed, force: force);

            Console.WriteLine($"Succeeded");
        }
    }
}
