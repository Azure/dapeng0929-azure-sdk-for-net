// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The AsAsset. </summary>
    public partial class AsAsset : InventoryAsset
    {
        /// <summary> Initializes a new instance of AsAsset. </summary>
        internal AsAsset()
        {
            AsNames = new ChangeTrackingList<ObservedString>();
            OrgNames = new ChangeTrackingList<ObservedString>();
            OrgIds = new ChangeTrackingList<ObservedString>();
            Countries = new ChangeTrackingList<ObservedString>();
            Registries = new ChangeTrackingList<ObservedString>();
            Sources = new ChangeTrackingList<Source>();
            RegistrarCreatedAt = new ChangeTrackingList<ObservedLong>();
            RegistrarUpdatedAt = new ChangeTrackingList<ObservedLong>();
            RegistrantContacts = new ChangeTrackingList<ObservedString>();
            AdminContacts = new ChangeTrackingList<ObservedString>();
            TechnicalContacts = new ChangeTrackingList<ObservedString>();
            RegistrarNames = new ChangeTrackingList<ObservedString>();
            RegistrantNames = new ChangeTrackingList<ObservedString>();
            AdminNames = new ChangeTrackingList<ObservedString>();
            TechnicalNames = new ChangeTrackingList<ObservedString>();
            AdminOrgs = new ChangeTrackingList<ObservedString>();
            TechnicalOrgs = new ChangeTrackingList<ObservedString>();
            RegistrantPhones = new ChangeTrackingList<ObservedString>();
            AdminPhones = new ChangeTrackingList<ObservedString>();
            TechnicalPhones = new ChangeTrackingList<ObservedString>();
        }

        /// <summary> Initializes a new instance of AsAsset. </summary>
        /// <param name="asn"></param>
        /// <param name="asNames"></param>
        /// <param name="orgNames"></param>
        /// <param name="orgIds"></param>
        /// <param name="countries"></param>
        /// <param name="registries"></param>
        /// <param name="sources"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="registrarCreatedAt"></param>
        /// <param name="registrarUpdatedAt"></param>
        /// <param name="registrantContacts"></param>
        /// <param name="adminContacts"></param>
        /// <param name="technicalContacts"></param>
        /// <param name="registrarNames"></param>
        /// <param name="registrantNames"></param>
        /// <param name="adminNames"></param>
        /// <param name="technicalNames"></param>
        /// <param name="adminOrgs"></param>
        /// <param name="technicalOrgs"></param>
        /// <param name="registrantPhones"></param>
        /// <param name="adminPhones"></param>
        /// <param name="technicalPhones"></param>
        /// <param name="detailedFromWhoisAt"></param>
        internal AsAsset(long? asn, IReadOnlyList<ObservedString> asNames, IReadOnlyList<ObservedString> orgNames, IReadOnlyList<ObservedString> orgIds, IReadOnlyList<ObservedString> countries, IReadOnlyList<ObservedString> registries, IReadOnlyList<Source> sources, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, IReadOnlyList<ObservedLong> registrarCreatedAt, IReadOnlyList<ObservedLong> registrarUpdatedAt, IReadOnlyList<ObservedString> registrantContacts, IReadOnlyList<ObservedString> adminContacts, IReadOnlyList<ObservedString> technicalContacts, IReadOnlyList<ObservedString> registrarNames, IReadOnlyList<ObservedString> registrantNames, IReadOnlyList<ObservedString> adminNames, IReadOnlyList<ObservedString> technicalNames, IReadOnlyList<ObservedString> adminOrgs, IReadOnlyList<ObservedString> technicalOrgs, IReadOnlyList<ObservedString> registrantPhones, IReadOnlyList<ObservedString> adminPhones, IReadOnlyList<ObservedString> technicalPhones, DateTimeOffset? detailedFromWhoisAt)
        {
            Asn = asn;
            AsNames = asNames;
            OrgNames = orgNames;
            OrgIds = orgIds;
            Countries = countries;
            Registries = registries;
            Sources = sources;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            RegistrarCreatedAt = registrarCreatedAt;
            RegistrarUpdatedAt = registrarUpdatedAt;
            RegistrantContacts = registrantContacts;
            AdminContacts = adminContacts;
            TechnicalContacts = technicalContacts;
            RegistrarNames = registrarNames;
            RegistrantNames = registrantNames;
            AdminNames = adminNames;
            TechnicalNames = technicalNames;
            AdminOrgs = adminOrgs;
            TechnicalOrgs = technicalOrgs;
            RegistrantPhones = registrantPhones;
            AdminPhones = adminPhones;
            TechnicalPhones = technicalPhones;
            DetailedFromWhoisAt = detailedFromWhoisAt;
        }

        /// <summary> Gets the asn. </summary>
        public long? Asn { get; }
        /// <summary> Gets the as names. </summary>
        public IReadOnlyList<ObservedString> AsNames { get; }
        /// <summary> Gets the org names. </summary>
        public IReadOnlyList<ObservedString> OrgNames { get; }
        /// <summary> Gets the org ids. </summary>
        public IReadOnlyList<ObservedString> OrgIds { get; }
        /// <summary> Gets the countries. </summary>
        public IReadOnlyList<ObservedString> Countries { get; }
        /// <summary> Gets the registries. </summary>
        public IReadOnlyList<ObservedString> Registries { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<Source> Sources { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the registrar created at. </summary>
        public IReadOnlyList<ObservedLong> RegistrarCreatedAt { get; }
        /// <summary> Gets the registrar updated at. </summary>
        public IReadOnlyList<ObservedLong> RegistrarUpdatedAt { get; }
        /// <summary> Gets the registrant contacts. </summary>
        public IReadOnlyList<ObservedString> RegistrantContacts { get; }
        /// <summary> Gets the admin contacts. </summary>
        public IReadOnlyList<ObservedString> AdminContacts { get; }
        /// <summary> Gets the technical contacts. </summary>
        public IReadOnlyList<ObservedString> TechnicalContacts { get; }
        /// <summary> Gets the registrar names. </summary>
        public IReadOnlyList<ObservedString> RegistrarNames { get; }
        /// <summary> Gets the registrant names. </summary>
        public IReadOnlyList<ObservedString> RegistrantNames { get; }
        /// <summary> Gets the admin names. </summary>
        public IReadOnlyList<ObservedString> AdminNames { get; }
        /// <summary> Gets the technical names. </summary>
        public IReadOnlyList<ObservedString> TechnicalNames { get; }
        /// <summary> Gets the admin orgs. </summary>
        public IReadOnlyList<ObservedString> AdminOrgs { get; }
        /// <summary> Gets the technical orgs. </summary>
        public IReadOnlyList<ObservedString> TechnicalOrgs { get; }
        /// <summary> Gets the registrant phones. </summary>
        public IReadOnlyList<ObservedString> RegistrantPhones { get; }
        /// <summary> Gets the admin phones. </summary>
        public IReadOnlyList<ObservedString> AdminPhones { get; }
        /// <summary> Gets the technical phones. </summary>
        public IReadOnlyList<ObservedString> TechnicalPhones { get; }
        /// <summary> Gets the detailed from whois at. </summary>
        public DateTimeOffset? DetailedFromWhoisAt { get; }
    }
}
