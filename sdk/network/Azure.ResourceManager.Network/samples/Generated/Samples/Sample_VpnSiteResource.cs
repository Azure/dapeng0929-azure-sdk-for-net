// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VpnSiteResource
    {
        // VpnSiteGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VpnSiteGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VpnSiteGet.json
            // this example is just showing the usage of "VpnSites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnSiteResource created on azure
            // for more information of creating VpnSiteResource, please refer to the document of VpnSiteResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnSiteName = "vpnSite1";
            ResourceIdentifier vpnSiteResourceId = VpnSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnSiteName);
            VpnSiteResource vpnSite = client.GetVpnSiteResource(vpnSiteResourceId);

            // invoke the operation
            VpnSiteResource result = await vpnSite.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VpnSiteUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_VpnSiteUpdate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VpnSiteUpdateTags.json
            // this example is just showing the usage of "VpnSites_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnSiteResource created on azure
            // for more information of creating VpnSiteResource, please refer to the document of VpnSiteResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnSiteName = "vpnSite1";
            ResourceIdentifier vpnSiteResourceId = VpnSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnSiteName);
            VpnSiteResource vpnSite = client.GetVpnSiteResource(vpnSiteResourceId);

            // invoke the operation
            NetworkTagsObject vpnSiteParameters = new NetworkTagsObject()
            {
                Tags =
{
["key1"] = "value1",
["key2"] = "value2",
},
            };
            VpnSiteResource result = await vpnSite.UpdateAsync(vpnSiteParameters);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VpnSiteDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_VpnSiteDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VpnSiteDelete.json
            // this example is just showing the usage of "VpnSites_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnSiteResource created on azure
            // for more information of creating VpnSiteResource, please refer to the document of VpnSiteResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string vpnSiteName = "vpnSite1";
            ResourceIdentifier vpnSiteResourceId = VpnSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vpnSiteName);
            VpnSiteResource vpnSite = client.GetVpnSiteResource(vpnSiteResourceId);

            // invoke the operation
            await vpnSite.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // VpnSiteList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVpnSites_VpnSiteList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VpnSiteList.json
            // this example is just showing the usage of "VpnSites_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VpnSiteResource item in subscriptionResource.GetVpnSitesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VpnSiteData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
