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
    public partial class Sample_GremlinDatabaseResource
    {
        // CosmosDBGremlinDatabaseGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBGremlinDatabaseGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBGremlinDatabaseGet.json
            // this example is just showing the usage of "GremlinResources_GetGremlinDatabase" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            GremlinDatabaseResource result = await gremlinDatabase.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GremlinDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBGremlinDatabaseCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBGremlinDatabaseCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBGremlinDatabaseCreateUpdate.json
            // this example is just showing the usage of "GremlinResources_CreateUpdateGremlinDatabase" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            GremlinDatabaseCreateOrUpdateContent content = new GremlinDatabaseCreateOrUpdateContent(new AzureLocation("West US"), new GremlinDatabaseResourceInfo("databaseName"))
            {
                Options = new CosmosDBCreateUpdateConfig(),
                Tags =
{
},
            };
            ArmOperation<GremlinDatabaseResource> lro = await gremlinDatabase.UpdateAsync(WaitUntil.Completed, content);
            GremlinDatabaseResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GremlinDatabaseData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBGremlinDatabaseDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBGremlinDatabaseDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBGremlinDatabaseDelete.json
            // this example is just showing the usage of "GremlinResources_DeleteGremlinDatabase" operation, for the dependent resources, they will have to be created separately.

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

            // invoke the operation
            await gremlinDatabase.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
