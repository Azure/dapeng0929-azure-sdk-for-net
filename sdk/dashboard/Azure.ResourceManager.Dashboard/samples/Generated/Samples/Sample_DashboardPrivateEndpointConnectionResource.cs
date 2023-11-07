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
using Azure.ResourceManager.Dashboard;

namespace Azure.ResourceManager.Dashboard.Samples
{
    public partial class Sample_DashboardPrivateEndpointConnectionResource
    {
        // PrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2023-09-01/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DashboardPrivateEndpointConnectionResource created on azure
            // for more information of creating DashboardPrivateEndpointConnectionResource, please refer to the document of DashboardPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier dashboardPrivateEndpointConnectionResourceId = DashboardPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            DashboardPrivateEndpointConnectionResource dashboardPrivateEndpointConnection = client.GetDashboardPrivateEndpointConnectionResource(dashboardPrivateEndpointConnectionResourceId);

            // invoke the operation
            DashboardPrivateEndpointConnectionResource result = await dashboardPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DashboardPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnections_Approve
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PrivateEndpointConnectionsApprove()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2023-09-01/examples/PrivateEndpointConnections_Approve.json
            // this example is just showing the usage of "PrivateEndpointConnections_Approve" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DashboardPrivateEndpointConnectionResource created on azure
            // for more information of creating DashboardPrivateEndpointConnectionResource, please refer to the document of DashboardPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier dashboardPrivateEndpointConnectionResourceId = DashboardPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            DashboardPrivateEndpointConnectionResource dashboardPrivateEndpointConnection = client.GetDashboardPrivateEndpointConnectionResource(dashboardPrivateEndpointConnectionResourceId);

            // invoke the operation
            DashboardPrivateEndpointConnectionData data = new DashboardPrivateEndpointConnectionData();
            ArmOperation<DashboardPrivateEndpointConnectionResource> lro = await dashboardPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            DashboardPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DashboardPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnections_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PrivateEndpointConnectionsDelete()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2023-09-01/examples/PrivateEndpointConnections_Delete.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DashboardPrivateEndpointConnectionResource created on azure
            // for more information of creating DashboardPrivateEndpointConnectionResource, please refer to the document of DashboardPrivateEndpointConnectionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string workspaceName = "myWorkspace";
            string privateEndpointConnectionName = "myConnection";
            ResourceIdentifier dashboardPrivateEndpointConnectionResourceId = DashboardPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            DashboardPrivateEndpointConnectionResource dashboardPrivateEndpointConnection = client.GetDashboardPrivateEndpointConnectionResource(dashboardPrivateEndpointConnectionResourceId);

            // invoke the operation
            await dashboardPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
