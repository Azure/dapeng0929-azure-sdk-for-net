// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.TrustedSigning.Models;

namespace Azure.ResourceManager.TrustedSigning.Samples
{
    public partial class Sample_TrustedSigningCertificateProfileResource
    {
        // Get details of a certificate profile.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDetailsOfACertificateProfile()
        {
            // Generated from example definition: specification/codesigning/resource-manager/Microsoft.CodeSigning/preview/2024-09-30-preview/examples/CertificateProfiles_Get.json
            // this example is just showing the usage of "CertificateProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrustedSigningCertificateProfileResource created on azure
            // for more information of creating TrustedSigningCertificateProfileResource, please refer to the document of TrustedSigningCertificateProfileResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "MyResourceGroup";
            string accountName = "MyAccount";
            string profileName = "profileA";
            ResourceIdentifier trustedSigningCertificateProfileResourceId = TrustedSigningCertificateProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, profileName);
            TrustedSigningCertificateProfileResource trustedSigningCertificateProfile = client.GetTrustedSigningCertificateProfileResource(trustedSigningCertificateProfileResourceId);

            // invoke the operation
            TrustedSigningCertificateProfileResource result = await trustedSigningCertificateProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrustedSigningCertificateProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a certificate profile.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateACertificateProfile()
        {
            // Generated from example definition: specification/codesigning/resource-manager/Microsoft.CodeSigning/preview/2024-09-30-preview/examples/CertificateProfiles_Create.json
            // this example is just showing the usage of "CertificateProfiles_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrustedSigningCertificateProfileResource created on azure
            // for more information of creating TrustedSigningCertificateProfileResource, please refer to the document of TrustedSigningCertificateProfileResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "MyResourceGroup";
            string accountName = "MyAccount";
            string profileName = "profileA";
            ResourceIdentifier trustedSigningCertificateProfileResourceId = TrustedSigningCertificateProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, profileName);
            TrustedSigningCertificateProfileResource trustedSigningCertificateProfile = client.GetTrustedSigningCertificateProfileResource(trustedSigningCertificateProfileResourceId);

            // invoke the operation
            TrustedSigningCertificateProfileData data = new TrustedSigningCertificateProfileData()
            {
                ProfileType = CertificateProfileType.PublicTrust,
                IncludeStreetAddress = false,
                IncludePostalCode = true,
                IdentityValidationId = "00000000-1234-5678-3333-444444444444",
            };
            ArmOperation<TrustedSigningCertificateProfileResource> lro = await trustedSigningCertificateProfile.UpdateAsync(WaitUntil.Completed, data);
            TrustedSigningCertificateProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrustedSigningCertificateProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a certificate profile.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteACertificateProfile()
        {
            // Generated from example definition: specification/codesigning/resource-manager/Microsoft.CodeSigning/preview/2024-09-30-preview/examples/CertificateProfiles_Delete.json
            // this example is just showing the usage of "CertificateProfiles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrustedSigningCertificateProfileResource created on azure
            // for more information of creating TrustedSigningCertificateProfileResource, please refer to the document of TrustedSigningCertificateProfileResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "MyResourceGroup";
            string accountName = "MyAccount";
            string profileName = "profileA";
            ResourceIdentifier trustedSigningCertificateProfileResourceId = TrustedSigningCertificateProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, profileName);
            TrustedSigningCertificateProfileResource trustedSigningCertificateProfile = client.GetTrustedSigningCertificateProfileResource(trustedSigningCertificateProfileResourceId);

            // invoke the operation
            await trustedSigningCertificateProfile.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Revoke a certificate under a certificate profile.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RevokeCertificate_RevokeACertificateUnderACertificateProfile()
        {
            // Generated from example definition: specification/codesigning/resource-manager/Microsoft.CodeSigning/preview/2024-09-30-preview/examples/CertificateProfiles_RevokeCertificate.json
            // this example is just showing the usage of "CertificateProfiles_RevokeCertificate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrustedSigningCertificateProfileResource created on azure
            // for more information of creating TrustedSigningCertificateProfileResource, please refer to the document of TrustedSigningCertificateProfileResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "MyResourceGroup";
            string accountName = "MyAccount";
            string profileName = "profileA";
            ResourceIdentifier trustedSigningCertificateProfileResourceId = TrustedSigningCertificateProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, profileName);
            TrustedSigningCertificateProfileResource trustedSigningCertificateProfile = client.GetTrustedSigningCertificateProfileResource(trustedSigningCertificateProfileResourceId);

            // invoke the operation
            RevokeCertificateContent content = new RevokeCertificateContent("xxxxxxxxxxxxxxxxxx", "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", DateTimeOffset.Parse("2023-11-12T23:40:25+00:00"), "KeyCompromised")
            {
                Remarks = "test",
            };
            await trustedSigningCertificateProfile.RevokeCertificateAsync(content);

            Console.WriteLine($"Succeeded");
        }
    }
}
