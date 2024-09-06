// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_KubeEnvironmentResource
    {
        // List kube environments by subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetKubeEnvironments_ListKubeEnvironmentsBySubscription()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/KubeEnvironments_ListBySubscription.json
            // this example is just showing the usage of "KubeEnvironments_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (KubeEnvironmentResource item in subscriptionResource.GetKubeEnvironmentsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                KubeEnvironmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get kube environments by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetKubeEnvironmentsByName()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/KubeEnvironments_Get.json
            // this example is just showing the usage of "KubeEnvironments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KubeEnvironmentResource created on azure
            // for more information of creating KubeEnvironmentResource, please refer to the document of KubeEnvironmentResource
            string subscriptionId = "8efdecc5-919e-44eb-b179-915dca89ebf9";
            string resourceGroupName = "examplerg";
            string name = "jlaw-demo1";
            ResourceIdentifier kubeEnvironmentResourceId = KubeEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            KubeEnvironmentResource kubeEnvironment = client.GetKubeEnvironmentResource(kubeEnvironmentResourceId);

            // invoke the operation
            KubeEnvironmentResource result = await kubeEnvironment.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubeEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete kube environment by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteKubeEnvironmentByName()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/KubeEnvironments_Delete.json
            // this example is just showing the usage of "KubeEnvironments_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KubeEnvironmentResource created on azure
            // for more information of creating KubeEnvironmentResource, please refer to the document of KubeEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string name = "examplekenv";
            ResourceIdentifier kubeEnvironmentResourceId = KubeEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            KubeEnvironmentResource kubeEnvironment = client.GetKubeEnvironmentResource(kubeEnvironmentResourceId);

            // invoke the operation
            await kubeEnvironment.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Update kube environments
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateKubeEnvironments()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/KubeEnvironments_Update.json
            // this example is just showing the usage of "KubeEnvironments_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KubeEnvironmentResource created on azure
            // for more information of creating KubeEnvironmentResource, please refer to the document of KubeEnvironmentResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "examplerg";
            string name = "testkubeenv";
            ResourceIdentifier kubeEnvironmentResourceId = KubeEnvironmentResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            KubeEnvironmentResource kubeEnvironment = client.GetKubeEnvironmentResource(kubeEnvironmentResourceId);

            // invoke the operation
            KubeEnvironmentPatch patch = new KubeEnvironmentPatch()
            {
                StaticIP = "1.2.3.4",
            };
            KubeEnvironmentResource result = await kubeEnvironment.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KubeEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
