// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_WorkflowRunActionScopeRepetitionCollection
    {
        // List the scoped repetitions
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListTheScopedRepetitions()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/WorkflowRunActionScopeRepetitions_List.json
            // this example is just showing the usage of "WorkflowRunActionScopeRepetitions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunActionResource created on azure
            // for more information of creating WorkflowRunActionResource, please refer to the document of WorkflowRunActionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string name = "test-name";
            string workflowName = "testFlow";
            string runName = "08586776228332053161046300351";
            string actionName = "for_each";
            ResourceIdentifier workflowRunActionResourceId = WorkflowRunActionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName, actionName);
            WorkflowRunActionResource workflowRunAction = client.GetWorkflowRunActionResource(workflowRunActionResourceId);

            // get the collection of this WorkflowRunActionScopeRepetitionResource
            WorkflowRunActionScopeRepetitionCollection collection = workflowRunAction.GetWorkflowRunActionScopeRepetitions();

            // invoke the operation and iterate over the result
            await foreach (WorkflowRunActionScopeRepetitionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkflowRunActionRepetitionDefinitionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a scoped repetition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAScopedRepetition()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/WorkflowRunActionScopeRepetitions_Get.json
            // this example is just showing the usage of "WorkflowRunActionScopeRepetitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunActionResource created on azure
            // for more information of creating WorkflowRunActionResource, please refer to the document of WorkflowRunActionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string name = "test-name";
            string workflowName = "testFlow";
            string runName = "08586776228332053161046300351";
            string actionName = "for_each";
            ResourceIdentifier workflowRunActionResourceId = WorkflowRunActionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName, actionName);
            WorkflowRunActionResource workflowRunAction = client.GetWorkflowRunActionResource(workflowRunActionResourceId);

            // get the collection of this WorkflowRunActionScopeRepetitionResource
            WorkflowRunActionScopeRepetitionCollection collection = workflowRunAction.GetWorkflowRunActionScopeRepetitions();

            // invoke the operation
            string repetitionName = "000000";
            WorkflowRunActionScopeRepetitionResource result = await collection.GetAsync(repetitionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WorkflowRunActionRepetitionDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a scoped repetition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAScopedRepetition()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/WorkflowRunActionScopeRepetitions_Get.json
            // this example is just showing the usage of "WorkflowRunActionScopeRepetitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunActionResource created on azure
            // for more information of creating WorkflowRunActionResource, please refer to the document of WorkflowRunActionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string name = "test-name";
            string workflowName = "testFlow";
            string runName = "08586776228332053161046300351";
            string actionName = "for_each";
            ResourceIdentifier workflowRunActionResourceId = WorkflowRunActionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName, actionName);
            WorkflowRunActionResource workflowRunAction = client.GetWorkflowRunActionResource(workflowRunActionResourceId);

            // get the collection of this WorkflowRunActionScopeRepetitionResource
            WorkflowRunActionScopeRepetitionCollection collection = workflowRunAction.GetWorkflowRunActionScopeRepetitions();

            // invoke the operation
            string repetitionName = "000000";
            bool result = await collection.ExistsAsync(repetitionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a scoped repetition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAScopedRepetition()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2024-04-01/examples/WorkflowRunActionScopeRepetitions_Get.json
            // this example is just showing the usage of "WorkflowRunActionScopeRepetitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkflowRunActionResource created on azure
            // for more information of creating WorkflowRunActionResource, please refer to the document of WorkflowRunActionResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "testResourceGroup";
            string name = "test-name";
            string workflowName = "testFlow";
            string runName = "08586776228332053161046300351";
            string actionName = "for_each";
            ResourceIdentifier workflowRunActionResourceId = WorkflowRunActionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName, actionName);
            WorkflowRunActionResource workflowRunAction = client.GetWorkflowRunActionResource(workflowRunActionResourceId);

            // get the collection of this WorkflowRunActionScopeRepetitionResource
            WorkflowRunActionScopeRepetitionCollection collection = workflowRunAction.GetWorkflowRunActionScopeRepetitions();

            // invoke the operation
            string repetitionName = "000000";
            NullableResponse<WorkflowRunActionScopeRepetitionResource> response = await collection.GetIfExistsAsync(repetitionName);
            WorkflowRunActionScopeRepetitionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                WorkflowRunActionRepetitionDefinitionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
