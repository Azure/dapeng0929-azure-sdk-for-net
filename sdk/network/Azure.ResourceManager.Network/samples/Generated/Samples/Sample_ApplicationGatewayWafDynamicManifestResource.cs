// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ApplicationGatewayWafDynamicManifestResource
    {
        // Gets WAF default manifest
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsWAFDefaultManifest()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/GetApplicationGatewayWafDynamicManifestsDefault.json
            // this example is just showing the usage of "ApplicationGatewayWafDynamicManifestsDefault_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ApplicationGatewayWafDynamicManifestResource created on azure
            // for more information of creating ApplicationGatewayWafDynamicManifestResource, please refer to the document of ApplicationGatewayWafDynamicManifestResource
            string subscriptionId = "subid";
            AzureLocation location = new AzureLocation("westus");
            ResourceIdentifier applicationGatewayWafDynamicManifestResourceId = ApplicationGatewayWafDynamicManifestResource.CreateResourceIdentifier(subscriptionId, location);
            ApplicationGatewayWafDynamicManifestResource applicationGatewayWafDynamicManifest = client.GetApplicationGatewayWafDynamicManifestResource(applicationGatewayWafDynamicManifestResourceId);

            // invoke the operation
            ApplicationGatewayWafDynamicManifestResource result = await applicationGatewayWafDynamicManifest.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApplicationGatewayWafDynamicManifestData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
