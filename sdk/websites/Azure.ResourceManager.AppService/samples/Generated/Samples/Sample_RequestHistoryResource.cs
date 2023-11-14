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
    public partial class Sample_RequestHistoryResource
    {
        // Get a repetition request history
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetARepetitionRequestHistory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-01-01/examples/WorkflowRunActionRepetitionsRequestHistories_Get.json
            // this example is just showing the usage of "WorkflowRunActionRepetitionsRequestHistories_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RequestHistoryResource created on azure
            // for more information of creating RequestHistoryResource, please refer to the document of RequestHistoryResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "test-resource-group";
            string name = "test-name";
            string workflowName = "test-workflow";
            string runName = "08586776228332053161046300351";
            string actionName = "HTTP_Webhook";
            string repetitionName = "000001";
            string requestHistoryName = "08586611142732800686";
            ResourceIdentifier requestHistoryResourceId = RequestHistoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, workflowName, runName, actionName, repetitionName, requestHistoryName);
            RequestHistoryResource requestHistory = client.GetRequestHistoryResource(requestHistoryResourceId);

            // invoke the operation
            RequestHistoryResource result = await requestHistory.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RequestHistoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
