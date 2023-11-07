// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RedisEnterprise;
using Azure.ResourceManager.RedisEnterprise.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RedisEnterprise.Samples
{
    public partial class Sample_SubscriptionResourceExtensions
    {
        // OperationsStatusGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetRedisEnterpriseOperationsStatus_OperationsStatusGet()
        {
            // Generated from example definition: specification/redisenterprise/resource-manager/Microsoft.Cache/stable/2023-11-01/examples/OperationsStatusGet.json
            // this example is just showing the usage of "OperationsStatus_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("West US");
            string operationId = "testoperationid";
            RedisEnterpriseOperationStatus result = await subscriptionResource.GetRedisEnterpriseOperationsStatusAsync(location, operationId);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
