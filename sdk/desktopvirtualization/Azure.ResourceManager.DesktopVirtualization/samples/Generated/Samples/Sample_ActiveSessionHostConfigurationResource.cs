// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_ActiveSessionHostConfigurationResource
    {
        // SessionHostConfigurations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SessionHostConfigurationsGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2024-08-08-preview/examples/ActiveSessionHostConfigurations_Get.json
            // this example is just showing the usage of "ActiveSessionHostConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ActiveSessionHostConfigurationResource created on azure
            // for more information of creating ActiveSessionHostConfigurationResource, please refer to the document of ActiveSessionHostConfigurationResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier activeSessionHostConfigurationResourceId = ActiveSessionHostConfigurationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            ActiveSessionHostConfigurationResource activeSessionHostConfiguration = client.GetActiveSessionHostConfigurationResource(activeSessionHostConfigurationResourceId);

            // invoke the operation
            ActiveSessionHostConfigurationResource result = await activeSessionHostConfiguration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ActiveSessionHostConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
