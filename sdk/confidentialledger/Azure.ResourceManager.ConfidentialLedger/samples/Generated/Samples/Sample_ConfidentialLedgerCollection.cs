// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ConfidentialLedger.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ConfidentialLedger.Samples
{
    public partial class Sample_ConfidentialLedgerCollection
    {
        // ConfidentialLedgerGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ConfidentialLedgerGet()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_Get.json
            // this example is just showing the usage of "Ledger_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfidentialLedgerResource
            ConfidentialLedgerCollection collection = resourceGroupResource.GetConfidentialLedgers();

            // invoke the operation
            string ledgerName = "DummyLedgerName";
            ConfidentialLedgerResource result = await collection.GetAsync(ledgerName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfidentialLedgerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConfidentialLedgerGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ConfidentialLedgerGet()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_Get.json
            // this example is just showing the usage of "Ledger_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfidentialLedgerResource
            ConfidentialLedgerCollection collection = resourceGroupResource.GetConfidentialLedgers();

            // invoke the operation
            string ledgerName = "DummyLedgerName";
            bool result = await collection.ExistsAsync(ledgerName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConfidentialLedgerGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ConfidentialLedgerGet()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_Get.json
            // this example is just showing the usage of "Ledger_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfidentialLedgerResource
            ConfidentialLedgerCollection collection = resourceGroupResource.GetConfidentialLedgers();

            // invoke the operation
            string ledgerName = "DummyLedgerName";
            NullableResponse<ConfidentialLedgerResource> response = await collection.GetIfExistsAsync(ledgerName);
            ConfidentialLedgerResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConfidentialLedgerData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ConfidentialLedgerCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ConfidentialLedgerCreate()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_Create.json
            // this example is just showing the usage of "Ledger_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfidentialLedgerResource
            ConfidentialLedgerCollection collection = resourceGroupResource.GetConfidentialLedgers();

            // invoke the operation
            string ledgerName = "DummyLedgerName";
            ConfidentialLedgerData data = new ConfidentialLedgerData(new AzureLocation("EastUS"))
            {
                Properties = new ConfidentialLedgerProperties()
                {
                    LedgerType = ConfidentialLedgerType.Public,
                    LedgerSku = ConfidentialLedgerSku.Standard,
                    AadBasedSecurityPrincipals =
{
new AadBasedSecurityPrincipal()
{
PrincipalId = Guid.Parse("34621747-6fc8-4771-a2eb-72f31c461f2e"),
TenantId = Guid.Parse("bce123b9-2b7b-4975-8360-5ca0b9b1cd08"),
LedgerRoleName = ConfidentialLedgerRoleName.Administrator,
}
},
                    CertBasedSecurityPrincipals =
{
new CertBasedSecurityPrincipal()
{
Cert = "-----BEGIN CERTIFICATE-----MIIBsjCCATigAwIBAgIUZWIbyG79TniQLd2UxJuU74tqrKcwCgYIKoZIzj0EAwMwEDEOMAwGA1UEAwwFdXNlcjAwHhcNMjEwMzE2MTgwNjExWhcNMjIwMzE2MTgwNjExWjAQMQ4wDAYDVQQDDAV1c2VyMDB2MBAGByqGSM49AgEGBSuBBAAiA2IABBiWSo/j8EFit7aUMm5lF+lUmCu+IgfnpFD+7QMgLKtxRJ3aGSqgS/GpqcYVGddnODtSarNE/HyGKUFUolLPQ5ybHcouUk0kyfA7XMeSoUA4lBz63Wha8wmXo+NdBRo39qNTMFEwHQYDVR0OBBYEFPtuhrwgGjDFHeUUT4nGsXaZn69KMB8GA1UdIwQYMBaAFPtuhrwgGjDFHeUUT4nGsXaZn69KMA8GA1UdEwEB/wQFMAMBAf8wCgYIKoZIzj0EAwMDaAAwZQIxAOnozm2CyqRwSSQLls5r+mUHRGRyXHXwYtM4Dcst/VEZdmS9fqvHRCHbjUlO/+HNfgIwMWZ4FmsjD3wnPxONOm9YdVn/PRD7SsPRPbOjwBiE4EBGaHDsLjYAGDSGi7NJnSkA-----END CERTIFICATE-----",
LedgerRoleName = ConfidentialLedgerRoleName.Reader,
}
},
                    HostLevel = "Info",
                    MaxBodySizeInMb = 1,
                    SubjectName = "CN=CCF Node",
                    NodeCount = 3,
                    WriteLBAddressPrefix = "write",
                    WorkerThreads = 0,
                },
                Tags =
{
["additionalProps1"] = "additional properties",
},
            };
            ArmOperation<ConfidentialLedgerResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ledgerName, data);
            ConfidentialLedgerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfidentialLedgerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConfidentialLedgerList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ConfidentialLedgerList()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_List.json
            // this example is just showing the usage of "Ledger_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ConfidentialLedgerResource
            ConfidentialLedgerCollection collection = resourceGroupResource.GetConfidentialLedgers();

            // invoke the operation and iterate over the result
            await foreach (ConfidentialLedgerResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConfidentialLedgerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
