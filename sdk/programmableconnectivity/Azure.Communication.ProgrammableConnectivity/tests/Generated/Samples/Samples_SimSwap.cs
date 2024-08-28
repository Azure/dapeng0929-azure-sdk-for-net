// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.Communication.ProgrammableConnectivity.Samples
{
    public partial class Samples_SimSwap
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SimSwap_Retrieve_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                networkIdentifier = new
                {
                    identifierType = "<identifierType>",
                    identifier = "<identifier>",
                },
            });
            Response response = client.Retrieve("<apcGatewayId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SimSwap_Retrieve_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                networkIdentifier = new
                {
                    identifierType = "<identifierType>",
                    identifier = "<identifier>",
                },
            });
            Response response = await client.RetrieveAsync("<apcGatewayId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SimSwap_Retrieve_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            SimSwapRetrievalContent body = new SimSwapRetrievalContent(new NetworkIdentifier("<identifierType>", "<identifier>"));
            Response<SimSwapRetrievalResult> response = client.Retrieve("<apcGatewayId>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SimSwap_Retrieve_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            SimSwapRetrievalContent body = new SimSwapRetrievalContent(new NetworkIdentifier("<identifierType>", "<identifier>"));
            Response<SimSwapRetrievalResult> response = await client.RetrieveAsync("<apcGatewayId>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SimSwap_Retrieve_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                phoneNumber = "<phoneNumber>",
                networkIdentifier = new
                {
                    identifierType = "<identifierType>",
                    identifier = "<identifier>",
                },
            });
            Response response = client.Retrieve("<apcGatewayId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("date").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SimSwap_Retrieve_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                phoneNumber = "<phoneNumber>",
                networkIdentifier = new
                {
                    identifierType = "<identifierType>",
                    identifier = "<identifier>",
                },
            });
            Response response = await client.RetrieveAsync("<apcGatewayId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("date").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SimSwap_Retrieve_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            SimSwapRetrievalContent body = new SimSwapRetrievalContent(new NetworkIdentifier("<identifierType>", "<identifier>"))
            {
                PhoneNumber = "<phoneNumber>",
            };
            Response<SimSwapRetrievalResult> response = client.Retrieve("<apcGatewayId>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SimSwap_Retrieve_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            SimSwapRetrievalContent body = new SimSwapRetrievalContent(new NetworkIdentifier("<identifierType>", "<identifier>"))
            {
                PhoneNumber = "<phoneNumber>",
            };
            Response<SimSwapRetrievalResult> response = await client.RetrieveAsync("<apcGatewayId>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SimSwap_Verify_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                networkIdentifier = new
                {
                    identifierType = "<identifierType>",
                    identifier = "<identifier>",
                },
            });
            Response response = client.Verify("<apcGatewayId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("verificationResult").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SimSwap_Verify_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                networkIdentifier = new
                {
                    identifierType = "<identifierType>",
                    identifier = "<identifier>",
                },
            });
            Response response = await client.VerifyAsync("<apcGatewayId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("verificationResult").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SimSwap_Verify_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            SimSwapVerificationContent body = new SimSwapVerificationContent(new NetworkIdentifier("<identifierType>", "<identifier>"));
            Response<SimSwapVerificationResult> response = client.Verify("<apcGatewayId>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SimSwap_Verify_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            SimSwapVerificationContent body = new SimSwapVerificationContent(new NetworkIdentifier("<identifierType>", "<identifier>"));
            Response<SimSwapVerificationResult> response = await client.VerifyAsync("<apcGatewayId>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SimSwap_Verify_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                phoneNumber = "<phoneNumber>",
                maxAgeHours = 1234,
                networkIdentifier = new
                {
                    identifierType = "<identifierType>",
                    identifier = "<identifier>",
                },
            });
            Response response = client.Verify("<apcGatewayId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("verificationResult").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SimSwap_Verify_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            using RequestContent content = RequestContent.Create(new
            {
                phoneNumber = "<phoneNumber>",
                maxAgeHours = 1234,
                networkIdentifier = new
                {
                    identifierType = "<identifierType>",
                    identifier = "<identifier>",
                },
            });
            Response response = await client.VerifyAsync("<apcGatewayId>", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("verificationResult").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SimSwap_Verify_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            SimSwapVerificationContent body = new SimSwapVerificationContent(new NetworkIdentifier("<identifierType>", "<identifier>"))
            {
                PhoneNumber = "<phoneNumber>",
                MaxAgeHours = 1234,
            };
            Response<SimSwapVerificationResult> response = client.Verify("<apcGatewayId>", body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SimSwap_Verify_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            TokenCredential credential = new DefaultAzureCredential();
            SimSwap client = new ProgrammableConnectivityClient(endpoint, credential).GetSimSwapClient(apiVersion: "2024-02-09-preview");

            SimSwapVerificationContent body = new SimSwapVerificationContent(new NetworkIdentifier("<identifierType>", "<identifier>"))
            {
                PhoneNumber = "<phoneNumber>",
                MaxAgeHours = 1234,
            };
            Response<SimSwapVerificationResult> response = await client.VerifyAsync("<apcGatewayId>", body);
        }
    }
}
