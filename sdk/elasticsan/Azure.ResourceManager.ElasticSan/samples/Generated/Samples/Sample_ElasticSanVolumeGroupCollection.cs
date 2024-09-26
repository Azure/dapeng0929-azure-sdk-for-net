// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan.Samples
{
    public partial class Sample_ElasticSanVolumeGroupCollection
    {
        // VolumeGroups_ListByElasticSan_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VolumeGroupsListByElasticSanMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_ListByElasticSan_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_ListByElasticSan" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation and iterate over the result
            await foreach (ElasticSanVolumeGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanVolumeGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VolumeGroups_ListByElasticSan_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VolumeGroupsListByElasticSanMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_ListByElasticSan_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_ListByElasticSan" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation and iterate over the result
            await foreach (ElasticSanVolumeGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanVolumeGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VolumeGroups_Create_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VolumeGroupsCreateMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation
            string volumeGroupName = "volumegroupname";
            ElasticSanVolumeGroupData data = new ElasticSanVolumeGroupData()
            {
                Identity = new ManagedServiceIdentity("None")
                {
                    UserAssignedIdentities =
{
[new ResourceIdentifier("key1006")] = new UserAssignedIdentity(),
},
                },
                ProtocolType = ElasticSanStorageTargetType.Iscsi,
                Encryption = ElasticSanEncryptionType.EncryptionAtRestWithPlatformKey,
                EncryptionProperties = new ElasticSanEncryptionProperties()
                {
                    KeyVaultProperties = new ElasticSanKeyVaultProperties()
                    {
                        KeyName = "lunpapamzeimppgobraxjt",
                        KeyVersion = "oemygbnfmqhijmonkqfqmy",
                        KeyVaultUri = new Uri("https://microsoft.com/a"),
                    },
                    EncryptionUserAssignedIdentity = new ResourceIdentifier("gfhkfbozahmmwluqndfgxunssafa"),
                },
                VirtualNetworkRules =
{
new ElasticSanVirtualNetworkRule(new ResourceIdentifier("bkhwaiqvvaguymsmnzzbzz"))
{
Action = ElasticSanVirtualNetworkRuleAction.Allow,
}
},
                EnforceDataIntegrityCheckForIscsi = true,
            };
            ArmOperation<ElasticSanVolumeGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, volumeGroupName, data);
            ElasticSanVolumeGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Create_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VolumeGroupsCreateMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Create_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation
            string volumeGroupName = "volumegroupname";
            ElasticSanVolumeGroupData data = new ElasticSanVolumeGroupData();
            ArmOperation<ElasticSanVolumeGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, volumeGroupName, data);
            ElasticSanVolumeGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeGroupsGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation
            string volumeGroupName = "volumegroupname";
            ElasticSanVolumeGroupResource result = await collection.GetAsync(volumeGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_VolumeGroupsGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation
            string volumeGroupName = "volumegroupname";
            bool result = await collection.ExistsAsync(volumeGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VolumeGroups_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_VolumeGroupsGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation
            string volumeGroupName = "volumegroupname";
            NullableResponse<ElasticSanVolumeGroupResource> response = await collection.GetIfExistsAsync(volumeGroupName);
            ElasticSanVolumeGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanVolumeGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // VolumeGroups_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VolumeGroupsGetMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation
            string volumeGroupName = "volumegroupname";
            ElasticSanVolumeGroupResource result = await collection.GetAsync(volumeGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanVolumeGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VolumeGroups_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_VolumeGroupsGetMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation
            string volumeGroupName = "volumegroupname";
            bool result = await collection.ExistsAsync(volumeGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VolumeGroups_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_VolumeGroupsGetMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/preview/2024-06-01-preview/examples/VolumeGroups_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VolumeGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // get the collection of this ElasticSanVolumeGroupResource
            ElasticSanVolumeGroupCollection collection = elasticSan.GetElasticSanVolumeGroups();

            // invoke the operation
            string volumeGroupName = "volumegroupname";
            NullableResponse<ElasticSanVolumeGroupResource> response = await collection.GetIfExistsAsync(volumeGroupName);
            ElasticSanVolumeGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanVolumeGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
