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
    public partial class Sample_MeshUpgradeProfileResource
    {
        // Gets version compatibility and upgrade profile for a service mesh in a cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsVersionCompatibilityAndUpgradeProfileForAServiceMeshInACluster()
        {
            // Generated from example definition: specification/containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2024-09-02-preview/examples/ManagedClustersGet_MeshUpgradeProfile.json
            // this example is just showing the usage of "ManagedClusters_GetMeshUpgradeProfile" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MeshUpgradeProfileResource created on azure
            // for more information of creating MeshUpgradeProfileResource, please refer to the document of MeshUpgradeProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string resourceName = "clustername1";
            string mode = "istio";
            ResourceIdentifier meshUpgradeProfileResourceId = MeshUpgradeProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName, mode);
            MeshUpgradeProfileResource meshUpgradeProfile = client.GetMeshUpgradeProfileResource(meshUpgradeProfileResourceId);

            // invoke the operation
            MeshUpgradeProfileResource result = await meshUpgradeProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MeshUpgradeProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
