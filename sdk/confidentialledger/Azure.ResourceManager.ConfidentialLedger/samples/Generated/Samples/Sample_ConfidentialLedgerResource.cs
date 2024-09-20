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
    public partial class Sample_ConfidentialLedgerResource
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

            // this example assumes you already have this ConfidentialLedgerResource created on azure
            // for more information of creating ConfidentialLedgerResource, please refer to the document of ConfidentialLedgerResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string ledgerName = "DummyLedgerName";
            ResourceIdentifier confidentialLedgerResourceId = ConfidentialLedgerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ledgerName);
            ConfidentialLedgerResource confidentialLedger = client.GetConfidentialLedgerResource(confidentialLedgerResourceId);

            // invoke the operation
            ConfidentialLedgerResource result = await confidentialLedger.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfidentialLedgerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConfidentialLedgerDelete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ConfidentialLedgerDelete()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_Delete.json
            // this example is just showing the usage of "Ledger_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfidentialLedgerResource created on azure
            // for more information of creating ConfidentialLedgerResource, please refer to the document of ConfidentialLedgerResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string ledgerName = "DummyLedgerName";
            ResourceIdentifier confidentialLedgerResourceId = ConfidentialLedgerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ledgerName);
            ConfidentialLedgerResource confidentialLedger = client.GetConfidentialLedgerResource(confidentialLedgerResourceId);

            // invoke the operation
            await confidentialLedger.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ConfidentialLedgerUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ConfidentialLedgerUpdate()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_Update.json
            // this example is just showing the usage of "Ledger_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfidentialLedgerResource created on azure
            // for more information of creating ConfidentialLedgerResource, please refer to the document of ConfidentialLedgerResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string ledgerName = "DummyLedgerName";
            ResourceIdentifier confidentialLedgerResourceId = ConfidentialLedgerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ledgerName);
            ConfidentialLedgerResource confidentialLedger = client.GetConfidentialLedgerResource(confidentialLedgerResourceId);

            // invoke the operation
            ConfidentialLedgerData data = new ConfidentialLedgerData(new AzureLocation("EastUS"))
            {
                Properties = new ConfidentialLedgerProperties()
                {
                    LedgerType = ConfidentialLedgerType.Public,
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
Cert = "-----BEGIN CERTIFICATE-----\nMIIDUjCCAjqgAwIBAgIQJ2IrDBawSkiAbkBYmiAopDANBgkqhkiG9w0BAQsFADAmMSQwIgYDVQQDExtTeW50aGV0aWNzIExlZGdlciBVc2VyIENlcnQwHhcNMjAwOTIzMjIxODQ2WhcNMjEwOTIzMjIyODQ2WjAmMSQwIgYDVQQDExtTeW50aGV0aWNzIExlZGdlciBVc2VyIENlcnQwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQCX2s/Eu4q/eQ63N+Ugeg5oAciZua/YCJr41c/696szvSY7Zg1SNJlW88/nbz70+QpO55OmqlEE3QCU+T0Vl/h0Gf//n1PYcoBbTGUnYEmV+fTTHict6rFiEwrGJ62tvcpYgwapInSLyEeUzjki0zhOLJ1OfRnYd1eGnFVMpE5aVjiS8Q5dmTEUyd51EIprGE8RYAW9aeWSwTH7gjHUsRlJnHKcdhaK/v5QKJnNu5bzPFUcpC0ZBcizoMPAtroLAD4B68Jl0z3op18MgZe6lRrVoWuxfqnk5GojuB/Vu8ohAZKoFhQ6NB6r+LL2AUs+Zr7Bt26IkEdR178n9JMEA4gHAgMBAAGjfDB6MA4GA1UdDwEB/wQEAwIFoDAJBgNVHRMEAjAAMB0GA1UdJQQWMBQGCCsGAQUFBwMBBggrBgEFBQcDAjAfBgNVHSMEGDAWgBS/a7PU9iOfOKEyZCp11Oen5VSuuDAdBgNVHQ4EFgQUv2uz1PYjnzihMmQqddTnp+VUrrgwDQYJKoZIhvcNAQELBQADggEBAF5q2fDwnse8egXhfaJCqqM969E9gSacqFmASpoDJPRPEX7gqoO7v1ww7nqRtRDoRiBvo/yNk7jlSAkRN3nRRnZLZZ3MYQdmCr4FGyIqRg4Y94+nja+Du9pDD761rxRktMVPSOaAVM/E5DQvscDlPvlPYe9mkcrLCE4DXYpiMmLT8Tm55LJJq5m07dVDgzAIR1L/hmEcbK0pnLgzciMtMLxGO2udnyyW/UW9WxnjvrrD2JluTHH9mVbb+XQP1oFtlRBfH7aui1ZgWfKvxrdP4zdK9QoWSUvRux3TLsGmHRBjBMtqYDY3y5mB+aNjLelvWpeVb0m2aOSVXynrLwNCAVA=\n-----END CERTIFICATE-----",
LedgerRoleName = ConfidentialLedgerRoleName.Reader,
}
},
                },
                Tags =
{
["additionProps2"] = "additional property value",
["additionalProps1"] = "additional properties",
},
            };
            ArmOperation<ConfidentialLedgerResource> lro = await confidentialLedger.UpdateAsync(WaitUntil.Completed, data);
            ConfidentialLedgerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ConfidentialLedgerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConfidentialLedgerListBySub
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetConfidentialLedgers_ConfidentialLedgerListBySub()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_ListBySub.json
            // this example is just showing the usage of "Ledger_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ConfidentialLedgerResource item in subscriptionResource.GetConfidentialLedgersAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ConfidentialLedgerData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ConfidentialLedgerBackup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Backup_ConfidentialLedgerBackup()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_Backup.json
            // this example is just showing the usage of "Ledger_Backup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfidentialLedgerResource created on azure
            // for more information of creating ConfidentialLedgerResource, please refer to the document of ConfidentialLedgerResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string ledgerName = "DummyLedgerName";
            ResourceIdentifier confidentialLedgerResourceId = ConfidentialLedgerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ledgerName);
            ConfidentialLedgerResource confidentialLedger = client.GetConfidentialLedgerResource(confidentialLedgerResourceId);

            // invoke the operation
            ConfidentialLedgerBackupContent content = new ConfidentialLedgerBackupContent(new Uri("DummySASUri"))
            {
                RestoreRegion = "EastUS",
            };
            ArmOperation<ConfidentialLedgerBackupResult> lro = await confidentialLedger.BackupAsync(WaitUntil.Completed, content);
            ConfidentialLedgerBackupResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConfidentialLedgerRestore
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restore_ConfidentialLedgerRestore()
        {
            // Generated from example definition: specification/confidentialledger/resource-manager/Microsoft.ConfidentialLedger/preview/2024-09-19-preview/examples/ConfidentialLedger_Restore.json
            // this example is just showing the usage of "Ledger_Restore" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ConfidentialLedgerResource created on azure
            // for more information of creating ConfidentialLedgerResource, please refer to the document of ConfidentialLedgerResource
            string subscriptionId = "0000000-0000-0000-0000-000000000001";
            string resourceGroupName = "DummyResourceGroupName";
            string ledgerName = "DummyLedgerName";
            ResourceIdentifier confidentialLedgerResourceId = ConfidentialLedgerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ledgerName);
            ConfidentialLedgerResource confidentialLedger = client.GetConfidentialLedgerResource(confidentialLedgerResourceId);

            // invoke the operation
            ConfidentialLedgerRestoreContent content = new ConfidentialLedgerRestoreContent("DummyFileShareName", "EastUS", new Uri("DummySASUri"));
            ArmOperation<ConfidentialLedgerRestoreResult> lro = await confidentialLedger.RestoreAsync(WaitUntil.Completed, content);
            ConfidentialLedgerRestoreResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
