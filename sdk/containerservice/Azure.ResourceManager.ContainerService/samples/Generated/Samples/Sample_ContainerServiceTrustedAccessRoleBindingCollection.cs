// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ContainerService.Samples
{
    public partial class Sample_ContainerServiceTrustedAccessRoleBindingCollection
    {
        // List trusted access role bindings
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListTrustedAccessRoleBindings()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2024-06-02-preview/examples/TrustedAccessRoleBindings_List.json
            // this example is just showing the usage of "TrustedAccessRoleBindings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceTrustedAccessRoleBindingResource
            ContainerServiceTrustedAccessRoleBindingCollection collection = containerServiceManagedCluster.GetContainerServiceTrustedAccessRoleBindings();

            // invoke the operation and iterate over the result
            await foreach (ContainerServiceTrustedAccessRoleBindingResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceTrustedAccessRoleBindingData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a trusted access role binding
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetATrustedAccessRoleBinding()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2024-06-02-preview/examples/TrustedAccessRoleBindings_Get.json
            // this example is just showing the usage of "TrustedAccessRoleBindings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceTrustedAccessRoleBindingResource
            ContainerServiceTrustedAccessRoleBindingCollection collection = containerServiceManagedCluster.GetContainerServiceTrustedAccessRoleBindings();

            // invoke the operation
            string trustedAccessRoleBindingName = "binding1";
            ContainerServiceTrustedAccessRoleBindingResource result = await collection.GetAsync(trustedAccessRoleBindingName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceTrustedAccessRoleBindingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a trusted access role binding
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetATrustedAccessRoleBinding()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2024-06-02-preview/examples/TrustedAccessRoleBindings_Get.json
            // this example is just showing the usage of "TrustedAccessRoleBindings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceTrustedAccessRoleBindingResource
            ContainerServiceTrustedAccessRoleBindingCollection collection = containerServiceManagedCluster.GetContainerServiceTrustedAccessRoleBindings();

            // invoke the operation
            string trustedAccessRoleBindingName = "binding1";
            bool result = await collection.ExistsAsync(trustedAccessRoleBindingName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a trusted access role binding
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetATrustedAccessRoleBinding()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2024-06-02-preview/examples/TrustedAccessRoleBindings_Get.json
            // this example is just showing the usage of "TrustedAccessRoleBindings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceTrustedAccessRoleBindingResource
            ContainerServiceTrustedAccessRoleBindingCollection collection = containerServiceManagedCluster.GetContainerServiceTrustedAccessRoleBindings();

            // invoke the operation
            string trustedAccessRoleBindingName = "binding1";
            NullableResponse<ContainerServiceTrustedAccessRoleBindingResource> response = await collection.GetIfExistsAsync(trustedAccessRoleBindingName);
            ContainerServiceTrustedAccessRoleBindingResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ContainerServiceTrustedAccessRoleBindingData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update a trusted access role binding
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateATrustedAccessRoleBinding()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2024-06-02-preview/examples/TrustedAccessRoleBindings_CreateOrUpdate.json
            // this example is just showing the usage of "TrustedAccessRoleBindings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerServiceManagedClusterResource created on azure
            // for more information of creating ContainerServiceManagedClusterResource, please refer to the document of ContainerServiceManagedClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            ResourceIdentifier containerServiceManagedClusterResourceId = ContainerServiceManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            ContainerServiceManagedClusterResource containerServiceManagedCluster = client.GetContainerServiceManagedClusterResource(containerServiceManagedClusterResourceId);

            // get the collection of this ContainerServiceTrustedAccessRoleBindingResource
            ContainerServiceTrustedAccessRoleBindingCollection collection = containerServiceManagedCluster.GetContainerServiceTrustedAccessRoleBindings();

            // invoke the operation
            string trustedAccessRoleBindingName = "binding1";
            ContainerServiceTrustedAccessRoleBindingData data = new ContainerServiceTrustedAccessRoleBindingData(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/b/providers/Microsoft.MachineLearningServices/workspaces/c"), new string[]
            {
"Microsoft.MachineLearningServices/workspaces/reader","Microsoft.MachineLearningServices/workspaces/writer"
            });
            ArmOperation<ContainerServiceTrustedAccessRoleBindingResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, trustedAccessRoleBindingName, data);
            ContainerServiceTrustedAccessRoleBindingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerServiceTrustedAccessRoleBindingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
