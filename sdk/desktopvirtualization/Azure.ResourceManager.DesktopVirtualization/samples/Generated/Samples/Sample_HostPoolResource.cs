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
    public partial class Sample_HostPoolResource
    {
        // PrivateLinkResources_ListByHostPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPrivateLinkResources_PrivateLinkResourcesListByHostPool()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/PrivateLinkResources_ListByHostPool.json
            // this example is just showing the usage of "PrivateLinkResources_ListByHostPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // invoke the operation and iterate over the result
            await foreach (DesktopVirtualizationPrivateLinkResourceData item in hostPool.GetPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ScalingPlan_ListByHostPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetScalingPlans_ScalingPlanListByHostPool()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/ScalingPlan_ListByHostPool.json
            // this example is just showing the usage of "ScalingPlans_ListByHostPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // invoke the operation and iterate over the result
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (ScalingPlanResource item in hostPool.GetScalingPlansAsync(pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ScalingPlanData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // HostPool_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_HostPoolGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/HostPool_Get.json
            // this example is just showing the usage of "HostPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // invoke the operation
            HostPoolResource result = await hostPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HostPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HostPool_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_HostPoolDelete()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/HostPool_Delete.json
            // this example is just showing the usage of "HostPools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // invoke the operation
            bool? force = true;
            await hostPool.DeleteAsync(WaitUntil.Completed, force: force);

            Console.WriteLine($"Succeeded");
        }

        // HostPool_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_HostPoolUpdate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/HostPool_Update.json
            // this example is just showing the usage of "HostPools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // invoke the operation
            HostPoolPatch patch = new HostPoolPatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
                FriendlyName = "friendly",
                Description = "des1",
                CustomRdpProperty = null,
                MaxSessionLimit = 999999,
                PersonalDesktopAssignmentType = PersonalDesktopAssignmentType.Automatic,
                LoadBalancerType = HostPoolLoadBalancerType.BreadthFirst,
                RegistrationInfo = new HostPoolRegistrationInfoPatch()
                {
                    ExpireOn = DateTimeOffset.Parse("2020-10-01T15:01:54.9571247Z"),
                    RegistrationTokenOperation = HostPoolRegistrationTokenOperation.Update,
                },
                VmTemplate = "{json:json}",
                SsoAdfsAuthority = "https://adfs",
                SsoClientId = "client",
                SsoClientSecretKeyVaultPath = "https://keyvault/secret",
                SsoSecretType = HostPoolSsoSecretType.SharedKey,
                StartVmOnConnect = false,
                AgentUpdate = new SessionHostAgentUpdatePatchProperties()
                {
                    UpdateType = SessionHostComponentUpdateType.Scheduled,
                    DoesUseSessionHostLocalTime = false,
                    MaintenanceWindowTimeZone = "Alaskan Standard Time",
                    MaintenanceWindows =
{
new MaintenanceWindowPatchProperties()
{
Hour = 7,
DayOfWeek = DesktopVirtualizationDayOfWeek.Friday,
},new MaintenanceWindowPatchProperties()
{
Hour = 8,
DayOfWeek = DesktopVirtualizationDayOfWeek.Saturday,
}
},
                },
            };
            HostPoolResource result = await hostPool.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HostPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HostPool_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetHostPools_HostPoolList()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/HostPool_List.json
            // this example is just showing the usage of "HostPools_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (HostPoolResource item in subscriptionResource.GetHostPoolsAsync(pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HostPoolData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // HostPools_RetrieveRegistrationToken_Post
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RetrieveRegistrationToken_HostPoolsRetrieveRegistrationTokenPost()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/HostPools_RetrieveRegistrationToken_Post.json
            // this example is just showing the usage of "HostPools_RetrieveRegistrationToken" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // invoke the operation
            HostPoolRegistrationInfo result = await hostPool.RetrieveRegistrationTokenAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // UserSession_ListByHostPool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetUserSessions_UserSessionListByHostPool()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/UserSession_ListByHostPool.json
            // this example is just showing the usage of "UserSessions_ListByHostPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // invoke the operation and iterate over the result
            string filter = "userPrincipalName eq 'user1@microsoft.com' and state eq 'active'";
            int? pageSize = 10;
            bool? isDescending = true;
            int? initialSkip = 0;
            await foreach (UserSessionResource item in hostPool.GetUserSessionsAsync(filter: filter, pageSize: pageSize, isDescending: isDescending, initialSkip: initialSkip))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                UserSessionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // AppAttachPackageInfo_Import
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ImportAppAttachPackageInfos_AppAttachPackageInfoImport()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/AppAttachPackageInfo_Import_Post.json
            // this example is just showing the usage of "AppAttachPackageInfo_Import" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostpool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // invoke the operation and iterate over the result
            ImportPackageInfoContent content = new ImportPackageInfoContent()
            {
                Path = "imagepath",
                PackageArchitecture = AppAttachPackageArchitecture.X64,
            };
            await foreach (AppAttachPackageResource item in hostPool.ImportAppAttachPackageInfosAsync(content))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppAttachPackageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // MsixImage_Expand
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ExpandMsixImages_MsixImageExpand()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/preview/2023-10-04-preview/examples/MsixImage_Expand_Post.json
            // this example is just showing the usage of "MsixImages_Expand" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HostPoolResource created on azure
            // for more information of creating HostPoolResource, please refer to the document of HostPoolResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostpool1";
            ResourceIdentifier hostPoolResourceId = HostPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName);
            HostPoolResource hostPool = client.GetHostPoolResource(hostPoolResourceId);

            // invoke the operation and iterate over the result
            MsixImageUri msixImageUri = new MsixImageUri()
            {
                Uri = new Uri("imagepath"),
            };
            await foreach (ExpandMsixImage item in hostPool.ExpandMsixImagesAsync(msixImageUri))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
