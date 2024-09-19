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
    public partial class Sample_GremlinGraphCollection
    {
        // CosmosDBGremlinGraphList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_CosmosDBGremlinGraphList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBGremlinGraphList.json
            // this example is just showing the usage of "GremlinResources_ListGremlinGraphs" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GremlinDatabaseResource created on azure
            // for more information of creating GremlinDatabaseResource, please refer to the document of GremlinDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier gremlinDatabaseResourceId = GremlinDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            GremlinDatabaseResource gremlinDatabase = client.GetGremlinDatabaseResource(gremlinDatabaseResourceId);

            // get the collection of this GremlinGraphResource
            GremlinGraphCollection collection = gremlinDatabase.GetGremlinGraphs();

            // invoke the operation and iterate over the result
            await foreach (GremlinGraphResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GremlinGraphData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // CosmosDBGremlinGraphGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBGremlinGraphGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBGremlinGraphGet.json
            // this example is just showing the usage of "GremlinResources_GetGremlinGraph" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GremlinDatabaseResource created on azure
            // for more information of creating GremlinDatabaseResource, please refer to the document of GremlinDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier gremlinDatabaseResourceId = GremlinDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            GremlinDatabaseResource gremlinDatabase = client.GetGremlinDatabaseResource(gremlinDatabaseResourceId);

            // get the collection of this GremlinGraphResource
            GremlinGraphCollection collection = gremlinDatabase.GetGremlinGraphs();

            // invoke the operation
            string graphName = "graphName";
            GremlinGraphResource result = await collection.GetAsync(graphName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GremlinGraphData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBGremlinGraphGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_CosmosDBGremlinGraphGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBGremlinGraphGet.json
            // this example is just showing the usage of "GremlinResources_GetGremlinGraph" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GremlinDatabaseResource created on azure
            // for more information of creating GremlinDatabaseResource, please refer to the document of GremlinDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier gremlinDatabaseResourceId = GremlinDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            GremlinDatabaseResource gremlinDatabase = client.GetGremlinDatabaseResource(gremlinDatabaseResourceId);

            // get the collection of this GremlinGraphResource
            GremlinGraphCollection collection = gremlinDatabase.GetGremlinGraphs();

            // invoke the operation
            string graphName = "graphName";
            bool result = await collection.ExistsAsync(graphName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // CosmosDBGremlinGraphGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_CosmosDBGremlinGraphGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBGremlinGraphGet.json
            // this example is just showing the usage of "GremlinResources_GetGremlinGraph" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GremlinDatabaseResource created on azure
            // for more information of creating GremlinDatabaseResource, please refer to the document of GremlinDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier gremlinDatabaseResourceId = GremlinDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            GremlinDatabaseResource gremlinDatabase = client.GetGremlinDatabaseResource(gremlinDatabaseResourceId);

            // get the collection of this GremlinGraphResource
            GremlinGraphCollection collection = gremlinDatabase.GetGremlinGraphs();

            // invoke the operation
            string graphName = "graphName";
            NullableResponse<GremlinGraphResource> response = await collection.GetIfExistsAsync(graphName);
            GremlinGraphResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GremlinGraphData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CosmosDBGremlinGraphCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CosmosDBGremlinGraphCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-09-01-preview/examples/CosmosDBGremlinGraphCreateUpdate.json
            // this example is just showing the usage of "GremlinResources_CreateUpdateGremlinGraph" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GremlinDatabaseResource created on azure
            // for more information of creating GremlinDatabaseResource, please refer to the document of GremlinDatabaseResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            ResourceIdentifier gremlinDatabaseResourceId = GremlinDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName);
            GremlinDatabaseResource gremlinDatabase = client.GetGremlinDatabaseResource(gremlinDatabaseResourceId);

            // get the collection of this GremlinGraphResource
            GremlinGraphCollection collection = gremlinDatabase.GetGremlinGraphs();

            // invoke the operation
            string graphName = "graphName";
            GremlinGraphCreateOrUpdateContent content = new GremlinGraphCreateOrUpdateContent(new AzureLocation("West US"), new GremlinGraphResourceInfo("graphName")
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
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<GremlinGraphResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, graphName, content);
            GremlinGraphResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GremlinGraphData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
