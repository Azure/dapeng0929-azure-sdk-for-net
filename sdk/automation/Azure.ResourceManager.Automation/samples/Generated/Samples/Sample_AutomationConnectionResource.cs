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
using Azure.ResourceManager.Automation;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_AutomationConnectionResource
    {
        // Delete an existing connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAnExistingConnection()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/deleteConnection.json
            // this example is just showing the usage of "Connection_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationConnectionResource created on azure
            // for more information of creating AutomationConnectionResource, please refer to the document of AutomationConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount28";
            string connectionName = "myConnection";
            ResourceIdentifier automationConnectionResourceId = AutomationConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, connectionName);
            AutomationConnectionResource automationConnection = client.GetAutomationConnectionResource(automationConnectionResourceId);

            // invoke the operation
            await automationConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAConnection()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/getConnection.json
            // this example is just showing the usage of "Connection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationConnectionResource created on azure
            // for more information of creating AutomationConnectionResource, please refer to the document of AutomationConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount28";
            string connectionName = "myConnection";
            ResourceIdentifier automationConnectionResourceId = AutomationConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, connectionName);
            AutomationConnectionResource automationConnection = client.GetAutomationConnectionResource(automationConnectionResourceId);

            // invoke the operation
            AutomationConnectionResource result = await automationConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a connection
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAConnection()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/updateConnection.json
            // this example is just showing the usage of "Connection_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationConnectionResource created on azure
            // for more information of creating AutomationConnectionResource, please refer to the document of AutomationConnectionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount28";
            string connectionName = "myConnection";
            ResourceIdentifier automationConnectionResourceId = AutomationConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, connectionName);
            AutomationConnectionResource automationConnection = client.GetAutomationConnectionResource(automationConnectionResourceId);

            // invoke the operation
            AutomationConnectionPatch patch = new AutomationConnectionPatch()
            {
                Name = "myConnection",
                Description = "my description goes here",
                FieldDefinitionValues =
{
["AutomationCertificateName"] = "myCertificateName",
["SubscriptionID"] = "b5e4748c-f69a-467c-8749-e2f9c8cd3009",
},
            };
            AutomationConnectionResource result = await automationConnection.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
