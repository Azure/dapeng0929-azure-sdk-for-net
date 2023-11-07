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
    public partial class Sample_RedisEnterprisePrivateEndpointConnectionResource
    {
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

            // this example assumes you already have this RedisEnterprisePrivateEndpointConnectionResource created on azure
            // for more information of creating RedisEnterprisePrivateEndpointConnectionResource, please refer to the document of RedisEnterprisePrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string privateEndpointConnectionName = "pectest01";
            ResourceIdentifier redisEnterprisePrivateEndpointConnectionResourceId = RedisEnterprisePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, privateEndpointConnectionName);
            RedisEnterprisePrivateEndpointConnectionResource redisEnterprisePrivateEndpointConnection = client.GetRedisEnterprisePrivateEndpointConnectionResource(redisEnterprisePrivateEndpointConnectionResourceId);

            // invoke the operation
            RedisEnterprisePrivateEndpointConnectionResource result = await redisEnterprisePrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterprisePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RedisEnterprisePutPrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RedisEnterprisePutPrivateEndpointConnection()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2023-11-01/examples/RedisEnterprisePutPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Put" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterprisePrivateEndpointConnectionResource created on azure
            // for more information of creating RedisEnterprisePrivateEndpointConnectionResource, please refer to the document of RedisEnterprisePrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string privateEndpointConnectionName = "pectest01";
            ResourceIdentifier redisEnterprisePrivateEndpointConnectionResourceId = RedisEnterprisePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, privateEndpointConnectionName);
            RedisEnterprisePrivateEndpointConnectionResource redisEnterprisePrivateEndpointConnection = client.GetRedisEnterprisePrivateEndpointConnectionResource(redisEnterprisePrivateEndpointConnectionResourceId);

            // invoke the operation
            RedisEnterprisePrivateEndpointConnectionData data = new RedisEnterprisePrivateEndpointConnectionData()
            {
                ConnectionState = new RedisEnterprisePrivateLinkServiceConnectionState()
                {
                    Status = RedisEnterprisePrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Auto-Approved",
                },
            };
            ArmOperation<RedisEnterprisePrivateEndpointConnectionResource> lro = await redisEnterprisePrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            RedisEnterprisePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisEnterprisePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // RedisEnterpriseDeletePrivateEndpointConnection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RedisEnterpriseDeletePrivateEndpointConnection()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2023-11-01/examples/RedisEnterpriseDeletePrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisEnterprisePrivateEndpointConnectionResource created on azure
            // for more information of creating RedisEnterprisePrivateEndpointConnectionResource, please refer to the document of RedisEnterprisePrivateEndpointConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string clusterName = "cache1";
            string privateEndpointConnectionName = "pectest01";
            ResourceIdentifier redisEnterprisePrivateEndpointConnectionResourceId = RedisEnterprisePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, privateEndpointConnectionName);
            RedisEnterprisePrivateEndpointConnectionResource redisEnterprisePrivateEndpointConnection = client.GetRedisEnterprisePrivateEndpointConnectionResource(redisEnterprisePrivateEndpointConnectionResourceId);

            // invoke the operation
            await redisEnterprisePrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
