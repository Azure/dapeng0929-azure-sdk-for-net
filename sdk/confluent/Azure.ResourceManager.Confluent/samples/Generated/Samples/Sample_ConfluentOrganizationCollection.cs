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
using Azure.ResourceManager.Confluent;
using Azure.ResourceManager.Confluent.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Confluent.Samples
{
    public partial class Sample_ConfluentOrganizationCollection
    {
        // Organization_ListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_OrganizationListByResourceGroup()
        {
            // Generated from example definition: specification/confluent/resource-manager/Microsoft.Confluent/stable/2023-08-22/examples/Organization_ListByResourceGroup.json
            // this example is just showing the usage of "Organization_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfluentOrganizationResource
            ConfluentOrganizationCollection collection = resourceGroupResource.GetConfluentOrganizations();

            // invoke the operation and iterate over the result
            await foreach (ConfluentOrganizationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConfluentOrganizationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Organization_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_OrganizationGet()
        {
            // Generated from example definition: specification/confluent/resource-manager/Microsoft.Confluent/stable/2023-08-22/examples/Organization_Get.json
            // this example is just showing the usage of "Organization_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfluentOrganizationResource
            ConfluentOrganizationCollection collection = resourceGroupResource.GetConfluentOrganizations();

            // invoke the operation
            string organizationName = "myOrganization";
            ConfluentOrganizationResource result = await collection.GetAsync(organizationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfluentOrganizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Organization_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_OrganizationGet()
        {
            // Generated from example definition: specification/confluent/resource-manager/Microsoft.Confluent/stable/2023-08-22/examples/Organization_Get.json
            // this example is just showing the usage of "Organization_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfluentOrganizationResource
            ConfluentOrganizationCollection collection = resourceGroupResource.GetConfluentOrganizations();

            // invoke the operation
            string organizationName = "myOrganization";
            bool result = await collection.ExistsAsync(organizationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Organization_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_OrganizationGet()
        {
            // Generated from example definition: specification/confluent/resource-manager/Microsoft.Confluent/stable/2023-08-22/examples/Organization_Get.json
            // this example is just showing the usage of "Organization_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfluentOrganizationResource
            ConfluentOrganizationCollection collection = resourceGroupResource.GetConfluentOrganizations();

            // invoke the operation
            string organizationName = "myOrganization";
            NullableResponse<ConfluentOrganizationResource> response = await collection.GetIfExistsAsync(organizationName);
            ConfluentOrganizationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConfluentOrganizationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Organization_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_OrganizationCreate()
        {
            // Generated from example definition: specification/confluent/resource-manager/Microsoft.Confluent/stable/2023-08-22/examples/Organization_Create.json
            // this example is just showing the usage of "Organization_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfluentOrganizationResource
            ConfluentOrganizationCollection collection = resourceGroupResource.GetConfluentOrganizations();

            // invoke the operation
            string organizationName = "myOrganization";
            ConfluentOrganizationData data = new ConfluentOrganizationData(new AzureLocation("West US"), new ConfluentOfferDetail("string", "string", "string", "string", "string")
            {
                PrivateOfferId = "string",
                PrivateOfferIds =
{
"string"
},
            }, new ConfluentUserDetail("contoso@microsoft.com")
            {
                FirstName = "string",
                LastName = "string",
                UserPrincipalName = "contoso@microsoft.com",
                AadEmail = "contoso@microsoft.com",
            })
            {
                LinkOrganizationToken = "string",
                Tags =
{
["Environment"] = "Dev",
},
            };
            ArmOperation<ConfluentOrganizationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, organizationName, data);
            ConfluentOrganizationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfluentOrganizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
