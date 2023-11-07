// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomationAccountPowerShell72ModuleResource" /> and their operations.
    /// Each <see cref="AutomationAccountPowerShell72ModuleResource" /> in the collection will belong to the same instance of <see cref="AutomationAccountResource" />.
    /// To get an <see cref="AutomationAccountPowerShell72ModuleCollection" /> instance call the GetAutomationAccountPowerShell72Modules method from an instance of <see cref="AutomationAccountResource" />.
    /// </summary>
    public partial class AutomationAccountPowerShell72ModuleCollection : ArmCollection, IEnumerable<AutomationAccountPowerShell72ModuleResource>, IAsyncEnumerable<AutomationAccountPowerShell72ModuleResource>
    {
        private readonly ClientDiagnostics _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics;
        private readonly PowerShell72ModuleRestOperations _automationAccountPowerShell72ModulePowerShell72ModuleRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomationAccountPowerShell72ModuleCollection"/> class for mocking. </summary>
        protected AutomationAccountPowerShell72ModuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationAccountPowerShell72ModuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomationAccountPowerShell72ModuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationAccountPowerShell72ModuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomationAccountPowerShell72ModuleResource.ResourceType, out string automationAccountPowerShell72ModulePowerShell72ModuleApiVersion);
            _automationAccountPowerShell72ModulePowerShell72ModuleRestClient = new PowerShell72ModuleRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automationAccountPowerShell72ModulePowerShell72ModuleApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AutomationAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AutomationAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update the module identified by module name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="moduleCreateOrUpdateParameters"> The create or update parameters for module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> or <paramref name="moduleCreateOrUpdateParameters"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomationAccountPowerShell72ModuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string moduleName, ModuleCreateOrUpdateParameters moduleCreateOrUpdateParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));
            Argument.AssertNotNull(moduleCreateOrUpdateParameters, nameof(moduleCreateOrUpdateParameters));

            using var scope = _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics.CreateScope("AutomationAccountPowerShell72ModuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, moduleCreateOrUpdateParameters, cancellationToken).ConfigureAwait(false);
                var operation = new AutomationArmOperation<AutomationAccountPowerShell72ModuleResource>(Response.FromValue(new AutomationAccountPowerShell72ModuleResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update the module identified by module name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="moduleCreateOrUpdateParameters"> The create or update parameters for module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> or <paramref name="moduleCreateOrUpdateParameters"/> is null. </exception>
        public virtual ArmOperation<AutomationAccountPowerShell72ModuleResource> CreateOrUpdate(WaitUntil waitUntil, string moduleName, ModuleCreateOrUpdateParameters moduleCreateOrUpdateParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));
            Argument.AssertNotNull(moduleCreateOrUpdateParameters, nameof(moduleCreateOrUpdateParameters));

            using var scope = _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics.CreateScope("AutomationAccountPowerShell72ModuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, moduleCreateOrUpdateParameters, cancellationToken);
                var operation = new AutomationArmOperation<AutomationAccountPowerShell72ModuleResource>(Response.FromValue(new AutomationAccountPowerShell72ModuleResource(Client, response), response.GetRawResponse()));
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
        /// Retrieve the module identified by module name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual async Task<Response<AutomationAccountPowerShell72ModuleResource>> GetAsync(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics.CreateScope("AutomationAccountPowerShell72ModuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountPowerShell72ModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the module identified by module name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual Response<AutomationAccountPowerShell72ModuleResource> Get(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics.CreateScope("AutomationAccountPowerShell72ModuleCollection.Get");
            scope.Start();
            try
            {
                var response = _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountPowerShell72ModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of PowerShell72 modules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationAccountPowerShell72ModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationAccountPowerShell72ModuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutomationAccountPowerShell72ModuleResource(Client, AutomationModuleData.DeserializeAutomationModuleData(e)), _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics, Pipeline, "AutomationAccountPowerShell72ModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of PowerShell72 modules.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_ListByAutomationAccount</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationAccountPowerShell72ModuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationAccountPowerShell72ModuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.CreateListByAutomationAccountRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.CreateListByAutomationAccountNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutomationAccountPowerShell72ModuleResource(Client, AutomationModuleData.DeserializeAutomationModuleData(e)), _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics, Pipeline, "AutomationAccountPowerShell72ModuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics.CreateScope("AutomationAccountPowerShell72ModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual Response<bool> Exists(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics.CreateScope("AutomationAccountPowerShell72ModuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomationAccountPowerShell72ModuleResource>> GetIfExistsAsync(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics.CreateScope("AutomationAccountPowerShell72ModuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomationAccountPowerShell72ModuleResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountPowerShell72ModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Automation/automationAccounts/{automationAccountName}/powerShell72Modules/{moduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PowerShell72Module_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="moduleName"> The name of module. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="moduleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="moduleName"/> is null. </exception>
        public virtual NullableResponse<AutomationAccountPowerShell72ModuleResource> GetIfExists(string moduleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(moduleName, nameof(moduleName));

            using var scope = _automationAccountPowerShell72ModulePowerShell72ModuleClientDiagnostics.CreateScope("AutomationAccountPowerShell72ModuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automationAccountPowerShell72ModulePowerShell72ModuleRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, moduleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomationAccountPowerShell72ModuleResource>(response.GetRawResponse());
                return Response.FromValue(new AutomationAccountPowerShell72ModuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomationAccountPowerShell72ModuleResource> IEnumerable<AutomationAccountPowerShell72ModuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomationAccountPowerShell72ModuleResource> IAsyncEnumerable<AutomationAccountPowerShell72ModuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
