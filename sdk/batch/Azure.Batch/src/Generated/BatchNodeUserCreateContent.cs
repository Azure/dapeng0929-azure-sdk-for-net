// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Compute.Batch
{
    /// <summary> Parameters for creating a user account for RDP or SSH access on an Azure Batch Compute Node. </summary>
    public partial class BatchNodeUserCreateContent
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

        /// <summary> Initializes a new instance of <see cref="BatchNodeUserCreateContent"/>. </summary>
        /// <param name="name"> The user name of the Account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public BatchNodeUserCreateContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeUserCreateContent"/>. </summary>
        /// <param name="name"> The user name of the Account. </param>
        /// <param name="isAdmin"> Whether the Account should be an administrator on the Compute Node. The default value is false. </param>
        /// <param name="expiryTime"> The time at which the Account should expire. If omitted, the default is 1 day from the current time. For Linux Compute Nodes, the expiryTime has a precision up to a day. </param>
        /// <param name="password"> The password of the Account. The password is required for Windows Compute Nodes (those created with 'virtualMachineConfiguration' using a Windows Image reference). For Linux Compute Nodes, the password can optionally be specified along with the sshPublicKey property. </param>
        /// <param name="sshPublicKey"> The SSH public key that can be used for remote login to the Compute Node. The public key should be compatible with OpenSSH encoding and should be base 64 encoded. This property can be specified only for Linux Compute Nodes. If this is specified for a Windows Compute Node, then the Batch service rejects the request; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNodeUserCreateContent(string name, bool? isAdmin, DateTimeOffset? expiryTime, string password, string sshPublicKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            IsAdmin = isAdmin;
            ExpiryTime = expiryTime;
            Password = password;
            SshPublicKey = sshPublicKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchNodeUserCreateContent"/> for deserialization. </summary>
        internal BatchNodeUserCreateContent()
        {
        }

        /// <summary> The user name of the Account. </summary>
        public string Name { get; }
        /// <summary> Whether the Account should be an administrator on the Compute Node. The default value is false. </summary>
        public bool? IsAdmin { get; set; }
        /// <summary> The time at which the Account should expire. If omitted, the default is 1 day from the current time. For Linux Compute Nodes, the expiryTime has a precision up to a day. </summary>
        public DateTimeOffset? ExpiryTime { get; set; }
        /// <summary> The password of the Account. The password is required for Windows Compute Nodes (those created with 'virtualMachineConfiguration' using a Windows Image reference). For Linux Compute Nodes, the password can optionally be specified along with the sshPublicKey property. </summary>
        public string Password { get; set; }
        /// <summary> The SSH public key that can be used for remote login to the Compute Node. The public key should be compatible with OpenSSH encoding and should be base 64 encoded. This property can be specified only for Linux Compute Nodes. If this is specified for a Windows Compute Node, then the Batch service rejects the request; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public string SshPublicKey { get; set; }
    }
}
