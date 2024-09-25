// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_WorkspacePrivateEndpointConnectionResource
    {
        // PrivateEndpointConnection_GetByWorkspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateEndpointConnectionGetByWorkspace()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2024-08-08-preview/examples/PrivateEndpointConnection_GetByWorkspace.json
            // this example is just showing the usage of "PrivateEndpointConnections_GetByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspacePrivateEndpointConnectionResource created on azure
            // for more information of creating WorkspacePrivateEndpointConnectionResource, please refer to the document of WorkspacePrivateEndpointConnectionResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            string privateEndpointConnectionName = "workspace1.377103f1-5179-4bdf-8556-4cdd3207cc5b";
            ResourceIdentifier workspacePrivateEndpointConnectionResourceId = WorkspacePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            WorkspacePrivateEndpointConnectionResource workspacePrivateEndpointConnection = client.GetWorkspacePrivateEndpointConnectionResource(workspacePrivateEndpointConnectionResourceId);

            // invoke the operation
            WorkspacePrivateEndpointConnectionResource result = await workspacePrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DesktopVirtualizationPrivateEndpointConnectionDataData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnection_DeleteByWorkspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PrivateEndpointConnectionDeleteByWorkspace()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2024-08-08-preview/examples/PrivateEndpointConnection_DeleteByWorkspace.json
            // this example is just showing the usage of "PrivateEndpointConnections_DeleteByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspacePrivateEndpointConnectionResource created on azure
            // for more information of creating WorkspacePrivateEndpointConnectionResource, please refer to the document of WorkspacePrivateEndpointConnectionResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            string privateEndpointConnectionName = "workspace1.377103f1-5179-4bdf-8556-4cdd3207cc5b";
            ResourceIdentifier workspacePrivateEndpointConnectionResourceId = WorkspacePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            WorkspacePrivateEndpointConnectionResource workspacePrivateEndpointConnection = client.GetWorkspacePrivateEndpointConnectionResource(workspacePrivateEndpointConnectionResourceId);

            // invoke the operation
            await workspacePrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // PrivateEndpointConnection_UpdateByWorkspace
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PrivateEndpointConnectionUpdateByWorkspace()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2024-08-08-preview/examples/PrivateEndpointConnection_UpdateByWorkspace.json
            // this example is just showing the usage of "PrivateEndpointConnections_UpdateByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspacePrivateEndpointConnectionResource created on azure
            // for more information of creating WorkspacePrivateEndpointConnectionResource, please refer to the document of WorkspacePrivateEndpointConnectionResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string workspaceName = "workspace1";
            string privateEndpointConnectionName = "workspace1.377103f1-5179-4bdf-8556-4cdd3207cc5b";
            ResourceIdentifier workspacePrivateEndpointConnectionResourceId = WorkspacePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, privateEndpointConnectionName);
            WorkspacePrivateEndpointConnectionResource workspacePrivateEndpointConnection = client.GetWorkspacePrivateEndpointConnectionResource(workspacePrivateEndpointConnectionResourceId);

            // invoke the operation
            DesktopVirtualizationPrivateEndpointConnection connection = new DesktopVirtualizationPrivateEndpointConnection()
            {
                ConnectionState = new DesktopVirtualizationPrivateLinkServiceConnectionState()
                {
                    Status = DesktopVirtualizationPrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Approved by admin@consoto.com",
                    ActionsRequired = "None",
                },
            };
            ArmOperation<WorkspacePrivateEndpointConnectionResource> lro = await workspacePrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, connection);
            WorkspacePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DesktopVirtualizationPrivateEndpointConnectionDataData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
