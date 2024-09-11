// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_SecurityConnectorGitHubRepositoryResource
    {
        // Get_GitHubRepos
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetGitHubRepos()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/stable/2024-04-01/examples/SecurityConnectorsDevOps/GetGitHubRepos_example.json
            // this example is just showing the usage of "GitHubRepos_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SecurityConnectorGitHubRepositoryResource created on azure
            // for more information of creating SecurityConnectorGitHubRepositoryResource, please refer to the document of SecurityConnectorGitHubRepositoryResource
            string subscriptionId = "0806e1cd-cfda-4ff8-b99c-2b0af42cffd3";
            string resourceGroupName = "myRg";
            string securityConnectorName = "mySecurityConnectorName";
            string ownerName = "myGitHubOwner";
            string repoName = "myGitHubRepo";
            ResourceIdentifier securityConnectorGitHubRepositoryResourceId = SecurityConnectorGitHubRepositoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, securityConnectorName, ownerName, repoName);
            SecurityConnectorGitHubRepositoryResource securityConnectorGitHubRepository = client.GetSecurityConnectorGitHubRepositoryResource(securityConnectorGitHubRepositoryResourceId);

            // invoke the operation
            SecurityConnectorGitHubRepositoryResource result = await securityConnectorGitHubRepository.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityConnectorGitHubRepositoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
