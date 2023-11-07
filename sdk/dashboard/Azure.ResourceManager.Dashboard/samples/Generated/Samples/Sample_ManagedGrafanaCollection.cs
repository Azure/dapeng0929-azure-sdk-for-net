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
using Azure.ResourceManager.Dashboard;
using Azure.ResourceManager.Dashboard.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Dashboard.Samples
{
    public partial class Sample_ManagedGrafanaCollection
    {
        // Grafana_ListByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GrafanaListByResourceGroup()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2023-09-01/examples/Grafana_ListByResourceGroup.json
            // this example is just showing the usage of "Grafana_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ManagedGrafanaResource
            ManagedGrafanaCollection collection = resourceGroupResource.GetManagedGrafanas();

            // invoke the operation and iterate over the result
            await foreach (ManagedGrafanaResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedGrafanaData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Grafana_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GrafanaGet()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2023-09-01/examples/Grafana_Get.json
            // this example is just showing the usage of "Grafana_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ManagedGrafanaResource
            ManagedGrafanaCollection collection = resourceGroupResource.GetManagedGrafanas();

            // invoke the operation
            string workspaceName = "myWorkspace";
            ManagedGrafanaResource result = await collection.GetAsync(workspaceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedGrafanaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Grafana_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GrafanaGet()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2023-09-01/examples/Grafana_Get.json
            // this example is just showing the usage of "Grafana_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ManagedGrafanaResource
            ManagedGrafanaCollection collection = resourceGroupResource.GetManagedGrafanas();

            // invoke the operation
            string workspaceName = "myWorkspace";
            bool result = await collection.ExistsAsync(workspaceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Grafana_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GrafanaGet()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2023-09-01/examples/Grafana_Get.json
            // this example is just showing the usage of "Grafana_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ManagedGrafanaResource
            ManagedGrafanaCollection collection = resourceGroupResource.GetManagedGrafanas();

            // invoke the operation
            string workspaceName = "myWorkspace";
            NullableResponse<ManagedGrafanaResource> response = await collection.GetIfExistsAsync(workspaceName);
            ManagedGrafanaResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ManagedGrafanaData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Grafana_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_GrafanaCreate()
        {
            // Generated from example definition: specification/dashboard/resource-manager/Microsoft.Dashboard/stable/2023-09-01/examples/Grafana_Create.json
            // this example is just showing the usage of "Grafana_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ManagedGrafanaResource
            ManagedGrafanaCollection collection = resourceGroupResource.GetManagedGrafanas();

            // invoke the operation
            string workspaceName = "myWorkspace";
            ManagedGrafanaData data = new ManagedGrafanaData(new AzureLocation("West US"))
            {
                SkuName = "Standard",
                Properties = new ManagedGrafanaProperties()
                {
                    PublicNetworkAccess = PublicNetworkAccess.Enabled,
                    ZoneRedundancy = ZoneRedundancy.Enabled,
                    ApiKey = ApiKey.Enabled,
                    DeterministicOutboundIP = DeterministicOutboundIP.Enabled,
                    AzureMonitorWorkspaceIntegrations =
{
new AzureMonitorWorkspaceIntegration()
{
AzureMonitorWorkspaceResourceId = "/subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/myResourceGroup/providers/microsoft.monitor/accounts/myAzureMonitorWorkspace",
}
},
                    EnterpriseConfigurations = new EnterpriseConfigurations()
                    {
                        MarketplacePlanId = "myPlanId",
                        MarketplaceAutoRenew = MarketplaceAutoRenew.Enabled,
                    },
                    GrafanaConfigurationsSmtp = new Smtp()
                    {
                        Enabled = true,
                        Host = "smtp.sendemail.com:587",
                        User = "username",
                        Password = "<password>",
                        FromAddress = "test@sendemail.com",
                        FromName = "emailsender",
                        StartTLSPolicy = StartTLSPolicy.OpportunisticStartTLS,
                        SkipVerify = true,
                    },
                    GrafanaPlugins =
{
["sample-plugin-id"] = new GrafanaPlugin(),
},
                    GrafanaMajorVersion = "9",
                },
                Identity = new ManagedServiceIdentity("SystemAssigned"),
                Tags =
{
["Environment"] = "Dev",
},
            };
            ArmOperation<ManagedGrafanaResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workspaceName, data);
            ManagedGrafanaResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedGrafanaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
