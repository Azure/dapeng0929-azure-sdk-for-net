// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    internal partial class BackupResourceVaultConfigsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of BackupResourceVaultConfigsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public BackupResourceVaultConfigsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string vaultName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupconfig/vaultconfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string vaultName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupconfig/vaultconfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Fetches resource vault config. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BackupResourceVaultConfigData>> GetAsync(string subscriptionId, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupResourceVaultConfigData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BackupResourceVaultConfigData.DeserializeBackupResourceVaultConfigData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BackupResourceVaultConfigData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Fetches resource vault config. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BackupResourceVaultConfigData> Get(string subscriptionId, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, vaultName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupResourceVaultConfigData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BackupResourceVaultConfigData.DeserializeBackupResourceVaultConfigData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BackupResourceVaultConfigData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateUpdateRequestUri(string subscriptionId, string resourceGroupName, string vaultName, BackupResourceVaultConfigData data, string xMsAuthorizationAuxiliary)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupconfig/vaultconfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string vaultName, BackupResourceVaultConfigData data, string xMsAuthorizationAuxiliary)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupconfig/vaultconfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (xMsAuthorizationAuxiliary != null)
            {
                request.Headers.Add("x-ms-authorization-auxiliary", xMsAuthorizationAuxiliary);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates vault security config. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="data"> resource config request. </param>
        /// <param name="xMsAuthorizationAuxiliary"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BackupResourceVaultConfigData>> UpdateAsync(string subscriptionId, string resourceGroupName, string vaultName, BackupResourceVaultConfigData data, string xMsAuthorizationAuxiliary = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, vaultName, data, xMsAuthorizationAuxiliary);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupResourceVaultConfigData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BackupResourceVaultConfigData.DeserializeBackupResourceVaultConfigData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates vault security config. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="data"> resource config request. </param>
        /// <param name="xMsAuthorizationAuxiliary"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BackupResourceVaultConfigData> Update(string subscriptionId, string resourceGroupName, string vaultName, BackupResourceVaultConfigData data, string xMsAuthorizationAuxiliary = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, vaultName, data, xMsAuthorizationAuxiliary);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupResourceVaultConfigData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BackupResourceVaultConfigData.DeserializeBackupResourceVaultConfigData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreatePutRequestUri(string subscriptionId, string resourceGroupName, string vaultName, BackupResourceVaultConfigData data, string xMsAuthorizationAuxiliary)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupconfig/vaultconfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreatePutRequest(string subscriptionId, string resourceGroupName, string vaultName, BackupResourceVaultConfigData data, string xMsAuthorizationAuxiliary)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.RecoveryServices/vaults/", false);
            uri.AppendPath(vaultName, true);
            uri.AppendPath("/backupconfig/vaultconfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (xMsAuthorizationAuxiliary != null)
            {
                request.Headers.Add("x-ms-authorization-auxiliary", xMsAuthorizationAuxiliary);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data, ModelSerializationExtensions.WireOptions);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates vault security config. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="data"> resource config request. </param>
        /// <param name="xMsAuthorizationAuxiliary"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BackupResourceVaultConfigData>> PutAsync(string subscriptionId, string resourceGroupName, string vaultName, BackupResourceVaultConfigData data, string xMsAuthorizationAuxiliary = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreatePutRequest(subscriptionId, resourceGroupName, vaultName, data, xMsAuthorizationAuxiliary);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupResourceVaultConfigData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BackupResourceVaultConfigData.DeserializeBackupResourceVaultConfigData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates vault security config. </summary>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="resourceGroupName"> The name of the resource group where the recovery services vault is present. </param>
        /// <param name="vaultName"> The name of the recovery services vault. </param>
        /// <param name="data"> resource config request. </param>
        /// <param name="xMsAuthorizationAuxiliary"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="vaultName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BackupResourceVaultConfigData> Put(string subscriptionId, string resourceGroupName, string vaultName, BackupResourceVaultConfigData data, string xMsAuthorizationAuxiliary = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(vaultName, nameof(vaultName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreatePutRequest(subscriptionId, resourceGroupName, vaultName, data, xMsAuthorizationAuxiliary);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackupResourceVaultConfigData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BackupResourceVaultConfigData.DeserializeBackupResourceVaultConfigData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
