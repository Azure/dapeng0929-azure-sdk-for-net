// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary>
    /// A class representing the StorageCacheImportJob data model.
    /// An import job instance. Follows Azure Resource Manager standards: https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/resource-api-reference.md
    /// </summary>
    public partial class StorageCacheImportJobData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageCacheImportJobData"/>. </summary>
        /// <param name="location"> The location. </param>
        public StorageCacheImportJobData(AzureLocation location) : base(location)
        {
            ImportPrefixes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheImportJobData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> ARM provisioning state. </param>
        /// <param name="adminStatus"> The administrative status of the import job. Possible values: 'Enable', 'Disable'. Passing in a value of 'Disable' will cancel the current active import job. By default it is set to 'Enable'. </param>
        /// <param name="importPrefixes"> An array of blob paths/prefixes that get imported into the cluster namespace. It has '/' as the default value. </param>
        /// <param name="conflictResolutionMode"> How the import job will handle conflicts. For example, if the import job is trying to bring in a directory, but a file is at that path, how it handles it. Fail indicates that the import job should stop immediately and not do anything with the conflict. Skip indicates that it should pass over the conflict. OverwriteIfDirty causes the import job to delete and re-import the file or directory if it is a conflicting type, is dirty, or was not previously imported. OverwriteAlways extends OverwriteIfDirty to include releasing files that had been restored but were not dirty. Please reference https://learn.microsoft.com/en-us/azure/azure-managed-lustre/ for a thorough explanation of these resolution modes. </param>
        /// <param name="maximumErrors"> Total non-conflict oriented errors the import job will tolerate before exiting with failure. -1 means infinite. 0 means exit immediately and is the default. </param>
        /// <param name="state"> The operational state of the import job. InProgress indicates the import is still running. Canceled indicates it has been canceled by the user. Completed indicates import finished, successfully importing all discovered blobs into the Lustre namespace. CompletedPartial indicates the import finished but some blobs either were found to be conflicting and could not be imported or other errors were encountered. Failed means the import was unable to complete due to a fatal error. </param>
        /// <param name="statusMessage"> The status message of the import job. </param>
        /// <param name="totalBlobsWalked"> The total blob objects walked. </param>
        /// <param name="blobsWalkedPerSecond"> A recent and frequently updated rate of blobs walked per second. </param>
        /// <param name="totalBlobsImported"> The total blobs that have been imported since import began. </param>
        /// <param name="importedFiles"> Number of new or modified files that have been imported into the filesystem. </param>
        /// <param name="importedDirectories"> Number of new or modified directories that have been imported into the filesystem. </param>
        /// <param name="importedSymlinks"> Number of newly added symbolic links into the filesystem. </param>
        /// <param name="preexistingFiles"> Number of files that already exist in the filesystem and have not been modified. </param>
        /// <param name="preexistingDirectories"> Number of directories that already exist in the filesystem and have not been modified. </param>
        /// <param name="preexistingSymlinks"> Number of symbolic links that already exist in the filesystem and have not been modified. </param>
        /// <param name="blobsImportedPerSecond"> A recent and frequently updated rate of total files, directories, and symlinks imported per second. </param>
        /// <param name="lastCompletionOn"> The time (in UTC) of the last completed import job. </param>
        /// <param name="lastStartedOn"> The time (in UTC) the latest import job started. </param>
        /// <param name="totalErrors"> Number of errors in the import job. </param>
        /// <param name="totalConflicts"> Number of conflicts in the import job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheImportJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ImportJobProvisioningStateType? provisioningState, ImportJobAdminStatus? adminStatus, IList<string> importPrefixes, ConflictResolutionMode? conflictResolutionMode, int? maximumErrors, ImportStatusType? state, string statusMessage, long? totalBlobsWalked, long? blobsWalkedPerSecond, long? totalBlobsImported, long? importedFiles, long? importedDirectories, long? importedSymlinks, long? preexistingFiles, long? preexistingDirectories, long? preexistingSymlinks, long? blobsImportedPerSecond, DateTimeOffset? lastCompletionOn, DateTimeOffset? lastStartedOn, int? totalErrors, int? totalConflicts, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            AdminStatus = adminStatus;
            ImportPrefixes = importPrefixes;
            ConflictResolutionMode = conflictResolutionMode;
            MaximumErrors = maximumErrors;
            State = state;
            StatusMessage = statusMessage;
            TotalBlobsWalked = totalBlobsWalked;
            BlobsWalkedPerSecond = blobsWalkedPerSecond;
            TotalBlobsImported = totalBlobsImported;
            ImportedFiles = importedFiles;
            ImportedDirectories = importedDirectories;
            ImportedSymlinks = importedSymlinks;
            PreexistingFiles = preexistingFiles;
            PreexistingDirectories = preexistingDirectories;
            PreexistingSymlinks = preexistingSymlinks;
            BlobsImportedPerSecond = blobsImportedPerSecond;
            LastCompletionOn = lastCompletionOn;
            LastStartedOn = lastStartedOn;
            TotalErrors = totalErrors;
            TotalConflicts = totalConflicts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheImportJobData"/> for deserialization. </summary>
        internal StorageCacheImportJobData()
        {
        }

        /// <summary> ARM provisioning state. </summary>
        public ImportJobProvisioningStateType? ProvisioningState { get; }
        /// <summary> The administrative status of the import job. Possible values: 'Enable', 'Disable'. Passing in a value of 'Disable' will cancel the current active import job. By default it is set to 'Enable'. </summary>
        public ImportJobAdminStatus? AdminStatus { get; set; }
        /// <summary> An array of blob paths/prefixes that get imported into the cluster namespace. It has '/' as the default value. </summary>
        public IList<string> ImportPrefixes { get; }
        /// <summary> How the import job will handle conflicts. For example, if the import job is trying to bring in a directory, but a file is at that path, how it handles it. Fail indicates that the import job should stop immediately and not do anything with the conflict. Skip indicates that it should pass over the conflict. OverwriteIfDirty causes the import job to delete and re-import the file or directory if it is a conflicting type, is dirty, or was not previously imported. OverwriteAlways extends OverwriteIfDirty to include releasing files that had been restored but were not dirty. Please reference https://learn.microsoft.com/en-us/azure/azure-managed-lustre/ for a thorough explanation of these resolution modes. </summary>
        public ConflictResolutionMode? ConflictResolutionMode { get; set; }
        /// <summary> Total non-conflict oriented errors the import job will tolerate before exiting with failure. -1 means infinite. 0 means exit immediately and is the default. </summary>
        public int? MaximumErrors { get; set; }
        /// <summary> The operational state of the import job. InProgress indicates the import is still running. Canceled indicates it has been canceled by the user. Completed indicates import finished, successfully importing all discovered blobs into the Lustre namespace. CompletedPartial indicates the import finished but some blobs either were found to be conflicting and could not be imported or other errors were encountered. Failed means the import was unable to complete due to a fatal error. </summary>
        public ImportStatusType? State { get; }
        /// <summary> The status message of the import job. </summary>
        public string StatusMessage { get; }
        /// <summary> The total blob objects walked. </summary>
        public long? TotalBlobsWalked { get; }
        /// <summary> A recent and frequently updated rate of blobs walked per second. </summary>
        public long? BlobsWalkedPerSecond { get; }
        /// <summary> The total blobs that have been imported since import began. </summary>
        public long? TotalBlobsImported { get; }
        /// <summary> Number of new or modified files that have been imported into the filesystem. </summary>
        public long? ImportedFiles { get; }
        /// <summary> Number of new or modified directories that have been imported into the filesystem. </summary>
        public long? ImportedDirectories { get; }
        /// <summary> Number of newly added symbolic links into the filesystem. </summary>
        public long? ImportedSymlinks { get; }
        /// <summary> Number of files that already exist in the filesystem and have not been modified. </summary>
        public long? PreexistingFiles { get; }
        /// <summary> Number of directories that already exist in the filesystem and have not been modified. </summary>
        public long? PreexistingDirectories { get; }
        /// <summary> Number of symbolic links that already exist in the filesystem and have not been modified. </summary>
        public long? PreexistingSymlinks { get; }
        /// <summary> A recent and frequently updated rate of total files, directories, and symlinks imported per second. </summary>
        public long? BlobsImportedPerSecond { get; }
        /// <summary> The time (in UTC) of the last completed import job. </summary>
        public DateTimeOffset? LastCompletionOn { get; }
        /// <summary> The time (in UTC) the latest import job started. </summary>
        public DateTimeOffset? LastStartedOn { get; }
        /// <summary> Number of errors in the import job. </summary>
        public int? TotalErrors { get; }
        /// <summary> Number of conflicts in the import job. </summary>
        public int? TotalConflicts { get; }
    }
}
