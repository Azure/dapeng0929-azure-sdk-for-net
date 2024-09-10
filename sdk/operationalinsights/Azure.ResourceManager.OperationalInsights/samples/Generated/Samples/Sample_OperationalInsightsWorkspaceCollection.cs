// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.OperationalInsights.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.OperationalInsights.Samples
{
    public partial class Sample_OperationalInsightsWorkspaceCollection
    {
        // WorkspacesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_WorkspacesGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2023-09-01/examples/WorkspacesListByResourceGroup.json
            // this example is just showing the usage of "Workspaces_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OperationalInsightsWorkspaceResource
            OperationalInsightsWorkspaceCollection collection = resourceGroupResource.GetOperationalInsightsWorkspaces();

            // invoke the operation and iterate over the result
            await foreach (OperationalInsightsWorkspaceResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsWorkspaceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // WorkspacesCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_WorkspacesCreate()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2023-09-01/examples/WorkspacesCreate.json
            // this example is just showing the usage of "Workspaces_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OperationalInsightsWorkspaceResource
            OperationalInsightsWorkspaceCollection collection = resourceGroupResource.GetOperationalInsightsWorkspaces();

            // invoke the operation
            string workspaceName = "oiautorest6685";
            OperationalInsightsWorkspaceData data = new OperationalInsightsWorkspaceData(new AzureLocation("australiasoutheast"))
            {
                Sku = new OperationalInsightsWorkspaceSku(OperationalInsightsWorkspaceSkuName.PerGB2018),
                RetentionInDays = 30,
                Tags =
{
["tag1"] = "val1",
},
            };
            ArmOperation<OperationalInsightsWorkspaceResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workspaceName, data);
            OperationalInsightsWorkspaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkspaceGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_WorkspaceGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2023-09-01/examples/WorkspacesGet.json
            // this example is just showing the usage of "Workspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OperationalInsightsWorkspaceResource
            OperationalInsightsWorkspaceCollection collection = resourceGroupResource.GetOperationalInsightsWorkspaces();

            // invoke the operation
            string workspaceName = "oiautorest6685";
            OperationalInsightsWorkspaceResource result = await collection.GetAsync(workspaceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalInsightsWorkspaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // WorkspaceGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_WorkspaceGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2023-09-01/examples/WorkspacesGet.json
            // this example is just showing the usage of "Workspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OperationalInsightsWorkspaceResource
            OperationalInsightsWorkspaceCollection collection = resourceGroupResource.GetOperationalInsightsWorkspaces();

            // invoke the operation
            string workspaceName = "oiautorest6685";
            bool result = await collection.ExistsAsync(workspaceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // WorkspaceGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_WorkspaceGet()
        {
            // Generated from example definition: specification/operationalinsights/resource-manager/Microsoft.OperationalInsights/stable/2023-09-01/examples/WorkspacesGet.json
            // this example is just showing the usage of "Workspaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-00000000000";
            string resourceGroupName = "oiautorest6685";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OperationalInsightsWorkspaceResource
            OperationalInsightsWorkspaceCollection collection = resourceGroupResource.GetOperationalInsightsWorkspaces();

            // invoke the operation
            string workspaceName = "oiautorest6685";
            NullableResponse<OperationalInsightsWorkspaceResource> response = await collection.GetIfExistsAsync(workspaceName);
            OperationalInsightsWorkspaceResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalInsightsWorkspaceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
