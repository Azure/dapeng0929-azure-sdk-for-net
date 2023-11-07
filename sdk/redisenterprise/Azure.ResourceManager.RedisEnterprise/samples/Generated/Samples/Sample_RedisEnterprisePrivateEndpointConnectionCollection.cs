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
using Azure.ResourceManager.RedisEnterprise;
using Azure.ResourceManager.RedisEnterprise.Models;

namespace Azure.ResourceManager.RedisEnterprise.Samples
{
    public partial class Sample_RedisEnterprisePrivateEndpointConnectionCollection
    {
        // RedisEnterpriseListPrivateEndpointConnections
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_RedisEnterpriseListPrivateEndpointConnections()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2023-11-01/examples/RedisEnterpriseListPrivateEndpointConnections.json
            // this example is just showing the usage of "PrivateEndpointConnections_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseClusterResource created on azure
            // for more information of creating RedisEnterpriseClusterResource, please refer to the document of RedisEnterpriseClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            ResourceIdentifier redisEnterpriseClusterResourceId = RedisEnterpriseClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            RedisEnterpriseClusterResource redisEnterpriseCluster = client.GetRedisEnterpriseClusterResource(redisEnterpriseClusterResourceId);

            // get the collection of this RedisEnterprisePrivateEndpointConnectionResource
            RedisEnterprisePrivateEndpointConnectionCollection collection = redisEnterpriseCluster.GetRedisEnterprisePrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (RedisEnterprisePrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisEnterprisePrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // RedisEnterpriseGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RedisEnterpriseGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2023-11-01/examples/RedisEnterpriseGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseClusterResource created on azure
            // for more information of creating RedisEnterpriseClusterResource, please refer to the document of RedisEnterpriseClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            ResourceIdentifier redisEnterpriseClusterResourceId = RedisEnterpriseClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            RedisEnterpriseClusterResource redisEnterpriseCluster = client.GetRedisEnterpriseClusterResource(redisEnterpriseClusterResourceId);

            // get the collection of this RedisEnterprisePrivateEndpointConnectionResource
            RedisEnterprisePrivateEndpointConnectionCollection collection = redisEnterpriseCluster.GetRedisEnterprisePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "pectest01";
            RedisEnterprisePrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterprisePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RedisEnterpriseGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_RedisEnterpriseGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2023-11-01/examples/RedisEnterpriseGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseClusterResource created on azure
            // for more information of creating RedisEnterpriseClusterResource, please refer to the document of RedisEnterpriseClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            ResourceIdentifier redisEnterpriseClusterResourceId = RedisEnterpriseClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            RedisEnterpriseClusterResource redisEnterpriseCluster = client.GetRedisEnterpriseClusterResource(redisEnterpriseClusterResourceId);

            // get the collection of this RedisEnterprisePrivateEndpointConnectionResource
            RedisEnterprisePrivateEndpointConnectionCollection collection = redisEnterpriseCluster.GetRedisEnterprisePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "pectest01";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // RedisEnterpriseGetPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_RedisEnterpriseGetPrivateEndpointConnection()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2023-11-01/examples/RedisEnterpriseGetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseClusterResource created on azure
            // for more information of creating RedisEnterpriseClusterResource, please refer to the document of RedisEnterpriseClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            ResourceIdentifier redisEnterpriseClusterResourceId = RedisEnterpriseClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            RedisEnterpriseClusterResource redisEnterpriseCluster = client.GetRedisEnterpriseClusterResource(redisEnterpriseClusterResourceId);

            // get the collection of this RedisEnterprisePrivateEndpointConnectionResource
            RedisEnterprisePrivateEndpointConnectionCollection collection = redisEnterpriseCluster.GetRedisEnterprisePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "pectest01";
            NullableResponse<RedisEnterprisePrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            RedisEnterprisePrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisEnterprisePrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // RedisEnterprisePutPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_RedisEnterprisePutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2023-11-01/examples/RedisEnterprisePutPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterpriseClusterResource created on azure
            // for more information of creating RedisEnterpriseClusterResource, please refer to the document of RedisEnterpriseClusterResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            ResourceIdentifier redisEnterpriseClusterResourceId = RedisEnterpriseClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            RedisEnterpriseClusterResource redisEnterpriseCluster = client.GetRedisEnterpriseClusterResource(redisEnterpriseClusterResourceId);

            // get the collection of this RedisEnterprisePrivateEndpointConnectionResource
            RedisEnterprisePrivateEndpointConnectionCollection collection = redisEnterpriseCluster.GetRedisEnterprisePrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "pectest01";
            RedisEnterprisePrivateEndpointConnectionData data = new RedisEnterprisePrivateEndpointConnectionData()
            {
                ConnectionState = new RedisEnterprisePrivateLinkServiceConnectionState()
                {
                    Status = RedisEnterprisePrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<RedisEnterprisePrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            RedisEnterprisePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterprisePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
