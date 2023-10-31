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
using Azure.ResourceManager.DesktopVirtualization;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_AppAttachPackageCollection
    {
        // AppAttachPackage_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AppAttachPackageGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/AppAttachPackage_Get.json
            // this example is just showing the usage of "AppAttachPackage_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppAttachPackageResource
            AppAttachPackageCollection collection = resourceGroupResource.GetAppAttachPackages();

            // invoke the operation
            string appAttachPackageName = "packagefullname";
            AppAttachPackageResource result = await collection.GetAsync(appAttachPackageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppAttachPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AppAttachPackage_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_AppAttachPackageGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/AppAttachPackage_Get.json
            // this example is just showing the usage of "AppAttachPackage_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppAttachPackageResource
            AppAttachPackageCollection collection = resourceGroupResource.GetAppAttachPackages();

            // invoke the operation
            string appAttachPackageName = "packagefullname";
            bool result = await collection.ExistsAsync(appAttachPackageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // AppAttachPackage_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_AppAttachPackageGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/AppAttachPackage_Get.json
            // this example is just showing the usage of "AppAttachPackage_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppAttachPackageResource
            AppAttachPackageCollection collection = resourceGroupResource.GetAppAttachPackages();

            // invoke the operation
            string appAttachPackageName = "packagefullname";
            NullableResponse<AppAttachPackageResource> response = await collection.GetIfExistsAsync(appAttachPackageName);
            AppAttachPackageResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppAttachPackageData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // AppAttachPackage_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_AppAttachPackageCreate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/AppAttachPackage_Create.json
            // this example is just showing the usage of "AppAttachPackage_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppAttachPackageResource
            AppAttachPackageCollection collection = resourceGroupResource.GetAppAttachPackages();

            // invoke the operation
            string appAttachPackageName = "msixpackagefullname";
            AppAttachPackageData data = new AppAttachPackageData(new AzureLocation("southcentralus"), new AppAttachPackageProperties()
            {
                Image = new AppAttachPackageInfoProperties()
                {
                    PackageAlias = "msixpackagealias",
                    ImagePath = "imagepath",
                    PackageName = "MsixPackageName",
                    PackageFamilyName = "MsixPackage_FamilyName",
                    PackageFullName = "MsixPackage_FullName",
                    DisplayName = "displayname",
                    PackageRelativePath = "packagerelativepath",
                    IsRegularRegistration = false,
                    IsActive = false,
                    PackageDependencies =
{
new MsixPackageDependencies()
{
DependencyName = "MsixPackage_Dependency_Name",
Publisher = "MsixPackage_Dependency_Publisher",
MinVersion = "packageDep_version",
}
},
                    Version = "packageversion",
                    LastUpdated = DateTimeOffset.Parse("2008-09-22T14:01:54.9571247Z"),
                    PackageApplications =
{
new MsixPackageApplications()
{
AppId = "AppId",
Description = "PackageApplicationDescription",
AppUserModelId = "AppUserModelId",
FriendlyName = "FriendlyName",
IconImageName = "Iconimagename",
RawIcon = BinaryData.FromString("VGhpcyBpcyBhIHN0cmluZyB0byBoYXNo"),
RawPng = BinaryData.FromString("VGhpcyBpcyBhIHN0cmluZyB0byBoYXNo"),
}
},
                    CertificateName = "certName",
                    CertificateExpiry = DateTimeOffset.Parse("2023-01-02T17:18:19.1234567Z"),
                },
                HostPoolReferences =
{
},
                KeyVaultURL = "",
                FailHealthCheckOnStagingFailure = FailHealthCheckOnStagingFailure.NeedsAssistance,
            });
            ArmOperation<AppAttachPackageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, appAttachPackageName, data);
            AppAttachPackageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppAttachPackageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AppAttachPackage_ListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_AppAttachPackageListByResourceGroup()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/AppAttachPackage_ListByResourceGroup.json
            // this example is just showing the usage of "AppAttachPackage_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this AppAttachPackageResource
            AppAttachPackageCollection collection = resourceGroupResource.GetAppAttachPackages();

            // invoke the operation and iterate over the result
            string filter = "HostPoolName eq 'hostpool1'";
            await foreach (AppAttachPackageResource item in collection.GetAllAsync(filter: filter))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppAttachPackageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
