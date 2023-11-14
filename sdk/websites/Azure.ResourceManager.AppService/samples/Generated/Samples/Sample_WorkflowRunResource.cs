// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_WorkflowRunResource
    {
        // Get a run for a workflow
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetARunForAWorkflow()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-01-01/examples/WorkflowRuns_Get.json
            // this example is just showing the usage of "WorkflowRuns_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunResource created on azure
            // for more information of creating WorkflowRunResource, please refer to the document of WorkflowRunResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string runName = "08586676746934337772206998657CU22";
            ResourceIdentifier workflowRunResourceId = WorkflowRunResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName);
            WorkflowRunResource workflowRun = client.GetWorkflowRunResource(workflowRunResourceId);

            // invoke the operation
            WorkflowRunResource result = await workflowRun.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkflowRunData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Cancel a workflow run
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Cancel_CancelAWorkflowRun()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-01-01/examples/WorkflowRuns_Cancel.json
            // this example is just showing the usage of "WorkflowRuns_Cancel" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunResource created on azure
            // for more information of creating WorkflowRunResource, please refer to the document of WorkflowRunResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string runName = "08586676746934337772206998657CU22";
            ResourceIdentifier workflowRunResourceId = WorkflowRunResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName);
            WorkflowRunResource workflowRun = client.GetWorkflowRunResource(workflowRunResourceId);

            // invoke the operation
            await workflowRun.CancelAsync();

            Console.WriteLine($"Succeeded");
        }
    }
}
