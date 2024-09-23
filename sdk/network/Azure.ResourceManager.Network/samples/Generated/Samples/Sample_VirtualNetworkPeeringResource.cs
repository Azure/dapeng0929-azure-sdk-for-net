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
    public partial class Sample_VirtualNetworkPeeringResource
    {
        // Delete peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletePeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkPeeringDelete.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            await virtualNetworkPeering.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get V6 subnet peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetV6SubnetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkV6SubnetPeeringGet.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringResource result = await virtualNetworkPeering.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkPeeringGet.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringResource result = await virtualNetworkPeering.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get peering with remote virtual network encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPeeringWithRemoteVirtualNetworkEncryption()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkPeeringGetWithRemoteVirtualNetworkEncryption.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringResource result = await virtualNetworkPeering.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get subnet peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSubnetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkSubnetPeeringGet.json
            // this example is just showing the usage of "VirtualNetworkPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringResource result = await virtualNetworkPeering.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create V6 Subnet peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateV6SubnetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkV6SubnetPeeringCreate.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
                AreCompleteVnetsPeered = false,
                EnableOnlyIPv6Peering = true,
                LocalSubnetNames =
{
"Subnet1","Subnet4"
},
                RemoteSubnetNames =
{
"Subnet2"
},
            };
            ArmOperation<VirtualNetworkPeeringResource> lro = await virtualNetworkPeering.UpdateAsync(WaitUntil.Completed, data);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatePeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkPeeringCreate.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
            };
            ArmOperation<VirtualNetworkPeeringResource> lro = await virtualNetworkPeering.UpdateAsync(WaitUntil.Completed, data);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create peering with remote virtual network encryption
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreatePeeringWithRemoteVirtualNetworkEncryption()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkPeeringCreateWithRemoteVirtualNetworkEncryption.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
            };
            ArmOperation<VirtualNetworkPeeringResource> lro = await virtualNetworkPeering.UpdateAsync(WaitUntil.Completed, data);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create subnet peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateSubnetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkSubnetPeeringCreate.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
                AreCompleteVnetsPeered = false,
                EnableOnlyIPv6Peering = false,
                LocalSubnetNames =
{
"Subnet1","Subnet4"
},
                RemoteSubnetNames =
{
"Subnet2"
},
            };
            ArmOperation<VirtualNetworkPeeringResource> lro = await virtualNetworkPeering.UpdateAsync(WaitUntil.Completed, data);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Sync Peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SyncPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkPeeringSync.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
            };
            SyncRemoteAddressSpace? syncRemoteAddressSpace = SyncRemoteAddressSpace.True;
            ArmOperation<VirtualNetworkPeeringResource> lro = await virtualNetworkPeering.UpdateAsync(WaitUntil.Completed, data, syncRemoteAddressSpace: syncRemoteAddressSpace);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Sync V6 Subnet Peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SyncV6SubnetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkV6SubnetPeeringSync.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
                AreCompleteVnetsPeered = false,
                EnableOnlyIPv6Peering = true,
            };
            SyncRemoteAddressSpace? syncRemoteAddressSpace = SyncRemoteAddressSpace.True;
            ArmOperation<VirtualNetworkPeeringResource> lro = await virtualNetworkPeering.UpdateAsync(WaitUntil.Completed, data, syncRemoteAddressSpace: syncRemoteAddressSpace);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Sync subnet Peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SyncSubnetPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkSubnetPeeringSync.json
            // this example is just showing the usage of "VirtualNetworkPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkPeeringResource created on azure
            // for more information of creating VirtualNetworkPeeringResource, please refer to the document of VirtualNetworkPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "peerTest";
            string virtualNetworkName = "vnet1";
            string virtualNetworkPeeringName = "peer";
            ResourceIdentifier virtualNetworkPeeringResourceId = VirtualNetworkPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualNetworkName, virtualNetworkPeeringName);
            VirtualNetworkPeeringResource virtualNetworkPeering = client.GetVirtualNetworkPeeringResource(virtualNetworkPeeringResourceId);

            // invoke the operation
            VirtualNetworkPeeringData data = new VirtualNetworkPeeringData()
            {
                AllowVirtualNetworkAccess = true,
                AllowForwardedTraffic = true,
                AllowGatewayTransit = false,
                UseRemoteGateways = false,
                RemoteVirtualNetworkId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/peerTest/providers/Microsoft.Network/virtualNetworks/vnet2"),
                AreCompleteVnetsPeered = false,
                EnableOnlyIPv6Peering = false,
            };
            SyncRemoteAddressSpace? syncRemoteAddressSpace = SyncRemoteAddressSpace.True;
            ArmOperation<VirtualNetworkPeeringResource> lro = await virtualNetworkPeering.UpdateAsync(WaitUntil.Completed, data, syncRemoteAddressSpace: syncRemoteAddressSpace);
            VirtualNetworkPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
