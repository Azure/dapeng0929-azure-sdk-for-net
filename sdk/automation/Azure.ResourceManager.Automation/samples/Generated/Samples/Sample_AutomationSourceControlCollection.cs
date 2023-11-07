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
    public partial class Sample_AutomationSourceControlCollection
    {
        // Create or update a source control
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateASourceControl()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/sourceControl/createOrUpdateSourceControl.json
            // this example is just showing the usage of "SourceControl_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "sampleAccount9";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationSourceControlResource
            AutomationSourceControlCollection collection = automationAccount.GetAutomationSourceControls();

            // invoke the operation
            string sourceControlName = "sampleSourceControl";
            AutomationSourceControlCreateOrUpdateContent content = new AutomationSourceControlCreateOrUpdateContent()
            {
                RepoUri = new Uri("https://sampleUser.visualstudio.com/myProject/_git/myRepository"),
                Branch = "master",
                FolderPath = "/folderOne/folderTwo",
                IsAutoSyncEnabled = true,
                IsAutoPublishRunbookEnabled = true,
                SourceType = SourceControlSourceType.VsoGit,
                SecurityToken = new SourceControlSecurityTokenProperties()
                {
                    AccessToken = "******",
                    TokenType = SourceControlTokenType.PersonalAccessToken,
                },
                Description = "my description",
            };
            ArmOperation<AutomationSourceControlResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, sourceControlName, content);
            AutomationSourceControlResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationSourceControlData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a source control
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASourceControl()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/sourceControl/getSourceControl.json
            // this example is just showing the usage of "SourceControl_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "sampleAccount9";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationSourceControlResource
            AutomationSourceControlCollection collection = automationAccount.GetAutomationSourceControls();

            // invoke the operation
            string sourceControlName = "sampleSourceControl";
            AutomationSourceControlResource result = await collection.GetAsync(sourceControlName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationSourceControlData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a source control
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetASourceControl()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/sourceControl/getSourceControl.json
            // this example is just showing the usage of "SourceControl_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "sampleAccount9";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationSourceControlResource
            AutomationSourceControlCollection collection = automationAccount.GetAutomationSourceControls();

            // invoke the operation
            string sourceControlName = "sampleSourceControl";
            bool result = await collection.ExistsAsync(sourceControlName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a source control
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetASourceControl()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/sourceControl/getSourceControl.json
            // this example is just showing the usage of "SourceControl_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "sampleAccount9";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationSourceControlResource
            AutomationSourceControlCollection collection = automationAccount.GetAutomationSourceControls();

            // invoke the operation
            string sourceControlName = "sampleSourceControl";
            NullableResponse<AutomationSourceControlResource> response = await collection.GetIfExistsAsync(sourceControlName);
            AutomationSourceControlResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationSourceControlData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List sourceControls
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListSourceControls()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/sourceControl/getAllSourceControls.json
            // this example is just showing the usage of "SourceControl_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "sampleAccount9";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationSourceControlResource
            AutomationSourceControlCollection collection = automationAccount.GetAutomationSourceControls();

            // invoke the operation and iterate over the result
            await foreach (AutomationSourceControlResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationSourceControlData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
