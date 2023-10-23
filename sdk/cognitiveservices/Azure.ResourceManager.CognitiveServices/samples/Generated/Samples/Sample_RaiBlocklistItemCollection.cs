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
using Azure.ResourceManager.CognitiveServices;
using Azure.ResourceManager.CognitiveServices.Models;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_RaiBlocklistItemCollection
    {
        // ListBlocklistItems
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListBlocklistItems()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/ListBlocklistItems.json
            // this example is just showing the usage of "RaiBlocklistItems_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RaiBlocklistResource created on azure
            // for more information of creating RaiBlocklistResource, please refer to the document of RaiBlocklistResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string raiBlocklistName = "raiBlocklistName";
            ResourceIdentifier raiBlocklistResourceId = RaiBlocklistResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, raiBlocklistName);
            RaiBlocklistResource raiBlocklist = client.GetRaiBlocklistResource(raiBlocklistResourceId);

            // get the collection of this RaiBlocklistItemResource
            RaiBlocklistItemCollection collection = raiBlocklist.GetRaiBlocklistItems();

            // invoke the operation and iterate over the result
            await foreach (RaiBlocklistItemResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RaiBlocklistItemData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetRaiBlocklistItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRaiBlocklistItem()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/GetRaiBlocklistItem.json
            // this example is just showing the usage of "RaiBlocklistItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RaiBlocklistResource created on azure
            // for more information of creating RaiBlocklistResource, please refer to the document of RaiBlocklistResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string raiBlocklistName = "raiBlocklistName";
            ResourceIdentifier raiBlocklistResourceId = RaiBlocklistResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, raiBlocklistName);
            RaiBlocklistResource raiBlocklist = client.GetRaiBlocklistResource(raiBlocklistResourceId);

            // get the collection of this RaiBlocklistItemResource
            RaiBlocklistItemCollection collection = raiBlocklist.GetRaiBlocklistItems();

            // invoke the operation
            string raiBlocklistItemName = "raiBlocklistItemName";
            RaiBlocklistItemResource result = await collection.GetAsync(raiBlocklistItemName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RaiBlocklistItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetRaiBlocklistItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetRaiBlocklistItem()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/GetRaiBlocklistItem.json
            // this example is just showing the usage of "RaiBlocklistItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RaiBlocklistResource created on azure
            // for more information of creating RaiBlocklistResource, please refer to the document of RaiBlocklistResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string raiBlocklistName = "raiBlocklistName";
            ResourceIdentifier raiBlocklistResourceId = RaiBlocklistResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, raiBlocklistName);
            RaiBlocklistResource raiBlocklist = client.GetRaiBlocklistResource(raiBlocklistResourceId);

            // get the collection of this RaiBlocklistItemResource
            RaiBlocklistItemCollection collection = raiBlocklist.GetRaiBlocklistItems();

            // invoke the operation
            string raiBlocklistItemName = "raiBlocklistItemName";
            bool result = await collection.ExistsAsync(raiBlocklistItemName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetRaiBlocklistItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetRaiBlocklistItem()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/GetRaiBlocklistItem.json
            // this example is just showing the usage of "RaiBlocklistItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RaiBlocklistResource created on azure
            // for more information of creating RaiBlocklistResource, please refer to the document of RaiBlocklistResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string raiBlocklistName = "raiBlocklistName";
            ResourceIdentifier raiBlocklistResourceId = RaiBlocklistResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, raiBlocklistName);
            RaiBlocklistResource raiBlocklist = client.GetRaiBlocklistResource(raiBlocklistResourceId);

            // get the collection of this RaiBlocklistItemResource
            RaiBlocklistItemCollection collection = raiBlocklist.GetRaiBlocklistItems();

            // invoke the operation
            string raiBlocklistItemName = "raiBlocklistItemName";
            NullableResponse<RaiBlocklistItemResource> response = await collection.GetIfExistsAsync(raiBlocklistItemName);
            RaiBlocklistItemResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RaiBlocklistItemData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PutRaiBlocklistItem
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutRaiBlocklistItem()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/PutRaiBlocklistItem.json
            // this example is just showing the usage of "RaiBlocklistItems_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RaiBlocklistResource created on azure
            // for more information of creating RaiBlocklistResource, please refer to the document of RaiBlocklistResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            string raiBlocklistName = "raiBlocklistName";
            ResourceIdentifier raiBlocklistResourceId = RaiBlocklistResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, raiBlocklistName);
            RaiBlocklistResource raiBlocklist = client.GetRaiBlocklistResource(raiBlocklistResourceId);

            // get the collection of this RaiBlocklistItemResource
            RaiBlocklistItemCollection collection = raiBlocklist.GetRaiBlocklistItems();

            // invoke the operation
            string raiBlocklistItemName = "raiBlocklistItemName";
            RaiBlocklistItemData data = new RaiBlocklistItemData()
            {
                Properties = new RaiBlocklistItemProperties()
                {
                    Pattern = "Pattern To Block",
                    IsRegex = false,
                },
            };
            ArmOperation<RaiBlocklistItemResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, raiBlocklistItemName, data);
            RaiBlocklistItemResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RaiBlocklistItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
