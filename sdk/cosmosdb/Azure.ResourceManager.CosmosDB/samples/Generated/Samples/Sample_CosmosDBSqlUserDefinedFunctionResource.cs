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
    public partial class Sample_CosmosDBSqlUserDefinedFunctionResource
    {
        // CosmosDBSqlUserDefinedFunctionGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CosmosDBSqlUserDefinedFunctionGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBSqlUserDefinedFunctionGet.json
            // this example is just showing the usage of "SqlResources_GetSqlUserDefinedFunction" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlUserDefinedFunctionResource created on azure
            // for more information of creating CosmosDBSqlUserDefinedFunctionResource, please refer to the document of CosmosDBSqlUserDefinedFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rgName";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            string userDefinedFunctionName = "userDefinedFunctionName";
            ResourceIdentifier cosmosDBSqlUserDefinedFunctionResourceId = CosmosDBSqlUserDefinedFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName, userDefinedFunctionName);
            CosmosDBSqlUserDefinedFunctionResource cosmosDBSqlUserDefinedFunction = client.GetCosmosDBSqlUserDefinedFunctionResource(cosmosDBSqlUserDefinedFunctionResourceId);

            // invoke the operation
            CosmosDBSqlUserDefinedFunctionResource result = await cosmosDBSqlUserDefinedFunction.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlUserDefinedFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlUserDefinedFunctionCreateUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CosmosDBSqlUserDefinedFunctionCreateUpdate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBSqlUserDefinedFunctionCreateUpdate.json
            // this example is just showing the usage of "SqlResources_CreateUpdateSqlUserDefinedFunction" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlUserDefinedFunctionResource created on azure
            // for more information of creating CosmosDBSqlUserDefinedFunctionResource, please refer to the document of CosmosDBSqlUserDefinedFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            string userDefinedFunctionName = "userDefinedFunctionName";
            ResourceIdentifier cosmosDBSqlUserDefinedFunctionResourceId = CosmosDBSqlUserDefinedFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName, userDefinedFunctionName);
            CosmosDBSqlUserDefinedFunctionResource cosmosDBSqlUserDefinedFunction = client.GetCosmosDBSqlUserDefinedFunctionResource(cosmosDBSqlUserDefinedFunctionResourceId);

            // invoke the operation
            CosmosDBSqlUserDefinedFunctionCreateOrUpdateContent content = new CosmosDBSqlUserDefinedFunctionCreateOrUpdateContent(new AzureLocation("placeholder"), new CosmosDBSqlUserDefinedFunctionResourceInfo("userDefinedFunctionName")
            {
                Body = "body",
            })
            {
                Options = new CosmosDBCreateUpdateConfig(),
            };
            ArmOperation<CosmosDBSqlUserDefinedFunctionResource> lro = await cosmosDBSqlUserDefinedFunction.UpdateAsync(WaitUntil.Completed, content);
            CosmosDBSqlUserDefinedFunctionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBSqlUserDefinedFunctionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CosmosDBSqlUserDefinedFunctionDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_CosmosDBSqlUserDefinedFunctionDelete()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/stable/2024-08-15/examples/CosmosDBSqlUserDefinedFunctionDelete.json
            // this example is just showing the usage of "SqlResources_DeleteSqlUserDefinedFunction" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBSqlUserDefinedFunctionResource created on azure
            // for more information of creating CosmosDBSqlUserDefinedFunctionResource, please refer to the document of CosmosDBSqlUserDefinedFunctionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string accountName = "ddb1";
            string databaseName = "databaseName";
            string containerName = "containerName";
            string userDefinedFunctionName = "userDefinedFunctionName";
            ResourceIdentifier cosmosDBSqlUserDefinedFunctionResourceId = CosmosDBSqlUserDefinedFunctionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, databaseName, containerName, userDefinedFunctionName);
            CosmosDBSqlUserDefinedFunctionResource cosmosDBSqlUserDefinedFunction = client.GetCosmosDBSqlUserDefinedFunctionResource(cosmosDBSqlUserDefinedFunctionResourceId);

            // invoke the operation
            await cosmosDBSqlUserDefinedFunction.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
