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
using Azure.ResourceManager.CognitiveServices;
using Azure.ResourceManager.CognitiveServices.Models;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_CognitiveServicesAccountDeploymentCollection
    {
        // ListDeployments
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDeployments()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/ListDeployments.json
            // this example is just showing the usage of "Deployments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // get the collection of this CognitiveServicesAccountDeploymentResource
            CognitiveServicesAccountDeploymentCollection collection = cognitiveServicesAccount.GetCognitiveServicesAccountDeployments();

            // invoke the operation and iterate over the result
            await foreach (CognitiveServicesAccountDeploymentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CognitiveServicesAccountDeploymentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // GetDeployment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDeployment()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/GetDeployment.json
            // this example is just showing the usage of "Deployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // get the collection of this CognitiveServicesAccountDeploymentResource
            CognitiveServicesAccountDeploymentCollection collection = cognitiveServicesAccount.GetCognitiveServicesAccountDeployments();

            // invoke the operation
            string deploymentName = "deploymentName";
            CognitiveServicesAccountDeploymentResource result = await collection.GetAsync(deploymentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesAccountDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetDeployment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetDeployment()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/GetDeployment.json
            // this example is just showing the usage of "Deployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // get the collection of this CognitiveServicesAccountDeploymentResource
            CognitiveServicesAccountDeploymentCollection collection = cognitiveServicesAccount.GetCognitiveServicesAccountDeployments();

            // invoke the operation
            string deploymentName = "deploymentName";
            bool result = await collection.ExistsAsync(deploymentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetDeployment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetDeployment()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/GetDeployment.json
            // this example is just showing the usage of "Deployments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // get the collection of this CognitiveServicesAccountDeploymentResource
            CognitiveServicesAccountDeploymentCollection collection = cognitiveServicesAccount.GetCognitiveServicesAccountDeployments();

            // invoke the operation
            string deploymentName = "deploymentName";
            NullableResponse<CognitiveServicesAccountDeploymentResource> response = await collection.GetIfExistsAsync(deploymentName);
            CognitiveServicesAccountDeploymentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CognitiveServicesAccountDeploymentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PutDeployment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutDeployment()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/preview/2023-10-01-preview/examples/PutDeployment.json
            // this example is just showing the usage of "Deployments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesAccountResource created on azure
            // for more information of creating CognitiveServicesAccountResource, please refer to the document of CognitiveServicesAccountResource
            string subscriptionId = "subscriptionId";
            string resourceGroupName = "resourceGroupName";
            string accountName = "accountName";
            ResourceIdentifier cognitiveServicesAccountResourceId = CognitiveServicesAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            CognitiveServicesAccountResource cognitiveServicesAccount = client.GetCognitiveServicesAccountResource(cognitiveServicesAccountResourceId);

            // get the collection of this CognitiveServicesAccountDeploymentResource
            CognitiveServicesAccountDeploymentCollection collection = cognitiveServicesAccount.GetCognitiveServicesAccountDeployments();

            // invoke the operation
            string deploymentName = "deploymentName";
            CognitiveServicesAccountDeploymentData data = new CognitiveServicesAccountDeploymentData()
            {
                Sku = new CognitiveServicesSku("Standard")
                {
                    Capacity = 1,
                },
                Properties = new CognitiveServicesAccountDeploymentProperties()
                {
                    Model = new CognitiveServicesAccountDeploymentModel()
                    {
                        Format = "OpenAI",
                        Name = "ada",
                        Version = "1",
                    },
                },
            };
            ArmOperation<CognitiveServicesAccountDeploymentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, deploymentName, data);
            CognitiveServicesAccountDeploymentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesAccountDeploymentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
