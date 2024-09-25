// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_HostPoolCollection
    {
        // HostPool_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_HostPoolGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2024-08-08-preview/examples/HostPool_Get.json
            // this example is just showing the usage of "HostPools_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this HostPoolResource
            HostPoolCollection collection = resourceGroupResource.GetHostPools();

            // invoke the operation
            string hostPoolName = "hostPool1";
            HostPoolResource result = await collection.GetAsync(hostPoolName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HostPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HostPool_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_HostPoolGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2024-08-08-preview/examples/HostPool_Get.json
            // this example is just showing the usage of "HostPools_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this HostPoolResource
            HostPoolCollection collection = resourceGroupResource.GetHostPools();

            // invoke the operation
            string hostPoolName = "hostPool1";
            bool result = await collection.ExistsAsync(hostPoolName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // HostPool_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_HostPoolGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2024-08-08-preview/examples/HostPool_Get.json
            // this example is just showing the usage of "HostPools_Get" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this HostPoolResource
            HostPoolCollection collection = resourceGroupResource.GetHostPools();

            // invoke the operation
            string hostPoolName = "hostPool1";
            NullableResponse<HostPoolResource> response = await collection.GetIfExistsAsync(hostPoolName);
            HostPoolResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HostPoolData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // HostPool_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_HostPoolCreate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2024-08-08-preview/examples/HostPool_Create.json
            // this example is just showing the usage of "HostPools_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this HostPoolResource
            HostPoolCollection collection = resourceGroupResource.GetHostPools();

            // invoke the operation
            string hostPoolName = "hostPool1";
            HostPoolData data = new HostPoolData(new AzureLocation("centralus"), HostPoolType.Pooled, HostPoolLoadBalancerType.BreadthFirst, PreferredAppGroupType.Desktop)
            {
                FriendlyName = "friendly",
                Description = "des1",
                PersonalDesktopAssignmentType = PersonalDesktopAssignmentType.Automatic,
                CustomRdpProperty = null,
                MaxSessionLimit = 999999,
                RegistrationInfo = new HostPoolRegistrationInfo()
                {
                    ExpireOn = DateTimeOffset.Parse("2020-10-01T14:01:54.9571247Z"),
                    RegistrationTokenOperation = HostPoolRegistrationTokenOperation.Update,
                },
                VmTemplate = "{json:json}",
                ManagementType = ManagementType.Automated,
                SsoAdfsAuthority = "https://adfs",
                SsoClientId = "client",
                SsoClientSecretKeyVaultPath = "https://keyvault/secret",
                SsoSecretType = HostPoolSsoSecretType.SharedKey,
                StartVmOnConnect = false,
                AgentUpdate = new SessionHostAgentUpdateProperties()
                {
                    UpdateType = SessionHostComponentUpdateType.Scheduled,
                    DoesUseSessionHostLocalTime = false,
                    MaintenanceWindowTimeZone = "Alaskan Standard Time",
                    MaintenanceWindows =
{
new SessionHostMaintenanceWindowProperties()
{
Hour = 7,
DayOfWeek = DesktopVirtualizationDayOfWeek.Friday,
},new SessionHostMaintenanceWindowProperties()
{
Hour = 8,
DayOfWeek = DesktopVirtualizationDayOfWeek.Saturday,
}
},
                },
                ManagedPrivateUDP = ManagedPrivateUDP.Enabled,
                DirectUDP = DirectUDP.Enabled,
                PublicUDP = PublicUDP.Enabled,
                RelayUDP = RelayUDP.Enabled,
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<HostPoolResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, hostPoolName, data);
            HostPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HostPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HostPool_ListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_HostPoolListByResourceGroup()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2024-08-08-preview/examples/HostPool_ListByResourceGroup.json
            // this example is just showing the usage of "HostPools_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

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

            // get the collection of this HostPoolResource
            HostPoolCollection collection = resourceGroupResource.GetHostPools();

            // invoke the operation and iterate over the result
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (HostPoolResource item in collection.GetAllAsync(pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HostPoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
