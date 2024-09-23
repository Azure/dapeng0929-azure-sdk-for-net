// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_CommitmentPlanAccountAssociationResource
    {
        // GetCommitmentPlan
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2024-10-01/examples/GetSharedCommitmentPlanAssociation.json
            // this example is just showing the usage of "CommitmentPlans_GetAssociation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CommitmentPlanAccountAssociationResource created on azure
            // for more information of creating CommitmentPlanAccountAssociationResource, please refer to the document of CommitmentPlanAccountAssociationResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "resourceGroupName";
            string commitmentPlanName = "commitmentPlanName";
            string commitmentPlanAssociationName = "commitmentPlanAssociationName";
            ResourceIdentifier commitmentPlanAccountAssociationResourceId = CommitmentPlanAccountAssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, commitmentPlanName, commitmentPlanAssociationName);
            CommitmentPlanAccountAssociationResource commitmentPlanAccountAssociation = client.GetCommitmentPlanAccountAssociationResource(commitmentPlanAccountAssociationResourceId);

            // invoke the operation
            CommitmentPlanAccountAssociationResource result = await commitmentPlanAccountAssociation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommitmentPlanAccountAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PutCommitmentPlan
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PutCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2024-10-01/examples/CreateSharedCommitmentPlanAssociation.json
            // this example is just showing the usage of "CommitmentPlans_CreateOrUpdateAssociation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CommitmentPlanAccountAssociationResource created on azure
            // for more information of creating CommitmentPlanAccountAssociationResource, please refer to the document of CommitmentPlanAccountAssociationResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "resourceGroupName";
            string commitmentPlanName = "commitmentPlanName";
            string commitmentPlanAssociationName = "commitmentPlanAssociationName";
            ResourceIdentifier commitmentPlanAccountAssociationResourceId = CommitmentPlanAccountAssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, commitmentPlanName, commitmentPlanAssociationName);
            CommitmentPlanAccountAssociationResource commitmentPlanAccountAssociation = client.GetCommitmentPlanAccountAssociationResource(commitmentPlanAccountAssociationResourceId);

            // invoke the operation
            CommitmentPlanAccountAssociationData data = new CommitmentPlanAccountAssociationData()
            {
                AccountId = "/subscriptions/subscriptionId/resourceGroups/resourceGroupName/providers/Microsoft.CognitiveServices/accounts/accountName",
            };
            ArmOperation<CommitmentPlanAccountAssociationResource> lro = await commitmentPlanAccountAssociation.UpdateAsync(WaitUntil.Completed, data);
            CommitmentPlanAccountAssociationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CommitmentPlanAccountAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DeleteCommitmentPlan
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteCommitmentPlan()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2024-10-01/examples/DeleteSharedCommitmentPlanAssociation.json
            // this example is just showing the usage of "CommitmentPlans_DeleteAssociation" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CommitmentPlanAccountAssociationResource created on azure
            // for more information of creating CommitmentPlanAccountAssociationResource, please refer to the document of CommitmentPlanAccountAssociationResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            string resourceGroupName = "resourceGroupName";
            string commitmentPlanName = "commitmentPlanName";
            string commitmentPlanAssociationName = "commitmentPlanAssociationName";
            ResourceIdentifier commitmentPlanAccountAssociationResourceId = CommitmentPlanAccountAssociationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, commitmentPlanName, commitmentPlanAssociationName);
            CommitmentPlanAccountAssociationResource commitmentPlanAccountAssociation = client.GetCommitmentPlanAccountAssociationResource(commitmentPlanAccountAssociationResourceId);

            // invoke the operation
            await commitmentPlanAccountAssociation.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
