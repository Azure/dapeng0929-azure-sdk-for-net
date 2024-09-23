// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ExpressRouteCircuitAuthorizationResource
    {
        // Delete ExpressRouteCircuit Authorization
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteExpressRouteCircuitAuthorization()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitAuthorizationDelete.json
            // this example is just showing the usage of "ExpressRouteCircuitAuthorizations_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitAuthorizationResource created on azure
            // for more information of creating ExpressRouteCircuitAuthorizationResource, please refer to the document of ExpressRouteCircuitAuthorizationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string authorizationName = "authorizationName";
            ResourceIdentifier expressRouteCircuitAuthorizationResourceId = ExpressRouteCircuitAuthorizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, authorizationName);
            ExpressRouteCircuitAuthorizationResource expressRouteCircuitAuthorization = client.GetExpressRouteCircuitAuthorizationResource(expressRouteCircuitAuthorizationResourceId);

            // invoke the operation
            await expressRouteCircuitAuthorization.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get ExpressRouteCircuit Authorization
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetExpressRouteCircuitAuthorization()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitAuthorizationGet.json
            // this example is just showing the usage of "ExpressRouteCircuitAuthorizations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitAuthorizationResource created on azure
            // for more information of creating ExpressRouteCircuitAuthorizationResource, please refer to the document of ExpressRouteCircuitAuthorizationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string authorizationName = "authorizationName";
            ResourceIdentifier expressRouteCircuitAuthorizationResourceId = ExpressRouteCircuitAuthorizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, authorizationName);
            ExpressRouteCircuitAuthorizationResource expressRouteCircuitAuthorization = client.GetExpressRouteCircuitAuthorizationResource(expressRouteCircuitAuthorizationResourceId);

            // invoke the operation
            ExpressRouteCircuitAuthorizationResource result = await expressRouteCircuitAuthorization.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitAuthorizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create ExpressRouteCircuit Authorization
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateExpressRouteCircuitAuthorization()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteCircuitAuthorizationCreate.json
            // this example is just showing the usage of "ExpressRouteCircuitAuthorizations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRouteCircuitAuthorizationResource created on azure
            // for more information of creating ExpressRouteCircuitAuthorizationResource, please refer to the document of ExpressRouteCircuitAuthorizationResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string circuitName = "circuitName";
            string authorizationName = "authorizatinName";
            ResourceIdentifier expressRouteCircuitAuthorizationResourceId = ExpressRouteCircuitAuthorizationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, circuitName, authorizationName);
            ExpressRouteCircuitAuthorizationResource expressRouteCircuitAuthorization = client.GetExpressRouteCircuitAuthorizationResource(expressRouteCircuitAuthorizationResourceId);

            // invoke the operation
            ExpressRouteCircuitAuthorizationData data = new ExpressRouteCircuitAuthorizationData();
            ArmOperation<ExpressRouteCircuitAuthorizationResource> lro = await expressRouteCircuitAuthorization.UpdateAsync(WaitUntil.Completed, data);
            ExpressRouteCircuitAuthorizationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteCircuitAuthorizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
