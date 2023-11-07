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
    public partial class Sample_AutomationAccountPython2PackageResource
    {
        // Delete a python 2 package
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAPython2Package()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/deletePython2Package.json
            // this example is just showing the usage of "Python2Package_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountPython2PackageResource created on azure
            // for more information of creating AutomationAccountPython2PackageResource, please refer to the document of AutomationAccountPython2PackageResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            string packageName = "OmsCompositeResources";
            ResourceIdentifier automationAccountPython2PackageResourceId = AutomationAccountPython2PackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, packageName);
            AutomationAccountPython2PackageResource automationAccountPython2Package = client.GetAutomationAccountPython2PackageResource(automationAccountPython2PackageResourceId);

            // invoke the operation
            await automationAccountPython2Package.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a python 2 package
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAPython2Package()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/getPython2Package.json
            // this example is just showing the usage of "Python2Package_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountPython2PackageResource created on azure
            // for more information of creating AutomationAccountPython2PackageResource, please refer to the document of AutomationAccountPython2PackageResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "myAutomationAccount33";
            string packageName = "OmsCompositeResources";
            ResourceIdentifier automationAccountPython2PackageResourceId = AutomationAccountPython2PackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, packageName);
            AutomationAccountPython2PackageResource automationAccountPython2Package = client.GetAutomationAccountPython2PackageResource(automationAccountPython2PackageResourceId);

            // invoke the operation
            AutomationAccountPython2PackageResource result = await automationAccountPython2Package.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationModuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a module
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateAModule()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/stable/2023-11-01/examples/updatePython2Package.json
            // this example is just showing the usage of "Python2Package_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountPython2PackageResource created on azure
            // for more information of creating AutomationAccountPython2PackageResource, please refer to the document of AutomationAccountPython2PackageResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyAutomationAccount";
            string packageName = "MyPython2Package";
            ResourceIdentifier automationAccountPython2PackageResourceId = AutomationAccountPython2PackageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName, packageName);
            AutomationAccountPython2PackageResource automationAccountPython2Package = client.GetAutomationAccountPython2PackageResource(automationAccountPython2PackageResourceId);

            // invoke the operation
            PythonPackageUpdateParameters pythonPackageUpdateParameters = new PythonPackageUpdateParameters()
            {
                Tags =
{
},
            };
            AutomationAccountPython2PackageResource result = await automationAccountPython2Package.UpdateAsync(pythonPackageUpdateParameters);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationModuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
