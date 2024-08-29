// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_StaticCidrCollection
    {
        // StaticCidrs_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_StaticCidrsList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/StaticCidrs_List.json
            // this example is just showing the usage of "StaticCidrs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // get the collection of this StaticCidrResource
            StaticCidrCollection collection = ipamPool.GetStaticCidrs();

            // invoke the operation and iterate over the result
            await foreach (StaticCidrResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StaticCidrData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // StaticCidrs_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StaticCidrsCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/StaticCidrs_Create.json
            // this example is just showing the usage of "StaticCidrs_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // get the collection of this StaticCidrResource
            StaticCidrCollection collection = ipamPool.GetStaticCidrs();

            // invoke the operation
            string staticCidrName = "TestStaticCidr";
            StaticCidrData data = new StaticCidrData();
            ArmOperation<StaticCidrResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, staticCidrName, data);
            StaticCidrResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticCidrData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StaticCidrs_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StaticCidrsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/StaticCidrs_Get.json
            // this example is just showing the usage of "StaticCidrs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // get the collection of this StaticCidrResource
            StaticCidrCollection collection = ipamPool.GetStaticCidrs();

            // invoke the operation
            string staticCidrName = "TestStaticCidr";
            StaticCidrResource result = await collection.GetAsync(staticCidrName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticCidrData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StaticCidrs_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_StaticCidrsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/StaticCidrs_Get.json
            // this example is just showing the usage of "StaticCidrs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // get the collection of this StaticCidrResource
            StaticCidrCollection collection = ipamPool.GetStaticCidrs();

            // invoke the operation
            string staticCidrName = "TestStaticCidr";
            bool result = await collection.ExistsAsync(staticCidrName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // StaticCidrs_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_StaticCidrsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/StaticCidrs_Get.json
            // this example is just showing the usage of "StaticCidrs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IpamPoolResource created on azure
            // for more information of creating IpamPoolResource, please refer to the document of IpamPoolResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            ResourceIdentifier ipamPoolResourceId = IpamPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName);
            IpamPoolResource ipamPool = client.GetIpamPoolResource(ipamPoolResourceId);

            // get the collection of this StaticCidrResource
            StaticCidrCollection collection = ipamPool.GetStaticCidrs();

            // invoke the operation
            string staticCidrName = "TestStaticCidr";
            NullableResponse<StaticCidrResource> response = await collection.GetIfExistsAsync(staticCidrName);
            StaticCidrResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StaticCidrData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
