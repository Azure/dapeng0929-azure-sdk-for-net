// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DeviceProvisioningServices.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary>
    /// A Class representing a DeviceProvisioningServicesCertificate along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="DeviceProvisioningServicesCertificateResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetDeviceProvisioningServicesCertificateResource method.
    /// Otherwise you can get one from its parent resource <see cref="DeviceProvisioningServiceResource"/> using the GetDeviceProvisioningServicesCertificate method.
    /// </summary>
    public partial class DeviceProvisioningServicesCertificateResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DeviceProvisioningServicesCertificateResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="provisioningServiceName"> The provisioningServiceName. </param>
        /// <param name="certificateName"> The certificateName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string provisioningServiceName, string certificateName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics;
        private readonly DpsCertificateRestOperations _deviceProvisioningServicesCertificateDpsCertificateRestClient;
        private readonly DeviceProvisioningServicesCertificateData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Devices/provisioningServices/certificates";

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesCertificateResource"/> class for mocking. </summary>
        protected DeviceProvisioningServicesCertificateResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesCertificateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DeviceProvisioningServicesCertificateResource(ArmClient client, DeviceProvisioningServicesCertificateData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DeviceProvisioningServicesCertificateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeviceProvisioningServicesCertificateResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DeviceProvisioningServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string deviceProvisioningServicesCertificateDpsCertificateApiVersion);
            _deviceProvisioningServicesCertificateDpsCertificateRestClient = new DpsCertificateRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deviceProvisioningServicesCertificateDpsCertificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeviceProvisioningServicesCertificateData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the certificate from the provisioning service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeviceProvisioningServicesCertificateResource>> GetAsync(string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.Get");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesCertificateDpsCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the certificate from the provisioning service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeviceProvisioningServicesCertificateResource> Get(string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.Get");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesCertificateDpsCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified certificate associated with the Provisioning Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, DeviceProvisioningServicesCertificateResourceDeleteOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.Delete");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesCertificateDpsCertificateRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.IfMatch, options.CertificateCommonName, options.CertificateRawBytes, options.CertificateIsVerified, options.CertificatePurpose, options.CertificateCreatedOn, options.CertificateLastUpdatedOn, options.CertificateHasPrivateKey, options.CertificateNonce, cancellationToken).ConfigureAwait(false);
                var uri = _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.IfMatch, options.CertificateCommonName, options.CertificateRawBytes, options.CertificateIsVerified, options.CertificatePurpose, options.CertificateCreatedOn, options.CertificateLastUpdatedOn, options.CertificateHasPrivateKey, options.CertificateNonce);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DeviceProvisioningServicesArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified certificate associated with the Provisioning Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual ArmOperation Delete(WaitUntil waitUntil, DeviceProvisioningServicesCertificateResourceDeleteOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.Delete");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesCertificateDpsCertificateRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.IfMatch, options.CertificateCommonName, options.CertificateRawBytes, options.CertificateIsVerified, options.CertificatePurpose, options.CertificateCreatedOn, options.CertificateLastUpdatedOn, options.CertificateHasPrivateKey, options.CertificateNonce, cancellationToken);
                var uri = _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateDeleteRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.IfMatch, options.CertificateCommonName, options.CertificateRawBytes, options.CertificateIsVerified, options.CertificatePurpose, options.CertificateCreatedOn, options.CertificateLastUpdatedOn, options.CertificateHasPrivateKey, options.CertificateNonce);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DeviceProvisioningServicesArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add new certificate or update an existing certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the certificate. This is required to update an existing certificate, and ignored while creating a brand new certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DeviceProvisioningServicesCertificateResource>> UpdateAsync(WaitUntil waitUntil, DeviceProvisioningServicesCertificateData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.Update");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var uri = _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesCertificateResource>(Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add new certificate or update an existing certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The certificate body. </param>
        /// <param name="ifMatch"> ETag of the certificate. This is required to update an existing certificate, and ignored while creating a brand new certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DeviceProvisioningServicesCertificateResource> Update(WaitUntil waitUntil, DeviceProvisioningServicesCertificateData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.Update");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch, cancellationToken);
                var uri = _deviceProvisioningServicesCertificateDpsCertificateRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, ifMatch);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new DeviceProvisioningServicesArmOperation<DeviceProvisioningServicesCertificateResource>(Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Generate verification code for Proof of Possession.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}/generateVerificationCode</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_GenerateVerificationCode</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual async Task<Response<CertificateVerificationCodeResult>> GenerateVerificationCodeAsync(DeviceProvisioningServicesCertificateResourceGenerateVerificationCodeOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.GenerateVerificationCode");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesCertificateDpsCertificateRestClient.GenerateVerificationCodeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.IfMatch, options.CertificateCommonName, options.CertificateRawBytes, options.CertificateIsVerified, options.CertificatePurpose, options.CertificateCreatedOn, options.CertificateLastUpdatedOn, options.CertificateHasPrivateKey, options.CertificateNonce, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Generate verification code for Proof of Possession.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}/generateVerificationCode</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_GenerateVerificationCode</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual Response<CertificateVerificationCodeResult> GenerateVerificationCode(DeviceProvisioningServicesCertificateResourceGenerateVerificationCodeOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.GenerateVerificationCode");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesCertificateDpsCertificateRestClient.GenerateVerificationCode(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.IfMatch, options.CertificateCommonName, options.CertificateRawBytes, options.CertificateIsVerified, options.CertificatePurpose, options.CertificateCreatedOn, options.CertificateLastUpdatedOn, options.CertificateHasPrivateKey, options.CertificateNonce, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the certificate's private key possession by providing the leaf cert issued by the verifying pre uploaded certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}/verify</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_VerifyCertificate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual async Task<Response<DeviceProvisioningServicesCertificateResource>> VerifyCertificateAsync(DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.VerifyCertificate");
            scope.Start();
            try
            {
                var response = await _deviceProvisioningServicesCertificateDpsCertificateRestClient.VerifyCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.IfMatch, options.Content, options.CertificateCommonName, options.CertificateRawBytes, options.CertificateIsVerified, options.CertificatePurpose, options.CertificateCreatedOn, options.CertificateLastUpdatedOn, options.CertificateHasPrivateKey, options.CertificateNonce, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Verifies the certificate's private key possession by providing the leaf cert issued by the verifying pre uploaded certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}/certificates/{certificateName}/verify</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DpsCertificate_VerifyCertificate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServicesCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="options"/> is null. </exception>
        public virtual Response<DeviceProvisioningServicesCertificateResource> VerifyCertificate(DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions options, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(options, nameof(options));

            using var scope = _deviceProvisioningServicesCertificateDpsCertificateClientDiagnostics.CreateScope("DeviceProvisioningServicesCertificateResource.VerifyCertificate");
            scope.Start();
            try
            {
                var response = _deviceProvisioningServicesCertificateDpsCertificateRestClient.VerifyCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, options.IfMatch, options.Content, options.CertificateCommonName, options.CertificateRawBytes, options.CertificateIsVerified, options.CertificatePurpose, options.CertificateCreatedOn, options.CertificateLastUpdatedOn, options.CertificateHasPrivateKey, options.CertificateNonce, cancellationToken);
                return Response.FromValue(new DeviceProvisioningServicesCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
