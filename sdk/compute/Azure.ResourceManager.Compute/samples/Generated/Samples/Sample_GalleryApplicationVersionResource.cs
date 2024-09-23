// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_GalleryApplicationVersionResource
    {
        // Update a simple gallery Application Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateASimpleGalleryApplicationVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryExamples/GalleryApplicationVersion_Update.json
            // this example is just showing the usage of "GalleryApplicationVersions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryApplicationVersionResource created on azure
            // for more information of creating GalleryApplicationVersionResource, please refer to the document of GalleryApplicationVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryApplicationName = "myGalleryApplicationName";
            string galleryApplicationVersionName = "1.0.0";
            ResourceIdentifier galleryApplicationVersionResourceId = GalleryApplicationVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName);
            GalleryApplicationVersionResource galleryApplicationVersion = client.GetGalleryApplicationVersionResource(galleryApplicationVersionResourceId);

            // invoke the operation
            GalleryApplicationVersionPatch patch = new GalleryApplicationVersionPatch()
            {
                PublishingProfile = new GalleryApplicationVersionPublishingProfile(new UserArtifactSource("https://mystorageaccount.blob.core.windows.net/mycontainer/package.zip?{sasKey}"))
                {
                    ManageActions = new UserArtifactManagement("powershell -command \"Expand-Archive -Path package.zip -DestinationPath C:\\package\"", "del C:\\package "),
                    TargetRegions =
{
new TargetRegion("West US")
{
RegionalReplicaCount = 1,
StorageAccountType = ImageStorageAccountType.StandardLrs,
IsExcludedFromLatest = false,
}
},
                    ReplicaCount = 1,
                    EndOfLifeOn = DateTimeOffset.Parse("2019-07-01T07:00:00Z"),
                    StorageAccountType = ImageStorageAccountType.StandardLrs,
                },
                AllowDeletionOfReplicatedLocations = false,
            };
            ArmOperation<GalleryApplicationVersionResource> lro = await galleryApplicationVersion.UpdateAsync(WaitUntil.Completed, patch);
            GalleryApplicationVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryApplicationVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a gallery Application Version with replication status.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAGalleryApplicationVersionWithReplicationStatus()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryExamples/GalleryApplicationVersion_Get_WithReplicationStatus.json
            // this example is just showing the usage of "GalleryApplicationVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryApplicationVersionResource created on azure
            // for more information of creating GalleryApplicationVersionResource, please refer to the document of GalleryApplicationVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryApplicationName = "myGalleryApplicationName";
            string galleryApplicationVersionName = "1.0.0";
            ResourceIdentifier galleryApplicationVersionResourceId = GalleryApplicationVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName);
            GalleryApplicationVersionResource galleryApplicationVersion = client.GetGalleryApplicationVersionResource(galleryApplicationVersionResourceId);

            // invoke the operation
            ReplicationStatusType? expand = ReplicationStatusType.ReplicationStatus;
            GalleryApplicationVersionResource result = await galleryApplicationVersion.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryApplicationVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a gallery Application Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAGalleryApplicationVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryExamples/GalleryApplicationVersion_Get.json
            // this example is just showing the usage of "GalleryApplicationVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryApplicationVersionResource created on azure
            // for more information of creating GalleryApplicationVersionResource, please refer to the document of GalleryApplicationVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryApplicationName = "myGalleryApplicationName";
            string galleryApplicationVersionName = "1.0.0";
            ResourceIdentifier galleryApplicationVersionResourceId = GalleryApplicationVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName);
            GalleryApplicationVersionResource galleryApplicationVersion = client.GetGalleryApplicationVersionResource(galleryApplicationVersionResourceId);

            // invoke the operation
            GalleryApplicationVersionResource result = await galleryApplicationVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryApplicationVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a gallery Application Version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAGalleryApplicationVersion()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2024-03-03/examples/galleryExamples/GalleryApplicationVersion_Delete.json
            // this example is just showing the usage of "GalleryApplicationVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this GalleryApplicationVersionResource created on azure
            // for more information of creating GalleryApplicationVersionResource, please refer to the document of GalleryApplicationVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryApplicationName = "myGalleryApplicationName";
            string galleryApplicationVersionName = "1.0.0";
            ResourceIdentifier galleryApplicationVersionResourceId = GalleryApplicationVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName);
            GalleryApplicationVersionResource galleryApplicationVersion = client.GetGalleryApplicationVersionResource(galleryApplicationVersionResourceId);

            // invoke the operation
            await galleryApplicationVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
