// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_ResourceGroupResourceExtensions
    {
        // List ResourceHealthMetadata for a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAllResourceHealthMetadataData_ListResourceHealthMetadataForAResourceGroup()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-01-01/examples/ListResourceHealthMetadataByResourceGroup.json
            // this example is just showing the usage of "ResourceHealthMetadata_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "4adb32ad-8327-4cbb-b775-b84b4465bb38";
            string resourceGroupName = "Default-Web-NorthCentralUS";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // invoke the operation and iterate over the result
            await foreach (ResourceHealthMetadataData item in resourceGroupResource.GetAllResourceHealthMetadataDataAsync())
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
