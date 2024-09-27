// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;

namespace Azure.Security.CodeTransparency
{
    /// <summary> Model factory for models. </summary>
    public static partial class SecurityCodeTransparencyModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CreateEntryResult"/>. </summary>
        /// <param name="operationId"></param>
        /// <returns> A new <see cref="CodeTransparency.CreateEntryResult"/> instance for mocking. </returns>
        public static CreateEntryResult CreateEntryResult(string operationId = null)
        {
            return new CreateEntryResult(operationId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.GetOperationResult"/>. </summary>
        /// <param name="entryId"></param>
        /// <param name="error"></param>
        /// <param name="operationId"></param>
        /// <param name="status"></param>
        /// <returns> A new <see cref="CodeTransparency.GetOperationResult"/> instance for mocking. </returns>
        public static GetOperationResult GetOperationResult(string entryId = null, string error = null, string operationId = null, OperationStatus status = default)
        {
            return new GetOperationResult(entryId, error, operationId, status, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.ListOperationResult"/>. </summary>
        /// <param name="operations"></param>
        /// <returns> A new <see cref="CodeTransparency.ListOperationResult"/> instance for mocking. </returns>
        public static ListOperationResult ListOperationResult(IEnumerable<GetOperationResult> operations = null)
        {
            operations ??= new List<GetOperationResult>();

            return new ListOperationResult(operations?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.ParametersResult"/>. </summary>
        /// <param name="serviceCertificate"></param>
        /// <param name="serviceId"></param>
        /// <param name="signatureAlgorithm"></param>
        /// <param name="treeAlgorithm"></param>
        /// <returns> A new <see cref="CodeTransparency.ParametersResult"/> instance for mocking. </returns>
        public static ParametersResult ParametersResult(string serviceCertificate = null, string serviceId = null, string signatureAlgorithm = null, string treeAlgorithm = null)
        {
            return new ParametersResult(serviceCertificate, serviceId, signatureAlgorithm, treeAlgorithm, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.DidDocument"/>. </summary>
        /// <param name="id"></param>
        /// <param name="assertionMethod"></param>
        /// <returns> A new <see cref="CodeTransparency.DidDocument"/> instance for mocking. </returns>
        public static DidDocument DidDocument(string id = null, IEnumerable<DidDocumentKey> assertionMethod = null)
        {
            assertionMethod ??= new List<DidDocumentKey>();

            return new DidDocument(id, assertionMethod?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.DidDocumentKey"/>. </summary>
        /// <param name="id"></param>
        /// <param name="controller"></param>
        /// <param name="type"></param>
        /// <param name="publicKeyJwk"></param>
        /// <returns> A new <see cref="CodeTransparency.DidDocumentKey"/> instance for mocking. </returns>
        public static DidDocumentKey DidDocumentKey(string id = null, string controller = null, DidDocumentKeyType type = default, JsonWebKey publicKeyJwk = null)
        {
            return new DidDocumentKey(id, controller, type, publicKeyJwk, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.JsonWebKey"/>. </summary>
        /// <param name="alg"></param>
        /// <param name="crv"></param>
        /// <param name="d"></param>
        /// <param name="dp"></param>
        /// <param name="dq"></param>
        /// <param name="e"></param>
        /// <param name="k"></param>
        /// <param name="kid"></param>
        /// <param name="kty"></param>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <param name="qi"></param>
        /// <param name="use"></param>
        /// <param name="x"></param>
        /// <param name="x5c"></param>
        /// <param name="y"></param>
        /// <returns> A new <see cref="CodeTransparency.JsonWebKey"/> instance for mocking. </returns>
        public static JsonWebKey JsonWebKey(string alg = null, string crv = null, string d = null, string dp = null, string dq = null, string e = null, string k = null, string kid = null, string kty = null, string n = null, string p = null, string q = null, string qi = null, string use = null, string x = null, IEnumerable<string> x5c = null, string y = null)
        {
            x5c ??= new List<string>();

            return new JsonWebKey(
                alg,
                crv,
                d,
                dp,
                dq,
                e,
                k,
                kid,
                kty,
                n,
                p,
                q,
                qi,
                use,
                x,
                x5c?.ToList(),
                y,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CodeTransparencyConfiguration"/>. </summary>
        /// <param name="policy"></param>
        /// <param name="authentication"></param>
        /// <param name="serviceIdentifier"></param>
        /// <returns> A new <see cref="CodeTransparency.CodeTransparencyConfiguration"/> instance for mocking. </returns>
        public static CodeTransparencyConfiguration CodeTransparencyConfiguration(CodeTransparencyConfigurationPolicy policy = null, CodeTransparencyConfigurationAuthentication authentication = null, string serviceIdentifier = null)
        {
            return new CodeTransparencyConfiguration(policy, authentication, serviceIdentifier, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CodeTransparencyConfigurationPolicy"/>. </summary>
        /// <param name="acceptedAlgorithms"></param>
        /// <param name="acceptedDidIssuers"></param>
        /// <returns> A new <see cref="CodeTransparency.CodeTransparencyConfigurationPolicy"/> instance for mocking. </returns>
        public static CodeTransparencyConfigurationPolicy CodeTransparencyConfigurationPolicy(IEnumerable<string> acceptedAlgorithms = null, IEnumerable<string> acceptedDidIssuers = null)
        {
            acceptedAlgorithms ??= new List<string>();
            acceptedDidIssuers ??= new List<string>();

            return new CodeTransparencyConfigurationPolicy(acceptedAlgorithms?.ToList(), acceptedDidIssuers?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CodeTransparencyConfigurationAuthentication"/>. </summary>
        /// <param name="allowUnauthenticated"></param>
        /// <param name="jwt"></param>
        /// <returns> A new <see cref="CodeTransparency.CodeTransparencyConfigurationAuthentication"/> instance for mocking. </returns>
        public static CodeTransparencyConfigurationAuthentication CodeTransparencyConfigurationAuthentication(bool allowUnauthenticated = default, CodeTransparencyConfigurationAuthenticationJwt jwt = null)
        {
            return new CodeTransparencyConfigurationAuthentication(allowUnauthenticated, jwt, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.CodeTransparencyConfigurationAuthenticationJwt"/>. </summary>
        /// <param name="requiredClaims"></param>
        /// <returns> A new <see cref="CodeTransparency.CodeTransparencyConfigurationAuthenticationJwt"/> instance for mocking. </returns>
        public static CodeTransparencyConfigurationAuthenticationJwt CodeTransparencyConfigurationAuthenticationJwt(IReadOnlyDictionary<string, string> requiredClaims = null)
        {
            requiredClaims ??= new Dictionary<string, string>();

            return new CodeTransparencyConfigurationAuthenticationJwt(requiredClaims, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CodeTransparency.VersionResult"/>. </summary>
        /// <param name="scittVersion"></param>
        /// <returns> A new <see cref="CodeTransparency.VersionResult"/> instance for mocking. </returns>
        public static VersionResult VersionResult(string scittVersion = null)
        {
            return new VersionResult(scittVersion, serializedAdditionalRawData: null);
        }
    }
}
