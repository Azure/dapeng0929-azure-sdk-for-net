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
    public partial class Sample_FrontendIPConfigurationCollection
    {
        // LoadBalancerFrontendIPConfigurationList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_LoadBalancerFrontendIPConfigurationList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/LoadBalancerFrontendIPConfigurationList.json
            // this example is just showing the usage of "LoadBalancerFrontendIPConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // get the collection of this FrontendIPConfigurationResource
            FrontendIPConfigurationCollection collection = loadBalancer.GetFrontendIPConfigurations();

            // invoke the operation and iterate over the result
            await foreach (FrontendIPConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontendIPConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // LoadBalancerFrontendIPConfigurationGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_LoadBalancerFrontendIPConfigurationGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/LoadBalancerFrontendIPConfigurationGet.json
            // this example is just showing the usage of "LoadBalancerFrontendIPConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // get the collection of this FrontendIPConfigurationResource
            FrontendIPConfigurationCollection collection = loadBalancer.GetFrontendIPConfigurations();

            // invoke the operation
            string frontendIPConfigurationName = "frontend";
            FrontendIPConfigurationResource result = await collection.GetAsync(frontendIPConfigurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontendIPConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // LoadBalancerFrontendIPConfigurationGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_LoadBalancerFrontendIPConfigurationGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/LoadBalancerFrontendIPConfigurationGet.json
            // this example is just showing the usage of "LoadBalancerFrontendIPConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // get the collection of this FrontendIPConfigurationResource
            FrontendIPConfigurationCollection collection = loadBalancer.GetFrontendIPConfigurations();

            // invoke the operation
            string frontendIPConfigurationName = "frontend";
            bool result = await collection.ExistsAsync(frontendIPConfigurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // LoadBalancerFrontendIPConfigurationGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_LoadBalancerFrontendIPConfigurationGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/LoadBalancerFrontendIPConfigurationGet.json
            // this example is just showing the usage of "LoadBalancerFrontendIPConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this LoadBalancerResource created on azure
            // for more information of creating LoadBalancerResource, please refer to the document of LoadBalancerResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string loadBalancerName = "lb";
            ResourceIdentifier loadBalancerResourceId = LoadBalancerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, loadBalancerName);
            LoadBalancerResource loadBalancer = client.GetLoadBalancerResource(loadBalancerResourceId);

            // get the collection of this FrontendIPConfigurationResource
            FrontendIPConfigurationCollection collection = loadBalancer.GetFrontendIPConfigurations();

            // invoke the operation
            string frontendIPConfigurationName = "frontend";
            NullableResponse<FrontendIPConfigurationResource> response = await collection.GetIfExistsAsync(frontendIPConfigurationName);
            FrontendIPConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FrontendIPConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
