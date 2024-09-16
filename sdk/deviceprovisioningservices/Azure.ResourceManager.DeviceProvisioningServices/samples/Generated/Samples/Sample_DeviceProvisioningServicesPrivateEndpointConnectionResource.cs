// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DeviceProvisioningServices.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices.Samples
{
    public partial class Sample_DeviceProvisioningServicesPrivateEndpointConnectionResource
    {
        // PrivateEndpointConnection_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateEndpointConnectionGet()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/preview/2023-03-01-preview/examples/DPSGetPrivateEndpointConnection.json
            // this example is just showing the usage of "IotDpsResource_GetPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServicesPrivateEndpointConnectionResource created on azure
            // for more information of creating DeviceProvisioningServicesPrivateEndpointConnectionResource, please refer to the document of DeviceProvisioningServicesPrivateEndpointConnectionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myFirstProvisioningService";
            string privateEndpointConnectionName = "myPrivateEndpointConnection";
            ResourceIdentifier deviceProvisioningServicesPrivateEndpointConnectionResourceId = DeviceProvisioningServicesPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, privateEndpointConnectionName);
            DeviceProvisioningServicesPrivateEndpointConnectionResource deviceProvisioningServicesPrivateEndpointConnection = client.GetDeviceProvisioningServicesPrivateEndpointConnectionResource(deviceProvisioningServicesPrivateEndpointConnectionResourceId);

            // invoke the operation
            DeviceProvisioningServicesPrivateEndpointConnectionResource result = await deviceProvisioningServicesPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceProvisioningServicesPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnection_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PrivateEndpointConnectionCreateOrUpdate()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/preview/2023-03-01-preview/examples/DPSCreateOrUpdatePrivateEndpointConnection.json
            // this example is just showing the usage of "IotDpsResource_CreateOrUpdatePrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServicesPrivateEndpointConnectionResource created on azure
            // for more information of creating DeviceProvisioningServicesPrivateEndpointConnectionResource, please refer to the document of DeviceProvisioningServicesPrivateEndpointConnectionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myFirstProvisioningService";
            string privateEndpointConnectionName = "myPrivateEndpointConnection";
            ResourceIdentifier deviceProvisioningServicesPrivateEndpointConnectionResourceId = DeviceProvisioningServicesPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, privateEndpointConnectionName);
            DeviceProvisioningServicesPrivateEndpointConnectionResource deviceProvisioningServicesPrivateEndpointConnection = client.GetDeviceProvisioningServicesPrivateEndpointConnectionResource(deviceProvisioningServicesPrivateEndpointConnectionResourceId);

            // invoke the operation
            DeviceProvisioningServicesPrivateEndpointConnectionData data = new DeviceProvisioningServicesPrivateEndpointConnectionData(new DeviceProvisioningServicesPrivateEndpointConnectionProperties(new DeviceProvisioningServicesPrivateLinkServiceConnectionState(DeviceProvisioningServicesPrivateLinkServiceConnectionStatus.Approved, "Approved by johndoe@contoso.com")));
            ArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource> lro = await deviceProvisioningServicesPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            DeviceProvisioningServicesPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceProvisioningServicesPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnection_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_PrivateEndpointConnectionDelete()
        {
            // Generated from example definition: specification/deviceprovisioningservices/resource-manager/Microsoft.Devices/preview/2023-03-01-preview/examples/DPSDeletePrivateEndpointConnection.json
            // this example is just showing the usage of "IotDpsResource_DeletePrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceProvisioningServicesPrivateEndpointConnectionResource created on azure
            // for more information of creating DeviceProvisioningServicesPrivateEndpointConnectionResource, please refer to the document of DeviceProvisioningServicesPrivateEndpointConnectionResource
            string subscriptionId = "91d12660-3dec-467a-be2a-213b5544ddc0";
            string resourceGroupName = "myResourceGroup";
            string resourceName = "myFirstProvisioningService";
            string privateEndpointConnectionName = "myPrivateEndpointConnection";
            ResourceIdentifier deviceProvisioningServicesPrivateEndpointConnectionResourceId = DeviceProvisioningServicesPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, privateEndpointConnectionName);
            DeviceProvisioningServicesPrivateEndpointConnectionResource deviceProvisioningServicesPrivateEndpointConnection = client.GetDeviceProvisioningServicesPrivateEndpointConnectionResource(deviceProvisioningServicesPrivateEndpointConnectionResourceId);

            // invoke the operation
            ArmOperation<DeviceProvisioningServicesPrivateEndpointConnectionResource> lro = await deviceProvisioningServicesPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);
            DeviceProvisioningServicesPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceProvisioningServicesPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
