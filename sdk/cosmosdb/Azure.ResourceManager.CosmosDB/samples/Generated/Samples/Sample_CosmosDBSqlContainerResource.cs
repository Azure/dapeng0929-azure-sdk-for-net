// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBSqlContainerResource
    {
        // CosmosDBSqlContainerGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBSqlContainerGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBSqlContainerGet.json
            // this example is just showing the usage of "SqlResources_GetSqlContainer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerResource created on azure
            // for more information of creating CosmosDBSqlContainerResource, please refer to the document of CosmosDBSqlContainerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerResourceId = CosmosDBSqlContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerResource cosmosDBSqlContainer = client.GetCosmosDBSqlContainerResource(cosmosDBSqlContainerResourceId);

            // invoke the operation
            CosmosDBSqlContainerResource result = await cosmosDBSqlContainer.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlContainerCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBSqlContainerCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBSqlContainerCreateUpdate.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlContainer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerResource created on azure
            // for more information of creating CosmosDBSqlContainerResource, please refer to the document of CosmosDBSqlContainerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerResourceId = CosmosDBSqlContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerResource cosmosDBSqlContainer = client.GetCosmosDBSqlContainerResource(cosmosDBSqlContainerResourceId);

            // invoke the operation
            CosmosDBSqlContainerCreateOrUpdateContent content = new CosmosDBSqlContainerCreateOrUpdateContent(new AzureLocation("West US"), new CosmosDBSqlContainerResourceInfo("containerName")
            {
                IndexingPolicy = new CosmosDBIndexingPolicy()
                {
                    IsAutomatic = true,
                    IndexingMode = CosmosDBIndexingMode.Consistent,
                    IncludedPaths =
{
new CosmosDBIncludedPath()
{
Path = "/*",
Indexes =
{
new CosmosDBPathIndexes()
{
DataType = CosmosDBDataType.String,
Precision = -1,
Kind = CosmosDBIndexKind.Range,
},new CosmosDBPathIndexes()
{
DataType = CosmosDBDataType.Number,
Precision = -1,
Kind = CosmosDBIndexKind.Range,
}
},
}
},
                    ExcludedPaths =
{
},
                },
                PartitionKey = new CosmosDBContainerPartitionKey()
                {
                    Paths =
{
"/AccountNumber"
},
                    Kind = CosmosDBPartitionKind.Hash,
                },
                DefaultTtl = 100,
                UniqueKeys =
{
new CosmosDBUniqueKey()
{
Paths =
{
"/testPath"
},
}
},
                ConflictResolutionPolicy = new ConflictResolutionPolicy()
                {
                    Mode = ConflictResolutionMode.LastWriterWins,
                    ConflictResolutionPath = "/path",
                },
                ClientEncryptionPolicy = new CosmosDBClientEncryptionPolicy(new CosmosDBClientEncryptionIncludedPath[]
            {
new CosmosDBClientEncryptionIncludedPath("/path","keyId","Deterministic","AEAD_AES_256_CBC_HMAC_SHA256")
            }, 2),
                ComputedProperties =
{
new ComputedProperty()
{
Name = "cp_lowerName",
Query = "SELECT VALUE LOWER(c.name) FROM c",
}
},
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<CosmosDBSqlContainerResource> lro = await cosmosDBSqlContainer.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBSqlContainerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlContainerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlContainerDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBSqlContainerDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBSqlContainerDelete.json
            // this example is just showing the usage of "SqlResources_DeleteSqlContainer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerResource created on azure
            // for more information of creating CosmosDBSqlContainerResource, please refer to the document of CosmosDBSqlContainerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerResourceId = CosmosDBSqlContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerResource cosmosDBSqlContainer = client.GetCosmosDBSqlContainerResource(cosmosDBSqlContainerResourceId);

            // invoke the operation
            await cosmosDBSqlContainer.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBSqlContainerBackupInformation
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RetrieveContinuousBackupInformation_CosmosDBSqlContainerBackupInformation()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBSqlContainerBackupInformation.json
            // this example is just showing the usage of "SqlResources_RetrieveContinuousBackupInformation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlContainerResource created on azure
            // for more information of creating CosmosDBSqlContainerResource, please refer to the document of CosmosDBSqlContainerResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            ResourceIdentifier cosmosDBSqlContainerResourceId = CosmosDBSqlContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName);
            CosmosDBSqlContainerResource cosmosDBSqlContainer = client.GetCosmosDBSqlContainerResource(cosmosDBSqlContainerResourceId);

            // invoke the operation
            ContinuousBackupRestoreLocation location = new ContinuousBackupRestoreLocation()
            {
                Location = new AzureLocation("North Europe"),
            };
            ArmOperation<CosmosDBBackupInformation> lro = await cosmosDBSqlContainer.RetrieveContinuousBackupInformationAsync(WaitUntil.Completed, location);
            CosmosDBBackupInformation result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
