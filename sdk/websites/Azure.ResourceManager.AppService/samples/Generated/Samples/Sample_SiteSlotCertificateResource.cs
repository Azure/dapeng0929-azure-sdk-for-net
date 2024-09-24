// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteSlotCertificateResource
    {
        // Get Site Certificate for a slot
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSiteCertificateForASlot()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/GetSiteCertificateSlot.json
            // this example is just showing the usage of "SiteCertificates_GetSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotCertificateResource created on azure
            // for more information of creating SiteSlotCertificateResource, please refer to the document of SiteSlotCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testSiteName";
            string slot = "staging";
            string certificateName = "testc6282";
            ResourceIdentifier siteSlotCertificateResourceId = SiteSlotCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, slot, certificateName);
            SiteSlotCertificateResource siteSlotCertificate = client.GetSiteSlotCertificateResource(siteSlotCertificateResourceId);

            // invoke the operation
            SiteSlotCertificateResource result = await siteSlotCertificate.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Certificate for slot
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteCertificateForSlot()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/DeleteSiteCertificateSlot.json
            // this example is just showing the usage of "SiteCertificates_DeleteSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotCertificateResource created on azure
            // for more information of creating SiteSlotCertificateResource, please refer to the document of SiteSlotCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testSiteName";
            string slot = "staging";
            string certificateName = "testc6282";
            ResourceIdentifier siteSlotCertificateResourceId = SiteSlotCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, slot, certificateName);
            SiteSlotCertificateResource siteSlotCertificate = client.GetSiteSlotCertificateResource(siteSlotCertificateResourceId);

            // invoke the operation
            await siteSlotCertificate.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch Certificate for slot
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchCertificateForSlot()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/PatchSiteCertificateSlot.json
            // this example is just showing the usage of "SiteCertificates_UpdateSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotCertificateResource created on azure
            // for more information of creating SiteSlotCertificateResource, please refer to the document of SiteSlotCertificateResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testrg123";
            string name = "testSiteName";
            string slot = "staging";
            string certificateName = "testc6282";
            ResourceIdentifier siteSlotCertificateResourceId = SiteSlotCertificateResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, slot, certificateName);
            SiteSlotCertificateResource siteSlotCertificate = client.GetSiteSlotCertificateResource(siteSlotCertificateResourceId);

            // invoke the operation
            CertificatePatchResource certificateEnvelope = new CertificatePatchResource()
            {
                KeyVaultId = new ResourceIdentifier("testKVId"),
            };
            SiteSlotCertificateResource result = await siteSlotCertificate.UpdateAsync(certificateEnvelope);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppCertificateData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
