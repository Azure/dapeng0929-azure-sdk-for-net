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
    public partial class Sample_ExpressRouteCircuitPeeringResource
    {
        // Delete ExpressRouteCircuit Peerings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteExpressRouteCircuitPeerings()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitPeeringDelete.json
            // this example is just showing the usage of "ExpressRouteCircuitPeerings_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string peeringName = "peeringName";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // invoke the operation
            await expressRouteCircuitPeering.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get ExpressRouteCircuit Peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetExpressRouteCircuitPeering()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitPeeringGet.json
            // this example is just showing the usage of "ExpressRouteCircuitPeerings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string peeringName = "MicrosoftPeering";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // invoke the operation
            ExpressRouteCircuitPeeringResource result = await expressRouteCircuitPeering.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create ExpressRouteCircuit Peerings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateExpressRouteCircuitPeerings()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitPeeringCreate.json
            // this example is just showing the usage of "ExpressRouteCircuitPeerings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string peeringName = "AzurePrivatePeering";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // invoke the operation
            ExpressRouteCircuitPeeringData data = new ExpressRouteCircuitPeeringData()
            {
                PeerASN = 200,
                PrimaryPeerAddressPrefix = "192.168.16.252/30",
                SecondaryPeerAddressPrefix = "192.168.18.252/30",
                VlanId = 200,
            };
            ArmOperation<ExpressRouteCircuitPeeringResource> lro = await expressRouteCircuitPeering.UpdateAsync(WaitUntil.Completed, data);
            ExpressRouteCircuitPeeringResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitPeeringData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List ARP Table
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetArpTableExpressRouteCircuit_ListARPTable()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitARPTableList.json
            // this example is just showing the usage of "ExpressRouteCircuits_ListArpTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string peeringName = "peeringName";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // invoke the operation
            string devicePath = "devicePath";
            ArmOperation<ExpressRouteCircuitsArpTableListResult> lro = await expressRouteCircuitPeering.GetArpTableExpressRouteCircuitAsync(WaitUntil.Completed, devicePath);
            ExpressRouteCircuitsArpTableListResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // List Route Tables
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRoutesTableExpressRouteCircuit_ListRouteTables()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitRouteTableList.json
            // this example is just showing the usage of "ExpressRouteCircuits_ListRoutesTable" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string peeringName = "peeringName";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // invoke the operation
            string devicePath = "devicePath";
            ArmOperation<ExpressRouteCircuitsRoutesTableListResult> lro = await expressRouteCircuitPeering.GetRoutesTableExpressRouteCircuitAsync(WaitUntil.Completed, devicePath);
            ExpressRouteCircuitsRoutesTableListResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // List Route Table Summary
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRoutesTableSummaryExpressRouteCircuit_ListRouteTableSummary()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitRouteTableSummaryList.json
            // this example is just showing the usage of "ExpressRouteCircuits_ListRoutesTableSummary" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string peeringName = "peeringName";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // invoke the operation
            string devicePath = "devicePath";
            ArmOperation<ExpressRouteCircuitsRoutesTableSummaryListResult> lro = await expressRouteCircuitPeering.GetRoutesTableSummaryExpressRouteCircuitAsync(WaitUntil.Completed, devicePath);
            ExpressRouteCircuitsRoutesTableSummaryListResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get ExpressRoute Circuit Peering Traffic Stats
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPeeringStatsExpressRouteCircuit_GetExpressRouteCircuitPeeringTrafficStats()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitPeeringStats.json
            // this example is just showing the usage of "ExpressRouteCircuits_GetPeeringStats" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitPeeringResource created on azure
            // for more information of creating ExpressRouteCircuitPeeringResource, please refer to the document of ExpressRouteCircuitPeeringResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string peeringName = "peeringName";
            ResourceIdentifier expressRouteCircuitPeeringResourceId = ExpressRouteCircuitPeeringResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, peeringName);
            ExpressRouteCircuitPeeringResource expressRouteCircuitPeering = client.GetExpressRouteCircuitPeeringResource(expressRouteCircuitPeeringResourceId);

            // invoke the operation
            ExpressRouteCircuitStats result = await expressRouteCircuitPeering.GetPeeringStatsExpressRouteCircuitAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
