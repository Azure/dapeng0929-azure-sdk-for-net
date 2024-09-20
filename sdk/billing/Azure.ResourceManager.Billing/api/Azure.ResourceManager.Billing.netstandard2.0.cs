namespace Azure.ResourceManager.Billing
{
    public partial class BillingAccountCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingAccountResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingAccountResource>, System.Collections.IEnumerable
    {
        protected BillingAccountCollection() { }
        public virtual Azure.Response<bool> Exists(string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource> Get(string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingAccountResource> GetAll(Azure.ResourceManager.Billing.Models.BillingAccountCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingAccountResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingAccountCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource>> GetAsync(string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingAccountResource> GetIfExists(string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingAccountResource>> GetIfExistsAsync(string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingAccountResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingAccountResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingAccountResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingAccountResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingAccountData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountData>
    {
        public BillingAccountData() { }
        public Azure.ResourceManager.Billing.Models.BillingAccountProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingAccountData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingAccountData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAccountPaymentMethodCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>, System.Collections.IEnumerable
    {
        protected BillingAccountPaymentMethodCollection() { }
        public virtual Azure.Response<bool> Exists(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> Get(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>> GetAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> GetIfExists(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>> GetIfExistsAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingAccountPaymentMethodResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingAccountPaymentMethodResource() { }
        public virtual Azure.ResourceManager.Billing.BillingPaymentMethodData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string paymentMethodName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingPaymentMethodData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingPaymentMethodData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAccountPolicyData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>
    {
        public BillingAccountPolicyData() { }
        public Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingAccountPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingAccountPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAccountPolicyResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingAccountPolicyResource() { }
        public virtual Azure.ResourceManager.Billing.BillingAccountPolicyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountPolicyResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountPolicyResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAccountPolicyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingAccountPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAccountPolicyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingAccountPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountPolicyResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountPolicyResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountPolicyResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountPolicyResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountPolicyResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountPolicyResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingAccountPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingAccountPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAccountResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingAccountResource() { }
        public virtual Azure.ResourceManager.Billing.BillingAccountData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAccountResource> AddPaymentTerms(Azure.WaitUntil waitUntil, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPaymentTerm> arrayOfPaymentTerm, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAccountResource>> AddPaymentTermsAsync(Azure.WaitUntil waitUntil, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPaymentTerm> arrayOfPaymentTerm, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAccountResource> CancelPaymentTerms(Azure.WaitUntil waitUntil, System.DateTimeOffset dateTime, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAccountResource>> CancelPaymentTermsAsync(Azure.WaitUntil waitUntil, System.DateTimeOffset dateTime, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissions(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissionsAsync(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.BillingTransitionDetails> ConfirmTransition(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.BillingTransitionDetails>> ConfirmTransitionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentData> CreateByBillingAccountBillingRoleAssignment(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties billingRoleAssignmentProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentData>> CreateByBillingAccountBillingRoleAssignmentAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties billingRoleAssignmentProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult> DownloadDocumentsByBillingAccountInvoice(Azure.WaitUntil waitUntil, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent> arrayOfDocumentDownloadRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>> DownloadDocumentsByBillingAccountInvoiceAsync(Azure.WaitUntil waitUntil, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent> arrayOfDocumentDownloadRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData> GetBillingAccountAvailableBalance(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData>> GetBillingAccountAvailableBalanceAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> GetBillingAccountPaymentMethod(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>> GetBillingAccountPaymentMethodAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingAccountPaymentMethodCollection GetBillingAccountPaymentMethods() { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingAccountPolicyResource GetBillingAccountPolicy() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAgreementResource> GetBillingAgreement(string agreementName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAgreementResource>> GetBillingAgreementAsync(string agreementName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingAgreementCollection GetBillingAgreements() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> GetBillingAssociatedTenant(string associatedTenantName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>> GetBillingAssociatedTenantAsync(string associatedTenantName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingAssociatedTenantCollection GetBillingAssociatedTenants() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerResource> GetBillingCustomer(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerResource>> GetBillingCustomerAsync(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingCustomerCollection GetBillingCustomers() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentResource> GetBillingDepartment(string departmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentResource>> GetBillingDepartmentAsync(string departmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingDepartmentCollection GetBillingDepartments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource> GetBillingEnrollmentAccount(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource>> GetBillingEnrollmentAccountAsync(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingEnrollmentAccountCollection GetBillingEnrollmentAccounts() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceResource> GetBillingInvoice(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceResource>> GetBillingInvoiceAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceCollection GetBillingInvoices() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProductResource> GetBillingProduct(string productName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProductResource>> GetBillingProductAsync(string productName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProductCollection GetBillingProducts() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource> GetBillingProfile(string billingProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource>> GetBillingProfileAsync(string billingProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileCollection GetBillingProfiles() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequests(Azure.ResourceManager.Billing.Models.BillingAccountResourceGetBillingRequestsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequestsAsync(Azure.ResourceManager.Billing.Models.BillingAccountResourceGetBillingRequestsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingReservationOrderResource> GetBillingReservationOrder(string reservationOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingReservationOrderResource>> GetBillingReservationOrderAsync(string reservationOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingReservationOrderCollection GetBillingReservationOrders() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> GetBillingRoleAssignment(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>> GetBillingRoleAssignmentAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingRoleAssignmentCollection GetBillingRoleAssignments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRoleDefinitionResource> GetBillingRoleDefinition(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRoleDefinitionResource>> GetBillingRoleDefinitionAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingRoleDefinitionCollection GetBillingRoleDefinitions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> GetBillingSubscription(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> GetBillingSubscriptionAlias(string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> GetBillingSubscriptionAliasAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingSubscriptionAliasCollection GetBillingSubscriptionAliases() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> GetBillingSubscriptionAsync(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingSubscriptionCollection GetBillingSubscriptions() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> GetByBillingAccountSavingsPlan(Azure.ResourceManager.Billing.Models.BillingAccountResourceGetByBillingAccountSavingsPlanOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> GetByBillingAccountSavingsPlanAsync(Azure.ResourceManager.Billing.Models.BillingAccountResourceGetByBillingAccountSavingsPlanOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission> GetInvoiceSectionsByCreateSubscriptionPermission(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission> GetInvoiceSectionsByCreateSubscriptionPermissionAsync(string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingReservationResource> GetReservations(Azure.ResourceManager.Billing.Models.BillingAccountResourceGetReservationsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingReservationResource> GetReservationsAsync(Azure.ResourceManager.Billing.Models.BillingAccountResourceGetReservationsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource> GetSavingsPlanOrderModel(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource>> GetSavingsPlanOrderModelAsync(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.SavingsPlanOrderModelCollection GetSavingsPlanOrderModels() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult> ResolveByBillingAccountBillingRoleAssignment(Azure.WaitUntil waitUntil, bool? resolveScopeDisplayNames = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>> ResolveByBillingAccountBillingRoleAssignmentAsync(Azure.WaitUntil waitUntil, bool? resolveScopeDisplayNames = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingAccountData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAccountData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingAccountData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAccountData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAccountResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingAccountPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAccountResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingAccountPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult> ValidatePaymentTerms(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPaymentTerm> arrayOfPaymentTerm, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult>> ValidatePaymentTermsAsync(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPaymentTerm> arrayOfPaymentTerm, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingAgreementCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingAgreementResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingAgreementResource>, System.Collections.IEnumerable
    {
        protected BillingAgreementCollection() { }
        public virtual Azure.Response<bool> Exists(string agreementName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string agreementName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAgreementResource> Get(string agreementName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingAgreementResource> GetAll(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingAgreementResource> GetAllAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAgreementResource>> GetAsync(string agreementName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingAgreementResource> GetIfExists(string agreementName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingAgreementResource>> GetIfExistsAsync(string agreementName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingAgreementResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingAgreementResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingAgreementResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingAgreementResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingAgreementData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAgreementData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAgreementData>
    {
        public BillingAgreementData() { }
        public Azure.ResourceManager.Billing.Models.BillingAgreementProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingAgreementData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAgreementData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAgreementData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingAgreementData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAgreementData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAgreementData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAgreementData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAgreementResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAgreementData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAgreementData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingAgreementResource() { }
        public virtual Azure.ResourceManager.Billing.BillingAgreementData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string agreementName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAgreementResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAgreementResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingAgreementData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAgreementData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAgreementData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingAgreementData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAgreementData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAgreementData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAgreementData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAssociatedTenantCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>, System.Collections.IEnumerable
    {
        protected BillingAssociatedTenantCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string associatedTenantName, Azure.ResourceManager.Billing.BillingAssociatedTenantData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string associatedTenantName, Azure.ResourceManager.Billing.BillingAssociatedTenantData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string associatedTenantName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string associatedTenantName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> Get(string associatedTenantName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> GetAll(Azure.ResourceManager.Billing.Models.BillingAssociatedTenantCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingAssociatedTenantCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>> GetAsync(string associatedTenantName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> GetIfExists(string associatedTenantName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>> GetIfExistsAsync(string associatedTenantName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingAssociatedTenantData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>
    {
        public BillingAssociatedTenantData() { }
        public Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingAssociatedTenantData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingAssociatedTenantData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAssociatedTenantResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingAssociatedTenantResource() { }
        public virtual Azure.ResourceManager.Billing.BillingAssociatedTenantData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string associatedTenantName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingAssociatedTenantData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingAssociatedTenantData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingAssociatedTenantData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAssociatedTenantResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingAssociatedTenantData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingAssociatedTenantResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingAssociatedTenantData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingCustomerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingCustomerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingCustomerResource>, System.Collections.IEnumerable
    {
        protected BillingCustomerCollection() { }
        public virtual Azure.Response<bool> Exists(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerResource> Get(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingCustomerResource> GetAll(Azure.ResourceManager.Billing.Models.BillingCustomerCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingCustomerResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingCustomerCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerResource>> GetAsync(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingCustomerResource> GetIfExists(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingCustomerResource>> GetIfExistsAsync(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingCustomerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingCustomerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingCustomerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingCustomerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingCustomerData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>
    {
        public BillingCustomerData() { }
        public Azure.ResourceManager.Billing.Models.BillingCustomerProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingCustomerData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingCustomerData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingCustomerPolicyData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>
    {
        public BillingCustomerPolicyData() { }
        public Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingCustomerPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingCustomerPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingCustomerPolicyResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingCustomerPolicyResource() { }
        public virtual Azure.ResourceManager.Billing.BillingCustomerPolicyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerPolicyResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerPolicyResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingCustomerPolicyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingCustomerPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingCustomerPolicyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingCustomerPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string customerName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerPolicyResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerPolicyResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerPolicyResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerPolicyResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerPolicyResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerPolicyResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingCustomerPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingCustomerPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingCustomerResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingCustomerResource() { }
        public virtual Azure.ResourceManager.Billing.BillingCustomerData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string customerName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingCustomerPolicyResource GetBillingCustomerPolicy() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissionsByCustomerAtBillingAccount(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissionsByCustomerAtBillingAccountAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSubscriptionData> GetBillingSubscriptionsByCustomerAtBillingAccount(Azure.ResourceManager.Billing.Models.BillingCustomerResourceGetBillingSubscriptionsByCustomerAtBillingAccountOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSubscriptionData> GetBillingSubscriptionsByCustomerAtBillingAccountAsync(Azure.ResourceManager.Billing.Models.BillingCustomerResourceGetBillingSubscriptionsByCustomerAtBillingAccountOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingProductResource> GetProducts(Azure.ResourceManager.Billing.Models.BillingCustomerResourceGetProductsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingProductResource> GetProductsAsync(Azure.ResourceManager.Billing.Models.BillingCustomerResourceGetProductsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingCustomerData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingCustomerData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingCustomerRoleAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource>, System.Collections.IEnumerable
    {
        protected BillingCustomerRoleAssignmentCollection() { }
        public virtual Azure.Response<bool> Exists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource> Get(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource> GetAll(string filter = null, long? top = default(long?), long? skip = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource> GetAllAsync(string filter = null, long? top = default(long?), long? skip = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource>> GetAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource> GetIfExists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource>> GetIfExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingCustomerRoleAssignmentResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingCustomerRoleAssignmentResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string customerName, string billingRoleAssignmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingCustomerRoleDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource>, System.Collections.IEnumerable
    {
        protected BillingCustomerRoleDefinitionCollection() { }
        public virtual Azure.Response<bool> Exists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource> Get(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource>> GetAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource> GetIfExists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource>> GetIfExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingCustomerRoleDefinitionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingCustomerRoleDefinitionResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string customerName, string roleDefinitionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingDepartmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingDepartmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingDepartmentResource>, System.Collections.IEnumerable
    {
        protected BillingDepartmentCollection() { }
        public virtual Azure.Response<bool> Exists(string departmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string departmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentResource> Get(string departmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingDepartmentResource> GetAll(string filter = null, string orderBy = null, long? top = default(long?), long? skip = default(long?), string search = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingDepartmentResource> GetAllAsync(string filter = null, string orderBy = null, long? top = default(long?), long? skip = default(long?), string search = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentResource>> GetAsync(string departmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingDepartmentResource> GetIfExists(string departmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingDepartmentResource>> GetIfExistsAsync(string departmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingDepartmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingDepartmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingDepartmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingDepartmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingDepartmentData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingDepartmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingDepartmentData>
    {
        public BillingDepartmentData() { }
        public Azure.ResourceManager.Billing.Models.BillingDepartmentProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingDepartmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingDepartmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingDepartmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingDepartmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingDepartmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingDepartmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingDepartmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingDepartmentEnrollmentAccountCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource>, System.Collections.IEnumerable
    {
        protected BillingDepartmentEnrollmentAccountCollection() { }
        public virtual Azure.Response<bool> Exists(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource> Get(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource> GetAll(Azure.ResourceManager.Billing.Models.BillingDepartmentEnrollmentAccountCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingDepartmentEnrollmentAccountCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource>> GetAsync(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource> GetIfExists(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource>> GetIfExistsAsync(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingDepartmentEnrollmentAccountResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingDepartmentEnrollmentAccountResource() { }
        public virtual Azure.ResourceManager.Billing.BillingEnrollmentAccountData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string departmentName, string enrollmentAccountName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingEnrollmentAccountData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingEnrollmentAccountData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingDepartmentResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingDepartmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingDepartmentData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingDepartmentResource() { }
        public virtual Azure.ResourceManager.Billing.BillingDepartmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissions(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissionsAsync(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string departmentName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource> GetBillingDepartmentEnrollmentAccount(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource>> GetBillingDepartmentEnrollmentAccountAsync(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountCollection GetBillingDepartmentEnrollmentAccounts() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> GetBillingDepartmentRoleAssignment(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>> GetBillingDepartmentRoleAssignmentAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentCollection GetBillingDepartmentRoleAssignments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource> GetBillingDepartmentRoleDefinition(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource>> GetBillingDepartmentRoleDefinitionAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionCollection GetBillingDepartmentRoleDefinitions() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingDepartmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingDepartmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingDepartmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingDepartmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingDepartmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingDepartmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingDepartmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingDepartmentRoleAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>, System.Collections.IEnumerable
    {
        protected BillingDepartmentRoleAssignmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string billingRoleAssignmentName, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string billingRoleAssignmentName, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> Get(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>> GetAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> GetIfExists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>> GetIfExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingDepartmentRoleAssignmentResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingDepartmentRoleAssignmentResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string departmentName, string billingRoleAssignmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingDepartmentRoleDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource>, System.Collections.IEnumerable
    {
        protected BillingDepartmentRoleDefinitionCollection() { }
        public virtual Azure.Response<bool> Exists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource> Get(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource>> GetAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource> GetIfExists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource>> GetIfExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingDepartmentRoleDefinitionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingDepartmentRoleDefinitionResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string departmentName, string roleDefinitionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingEnrollmentAccountCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource>, System.Collections.IEnumerable
    {
        protected BillingEnrollmentAccountCollection() { }
        public virtual Azure.Response<bool> Exists(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource> Get(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource> GetAll(Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource>> GetAsync(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource> GetIfExists(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource>> GetIfExistsAsync(string enrollmentAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingEnrollmentAccountData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>
    {
        public BillingEnrollmentAccountData() { }
        public Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingEnrollmentAccountData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingEnrollmentAccountData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingEnrollmentAccountResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingEnrollmentAccountResource() { }
        public virtual Azure.ResourceManager.Billing.BillingEnrollmentAccountData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissions(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissionsAsync(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string enrollmentAccountName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> GetBillingEnrollmentAccountRoleAssignment(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>> GetBillingEnrollmentAccountRoleAssignmentAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentCollection GetBillingEnrollmentAccountRoleAssignments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource> GetBillingEnrollmentAccountRoleDefinition(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource>> GetBillingEnrollmentAccountRoleDefinitionAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionCollection GetBillingEnrollmentAccountRoleDefinitions() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSubscriptionData> GetBillingSubscriptions(Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountResourceGetBillingSubscriptionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSubscriptionData> GetBillingSubscriptionsAsync(Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountResourceGetBillingSubscriptionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingEnrollmentAccountData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingEnrollmentAccountData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingEnrollmentAccountData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingEnrollmentAccountRoleAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>, System.Collections.IEnumerable
    {
        protected BillingEnrollmentAccountRoleAssignmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string billingRoleAssignmentName, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string billingRoleAssignmentName, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> Get(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>> GetAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> GetIfExists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>> GetIfExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingEnrollmentAccountRoleAssignmentResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingEnrollmentAccountRoleAssignmentResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string enrollmentAccountName, string billingRoleAssignmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingEnrollmentAccountRoleDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource>, System.Collections.IEnumerable
    {
        protected BillingEnrollmentAccountRoleDefinitionCollection() { }
        public virtual Azure.Response<bool> Exists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource> Get(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource>> GetAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource> GetIfExists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource>> GetIfExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingEnrollmentAccountRoleDefinitionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingEnrollmentAccountRoleDefinitionResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string enrollmentAccountName, string roleDefinitionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class BillingExtensions
    {
        public static Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult> DownloadDocumentsByBillingSubscriptionInvoice(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.WaitUntil waitUntil, string subscriptionId, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent> arrayOfDocumentDownloadRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>> DownloadDocumentsByBillingSubscriptionInvoiceAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.WaitUntil waitUntil, string subscriptionId, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent> arrayOfDocumentDownloadRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource> GetBillingAccount(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource>> GetBillingAccountAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> GetBillingAccountPaymentMethod(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>> GetBillingAccountPaymentMethodAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource GetBillingAccountPaymentMethodResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.BillingAccountPaymentMethodCollection GetBillingAccountPaymentMethods(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName) { throw null; }
        public static Azure.ResourceManager.Billing.BillingAccountPolicyResource GetBillingAccountPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingAccountResource GetBillingAccountResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingAccountCollection GetBillingAccounts(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.Billing.BillingAgreementResource GetBillingAgreementResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingAssociatedTenantResource GetBillingAssociatedTenantResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingCustomerPolicyResource GetBillingCustomerPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingCustomerResource GetBillingCustomerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource GetBillingCustomerRoleAssignmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource GetBillingCustomerRoleDefinitionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource GetBillingDepartmentEnrollmentAccountResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingDepartmentResource GetBillingDepartmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource GetBillingDepartmentRoleAssignmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource GetBillingDepartmentRoleDefinitionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingEnrollmentAccountResource GetBillingEnrollmentAccountResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource GetBillingEnrollmentAccountRoleAssignmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource GetBillingEnrollmentAccountRoleDefinitionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingInvoiceResource GetBillingInvoiceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingInvoiceSectionResource GetBillingInvoiceSectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource GetBillingInvoiceSectionRoleAssignmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource GetBillingInvoiceSectionRoleDefinitionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodResource> GetBillingPaymentMethod(this Azure.ResourceManager.Resources.TenantResource tenantResource, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodResource>> GetBillingPaymentMethodAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> GetBillingPaymentMethodLink(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, string billingProfileName, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>> GetBillingPaymentMethodLinkAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, string billingProfileName, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource GetBillingPaymentMethodLinkResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.BillingPaymentMethodLinkCollection GetBillingPaymentMethodLinks(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, string billingProfileName) { throw null; }
        public static Azure.ResourceManager.Billing.BillingPaymentMethodResource GetBillingPaymentMethodResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingPaymentMethodCollection GetBillingPaymentMethods(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProductResource GetBillingProductResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource GetBillingProfileCustomerPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProfileCustomerResource GetBillingProfileCustomerResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProfilePolicyResource GetBillingProfilePolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProfileResource GetBillingProfileResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource GetBillingProfileRoleAssignmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource GetBillingProfileRoleDefinitionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProfileSubscriptionResource GetBillingProfileSubscriptionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequest(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource>> GetBillingRequestAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Billing.BillingRequestResource GetBillingRequestResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingRequestCollection GetBillingRequests(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.Billing.BillingReservationOrderResource GetBillingReservationOrderResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingReservationResource GetBillingReservationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingRoleAssignmentResource GetBillingRoleAssignmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingRoleDefinitionResource GetBillingRoleDefinitionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.BillingSavingsPlanModelResource GetBillingSavingsPlanModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> GetBillingSubscription(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, string billingSubscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> GetBillingSubscriptionAlias(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> GetBillingSubscriptionAliasAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.BillingSubscriptionAliasCollection GetBillingSubscriptionAliases(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName) { throw null; }
        public static Azure.ResourceManager.Billing.BillingSubscriptionAliasResource GetBillingSubscriptionAliasResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> GetBillingSubscriptionAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName, string billingSubscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Billing.BillingSubscriptionResource GetBillingSubscriptionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.BillingSubscriptionCollection GetBillingSubscriptions(this Azure.ResourceManager.Resources.TenantResource tenantResource, string billingAccountName) { throw null; }
        public static Azure.ResourceManager.Billing.BillingTransferDetailResource GetBillingTransferDetailResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource> GetDefaultBillingInvoice(this Azure.ResourceManager.Resources.TenantResource tenantResource, string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource>> GetDefaultBillingInvoiceAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Billing.DefaultBillingInvoiceResource GetDefaultBillingInvoiceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.DefaultBillingInvoiceCollection GetDefaultBillingInvoices(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.Billing.PartnerTransferDetailResource GetPartnerTransferDetailResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource> GetRecipientTransferDetail(this Azure.ResourceManager.Resources.TenantResource tenantResource, string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource>> GetRecipientTransferDetailAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Billing.RecipientTransferDetailResource GetRecipientTransferDetailResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.RecipientTransferDetailCollection GetRecipientTransferDetails(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.Billing.SavingsPlanOrderModelResource GetSavingsPlanOrderModelResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource> GetSubscriptionBillingInvoice(this Azure.ResourceManager.Resources.TenantResource tenantResource, string subscriptionId, string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource>> GetSubscriptionBillingInvoiceAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string subscriptionId, string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource GetSubscriptionBillingInvoiceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.Billing.SubscriptionBillingInvoiceCollection GetSubscriptionBillingInvoices(this Azure.ResourceManager.Resources.TenantResource tenantResource, string subscriptionId) { throw null; }
        public static Azure.ResourceManager.Billing.SubscriptionPolicyResource GetSubscriptionPolicy(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource) { throw null; }
        public static Azure.ResourceManager.Billing.SubscriptionPolicyResource GetSubscriptionPolicyResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult> ValidateAddres(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.Billing.Models.BillingAddressDetails details, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult>> ValidateAddresAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.Billing.Models.BillingAddressDetails details, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingInvoiceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingInvoiceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingInvoiceResource>, System.Collections.IEnumerable
    {
        protected BillingInvoiceCollection() { }
        public virtual Azure.Response<bool> Exists(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceResource> Get(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingInvoiceResource> GetAll(Azure.ResourceManager.Billing.Models.BillingInvoiceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingInvoiceResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingInvoiceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceResource>> GetAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingInvoiceResource> GetIfExists(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingInvoiceResource>> GetIfExistsAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingInvoiceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingInvoiceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingInvoiceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingInvoiceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingInvoiceData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>
    {
        public BillingInvoiceData() { }
        public Azure.ResourceManager.Billing.Models.BillingInvoiceProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingInvoiceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingInvoiceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingInvoiceResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingInvoiceResource() { }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation Amend(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> AmendAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string invoiceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult> DownloadByBillingAccount(Azure.WaitUntil waitUntil, string documentName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>> DownloadByBillingAccountAsync(Azure.WaitUntil waitUntil, string documentName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult> DownloadSummaryByBillingAccount(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>> DownloadSummaryByBillingAccountAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingTransactionData> GetTransactions(Azure.ResourceManager.Billing.Models.BillingInvoiceResourceGetTransactionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingTransactionData> GetTransactionsAsync(Azure.ResourceManager.Billing.Models.BillingInvoiceResourceGetTransactionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.BillingTransactionSummary> GetTransactionSummaryByInvoiceTransaction(string filter = null, string search = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.BillingTransactionSummary>> GetTransactionSummaryByInvoiceTransactionAsync(string filter = null, string search = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingInvoiceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingInvoiceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult> TransactionsDownloadByInvoiceTransaction(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>> TransactionsDownloadByInvoiceTransactionAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingInvoiceSectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>, System.Collections.IEnumerable
    {
        protected BillingInvoiceSectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string invoiceSectionName, Azure.ResourceManager.Billing.BillingInvoiceSectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string invoiceSectionName, Azure.ResourceManager.Billing.BillingInvoiceSectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string invoiceSectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string invoiceSectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> Get(string invoiceSectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> GetAll(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>> GetAsync(string invoiceSectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> GetIfExists(string invoiceSectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>> GetIfExistsAsync(string invoiceSectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingInvoiceSectionData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>
    {
        public BillingInvoiceSectionData() { }
        public Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingInvoiceSectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingInvoiceSectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingInvoiceSectionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingInvoiceSectionResource() { }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceSectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissions(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissionsAsync(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentData> CreateByInvoiceSectionBillingRoleAssignment(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties billingRoleAssignmentProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentData>> CreateByInvoiceSectionBillingRoleAssignmentAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties billingRoleAssignmentProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string invoiceSectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource> GetBillingInvoiceSectionRoleAssignment(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource>> GetBillingInvoiceSectionRoleAssignmentAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentCollection GetBillingInvoiceSectionRoleAssignments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource> GetBillingInvoiceSectionRoleDefinition(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource>> GetBillingInvoiceSectionRoleDefinitionAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionCollection GetBillingInvoiceSectionRoleDefinitions() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequests(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionResourceGetBillingRequestsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequestsAsync(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionResourceGetBillingRequestsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSubscriptionData> GetBillingSubscriptions(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionResourceGetBillingSubscriptionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSubscriptionData> GetBillingSubscriptionsAsync(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionResourceGetBillingSubscriptionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingTransferDetailResource> GetBillingTransferDetail(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingTransferDetailResource>> GetBillingTransferDetailAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingTransferDetailCollection GetBillingTransferDetails() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingProductResource> GetProducts(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionResourceGetProductsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingProductResource> GetProductsAsync(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionResourceGetProductsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingTransactionData> GetTransactions(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionResourceGetTransactionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingTransactionData> GetTransactionsAsync(Azure.ResourceManager.Billing.Models.BillingInvoiceSectionResourceGetTransactionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult> ResolveByInvoiceSectionBillingRoleAssignment(Azure.WaitUntil waitUntil, bool? resolveScopeDisplayNames = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>> ResolveByInvoiceSectionBillingRoleAssignmentAsync(Azure.WaitUntil waitUntil, bool? resolveScopeDisplayNames = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingInvoiceSectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingInvoiceSectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceSectionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingInvoiceSectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingInvoiceSectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult> ValidateDeleteEligibility(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult>> ValidateDeleteEligibilityAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingInvoiceSectionRoleAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource>, System.Collections.IEnumerable
    {
        protected BillingInvoiceSectionRoleAssignmentCollection() { }
        public virtual Azure.Response<bool> Exists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource> Get(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource> GetAll(string filter = null, long? top = default(long?), long? skip = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource> GetAllAsync(string filter = null, long? top = default(long?), long? skip = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource>> GetAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource> GetIfExists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource>> GetIfExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingInvoiceSectionRoleAssignmentResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingInvoiceSectionRoleAssignmentResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string invoiceSectionName, string billingRoleAssignmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingInvoiceSectionRoleDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource>, System.Collections.IEnumerable
    {
        protected BillingInvoiceSectionRoleDefinitionCollection() { }
        public virtual Azure.Response<bool> Exists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource> Get(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource>> GetAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource> GetIfExists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource>> GetIfExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingInvoiceSectionRoleDefinitionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingInvoiceSectionRoleDefinitionResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string invoiceSectionName, string roleDefinitionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingPaymentMethodCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingPaymentMethodResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingPaymentMethodResource>, System.Collections.IEnumerable
    {
        protected BillingPaymentMethodCollection() { }
        public virtual Azure.Response<bool> Exists(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodResource> Get(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingPaymentMethodResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingPaymentMethodResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodResource>> GetAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingPaymentMethodResource> GetIfExists(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingPaymentMethodResource>> GetIfExistsAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingPaymentMethodResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingPaymentMethodResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingPaymentMethodResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingPaymentMethodResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingPaymentMethodData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>
    {
        public BillingPaymentMethodData() { }
        public string AccountHolderName { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Expiration { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentMethodFamily? Family { get { throw null; } set { } }
        public string LastFourDigits { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.PaymentMethodLogo> Logos { get { throw null; } }
        public Azure.Core.ResourceIdentifier PaymentMethodId { get { throw null; } }
        public string PaymentMethodType { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentMethodStatus? Status { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingPaymentMethodData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingPaymentMethodData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingPaymentMethodLinkCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>, System.Collections.IEnumerable
    {
        protected BillingPaymentMethodLinkCollection() { }
        public virtual Azure.Response<bool> Exists(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> Get(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>> GetAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> GetIfExists(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>> GetIfExistsAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingPaymentMethodLinkData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>
    {
        public BillingPaymentMethodLinkData() { }
        public string AccountHolderName { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Expiration { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentMethodFamily? Family { get { throw null; } }
        public string LastFourDigits { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.PaymentMethodLogo> Logos { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties PaymentMethod { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PaymentMethodId { get { throw null; } set { } }
        public string PaymentMethodType { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentMethodStatus? Status { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingPaymentMethodLinkData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingPaymentMethodLinkData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingPaymentMethodLinkResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingPaymentMethodLinkResource() { }
        public virtual Azure.ResourceManager.Billing.BillingPaymentMethodLinkData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string paymentMethodName) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingPaymentMethodLinkData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingPaymentMethodLinkData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodLinkData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingPaymentMethodResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingPaymentMethodResource() { }
        public virtual Azure.ResourceManager.Billing.BillingPaymentMethodData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string paymentMethodName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingPaymentMethodData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingPaymentMethodData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingPaymentMethodData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProductCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProductResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProductResource>, System.Collections.IEnumerable
    {
        protected BillingProductCollection() { }
        public virtual Azure.Response<bool> Exists(string productName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string productName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProductResource> Get(string productName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingProductResource> GetAll(Azure.ResourceManager.Billing.Models.BillingProductCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingProductResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingProductCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProductResource>> GetAsync(string productName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProductResource> GetIfExists(string productName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProductResource>> GetIfExistsAsync(string productName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingProductResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProductResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingProductResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProductResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingProductData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProductData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProductData>
    {
        public BillingProductData() { }
        public Azure.ResourceManager.Billing.Models.BillingProductProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingProductData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProductData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProductData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingProductData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProductData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProductData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProductData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProductResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProductData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProductData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingProductResource() { }
        public virtual Azure.ResourceManager.Billing.BillingProductData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProductResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProductResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string productName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProductResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProductResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingProductResource> Move(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.MoveProductContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingProductResource>> MoveAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.MoveProductContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProductResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProductResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProductResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProductResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingProductData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProductData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProductData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingProductData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProductData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProductData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProductData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProductResource> Update(Azure.ResourceManager.Billing.Models.BillingProductPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProductResource>> UpdateAsync(Azure.ResourceManager.Billing.Models.BillingProductPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult> ValidateMoveEligibility(Azure.ResourceManager.Billing.Models.MoveProductContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult>> ValidateMoveEligibilityAsync(Azure.ResourceManager.Billing.Models.MoveProductContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingProfileCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileResource>, System.Collections.IEnumerable
    {
        protected BillingProfileCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingProfileResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string billingProfileName, Azure.ResourceManager.Billing.BillingProfileData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingProfileResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string billingProfileName, Azure.ResourceManager.Billing.BillingProfileData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string billingProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource> Get(string billingProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingProfileResource> GetAll(Azure.ResourceManager.Billing.Models.BillingProfileCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingProfileResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingProfileCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource>> GetAsync(string billingProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileResource> GetIfExists(string billingProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileResource>> GetIfExistsAsync(string billingProfileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingProfileResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingProfileResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingProfileCustomerCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileCustomerResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileCustomerResource>, System.Collections.IEnumerable
    {
        protected BillingProfileCustomerCollection() { }
        public virtual Azure.Response<bool> Exists(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerResource> Get(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingProfileCustomerResource> GetAll(Azure.ResourceManager.Billing.Models.BillingProfileCustomerCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingProfileCustomerResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingProfileCustomerCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerResource>> GetAsync(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileCustomerResource> GetIfExists(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileCustomerResource>> GetIfExistsAsync(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingProfileCustomerResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileCustomerResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingProfileCustomerResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileCustomerResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingProfileCustomerPolicyCollection : Azure.ResourceManager.ArmCollection
    {
        protected BillingProfileCustomerPolicyCollection() { }
        public virtual Azure.Response<bool> Exists(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource> Get(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource>> GetAsync(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource> GetIfExists(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource>> GetIfExistsAsync(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingProfileCustomerPolicyResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingProfileCustomerPolicyResource() { }
        public virtual Azure.ResourceManager.Billing.BillingCustomerPolicyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string customerName, Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName policyName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingCustomerPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingCustomerPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfileCustomerResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingProfileCustomerResource() { }
        public virtual Azure.ResourceManager.Billing.BillingCustomerData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissions(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissionsAsync(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentData> CreateByCustomerBillingRoleAssignment(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties billingRoleAssignmentProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentData>> CreateByCustomerBillingRoleAssignmentAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties billingRoleAssignmentProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingCustomerPolicyData> CreateOrUpdateByCustomerPolicy(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingCustomerPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingCustomerPolicyData>> CreateOrUpdateByCustomerPolicyAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingCustomerPolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string customerName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource> GetBillingCustomerRoleAssignment(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource>> GetBillingCustomerRoleAssignmentAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentCollection GetBillingCustomerRoleAssignments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource> GetBillingCustomerRoleDefinition(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource>> GetBillingCustomerRoleDefinitionAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionCollection GetBillingCustomerRoleDefinitions() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileCustomerPolicyCollection GetBillingProfileCustomerPolicies() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource> GetBillingProfileCustomerPolicy(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource>> GetBillingProfileCustomerPolicyAsync(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequests(Azure.ResourceManager.Billing.Models.BillingProfileCustomerResourceGetBillingRequestsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequestsAsync(Azure.ResourceManager.Billing.Models.BillingProfileCustomerResourceGetBillingRequestsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSubscriptionData> GetBillingSubscriptions(Azure.ResourceManager.Billing.Models.BillingProfileCustomerResourceGetBillingSubscriptionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSubscriptionData> GetBillingSubscriptionsAsync(Azure.ResourceManager.Billing.Models.BillingProfileCustomerResourceGetBillingSubscriptionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.PartnerTransferDetailResource> GetPartnerTransferDetail(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.PartnerTransferDetailResource>> GetPartnerTransferDetailAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.PartnerTransferDetailCollection GetPartnerTransferDetails() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingTransactionData> GetTransactions(Azure.ResourceManager.Billing.Models.BillingProfileCustomerResourceGetTransactionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingTransactionData> GetTransactionsAsync(Azure.ResourceManager.Billing.Models.BillingProfileCustomerResourceGetTransactionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult> ResolveByCustomerBillingRoleAssignment(Azure.WaitUntil waitUntil, bool? resolveScopeDisplayNames = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>> ResolveByCustomerBillingRoleAssignmentAsync(Azure.WaitUntil waitUntil, bool? resolveScopeDisplayNames = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingCustomerData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingCustomerData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingCustomerData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingCustomerData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfileData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfileData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfileData>
    {
        public BillingProfileData() { }
        public Azure.ResourceManager.Billing.Models.BillingProfileProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingProfileData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfileData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfileData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingProfileData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfileData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfileData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfileData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfilePolicyData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>
    {
        public BillingProfilePolicyData() { }
        public Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingProfilePolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingProfilePolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfilePolicyResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingProfilePolicyResource() { }
        public virtual Azure.ResourceManager.Billing.BillingProfilePolicyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfilePolicyResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfilePolicyResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingProfilePolicyResource> CreateOrUpdate(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingProfilePolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingProfilePolicyResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingProfilePolicyData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfilePolicyResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfilePolicyResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfilePolicyResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfilePolicyResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfilePolicyResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfilePolicyResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingProfilePolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingProfilePolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfilePolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfileResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfileData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfileData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingProfileResource() { }
        public virtual Azure.ResourceManager.Billing.BillingProfileData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissions(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult> CheckAccessBillingPermissionsAsync(Azure.ResourceManager.Billing.Models.BillingCheckAccessContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentData> CreateByBillingProfileBillingRoleAssignment(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties billingRoleAssignmentProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentData>> CreateByBillingProfileBillingRoleAssignmentAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties billingRoleAssignmentProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource> GetBillingInvoiceSection(string invoiceSectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingInvoiceSectionResource>> GetBillingInvoiceSectionAsync(string invoiceSectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceSectionCollection GetBillingInvoiceSections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> GetBillingPaymentMethodLink(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>> GetBillingPaymentMethodLinkAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingPaymentMethodLinkCollection GetBillingPaymentMethodLinks() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingPermission> GetBillingPermissionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData> GetBillingProfileAvailableBalance(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData>> GetBillingProfileAvailableBalanceAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerResource> GetBillingProfileCustomer(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileCustomerResource>> GetBillingProfileCustomerAsync(string customerName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileCustomerCollection GetBillingProfileCustomers() { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfilePolicyResource GetBillingProfilePolicy() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource> GetBillingProfileRoleAssignment(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource>> GetBillingProfileRoleAssignmentAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileRoleAssignmentCollection GetBillingProfileRoleAssignments() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource> GetBillingProfileRoleDefinition(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource>> GetBillingProfileRoleDefinitionAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileRoleDefinitionCollection GetBillingProfileRoleDefinitions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource> GetBillingProfileSubscription(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource>> GetBillingProfileSubscriptionAsync(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileSubscriptionCollection GetBillingProfileSubscriptions() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequests(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetBillingRequestsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequestsAsync(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetBillingRequestsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingInvoiceData> GetInvoices(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetInvoicesOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingInvoiceData> GetInvoicesAsync(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetInvoicesOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingProductResource> GetProducts(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetProductsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingProductResource> GetProductsAsync(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetProductsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingReservationResource> GetReservations(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetReservationsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingReservationResource> GetReservationsAsync(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetReservationsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingTransactionData> GetTransactions(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetTransactionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingTransactionData> GetTransactionsAsync(Azure.ResourceManager.Billing.Models.BillingProfileResourceGetTransactionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult> ResolveByBillingProfileBillingRoleAssignment(Azure.WaitUntil waitUntil, bool? resolveScopeDisplayNames = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>> ResolveByBillingProfileBillingRoleAssignmentAsync(Azure.WaitUntil waitUntil, bool? resolveScopeDisplayNames = default(bool?), string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingProfileData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfileData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingProfileData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingProfileData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfileData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfileData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingProfileData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingProfileResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingProfileData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingProfileResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingProfileData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult> ValidateDeleteEligibility(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult>> ValidateDeleteEligibilityAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingProfileRoleAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource>, System.Collections.IEnumerable
    {
        protected BillingProfileRoleAssignmentCollection() { }
        public virtual Azure.Response<bool> Exists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource> Get(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource> GetAll(string filter = null, long? top = default(long?), long? skip = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource> GetAllAsync(string filter = null, long? top = default(long?), long? skip = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource>> GetAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource> GetIfExists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource>> GetIfExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingProfileRoleAssignmentResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingProfileRoleAssignmentResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string billingRoleAssignmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfileRoleDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource>, System.Collections.IEnumerable
    {
        protected BillingProfileRoleDefinitionCollection() { }
        public virtual Azure.Response<bool> Exists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource> Get(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource>> GetAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource> GetIfExists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource>> GetIfExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingProfileRoleDefinitionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingProfileRoleDefinitionResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string roleDefinitionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfileSubscriptionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource>, System.Collections.IEnumerable
    {
        protected BillingProfileSubscriptionCollection() { }
        public virtual Azure.Response<bool> Exists(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource> Get(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource> GetAll(Azure.ResourceManager.Billing.Models.BillingProfileSubscriptionCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingProfileSubscriptionCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource>> GetAsync(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource> GetIfExists(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource>> GetIfExistsAsync(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingProfileSubscriptionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingProfileSubscriptionResource() { }
        public virtual Azure.ResourceManager.Billing.BillingSubscriptionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string billingSubscriptionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingProfileSubscriptionResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingSubscriptionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingSubscriptionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingRequestCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingRequestResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingRequestResource>, System.Collections.IEnumerable
    {
        protected BillingRequestCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRequestResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string billingRequestName, Azure.ResourceManager.Billing.BillingRequestData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRequestResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string billingRequestName, Azure.ResourceManager.Billing.BillingRequestData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource> Get(string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingRequestResource> GetAll(Azure.ResourceManager.Billing.Models.BillingRequestCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingRequestResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingRequestCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource>> GetAsync(string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingRequestResource> GetIfExists(string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingRequestResource>> GetIfExistsAsync(string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingRequestResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingRequestResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingRequestResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingRequestResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingRequestData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRequestData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRequestData>
    {
        public BillingRequestData() { }
        public Azure.ResourceManager.Billing.Models.BillingRequestProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingRequestData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRequestData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRequestData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRequestData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRequestData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRequestData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRequestData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingRequestResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRequestData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRequestData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingRequestResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRequestData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingRequestName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRequestData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRequestData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRequestData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRequestData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRequestData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRequestData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRequestData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRequestResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingRequestData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRequestResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingRequestData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingReservationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingReservationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingReservationResource>, System.Collections.IEnumerable
    {
        protected BillingReservationCollection() { }
        public virtual Azure.Response<bool> Exists(string reservationId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string reservationId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource> Get(string reservationId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingReservationResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingReservationResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource>> GetAsync(string reservationId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingReservationResource> GetIfExists(string reservationId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingReservationResource>> GetIfExistsAsync(string reservationId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingReservationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingReservationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingReservationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingReservationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingReservationData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationData>
    {
        public BillingReservationData(Azure.Core.AzureLocation location) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates> Aggregates { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> AppliedScopes { get { throw null; } }
        public string AppliedScopeType { get { throw null; } }
        public System.DateTimeOffset? BenefitStartOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationBillingPlan? BillingPlan { get { throw null; } set { } }
        public string BillingScopeId { get { throw null; } }
        public string Capabilities { get { throw null; } set { } }
        public string DisplayName { get { throw null; } }
        public string DisplayProvisioningState { get { throw null; } }
        public System.DateTimeOffset? EffectiveOn { get { throw null; } }
        public int? ETag { get { throw null; } set { } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo ExtendedStatusInfo { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.InstanceFlexibility? InstanceFlexibility { get { throw null; } set { } }
        public bool? IsArchived { get { throw null; } set { } }
        public bool? IsRenewed { get { throw null; } }
        public System.DateTimeOffset? LastUpdatedOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.ReservationMergeProperties MergeProperties { get { throw null; } set { } }
        public string ProductCode { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public string ProvisioningSubState { get { throw null; } }
        public System.DateTimeOffset? PurchaseOn { get { throw null; } set { } }
        public float? Quantity { get { throw null; } }
        public string RenewDestination { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationRenewProperties RenewProperties { get { throw null; } set { } }
        public string RenewSource { get { throw null; } }
        public System.DateTimeOffset? ReservationExpireOn { get { throw null; } set { } }
        public System.DateTimeOffset? ReservationPurchaseOn { get { throw null; } set { } }
        public string ReservedResourceType { get { throw null; } }
        public System.DateTimeOffset? ReviewOn { get { throw null; } set { } }
        public string SkuDescription { get { throw null; } }
        public string SkuName { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.ReservationSplitProperties SplitProperties { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationSwapProperties SwapProperties { get { throw null; } set { } }
        public string Term { get { throw null; } }
        public string Trend { get { throw null; } }
        public string UserFriendlyAppliedScopeType { get { throw null; } }
        public string UserFriendlyRenewState { get { throw null; } }
        Azure.ResourceManager.Billing.BillingReservationData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingReservationData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingReservationOrderCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingReservationOrderResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingReservationOrderResource>, System.Collections.IEnumerable
    {
        protected BillingReservationOrderCollection() { }
        public virtual Azure.Response<bool> Exists(string reservationOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string reservationOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingReservationOrderResource> Get(string reservationOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingReservationOrderResource> GetAll(string filter = null, string orderBy = null, float? skiptoken = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingReservationOrderResource> GetAllAsync(string filter = null, string orderBy = null, float? skiptoken = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingReservationOrderResource>> GetAsync(string reservationOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingReservationOrderResource> GetIfExists(string reservationOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingReservationOrderResource>> GetIfExistsAsync(string reservationOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingReservationOrderResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingReservationOrderResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingReservationOrderResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingReservationOrderResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingReservationOrderData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationOrderData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationOrderData>
    {
        public BillingReservationOrderData() { }
        public System.DateTimeOffset? BenefitStartOn { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingAccountId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationBillingPlan? BillingPlan { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier CustomerId { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string EnrollmentId { get { throw null; } set { } }
        public int? ETag { get { throw null; } set { } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo ExtendedStatusInfo { get { throw null; } set { } }
        public int? OriginalQuantity { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation PlanInformation { get { throw null; } set { } }
        public string ProductCode { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public System.DateTimeOffset? RequestOn { get { throw null; } set { } }
        public System.DateTimeOffset? ReservationExpireOn { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.BillingReservationData> Reservations { get { throw null; } }
        public System.DateTimeOffset? ReviewedOn { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public string Term { get { throw null; } }
        Azure.ResourceManager.Billing.BillingReservationOrderData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingReservationOrderData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingReservationOrderResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationOrderData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationOrderData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingReservationOrderResource() { }
        public virtual Azure.ResourceManager.Billing.BillingReservationOrderData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string reservationOrderId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingReservationOrderResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingReservationOrderResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource> GetBillingReservation(string reservationId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource>> GetBillingReservationAsync(string reservationId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingReservationCollection GetBillingReservations() { throw null; }
        Azure.ResourceManager.Billing.BillingReservationOrderData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingReservationOrderData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationOrderData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingReservationResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingReservationResource() { }
        public virtual Azure.ResourceManager.Billing.BillingReservationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string reservationOrderId, string reservationId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingReservationResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingReservationData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingReservationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingReservationData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingReservationData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingReservationResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingReservationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingReservationResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingReservationPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingRoleAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>, System.Collections.IEnumerable
    {
        protected BillingRoleAssignmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string billingRoleAssignmentName, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string billingRoleAssignmentName, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> Get(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> GetAll(string filter = null, long? top = default(long?), long? skip = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> GetAllAsync(string filter = null, long? top = default(long?), long? skip = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>> GetAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> GetIfExists(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>> GetIfExistsAsync(string billingRoleAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingRoleAssignmentData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>
    {
        public BillingRoleAssignmentData() { }
        public Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingRoleAssignmentResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingRoleAssignmentResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingRoleAssignmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleAssignmentData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleAssignmentData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingRoleAssignmentResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingRoleAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingRoleDefinitionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingRoleDefinitionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingRoleDefinitionResource>, System.Collections.IEnumerable
    {
        protected BillingRoleDefinitionCollection() { }
        public virtual Azure.Response<bool> Exists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRoleDefinitionResource> Get(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingRoleDefinitionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingRoleDefinitionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRoleDefinitionResource>> GetAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingRoleDefinitionResource> GetIfExists(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingRoleDefinitionResource>> GetIfExistsAsync(string roleDefinitionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingRoleDefinitionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingRoleDefinitionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingRoleDefinitionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingRoleDefinitionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingRoleDefinitionData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>
    {
        public BillingRoleDefinitionData() { }
        public Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingRoleDefinitionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingRoleDefinitionResource() { }
        public virtual Azure.ResourceManager.Billing.BillingRoleDefinitionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string roleDefinitionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRoleDefinitionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRoleDefinitionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingRoleDefinitionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingRoleDefinitionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingSavingsPlanModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>, System.Collections.IEnumerable
    {
        protected BillingSavingsPlanModelCollection() { }
        public virtual Azure.Response<bool> Exists(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> Get(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>> GetAsync(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> GetIfExists(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>> GetIfExistsAsync(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingSavingsPlanModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>
    {
        public BillingSavingsPlanModelData(Azure.ResourceManager.Billing.Models.BillingSku sku) { }
        public Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public System.DateTimeOffset? BenefitStartOn { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingAccountId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingPlan? BillingPlan { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public string BillingScopeId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingBenefitCommitment Commitment { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier CustomerId { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public string DisplayProvisioningState { get { throw null; } }
        public System.DateTimeOffset? EffectiveOn { get { throw null; } }
        public System.DateTimeOffset? ExpiryOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.ExtendedStatusInfo ExtendedStatusInfo { get { throw null; } }
        public bool? IsRenewed { get { throw null; } set { } }
        public string ProductCode { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } set { } }
        public System.DateTimeOffset? PurchaseOn { get { throw null; } }
        public string RenewDestination { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPurchaseProperties RenewPurchaseProperties { get { throw null; } set { } }
        public string RenewSource { get { throw null; } set { } }
        public string SkuName { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm? Term { get { throw null; } set { } }
        public string UserFriendlyAppliedScopeType { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.SavingsPlanUtilization Utilization { get { throw null; } }
        Azure.ResourceManager.Billing.BillingSavingsPlanModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingSavingsPlanModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingSavingsPlanModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingSavingsPlanModelResource() { }
        public virtual Azure.ResourceManager.Billing.BillingSavingsPlanModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string savingsPlanOrderId, string savingsPlanId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingSavingsPlanModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingSavingsPlanModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSavingsPlanModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult> ValidateUpdateByBillingAccount(Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult>> ValidateUpdateByBillingAccountAsync(Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingSubscriptionAliasCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>, System.Collections.IEnumerable
    {
        protected BillingSubscriptionAliasCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string aliasName, Azure.ResourceManager.Billing.BillingSubscriptionAliasData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string aliasName, Azure.ResourceManager.Billing.BillingSubscriptionAliasData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> Get(string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> GetAll(Azure.ResourceManager.Billing.Models.BillingSubscriptionAliasCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> GetAll(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingSubscriptionAliasCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> GetAllAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> GetAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> GetIfExists(string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> GetIfExistsAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingSubscriptionAliasData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>
    {
        public BillingSubscriptionAliasData() { }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? AutoRenew { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingBeneficiary Beneficiary { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is now deprecated. Please use the new property `SubscriptionAliasBeneficiaryTenantId` moving forward.")]
        public string BeneficiaryTenantId { get { throw null; } set { } }
        public string BillingFrequency { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> BillingPolicies { get { throw null; } }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } set { } }
        public string BillingProfileName { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is now deprecated. Please use the new property `SubscriptionAliasSubscriptionId` moving forward.")]
        public Azure.Core.ResourceIdentifier BillingSubscriptionId { get { throw null; } }
        public string ConsumptionCostCenter { get { throw null; } set { } }
        public string CustomerDisplayName { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is now deprecated. Please use the new property `SubscriptionAliasCustomerId` moving forward.")]
        public string CustomerId { get { throw null; } set { } }
        public string CustomerName { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public string EnrollmentAccountDisplayName { get { throw null; } }
        public string EnrollmentAccountId { get { throw null; } }
        public System.DateTimeOffset? EnrollmentAccountStartOn { get { throw null; } }
        public string InvoiceSectionDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier InvoiceSectionId { get { throw null; } set { } }
        public string InvoiceSectionName { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount LastMonthCharges { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount MonthToDateCharges { get { throw null; } }
        public string NextBillingCycleBillingFrequency { get { throw null; } }
        public string OfferId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus? OperationStatus { get { throw null; } }
        public string ProductCategory { get { throw null; } }
        public string ProductType { get { throw null; } }
        public string ProductTypeId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public System.Guid? ProvisioningTenantId { get { throw null; } set { } }
        public System.DateTimeOffset? PurchaseOn { get { throw null; } }
        public long? Quantity { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails RenewalTermDetails { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller Reseller { get { throw null; } }
        public System.Uri ResourceUri { get { throw null; } }
        public string SkuDescription { get { throw null; } }
        public string SkuId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus? Status { get { throw null; } }
        public System.Guid? SubscriptionAliasBeneficiaryTenantId { get { throw null; } set { } }
        public string SubscriptionAliasCustomerId { get { throw null; } set { } }
        public string SubscriptionAliasSubscriptionId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus? SubscriptionEnrollmentAccountStatus { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails> SuspensionReasonDetails { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SuspensionReasons { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingSystemOverrides SystemOverrides { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public System.TimeSpan? TermDuration { get { throw null; } set { } }
        public System.DateTimeOffset? TermEndOn { get { throw null; } }
        public System.DateTimeOffset? TermStartOn { get { throw null; } }
        Azure.ResourceManager.Billing.BillingSubscriptionAliasData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingSubscriptionAliasData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingSubscriptionAliasResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingSubscriptionAliasResource() { }
        public virtual Azure.ResourceManager.Billing.BillingSubscriptionAliasData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string aliasName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingSubscriptionAliasData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingSubscriptionAliasData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionAliasData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingSubscriptionAliasData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingSubscriptionAliasData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingSubscriptionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingSubscriptionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingSubscriptionResource>, System.Collections.IEnumerable
    {
        protected BillingSubscriptionCollection() { }
        public virtual Azure.Response<bool> Exists(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.Response<bool> Exists(string billingSubscriptionName, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string billingSubscriptionName, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> Get(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> Get(string billingSubscriptionName, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSubscriptionResource> GetAll(Azure.ResourceManager.Billing.Models.BillingSubscriptionCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingSubscriptionResource> GetAll(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSubscriptionResource> GetAllAsync(Azure.ResourceManager.Billing.Models.BillingSubscriptionCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingSubscriptionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> GetAsync(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> GetAsync(string billingSubscriptionName, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingSubscriptionResource> GetIfExists(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingSubscriptionResource> GetIfExists(string billingSubscriptionName, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingSubscriptionResource>> GetIfExistsAsync(string billingSubscriptionName, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingSubscriptionResource>> GetIfExistsAsync(string billingSubscriptionName, System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingSubscriptionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingSubscriptionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingSubscriptionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingSubscriptionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingSubscriptionData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>
    {
        public BillingSubscriptionData() { }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? AutoRenew { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingBeneficiary Beneficiary { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is now deprecated. Please use the new property `SubscriptionBeneficiaryTenantId` moving forward.")]
        public string BeneficiaryTenantId { get { throw null; } set { } }
        public string BillingFrequency { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> BillingPolicies { get { throw null; } }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } set { } }
        public string BillingProfileName { get { throw null; } }
        public string ConsumptionCostCenter { get { throw null; } set { } }
        public string CustomerDisplayName { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is now deprecated. Please use the new property `SubscriptionCustomerId` moving forward.")]
        public string CustomerId { get { throw null; } set { } }
        public string CustomerName { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public string EnrollmentAccountDisplayName { get { throw null; } }
        public string EnrollmentAccountId { get { throw null; } }
        public System.DateTimeOffset? EnrollmentAccountStartOn { get { throw null; } }
        public string InvoiceSectionDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier InvoiceSectionId { get { throw null; } set { } }
        public string InvoiceSectionName { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount LastMonthCharges { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount MonthToDateCharges { get { throw null; } }
        public string NextBillingCycleBillingFrequency { get { throw null; } }
        public string OfferId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus? OperationStatus { get { throw null; } }
        public string ProductCategory { get { throw null; } }
        public string ProductType { get { throw null; } }
        public string ProductTypeId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public System.Guid? ProvisioningTenantId { get { throw null; } set { } }
        public System.DateTimeOffset? PurchaseOn { get { throw null; } }
        public long? Quantity { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails RenewalTermDetails { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller Reseller { get { throw null; } }
        public System.Uri ResourceUri { get { throw null; } }
        public string SkuDescription { get { throw null; } }
        public string SkuId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus? Status { get { throw null; } }
        public System.Guid? SubscriptionBeneficiaryTenantId { get { throw null; } set { } }
        public string SubscriptionCustomerId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus? SubscriptionEnrollmentAccountStatus { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails> SuspensionReasonDetails { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SuspensionReasons { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingSystemOverrides SystemOverrides { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public System.TimeSpan? TermDuration { get { throw null; } set { } }
        public System.DateTimeOffset? TermEndOn { get { throw null; } }
        public System.DateTimeOffset? TermStartOn { get { throw null; } }
        Azure.ResourceManager.Billing.BillingSubscriptionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingSubscriptionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingSubscriptionResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingSubscriptionResource() { }
        public virtual Azure.ResourceManager.Billing.BillingSubscriptionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Cancel(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.CancelSubscriptionContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> CancelAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.CancelSubscriptionContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingSubscriptionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> Get(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> GetAsync(System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource> Merge(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource>> MergeAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource> Move(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource>> MoveAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource> Split(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource>> SplitAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingSubscriptionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingSubscriptionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingSubscriptionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingSubscriptionData data, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.BillingSubscriptionData data, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingSubscriptionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult> ValidateMoveEligibility(Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult>> ValidateMoveEligibilityAsync(Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class BillingTransferDetailCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingTransferDetailResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingTransferDetailResource>, System.Collections.IEnumerable
    {
        protected BillingTransferDetailCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingTransferDetailResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string transferName, Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingTransferDetailResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string transferName, Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingTransferDetailResource> Get(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.BillingTransferDetailResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.BillingTransferDetailResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingTransferDetailResource>> GetAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.BillingTransferDetailResource> GetIfExists(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.BillingTransferDetailResource>> GetIfExistsAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.BillingTransferDetailResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.BillingTransferDetailResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.BillingTransferDetailResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingTransferDetailResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class BillingTransferDetailData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingTransferDetailData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingTransferDetailData>
    {
        public BillingTransferDetailData() { }
        public string CanceledBy { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.DetailedTransferStatus> DetailedTransferStatus { get { throw null; } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } }
        public string InitiatorEmailId { get { throw null; } }
        public string RecipientEmailId { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PartnerTransferStatus? TransferStatus { get { throw null; } }
        Azure.ResourceManager.Billing.BillingTransferDetailData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingTransferDetailData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingTransferDetailResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingTransferDetailData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingTransferDetailData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected BillingTransferDetailResource() { }
        public virtual Azure.ResourceManager.Billing.BillingTransferDetailData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingTransferDetailResource> Cancel(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingTransferDetailResource>> CancelAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string invoiceSectionName, string transferName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingTransferDetailResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingTransferDetailResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingTransferDetailData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingTransferDetailData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingTransferDetailData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingTransferDetailResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.BillingTransferDetailResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DefaultBillingInvoiceCollection : Azure.ResourceManager.ArmCollection
    {
        protected DefaultBillingInvoiceCollection() { }
        public virtual Azure.Response<bool> Exists(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource> Get(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource>> GetAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource> GetIfExists(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource>> GetIfExistsAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DefaultBillingInvoiceResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected DefaultBillingInvoiceResource() { }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string invoiceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingInvoiceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingInvoiceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PartnerTransferDetailCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.PartnerTransferDetailResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.PartnerTransferDetailResource>, System.Collections.IEnumerable
    {
        protected PartnerTransferDetailCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.PartnerTransferDetailResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string transferName, Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.PartnerTransferDetailResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string transferName, Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.PartnerTransferDetailResource> Get(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.PartnerTransferDetailResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.PartnerTransferDetailResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.PartnerTransferDetailResource>> GetAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.PartnerTransferDetailResource> GetIfExists(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.PartnerTransferDetailResource>> GetIfExistsAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.PartnerTransferDetailResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.PartnerTransferDetailResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.PartnerTransferDetailResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.PartnerTransferDetailResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class PartnerTransferDetailData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>
    {
        public PartnerTransferDetailData() { }
        public string CanceledBy { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.DetailedTransferStatus> DetailedTransferStatus { get { throw null; } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.InitiatorCustomerType? InitiatorCustomerType { get { throw null; } }
        public string InitiatorEmailId { get { throw null; } }
        public string RecipientEmailId { get { throw null; } }
        public string ResellerId { get { throw null; } }
        public string ResellerName { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PartnerTransferStatus? TransferStatus { get { throw null; } }
        Azure.ResourceManager.Billing.PartnerTransferDetailData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.PartnerTransferDetailData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PartnerTransferDetailResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected PartnerTransferDetailResource() { }
        public virtual Azure.ResourceManager.Billing.PartnerTransferDetailData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.PartnerTransferDetailResource> Cancel(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.PartnerTransferDetailResource>> CancelAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string billingProfileName, string customerName, string transferName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.PartnerTransferDetailResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.PartnerTransferDetailResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.PartnerTransferDetailData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.PartnerTransferDetailData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.PartnerTransferDetailData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.PartnerTransferDetailResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.PartnerTransferDetailResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class RecipientTransferDetailCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.RecipientTransferDetailResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.RecipientTransferDetailResource>, System.Collections.IEnumerable
    {
        protected RecipientTransferDetailCollection() { }
        public virtual Azure.Response<bool> Exists(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource> Get(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.RecipientTransferDetailResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.RecipientTransferDetailResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource>> GetAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.RecipientTransferDetailResource> GetIfExists(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.RecipientTransferDetailResource>> GetIfExistsAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.RecipientTransferDetailResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.RecipientTransferDetailResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.RecipientTransferDetailResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.RecipientTransferDetailResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class RecipientTransferDetailData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>
    {
        public RecipientTransferDetailData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.EligibleProductType> AllowedProductType { get { throw null; } }
        public string CanceledBy { get { throw null; } }
        public System.Guid? CustomerTenantId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.DetailedTransferStatus> DetailedTransferStatus { get { throw null; } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.InitiatorCustomerType? InitiatorCustomerType { get { throw null; } }
        public string InitiatorEmailId { get { throw null; } }
        public string RecipientEmailId { get { throw null; } }
        public string ResellerId { get { throw null; } }
        public string ResellerName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingSupportedAccountType> SupportedAccounts { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PartnerTransferStatus? TransferStatus { get { throw null; } }
        Azure.ResourceManager.Billing.RecipientTransferDetailData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.RecipientTransferDetailData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RecipientTransferDetailResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected RecipientTransferDetailResource() { }
        public virtual Azure.ResourceManager.Billing.RecipientTransferDetailData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource> Accept(Azure.ResourceManager.Billing.Models.AcceptTransferContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource>> AcceptAsync(Azure.ResourceManager.Billing.Models.AcceptTransferContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string transferName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource> Decline(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource>> DeclineAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.RecipientTransferDetailData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.RecipientTransferDetailData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.RecipientTransferDetailData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.Models.BillingTransferValidationResult> Validate(Azure.ResourceManager.Billing.Models.AcceptTransferContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.Models.BillingTransferValidationResult> ValidateAsync(Azure.ResourceManager.Billing.Models.AcceptTransferContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SavingsPlanOrderModelCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource>, System.Collections.IEnumerable
    {
        protected SavingsPlanOrderModelCollection() { }
        public virtual Azure.Response<bool> Exists(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource> Get(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource> GetAll(string filter = null, string orderBy = null, float? skiptoken = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource> GetAllAsync(string filter = null, string orderBy = null, float? skiptoken = default(float?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource>> GetAsync(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource> GetIfExists(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource>> GetIfExistsAsync(string savingsPlanOrderId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SavingsPlanOrderModelData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>
    {
        public SavingsPlanOrderModelData(Azure.ResourceManager.Billing.Models.BillingSku sku) { }
        public System.DateTimeOffset? BenefitStartOn { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingAccountId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingPlan? BillingPlan { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public string BillingScopeId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier CustomerId { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset? ExpiryOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.ExtendedStatusInfo ExtendedStatusInfo { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingPlanInformation PlanInformation { get { throw null; } set { } }
        public string ProductCode { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<string> SavingsPlans { get { throw null; } }
        public string SkuName { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm? Term { get { throw null; } set { } }
        Azure.ResourceManager.Billing.SavingsPlanOrderModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.SavingsPlanOrderModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SavingsPlanOrderModelResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SavingsPlanOrderModelResource() { }
        public virtual Azure.ResourceManager.Billing.SavingsPlanOrderModelData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string billingAccountName, string savingsPlanOrderId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource> Get(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.SavingsPlanOrderModelResource>> GetAsync(string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource> GetBillingSavingsPlanModel(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSavingsPlanModelResource>> GetBillingSavingsPlanModelAsync(string savingsPlanId, string expand = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingSavingsPlanModelCollection GetBillingSavingsPlanModels() { throw null; }
        Azure.ResourceManager.Billing.SavingsPlanOrderModelData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.SavingsPlanOrderModelData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SavingsPlanOrderModelData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubscriptionBillingInvoiceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource>, System.Collections.IEnumerable
    {
        protected SubscriptionBillingInvoiceCollection() { }
        public virtual Azure.Response<bool> Exists(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource> Get(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource> GetAll(Azure.ResourceManager.Billing.Models.SubscriptionBillingInvoiceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource> GetAllAsync(Azure.ResourceManager.Billing.Models.SubscriptionBillingInvoiceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource>> GetAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource> GetIfExists(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource>> GetIfExistsAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SubscriptionBillingInvoiceResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SubscriptionBillingInvoiceResource() { }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string invoiceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult> DownloadByBillingSubscription(Azure.WaitUntil waitUntil, string documentName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>> DownloadByBillingSubscriptionAsync(Azure.WaitUntil waitUntil, string documentName = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.BillingInvoiceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.BillingInvoiceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.BillingInvoiceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubscriptionPolicyData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>
    {
        public SubscriptionPolicyData() { }
        public Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.SubscriptionPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.SubscriptionPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubscriptionPolicyResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SubscriptionPolicyResource() { }
        public virtual Azure.ResourceManager.Billing.SubscriptionPolicyData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.SubscriptionPolicyResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.SubscriptionPolicyResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.Billing.SubscriptionPolicyData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.SubscriptionPolicyData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.SubscriptionPolicyData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.Billing.Mocking
{
    public partial class MockableBillingArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableBillingArmClient() { }
        public virtual Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource GetBillingAccountPaymentMethodResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingAccountPolicyResource GetBillingAccountPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingAccountResource GetBillingAccountResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingAgreementResource GetBillingAgreementResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingAssociatedTenantResource GetBillingAssociatedTenantResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingCustomerPolicyResource GetBillingCustomerPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingCustomerResource GetBillingCustomerResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingCustomerRoleAssignmentResource GetBillingCustomerRoleAssignmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingCustomerRoleDefinitionResource GetBillingCustomerRoleDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingDepartmentEnrollmentAccountResource GetBillingDepartmentEnrollmentAccountResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingDepartmentResource GetBillingDepartmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingDepartmentRoleAssignmentResource GetBillingDepartmentRoleAssignmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingDepartmentRoleDefinitionResource GetBillingDepartmentRoleDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingEnrollmentAccountResource GetBillingEnrollmentAccountResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleAssignmentResource GetBillingEnrollmentAccountRoleAssignmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingEnrollmentAccountRoleDefinitionResource GetBillingEnrollmentAccountRoleDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceResource GetBillingInvoiceResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceSectionResource GetBillingInvoiceSectionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceSectionRoleAssignmentResource GetBillingInvoiceSectionRoleAssignmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingInvoiceSectionRoleDefinitionResource GetBillingInvoiceSectionRoleDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource GetBillingPaymentMethodLinkResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingPaymentMethodResource GetBillingPaymentMethodResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProductResource GetBillingProductResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileCustomerPolicyResource GetBillingProfileCustomerPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileCustomerResource GetBillingProfileCustomerResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfilePolicyResource GetBillingProfilePolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileResource GetBillingProfileResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileRoleAssignmentResource GetBillingProfileRoleAssignmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileRoleDefinitionResource GetBillingProfileRoleDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingProfileSubscriptionResource GetBillingProfileSubscriptionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingRequestResource GetBillingRequestResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingReservationOrderResource GetBillingReservationOrderResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingReservationResource GetBillingReservationResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingRoleAssignmentResource GetBillingRoleAssignmentResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingRoleDefinitionResource GetBillingRoleDefinitionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingSavingsPlanModelResource GetBillingSavingsPlanModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingSubscriptionAliasResource GetBillingSubscriptionAliasResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingSubscriptionResource GetBillingSubscriptionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingTransferDetailResource GetBillingTransferDetailResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.DefaultBillingInvoiceResource GetDefaultBillingInvoiceResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.PartnerTransferDetailResource GetPartnerTransferDetailResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.RecipientTransferDetailResource GetRecipientTransferDetailResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.SavingsPlanOrderModelResource GetSavingsPlanOrderModelResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource GetSubscriptionBillingInvoiceResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.Billing.SubscriptionPolicyResource GetSubscriptionPolicyResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableBillingSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableBillingSubscriptionResource() { }
        public virtual Azure.ResourceManager.Billing.SubscriptionPolicyResource GetSubscriptionPolicy() { throw null; }
    }
    public partial class MockableBillingTenantResource : Azure.ResourceManager.ArmResource
    {
        protected MockableBillingTenantResource() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult> DownloadDocumentsByBillingSubscriptionInvoice(Azure.WaitUntil waitUntil, string subscriptionId, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent> arrayOfDocumentDownloadRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>> DownloadDocumentsByBillingSubscriptionInvoiceAsync(Azure.WaitUntil waitUntil, string subscriptionId, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent> arrayOfDocumentDownloadRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource> GetBillingAccount(string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountResource>> GetBillingAccountAsync(string billingAccountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource> GetBillingAccountPaymentMethod(string billingAccountName, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingAccountPaymentMethodResource>> GetBillingAccountPaymentMethodAsync(string billingAccountName, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.ResourceManager.Billing.BillingAccountPaymentMethodCollection GetBillingAccountPaymentMethods(string billingAccountName) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingAccountCollection GetBillingAccounts() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodResource> GetBillingPaymentMethod(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodResource>> GetBillingPaymentMethodAsync(string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource> GetBillingPaymentMethodLink(string billingAccountName, string billingProfileName, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingPaymentMethodLinkResource>> GetBillingPaymentMethodLinkAsync(string billingAccountName, string billingProfileName, string paymentMethodName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.ResourceManager.Billing.BillingPaymentMethodLinkCollection GetBillingPaymentMethodLinks(string billingAccountName, string billingProfileName) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingPaymentMethodCollection GetBillingPaymentMethods() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource> GetBillingRequest(string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingRequestResource>> GetBillingRequestAsync(string billingRequestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.BillingRequestCollection GetBillingRequests() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource> GetBillingSubscription(string billingAccountName, string billingSubscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource> GetBillingSubscriptionAlias(string billingAccountName, string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionAliasResource>> GetBillingSubscriptionAliasAsync(string billingAccountName, string aliasName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.ResourceManager.Billing.BillingSubscriptionAliasCollection GetBillingSubscriptionAliases(string billingAccountName) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.BillingSubscriptionResource>> GetBillingSubscriptionAsync(string billingAccountName, string billingSubscriptionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public virtual Azure.ResourceManager.Billing.BillingSubscriptionCollection GetBillingSubscriptions(string billingAccountName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource> GetDefaultBillingInvoice(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.DefaultBillingInvoiceResource>> GetDefaultBillingInvoiceAsync(string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.DefaultBillingInvoiceCollection GetDefaultBillingInvoices() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource> GetRecipientTransferDetail(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.RecipientTransferDetailResource>> GetRecipientTransferDetailAsync(string transferName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.RecipientTransferDetailCollection GetRecipientTransferDetails() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource> GetSubscriptionBillingInvoice(string subscriptionId, string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.SubscriptionBillingInvoiceResource>> GetSubscriptionBillingInvoiceAsync(string subscriptionId, string invoiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.Billing.SubscriptionBillingInvoiceCollection GetSubscriptionBillingInvoices(string subscriptionId) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult> ValidateAddres(Azure.ResourceManager.Billing.Models.BillingAddressDetails details, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult>> ValidateAddresAsync(Azure.ResourceManager.Billing.Models.BillingAddressDetails details, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.Billing.Models
{
    public partial class AcceptTransferContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.AcceptTransferContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.AcceptTransferContent>
    {
        public AcceptTransferContent() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingProductDetails> ProductDetails { get { throw null; } }
        Azure.ResourceManager.Billing.Models.AcceptTransferContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.AcceptTransferContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.AcceptTransferContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.AcceptTransferContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.AcceptTransferContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.AcceptTransferContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.AcceptTransferContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AgreementAcceptanceMode : System.IEquatable<Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AgreementAcceptanceMode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode ClickToAccept { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode ESignEmbedded { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode ESignOffline { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode Implicit { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode Offline { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode PhysicalSign { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode left, Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode left, Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmBillingModelFactory
    {
        public static Azure.ResourceManager.Billing.BillingAccountData BillingAccountData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingAccountProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails BillingAccountEnrollmentDetails(System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), string currency = null, string channel = null, string language = null, string countryCode = null, string billingCycle = null, Azure.ResourceManager.Billing.Models.ExtendedTermOption? extendedTermOption = default(Azure.ResourceManager.Billing.Models.ExtendedTermOption?), Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel? supportLevel = default(Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel?), string supportCoverage = null, string cloud = null, string poNumber = null, Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus? markupStatus = default(Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus?), Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo indirectRelationshipInfo = null, string invoiceRecipient = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAccountPatch BillingAccountPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingAccountProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingAccountPolicyData BillingAccountPolicyData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties BillingAccountPolicyProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies enterpriseAgreementPolicies = null, Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy? marketplacePurchases = default(Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy?), Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy? reservationPurchases = default(Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy?), Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy? savingsPlanPurchases = default(Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPolicySummary> policies = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAccountProperties BillingAccountProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), Azure.ResourceManager.Billing.Models.BillingAccountStatus? accountStatus = default(Azure.ResourceManager.Billing.Models.BillingAccountStatus?), Azure.ResourceManager.Billing.Models.BillingAccountType? accountType = default(Azure.ResourceManager.Billing.Models.BillingAccountType?), Azure.ResourceManager.Billing.Models.BillingAccountSubType? accountSubType = default(Azure.ResourceManager.Billing.Models.BillingAccountSubType?), Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode? accountStatusReasonCode = default(Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode?), Azure.ResourceManager.Billing.Models.BillingAgreementType? agreementType = default(Azure.ResourceManager.Billing.Models.BillingAgreementType?), string displayName = null, Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails enrollmentDetails = null, bool? hasReadAccess = default(bool?), bool? hasNoBillingProfiles = default(bool?), string notificationEmailAddress = null, System.Guid? primaryBillingTenantId = default(System.Guid?), Azure.ResourceManager.Billing.Models.BillingAddressDetails soldTo = null, Azure.ResourceManager.Billing.Models.BillingRegistrationNumber registrationNumber = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingRelationshipType> billingRelationshipTypes = null, System.Collections.Generic.IEnumerable<string> qualifications = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingTaxIdentifier> taxIds = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAddressValidationResult BillingAddressValidationResult(Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus? status = default(Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingAddressDetails> suggestedAddresses = null, string validationMessage = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingAgreementData BillingAgreementData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingAgreementProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementParticipant BillingAgreementParticipant(string email = null, string status = null, System.DateTimeOffset? statusOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementProperties BillingAgreementProperties(Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode? acceptanceMode = default(Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode?), string agreementLink = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingProfileInfo> billingProfileInfo = null, Azure.ResourceManager.Billing.Models.BillingAgreementCategory? category = default(Azure.ResourceManager.Billing.Models.BillingAgreementCategory?), string displayName = null, System.DateTimeOffset? effectiveOn = default(System.DateTimeOffset?), System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingAgreementParticipant> participants = null, string status = null, string leadBillingAccountName = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAmount BillingAmount(string currency = null, float? value = default(float?)) { throw null; }
        public static Azure.ResourceManager.Billing.BillingAssociatedTenantData BillingAssociatedTenantData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties BillingAssociatedTenantProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), string displayName = null, System.Guid? tenantId = default(System.Guid?), Azure.ResourceManager.Billing.Models.BillingManagementTenantState? billingManagementState = default(Azure.ResourceManager.Billing.Models.BillingManagementTenantState?), Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState? provisioningManagementState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState?), string provisioningBillingRequestId = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData BillingAvailableBalanceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties BillingAvailableBalanceProperties(Azure.ResourceManager.Billing.Models.BillingAmount amount = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount> paymentsOnAccount = null, Azure.ResourceManager.Billing.Models.BillingAmount totalPaymentsOnAccount = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingCheckAccessResult BillingCheckAccessResult(Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision? accessDecision = default(Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision?), string action = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingCustomerData BillingCustomerData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingCustomerProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingCustomerPolicyData BillingCustomerPolicyData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties BillingCustomerPolicyProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), Azure.ResourceManager.Billing.Models.ViewChargesPolicy viewCharges = default(Azure.ResourceManager.Billing.Models.ViewChargesPolicy), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPolicySummary> policies = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingCustomerProperties BillingCustomerProperties(string billingProfileDisplayName = null, Azure.Core.ResourceIdentifier billingProfileId = null, string displayName = null, string systemId = null, Azure.ResourceManager.Billing.Models.BillingCustomerStatus? status = default(Azure.ResourceManager.Billing.Models.BillingCustomerStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingAzurePlan> enabledAzurePlans = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller> resellers = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingDepartmentData BillingDepartmentData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingDepartmentProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingDepartmentProperties BillingDepartmentProperties(string costCenter = null, string displayName = null, string id = null, string status = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult BillingDocumentDownloadResult(System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), System.Uri uri = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingEnrollmentAccountData BillingEnrollmentAccountData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties BillingEnrollmentAccountProperties(string costCenter = null, string displayName = null, string departmentDisplayName = null, string departmentId = null, bool? isDevTestEnabled = default(bool?), string accountOwner = null, string authType = null, string status = null, System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.Billing.BillingInvoiceData BillingInvoiceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingInvoiceProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment BillingInvoiceFailedPayment(System.DateTimeOffset? on = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason? failedPaymentReason = default(Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingInvoicePayment BillingInvoicePayment(Azure.ResourceManager.Billing.Models.BillingAmount amount = null, System.DateTimeOffset? madeOn = default(System.DateTimeOffset?), Azure.Core.ResourceIdentifier paymentMethodId = null, Azure.ResourceManager.Billing.Models.PaymentMethodFamily? paymentMethodFamily = default(Azure.ResourceManager.Billing.Models.PaymentMethodFamily?), string paymentMethodType = null, string paymentType = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceProperties BillingInvoiceProperties(Azure.ResourceManager.Billing.Models.BillingAmount amountDue = null, Azure.ResourceManager.Billing.Models.BillingAmount azurePrepaymentApplied = null, Azure.ResourceManager.Billing.Models.BillingAmount billedAmount = null, string billedDocumentId = null, string billingProfileDisplayName = null, Azure.Core.ResourceIdentifier billingProfileId = null, Azure.ResourceManager.Billing.Models.BillingAmount creditAmount = null, string creditForDocumentId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.InvoiceDocument> documents = null, Azure.ResourceManager.Billing.Models.InvoiceDocumentType? documentType = default(Azure.ResourceManager.Billing.Models.InvoiceDocumentType?), System.DateTimeOffset? dueOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment> failedPayments = null, Azure.ResourceManager.Billing.Models.BillingAmount freeAzureCreditApplied = null, System.DateTimeOffset? invoiceOn = default(System.DateTimeOffset?), System.DateTimeOffset? invoicePeriodEndOn = default(System.DateTimeOffset?), System.DateTimeOffset? invoicePeriodStartOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.BillingInvoiceType? invoiceType = default(Azure.ResourceManager.Billing.Models.BillingInvoiceType?), bool? isMonthlyInvoice = default(bool?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingInvoicePayment> payments = null, string purchaseOrderNumber = null, Azure.ResourceManager.Billing.Models.RebillDetails rebillDetails = null, Azure.ResourceManager.Billing.Models.BillingInvoiceStatus? status = default(Azure.ResourceManager.Billing.Models.BillingInvoiceStatus?), string subscriptionDisplayName = null, string subscriptionId = null, Azure.ResourceManager.Billing.Models.SpecialTaxationType? specialTaxationType = default(Azure.ResourceManager.Billing.Models.SpecialTaxationType?), Azure.ResourceManager.Billing.Models.BillingAmount subTotal = null, Azure.ResourceManager.Billing.Models.BillingAmount taxAmount = null, Azure.ResourceManager.Billing.Models.BillingAmount totalAmount = null, Azure.ResourceManager.Billing.Models.RefundDetailsSummary refundDetails = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingInvoiceSectionData BillingInvoiceSectionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties BillingInvoiceSectionProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), string displayName = null, Azure.ResourceManager.Billing.Models.InvoiceSectionState? state = default(Azure.ResourceManager.Billing.Models.InvoiceSectionState?), Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode? reasonCode = default(Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode?), string systemId = null, string targetCloud = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingPaymentMethodData BillingPaymentMethodData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.ResourceIdentifier paymentMethodId = null, string accountHolderName = null, string displayName = null, string expiration = null, Azure.ResourceManager.Billing.Models.PaymentMethodFamily? family = default(Azure.ResourceManager.Billing.Models.PaymentMethodFamily?), string lastFourDigits = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.PaymentMethodLogo> logos = null, string paymentMethodType = null, Azure.ResourceManager.Billing.Models.PaymentMethodStatus? status = default(Azure.ResourceManager.Billing.Models.PaymentMethodStatus?), System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.BillingPaymentMethodData BillingPaymentMethodData(Azure.Core.ResourceIdentifier id, string name, Azure.Core.ResourceType resourceType, Azure.ResourceManager.Models.SystemData systemData, Azure.ResourceManager.Billing.Models.PaymentMethodFamily? family, string paymentMethodType, string accountHolderName, string expiration, string lastFourDigits, string displayName, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.PaymentMethodLogo> logos, Azure.ResourceManager.Billing.Models.PaymentMethodStatus? status) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.BillingPaymentMethodLinkData BillingPaymentMethodLinkData(Azure.Core.ResourceIdentifier id, string name, Azure.Core.ResourceType resourceType, Azure.ResourceManager.Models.SystemData systemData, Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties paymentMethod) { throw null; }
        public static Azure.ResourceManager.Billing.BillingPaymentMethodLinkData BillingPaymentMethodLinkData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string accountHolderName = null, string displayName = null, string expiration = null, Azure.ResourceManager.Billing.Models.PaymentMethodFamily? family = default(Azure.ResourceManager.Billing.Models.PaymentMethodFamily?), string lastFourDigits = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.PaymentMethodLogo> logos = null, Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties paymentMethod = null, Azure.Core.ResourceIdentifier paymentMethodId = null, string paymentMethodType = null, Azure.ResourceManager.Billing.Models.PaymentMethodStatus? status = default(Azure.ResourceManager.Billing.Models.PaymentMethodStatus?), System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount BillingPaymentOnAccount(Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller amount = null, Azure.Core.ResourceIdentifier billingProfileId = null, string billingProfileDisplayName = null, Azure.Core.ResourceIdentifier invoiceId = null, string invoiceName = null, System.DateTimeOffset? on = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.PaymentMethodFamily? paymentMethodType = default(Azure.ResourceManager.Billing.Models.PaymentMethodFamily?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingPaymentTerm BillingPaymentTerm(string term = null, System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), bool? isDefault = default(bool?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingPermission BillingPermission(System.Collections.Generic.IEnumerable<string> actions = null, System.Collections.Generic.IEnumerable<string> notActions = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail BillingPlanPaymentDetail(System.DateTimeOffset? dueOn = default(System.DateTimeOffset?), System.DateTimeOffset? paymentCompletedOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.BillingPrice pricingCurrencyTotal = null, Azure.ResourceManager.Billing.Models.BillingPrice billingCurrencyTotal = null, Azure.ResourceManager.Billing.Models.BillingPaymentStatus? status = default(Azure.ResourceManager.Billing.Models.BillingPaymentStatus?), Azure.ResourceManager.Billing.Models.ExtendedStatusInfo extendedStatusInfo = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProductData BillingProductData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingProductProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProductPatch BillingProductPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingProductProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProductProperties BillingProductProperties(Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? autoRenew = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState?), string availabilityId = null, string billingFrequency = null, Azure.Core.ResourceIdentifier billingProfileId = null, string billingProfileDisplayName = null, Azure.Core.ResourceIdentifier customerId = null, string customerDisplayName = null, string displayName = null, string endDate = null, Azure.Core.ResourceIdentifier invoiceSectionId = null, string invoiceSectionDisplayName = null, Azure.ResourceManager.Billing.Models.BillingAmount lastCharge = null, string lastChargeDate = null, string productType = null, string productTypeId = null, string skuId = null, string skuDescription = null, string purchaseDate = null, long? quantity = default(long?), Azure.ResourceManager.Billing.Models.BillingProductStatus? status = default(Azure.ResourceManager.Billing.Models.BillingProductStatus?), System.Guid? tenantId = default(System.Guid?), Azure.ResourceManager.Billing.Models.BillingAmount reseller = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProfileData BillingProfileData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingProfileProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProfileInfo BillingProfileInfo(Azure.Core.ResourceIdentifier billingAccountId = null, string billingProfileDisplayName = null, Azure.Core.ResourceIdentifier billingProfileId = null, string billingProfileSystemId = null, string indirectRelationshipOrganizationName = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingProfilePolicyData BillingProfilePolicyData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties BillingProfilePolicyProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies enterpriseAgreementPolicies = null, Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy? invoiceSectionLabelManagement = default(Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy?), Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy? marketplacePurchases = default(Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy?), Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy? reservationPurchases = default(Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy?), Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy? savingsPlanPurchases = default(Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy?), Azure.ResourceManager.Billing.Models.ViewChargesPolicy? viewCharges = default(Azure.ResourceManager.Billing.Models.ViewChargesPolicy?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPolicySummary> policies = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProfileProperties BillingProfileProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), Azure.ResourceManager.Billing.Models.BillingRelationshipType? billingRelationshipType = default(Azure.ResourceManager.Billing.Models.BillingRelationshipType?), Azure.ResourceManager.Billing.Models.BillingAddressDetails billTo = null, string currency = null, string displayName = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingAzurePlan> enabledAzurePlans = null, bool? hasReadAccess = default(bool?), Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo indirectRelationshipInfo = null, int? invoiceDay = default(int?), bool? isInvoiceEmailOptIn = default(bool?), System.Collections.Generic.IEnumerable<string> invoiceRecipients = null, string poNumber = null, Azure.ResourceManager.Billing.Models.BillingAddressDetails shipTo = null, Azure.ResourceManager.Billing.Models.BillingAddressDetails soldTo = null, Azure.ResourceManager.Billing.Models.BillingSpendingLimit? spendingLimit = default(Azure.ResourceManager.Billing.Models.BillingSpendingLimit?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.SpendingLimitDetails> spendingLimitDetails = null, Azure.ResourceManager.Billing.Models.BillingProfileStatus? status = default(Azure.ResourceManager.Billing.Models.BillingProfileStatus?), Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode? statusReasonCode = default(Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode?), string systemId = null, System.Collections.Generic.IDictionary<string, string> tags = null, System.Collections.Generic.IEnumerable<string> targetClouds = null, Azure.ResourceManager.Billing.Models.BillingPaymentTerm currentPaymentTerm = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPaymentTerm> otherPaymentTerms = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingRegistrationNumber BillingRegistrationNumber(string id = null, bool? isRequired = default(bool?), System.Collections.Generic.IEnumerable<string> registrationNumberType = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingRequestData BillingRequestData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingRequestProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingRequestProperties BillingRequestProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), System.Collections.Generic.IDictionary<string, string> additionalInformation = null, Azure.ResourceManager.Billing.Models.BillingPrincipal reviewedBy = null, System.DateTimeOffset? reviewalOn = default(System.DateTimeOffset?), Azure.Core.ResourceIdentifier billingAccountId = null, string billingAccountName = null, string billingAccountDisplayName = null, System.Guid? billingAccountPrimaryBillingTenantId = default(System.Guid?), Azure.Core.ResourceIdentifier billingProfileId = null, string billingProfileName = null, string billingProfileDisplayName = null, Azure.ResourceManager.Billing.Models.BillingPrincipal createdBy = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), string decisionReason = null, Azure.Core.ResourceIdentifier invoiceSectionId = null, string invoiceSectionName = null, string invoiceSectionDisplayName = null, Azure.Core.ResourceIdentifier customerId = null, string customerName = null, string customerDisplayName = null, string subscriptionId = null, string subscriptionName = null, string subscriptionDisplayName = null, string justification = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPrincipal> recipients = null, string requestScope = null, string billingScope = null, Azure.ResourceManager.Billing.Models.BillingRequestStatus? status = default(Azure.ResourceManager.Billing.Models.BillingRequestStatus?), Azure.ResourceManager.Billing.Models.BillingRequestType? requestType = default(Azure.ResourceManager.Billing.Models.BillingRequestType?), Azure.ResourceManager.Billing.Models.BillingPrincipal lastUpdatedBy = null, System.DateTimeOffset? lastUpdatedOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.Billing.BillingReservationData BillingReservationData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), int? etag = default(int?), string skuName = null, string reservedResourceType = null, Azure.ResourceManager.Billing.Models.InstanceFlexibility? instanceFlexibility = default(Azure.ResourceManager.Billing.Models.InstanceFlexibility?), string displayName = null, System.Collections.Generic.IEnumerable<string> appliedScopes = null, string appliedScopeType = null, bool? isArchived = default(bool?), string capabilities = null, float? quantity = default(float?), string provisioningState = null, System.DateTimeOffset? effectiveOn = default(System.DateTimeOffset?), System.DateTimeOffset? benefitStartOn = default(System.DateTimeOffset?), System.DateTimeOffset? lastUpdatedOn = default(System.DateTimeOffset?), System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), System.DateTimeOffset? reservationExpireOn = default(System.DateTimeOffset?), System.DateTimeOffset? reviewOn = default(System.DateTimeOffset?), string skuDescription = null, Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo extendedStatusInfo = null, Azure.ResourceManager.Billing.Models.ReservationBillingPlan? billingPlan = default(Azure.ResourceManager.Billing.Models.ReservationBillingPlan?), string displayProvisioningState = null, string provisioningSubState = null, System.DateTimeOffset? purchaseOn = default(System.DateTimeOffset?), System.DateTimeOffset? reservationPurchaseOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.ReservationSplitProperties splitProperties = null, Azure.ResourceManager.Billing.Models.ReservationMergeProperties mergeProperties = null, Azure.ResourceManager.Billing.Models.ReservationSwapProperties swapProperties = null, Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties appliedScopeProperties = null, string billingScopeId = null, bool? isRenewed = default(bool?), string renewSource = null, string renewDestination = null, Azure.ResourceManager.Billing.Models.ReservationRenewProperties renewProperties = null, string term = null, string userFriendlyAppliedScopeType = null, string userFriendlyRenewState = null, string productCode = null, string trend = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates> aggregates = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingReservationOrderData BillingReservationOrderData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, int? etag = default(int?), System.Collections.Generic.IDictionary<string, string> tags = null, string displayName = null, string enrollmentId = null, Azure.Core.ResourceIdentifier customerId = null, Azure.Core.ResourceIdentifier billingProfileId = null, Azure.Core.ResourceIdentifier billingAccountId = null, System.DateTimeOffset? requestOn = default(System.DateTimeOffset?), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), System.DateTimeOffset? reservationExpireOn = default(System.DateTimeOffset?), System.DateTimeOffset? benefitStartOn = default(System.DateTimeOffset?), int? originalQuantity = default(int?), string term = null, string provisioningState = null, Azure.ResourceManager.Billing.Models.ReservationBillingPlan? billingPlan = default(Azure.ResourceManager.Billing.Models.ReservationBillingPlan?), Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation planInformation = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingReservationData> reservations = null, System.DateTimeOffset? reviewedOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo extendedStatusInfo = null, string productCode = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingRoleAssignmentData BillingRoleAssignmentData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult BillingRoleAssignmentListResult(string nextLink = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.BillingRoleAssignmentData> value = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties BillingRoleAssignmentProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.Guid? createdByPrincipalTenantId = default(System.Guid?), string createdByPrincipalId = null, string createdByPrincipalPuid = null, string createdByUserEmailAddress = null, System.DateTimeOffset? modifiedOn = default(System.DateTimeOffset?), string modifiedByPrincipalPuid = null, string modifiedByUserEmailAddress = null, string modifiedByPrincipalId = null, System.Guid? modifiedByPrincipalTenantId = default(System.Guid?), string principalPuid = null, string principalId = null, System.Guid? principalTenantId = default(System.Guid?), Azure.Core.ResourceIdentifier roleDefinitionId = null, string scope = null, string userAuthenticationType = null, string userEmailAddress = null, string principalTenantName = null, string principalDisplayName = null, Azure.ResourceManager.Billing.Models.BillingPrincipalType? principalType = default(Azure.ResourceManager.Billing.Models.BillingPrincipalType?), Azure.Core.ResourceIdentifier billingRequestId = null, Azure.Core.ResourceIdentifier billingAccountId = null, string billingAccountDisplayName = null, Azure.Core.ResourceIdentifier billingProfileId = null, string billingProfileDisplayName = null, Azure.Core.ResourceIdentifier invoiceSectionId = null, string invoiceSectionDisplayName = null, Azure.Core.ResourceIdentifier customerId = null, string customerDisplayName = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingRoleDefinitionData BillingRoleDefinitionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties BillingRoleDefinitionProperties(string description = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPermission> permissions = null, string roleName = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingSavingsPlanModelData BillingSavingsPlanModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string skuName = null, string displayName = null, Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), string displayProvisioningState = null, string userFriendlyAppliedScopeType = null, string billingScopeId = null, Azure.Core.ResourceIdentifier billingProfileId = null, Azure.Core.ResourceIdentifier customerId = null, Azure.Core.ResourceIdentifier billingAccountId = null, Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm? term = default(Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm?), bool? isRenewed = default(bool?), string renewSource = null, string renewDestination = null, Azure.ResourceManager.Billing.Models.BillingPurchaseProperties renewPurchaseProperties = null, Azure.ResourceManager.Billing.Models.BillingPlan? billingPlan = default(Azure.ResourceManager.Billing.Models.BillingPlan?), Azure.ResourceManager.Billing.Models.BillingAppliedScopeType? appliedScopeType = default(Azure.ResourceManager.Billing.Models.BillingAppliedScopeType?), Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties appliedScopeProperties = null, Azure.ResourceManager.Billing.Models.BillingBenefitCommitment commitment = null, System.DateTimeOffset? effectiveOn = default(System.DateTimeOffset?), System.DateTimeOffset? benefitStartOn = default(System.DateTimeOffset?), System.DateTimeOffset? expiryOn = default(System.DateTimeOffset?), System.DateTimeOffset? purchaseOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.SavingsPlanUtilization utilization = null, Azure.ResourceManager.Billing.Models.ExtendedStatusInfo extendedStatusInfo = null, string productCode = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.BillingSubscriptionAliasData BillingSubscriptionAliasData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? autoRenew = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState?), System.Guid? subscriptionAliasBeneficiaryTenantId = default(System.Guid?), Azure.ResourceManager.Billing.Models.BillingBeneficiary beneficiary = null, string billingFrequency = null, Azure.Core.ResourceIdentifier billingProfileId = null, System.Collections.Generic.IReadOnlyDictionary<string, string> billingPolicies = null, string billingProfileDisplayName = null, string billingProfileName = null, string consumptionCostCenter = null, string subscriptionAliasCustomerId = null, string customerDisplayName = null, string customerName = null, string displayName = null, string enrollmentAccountId = null, string enrollmentAccountDisplayName = null, Azure.Core.ResourceIdentifier invoiceSectionId = null, string invoiceSectionDisplayName = null, string invoiceSectionName = null, Azure.ResourceManager.Billing.Models.BillingAmount lastMonthCharges = null, Azure.ResourceManager.Billing.Models.BillingAmount monthToDateCharges = null, string nextBillingCycleBillingFrequency = null, string offerId = null, string productCategory = null, string productType = null, string productTypeId = null, System.DateTimeOffset? purchaseOn = default(System.DateTimeOffset?), long? quantity = default(long?), Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller reseller = null, Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails renewalTermDetails = null, string skuId = null, string skuDescription = null, Azure.ResourceManager.Billing.Models.BillingSystemOverrides systemOverrides = null, System.Uri resourceUri = null, System.TimeSpan? termDuration = default(System.TimeSpan?), System.DateTimeOffset? termStartOn = default(System.DateTimeOffset?), System.DateTimeOffset? termEndOn = default(System.DateTimeOffset?), System.Guid? provisioningTenantId = default(System.Guid?), Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus? status = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus?), Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus? operationStatus = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus?), Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), string subscriptionId = null, System.Collections.Generic.IEnumerable<string> suspensionReasons = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails> suspensionReasonDetails = null, System.DateTimeOffset? enrollmentAccountStartOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus = default(Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus?), string subscriptionAliasSubscriptionId = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.BillingSubscriptionAliasData BillingSubscriptionAliasData(Azure.Core.ResourceIdentifier id, string name, Azure.Core.ResourceType resourceType, Azure.ResourceManager.Models.SystemData systemData, Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? autoRenew, string beneficiaryTenantId, string billingFrequency, Azure.Core.ResourceIdentifier billingProfileId, System.Collections.Generic.IReadOnlyDictionary<string, string> billingPolicies, string billingProfileDisplayName, string billingProfileName, string consumptionCostCenter, string customerId, string customerDisplayName, string displayName, string enrollmentAccountId, string enrollmentAccountDisplayName, Azure.Core.ResourceIdentifier invoiceSectionId, string invoiceSectionDisplayName, string invoiceSectionName, Azure.ResourceManager.Billing.Models.BillingAmount lastMonthCharges, Azure.ResourceManager.Billing.Models.BillingAmount monthToDateCharges, string nextBillingCycleBillingFrequency, string offerId, string productCategory, string productType, string productTypeId, System.DateTimeOffset? purchaseOn, long? quantity, Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller reseller, Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails renewalTermDetails, string skuDescription, string skuId, Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus? status, string subscriptionId, System.Collections.Generic.IEnumerable<string> suspensionReasons, System.TimeSpan? termDuration, System.DateTimeOffset? termStartOn, System.DateTimeOffset? termEndOn, Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus, System.DateTimeOffset? enrollmentAccountStartOn, Azure.Core.ResourceIdentifier billingSubscriptionId) { throw null; }
        public static Azure.ResourceManager.Billing.BillingSubscriptionData BillingSubscriptionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? autoRenew = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState?), System.Guid? subscriptionBeneficiaryTenantId = default(System.Guid?), Azure.ResourceManager.Billing.Models.BillingBeneficiary beneficiary = null, string billingFrequency = null, Azure.Core.ResourceIdentifier billingProfileId = null, System.Collections.Generic.IReadOnlyDictionary<string, string> billingPolicies = null, string billingProfileDisplayName = null, string billingProfileName = null, string consumptionCostCenter = null, string subscriptionCustomerId = null, string customerDisplayName = null, string customerName = null, string displayName = null, string enrollmentAccountId = null, string enrollmentAccountDisplayName = null, Azure.Core.ResourceIdentifier invoiceSectionId = null, string invoiceSectionDisplayName = null, string invoiceSectionName = null, Azure.ResourceManager.Billing.Models.BillingAmount lastMonthCharges = null, Azure.ResourceManager.Billing.Models.BillingAmount monthToDateCharges = null, string nextBillingCycleBillingFrequency = null, string offerId = null, string productCategory = null, string productType = null, string productTypeId = null, System.DateTimeOffset? purchaseOn = default(System.DateTimeOffset?), long? quantity = default(long?), Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller reseller = null, Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails renewalTermDetails = null, string skuId = null, string skuDescription = null, Azure.ResourceManager.Billing.Models.BillingSystemOverrides systemOverrides = null, System.Uri resourceUri = null, System.TimeSpan? termDuration = default(System.TimeSpan?), System.DateTimeOffset? termStartOn = default(System.DateTimeOffset?), System.DateTimeOffset? termEndOn = default(System.DateTimeOffset?), System.Guid? provisioningTenantId = default(System.Guid?), Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus? status = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus?), Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus? operationStatus = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus?), Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), string subscriptionId = null, System.Collections.Generic.IEnumerable<string> suspensionReasons = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails> suspensionReasonDetails = null, System.DateTimeOffset? enrollmentAccountStartOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus = default(Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus?), System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.BillingSubscriptionData BillingSubscriptionData(Azure.Core.ResourceIdentifier id, string name, Azure.Core.ResourceType resourceType, Azure.ResourceManager.Models.SystemData systemData, Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? autoRenew, string beneficiaryTenantId, string billingFrequency, Azure.Core.ResourceIdentifier billingProfileId, System.Collections.Generic.IReadOnlyDictionary<string, string> billingPolicies, string billingProfileDisplayName, string billingProfileName, string consumptionCostCenter, string customerId, string customerDisplayName, string displayName, string enrollmentAccountId, string enrollmentAccountDisplayName, Azure.Core.ResourceIdentifier invoiceSectionId, string invoiceSectionDisplayName, string invoiceSectionName, Azure.ResourceManager.Billing.Models.BillingAmount lastMonthCharges, Azure.ResourceManager.Billing.Models.BillingAmount monthToDateCharges, string nextBillingCycleBillingFrequency, string offerId, string productCategory, string productType, string productTypeId, System.DateTimeOffset? purchaseOn, long? quantity, Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller reseller, Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails renewalTermDetails, string skuDescription, string skuId, Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus? status, string subscriptionId, System.Collections.Generic.IEnumerable<string> suspensionReasons, System.TimeSpan? termDuration, System.DateTimeOffset? termStartOn, System.DateTimeOffset? termEndOn, Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus, System.DateTimeOffset? enrollmentAccountStartOn) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch BillingSubscriptionPatch(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? autoRenew = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState?), System.Guid? beneficiaryTenantId = default(System.Guid?), Azure.ResourceManager.Billing.Models.BillingBeneficiary beneficiary = null, string billingFrequency = null, Azure.Core.ResourceIdentifier billingProfileId = null, System.Collections.Generic.IReadOnlyDictionary<string, string> billingPolicies = null, string billingProfileDisplayName = null, string billingProfileName = null, string consumptionCostCenter = null, string customerId = null, string customerDisplayName = null, string customerName = null, string displayName = null, string enrollmentAccountId = null, string enrollmentAccountDisplayName = null, Azure.Core.ResourceIdentifier invoiceSectionId = null, string invoiceSectionDisplayName = null, string invoiceSectionName = null, Azure.ResourceManager.Billing.Models.BillingAmount lastMonthCharges = null, Azure.ResourceManager.Billing.Models.BillingAmount monthToDateCharges = null, string nextBillingCycleBillingFrequency = null, string offerId = null, string productCategory = null, string productType = null, string productTypeId = null, System.DateTimeOffset? purchaseOn = default(System.DateTimeOffset?), long? quantity = default(long?), Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller reseller = null, Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails renewalTermDetails = null, string skuId = null, string skuDescription = null, Azure.ResourceManager.Billing.Models.BillingSystemOverrides systemOverrides = null, System.Uri resourceUri = null, System.TimeSpan? termDuration = default(System.TimeSpan?), System.DateTimeOffset? termStartOn = default(System.DateTimeOffset?), System.DateTimeOffset? termEndOn = default(System.DateTimeOffset?), System.Guid? provisioningTenantId = default(System.Guid?), Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus? status = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus?), Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus? operationStatus = default(Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus?), Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), string subscriptionId = null, System.Collections.Generic.IEnumerable<string> suspensionReasons = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails> suspensionReasonDetails = null, System.DateTimeOffset? enrollmentAccountStartOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus? subscriptionEnrollmentAccountStatus = default(Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus?), System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails BillingSubscriptionStatusDetails(System.DateTimeOffset? effectiveOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.SubscriptionStatusReason? reason = default(Azure.ResourceManager.Billing.Models.SubscriptionStatusReason?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError BillingSubscriptionValidateMoveEligibilityError(Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode? code = default(Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode?), string message = null, string details = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult BillingSubscriptionValidateMoveEligibilityResult(bool? isMoveEligible = default(bool?), Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError errorDetails = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSystemOverrides BillingSystemOverrides(Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation? cancellation = default(Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation?), System.DateTimeOffset? cancellationAllowedEndOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionData BillingTransactionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.BillingTransactionProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionProperties BillingTransactionProperties(Azure.ResourceManager.Billing.Models.BillingAmount azureCreditApplied = null, string azurePlan = null, string billingCurrency = null, System.BinaryData billingProfileDisplayName = null, Azure.Core.ResourceIdentifier billingProfileId = null, Azure.ResourceManager.Billing.Models.BillingAmount consumptionCommitmentDecremented = null, string customerDisplayName = null, Azure.Core.ResourceIdentifier customerId = null, Azure.ResourceManager.Billing.Models.BillingTransactionCreditType? creditType = default(Azure.ResourceManager.Billing.Models.BillingTransactionCreditType?), System.DateTimeOffset? on = default(System.DateTimeOffset?), float? discount = default(float?), Azure.ResourceManager.Billing.Models.BillingAmount effectivePrice = null, float? exchangeRate = default(float?), string invoice = null, Azure.Core.ResourceIdentifier invoiceId = null, string invoiceSectionDisplayName = null, Azure.Core.ResourceIdentifier invoiceSectionId = null, bool? isThirdParty = default(bool?), Azure.ResourceManager.Billing.Models.BillingTransactionKind? kind = default(Azure.ResourceManager.Billing.Models.BillingTransactionKind?), Azure.ResourceManager.Billing.Models.BillingAmount marketPrice = null, string partNumber = null, string pricingCurrency = null, string productDescription = null, string productFamily = null, string productTypeId = null, string productType = null, int? quantity = default(int?), string reasonCode = null, System.DateTimeOffset? servicePeriodStartOn = default(System.DateTimeOffset?), System.DateTimeOffset? servicePeriodEndOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.BillingAmount subTotal = null, Azure.ResourceManager.Billing.Models.BillingAmount tax = null, Azure.ResourceManager.Billing.Models.BillingAmount transactionAmount = null, string transactionType = null, float? units = default(float?), string unitOfMeasure = null, string unitType = null, Azure.ResourceManager.Billing.Models.SpecialTaxationType? specialTaxationType = default(Azure.ResourceManager.Billing.Models.SpecialTaxationType?), Azure.ResourceManager.Billing.Models.RefundTransactionDetails refundTransactionDetails = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionSummary BillingTransactionSummary(float? azureCreditApplied = default(float?), string billingCurrency = null, float? consumptionCommitmentDecremented = default(float?), float? subTotal = default(float?), float? tax = default(float?), float? total = default(float?)) { throw null; }
        public static Azure.ResourceManager.Billing.BillingTransferDetailData BillingTransferDetailData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.PartnerTransferStatus? transferStatus = default(Azure.ResourceManager.Billing.Models.PartnerTransferStatus?), string recipientEmailId = null, string initiatorEmailId = null, string canceledBy = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.DetailedTransferStatus> detailedTransferStatus = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTransferError BillingTransferError(string code = null, string message = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTransferValidationResult BillingTransferValidationResult(string status = null, string productId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties> results = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties BillingTransferValidationResultProperties(string level = null, string code = null, string message = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTransitionDetails BillingTransitionDetails(System.DateTimeOffset? transitionOn = default(System.DateTimeOffset?), int? anniversaryDay = default(int?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.CancelSubscriptionContent CancelSubscriptionContent(Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason cancellationReason = default(Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason), Azure.Core.ResourceIdentifier customerId = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller CreatedSubscriptionReseller(string resellerId = null, string description = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail DeleteBillingProfileEligibilityDetail(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode? code = default(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode?), string message = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult DeleteBillingProfileEligibilityResult(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus? eligibilityStatus = default(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail> eligibilityDetails = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail DeleteInvoiceSectionEligibilityDetail(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode? code = default(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode?), string message = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult DeleteInvoiceSectionEligibilityResult(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus? eligibilityStatus = default(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail> eligibilityDetails = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.DetailedTransferStatus DetailedTransferStatus(Azure.ResourceManager.Billing.Models.BillingProductType? productType = default(Azure.ResourceManager.Billing.Models.BillingProductType?), string productId = null, string productName = null, string skuDescription = null, Azure.ResourceManager.Billing.Models.BillingProductTransferStatus? transferStatus = default(Azure.ResourceManager.Billing.Models.BillingProductTransferStatus?), Azure.ResourceManager.Billing.Models.BillingTransferError errorDetails = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.ExtendedStatusInfo ExtendedStatusInfo(string statusCode = null, string message = null, string subscriptionId = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.InvoiceDocument InvoiceDocument(System.Collections.Generic.IEnumerable<string> documentNumbers = null, System.Uri externalUri = null, Azure.ResourceManager.Billing.Models.InvoiceDocumentType? kind = default(Azure.ResourceManager.Billing.Models.InvoiceDocumentType?), string name = null, System.Uri uri = null, Azure.ResourceManager.Billing.Models.BillingDocumentSource? source = default(Azure.ResourceManager.Billing.Models.BillingDocumentSource?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission InvoiceSectionWithCreateSubPermission(string billingProfileDisplayName = null, Azure.Core.ResourceIdentifier billingProfileId = null, string billingProfileSystemId = null, Azure.ResourceManager.Billing.Models.BillingProfileStatus? billingProfileStatus = default(Azure.ResourceManager.Billing.Models.BillingProfileStatus?), Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode? billingProfileStatusReasonCode = default(Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode?), Azure.ResourceManager.Billing.Models.BillingSpendingLimit? billingProfileSpendingLimit = default(Azure.ResourceManager.Billing.Models.BillingSpendingLimit?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingAzurePlan> enabledAzurePlans = null, string invoiceSectionDisplayName = null, Azure.Core.ResourceIdentifier invoiceSectionId = null, string invoiceSectionSystemId = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult MoveProductEligibilityResult(bool? isMoveEligible = default(bool?), Azure.ResourceManager.Billing.Models.MoveProductErrorDetails errorDetails = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.MoveProductErrorDetails MoveProductErrorDetails(Azure.ResourceManager.Billing.Models.MoveValidationErrorCode? code = default(Azure.ResourceManager.Billing.Models.MoveValidationErrorCode?), string message = null, string details = null) { throw null; }
        public static Azure.ResourceManager.Billing.PartnerTransferDetailData PartnerTransferDetailData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.PartnerTransferStatus? transferStatus = default(Azure.ResourceManager.Billing.Models.PartnerTransferStatus?), string recipientEmailId = null, Azure.ResourceManager.Billing.Models.InitiatorCustomerType? initiatorCustomerType = default(Azure.ResourceManager.Billing.Models.InitiatorCustomerType?), string initiatorEmailId = null, string resellerId = null, string resellerName = null, string canceledBy = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.DetailedTransferStatus> detailedTransferStatus = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodLogo PaymentMethodLogo(string mimeType = null, System.Uri uri = null) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties PaymentMethodProjectionProperties(Azure.Core.ResourceIdentifier paymentMethodId, Azure.ResourceManager.Billing.Models.PaymentMethodFamily? family, string paymentMethodProjectionPropertiesType, string accountHolderName, string expiration, string lastFourDigits, string displayName, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.PaymentMethodLogo> logos, Azure.ResourceManager.Billing.Models.PaymentMethodStatus? status) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties PaymentMethodProjectionProperties(Azure.Core.ResourceIdentifier paymentMethodId = null, string accountHolderName = null, string displayName = null, string expiration = null, Azure.ResourceManager.Billing.Models.PaymentMethodFamily? family = default(Azure.ResourceManager.Billing.Models.PaymentMethodFamily?), string lastFourDigits = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.PaymentMethodLogo> logos = null, string paymentMethodType = null, Azure.ResourceManager.Billing.Models.PaymentMethodStatus? status = default(Azure.ResourceManager.Billing.Models.PaymentMethodStatus?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail PaymentTermsEligibilityDetail(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode? code = default(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode?), string message = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult PaymentTermsEligibilityResult(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus? eligibilityStatus = default(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail> eligibilityDetails = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.RebillDetails RebillDetails(Azure.Core.ResourceIdentifier invoiceDocumentId = null, Azure.Core.ResourceIdentifier creditNoteDocumentId = null, Azure.ResourceManager.Billing.Models.RebillDetails rebillDetailsValue = null) { throw null; }
        public static Azure.ResourceManager.Billing.RecipientTransferDetailData RecipientTransferDetailData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.DateTimeOffset? expireOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.EligibleProductType> allowedProductType = null, Azure.ResourceManager.Billing.Models.PartnerTransferStatus? transferStatus = default(Azure.ResourceManager.Billing.Models.PartnerTransferStatus?), string recipientEmailId = null, string initiatorEmailId = null, string resellerId = null, string resellerName = null, Azure.ResourceManager.Billing.Models.InitiatorCustomerType? initiatorCustomerType = default(Azure.ResourceManager.Billing.Models.InitiatorCustomerType?), string canceledBy = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.DetailedTransferStatus> detailedTransferStatus = null, System.Guid? customerTenantId = default(System.Guid?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingSupportedAccountType> supportedAccounts = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.RefundDetailsSummary RefundDetailsSummary(System.DateTimeOffset? requestedOn = default(System.DateTimeOffset?), System.DateTimeOffset? approvedOn = default(System.DateTimeOffset?), System.DateTimeOffset? completedOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.BillingAmount amountRequested = null, Azure.ResourceManager.Billing.Models.BillingAmount amountRefunded = null, Azure.Core.ResourceIdentifier rebillInvoiceId = null, int? transactionCount = default(int?), Azure.ResourceManager.Billing.Models.RefundStatus? refundStatus = default(Azure.ResourceManager.Billing.Models.RefundStatus?), string refundOperationId = null, Azure.ResourceManager.Billing.Models.RefundReasonCode? refundReason = default(Azure.ResourceManager.Billing.Models.RefundReasonCode?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.RefundTransactionDetails RefundTransactionDetails(Azure.ResourceManager.Billing.Models.BillingAmount amountRequested = null, Azure.ResourceManager.Billing.Models.BillingAmount amountRefunded = null, string refundOperationId = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest ReservationPurchaseRequest(string skuName = null, Azure.Core.AzureLocation? location = default(Azure.Core.AzureLocation?), string reservedResourceType = null, string billingScopeId = null, string term = null, Azure.ResourceManager.Billing.Models.ReservationBillingPlan? billingPlan = default(Azure.ResourceManager.Billing.Models.ReservationBillingPlan?), int? quantity = default(int?), string displayName = null, Azure.ResourceManager.Billing.Models.BillingAppliedScopeType? appliedScopeType = default(Azure.ResourceManager.Billing.Models.BillingAppliedScopeType?), System.Collections.Generic.IEnumerable<string> appliedScopes = null, Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties appliedScopeProperties = null, bool? isRenewed = default(bool?), Azure.ResourceManager.Billing.Models.InstanceFlexibility? instanceFlexibilityPropertiesInstanceFlexibility = default(Azure.ResourceManager.Billing.Models.InstanceFlexibility?), System.DateTimeOffset? reviewOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.InstanceFlexibility? instanceFlexibilityPropertiesReservedResourcePropertiesInstanceFlexibility = default(Azure.ResourceManager.Billing.Models.InstanceFlexibility?)) { throw null; }
        public static Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates ReservationUtilizationAggregates(float? grain = default(float?), string grainUnit = null, float? value = default(float?), string valueUnit = null) { throw null; }
        public static Azure.ResourceManager.Billing.SavingsPlanOrderModelData SavingsPlanOrderModelData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string skuName = null, string displayName = null, string provisioningState = null, string billingScopeId = null, Azure.Core.ResourceIdentifier billingProfileId = null, Azure.Core.ResourceIdentifier customerId = null, Azure.Core.ResourceIdentifier billingAccountId = null, Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm? term = default(Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm?), Azure.ResourceManager.Billing.Models.BillingPlan? billingPlan = default(Azure.ResourceManager.Billing.Models.BillingPlan?), System.DateTimeOffset? benefitStartOn = default(System.DateTimeOffset?), System.DateTimeOffset? expiryOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.BillingPlanInformation planInformation = null, System.Collections.Generic.IEnumerable<string> savingsPlans = null, Azure.ResourceManager.Billing.Models.ExtendedStatusInfo extendedStatusInfo = null, string productCode = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SavingsPlanUtilization SavingsPlanUtilization(string trend = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates> aggregates = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates SavingsPlanUtilizationAggregates(float? grain = default(float?), string grainUnit = null, float? value = default(float?), string valueUnit = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult SavingsPlanValidateResult(System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty> benefits = null, string nextLink = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty SavingsPlanValidResponseProperty(bool? isValid = default(bool?), string reasonCode = null, string reason = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitDetails SpendingLimitDetails(float? amount = default(float?), string currency = null, System.DateTimeOffset? startOn = default(System.DateTimeOffset?), System.DateTimeOffset? endOn = default(System.DateTimeOffset?), Azure.ResourceManager.Billing.Models.SpendingLimitType? limitType = default(Azure.ResourceManager.Billing.Models.SpendingLimitType?), Azure.ResourceManager.Billing.Models.SpendingLimitStatus? status = default(Azure.ResourceManager.Billing.Models.SpendingLimitStatus?)) { throw null; }
        public static Azure.ResourceManager.Billing.SubscriptionPolicyData SubscriptionPolicyData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties properties = null, System.Collections.Generic.IDictionary<string, string> tags = null) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties SubscriptionPolicyProperties(Azure.ResourceManager.Billing.Models.BillingProvisioningState? provisioningState = default(Azure.ResourceManager.Billing.Models.BillingProvisioningState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.Billing.Models.BillingPolicySummary> policies = null) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails SubscriptionRenewalTermDetails(string billingFrequency, string productTypeId, long? quantity, string skuId, System.TimeSpan? termDuration) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails SubscriptionRenewalTermDetails(string billingFrequency = null, string productId = null, string productTypeId = null, string skuId = null, System.TimeSpan? termDuration = default(System.TimeSpan?), long? quantity = default(long?), System.DateTimeOffset? termEndOn = default(System.DateTimeOffset?)) { throw null; }
    }
    public partial class BillingAccountCollectionGetAllOptions
    {
        public BillingAccountCollectionGetAllOptions() { }
        public string Expand { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeAll { get { throw null; } set { } }
        public bool? IncludeAllWithoutBillingProfiles { get { throw null; } set { } }
        public bool? IncludeDeleted { get { throw null; } set { } }
        public bool? IncludePendingAgreement { get { throw null; } set { } }
        public bool? IncludeResellee { get { throw null; } set { } }
        public string LegalOwnerOID { get { throw null; } set { } }
        public string LegalOwnerTID { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingAccountEnrollmentDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails>
    {
        public BillingAccountEnrollmentDetails() { }
        public string BillingCycle { get { throw null; } }
        public string Channel { get { throw null; } }
        public string Cloud { get { throw null; } }
        public string CountryCode { get { throw null; } }
        public string Currency { get { throw null; } }
        public System.DateTimeOffset? EndOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ExtendedTermOption? ExtendedTermOption { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo IndirectRelationshipInfo { get { throw null; } set { } }
        public string InvoiceRecipient { get { throw null; } }
        public string Language { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus? MarkupStatus { get { throw null; } }
        public string PoNumber { get { throw null; } set { } }
        public System.DateTimeOffset? StartOn { get { throw null; } set { } }
        public string SupportCoverage { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel? SupportLevel { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAccountPatch : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountPatch>
    {
        public BillingAccountPatch() { }
        public Azure.ResourceManager.Billing.Models.BillingAccountProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingAccountPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAccountPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAccountPolicyProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties>
    {
        public BillingAccountPolicyProperties() { }
        public Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies EnterpriseAgreementPolicies { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy? MarketplacePurchases { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingPolicySummary> Policies { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy? ReservationPurchases { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy? SavingsPlanPurchases { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountPolicyProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAccountProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountProperties>
    {
        public BillingAccountProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingAccountStatus? AccountStatus { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode? AccountStatusReasonCode { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAccountSubType? AccountSubType { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAccountType? AccountType { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAgreementType? AgreementType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingRelationshipType> BillingRelationshipTypes { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAccountEnrollmentDetails EnrollmentDetails { get { throw null; } set { } }
        public bool? HasNoBillingProfiles { get { throw null; } set { } }
        public bool? HasReadAccess { get { throw null; } set { } }
        public string NotificationEmailAddress { get { throw null; } set { } }
        public System.Guid? PrimaryBillingTenantId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Qualifications { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingRegistrationNumber RegistrationNumber { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAddressDetails SoldTo { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingTaxIdentifier> TaxIds { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingAccountProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAccountProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAccountProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAccountProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAccountResourceGetBillingRequestsOptions
    {
        public BillingAccountResourceGetBillingRequestsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingAccountResourceGetByBillingAccountSavingsPlanOptions
    {
        public BillingAccountResourceGetByBillingAccountSavingsPlanOptions() { }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string RefreshSummary { get { throw null; } set { } }
        public string SelectedState { get { throw null; } set { } }
        public float? Skiptoken { get { throw null; } set { } }
        public float? Take { get { throw null; } set { } }
    }
    public partial class BillingAccountResourceGetReservationsOptions
    {
        public BillingAccountResourceGetReservationsOptions() { }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string RefreshSummary { get { throw null; } set { } }
        public string SelectedState { get { throw null; } set { } }
        public float? Skiptoken { get { throw null; } set { } }
        public float? Take { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingAccountStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingAccountStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingAccountStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus Deleted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus Extended { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus New { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus Terminated { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus Transferred { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatus UnderReview { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingAccountStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingAccountStatus left, Azure.ResourceManager.Billing.Models.BillingAccountStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingAccountStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingAccountStatus left, Azure.ResourceManager.Billing.Models.BillingAccountStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingAccountStatusReasonCode : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingAccountStatusReasonCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode ManuallyTerminated { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode TerminateProcessing { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode Transferred { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode UnusualActivity { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode left, Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode left, Azure.ResourceManager.Billing.Models.BillingAccountStatusReasonCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingAccountSubType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingAccountSubType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingAccountSubType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAccountSubType Enterprise { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountSubType Individual { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountSubType None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountSubType Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountSubType Professional { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingAccountSubType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingAccountSubType left, Azure.ResourceManager.Billing.Models.BillingAccountSubType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingAccountSubType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingAccountSubType left, Azure.ResourceManager.Billing.Models.BillingAccountSubType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingAccountType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingAccountType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingAccountType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAccountType Business { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountType ClassicPartner { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountType Enterprise { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountType Individual { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountType Internal { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountType Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountType Partner { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountType Reseller { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAccountType Tenant { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingAccountType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingAccountType left, Azure.ResourceManager.Billing.Models.BillingAccountType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingAccountType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingAccountType left, Azure.ResourceManager.Billing.Models.BillingAccountType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingAddressDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAddressDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAddressDetails>
    {
        public BillingAddressDetails(string addressLine1, string country) { }
        public string AddressLine1 { get { throw null; } set { } }
        public string AddressLine2 { get { throw null; } set { } }
        public string AddressLine3 { get { throw null; } set { } }
        public string City { get { throw null; } set { } }
        public string CompanyName { get { throw null; } set { } }
        public string Country { get { throw null; } set { } }
        public string District { get { throw null; } set { } }
        public string Email { get { throw null; } set { } }
        public string FirstName { get { throw null; } set { } }
        public bool? IsValidAddress { get { throw null; } set { } }
        public string LastName { get { throw null; } set { } }
        public string MiddleName { get { throw null; } set { } }
        public string PhoneNumber { get { throw null; } set { } }
        public string PostalCode { get { throw null; } set { } }
        public string Region { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingAddressDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAddressDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAddressDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAddressDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAddressDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAddressDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAddressDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAddressValidationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult>
    {
        internal BillingAddressValidationResult() { }
        public Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus? Status { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingAddressDetails> SuggestedAddresses { get { throw null; } }
        public string ValidationMessage { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingAddressValidationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAddressValidationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAddressValidationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingAddressValidationStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingAddressValidationStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus Invalid { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus Valid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus left, Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus left, Azure.ResourceManager.Billing.Models.BillingAddressValidationStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingAgreementCategory : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingAgreementCategory>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingAgreementCategory(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementCategory AffiliatePurchaseTerms { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementCategory IndirectForGovernmentAgreement { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementCategory MicrosoftCustomerAgreement { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementCategory MicrosoftPartnerAgreement { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementCategory Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementCategory UKCloudComputeFramework { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingAgreementCategory other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingAgreementCategory left, Azure.ResourceManager.Billing.Models.BillingAgreementCategory right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingAgreementCategory (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingAgreementCategory left, Azure.ResourceManager.Billing.Models.BillingAgreementCategory right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingAgreementParticipant : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAgreementParticipant>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAgreementParticipant>
    {
        internal BillingAgreementParticipant() { }
        public string Email { get { throw null; } }
        public string Status { get { throw null; } }
        public System.DateTimeOffset? StatusOn { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingAgreementParticipant System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAgreementParticipant>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAgreementParticipant>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAgreementParticipant System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAgreementParticipant>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAgreementParticipant>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAgreementParticipant>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAgreementProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAgreementProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAgreementProperties>
    {
        public BillingAgreementProperties() { }
        public Azure.ResourceManager.Billing.Models.AgreementAcceptanceMode? AcceptanceMode { get { throw null; } }
        public string AgreementLink { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingProfileInfo> BillingProfileInfo { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAgreementCategory? Category { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public System.DateTimeOffset? EffectiveOn { get { throw null; } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } }
        public string LeadBillingAccountName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingAgreementParticipant> Participants { get { throw null; } }
        public string Status { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingAgreementProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAgreementProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAgreementProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAgreementProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAgreementProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAgreementProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAgreementProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingAgreementType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingAgreementType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingAgreementType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementType EnterpriseAgreement { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementType MicrosoftCustomerAgreement { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementType MicrosoftOnlineServicesProgram { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementType MicrosoftPartnerAgreement { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAgreementType Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingAgreementType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingAgreementType left, Azure.ResourceManager.Billing.Models.BillingAgreementType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingAgreementType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingAgreementType left, Azure.ResourceManager.Billing.Models.BillingAgreementType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingAmount : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAmount>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAmount>
    {
        internal BillingAmount() { }
        public string Currency { get { throw null; } }
        public float? Value { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingAmount System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAmount>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAmount>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAmount System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAmount>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAmount>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAmount>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAppliedScopeProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties>
    {
        public BillingAppliedScopeProperties() { }
        public string DisplayName { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ManagementGroupId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ResourceGroupId { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
        public System.Guid? TenantId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingAppliedScopeType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingAppliedScopeType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingAppliedScopeType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingAppliedScopeType ManagementGroup { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAppliedScopeType Shared { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingAppliedScopeType Single { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingAppliedScopeType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingAppliedScopeType left, Azure.ResourceManager.Billing.Models.BillingAppliedScopeType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingAppliedScopeType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingAppliedScopeType left, Azure.ResourceManager.Billing.Models.BillingAppliedScopeType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingAssociatedTenantCollectionGetAllOptions
    {
        public BillingAssociatedTenantCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeRevoked { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingAssociatedTenantProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties>
    {
        public BillingAssociatedTenantProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingManagementTenantState? BillingManagementState { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string ProvisioningBillingRequestId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState? ProvisioningManagementState { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public System.Guid? TenantId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAssociatedTenantProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAvailableBalanceData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData>
    {
        public BillingAvailableBalanceData() { }
        public Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAvailableBalanceProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties>
    {
        public BillingAvailableBalanceProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingAmount Amount { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount> PaymentsOnAccount { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount TotalPaymentsOnAccount { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAvailableBalanceProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingAzurePlan : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAzurePlan>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAzurePlan>
    {
        public BillingAzurePlan() { }
        public string ProductId { get { throw null; } set { } }
        public string SkuDescription { get { throw null; } set { } }
        public string SkuId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingAzurePlan System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAzurePlan>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingAzurePlan>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingAzurePlan System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAzurePlan>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAzurePlan>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingAzurePlan>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingBeneficiary : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingBeneficiary>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingBeneficiary>
    {
        public BillingBeneficiary() { }
        public string ObjectId { get { throw null; } set { } }
        public System.Guid? TenantId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingBeneficiary System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingBeneficiary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingBeneficiary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingBeneficiary System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingBeneficiary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingBeneficiary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingBeneficiary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingBenefitCommitment : Azure.ResourceManager.Billing.Models.BillingPrice, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingBenefitCommitment>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingBenefitCommitment>
    {
        public BillingBenefitCommitment() { }
        public Azure.ResourceManager.Billing.Models.BillingBenefitCommitmentGrain? Grain { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingBenefitCommitment System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingBenefitCommitment>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingBenefitCommitment>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingBenefitCommitment System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingBenefitCommitment>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingBenefitCommitment>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingBenefitCommitment>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingBenefitCommitmentGrain : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingBenefitCommitmentGrain>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingBenefitCommitmentGrain(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingBenefitCommitmentGrain Hourly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingBenefitCommitmentGrain other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingBenefitCommitmentGrain left, Azure.ResourceManager.Billing.Models.BillingBenefitCommitmentGrain right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingBenefitCommitmentGrain (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingBenefitCommitmentGrain left, Azure.ResourceManager.Billing.Models.BillingBenefitCommitmentGrain right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingCheckAccessContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessContent>
    {
        public BillingCheckAccessContent() { }
        public System.Collections.Generic.IList<string> Actions { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingCheckAccessContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingCheckAccessContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingCheckAccessResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult>
    {
        internal BillingCheckAccessResult() { }
        public Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision? AccessDecision { get { throw null; } }
        public string Action { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingCheckAccessResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingCheckAccessResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCheckAccessResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingCustomerCollectionGetAllOptions
    {
        public BillingCustomerCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Expand { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingCustomerPolicyProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties>
    {
        public BillingCustomerPolicyProperties(Azure.ResourceManager.Billing.Models.ViewChargesPolicy viewCharges) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingPolicySummary> Policies { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.ViewChargesPolicy ViewCharges { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCustomerPolicyProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingCustomerProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCustomerProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCustomerProperties>
    {
        public BillingCustomerProperties() { }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingAzurePlan> EnabledAzurePlans { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller> Resellers { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingCustomerStatus? Status { get { throw null; } }
        public string SystemId { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingCustomerProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCustomerProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingCustomerProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingCustomerProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCustomerProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCustomerProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingCustomerProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingCustomerResourceGetBillingSubscriptionsByCustomerAtBillingAccountOptions
    {
        public BillingCustomerResourceGetBillingSubscriptionsByCustomerAtBillingAccountOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Expand { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeDeleted { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingCustomerResourceGetProductsOptions
    {
        public BillingCustomerResourceGetProductsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingCustomerStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingCustomerStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingCustomerStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingCustomerStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingCustomerStatus Deleted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingCustomerStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingCustomerStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingCustomerStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingCustomerStatus UnderReview { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingCustomerStatus Warned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingCustomerStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingCustomerStatus left, Azure.ResourceManager.Billing.Models.BillingCustomerStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingCustomerStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingCustomerStatus left, Azure.ResourceManager.Billing.Models.BillingCustomerStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingDepartmentEnrollmentAccountCollectionGetAllOptions
    {
        public BillingDepartmentEnrollmentAccountCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingDepartmentProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingDepartmentProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDepartmentProperties>
    {
        public BillingDepartmentProperties() { }
        public string CostCenter { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public string Id { get { throw null; } }
        public string Status { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingDepartmentProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingDepartmentProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingDepartmentProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingDepartmentProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDepartmentProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDepartmentProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDepartmentProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingDocumentDownloadRequestContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent>
    {
        public BillingDocumentDownloadRequestContent() { }
        public string DocumentName { get { throw null; } set { } }
        public string InvoiceName { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadRequestContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingDocumentDownloadResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>
    {
        internal BillingDocumentDownloadResult() { }
        public System.DateTimeOffset? ExpireOn { get { throw null; } }
        public System.Uri Uri { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingDocumentDownloadResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingDocumentSource : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingDocumentSource>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingDocumentSource(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingDocumentSource Drs { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingDocumentSource Enf { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingDocumentSource Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingDocumentSource other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingDocumentSource left, Azure.ResourceManager.Billing.Models.BillingDocumentSource right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingDocumentSource (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingDocumentSource left, Azure.ResourceManager.Billing.Models.BillingDocumentSource right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingEnrollmentAccountCollectionGetAllOptions
    {
        public BillingEnrollmentAccountCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingEnrollmentAccountProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties>
    {
        public BillingEnrollmentAccountProperties() { }
        public string AccountOwner { get { throw null; } }
        public string AuthType { get { throw null; } }
        public string CostCenter { get { throw null; } set { } }
        public string DepartmentDisplayName { get { throw null; } }
        public string DepartmentId { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public bool? IsDevTestEnabled { get { throw null; } set { } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public string Status { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingEnrollmentAccountProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingEnrollmentAccountResourceGetBillingSubscriptionsOptions
    {
        public BillingEnrollmentAccountResourceGetBillingSubscriptionsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingEnrollmentSupportLevel : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingEnrollmentSupportLevel(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel Developer { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel ProDirect { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel left, Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel left, Azure.ResourceManager.Billing.Models.BillingEnrollmentSupportLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingInvoiceCollectionGetAllOptions
    {
        public BillingInvoiceCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public System.DateTimeOffset? PeriodEndDate { get { throw null; } set { } }
        public System.DateTimeOffset? PeriodStartDate { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingInvoiceFailedPayment : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment>
    {
        internal BillingInvoiceFailedPayment() { }
        public Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason? FailedPaymentReason { get { throw null; } }
        public System.DateTimeOffset? On { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingInvoiceFailedPaymentReason : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingInvoiceFailedPaymentReason(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason BankDeclined { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason CardExpired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason IncorrectCardDetails { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason left, Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason left, Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPaymentReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingInvoicePayment : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoicePayment>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoicePayment>
    {
        internal BillingInvoicePayment() { }
        public Azure.ResourceManager.Billing.Models.BillingAmount Amount { get { throw null; } }
        public System.DateTimeOffset? MadeOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentMethodFamily? PaymentMethodFamily { get { throw null; } }
        public Azure.Core.ResourceIdentifier PaymentMethodId { get { throw null; } }
        public string PaymentMethodType { get { throw null; } }
        public string PaymentType { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingInvoicePayment System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoicePayment>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoicePayment>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingInvoicePayment System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoicePayment>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoicePayment>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoicePayment>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingInvoiceProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoiceProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceProperties>
    {
        public BillingInvoiceProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingAmount AmountDue { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount AzurePrepaymentApplied { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount BilledAmount { get { throw null; } }
        public string BilledDocumentId { get { throw null; } }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount CreditAmount { get { throw null; } }
        public string CreditForDocumentId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.InvoiceDocument> Documents { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.InvoiceDocumentType? DocumentType { get { throw null; } }
        public System.DateTimeOffset? DueOn { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingInvoiceFailedPayment> FailedPayments { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount FreeAzureCreditApplied { get { throw null; } }
        public System.DateTimeOffset? InvoiceOn { get { throw null; } }
        public System.DateTimeOffset? InvoicePeriodEndOn { get { throw null; } }
        public System.DateTimeOffset? InvoicePeriodStartOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingInvoiceType? InvoiceType { get { throw null; } }
        public bool? IsMonthlyInvoice { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingInvoicePayment> Payments { get { throw null; } }
        public string PurchaseOrderNumber { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.RebillDetails RebillDetails { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.RefundDetailsSummary RefundDetails { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.SpecialTaxationType? SpecialTaxationType { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingInvoiceStatus? Status { get { throw null; } }
        public string SubscriptionDisplayName { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount SubTotal { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount TaxAmount { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount TotalAmount { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingInvoiceProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoiceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoiceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingInvoiceProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingInvoiceResourceGetTransactionsOptions
    {
        public BillingInvoiceResourceGetTransactionsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingInvoiceSectionCollectionGetAllOptions
    {
        public BillingInvoiceSectionCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeDeleted { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingInvoiceSectionProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties>
    {
        public BillingInvoiceSectionProperties() { }
        public string DisplayName { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode? ReasonCode { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.InvoiceSectionState? State { get { throw null; } set { } }
        public string SystemId { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public string TargetCloud { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingInvoiceSectionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingInvoiceSectionResourceGetBillingRequestsOptions
    {
        public BillingInvoiceSectionResourceGetBillingRequestsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingInvoiceSectionResourceGetBillingSubscriptionsOptions
    {
        public BillingInvoiceSectionResourceGetBillingSubscriptionsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Expand { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeDeleted { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingInvoiceSectionResourceGetProductsOptions
    {
        public BillingInvoiceSectionResourceGetProductsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingInvoiceSectionResourceGetTransactionsOptions
    {
        public BillingInvoiceSectionResourceGetTransactionsOptions(System.DateTimeOffset periodStartDate, System.DateTimeOffset periodEndDate, Azure.ResourceManager.Billing.Models.TransactionType type) { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public System.DateTimeOffset PeriodEndDate { get { throw null; } }
        public System.DateTimeOffset PeriodStartDate { get { throw null; } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.TransactionType Type { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingInvoiceStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingInvoiceStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingInvoiceStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceStatus Due { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceStatus Locked { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceStatus OverDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceStatus Paid { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceStatus Void { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingInvoiceStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingInvoiceStatus left, Azure.ResourceManager.Billing.Models.BillingInvoiceStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingInvoiceStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingInvoiceStatus left, Azure.ResourceManager.Billing.Models.BillingInvoiceStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingInvoiceType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingInvoiceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingInvoiceType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceType AzureMarketplace { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceType AzureServices { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceType AzureSupport { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingInvoiceType Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingInvoiceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingInvoiceType left, Azure.ResourceManager.Billing.Models.BillingInvoiceType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingInvoiceType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingInvoiceType left, Azure.ResourceManager.Billing.Models.BillingInvoiceType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingManagementTenantState : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingManagementTenantState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingManagementTenantState(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingManagementTenantState Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingManagementTenantState NotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingManagementTenantState Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingManagementTenantState Revoked { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingManagementTenantState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingManagementTenantState left, Azure.ResourceManager.Billing.Models.BillingManagementTenantState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingManagementTenantState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingManagementTenantState left, Azure.ResourceManager.Billing.Models.BillingManagementTenantState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingPaymentOnAccount : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount>
    {
        internal BillingPaymentOnAccount() { }
        public Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller Amount { get { throw null; } }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public Azure.Core.ResourceIdentifier InvoiceId { get { throw null; } }
        public string InvoiceName { get { throw null; } }
        public System.DateTimeOffset? On { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentMethodFamily? PaymentMethodType { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPaymentOnAccount>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingPaymentStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingPaymentStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingPaymentStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingPaymentStatus Cancelled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPaymentStatus Completed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPaymentStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPaymentStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPaymentStatus Scheduled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPaymentStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingPaymentStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingPaymentStatus left, Azure.ResourceManager.Billing.Models.BillingPaymentStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingPaymentStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingPaymentStatus left, Azure.ResourceManager.Billing.Models.BillingPaymentStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingPaymentTerm : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPaymentTerm>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPaymentTerm>
    {
        public BillingPaymentTerm() { }
        public System.DateTimeOffset? EndOn { get { throw null; } set { } }
        public bool? IsDefault { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } set { } }
        public string Term { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingPaymentTerm System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPaymentTerm>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPaymentTerm>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingPaymentTerm System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPaymentTerm>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPaymentTerm>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPaymentTerm>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingPermission : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPermission>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPermission>
    {
        internal BillingPermission() { }
        public System.Collections.Generic.IReadOnlyList<string> Actions { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> NotActions { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingPermission System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPermission>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPermission>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingPermission System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPermission>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPermission>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPermission>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingPlan : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingPlan>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingPlan(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingPlan P1M { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingPlan other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingPlan left, Azure.ResourceManager.Billing.Models.BillingPlan right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingPlan (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingPlan left, Azure.ResourceManager.Billing.Models.BillingPlan right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingPlanInformation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPlanInformation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPlanInformation>
    {
        public BillingPlanInformation() { }
        public System.DateTimeOffset? NextPaymentDueOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPrice PricingCurrencyTotal { get { throw null; } set { } }
        public System.DateTimeOffset? StartOn { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail> Transactions { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingPlanInformation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPlanInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPlanInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingPlanInformation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPlanInformation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPlanInformation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPlanInformation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingPlanPaymentDetail : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail>
    {
        public BillingPlanPaymentDetail() { }
        public Azure.ResourceManager.Billing.Models.BillingPrice BillingCurrencyTotal { get { throw null; } set { } }
        public System.DateTimeOffset? DueOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ExtendedStatusInfo ExtendedStatusInfo { get { throw null; } }
        public System.DateTimeOffset? PaymentCompletedOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPrice PricingCurrencyTotal { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPaymentStatus? Status { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPlanPaymentDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingPolicySummary : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPolicySummary>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPolicySummary>
    {
        public BillingPolicySummary() { }
        public string Name { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPolicyType? PolicyType { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingPolicySummary System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPolicySummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPolicySummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingPolicySummary System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPolicySummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPolicySummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPolicySummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingPolicyType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingPolicyType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingPolicyType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingPolicyType Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPolicyType SystemControlled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPolicyType UserControlled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingPolicyType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingPolicyType left, Azure.ResourceManager.Billing.Models.BillingPolicyType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingPolicyType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingPolicyType left, Azure.ResourceManager.Billing.Models.BillingPolicyType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingPrice : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPrice>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPrice>
    {
        public BillingPrice() { }
        public double? Amount { get { throw null; } set { } }
        public string CurrencyCode { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingPrice System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPrice>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPrice>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingPrice System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPrice>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPrice>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPrice>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingPrincipal : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPrincipal>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPrincipal>
    {
        public BillingPrincipal() { }
        public string ObjectId { get { throw null; } set { } }
        public System.Guid? TenantId { get { throw null; } set { } }
        public string Upn { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingPrincipal System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPrincipal>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPrincipal>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingPrincipal System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPrincipal>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPrincipal>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPrincipal>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingPrincipalType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingPrincipalType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingPrincipalType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingPrincipalType DirectoryRole { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPrincipalType Everyone { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPrincipalType Group { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPrincipalType None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPrincipalType ServicePrincipal { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPrincipalType Unknown { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingPrincipalType User { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingPrincipalType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingPrincipalType left, Azure.ResourceManager.Billing.Models.BillingPrincipalType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingPrincipalType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingPrincipalType left, Azure.ResourceManager.Billing.Models.BillingPrincipalType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingProductCollectionGetAllOptions
    {
        public BillingProductCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingProductDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProductDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductDetails>
    {
        public BillingProductDetails() { }
        public string ProductId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingProductType? ProductType { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingProductDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProductDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProductDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingProductDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProductPatch : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProductPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductPatch>
    {
        public BillingProductPatch() { }
        public Azure.ResourceManager.Billing.Models.BillingProductProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingProductPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProductPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProductPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingProductPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProductProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProductProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductProperties>
    {
        public BillingProductProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? AutoRenew { get { throw null; } set { } }
        public string AvailabilityId { get { throw null; } }
        public string BillingFrequency { get { throw null; } }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public string CustomerDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier CustomerId { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string EndDate { get { throw null; } }
        public string InvoiceSectionDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier InvoiceSectionId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount LastCharge { get { throw null; } }
        public string LastChargeDate { get { throw null; } }
        public string ProductType { get { throw null; } }
        public string ProductTypeId { get { throw null; } }
        public string PurchaseDate { get { throw null; } }
        public long? Quantity { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount Reseller { get { throw null; } }
        public string SkuDescription { get { throw null; } }
        public string SkuId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProductStatus? Status { get { throw null; } }
        public System.Guid? TenantId { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingProductProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProductProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProductProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingProductProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProductProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingProductStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingProductStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingProductStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus AutoRenew { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus Canceled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus Deleted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus Expiring { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus PastDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductStatus Suspended { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingProductStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingProductStatus left, Azure.ResourceManager.Billing.Models.BillingProductStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingProductStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingProductStatus left, Azure.ResourceManager.Billing.Models.BillingProductStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingProductTransferStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingProductTransferStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingProductTransferStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProductTransferStatus Completed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductTransferStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductTransferStatus InProgress { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductTransferStatus NotStarted { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingProductTransferStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingProductTransferStatus left, Azure.ResourceManager.Billing.Models.BillingProductTransferStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingProductTransferStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingProductTransferStatus left, Azure.ResourceManager.Billing.Models.BillingProductTransferStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingProductType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingProductType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingProductType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProductType AzureReservation { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductType AzureSubscription { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductType Department { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductType Saas { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProductType SavingsPlan { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingProductType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingProductType left, Azure.ResourceManager.Billing.Models.BillingProductType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingProductType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingProductType left, Azure.ResourceManager.Billing.Models.BillingProductType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingProfileAccessDecision : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingProfileAccessDecision(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision NotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision left, Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision left, Azure.ResourceManager.Billing.Models.BillingProfileAccessDecision right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingProfileCollectionGetAllOptions
    {
        public BillingProfileCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeDeleted { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingProfileCustomerCollectionGetAllOptions
    {
        public BillingProfileCustomerCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Expand { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingProfileCustomerResourceGetBillingRequestsOptions
    {
        public BillingProfileCustomerResourceGetBillingRequestsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingProfileCustomerResourceGetBillingSubscriptionsOptions
    {
        public BillingProfileCustomerResourceGetBillingSubscriptionsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Expand { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeDeleted { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingProfileCustomerResourceGetTransactionsOptions
    {
        public BillingProfileCustomerResourceGetTransactionsOptions(System.DateTimeOffset periodStartDate, System.DateTimeOffset periodEndDate, Azure.ResourceManager.Billing.Models.TransactionType type) { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public System.DateTimeOffset PeriodEndDate { get { throw null; } }
        public System.DateTimeOffset PeriodStartDate { get { throw null; } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.TransactionType Type { get { throw null; } }
    }
    public partial class BillingProfileInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProfileInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfileInfo>
    {
        internal BillingProfileInfo() { }
        public Azure.Core.ResourceIdentifier BillingAccountId { get { throw null; } }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public string BillingProfileSystemId { get { throw null; } }
        public string IndirectRelationshipOrganizationName { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingProfileInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProfileInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProfileInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingProfileInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfileInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfileInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfileInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfilePolicyProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties>
    {
        public BillingProfilePolicyProperties() { }
        public Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies EnterpriseAgreementPolicies { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy? InvoiceSectionLabelManagement { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy? MarketplacePurchases { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingPolicySummary> Policies { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy? ReservationPurchases { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy? SavingsPlanPurchases { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ViewChargesPolicy? ViewCharges { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfilePolicyProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfileProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProfileProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfileProperties>
    {
        public BillingProfileProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingRelationshipType? BillingRelationshipType { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAddressDetails BillTo { get { throw null; } set { } }
        public string Currency { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingPaymentTerm CurrentPaymentTerm { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingAzurePlan> EnabledAzurePlans { get { throw null; } }
        public bool? HasReadAccess { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo IndirectRelationshipInfo { get { throw null; } set { } }
        public int? InvoiceDay { get { throw null; } }
        public System.Collections.Generic.IList<string> InvoiceRecipients { get { throw null; } }
        public bool? IsInvoiceEmailOptIn { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingPaymentTerm> OtherPaymentTerms { get { throw null; } }
        public string PoNumber { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAddressDetails ShipTo { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAddressDetails SoldTo { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingSpendingLimit? SpendingLimit { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.SpendingLimitDetails> SpendingLimitDetails { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProfileStatus? Status { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode? StatusReasonCode { get { throw null; } }
        public string SystemId { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> TargetClouds { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingProfileProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProfileProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingProfileProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingProfileProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfileProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfileProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingProfileProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingProfileResourceGetBillingRequestsOptions
    {
        public BillingProfileResourceGetBillingRequestsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingProfileResourceGetInvoicesOptions
    {
        public BillingProfileResourceGetInvoicesOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public System.DateTimeOffset? PeriodEndDate { get { throw null; } set { } }
        public System.DateTimeOffset? PeriodStartDate { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingProfileResourceGetProductsOptions
    {
        public BillingProfileResourceGetProductsOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingProfileResourceGetReservationsOptions
    {
        public BillingProfileResourceGetReservationsOptions() { }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string RefreshSummary { get { throw null; } set { } }
        public string SelectedState { get { throw null; } set { } }
        public float? Skiptoken { get { throw null; } set { } }
        public float? Take { get { throw null; } set { } }
    }
    public partial class BillingProfileResourceGetTransactionsOptions
    {
        public BillingProfileResourceGetTransactionsOptions(System.DateTimeOffset periodStartDate, System.DateTimeOffset periodEndDate, Azure.ResourceManager.Billing.Models.TransactionType type) { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public System.DateTimeOffset PeriodEndDate { get { throw null; } }
        public System.DateTimeOffset PeriodStartDate { get { throw null; } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.TransactionType Type { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingProfileStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingProfileStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingProfileStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatus Deleted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatus UnderReview { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatus Warned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingProfileStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingProfileStatus left, Azure.ResourceManager.Billing.Models.BillingProfileStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingProfileStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingProfileStatus left, Azure.ResourceManager.Billing.Models.BillingProfileStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingProfileStatusReasonCode : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingProfileStatusReasonCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode PastDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode SpendingLimitExpired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode SpendingLimitReached { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode UnusualActivity { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode left, Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode left, Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingProfileSubscriptionCollectionGetAllOptions
    {
        public BillingProfileSubscriptionCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Expand { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeDeleted { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingProvisioningState : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState ConfirmedBilling { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState Created { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState New { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState Pending { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState PendingBilling { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingProvisioningState left, Azure.ResourceManager.Billing.Models.BillingProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingProvisioningState left, Azure.ResourceManager.Billing.Models.BillingProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingProvisioningTenantState : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingProvisioningTenantState(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState BillingRequestDeclined { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState BillingRequestExpired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState NotRequested { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState Pending { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState Revoked { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState left, Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState left, Azure.ResourceManager.Billing.Models.BillingProvisioningTenantState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingPurchaseProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPurchaseProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPurchaseProperties>
    {
        public BillingPurchaseProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPlan? BillingPlan { get { throw null; } set { } }
        public string BillingScopeId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingBenefitCommitment Commitment { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsRenewed { get { throw null; } set { } }
        public string SkuName { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm? Term { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingPurchaseProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPurchaseProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingPurchaseProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingPurchaseProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPurchaseProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPurchaseProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingPurchaseProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingRegistrationNumber : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRegistrationNumber>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRegistrationNumber>
    {
        public BillingRegistrationNumber() { }
        public string Id { get { throw null; } set { } }
        public bool? IsRequired { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RegistrationNumberType { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingRegistrationNumber System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRegistrationNumber>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRegistrationNumber>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingRegistrationNumber System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRegistrationNumber>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRegistrationNumber>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRegistrationNumber>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingRelationshipType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingRelationshipType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingRelationshipType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingRelationshipType CspCustomer { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRelationshipType CspPartner { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRelationshipType Direct { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRelationshipType IndirectCustomer { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRelationshipType IndirectPartner { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRelationshipType Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingRelationshipType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingRelationshipType left, Azure.ResourceManager.Billing.Models.BillingRelationshipType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingRelationshipType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingRelationshipType left, Azure.ResourceManager.Billing.Models.BillingRelationshipType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingRequestCollectionGetAllOptions
    {
        public BillingRequestCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingRequestProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRequestProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRequestProperties>
    {
        public BillingRequestProperties() { }
        public System.Collections.Generic.IDictionary<string, string> AdditionalInformation { get { throw null; } }
        public string BillingAccountDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingAccountId { get { throw null; } }
        public string BillingAccountName { get { throw null; } }
        public System.Guid? BillingAccountPrimaryBillingTenantId { get { throw null; } }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public string BillingProfileName { get { throw null; } }
        public string BillingScope { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingPrincipal CreatedBy { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string CustomerDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier CustomerId { get { throw null; } }
        public string CustomerName { get { throw null; } }
        public string DecisionReason { get { throw null; } set { } }
        public System.DateTimeOffset? ExpireOn { get { throw null; } }
        public string InvoiceSectionDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier InvoiceSectionId { get { throw null; } }
        public string InvoiceSectionName { get { throw null; } }
        public string Justification { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPrincipal LastUpdatedBy { get { throw null; } set { } }
        public System.DateTimeOffset? LastUpdatedOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingPrincipal> Recipients { get { throw null; } }
        public string RequestScope { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingRequestType? RequestType { get { throw null; } set { } }
        public System.DateTimeOffset? ReviewalOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingPrincipal ReviewedBy { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingRequestStatus? Status { get { throw null; } set { } }
        public string SubscriptionDisplayName { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        public string SubscriptionName { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingRequestProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRequestProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRequestProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingRequestProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRequestProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRequestProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRequestProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingRequestStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingRequestStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingRequestStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingRequestStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestStatus Cancelled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestStatus Completed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestStatus Declined { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestStatus Pending { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingRequestStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingRequestStatus left, Azure.ResourceManager.Billing.Models.BillingRequestStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingRequestStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingRequestStatus left, Azure.ResourceManager.Billing.Models.BillingRequestStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingRequestType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingRequestType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingRequestType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingRequestType InvoiceAccess { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestType Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestType ProvisioningAccess { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestType RoleAssignment { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingRequestType UpdateBillingPolicy { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingRequestType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingRequestType left, Azure.ResourceManager.Billing.Models.BillingRequestType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingRequestType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingRequestType left, Azure.ResourceManager.Billing.Models.BillingRequestType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingReservationPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingReservationPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingReservationPatch>
    {
        public BillingReservationPatch() { }
        public Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.InstanceFlexibility? InstanceFlexibility { get { throw null; } set { } }
        public bool? IsRenewed { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest PurchaseProperties { get { throw null; } set { } }
        public System.DateTimeOffset? ReviewOn { get { throw null; } set { } }
        public string SkuName { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingReservationPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingReservationPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingReservationPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingReservationPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingReservationPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingReservationPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingReservationPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingRoleAssignmentListResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>
    {
        internal BillingRoleAssignmentListResult() { }
        public string NextLink { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.BillingRoleAssignmentData> Value { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentListResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingRoleAssignmentProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties>
    {
        public BillingRoleAssignmentProperties(Azure.Core.ResourceIdentifier roleDefinitionId) { }
        public string BillingAccountDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingAccountId { get { throw null; } }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingRequestId { get { throw null; } }
        public string CreatedByPrincipalId { get { throw null; } }
        public string CreatedByPrincipalPuid { get { throw null; } }
        public System.Guid? CreatedByPrincipalTenantId { get { throw null; } }
        public string CreatedByUserEmailAddress { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string CustomerDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier CustomerId { get { throw null; } }
        public string InvoiceSectionDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier InvoiceSectionId { get { throw null; } }
        public string ModifiedByPrincipalId { get { throw null; } }
        public string ModifiedByPrincipalPuid { get { throw null; } }
        public System.Guid? ModifiedByPrincipalTenantId { get { throw null; } }
        public string ModifiedByUserEmailAddress { get { throw null; } }
        public System.DateTimeOffset? ModifiedOn { get { throw null; } }
        public string PrincipalDisplayName { get { throw null; } }
        public string PrincipalId { get { throw null; } set { } }
        public string PrincipalPuid { get { throw null; } set { } }
        public System.Guid? PrincipalTenantId { get { throw null; } set { } }
        public string PrincipalTenantName { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingPrincipalType? PrincipalType { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier RoleDefinitionId { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        public string UserAuthenticationType { get { throw null; } set { } }
        public string UserEmailAddress { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleAssignmentProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingRoleDefinitionProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties>
    {
        public BillingRoleDefinitionProperties(string roleName) { }
        public string Description { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingPermission> Permissions { get { throw null; } }
        public string RoleName { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingRoleDefinitionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingSavingsPlanModelPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch>
    {
        public BillingSavingsPlanModelPatch() { }
        public Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties Properties { get { throw null; } set { } }
        public string SkuName { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSavingsPlanModelPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingSavingsPlanTerm : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingSavingsPlanTerm(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm P1Y { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm P3Y { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm P5Y { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm left, Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm left, Azure.ResourceManager.Billing.Models.BillingSavingsPlanTerm right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSku>
    {
        public BillingSku() { }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingSpendingLimit : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingSpendingLimit>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingSpendingLimit(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSpendingLimit Off { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSpendingLimit On { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingSpendingLimit other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingSpendingLimit left, Azure.ResourceManager.Billing.Models.BillingSpendingLimit right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingSpendingLimit (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingSpendingLimit left, Azure.ResourceManager.Billing.Models.BillingSpendingLimit right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingSubscriptionAliasCollectionGetAllOptions
    {
        public BillingSubscriptionAliasCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeDeleted { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingSubscriptionAutoRenewState : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingSubscriptionAutoRenewState(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState Off { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState On { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState left, Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState left, Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingSubscriptionCollectionGetAllOptions
    {
        public BillingSubscriptionCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Expand { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public bool? IncludeDeleted { get { throw null; } set { } }
        public bool? IncludeFailed { get { throw null; } set { } }
        public bool? IncludeTenantSubscriptions { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    public partial class BillingSubscriptionMergeContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent>
    {
        public BillingSubscriptionMergeContent() { }
        public int? Quantity { get { throw null; } set { } }
        public string TargetBillingSubscriptionName { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMergeContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingSubscriptionMoveContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent>
    {
        public BillingSubscriptionMoveContent() { }
        public string DestinationEnrollmentAccountId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier DestinationInvoiceSectionId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionMoveContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingSubscriptionOperationStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingSubscriptionOperationStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus LockedForUpdate { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus left, Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus left, Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingSubscriptionPatch : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch>
    {
        public BillingSubscriptionPatch() { }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionAutoRenewState? AutoRenew { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingBeneficiary Beneficiary { get { throw null; } set { } }
        public System.Guid? BeneficiaryTenantId { get { throw null; } set { } }
        public string BillingFrequency { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyDictionary<string, string> BillingPolicies { get { throw null; } }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } set { } }
        public string BillingProfileName { get { throw null; } }
        public string ConsumptionCostCenter { get { throw null; } set { } }
        public string CustomerDisplayName { get { throw null; } }
        public string CustomerId { get { throw null; } set { } }
        public string CustomerName { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public string EnrollmentAccountDisplayName { get { throw null; } }
        public string EnrollmentAccountId { get { throw null; } }
        public System.DateTimeOffset? EnrollmentAccountStartOn { get { throw null; } }
        public string InvoiceSectionDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier InvoiceSectionId { get { throw null; } set { } }
        public string InvoiceSectionName { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount LastMonthCharges { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount MonthToDateCharges { get { throw null; } }
        public string NextBillingCycleBillingFrequency { get { throw null; } }
        public string OfferId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionOperationStatus? OperationStatus { get { throw null; } }
        public string ProductCategory { get { throw null; } }
        public string ProductType { get { throw null; } }
        public string ProductTypeId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        public System.Guid? ProvisioningTenantId { get { throw null; } set { } }
        public System.DateTimeOffset? PurchaseOn { get { throw null; } }
        public long? Quantity { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails RenewalTermDetails { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller Reseller { get { throw null; } }
        public System.Uri ResourceUri { get { throw null; } }
        public string SkuDescription { get { throw null; } }
        public string SkuId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus? Status { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus? SubscriptionEnrollmentAccountStatus { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails> SuspensionReasonDetails { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> SuspensionReasons { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingSystemOverrides SystemOverrides { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public System.TimeSpan? TermDuration { get { throw null; } set { } }
        public System.DateTimeOffset? TermEndOn { get { throw null; } }
        public System.DateTimeOffset? TermStartOn { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionPatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingSubscriptionSplitContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent>
    {
        public BillingSubscriptionSplitContent() { }
        public string BillingFrequency { get { throw null; } set { } }
        public int? Quantity { get { throw null; } set { } }
        public string TargetProductTypeId { get { throw null; } set { } }
        public string TargetSkuId { get { throw null; } set { } }
        public System.TimeSpan? TermDuration { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionSplitContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingSubscriptionStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingSubscriptionStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus AutoRenew { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Cancelled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Deleted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Expiring { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Suspended { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Unknown { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus Warned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus left, Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus left, Azure.ResourceManager.Billing.Models.BillingSubscriptionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingSubscriptionStatusDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails>
    {
        internal BillingSubscriptionStatusDetails() { }
        public System.DateTimeOffset? EffectiveOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.SubscriptionStatusReason? Reason { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionStatusDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingSubscriptionValidateMoveEligibilityError : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError>
    {
        internal BillingSubscriptionValidateMoveEligibilityError() { }
        public Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode? Code { get { throw null; } }
        public string Details { get { throw null; } }
        public string Message { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingSubscriptionValidateMoveEligibilityResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult>
    {
        internal BillingSubscriptionValidateMoveEligibilityResult() { }
        public Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityError ErrorDetails { get { throw null; } }
        public bool? IsMoveEligible { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSubscriptionValidateMoveEligibilityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingSupportedAccountType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingSupportedAccountType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingSupportedAccountType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingSupportedAccountType Enterprise { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSupportedAccountType Individual { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSupportedAccountType None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingSupportedAccountType Partner { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingSupportedAccountType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingSupportedAccountType left, Azure.ResourceManager.Billing.Models.BillingSupportedAccountType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingSupportedAccountType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingSupportedAccountType left, Azure.ResourceManager.Billing.Models.BillingSupportedAccountType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingSystemOverrides : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSystemOverrides>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSystemOverrides>
    {
        public BillingSystemOverrides() { }
        public Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation? Cancellation { get { throw null; } }
        public System.DateTimeOffset? CancellationAllowedEndOn { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingSystemOverrides System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSystemOverrides>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingSystemOverrides>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingSystemOverrides System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSystemOverrides>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSystemOverrides>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingSystemOverrides>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingTaxIdentifier : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTaxIdentifier>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTaxIdentifier>
    {
        public BillingTaxIdentifier() { }
        public string Country { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType? IdentifierType { get { throw null; } set { } }
        public string Scope { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus? Status { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingTaxIdentifier System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTaxIdentifier>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTaxIdentifier>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingTaxIdentifier System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTaxIdentifier>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTaxIdentifier>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTaxIdentifier>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingTaxIdentifierStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingTaxIdentifierStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus Invalid { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus Valid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus left, Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus left, Azure.ResourceManager.Billing.Models.BillingTaxIdentifierStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingTaxIdentifierType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingTaxIdentifierType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType BrazilCcmId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType BrazilCnpjId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType BrazilCpfId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType CanadianFederalExempt { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType CanadianProvinceExempt { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType ExternalTaxation { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType IndiaFederalServiceTaxId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType IndiaFederalTanId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType IndiaPanId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType IndiaStateCstId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType IndiaStateGstINId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType IndiaStateVatId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType IntlExempt { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType LoveCode { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType MobileBarCode { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType NationalIdentificationNumber { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType PublicSectorId { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType USExempt { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType VatId { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType left, Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType left, Azure.ResourceManager.Billing.Models.BillingTaxIdentifierType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingTransactionCreditType : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingTransactionCreditType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingTransactionCreditType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionCreditType AzureCreditOffer { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionCreditType AzureFreeCredit { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionCreditType Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionCreditType Refund { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionCreditType ServiceInterruption { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingTransactionCreditType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingTransactionCreditType left, Azure.ResourceManager.Billing.Models.BillingTransactionCreditType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingTransactionCreditType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingTransactionCreditType left, Azure.ResourceManager.Billing.Models.BillingTransactionCreditType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingTransactionData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransactionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionData>
    {
        public BillingTransactionData() { }
        public Azure.ResourceManager.Billing.Models.BillingTransactionProperties Properties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingTransactionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransactionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransactionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingTransactionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BillingTransactionKind : System.IEquatable<Azure.ResourceManager.Billing.Models.BillingTransactionKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BillingTransactionKind(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionKind All { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionKind Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.BillingTransactionKind Reservation { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.BillingTransactionKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.BillingTransactionKind left, Azure.ResourceManager.Billing.Models.BillingTransactionKind right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.BillingTransactionKind (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.BillingTransactionKind left, Azure.ResourceManager.Billing.Models.BillingTransactionKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BillingTransactionProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransactionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionProperties>
    {
        public BillingTransactionProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingAmount AzureCreditApplied { get { throw null; } }
        public string AzurePlan { get { throw null; } set { } }
        public string BillingCurrency { get { throw null; } set { } }
        public System.BinaryData BillingProfileDisplayName { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAmount ConsumptionCommitmentDecremented { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingTransactionCreditType? CreditType { get { throw null; } set { } }
        public string CustomerDisplayName { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier CustomerId { get { throw null; } set { } }
        public float? Discount { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAmount EffectivePrice { get { throw null; } }
        public float? ExchangeRate { get { throw null; } set { } }
        public string Invoice { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier InvoiceId { get { throw null; } set { } }
        public string InvoiceSectionDisplayName { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier InvoiceSectionId { get { throw null; } set { } }
        public bool? IsThirdParty { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingTransactionKind? Kind { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAmount MarketPrice { get { throw null; } }
        public System.DateTimeOffset? On { get { throw null; } set { } }
        public string PartNumber { get { throw null; } set { } }
        public string PricingCurrency { get { throw null; } set { } }
        public string ProductDescription { get { throw null; } set { } }
        public string ProductFamily { get { throw null; } set { } }
        public string ProductType { get { throw null; } set { } }
        public string ProductTypeId { get { throw null; } set { } }
        public int? Quantity { get { throw null; } set { } }
        public string ReasonCode { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.RefundTransactionDetails RefundTransactionDetails { get { throw null; } set { } }
        public System.DateTimeOffset? ServicePeriodEndOn { get { throw null; } set { } }
        public System.DateTimeOffset? ServicePeriodStartOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.SpecialTaxationType? SpecialTaxationType { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAmount SubTotal { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount Tax { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount TransactionAmount { get { throw null; } }
        public string TransactionType { get { throw null; } set { } }
        public string UnitOfMeasure { get { throw null; } set { } }
        public float? Units { get { throw null; } set { } }
        public string UnitType { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingTransactionProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransactionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransactionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingTransactionProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingTransactionSummary : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransactionSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionSummary>
    {
        internal BillingTransactionSummary() { }
        public float? AzureCreditApplied { get { throw null; } }
        public string BillingCurrency { get { throw null; } }
        public float? ConsumptionCommitmentDecremented { get { throw null; } }
        public float? SubTotal { get { throw null; } }
        public float? Tax { get { throw null; } }
        public float? Total { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingTransactionSummary System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransactionSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransactionSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingTransactionSummary System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransactionSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingTransferDetailCreateOrUpdateContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent>
    {
        public BillingTransferDetailCreateOrUpdateContent() { }
        public string RecipientEmailId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferDetailCreateOrUpdateContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingTransferError : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferError>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferError>
    {
        internal BillingTransferError() { }
        public string Code { get { throw null; } }
        public string Message { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingTransferError System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferError>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferError>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingTransferError System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferError>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferError>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferError>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingTransferValidationResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResult>
    {
        internal BillingTransferValidationResult() { }
        public string ProductId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties> Results { get { throw null; } }
        public string Status { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingTransferValidationResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingTransferValidationResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingTransferValidationResultProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties>
    {
        internal BillingTransferValidationResultProperties() { }
        public string Code { get { throw null; } }
        public string Level { get { throw null; } }
        public string Message { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransferValidationResultProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class BillingTransitionDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransitionDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransitionDetails>
    {
        internal BillingTransitionDetails() { }
        public int? AnniversaryDay { get { throw null; } }
        public System.DateTimeOffset? TransitionOn { get { throw null; } }
        Azure.ResourceManager.Billing.Models.BillingTransitionDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransitionDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.BillingTransitionDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.BillingTransitionDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransitionDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransitionDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.BillingTransitionDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CancelSubscriptionContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.CancelSubscriptionContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.CancelSubscriptionContent>
    {
        public CancelSubscriptionContent(Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason cancellationReason) { }
        public Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason CancellationReason { get { throw null; } }
        public Azure.Core.ResourceIdentifier CustomerId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.CancelSubscriptionContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.CancelSubscriptionContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.CancelSubscriptionContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.CancelSubscriptionContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.CancelSubscriptionContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.CancelSubscriptionContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.CancelSubscriptionContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class CreatedSubscriptionReseller : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller>
    {
        public CreatedSubscriptionReseller() { }
        public string Description { get { throw null; } }
        public string ResellerId { get { throw null; } }
        Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.CreatedSubscriptionReseller>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CustomerSubscriptionCancellationReason : System.IEquatable<Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CustomerSubscriptionCancellationReason(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason Compromise { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason Dispute { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason left, Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason left, Azure.ResourceManager.Billing.Models.CustomerSubscriptionCancellationReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeleteBillingProfileEligibilityCode : System.IEquatable<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeleteBillingProfileEligibilityCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode ActiveBillingSubscriptions { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode ActiveCreditCard { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode ActiveCredits { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode LastBillingProfile { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode NotSupported { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode OutstandingCharges { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode PendingCharges { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode ReservedInstances { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode left, Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode left, Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DeleteBillingProfileEligibilityDetail : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail>
    {
        internal DeleteBillingProfileEligibilityDetail() { }
        public Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityCode? Code { get { throw null; } }
        public string Message { get { throw null; } }
        Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeleteBillingProfileEligibilityResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult>
    {
        internal DeleteBillingProfileEligibilityResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityDetail> EligibilityDetails { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus? EligibilityStatus { get { throw null; } }
        Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeleteBillingProfileEligibilityStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeleteBillingProfileEligibilityStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus NotAllowed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus left, Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus left, Azure.ResourceManager.Billing.Models.DeleteBillingProfileEligibilityStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeleteInvoiceSectionEligibilityCode : System.IEquatable<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeleteInvoiceSectionEligibilityCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode ActiveAzurePlans { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode ActiveBillingSubscriptions { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode LastInvoiceSection { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode ReservedInstances { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode left, Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode left, Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DeleteInvoiceSectionEligibilityDetail : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail>
    {
        internal DeleteInvoiceSectionEligibilityDetail() { }
        public Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityCode? Code { get { throw null; } }
        public string Message { get { throw null; } }
        Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class DeleteInvoiceSectionEligibilityResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult>
    {
        internal DeleteInvoiceSectionEligibilityResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityDetail> EligibilityDetails { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus? EligibilityStatus { get { throw null; } }
        Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DeleteInvoiceSectionEligibilityStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DeleteInvoiceSectionEligibilityStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus NotAllowed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus left, Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus left, Azure.ResourceManager.Billing.Models.DeleteInvoiceSectionEligibilityStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DetailedTransferStatus : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DetailedTransferStatus>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DetailedTransferStatus>
    {
        internal DetailedTransferStatus() { }
        public Azure.ResourceManager.Billing.Models.BillingTransferError ErrorDetails { get { throw null; } }
        public string ProductId { get { throw null; } }
        public string ProductName { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProductType? ProductType { get { throw null; } }
        public string SkuDescription { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProductTransferStatus? TransferStatus { get { throw null; } }
        Azure.ResourceManager.Billing.Models.DetailedTransferStatus System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DetailedTransferStatus>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.DetailedTransferStatus>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.DetailedTransferStatus System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DetailedTransferStatus>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DetailedTransferStatus>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.DetailedTransferStatus>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EligibleProductType : System.IEquatable<Azure.ResourceManager.Billing.Models.EligibleProductType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EligibleProductType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.EligibleProductType AzureReservation { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EligibleProductType DevTestAzureSubscription { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EligibleProductType StandardAzureSubscription { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.EligibleProductType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.EligibleProductType left, Azure.ResourceManager.Billing.Models.EligibleProductType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.EligibleProductType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.EligibleProductType left, Azure.ResourceManager.Billing.Models.EligibleProductType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EnrollmentAccountOwnerViewCharge : System.IEquatable<Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EnrollmentAccountOwnerViewCharge(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge NotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge left, Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge left, Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EnrollmentAuthLevelState : System.IEquatable<Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EnrollmentAuthLevelState(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState MicrosoftAccountOnly { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState MixedAccount { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState OrganizationalAccountCrossTenant { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState OrganizationalAccountOnly { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState left, Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState left, Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EnrollmentDepartmentAdminViewCharge : System.IEquatable<Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EnrollmentDepartmentAdminViewCharge(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge NotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge left, Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge left, Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EnrollmentMarkupStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EnrollmentMarkupStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus Locked { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus Preview { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus Published { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus left, Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus left, Azure.ResourceManager.Billing.Models.EnrollmentMarkupStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EnterpriseAgreementPolicies : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies>
    {
        public EnterpriseAgreementPolicies() { }
        public Azure.ResourceManager.Billing.Models.EnrollmentAccountOwnerViewCharge? AccountOwnerViewCharges { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.EnrollmentAuthLevelState? AuthenticationType { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.EnrollmentDepartmentAdminViewCharge? DepartmentAdminViewCharges { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.EnterpriseAgreementPolicies>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ExtendedStatusInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ExtendedStatusInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ExtendedStatusInfo>
    {
        internal ExtendedStatusInfo() { }
        public string Message { get { throw null; } }
        public string StatusCode { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
        Azure.ResourceManager.Billing.Models.ExtendedStatusInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ExtendedStatusInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ExtendedStatusInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ExtendedStatusInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ExtendedStatusInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ExtendedStatusInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ExtendedStatusInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ExtendedTermOption : System.IEquatable<Azure.ResourceManager.Billing.Models.ExtendedTermOption>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ExtendedTermOption(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.ExtendedTermOption OptedIn { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ExtendedTermOption OptedOut { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ExtendedTermOption Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.ExtendedTermOption other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.ExtendedTermOption left, Azure.ResourceManager.Billing.Models.ExtendedTermOption right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.ExtendedTermOption (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.ExtendedTermOption left, Azure.ResourceManager.Billing.Models.ExtendedTermOption right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IndirectRelationshipInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo>
    {
        public IndirectRelationshipInfo() { }
        public string BillingAccountName { get { throw null; } set { } }
        public string BillingProfileName { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.IndirectRelationshipInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InitiatorCustomerType : System.IEquatable<Azure.ResourceManager.Billing.Models.InitiatorCustomerType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InitiatorCustomerType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.InitiatorCustomerType EA { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InitiatorCustomerType Partner { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.InitiatorCustomerType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.InitiatorCustomerType left, Azure.ResourceManager.Billing.Models.InitiatorCustomerType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.InitiatorCustomerType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.InitiatorCustomerType left, Azure.ResourceManager.Billing.Models.InitiatorCustomerType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InstanceFlexibility : System.IEquatable<Azure.ResourceManager.Billing.Models.InstanceFlexibility>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InstanceFlexibility(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.InstanceFlexibility Off { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InstanceFlexibility On { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.InstanceFlexibility other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.InstanceFlexibility left, Azure.ResourceManager.Billing.Models.InstanceFlexibility right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.InstanceFlexibility (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.InstanceFlexibility left, Azure.ResourceManager.Billing.Models.InstanceFlexibility right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class InvoiceDocument : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.InvoiceDocument>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.InvoiceDocument>
    {
        internal InvoiceDocument() { }
        public System.Collections.Generic.IReadOnlyList<string> DocumentNumbers { get { throw null; } }
        public System.Uri ExternalUri { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.InvoiceDocumentType? Kind { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingDocumentSource? Source { get { throw null; } }
        public System.Uri Uri { get { throw null; } }
        Azure.ResourceManager.Billing.Models.InvoiceDocument System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.InvoiceDocument>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.InvoiceDocument>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.InvoiceDocument System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.InvoiceDocument>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.InvoiceDocument>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.InvoiceDocument>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InvoiceDocumentType : System.IEquatable<Azure.ResourceManager.Billing.Models.InvoiceDocumentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InvoiceDocumentType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.InvoiceDocumentType CreditNote { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceDocumentType Invoice { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceDocumentType Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceDocumentType Summary { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceDocumentType TaxReceipt { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceDocumentType Transactions { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceDocumentType VoidNote { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.InvoiceDocumentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.InvoiceDocumentType left, Azure.ResourceManager.Billing.Models.InvoiceDocumentType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.InvoiceDocumentType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.InvoiceDocumentType left, Azure.ResourceManager.Billing.Models.InvoiceDocumentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InvoiceSectionLabelManagementPolicy : System.IEquatable<Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InvoiceSectionLabelManagementPolicy(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy NotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy left, Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy left, Azure.ResourceManager.Billing.Models.InvoiceSectionLabelManagementPolicy right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InvoiceSectionState : System.IEquatable<Azure.ResourceManager.Billing.Models.InvoiceSectionState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InvoiceSectionState(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionState Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionState Deleted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionState Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionState Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionState Restricted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionState UnderReview { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionState Warned { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.InvoiceSectionState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.InvoiceSectionState left, Azure.ResourceManager.Billing.Models.InvoiceSectionState right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.InvoiceSectionState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.InvoiceSectionState left, Azure.ResourceManager.Billing.Models.InvoiceSectionState right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct InvoiceSectionStateReasonCode : System.IEquatable<Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public InvoiceSectionStateReasonCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode PastDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode SpendingLimitExpired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode SpendingLimitReached { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode UnusualActivity { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode left, Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode left, Azure.ResourceManager.Billing.Models.InvoiceSectionStateReasonCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class InvoiceSectionWithCreateSubPermission : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission>
    {
        internal InvoiceSectionWithCreateSubPermission() { }
        public string BillingProfileDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier BillingProfileId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingSpendingLimit? BillingProfileSpendingLimit { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProfileStatus? BillingProfileStatus { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProfileStatusReasonCode? BillingProfileStatusReasonCode { get { throw null; } }
        public string BillingProfileSystemId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.BillingAzurePlan> EnabledAzurePlans { get { throw null; } }
        public string InvoiceSectionDisplayName { get { throw null; } }
        public Azure.Core.ResourceIdentifier InvoiceSectionId { get { throw null; } }
        public string InvoiceSectionSystemId { get { throw null; } }
        Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.InvoiceSectionWithCreateSubPermission>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MarketplacePurchasesPolicy : System.IEquatable<Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MarketplacePurchasesPolicy(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy AllAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy NotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy OnlyFreeAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy left, Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy left, Azure.ResourceManager.Billing.Models.MarketplacePurchasesPolicy right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MoveProductContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.MoveProductContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductContent>
    {
        public MoveProductContent(Azure.Core.ResourceIdentifier destinationInvoiceSectionId) { }
        public Azure.Core.ResourceIdentifier DestinationInvoiceSectionId { get { throw null; } }
        Azure.ResourceManager.Billing.Models.MoveProductContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.MoveProductContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.MoveProductContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.MoveProductContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MoveProductEligibilityResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult>
    {
        internal MoveProductEligibilityResult() { }
        public Azure.ResourceManager.Billing.Models.MoveProductErrorDetails ErrorDetails { get { throw null; } }
        public bool? IsMoveEligible { get { throw null; } }
        Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductEligibilityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class MoveProductErrorDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.MoveProductErrorDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductErrorDetails>
    {
        internal MoveProductErrorDetails() { }
        public Azure.ResourceManager.Billing.Models.MoveValidationErrorCode? Code { get { throw null; } }
        public string Details { get { throw null; } }
        public string Message { get { throw null; } }
        Azure.ResourceManager.Billing.Models.MoveProductErrorDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.MoveProductErrorDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.MoveProductErrorDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.MoveProductErrorDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductErrorDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductErrorDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.MoveProductErrorDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MoveValidationErrorCode : System.IEquatable<Azure.ResourceManager.Billing.Models.MoveValidationErrorCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MoveValidationErrorCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode BillingAccountInactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode DestinationBillingProfileInactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode DestinationBillingProfileNotFound { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode DestinationBillingProfilePastDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode DestinationInvoiceSectionInactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode DestinationInvoiceSectionNotFound { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode InsufficientPermissionOnDestination { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode InsufficientPermissionOnSource { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode InvalidDestination { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode InvalidSource { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode MarketplaceNotEnabledOnDestination { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode ProductInactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode ProductNotFound { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode ProductTypeNotSupported { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode SourceBillingProfilePastDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.MoveValidationErrorCode SourceInvoiceSectionInactive { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.MoveValidationErrorCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.MoveValidationErrorCode left, Azure.ResourceManager.Billing.Models.MoveValidationErrorCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.MoveValidationErrorCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.MoveValidationErrorCode left, Azure.ResourceManager.Billing.Models.MoveValidationErrorCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PartnerTransferDetailCreateOrUpdateContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent>
    {
        public PartnerTransferDetailCreateOrUpdateContent() { }
        public string RecipientEmailId { get { throw null; } set { } }
        public string ResellerId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PartnerTransferDetailCreateOrUpdateContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PartnerTransferStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.PartnerTransferStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PartnerTransferStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PartnerTransferStatus Canceled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PartnerTransferStatus Completed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PartnerTransferStatus CompletedWithErrors { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PartnerTransferStatus Declined { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PartnerTransferStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PartnerTransferStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PartnerTransferStatus InProgress { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PartnerTransferStatus Pending { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.PartnerTransferStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.PartnerTransferStatus left, Azure.ResourceManager.Billing.Models.PartnerTransferStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.PartnerTransferStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.PartnerTransferStatus left, Azure.ResourceManager.Billing.Models.PartnerTransferStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PaymentMethodFamily : System.IEquatable<Azure.ResourceManager.Billing.Models.PaymentMethodFamily>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PaymentMethodFamily(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodFamily CheckWire { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodFamily CreditCard { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodFamily Credits { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodFamily DirectDebit { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodFamily EWallet { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodFamily None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodFamily Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodFamily TaskOrder { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.PaymentMethodFamily other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.PaymentMethodFamily left, Azure.ResourceManager.Billing.Models.PaymentMethodFamily right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.PaymentMethodFamily (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.PaymentMethodFamily left, Azure.ResourceManager.Billing.Models.PaymentMethodFamily right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PaymentMethodLogo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentMethodLogo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentMethodLogo>
    {
        public PaymentMethodLogo() { }
        public string MimeType { get { throw null; } }
        public System.Uri Uri { get { throw null; } }
        Azure.ResourceManager.Billing.Models.PaymentMethodLogo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentMethodLogo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentMethodLogo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.PaymentMethodLogo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentMethodLogo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentMethodLogo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentMethodLogo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PaymentMethodProjectionProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties>
    {
        public PaymentMethodProjectionProperties() { }
        public string AccountHolderName { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string Expiration { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentMethodFamily? Family { get { throw null; } set { } }
        public string LastFourDigits { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.PaymentMethodLogo> Logos { get { throw null; } }
        public Azure.Core.ResourceIdentifier PaymentMethodId { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is now deprecated. Please use the new property `PaymentMethodType` moving forward.")]
        public string PaymentMethodProjectionPropertiesType { get { throw null; } }
        public string PaymentMethodType { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentMethodStatus? Status { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentMethodProjectionProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PaymentMethodStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.PaymentMethodStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PaymentMethodStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentMethodStatus Inactive { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.PaymentMethodStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.PaymentMethodStatus left, Azure.ResourceManager.Billing.Models.PaymentMethodStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.PaymentMethodStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.PaymentMethodStatus left, Azure.ResourceManager.Billing.Models.PaymentMethodStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PaymentTermsEligibilityCode : System.IEquatable<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PaymentTermsEligibilityCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode BillingAccountNotFound { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode InactiveBillingAccount { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode IneligibleBillingAccountStatus { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode InvalidBillingAccountType { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode InvalidDateFormat { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode InvalidDateRange { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode InvalidTerms { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode NullOrEmptyPaymentTerms { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode OverlappingPaymentTerms { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode left, Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode left, Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PaymentTermsEligibilityDetail : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail>
    {
        internal PaymentTermsEligibilityDetail() { }
        public Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityCode? Code { get { throw null; } }
        public string Message { get { throw null; } }
        Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class PaymentTermsEligibilityResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult>
    {
        internal PaymentTermsEligibilityResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityDetail> EligibilityDetails { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus? EligibilityStatus { get { throw null; } }
        Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PaymentTermsEligibilityStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PaymentTermsEligibilityStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus Invalid { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus Valid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus left, Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus left, Azure.ResourceManager.Billing.Models.PaymentTermsEligibilityStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PolicyOverrideCancellation : System.IEquatable<Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PolicyOverrideCancellation(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation NotAllowed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation left, Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation left, Azure.ResourceManager.Billing.Models.PolicyOverrideCancellation right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RebillDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.RebillDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RebillDetails>
    {
        internal RebillDetails() { }
        public Azure.Core.ResourceIdentifier CreditNoteDocumentId { get { throw null; } }
        public Azure.Core.ResourceIdentifier InvoiceDocumentId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.RebillDetails RebillDetailsValue { get { throw null; } }
        Azure.ResourceManager.Billing.Models.RebillDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.RebillDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.RebillDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.RebillDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RebillDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RebillDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RebillDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class RefundDetailsSummary : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.RefundDetailsSummary>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RefundDetailsSummary>
    {
        public RefundDetailsSummary() { }
        public Azure.ResourceManager.Billing.Models.BillingAmount AmountRefunded { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount AmountRequested { get { throw null; } }
        public System.DateTimeOffset? ApprovedOn { get { throw null; } }
        public System.DateTimeOffset? CompletedOn { get { throw null; } }
        public Azure.Core.ResourceIdentifier RebillInvoiceId { get { throw null; } }
        public string RefundOperationId { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.RefundReasonCode? RefundReason { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.RefundStatus? RefundStatus { get { throw null; } }
        public System.DateTimeOffset? RequestedOn { get { throw null; } }
        public int? TransactionCount { get { throw null; } }
        Azure.ResourceManager.Billing.Models.RefundDetailsSummary System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.RefundDetailsSummary>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.RefundDetailsSummary>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.RefundDetailsSummary System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RefundDetailsSummary>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RefundDetailsSummary>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RefundDetailsSummary>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RefundReasonCode : System.IEquatable<Azure.ResourceManager.Billing.Models.RefundReasonCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RefundReasonCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.RefundReasonCode AccidentalConversion { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundReasonCode AccidentalPurchase { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundReasonCode ForgotToCancel { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundReasonCode Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundReasonCode UnclearDocumentation { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundReasonCode UnclearPricing { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.RefundReasonCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.RefundReasonCode left, Azure.ResourceManager.Billing.Models.RefundReasonCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.RefundReasonCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.RefundReasonCode left, Azure.ResourceManager.Billing.Models.RefundReasonCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RefundStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.RefundStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RefundStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.RefundStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundStatus Cancelled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundStatus Completed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundStatus Declined { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundStatus Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.RefundStatus Pending { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.RefundStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.RefundStatus left, Azure.ResourceManager.Billing.Models.RefundStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.RefundStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.RefundStatus left, Azure.ResourceManager.Billing.Models.RefundStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RefundTransactionDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.RefundTransactionDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RefundTransactionDetails>
    {
        public RefundTransactionDetails() { }
        public Azure.ResourceManager.Billing.Models.BillingAmount AmountRefunded { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAmount AmountRequested { get { throw null; } }
        public string RefundOperationId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.RefundTransactionDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.RefundTransactionDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.RefundTransactionDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.RefundTransactionDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RefundTransactionDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RefundTransactionDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.RefundTransactionDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReservationAppliedScopeProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties>
    {
        public ReservationAppliedScopeProperties() { }
        public string DisplayName { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ManagementGroupId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ResourceGroupId { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
        public System.Guid? TenantId { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ReservationBillingPlan : System.IEquatable<Azure.ResourceManager.Billing.Models.ReservationBillingPlan>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ReservationBillingPlan(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.ReservationBillingPlan Monthly { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationBillingPlan Upfront { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.ReservationBillingPlan other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.ReservationBillingPlan left, Azure.ResourceManager.Billing.Models.ReservationBillingPlan right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.ReservationBillingPlan (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.ReservationBillingPlan left, Azure.ResourceManager.Billing.Models.ReservationBillingPlan right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ReservationExtendedStatusInfo : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo>
    {
        public ReservationExtendedStatusInfo() { }
        public string ExtendedStatusDefinitionSubscriptionId { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationStatusCode? StatusCode { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReservationMergeProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationMergeProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationMergeProperties>
    {
        public ReservationMergeProperties() { }
        public string MergeDestination { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> MergeSources { get { throw null; } }
        Azure.ResourceManager.Billing.Models.ReservationMergeProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationMergeProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationMergeProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationMergeProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationMergeProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationMergeProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationMergeProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReservationOrderBillingPlanInformation : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation>
    {
        public ReservationOrderBillingPlanInformation() { }
        public System.DateTimeOffset? NextPaymentDueOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPrice PricingCurrencyTotal { get { throw null; } set { } }
        public System.DateTimeOffset? StartOn { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.ReservationPaymentDetail> Transactions { get { throw null; } }
        Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationOrderBillingPlanInformation>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReservationPaymentDetail : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationPaymentDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationPaymentDetail>
    {
        public ReservationPaymentDetail() { }
        public string BillingAccount { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPrice BillingCurrencyTotal { get { throw null; } set { } }
        public System.DateTimeOffset? DueOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationExtendedStatusInfo ExtendedStatusInfo { get { throw null; } set { } }
        public System.DateTimeOffset? PaymentOn { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPrice PricingCurrencyTotal { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPaymentStatus? Status { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.ReservationPaymentDetail System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationPaymentDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationPaymentDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationPaymentDetail System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationPaymentDetail>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationPaymentDetail>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationPaymentDetail>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReservationPurchaseRequest : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest>
    {
        public ReservationPurchaseRequest() { }
        public Azure.ResourceManager.Billing.Models.ReservationAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> AppliedScopes { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationBillingPlan? BillingPlan { get { throw null; } set { } }
        public string BillingScopeId { get { throw null; } }
        public string DisplayName { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.InstanceFlexibility? InstanceFlexibilityPropertiesInstanceFlexibility { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.InstanceFlexibility? InstanceFlexibilityPropertiesReservedResourcePropertiesInstanceFlexibility { get { throw null; } set { } }
        public bool? IsRenewed { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public int? Quantity { get { throw null; } set { } }
        public string ReservedResourceType { get { throw null; } }
        public System.DateTimeOffset? ReviewOn { get { throw null; } set { } }
        public string SkuName { get { throw null; } set { } }
        public string Term { get { throw null; } }
        Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ReservationPurchasesPolicy : System.IEquatable<Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ReservationPurchasesPolicy(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy NotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy left, Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy left, Azure.ResourceManager.Billing.Models.ReservationPurchasesPolicy right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ReservationRenewProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationRenewProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationRenewProperties>
    {
        public ReservationRenewProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingPrice BillingCurrencyTotal { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPrice PricingCurrencyTotal { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.ReservationPurchaseRequest PurchaseProperties { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.ReservationRenewProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationRenewProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationRenewProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationRenewProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationRenewProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationRenewProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationRenewProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReservationSplitProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationSplitProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationSplitProperties>
    {
        public ReservationSplitProperties() { }
        public System.Collections.Generic.IList<string> SplitDestinations { get { throw null; } }
        public string SplitSource { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.ReservationSplitProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationSplitProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationSplitProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationSplitProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationSplitProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationSplitProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationSplitProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ReservationStatusCode : System.IEquatable<Azure.ResourceManager.Billing.Models.ReservationStatusCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ReservationStatusCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode CapacityError { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode CapacityRestricted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode CreditLineCheckFailed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode Exchanged { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode Merged { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode NoBenefit { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode NoBenefitDueToSubscriptionDeletion { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode NoBenefitDueToSubscriptionTransfer { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode PaymentInstrumentError { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode Pending { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode Processing { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode PurchaseError { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode RiskCheckFailed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode Split { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode Succeeded { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode UnknownError { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ReservationStatusCode Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.ReservationStatusCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.ReservationStatusCode left, Azure.ResourceManager.Billing.Models.ReservationStatusCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.ReservationStatusCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.ReservationStatusCode left, Azure.ResourceManager.Billing.Models.ReservationStatusCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ReservationSwapProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationSwapProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationSwapProperties>
    {
        public ReservationSwapProperties() { }
        public string SwapDestination { get { throw null; } set { } }
        public string SwapSource { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.ReservationSwapProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationSwapProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationSwapProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationSwapProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationSwapProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationSwapProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationSwapProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ReservationUtilizationAggregates : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates>
    {
        public ReservationUtilizationAggregates() { }
        public float? Grain { get { throw null; } }
        public string GrainUnit { get { throw null; } }
        public float? Value { get { throw null; } }
        public string ValueUnit { get { throw null; } }
        Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.ReservationUtilizationAggregates>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SavingsPlanPurchasesPolicy : System.IEquatable<Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SavingsPlanPurchasesPolicy(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy Disabled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy NotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy left, Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy left, Azure.ResourceManager.Billing.Models.SavingsPlanPurchasesPolicy right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SavingsPlanUpdateRequestProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties>
    {
        public SavingsPlanUpdateRequestProperties() { }
        public Azure.ResourceManager.Billing.Models.BillingAppliedScopeProperties AppliedScopeProperties { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingAppliedScopeType? AppliedScopeType { get { throw null; } set { } }
        public string DisplayName { get { throw null; } set { } }
        public bool? IsRenewed { get { throw null; } set { } }
        public Azure.ResourceManager.Billing.Models.BillingPurchaseProperties RenewPurchaseProperties { get { throw null; } set { } }
        Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SavingsPlanUpdateValidateContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent>
    {
        public SavingsPlanUpdateValidateContent() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateRequestProperties> Benefits { get { throw null; } }
        Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUpdateValidateContent>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SavingsPlanUtilization : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilization>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilization>
    {
        internal SavingsPlanUtilization() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates> Aggregates { get { throw null; } }
        public string Trend { get { throw null; } }
        Azure.ResourceManager.Billing.Models.SavingsPlanUtilization System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilization>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilization>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.SavingsPlanUtilization System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilization>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilization>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilization>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SavingsPlanUtilizationAggregates : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates>
    {
        internal SavingsPlanUtilizationAggregates() { }
        public float? Grain { get { throw null; } }
        public string GrainUnit { get { throw null; } }
        public float? Value { get { throw null; } }
        public string ValueUnit { get { throw null; } }
        Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanUtilizationAggregates>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SavingsPlanValidateResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult>
    {
        internal SavingsPlanValidateResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty> Benefits { get { throw null; } }
        public string NextLink { get { throw null; } }
        Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidateResult>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SavingsPlanValidResponseProperty : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty>
    {
        internal SavingsPlanValidResponseProperty() { }
        public bool? IsValid { get { throw null; } }
        public string Reason { get { throw null; } }
        public string ReasonCode { get { throw null; } }
        Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SavingsPlanValidResponseProperty>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ServiceDefinedResourceName : System.IEquatable<Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ServiceDefinedResourceName(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName Default { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName left, Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName left, Azure.ResourceManager.Billing.Models.ServiceDefinedResourceName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SpecialTaxationType : System.IEquatable<Azure.ResourceManager.Billing.Models.SpecialTaxationType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SpecialTaxationType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SpecialTaxationType InvoiceLevel { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpecialTaxationType SubtotalLevel { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.SpecialTaxationType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.SpecialTaxationType left, Azure.ResourceManager.Billing.Models.SpecialTaxationType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.SpecialTaxationType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.SpecialTaxationType left, Azure.ResourceManager.Billing.Models.SpecialTaxationType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SpendingLimitDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SpendingLimitDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SpendingLimitDetails>
    {
        internal SpendingLimitDetails() { }
        public float? Amount { get { throw null; } }
        public string Currency { get { throw null; } }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.SpendingLimitType? LimitType { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.SpendingLimitStatus? Status { get { throw null; } }
        Azure.ResourceManager.Billing.Models.SpendingLimitDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SpendingLimitDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SpendingLimitDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.SpendingLimitDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SpendingLimitDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SpendingLimitDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SpendingLimitDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SpendingLimitStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.SpendingLimitStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SpendingLimitStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitStatus LimitReached { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitStatus LimitRemoved { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitStatus None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitStatus Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.SpendingLimitStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.SpendingLimitStatus left, Azure.ResourceManager.Billing.Models.SpendingLimitStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.SpendingLimitStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.SpendingLimitStatus left, Azure.ResourceManager.Billing.Models.SpendingLimitStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SpendingLimitType : System.IEquatable<Azure.ResourceManager.Billing.Models.SpendingLimitType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SpendingLimitType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType AcademicSponsorship { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType AzureConsumptionCredit { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType AzureForStudents { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType AzureForStudentsStarter { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType AzurePassSponsorship { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType FreeAccount { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType MpnSponsorship { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType Msdn { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType NonProfitSponsorship { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType Sandbox { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType Sponsorship { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType StartupSponsorship { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SpendingLimitType VisualStudio { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.SpendingLimitType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.SpendingLimitType left, Azure.ResourceManager.Billing.Models.SpendingLimitType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.SpendingLimitType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.SpendingLimitType left, Azure.ResourceManager.Billing.Models.SpendingLimitType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SubscriptionBillingInvoiceCollectionGetAllOptions
    {
        public SubscriptionBillingInvoiceCollectionGetAllOptions() { }
        public bool? Count { get { throw null; } set { } }
        public string Filter { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public System.DateTimeOffset? PeriodEndDate { get { throw null; } set { } }
        public System.DateTimeOffset? PeriodStartDate { get { throw null; } set { } }
        public string Search { get { throw null; } set { } }
        public long? Skip { get { throw null; } set { } }
        public long? Top { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SubscriptionEnrollmentAccountStatus : System.IEquatable<Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SubscriptionEnrollmentAccountStatus(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus Active { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus Cancelled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus Deleted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus Inactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus TransferredOut { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus Transferring { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus left, Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus left, Azure.ResourceManager.Billing.Models.SubscriptionEnrollmentAccountStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SubscriptionPolicyProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties>
    {
        public SubscriptionPolicyProperties() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Billing.Models.BillingPolicySummary> Policies { get { throw null; } }
        public Azure.ResourceManager.Billing.Models.BillingProvisioningState? ProvisioningState { get { throw null; } }
        Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SubscriptionPolicyProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class SubscriptionRenewalTermDetails : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails>
    {
        internal SubscriptionRenewalTermDetails() { }
        public string BillingFrequency { get { throw null; } }
        public string ProductId { get { throw null; } }
        public string ProductTypeId { get { throw null; } }
        public long? Quantity { get { throw null; } }
        public string SkuId { get { throw null; } }
        public System.TimeSpan? TermDuration { get { throw null; } }
        public System.DateTimeOffset? TermEndOn { get { throw null; } }
        Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.Billing.Models.SubscriptionRenewalTermDetails>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SubscriptionStatusReason : System.IEquatable<Azure.ResourceManager.Billing.Models.SubscriptionStatusReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SubscriptionStatusReason(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SubscriptionStatusReason Cancelled { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionStatusReason Expired { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionStatusReason None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionStatusReason Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionStatusReason PastDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionStatusReason PolicyViolation { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionStatusReason SpendingLimitReached { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionStatusReason SuspiciousActivity { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionStatusReason Transferred { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.SubscriptionStatusReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.SubscriptionStatusReason left, Azure.ResourceManager.Billing.Models.SubscriptionStatusReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.SubscriptionStatusReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.SubscriptionStatusReason left, Azure.ResourceManager.Billing.Models.SubscriptionStatusReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SubscriptionTransferValidationErrorCode : System.IEquatable<Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SubscriptionTransferValidationErrorCode(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode AccountIsLocked { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode AssetHasCap { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode AssetNotActive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode BillingAccountInactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode BillingProfilePastDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode CrossBillingAccountNotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode DestinationBillingProfileInactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode DestinationBillingProfileNotFound { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode DestinationBillingProfilePastDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode DestinationInvoiceSectionInactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode DestinationInvoiceSectionNotFound { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode InsufficientPermissionOnDestination { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode InsufficientPermissionOnSource { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode InvalidDestination { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode InvalidSource { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode InvoiceSectionIsRestricted { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode MarketplaceNotEnabledOnDestination { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode NoActiveAzurePlan { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode None { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode ProductInactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode ProductNotFound { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode ProductTypeNotSupported { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode SourceBillingProfilePastDue { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode SourceInvoiceSectionInactive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode SubscriptionHasReservations { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode SubscriptionNotActive { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode SubscriptionTypeNotSupported { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode left, Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode left, Azure.ResourceManager.Billing.Models.SubscriptionTransferValidationErrorCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TransactionType : System.IEquatable<Azure.ResourceManager.Billing.Models.TransactionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TransactionType(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.TransactionType Billed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.TransactionType Other { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.TransactionType Unbilled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.TransactionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.TransactionType left, Azure.ResourceManager.Billing.Models.TransactionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.TransactionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.TransactionType left, Azure.ResourceManager.Billing.Models.TransactionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ViewChargesPolicy : System.IEquatable<Azure.ResourceManager.Billing.Models.ViewChargesPolicy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ViewChargesPolicy(string value) { throw null; }
        public static Azure.ResourceManager.Billing.Models.ViewChargesPolicy Allowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ViewChargesPolicy NotAllowed { get { throw null; } }
        public static Azure.ResourceManager.Billing.Models.ViewChargesPolicy Other { get { throw null; } }
        public bool Equals(Azure.ResourceManager.Billing.Models.ViewChargesPolicy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.Billing.Models.ViewChargesPolicy left, Azure.ResourceManager.Billing.Models.ViewChargesPolicy right) { throw null; }
        public static implicit operator Azure.ResourceManager.Billing.Models.ViewChargesPolicy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.Billing.Models.ViewChargesPolicy left, Azure.ResourceManager.Billing.Models.ViewChargesPolicy right) { throw null; }
        public override string ToString() { throw null; }
    }
}
