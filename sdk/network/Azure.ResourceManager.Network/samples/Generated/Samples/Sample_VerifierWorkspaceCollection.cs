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
    public partial class Sample_VerifierWorkspaceCollection
    {
        // VerifierWorkspaceList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VerifierWorkspaceList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VerifierWorkspaceList.json
            // this example is just showing the usage of "VerifierWorkspaces_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this VerifierWorkspaceResource
            VerifierWorkspaceCollection collection = networkManager.GetVerifierWorkspaces();

            // invoke the operation and iterate over the result
            await foreach (VerifierWorkspaceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VerifierWorkspaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VerifierWorkspaceGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VerifierWorkspaceGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VerifierWorkspaceGet.json
            // this example is just showing the usage of "VerifierWorkspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this VerifierWorkspaceResource
            VerifierWorkspaceCollection collection = networkManager.GetVerifierWorkspaces();

            // invoke the operation
            string workspaceName = "testWorkspace";
            VerifierWorkspaceResource result = await collection.GetAsync(workspaceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VerifierWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VerifierWorkspaceGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_VerifierWorkspaceGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VerifierWorkspaceGet.json
            // this example is just showing the usage of "VerifierWorkspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this VerifierWorkspaceResource
            VerifierWorkspaceCollection collection = networkManager.GetVerifierWorkspaces();

            // invoke the operation
            string workspaceName = "testWorkspace";
            bool result = await collection.ExistsAsync(workspaceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VerifierWorkspaceGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_VerifierWorkspaceGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VerifierWorkspaceGet.json
            // this example is just showing the usage of "VerifierWorkspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this VerifierWorkspaceResource
            VerifierWorkspaceCollection collection = networkManager.GetVerifierWorkspaces();

            // invoke the operation
            string workspaceName = "testWorkspace";
            NullableResponse<VerifierWorkspaceResource> response = await collection.GetIfExistsAsync(workspaceName);
            VerifierWorkspaceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VerifierWorkspaceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // VerifierWorkspaceCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VerifierWorkspaceCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/VerifierWorkspacePut.json
            // this example is just showing the usage of "VerifierWorkspaces_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this VerifierWorkspaceResource
            VerifierWorkspaceCollection collection = networkManager.GetVerifierWorkspaces();

            // invoke the operation
            string workspaceName = "testWorkspace";
            VerifierWorkspaceData data = new VerifierWorkspaceData(new AzureLocation("eastus"))
            {
                Properties = new VerifierWorkspaceProperties()
                {
                    Description = "A sample workspace",
                },
            };
            ArmOperation<VerifierWorkspaceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workspaceName, data);
            VerifierWorkspaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VerifierWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
