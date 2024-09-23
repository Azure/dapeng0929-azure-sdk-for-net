// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRouteCircuitCollection
    {
        // Get ExpressRouteCircuit
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetExpressRouteCircuit()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitGet.json
            // this example is just showing the usage of "ExpressRouteCircuits_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCircuitResource
            ExpressRouteCircuitCollection collection = resourceGroupResource.GetExpressRouteCircuits();

            // invoke the operation
            string circuitName = "circuitName";
            ExpressRouteCircuitResource result = await collection.GetAsync(circuitName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get ExpressRouteCircuit
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetExpressRouteCircuit()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitGet.json
            // this example is just showing the usage of "ExpressRouteCircuits_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCircuitResource
            ExpressRouteCircuitCollection collection = resourceGroupResource.GetExpressRouteCircuits();

            // invoke the operation
            string circuitName = "circuitName";
            bool result = await collection.ExistsAsync(circuitName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get ExpressRouteCircuit
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetExpressRouteCircuit()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitGet.json
            // this example is just showing the usage of "ExpressRouteCircuits_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCircuitResource
            ExpressRouteCircuitCollection collection = resourceGroupResource.GetExpressRouteCircuits();

            // invoke the operation
            string circuitName = "circuitName";
            NullableResponse<ExpressRouteCircuitResource> response = await collection.GetIfExistsAsync(circuitName);
            ExpressRouteCircuitResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteCircuitData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create ExpressRouteCircuit
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateExpressRouteCircuit()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitCreate.json
            // this example is just showing the usage of "ExpressRouteCircuits_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCircuitResource
            ExpressRouteCircuitCollection collection = resourceGroupResource.GetExpressRouteCircuits();

            // invoke the operation
            string circuitName = "circuitName";
            ExpressRouteCircuitData data = new ExpressRouteCircuitData()
            {
                Sku = new ExpressRouteCircuitSku()
                {
                    Name = "Standard_MeteredData",
                    Tier = ExpressRouteCircuitSkuTier.Standard,
                    Family = ExpressRouteCircuitSkuFamily.MeteredData,
                },
                AllowClassicOperations = false,
                Authorizations =
{
},
                Peerings =
{
},
                ServiceProviderProperties = new ExpressRouteCircuitServiceProviderProperties()
                {
                    ServiceProviderName = "Equinix",
                    PeeringLocation = "Silicon Valley",
                    BandwidthInMbps = 200,
                },
                Location = new AzureLocation("Brazil South"),
            };
            ArmOperation<ExpressRouteCircuitResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, circuitName, data);
            ExpressRouteCircuitResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create ExpressRouteCircuit on ExpressRoutePort
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateExpressRouteCircuitOnExpressRoutePort()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitCreateOnExpressRoutePort.json
            // this example is just showing the usage of "ExpressRouteCircuits_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCircuitResource
            ExpressRouteCircuitCollection collection = resourceGroupResource.GetExpressRouteCircuits();

            // invoke the operation
            string circuitName = "expressRouteCircuit1";
            ExpressRouteCircuitData data = new ExpressRouteCircuitData()
            {
                Sku = new ExpressRouteCircuitSku()
                {
                    Name = "Premium_MeteredData",
                    Tier = ExpressRouteCircuitSkuTier.Premium,
                    Family = ExpressRouteCircuitSkuFamily.MeteredData,
                },
                ExpressRoutePortId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/expressRoutePorts/portName"),
                BandwidthInGbps = 10,
                AuthorizationKey = "b0be57f5-1fba-463b-adec-ffe767354cdd",
                EnableDirectPortRateLimit = false,
                Location = new AzureLocation("westus"),
            };
            ArmOperation<ExpressRouteCircuitResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, circuitName, data);
            ExpressRouteCircuitResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List ExpressRouteCircuits in a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListExpressRouteCircuitsInAResourceGroup()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitListByResourceGroup.json
            // this example is just showing the usage of "ExpressRouteCircuits_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ExpressRouteCircuitResource
            ExpressRouteCircuitCollection collection = resourceGroupResource.GetExpressRouteCircuits();

            // invoke the operation and iterate over the result
            await foreach (ExpressRouteCircuitResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteCircuitData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
